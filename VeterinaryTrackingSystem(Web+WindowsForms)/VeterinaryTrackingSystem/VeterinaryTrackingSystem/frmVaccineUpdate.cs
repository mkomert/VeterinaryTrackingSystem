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

namespace VeterinaryTrackingSystem
{
    public partial class frmVaccineUpdate : DevExpress.XtraEditors.XtraForm
    {
        public frmVaccineUpdate()
        {
            InitializeComponent();
        }

        private void frmVaccineUpdate_Load(object sender, EventArgs e)
        {
            try
            {
                this.Text = "Veteriner Takip Sistemi Aşı Güncelleme Ekranı";
                VaccinesDB vDB = new VaccinesDB();
                var result = vDB.getVaccine();
                foreach (var item in result)
                {
                    comboBoxEdit1.Properties.Items.Add(item.vaccineName.TrimEnd());
                    listBoxControl1.Items.Add(item.ID);
                    
                }
                if (result.Count<1)
                {
                    XtraMessageBox.Show("Güncellenecek Aşı Kaydı Yok!", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    btnKaydet.Enabled = false;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }



        private void comboBoxEdit1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBoxControl1.SelectedIndex = comboBoxEdit1.SelectedIndex;
        }



        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                VaccinesDB vDB = new VaccinesDB();
                var returnValue = vDB.mrvaccineUpdate(Convert.ToInt32(listBoxControl1.SelectedItem), txtNewVaccineName.Text);



                if (returnValue.ResultText == "Aşı Güncelleme İşlemi Başarılı!")
                {
                    XtraMessageBox.Show(returnValue.ResultText, "Başarılı!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    var result = vDB.getVaccine();
                    comboBoxEdit1.Properties.Items.Clear();
                    listBoxControl1.Items.Clear();
                    txtNewVaccineName.Text = null;
                    comboBoxEdit1.Text = null;
                    foreach (var item in result)
                    {
                        comboBoxEdit1.Properties.Items.Add(item.vaccineName.TrimEnd());
                        listBoxControl1.Items.Add(item.ID);

                    }
                    if (result.Count < 1)
                    {
                        XtraMessageBox.Show("Güncellenecek Aşı Kaydı Yok!", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        btnKaydet.Enabled = false;
                    }
                }
                else
                {
                    XtraMessageBox.Show("Kayıt İşlemi Sırasında Hata", "HATA!", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            this.Close();
        }
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;
        private void frmVaccineUpdate_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        private void frmVaccineUpdate_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }

        }

        private void frmVaccineUpdate_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }
    }
}