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
using DataLayer.DataLayer;
using System.IO.Ports;
using System.Management;

namespace VeterinaryTrackingSystem
{
    public partial class frmPatientUpdate : DevExpress.XtraEditors.XtraForm
    {
        public frmPatientUpdate()
        {
            InitializeComponent();
        }

        private void textEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void frmPatientUpdate_Load(object sender, EventArgs e)
        {
            this.Text = "Veteriner Takip Sistemi Hasta Güncelleme Ekranı";

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
                    this.lstPatients.Items.Clear();
                    this.lstID.Items.Clear();
                    this.lblCustomerName.Text = "";
                    
                    


                    string cardID = lblHastaCard.Text;
                    CustomerDB _customerDB = new CustomerDB();
                    var message = _customerDB.mrGetCustomerByCardID(cardID);
                    var returnValue = _customerDB.Get_CustomerByCardID(cardID);
                    if (returnValue == null)
                    {
                        this.Size = new Size(304, 176);
                        this.CenterToScreen();
                        XtraMessageBox.Show("Karta Ait Bilgi Bulunamadı!", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.lblSuccess.Text = "BOŞ Kart!";
                        this.lblSuccess.ForeColor = Color.Red;
                        
                        lstPatients.Items.Clear();

                    }
                    else
                    {
                        this.Size = new Size(304, 665);
                        this.CenterToScreen();
                        lblCustomerName.Text = returnValue.Name.TrimEnd() + " " + returnValue.Surname.TrimEnd();
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
                                lstPatients.Items.Add(item.Name.TrimEnd());
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

        private void lstPatients_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstID.SelectedIndex = lstPatients.SelectedIndex;
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

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            serialPort1.Close();
        }

        private void btnChoose_Click(object sender, EventArgs e)
        {
            if (lstPatients.SelectedItem !=null)
            {
                panelControl3.Enabled = true;
            }
            else
            {
                XtraMessageBox.Show("Hasta Seçilmedi!", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtPatientName.Text == "" || txtPatientKind.Text == "" || txtPatientAge.Text == "" || txtPatientBreed.Text == "" || txtPatientKind.Text == "")
                {
                    XtraMessageBox.Show("Boş Alan Bırakmadan Tekrar Deneyin!", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    CustomerDB _customerDB = new CustomerDB();
                    PatientDB _pDB = new PatientDB();
                    var returnValue = _pDB.mrupdatePatient(Convert.ToInt32(lstID.SelectedItem), txtPatientName.Text, txtPatientBreed.Text, txtPatientKind.Text, Convert.ToInt32(txtPatientAge.Text));
                    XtraMessageBox.Show(returnValue.ResultText, "Başarılı!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    lstPatients.Items.Clear();
                    var asd = _customerDB.Get_CustomerByCardID(lblHastaCard.Text);
                    var patients = _customerDB.getanimalNameByCardID(asd.ID);
                    foreach (var item in patients)
                    {
                        lstPatients.Items.Add(item.Name);
                        lstID.Items.Add(item.ID);

                    }


                }
            }
            catch (Exception)
            {

                throw;
            }
            


        }

        private void txtPatientAge_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            serialPort1.Close();
            this.Close();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;
        private void frmPatientUpdate_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;

        }

        private void frmPatientUpdate_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }

        }

        private void frmPatientUpdate_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }
    }
}