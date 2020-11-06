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
    public partial class frmLoading : DevExpress.XtraEditors.XtraForm
    {
        public frmLoading()
        {
            InitializeComponent();
        }

        private void frmLoading_Load(object sender, EventArgs e)
        {
            this.Text = "Veteriner Takip Sistemi Yükleme Ekranı";
            this.Opacity = 0.1;
            this.BackColor = Color.Black;
            this.TransparencyKey = Color.Black;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Opacity += 0.03;
            frmLogin _login = new frmLogin();
            if (this.Opacity > 0.99)
            {
                this.Hide();
                _login.Show();
                timer1.Stop();
            }
        }
    }
}