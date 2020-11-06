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
using System.Management;
using System.IO.Ports;
using DataLayer.DataLayer;
using DataLayer;

namespace VeterinaryTrackingSystem
{
    public partial class frmCertificateShow : DevExpress.XtraEditors.XtraForm
    {
        public frmCertificateShow()
        {
            InitializeComponent();
        }

        private void windowsUIButtonPanel1_Click(object sender, EventArgs e)
        {

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
                    this.lblName.Text = "";
                    this.lblKind.Text = "";
                    this.lblBreed.Text = "";
                    this.lblAge.Text = "";
                    this.lstID.Items.Clear();
                    this.lstOPID.Items.Clear();
                    this.LstvaccineCert.Items.Clear();
                    this.lstVaccines.Items.Clear();
                    this.lstOperations.Items.Clear();
                    this.cmbPatients.Properties.Items.Clear();
                    this.cmbPatients.Text = "";
                    
                    this.CenterToScreen();



                    string cardID = lblHastaCard.Text;
                    CustomerDB _customerDB = new CustomerDB();
                    var message = _customerDB.mrGetCustomerByCardID(cardID);
                    var returnValue = _customerDB.Get_CustomerByCardID(cardID);
                    if (returnValue == null)
                    {
                        this.Size = new Size(301, 142);
                        this.CenterToScreen();
                        XtraMessageBox.Show("Karta Ait Bilgi Bulunamadı!", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        this.lblSuccess.Text = "BOŞ Kart!";
                        this.lblSuccess.ForeColor = Color.Red;
                        
                        cmbPatients.Properties.Items.Clear();

                    }
                    else
                    {
                        this.Size = new Size(749, 140);
                        this.CenterToScreen();
                        lblCustomerName.Text = "Hoşgeldiniz!\n" + returnValue.Name.TrimEnd() + " " + returnValue.Surname.TrimEnd();
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

        private void btnShow_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbPatients.Properties.Items.Count < 1 && cmbPatients.Text == "")
                {
                    XtraMessageBox.Show("Lütfen Geçerli Bir Kart Okutun!", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (cmbPatients.Text == "")
                {
                    XtraMessageBox.Show("Lütfen Bir Hasta Seçin!", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    this.groupControl5.Text = cmbPatients.SelectedItem + " - " +"Karnesi";
                    this.Size = new Size(751, 561);
                    this.CenterToScreen();
                    lblVaccineDate.Text = "";
                    lblOpDate.Text = "";
                    lstOPID.Items.Clear();
                    lstOperations.Items.Clear();
                    LstvaccineCert.Items.Clear();
                    lstVaccines.Items.Clear();
                    PatientDB pDB = new PatientDB();
                    var info = pDB.getAnimalByID(Convert.ToInt32(lstID.SelectedItem));
                    lblName.Text = info.Name;
                    lblBreed.Text = info.Breed;
                    lblKind.Text = info.Kind;
                    lblAge.Text = (Convert.ToInt32(DateTime.Now.Year) - info.Age).ToString();
                    CertificateDB cDB = new CertificateDB();

                    var asd = cDB.getVaccinationInfo(Convert.ToInt32(lstID.SelectedItem));
                    VaccinesDB vDB = new VaccinesDB();


                    foreach (var item in asd)
                    {
                        LstvaccineCert.Items.Add(item.ID);
                        var qwe = vDB.getVaccineNameByID(Convert.ToInt32(item.VaccinesID));
                        lstVaccines.Items.Add(qwe.vaccineName);

                    }

                    OperationDB oDB = new OperationDB();
                    var opReturn = cDB.getOPCertificateByAnimalID(Convert.ToInt32(lstID.SelectedItem));
                    foreach (var item in opReturn)
                    {
                        lstOPID.Items.Add(item.ID);
                        var gelen = oDB.getOpNameByID(Convert.ToInt32(item.OperationsID));
                        lstOperations.Items.Add(gelen.operationName);

                    }

                    if (lstVaccines.Items.Count > 0)
                    {
                        labelControl7.Visible = true;
                        lblVaccineDate.Visible = true;
                    }
                    else
                    {
                        labelControl7.Visible = false;
                        lblVaccineDate.Visible = false;
                    }
                    if (lstOperations.Items.Count > 0)
                    {
                        lblOpDate.Visible = true;
                        labelControl18.Visible = true;
                    }
                    else
                    {
                        lblOpDate.Visible = false;
                        labelControl18.Visible = false;
                    }



                }

            }
            catch (Exception)
            {

                throw;
            }
        }

        private void lstVaccines_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                
                if (LstvaccineCert.Items.Count>0)
                {
                    LstvaccineCert.SelectedIndex = lstVaccines.SelectedIndex;
                    CertificateDB cDB = new CertificateDB();
                    var retValue = cDB.getCertificateDate(Convert.ToInt32(LstvaccineCert.SelectedItem));
                    lblVaccineDate.Text = Convert.ToDateTime(retValue.Date).ToShortDateString().ToString();
                }
                
            }
            catch (Exception)
            {

                throw;
            }
            
        }

        private void btnSearcher_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtYear.Text.Length < 4 || txtYear.Text.Length > 4)
                {
                    XtraMessageBox.Show("Lütfen 4 Haneli Bir Yıl Araması Yapın!", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if(cmbPatients.Text == "")
                {
                    XtraMessageBox.Show("Lütfen Bir Hasta Seçin!", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    lstSearchByDate.Items.Clear();
                    CertificateDB cDB = new CertificateDB();
                    var asd = cDB.getCertByDate(Convert.ToInt32(txtYear.Text), Convert.ToInt32(lstID.Text));
                    VaccinesDB vDB = new VaccinesDB();
                    foreach (var item in asd)
                    {
                        var qwe = vDB.getVaccineNameByID(Convert.ToInt32(item.VaccinesID));
                        lstSearchByDate.Items.Add(qwe.vaccineName);

                    }
                    if (lstSearchByDate.Items.Count < 1)
                    {
                        XtraMessageBox.Show("Aranan Tarihe Göre Kayıt Bulunamadı!", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void frmCertificateShow_Load(object sender, EventArgs e)
        {
            try
            {
                
            }
            catch (Exception)
            {

                throw;
            }
        }
        string Month;
        private void btnSearchByMonth_Click(object sender, EventArgs e)
        {

            if (cmbMonth.Text != "" && txtYear.Text!="" && cmbPatients.Text != "")
            {


                if (cmbMonth.Text == "Ocak")
                {
                    Month = "01";
                }

                else if (cmbMonth.Text == "Şubat")
                {
                    Month = "02";
                }
                else if (cmbMonth.Text == "Mart")
                {
                    Month = "03";
                }
                else if (cmbMonth.Text == "Nisan")
                {
                    Month = "04";
                }
                else if (cmbMonth.Text == "Mayıs")
                {
                    Month = "05";
                }
                else if (cmbMonth.Text == "Haziran")
                {
                    Month = "06";
                }
                else if (cmbMonth.Text == "Temmuz")
                {
                    Month = "07";
                }
                else if (cmbMonth.Text == "Ağustos")
                {
                    Month = "08";
                }
                else if (cmbMonth.Text == "Eylül")
                {
                    Month = "09";
                }
                else if (cmbMonth.Text == "Ekim")
                {
                    Month = "10";
                }
                else if (cmbMonth.Text == "Kasım")
                {
                    Month = "11";
                }
                else if (cmbMonth.Text == "Aralık")
                {
                    Month = "12";
                }


                lstSearchByMonth.Items.Clear();
                CertificateDB cDB = new CertificateDB();
                var asd = cDB.getCertByMonth(Month,Convert.ToInt32(lstID.SelectedItem),Convert.ToInt32(txtYear.Text));
                VaccinesDB vDB = new VaccinesDB();
                foreach (var item in asd)
                {
                    var qwe = vDB.getVaccineNameByID(Convert.ToInt32(item.VaccinesID));
                    lstSearchByMonth.Items.Add(qwe.vaccineName);

                }



                if (lstSearchByMonth.Items.Count < 1)
                {
                    XtraMessageBox.Show("Aranan Tarihe Göre Kayıt Bulunamadı!", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
            else
            {
                XtraMessageBox.Show("Lütfen Tarih ve Ay Seçin!", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            

        }

        private void lstOperations_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (lstOperations.Items.Count > 0)
                {
                    lstOPID.SelectedIndex = lstOperations.SelectedIndex;
                    CertificateDB cDB = new CertificateDB();
                    var retValue = cDB.getOPCertificateDate(Convert.ToInt32(lstOPID.SelectedItem));
                    lblOpDate.Text = Convert.ToDateTime(retValue.Date).ToShortDateString().ToString();
                }
            }
            catch (Exception)
            {

                throw;
            }
            
        }

        private void btnOPyear_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtopYear.Text.Length < 4 || txtopYear.Text.Length > 4)
                {
                    XtraMessageBox.Show("Lütfen 4 Haneli Bir Yıl Araması Yapın!", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (cmbPatients.Text == "")
                {
                    XtraMessageBox.Show("Lütfen Bir Hasta Seçin!", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    lstopYear.Items.Clear();
                    CertificateDB cDB = new CertificateDB();
                    var asd = cDB.getOpCertByYear(Convert.ToInt32(txtopYear.Text), Convert.ToInt32(lstID.Text));
                    OperationDB oDB = new OperationDB();
                    foreach (var item in asd)
                    {
                        var qwe = oDB.getOpNameByID(Convert.ToInt32(item.OperationsID));
                        lstopYear.Items.Add(qwe.operationName);

                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnOPmonth_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbOpMonth.Text != "" && txtopYear.Text != "" && cmbPatients.Text != "")
                {


                    if (cmbOpMonth.Text == "Ocak")
                    {
                        Month = "01";
                    }

                    else if (cmbOpMonth.Text == "Şubat")
                    {
                        Month = "02";
                    }
                    else if (cmbOpMonth.Text == "Mart")
                    {
                        Month = "03";
                    }
                    else if (cmbOpMonth.Text == "Nisan")
                    {
                        Month = "04";
                    }
                    else if (cmbOpMonth.Text == "Mayıs")
                    {
                        Month = "05";
                    }
                    else if (cmbOpMonth.Text == "Haziran")
                    {
                        Month = "06";
                    }
                    else if (cmbOpMonth.Text == "Temmuz")
                    {
                        Month = "07";
                    }
                    else if (cmbOpMonth.Text == "Ağustos")
                    {
                        Month = "08";
                    }
                    else if (cmbOpMonth.Text == "Eylül")
                    {
                        Month = "09";
                    }
                    else if (cmbOpMonth.Text == "Ekim")
                    {
                        Month = "10";
                    }
                    else if (cmbOpMonth.Text == "Kasım")
                    {
                        Month = "11";
                    }
                    else if (cmbOpMonth.Text == "Aralık")
                    {
                        Month = "12";
                    }


                    lstOpMonth.Items.Clear();
                    CertificateDB cDB = new CertificateDB();
                    var asd = cDB.getOpCertByMonth(Month,Convert.ToInt32(lstID.SelectedItem),Convert.ToInt32(txtopYear.Text));
                    OperationDB oDB = new OperationDB();
                    foreach (var item in asd)
                    {
                        var qwe = oDB.getOpNameByID(Convert.ToInt32(item.OperationsID));
                        lstOpMonth.Items.Add(qwe.operationName);

                    }






                }
                else
                {
                    XtraMessageBox.Show("Lütfen Tarih ve Ay Seçin!", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            groupControl1.Location = new Point(4, 165);
            groupControl2.Location = new Point(604, 562);
        }

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupControl1_CustomButtonClick(object sender, DevExpress.XtraBars.Docking2010.BaseButtonEventArgs e)
        {
            groupControl1.Location = new Point(303, 562); 
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            groupControl1.Location = new Point(303, 562);
            groupControl2.Location = new Point(4, 165);
            
        }

        private void groupControl2_CustomButtonClick(object sender, DevExpress.XtraBars.Docking2010.BaseButtonEventArgs e)
        {
            groupControl2.Location = new Point(604, 562);
        }


        private void btnVaccineDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (LstvaccineCert.Items.Count>0)
                {


                    if (XtraMessageBox.Show("Silme İşlemini Onaylıyor Musunuz?", "Onay Verin", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        if (LstvaccineCert.Items.Count > 0)
                        {
                            CertificateDB cDB = new CertificateDB();
                            var context = cDB.mrDeleteVaccineCertByID(Convert.ToInt32(LstvaccineCert.SelectedItem));
                            if (context.ResultText == "Karneden Aşı Silme İşlemi Başarılı!")
                            {
                                XtraMessageBox.Show(context.ResultText, "Başarılı!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                btnShow_Click(sender, e);
                            }
                            else
                            {
                                XtraMessageBox.Show(context.ResultText, "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }

                        }
                    }
                }

                else
                {
                    XtraMessageBox.Show("Silinecek Aşı Bilgisi Yok!", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnOpDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (lstOPID.Items.Count > 0)
                {


                    if (XtraMessageBox.Show("Silme İşlemini Onaylıyor Musunuz?", "Onay Verin", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        if (lstOperations.Items.Count > 0)
                        {
                            CertificateDB cDB = new CertificateDB();
                            var context = cDB.mrdeleteOpCertByID(Convert.ToInt32(lstOPID.SelectedItem));
                            if (context.ResultText == "Karneden Operasyon Silme İşlemi Başarılı!")
                            {
                                XtraMessageBox.Show(context.ResultText, "Başarılı!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                btnShow_Click(sender, e);
                            }
                            else
                            {
                                XtraMessageBox.Show(context.ResultText, "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }

                        }
                    }
                }
                else
                {
                    XtraMessageBox.Show("Silinecek Operasyon Bilgisi Yok!", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void txtYear_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtopYear_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;
        private void frmCertificateShow_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }

        }

        private void frmCertificateShow_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void frmCertificateShow_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }
    }
}