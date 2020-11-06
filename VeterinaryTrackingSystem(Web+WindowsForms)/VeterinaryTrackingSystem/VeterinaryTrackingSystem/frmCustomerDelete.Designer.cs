namespace VeterinaryTrackingSystem
{
    partial class frmCustomerDelete
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCustomerDelete));
            this.lblSuccess = new DevExpress.XtraEditors.LabelControl();
            this.lblHastaCard = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.timerSerialPort = new System.Windows.Forms.Timer(this.components);
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnCustomerDelete = new DevExpress.XtraEditors.SimpleButton();
            this.btnConnect = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.btnMinimize = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSuccess
            // 
            this.lblSuccess.Appearance.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSuccess.Appearance.ForeColor = System.Drawing.Color.Red;
            this.lblSuccess.Appearance.Options.UseFont = true;
            this.lblSuccess.Appearance.Options.UseForeColor = true;
            this.lblSuccess.Location = new System.Drawing.Point(117, 64);
            this.lblSuccess.Name = "lblSuccess";
            this.lblSuccess.Size = new System.Drawing.Size(80, 13);
            this.lblSuccess.TabIndex = 8;
            this.lblSuccess.Text = "Kart Okunmadı!";
            // 
            // lblHastaCard
            // 
            this.lblHastaCard.Appearance.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblHastaCard.Appearance.Options.UseFont = true;
            this.lblHastaCard.Location = new System.Drawing.Point(117, 83);
            this.lblHastaCard.Name = "lblHastaCard";
            this.lblHastaCard.Size = new System.Drawing.Size(0, 13);
            this.lblHastaCard.TabIndex = 7;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(22, 36);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(229, 13);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Hasta Sahibi Silmeden Önce Bir Kart Okutun!";
            // 
            // timerSerialPort
            // 
            this.timerSerialPort.Interval = 200;
            this.timerSerialPort.Tick += new System.EventHandler(this.timerSerialPort_Tick);
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl9.Appearance.Options.UseFont = true;
            this.labelControl9.Location = new System.Drawing.Point(11, 18);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(137, 13);
            this.labelControl9.TabIndex = 27;
            this.labelControl9.Text = "Veterinary Tracking System";
            // 
            // groupControl1
            // 
            this.groupControl1.AppearanceCaption.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupControl1.AppearanceCaption.Options.UseFont = true;
            this.groupControl1.Controls.Add(this.btnCustomerDelete);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.btnConnect);
            this.groupControl1.Controls.Add(this.lblSuccess);
            this.groupControl1.Controls.Add(this.lblHastaCard);
            this.groupControl1.Location = new System.Drawing.Point(12, 61);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(268, 191);
            this.groupControl1.TabIndex = 90;
            this.groupControl1.Text = "Hasta Sahibi Silme Formu";
            // 
            // btnCustomerDelete
            // 
            this.btnCustomerDelete.Appearance.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCustomerDelete.Appearance.Options.UseFont = true;
            this.btnCustomerDelete.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCustomerDelete.ImageOptions.Image")));
            this.btnCustomerDelete.Location = new System.Drawing.Point(112, 109);
            this.btnCustomerDelete.Name = "btnCustomerDelete";
            this.btnCustomerDelete.Size = new System.Drawing.Size(85, 62);
            this.btnCustomerDelete.TabIndex = 27;
            this.btnCustomerDelete.Text = "Sil";
            this.btnCustomerDelete.Click += new System.EventHandler(this.btnCustomerDelete_Click);
            // 
            // btnConnect
            // 
            this.btnConnect.Appearance.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnConnect.Appearance.Options.UseFont = true;
            this.btnConnect.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnConnect.ImageOptions.Image")));
            this.btnConnect.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btnConnect.Location = new System.Drawing.Point(22, 64);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(89, 107);
            this.btnConnect.TabIndex = 1;
            this.btnConnect.Text = "Bağlan";
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnClose);
            this.panelControl1.Controls.Add(this.labelControl9);
            this.panelControl1.Controls.Add(this.btnMinimize);
            this.panelControl1.Location = new System.Drawing.Point(12, 12);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(268, 51);
            this.panelControl1.TabIndex = 91;
            // 
            // btnClose
            // 
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClose.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.ImageOptions.Image")));
            this.btnClose.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btnClose.Location = new System.Drawing.Point(235, 10);
            this.btnClose.Name = "btnClose";
            this.btnClose.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnClose.Size = new System.Drawing.Size(29, 36);
            this.btnClose.TabIndex = 88;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMinimize.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimize.ImageOptions.Image")));
            this.btnMinimize.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btnMinimize.Location = new System.Drawing.Point(205, 13);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnMinimize.Size = new System.Drawing.Size(29, 29);
            this.btnMinimize.TabIndex = 89;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // frmCustomerDelete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 262);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.groupControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("frmCustomerDelete.IconOptions.Icon")));
            this.IconOptions.Image = global::VeterinaryTrackingSystem.Properties.Resources.Icon32;
            this.Name = "frmCustomerDelete";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCustomerDelete";
            this.Load += new System.EventHandler(this.frmCustomerDelete_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmCustomerDelete_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmCustomerDelete_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.frmCustomerDelete_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.LabelControl lblSuccess;
        private DevExpress.XtraEditors.LabelControl lblHastaCard;
        private DevExpress.XtraEditors.SimpleButton btnConnect;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btnCustomerDelete;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Timer timerSerialPort;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.SimpleButton btnClose;
        private DevExpress.XtraEditors.SimpleButton btnMinimize;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
    }
}