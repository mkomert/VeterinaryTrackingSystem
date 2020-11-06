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
    public partial class frmPatientDelete : DevExpress.XtraEditors.XtraForm
    {
        public frmPatientDelete()
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
                    this.lstID.Items.Clear();
                    this.lblCustomerName.Text = "";
                    this.Size = new Size(326, 509);
                    this.CenterToScreen();


                    string cardID = lblHastaCard.Text;
                    CustomerDB _customerDB = new CustomerDB();
                    var message = _customerDB.mrGetCustomerByCardID(cardID);
                    var returnValue = _customerDB.Get_CustomerByCardID(cardID);
                    if (returnValue == null)
                    {
                        XtraMessageBox.Show("Karta Ait Bilgi Bulunamadı!", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        
                        this.lblSuccess.Text = "BOŞ Kart!";
                        this.lblSuccess.ForeColor = Color.Red;
                        this.Size = new Size(326, 207);
                        this.CenterToScreen();
                        lstPatients.Items.Clear();

                    }
                    else
                    {
                        this.Size = new Size(326, 509);
                        lblCustomerName.Text = returnValue.Name.TrimEnd() + " "+returnValue.Surname.TrimEnd();
                        XtraMessageBox.Show(message.ResultText, "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        var patients = _customerDB.getanimalNameByCardID(returnValue.ID);
                        if (patients.Count<1)
                        {
                            XtraMessageBox.Show("Okutulan Karta Ait Hasta Bilgisi Bulunamadı\nLütfen Başka Kart Okutun veya Hasta Kaydedin!","HATA",MessageBoxButtons.OK,MessageBoxIcon.Error);
                            this.lblSuccess.Text = "Hasta Bilgisi Bulunamadı!";
                            this.lblSuccess.ForeColor = Color.Red;
                            this.Size = new Size(292, 163);
                            this.CenterToScreen();
                        }
                        else
                        {
                            foreach (var item in patients)
                            {
                                lstPatients.Items.Add(item.Name);
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (lstID.SelectedItem != null)
                {
                    if (XtraMessageBox.Show(lblCustomerName.Text +" 'a Ait "+lstPatients.SelectedItem.ToString().TrimEnd()+" Hastasını Silmek İstiyor Musunuz?", "Onay Verin", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        PatientDB pDB = new PatientDB();
                        CustomerDB _customerDB = new CustomerDB();
                        var returnValue = pDB.mrdeletePatient(Convert.ToInt32(lstID.SelectedItem));
                        XtraMessageBox.Show(returnValue.ResultText, "Başarılı!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        lstPatients.Items.Clear();
                        lstID.Items.Clear();
                        var asd = _customerDB.Get_CustomerByCardID(lblHastaCard.Text);
                        var patients = _customerDB.getanimalNameByCardID(asd.ID);
                        foreach (var item in patients)
                        {
                            lstPatients.Items.Add(item.Name);
                            lstID.Items.Add(item.ID);

                        }
                    }

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

        private void lstPatients_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstID.SelectedIndex = lstPatients.SelectedIndex;
        }


        private void frmPatientDelete_Load(object sender, EventArgs e)
        {
            this.Text = "Veteriner Takip Sistemi Hasta Silme Ekranı";
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
        private void frmPatientDelete_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        private void frmPatientDelete_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        private void frmPatientDelete_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }
    }
}