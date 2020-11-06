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
    public partial class frmOperationDelete : DevExpress.XtraEditors.XtraForm
    {
        public frmOperationDelete()
        {
            InitializeComponent();
        }


        private void comboBoxEdit1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBoxControl1.SelectedIndex = comboBoxEdit1.SelectedIndex;
        }

        private void frmOperationDelete_Load(object sender, EventArgs e)
        {
            try
            {
                this.Text = "Veteriner Takip Sistemi Operasyon Silme Ekranı";
                OperationDB oDB = new OperationDB();
                var result = oDB.getOperation();
                foreach (var item in result)
                {
                    comboBoxEdit1.Properties.Items.Add(item.operationName.TrimEnd());
                    listBoxControl1.Items.Add(item.ID);
                }
                if (result.Count < 1)
                {
                    XtraMessageBox.Show("Silinecek Operasyon Kaydı Yok!", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                if (comboBoxEdit1.SelectedItem == null)
                {
                    XtraMessageBox.Show("Lütfen Silinecek Operasyon Seçin!", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    OperationDB oDB = new OperationDB();
                    var returnValue = oDB.mrOperationDelete(Convert.ToInt32(listBoxControl1.SelectedItem));
                    if (returnValue.ResultText == "Operasyon Silme İşlemi Başarılı!")
                    {
                        XtraMessageBox.Show(returnValue.ResultText, "Başarılı!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        var result = oDB.getOperation();
                        comboBoxEdit1.Properties.Items.Clear();
                        listBoxControl1.Items.Clear();
                        comboBoxEdit1.Text = null;
                        foreach (var item in result)
                        {
                            comboBoxEdit1.Properties.Items.Add(item.operationName.TrimEnd());
                            listBoxControl1.Items.Add(item.ID);
                        }
                        if (result.Count < 1)
                        {
                            XtraMessageBox.Show("Silinecek Operasyon Kaydı Yok!", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            btnDelete.Enabled = false;
                        }
                    
                    }
                    else
                    {
                        XtraMessageBox.Show("Operasyon Silme İşlemi Sırasında Hata!", "HATA!", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        private void frmOperationDelete_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        private void frmOperationDelete_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        private void frmOperationDelete_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }
    }
}