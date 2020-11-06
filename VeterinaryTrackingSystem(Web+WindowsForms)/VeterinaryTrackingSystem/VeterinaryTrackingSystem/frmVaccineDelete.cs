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
    public partial class frmVaccineDelete : DevExpress.XtraEditors.XtraForm
    {
        public frmVaccineDelete()
        {
            InitializeComponent();
        }

        private void frmVaccineDelete_Load(object sender, EventArgs e)
        {
            try
            {
                this.Text = "Veteriner Takip Sistemi Aşı Silme Ekranı";
                VaccinesDB vDB = new VaccinesDB();
                var result = vDB.getVaccine();
                foreach (var item in result)
                {
                    comboBoxEdit1.Properties.Items.Add(item.vaccineName.TrimEnd());
                    listBoxControl1.Items.Add(item.ID);

                }
                if (result.Count<1)
                {
                    XtraMessageBox.Show("Silinecek Aşı Kaydı Yok!", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    btnDelete.Enabled = false;
                }

                
            }
            catch (Exception)
            {

                throw;
            }
        }



        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                VaccinesDB _vDB = new VaccinesDB();
                if (XtraMessageBox.Show("Bu Aşıyı Sildiğinizde İlişkili Olarak\nHasta Karnelerinden Bu Aşıya Ait Bilgiler Silinecektir\nOnaylıyor Musunuz?", "Onay Verin", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    var controlValue = _vDB.controlVaccineForVaccineCert(Convert.ToInt32(listBoxControl1.SelectedItem));
                    if (controlValue != null)
                    {
                        if (comboBoxEdit1.SelectedItem == null)
                        {
                            XtraMessageBox.Show("Lütfen Silinecek Aşı Seçin!", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                        else
                        {

                            var returnValue = _vDB.mrVaccineDelete(Convert.ToInt32(listBoxControl1.SelectedItem));
                            if (returnValue.ResultText == "Aşı Bilgisi Silme İşlemi Başarılı!")
                            {
                                XtraMessageBox.Show(returnValue.ResultText, "Başarılı!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                var result = _vDB.getVaccine();
                                comboBoxEdit1.Properties.Items.Clear();
                                listBoxControl1.Items.Clear();
                                comboBoxEdit1.Text = null;
                                foreach (var item in result)
                                {
                                    comboBoxEdit1.Properties.Items.Add(item.vaccineName.TrimEnd());
                                    listBoxControl1.Items.Add(item.ID);

                                }
                                if (result.Count < 1)
                                {
                                    XtraMessageBox.Show("Silinecek Aşı Kaydı Yok!", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    btnDelete.Enabled = false;
                                }

                            }
                            else
                            {
                                XtraMessageBox.Show("Aşı Silme İşlemi Sırasında Hata!", "HATA!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }

                        }
                    }
                    else
                    {
                        if (listBoxControl1.SelectedItem == null)
                        {
                            XtraMessageBox.Show("Lütfen Silinecek Aşı Seçin!", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {

                            _vDB.deleteVaccine(Convert.ToInt32(listBoxControl1.SelectedItem));
                            XtraMessageBox.Show("Aşı Bilgisi Silme İşlemi Başarılı!", "Başarılı!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            var result = _vDB.getVaccine();
                            comboBoxEdit1.Properties.Items.Clear();
                            listBoxControl1.Items.Clear();
                            comboBoxEdit1.Text = null;
                            foreach (var item in result)
                            {
                                comboBoxEdit1.Properties.Items.Add(item.vaccineName.TrimEnd());
                                listBoxControl1.Items.Add(item.ID);

                            }
                            if (result.Count < 1)
                            {
                                XtraMessageBox.Show("Silinecek Aşı Kaydı Yok!", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                btnDelete.Enabled = false;
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

        private void panelControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBoxEdit1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBoxControl1.SelectedIndex = comboBoxEdit1.SelectedIndex;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;
        private void frmVaccineDelete_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        private void frmVaccineDelete_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        private void frmVaccineDelete_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }
    }
}