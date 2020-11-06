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
using DataLayer;
using Helper;

namespace VeterinaryTrackingSystem
{
    public partial class frmLogin : DevExpress.XtraEditors.XtraForm
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        
        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                User _loginUser = new User();
                UserDB uDB = new UserDB();
                
                _loginUser.name = txtUserName.Text.ToString();
                _loginUser.password = txtPassword.Text;
                

                var context = uDB.mrUserLogin(_loginUser);
                if (context.Object != null)
                {
                    XtraMessageBox.Show("Hoş Geldiniz " + context.ResultText, "Başarılı İşlem!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frmMain _frmmain = new frmMain();
                    this.Hide();
                    _frmmain.WindowState = FormWindowState.Maximized;
                    _frmmain.Show();
                }

                else
                {
                    XtraMessageBox.Show("Giriş Başarısız!\nLütfen Kullanıcı Adı Veya Şifrenizi Kontrol Edin!","Başarısız İşlem!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }



                

            }
            catch (Exception)
            {

                throw;
            }
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            try
            {
                Application.Exit();
            }
            catch (Exception)
            {

                throw;
            }
            
        }

   

        private void frmLogin_Load(object sender, EventArgs e)
        {
            try
            {
                this.Text = "Veteriner Takip Sistemi Giriş Ekranı";
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
            Application.Exit();
        }
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;
        private void frmLogin_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        private void frmLogin_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void frmLogin_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }
    }
}