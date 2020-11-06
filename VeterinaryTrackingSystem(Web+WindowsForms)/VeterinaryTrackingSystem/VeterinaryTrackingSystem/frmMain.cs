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
    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frmMain()
        {
            InitializeComponent();
            this.Text = "Veteriner Takip Sistemi";
            tmrClock.Start();
            

            
            
        }
        frmCustomer csmtrFrm;
        private void navBarItem1_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            try
            {
                if (csmtrFrm == null || csmtrFrm.IsDisposed)
                {
                    csmtrFrm = new frmCustomer();
                    csmtrFrm.Show();
                }
                else
                {

                    XtraMessageBox.Show("Hasta Sahibi Ekleme Formu Zaten Açık!", "HATA");
                    csmtrFrm.Focus();

                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void xtraTabControl1_HeaderButtonClick(object sender, DevExpress.XtraTab.ViewInfo.HeaderButtonEventArgs e)
        {
            
        }

        private void xtraTabControl1_CustomHeaderButtonClick(object sender, DevExpress.XtraTab.ViewInfo.CustomHeaderButtonEventArgs e)
        {
            if (e.Button.Tag.ToString() == "min")
            {
                this.WindowState = FormWindowState.Minimized;
            }
            else
            {
                if (XtraMessageBox.Show("Program Kapatılsın Mı?", "UYARI", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    Application.Exit();
                }
            }
        }

        private void navBarControl2_Click(object sender, EventArgs e)
        {

        }
        frmAnimal _frmHasta;
        private void navBarItem4_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            try
            {
                if (_frmHasta == null || _frmHasta.IsDisposed)
                {
                    _frmHasta = new frmAnimal();
                    _frmHasta.Show();
                }
                else
                {

                    XtraMessageBox.Show("Hasta Ekleme Formu Zaten Açık!", "HATA");
                    _frmHasta.Focus();

                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        frmCustomerDelete _frmDelete;
        private void navBarItem3_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            try
            {
                if (_frmDelete == null || _frmDelete.IsDisposed)
                {
                    _frmDelete = new frmCustomerDelete();
                    _frmDelete.Show();
                }
                else
                {

                    XtraMessageBox.Show("Hasta Silme Formu Zaten Açık!", "HATA");
                    _frmDelete.Focus();

                }
            }
            catch (Exception)
            {

                throw;
            }

        }
        frmCustomers _frmCustomers;
        private void navBarItem7_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            try
            {
                if (_frmCustomers == null || _frmCustomers.IsDisposed)
                {
                    _frmCustomers = new frmCustomers();
                    _frmCustomers.Show();
                }
                else
                {

                    XtraMessageBox.Show("Hasta Sahibi Ekleme Formu Zaten Açık!", "HATA");
                    _frmCustomers.Focus();

                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        customerUpdate _cstmrUpdate;
        private void navBarItem2_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            try
            {
                if (_cstmrUpdate == null || _cstmrUpdate.IsDisposed)
                {
                    _cstmrUpdate = new customerUpdate();
                    _cstmrUpdate.Show();
                }
                else
                {

                    XtraMessageBox.Show("Hasta Sahibi Ekleme Formu Zaten Açık!", "HATA");
                    _cstmrUpdate.Focus();

                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void xtraTabPage1_Paint(object sender, PaintEventArgs e)
        {

        }
        frmPatientDelete _patientDelete;
        private void navBarItem5_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            try
            {
                if (_patientDelete == null || _patientDelete.IsDisposed)
                {
                    _patientDelete = new frmPatientDelete();
                    _patientDelete.Show();
                }
                else
                {

                    XtraMessageBox.Show("Hasta Silme Formu Zaten Açık!", "HATA");
                    _patientDelete.Focus();

                }
            }
            catch (Exception)
            {

                throw;
            }
        }

     


        frmPatientUpdate _frmpatientUpdate;
        private void navBarItem6_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            try
            {
                if (_frmpatientUpdate == null || _frmpatientUpdate.IsDisposed)
                {
                    _frmpatientUpdate = new frmPatientUpdate();
                    _frmpatientUpdate.Show();
                }
                else
                {

                    XtraMessageBox.Show("Hasta Güncelleme Formu Zaten Açık!", "HATA");
                    _frmpatientUpdate.Focus();

                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        frmVaccineAdd _vaccineAdd;
        private void navBarItem8_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            try
            {
                if (_vaccineAdd == null || _vaccineAdd.IsDisposed)
                {
                    _vaccineAdd = new frmVaccineAdd();
                    _vaccineAdd.Show();
                }
                else
                {

                    XtraMessageBox.Show("Aşı Ekleme Formu Zaten Açık!", "HATA");
                    _vaccineAdd.Focus();

                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        frmVaccineUpdate _vaccineUpdate;
        private void navBarItem10_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            try
            {
                if (_vaccineUpdate == null || _vaccineUpdate.IsDisposed)
                {
                    _vaccineUpdate = new frmVaccineUpdate();
                    _vaccineUpdate.Show();
                }
                else
                {

                    XtraMessageBox.Show("Aşı Güncelleme Formu Zaten Açık!", "HATA");
                    _vaccineUpdate.Focus();

                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        frmVaccineDelete _vaccineDel;
        private void navBarItem9_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            try
            {
                if (_vaccineDel == null || _vaccineDel.IsDisposed)
                {
                    _vaccineDel = new frmVaccineDelete();
                    _vaccineDel.Show();
                }
                else
                {

                    XtraMessageBox.Show("Aşı Silme Formu Zaten Açık!", "HATA");
                    _vaccineDel.Focus();

                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void tmrClock_Tick(object sender, EventArgs e)
        {
          
        }
        frmSaveOperation _frmSaveOp;
        private void navBarItem11_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            try
            {
                if (_frmSaveOp == null || _frmSaveOp.IsDisposed)
                {
                    _frmSaveOp = new frmSaveOperation();
                    _frmSaveOp.Show();
                }
                else
                {

                    XtraMessageBox.Show("Operasyon Ekleme Formu Zaten Açık!", "HATA");
                    _frmSaveOp.Focus();

                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        frmUpdateOperations _updateOp;
        private void navBarItem13_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            try
            {
                if (_updateOp == null || _updateOp.IsDisposed)
                {
                    _updateOp = new frmUpdateOperations();
                    _updateOp.Show();
                }
                else
                {

                    XtraMessageBox.Show("Operasyon Güncelleme Formu Zaten Açık!", "HATA");
                    _updateOp.Focus();

                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        frmOperationDelete _opDelete;
        private void navBarItem12_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            try
            {
                if (_opDelete == null || _opDelete.IsDisposed)
                {
                    _opDelete = new frmOperationDelete();
                    _opDelete.Show();
                }
                else
                {

                    XtraMessageBox.Show("Operasyon Güncelleme Formu Zaten Açık!", "HATA");
                    _opDelete.Focus();

                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        frmCertificate _certificate;
        private void navBarItem14_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            try
            {
                if (_certificate == null || _certificate.IsDisposed)
                {
                    _certificate = new frmCertificate();
                    _certificate.Show();
                }
                else
                {

                    XtraMessageBox.Show("Karne Ekleme Formu Zaten Açık!", "HATA");
                    _certificate.Focus();

                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        frmCertificateShow _frmCShow;
        private void navBarItem15_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            try
            {
                if (_frmCShow == null || _frmCShow.IsDisposed)
                {
                    _frmCShow = new frmCertificateShow();
                    _frmCShow.Show();
                }
                else
                {

                    XtraMessageBox.Show("Karne Görüntüleme Formu Zaten Açık!", "HATA");
                    _frmCShow.Focus();

                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}