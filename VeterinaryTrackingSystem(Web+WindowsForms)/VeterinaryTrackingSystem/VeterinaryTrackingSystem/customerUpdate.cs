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
using System.Management;
using System.IO.Ports;

namespace VeterinaryTrackingSystem
{
    public partial class customerUpdate : DevExpress.XtraEditors.XtraForm
    {
        public customerUpdate()
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


                    string cardID = lblHastaCard.Text;
                    CustomerDB _customerDB = new CustomerDB();
                    var message = _customerDB.mrGetCustomerByCardID(cardID);
                    var returnValue = _customerDB.Get_CustomerByCardID(cardID);
                    if (returnValue == null)
                    {
                        XtraMessageBox.Show("Karta Ait Bilgi Bulunamadı!", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.Size = new Size(362, 223);
                        this.lblSuccess.Text = "BOŞ Kart!";
                        this.lblSuccess.ForeColor = Color.Red;

                    }
                    else
                    {
                        this.Size = new Size(362, 608);
                        this.CenterToScreen();
                        txtCustomerName.Text = returnValue.Name.TrimEnd();
                        txtCustomerSurname.Text = returnValue.Surname.TrimEnd();
                        txtCustomerPhone.Text = returnValue.Phone.TrimEnd();
                        txtAddress.Text = returnValue.Address.TrimEnd();
                        XtraMessageBox.Show(message.ResultText, "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                bool _gender;
                CustomerDB context = new CustomerDB();
                if (comboBoxEdit1.Text == "Erkek")
                {
                    _gender = true;
                }
                else
                {
                    _gender = false;
                }
                
                var returnValue = context.MrUpdateCustomer(lblHastaCard.Text, txtCustomerName.Text,txtCustomerSurname.Text,txtCustomerPhone.Text,_gender,txtAddress.Text);
                XtraMessageBox.Show(returnValue.ResultText, "Başarılı!", MessageBoxButtons.OK);
                this.Size = new Size(362, 223);
                this.lblSuccess.Text = "Kart Okunmadı!";
                this.lblSuccess.ForeColor = Color.Red;
                this.lblHastaCard.Text = "";
            }
            catch (Exception)
            {

                MessageBox.Show("Bilinmeyen Hata!");
            }
        }
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;
        private void customerUpdate_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        private void customerUpdate_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        private void customerUpdate_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void customerUpdate_Load(object sender, EventArgs e)
        {
            this.Text = "Veteriner Takip Sistemi Hasta Sahibi Güncelleme Ekranı";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.serialPort1.Close();
            this.Close();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}