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
    public partial class frmUpdateOperations : DevExpress.XtraEditors.XtraForm
    {
        public frmUpdateOperations()
        {
            InitializeComponent();
        }

        private void frmUpdateOperations_Load(object sender, EventArgs e)
        {
            try
            {
                this.Text = "Operasyon Güncelleme Ekranı";
                OperationDB oDB = new OperationDB();
                var result = oDB.getOperation();
                foreach (var item in result)
                {
                    comboBoxEdit1.Properties.Items.Add(item.operationName.TrimEnd());
                    listBoxControl1.Items.Add(item.ID);
                }

                if (result.Count<1)
                {
                    XtraMessageBox.Show("Güncellenecek Operasyon Kaydı Yok!", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    btnKaydet.Enabled = false;
                }


            }
            catch (Exception)
            {

                throw;
            }
        }



        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                OperationDB odb = new OperationDB();
                var returnValue = odb.mrOperationUpdate(txtNewOperationName.Text, Convert.ToInt32(listBoxControl1.SelectedItem));
                if (returnValue.ResultText == "Operasyon Güncelleme İşlemi Başarılı!")
                {
                    XtraMessageBox.Show(returnValue.ResultText, "Başarılı!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    var result = odb.getOperation();
                    comboBoxEdit1.Properties.Items.Clear();
                    listBoxControl1.Items.Clear();
                    txtNewOperationName.Text = null;
                    comboBoxEdit1.Text = null;
                    foreach (var item in result)
                    {
                        comboBoxEdit1.Properties.Items.Add(item.operationName.TrimEnd());
                        listBoxControl1.Items.Add(item.ID);
                    }
                    if (result.Count<1)
                    {
                        XtraMessageBox.Show("Güncellenecek Operasyon Kaydı Yok!", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
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
        private void frmUpdateOperations_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        private void frmUpdateOperations_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void frmUpdateOperations_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }
    }
}