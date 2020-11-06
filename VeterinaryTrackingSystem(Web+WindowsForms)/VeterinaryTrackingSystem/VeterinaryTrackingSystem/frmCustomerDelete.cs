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
    public partial class frmCustomerDelete : DevExpress.XtraEditors.XtraForm
    {
        public frmCustomerDelete()
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
                    this.btnCustomerDelete.Visible = true;
                    
                                                       
                    
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

        private void btnCustomerDelete_Click(object sender, EventArgs e)
        {
            try
            {
                
                

                if (btnConnect.Text == "Bağlantıyı Kes" && lblSuccess.Text =="Kart Okundu!")
                {

                    CustomerDB context = new CustomerDB();
                    var Contrl = context.isCustomerAlreadyExist(lblHastaCard.Text.ToString());
                    if (Contrl != null)
                    {
                        if (XtraMessageBox.Show(Contrl.Name.TrimEnd() + " " + Contrl.Surname.TrimEnd() + " 'ın Kaydını Silme İşlemini Onaylıyor Musunuz?", "Onay Verin", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            var returnValue = context.deleteCustomerByCardID(lblHastaCard.Text);
                            MessageBox.Show(returnValue.ResultText);
                        }
                    }
                    else
                    {
                        XtraMessageBox.Show("Silmeye Çalıştığınız Kart Zaten Boş!","HATA",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    }                   
                }

                else
                {
                    XtraMessageBox.Show("Kart Okunmadı!","HATA",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
                

            }
            catch (Exception)
            {

                throw;
            }
        }

   

        private void frmCustomerDelete_Load(object sender, EventArgs e)
        {
            this.Text = "Veteriner Takip Sistemi Hasta Sahibi Silme Ekranı";
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
        private void frmCustomerDelete_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        private void frmCustomerDelete_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        private void frmCustomerDelete_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }
    }
}