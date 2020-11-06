using DataLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DataLayer.DataLayer;
using DevExpress.XtraEditors;
using System.Management;
using System.IO.Ports;

namespace VeterinaryTrackingSystem
{
    public partial class frmCustomer : DevExpress.XtraEditors.XtraForm
    {
        public frmCustomer()
        {
            InitializeComponent();
        }
        delegate void GelenVerileriGuncelleCallback(string veri);
        private void GelenVerileriGuncelle(string veri)
        {
            if (this.labelControl11.InvokeRequired)
            {
                GelenVerileriGuncelleCallback d = new GelenVerileriGuncelleCallback(GelenVerileriGuncelle);
                this.Invoke(d, new object[] { veri });
            }
            else
            {
                this.labelControl11.Text= (InnerTrim(veri));
                if (this.labelControl11.Text != "")
                {
                    this.lblState.ForeColor = Color.Green;
                    this.lblState.Text = "Kart Okuma Başarılı!";
                    this.labelControl12.Text = "Kart No:";
                }
                else
                {
                    this.lblState.ForeColor = Color.Red;
                    this.lblState.Text = "Kart Okunmadı!";
                }

                
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                CustomerDB cdb = new CustomerDB();
                var Contrl =cdb.isCustomerAlreadyExist(labelControl11.Text.ToString());

                if (Contrl == null)
                {

                    if (txtCustomerName.Text == "" || txtCustomerPhone.Text.Length < 11 || txtCustomerSurname.Text == "" || txtAddress.Text == "" || comboBoxEdit1.SelectedItem == null)
                    {
                        XtraMessageBox.Show("Lütfen tüm alanları eksiksiz doldurun!", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        if (labelControl11.Text=="")
                        {
                            XtraMessageBox.Show("Lütfen Bir Kart Okutup Seçin!", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            Customer _cstmr = new Customer();
                            _cstmr.Name = txtCustomerName.Text;
                            _cstmr.Surname = txtCustomerSurname.Text;
                            _cstmr.Phone = txtCustomerPhone.Text;
                            bool _gender;
                            if (comboBoxEdit1.Text == "Erkek")
                            {
                                _gender = true;
                            }
                            else
                            {
                                _gender = false;
                            }
                            _cstmr.Gender = _gender;
                            _cstmr.CardID = labelControl11.Text.ToString();
                            _cstmr.Address = txtAddress.Text;

                            var returnResult = cdb.CustomerAddForWF(_cstmr);
                            XtraMessageBox.Show(returnResult.ResultText,"Kayıt Başarılı!",MessageBoxButtons.OK,MessageBoxIcon.Information);
                            if (returnResult.ResultText == "Hasta sahibi başarı ile kaydedildi!")
                            {
                                txtCustomerName.Text = "";
                                txtCustomerSurname.Text = "";
                                txtCustomerPhone.Text = "";
                                labelControl11.Text = "";
                                txtAddress.Text = "";
                                lblState.Text = "";
                                labelControl12.Text = "";
                                labelControl11.Text = "";
                                comboBoxEdit1.Text = "";

                            }
                        }
                    }
                }
                else
                {
                    XtraMessageBox.Show("Bu Kart "+Contrl.Name.TrimEnd()+" "+Contrl.Surname.TrimEnd()+" İsimli Kullanıcıya Ait!", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.lblState.ForeColor = Color.Red;
                    this.lblState.Text = "Geçersiz Kart!";
                }
            }
            catch (Exception)
            {

                throw;
            }
            
        }

     

        private void frmCustomer_Load(object sender, EventArgs e)
        {
            this.Text = "Veteriner Takip Sistemi Hasta Sahibi Ekleme Ekranı";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            serialPort1.Close();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void txtCustomerPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;
        private void frmCustomer_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        private void frmCustomer_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;

        }

        private void frmCustomer_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }
    }
}
