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
    public partial class frmVaccineAdd : DevExpress.XtraEditors.XtraForm
    {
        public frmVaccineAdd()
        {
            InitializeComponent();
        }

 

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtVaccineName.Text == "")
                {
                    XtraMessageBox.Show("İsim Alanı Boş Bırakılamaz!", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    VaccinesDB vDB = new VaccinesDB();
                    var Control = vDB.getVaccineByName(txtVaccineName.Text);
                    if (Control == null)
                    {
                        var resultValue = vDB.mrAddVaccine(txtVaccineName.Text.TrimEnd());
                        if (resultValue.ResultText == "Aşı Kayıt İşlemi Başarılı!")
                        {
                            XtraMessageBox.Show(resultValue.ResultText, "Başarılı!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txtVaccineName.Text = "";
                        }
                        else
                        {
                            XtraMessageBox.Show("Kayıt işlemi sırasında hata!");
                        }
                    }
                    else
                    {
                        XtraMessageBox.Show("Aynı İsimde Aşı Sistemde Mevcut!", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }


            }
            catch (Exception)
            {

                throw;
            }
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
        private void frmVaccineAdd_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        private void frmVaccineAdd_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }

        }

        private void frmVaccineAdd_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }
    }
}