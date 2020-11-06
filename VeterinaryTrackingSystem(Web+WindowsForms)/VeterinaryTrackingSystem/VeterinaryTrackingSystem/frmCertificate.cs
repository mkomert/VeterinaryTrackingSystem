using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.IO.Ports;
using System.Management;
using DataLayer.DataLayer;

namespace VeterinaryTrackingSystem
{
    public partial class frmCertificate : DevExpress.XtraEditors.XtraForm
    {
        public frmCertificate()
        {
            InitializeComponent();
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {
        }

        private void navBarItem1_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            try
            {
                if (cmbPatients.Properties.Items.Count > 0)
                {


                    panelControl5.Location = new Point(458, 578);
                    pictureBox2.Visible = false;
                    cmbVaccines.Properties.Items.Clear();
                    cmbVaccines.Text = null;
                    dateTimeVaccine.Text = null;
                    lstVaccineID.Items.Clear();
                    pnlVaccination.Enabled = true;
                    pnlVaccination.Visible = true;
                    pnlOperation.Enabled = false;
                    pnlOperation.Visible = true;

                    VaccinesDB vDB = new VaccinesDB();
                    var result = vDB.getVaccine();
                    foreach (var item in result)
                    {
                        cmbVaccines.Properties.Items.Add(item.vaccineName.TrimEnd());
                        lstVaccineID.Items.Add(item.ID);

                    }
                    if (result.Count < 1)
                    {
                        XtraMessageBox.Show("Aşı Kaydı Yok!", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }

                }
                else
                {
                    XtraMessageBox.Show("Bir Kart Okutup Hasta Seçin!", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
            catch (Exception)
            {

                throw;
            }
        }

        private void navBarItem2_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            try
            {
                if (cmbPatients.Properties.Items.Count > 0)
                {
                    lstOperationID.Items.Clear();
                    cmbOperations.Properties.Items.Clear();
                    cmbOperations.Text = null;
                    dateTimeOperation.Text = null;
                    pnlVaccination.Visible = true;
                    pnlOperation.Visible = true;
                    pnlVaccination.Enabled = false;
                    pnlOperation.Enabled = true;

                    OperationDB oDB = new OperationDB();
                    var result = oDB.getOperation();
                    foreach (var item in result)
                    {
                        cmbOperations.Properties.Items.Add(item.operationName.TrimEnd());
                        lstOperationID.Items.Add(item.ID);
                    }
                    if (result.Count < 1)
                    {
                        XtraMessageBox.Show("Operasyon Kaydı Yok!", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
                else
                {
                    XtraMessageBox.Show("Bir Kart Okutup Hasta Seçin!", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception)
            {

                throw;
            }
        }
        string returnValue;
        private void btnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                using (var searcher = new ManagementObjectSearcher("SELECT * FROM Win32_PnPEntity WHERE Caption like '%(COM%'"))
                {
                    var portnames = SerialPort.GetPortNames();
                    var ports = searcher.Get().Cast<ManagementBaseObject>().ToList().Select(p => p["Caption"].ToString());
                    var portList = portnames.Select(n => n + " - " + ports.FirstOrDefault(s => s.Contains(n))).ToList();
                    List<string> deviceNames = new List<string>();
                    foreach (string s in portList)
                    {
                        deviceNames.Add(s);
                    }
                    foreach (string item in deviceNames)
                    {
                        if (item.Contains("CH340"))
                            returnValue = (item[0].ToString() + item[1].ToString() + item[2].ToString() + item[3].ToString());
                    }




                }
                if (serialPort1.IsOpen == false)
                {
                    serialPort1.PortName = returnValue;
                    serialPort1.BaudRate = 9600;
                    serialPort1.Open();
                    btnConnect.Text = "Bağlantıyı Kes";

                    timerSerialPort.Enabled = true;
                }
                else
                {
                    timerSerialPort.Enabled = false;
                    serialPort1.Close();
                    btnConnect.Text = "Bağlan";
                }
            }
            catch
            {
                MessageBox.Show("Bağlantı açılamadı!");
            }
        }
        delegate void GelenVerileriGuncelleCallback(string veri);
        private void GelenVerileriGuncelle(string veri)
        {
            try
            {
                if (this.lblHastaCard.InvokeRequired)
                {
                    GelenVerileriGuncelleCallback d = new GelenVerileriGuncelleCallback(GelenVerileriGuncelle);
                    this.Invoke(d, new object[] { veri });
                }
                else
                {
                    this.lblHastaCard.Text = (InnerTrim(veri));
                    this.lblSuccess.Text = "Kart Okundu!";
                    this.lblSuccess.ForeColor = Color.GreenYellow;
                    this.cmbPatients.Properties.Items.Clear();
                    this.lstID.Items.Clear();
                    this.lblCustomerName.Text = "";



                    string cardID = lblHastaCard.Text;
                    CustomerDB _customerDB = new CustomerDB();
                    var message = _customerDB.mrGetCustomerByCardID(cardID);
                    var returnValue = _customerDB.Get_CustomerByCardID(cardID);
                    if (returnValue == null)
                    {
                        XtraMessageBox.Show("Karta Ait Bilgi Bulunamadı!", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        this.lblSuccess.Text = "BOŞ Kart!";
                        this.lblSuccess.ForeColor = Color.Red;

                        cmbPatients.Properties.Items.Clear();

                    }
                    else
                    {
                        
                        lblCustomerName.Text = "Hoşgeldiniz!\n"+returnValue.Name.TrimEnd() + " " + returnValue.Surname.TrimEnd();
                        XtraMessageBox.Show(message.ResultText, "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        var patients = _customerDB.getanimalNameByCardID(returnValue.ID);
                        if (patients.Count < 1)
                        {
                            XtraMessageBox.Show("Okutulan Karta Ait Hasta Bilgisi Bulunamadı\nLütfen Başka Kart Okutun veya Hasta Kaydedin!", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            this.lblSuccess.Text = "Hasta Bilgisi Bulunamadı!";
                            this.lblSuccess.ForeColor = Color.Red;

                        }
                        else
                        {
                            foreach (var item in patients)
                            {
                                cmbPatients.Properties.Items.Add(item.Name.TrimEnd());
                                lstID.Items.Add(item.ID);

                            }
                        }


                    }

                }
            }
            catch (Exception)
            {

                throw;
            }

        }
        public static string InnerTrim(string input)
        {
            return input.Trim().Replace(" ", string.Empty);
        }
        private void timerSerialPort_Tick(object sender, EventArgs e)
        {
            if (serialPort1.BytesToRead > 0)
            {
                GelenVerileriGuncelle(serialPort1.ReadExisting());

            }
        }

        private void cmbPatients_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstID.SelectedIndex = cmbPatients.SelectedIndex;
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            if (cmbPatients.Properties.Items.Count>0)
            {
                groupControl1.Text = cmbPatients.SelectedItem.ToString() + "'in Karnesi";
            }
            else
            {
                XtraMessageBox.Show("Seçilecek Hasta Yok!", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }




        private void cmbVaccines_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstVaccineID.SelectedIndex = cmbVaccines.SelectedIndex;
        }

        private void cmbOperations_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstOperationID.SelectedIndex = cmbOperations.SelectedIndex;
        }

        private void btnVaccineSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbVaccines.SelectedItem == null || dateTimeVaccine.Text == "")
                {
                    XtraMessageBox.Show("Eksiksiz Bilgi Doldurun!", "HATA!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    CertificateDB cdb = new CertificateDB();
                    var result = cdb.mrvacCertificationSave(Convert.ToInt32(lstID.SelectedItem), Convert.ToInt32(lstVaccineID.SelectedItem), Convert.ToDateTime(dateTimeVaccine.DateTime.Date.ToShortDateString()));
                    if (result.ResultText == "Hasta Karnesine Aşı Kaydedildi!")
                    {
                        XtraMessageBox.Show(result.ResultText, "BAŞARILI!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        cmbVaccines.Text = null;
                        dateTimeVaccine.Text = null;

                    }
                    else
                    {
                        XtraMessageBox.Show("KAYIT SIRASINDA HATA!", "HATA!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnOperationSave_Click(object sender, EventArgs e)
        {
            try
            {

                if (cmbOperations.SelectedItem == null || dateTimeOperation.Text == "")
                {
                    XtraMessageBox.Show("Eksiksiz Bilgi Doldurun!", "HATA!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    CertificateDB cDB = new CertificateDB();
                    var result = cDB.mrOperationCertificateSave(Convert.ToInt32(lstID.SelectedItem), Convert.ToInt32(lstOperationID.SelectedItem), dateTimeOperation.DateTime.Date);
                    if (result.ResultText == "Operasyon Hastanın Karnesine Kaydedildi!")
                    {
                        XtraMessageBox.Show(result.ResultText, "BAŞARILI!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        dateTimeOperation.Text = null;
                        cmbOperations.Text = null;
                    }
                    else
                    {
                        XtraMessageBox.Show("Operasyon Kayıt Sırasında HATA!", "HATA!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            serialPort1.Close();
            this.Close();
        }
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;
        private void frmCertificate_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        private void frmCertificate_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;

        }

        private void frmCertificate_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }
    }
}