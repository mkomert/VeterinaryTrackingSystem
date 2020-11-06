using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VeterinaryControlPanel.DatabaseProcesses;

namespace VeterinaryControlPanel
{
    public partial class Veterinary : Form
    {
        public Veterinary()
        {
            InitializeComponent();
        }

        private void kullanıcıEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.groupBox1.Visible = true;
            this.groupBox2.Visible = false;
            this.groupBox1.Location = new Point(12, 47);
            this.lstUsers.Visible = false;
            this.label1.Visible = false;
            this.Size = new Size(385, 276);
            this.lstUsers.Visible = false;
            this.btnDelete.Visible = false;

        }

        private void kullanıcıGüncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lstUsers.Items.Clear();
            lstUsersID.Items.Clear();

            Form1_Load(this, null);
            this.groupBox2.Visible = true;
            this.groupBox1.Visible = false;
            this.groupBox2.Location = new Point(12, 47);
            this.lstUsers.Visible = true;
            this.label1.Visible = true;
            this.Size = new Size(544, 285);
            this.lstUsers.Location = new Point(361, 55);
            this.lstUsers.Visible = true;
            this.btnDelete.Visible = false;
            this.label1.Location = new Point(358, 37);
            this.label1.Text = "Güncellenecek Kullanıcı";
        }

        private void kullanıcıSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.label1.Location = new Point(11, 29);
            this.lstUsers.Location = new Point(14, 47);
            this.btnDelete.Location = new Point(14, 217);
            this.Size = new Size(313, 317);
            this.btnDelete.Visible = true;
            this.groupBox1.Visible = false;
            this.lstUsers.Visible = true;
            this.label1.Visible = true;
            this.label1.Text = "Silinecek Kullanıcı";
            this.groupBox2.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Size = new Size(304, 252);
            List<Users> uList = new List<Users>();
            uList = uDB.getUsersList();
            foreach (var item in uList)
            {
                lstUsers.Items.Add(item.name);
                lstUsersID.Items.Add(item.ID);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtNewUserName.Text =="" || txtNewPassword.Text == "")
            {
                MessageBox.Show("Lütfen Boş Alan Bırakmayın!");
            }
            else if (lstUsers.SelectedItem==null)
            {
                MessageBox.Show("Lütfen Listeden Bir Kullanıcı Seçin!");
            }
            else {
                Users _newInformations = new Users();
                _newInformations.ID = Convert.ToInt32(lstUsersID.SelectedItem);
                _newInformations.name = txtNewUserName.Text;
                _newInformations.password = txtNewPassword.Text;
                uDB.updateUser(_newInformations);
                MessageBox.Show("Güncellendi!");
                lstUsers.Items.Clear();
                lstUsersID.Items.Clear();

                Form1_Load(this, null);
                this.groupBox2.Visible = true;
                this.groupBox1.Visible = false;
                this.groupBox2.Location = new Point(12, 47);
                this.lstUsers.Visible = true;
                this.label1.Visible = true;
                this.Size = new Size(544, 285);
                this.lstUsers.Location = new Point(361, 55);
                this.lstUsers.Visible = true;
                this.btnDelete.Visible = false;
                this.label1.Location = new Point(358, 37);
                this.label1.Text = "Güncellenecek Kullanıcı";

            }
                


        }
        UserDatabaseProcesses uDB = new UserDatabaseProcesses();
        private void btnSave_Click(object sender, EventArgs e)
        {
            

            if (txtUserName.Text == "" || txtPassword.Text == "")
            {
                MessageBox.Show("Lütfen Boş Alan Bırakmayın!");
            }
            else
            {
                try
                {
                    Users _newUser = new Users();
                    _newUser.name = txtUserName.Text;
                    _newUser.password = txtPassword.Text;
                    uDB.saveUser(_newUser);
                    MessageBox.Show("Kullanıcı Kayıt İşlemi Başarı İle Gerçekleşti!");
                    txtUserName.Clear();
                    txtPassword.Clear();
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message.ToString());
                }
             
            }

        }

        private void lstUsersID_SelectedIndexChanged(object sender, EventArgs e)
        {
           
           
        }

        private void lstUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstUsersID.SelectedIndex = lstUsers.SelectedIndex;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lstUsers.SelectedItem == null)
            {
                MessageBox.Show("Lütfen Silinecek Kullanıcıyı Seçin!");
            }
            else
            {
                uDB.deleteUser(Convert.ToInt32(lstUsersID.SelectedItem));
                MessageBox.Show("Silme İşlemi Başarılı!");
                lstUsers.Items.Clear();
                lstUsersID.Items.Clear();

                Form1_Load(this, null);
                this.label1.Location = new Point(11, 29);
                this.lstUsers.Location = new Point(14, 47);
                this.btnDelete.Location = new Point(14, 217);
                this.Size = new Size(313, 317);
                this.btnDelete.Visible = true;
                this.groupBox1.Visible = false;
                this.lstUsers.Visible = true;
                this.label1.Visible = true;
                this.label1.Text = "Silinecek Kullanıcı";
                this.groupBox2.Visible = false;
            }
            
        }
    }
}
