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
    public partial class frmSaveOperation : DevExpress.XtraEditors.XtraForm
    {
        public frmSaveOperation()
        {
            InitializeComponent();
            this.Text = "Veteriner Takip Sistemi Operasyon Kayıt Ekranı";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtOperationName.Text !="")
                {
                    OperationDB oDB = new OperationDB();
                    var result = oDB.mrOperationSave(txtOperationName.Text.TrimEnd());
                    if (result.ResultText == "Operasyon Kayıt İşlemi Başarılı!")
                    {
                        XtraMessageBox.Show(result.ResultText, "Başarılı!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtOperationName.Text = "";
                    }
                }
                else
                {
                    XtraMessageBox.Show("Boş Alan Bırakmayın!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        private void frmSaveOperation_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        private void frmSaveOperation_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void frmSaveOperation_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }
    }
}