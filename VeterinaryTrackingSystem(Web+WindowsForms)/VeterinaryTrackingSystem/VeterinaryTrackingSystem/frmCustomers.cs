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

namespace VeterinaryTrackingSystem
{
    public partial class frmCustomers : DevExpress.XtraEditors.XtraForm
    {
        public frmCustomers()
        {
            InitializeComponent();
        }

        private void frmCustomers_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'veterinaryDBDataSet.Customers' table. You can move, or remove it, as needed.
            this.customersTableAdapter.Fill(this.veterinaryDBDataSet.Customers);
            this.Text = "Veteriner Takip Sistemi Hasta Sahibi Görüntüleme Ekranı";


        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }


        private void btnExit_Click(object sender, EventArgs e)
        {
           
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void gridControl1_Click_1(object sender, EventArgs e)
        {

        }
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;
        private void frmCustomers_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        private void frmCustomers_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        private void frmCustomers_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }
    }
}