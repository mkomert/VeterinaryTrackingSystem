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
using DataLayer;
using DataLayer.DataLayer;
using Helper;
using System.Management;
using System.IO.Ports;

namespace VeterinaryTrackingSystem
{
    public partial class frmAnimal : DevExpress.XtraEditors.XtraForm
    {
        public frmAnimal()
        {
            InitializeComponent();
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
                    
                    
                        string cardID = lblHastaCard.Text;
                        CustomerDB _customerDB = new CustomerDB();
                        var message = _customerDB.mrGetCustomerByCardID(cardID);
                        var returnValue = _customerDB.Get_CustomerByCardID(cardID);
                    if (returnValue == null)
                    {
                        XtraMessageBox.Show("Karta Ait Bilgi Bulunamadı!", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.Size = new Size(351, 193);
                        this.lblSuccess.Text = "BOŞ Kart!";
                        this.lblSuccess.ForeColor = Color.Red;
                        lstPatients.Items.Clear();

                    }
                    else
                    {
                        this.Size = new Size(351, 439);
                        this.CenterToScreen();
                        lblCustomerName.Text = returnValue.Name;
                        lblCustomerSurname.Text = returnValue.Surname;
                        XtraMessageBox.Show(message.ResultText, "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        var patients = _customerDB.getanimalNameByCardID(returnValue.ID);
                        foreach (var item in patients)
                        {
                            lstPatients.Items.Add(item.Name);
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

        private void panelControl2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelControl3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            this.Size = new Size(351, 681);
            this.CenterToScreen();
        }



        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtPatientAge.Text.Length < 4)
                {
                    XtraMessageBox.Show("Doğum Yılı En Az 4 Haneli Olmalıdır!", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    PatientDB pDB = new PatientDB();
                    CustomerDB cDB = new CustomerDB();
                    var result = cDB.Get_CustomerByCardID(lblHastaCard.Text);
                    var returnValue_1 = cDB.Get_CustomerByCardID(lblHastaCard.Text);
                    if (result != null)
                    {
                        if (txtPatientName.Text == "" || txtPatientBreed.Text == "" || txtPatientKind.Text == "" || txtPatientAge.Text == "")
                        {
                            XtraMessageBox.Show("Lütfen Boş Alan Bırakmayın!", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            var returnValue = pDB.mrSavePatient(result.ID, txtPatientName.Text, txtPatientBreed.Text, Convert.ToInt32(txtPatientAge.Text), txtPatientKind.Text);
                            XtraMessageBox.Show(returnValue.ResultText, "Hasta Kayıt Başarılı!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            var patients = cDB.getanimalNameByCardID(returnValue_1.ID);
                            lstPatients.Items.Clear();
                            foreach (var item in patients)
                            {
                                lstPatients.Items.Add(item.Name);
                            }
                            txtPatientAge.Text = "";
                            txtPatientBreed.Text = "";
                            txtPatientName.Text = "";
                            txtPatientKind.Text = "";


                        }
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
            

            
            
        }

        private void frmAnimal_Load(object sender, EventArgs e)
        {
            this.Text = "Veteriner Takip Sistemi Hasta Ekleme Ekranı";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.serialPort1.Close();
            this.Close();
        }

        private void txtPatientAge_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;
        private void frmAnimal_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        private void frmAnimal_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void frmAnimal_MouseDown(object sender, MouseEventArgs e)
        {
            
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }
    }
}