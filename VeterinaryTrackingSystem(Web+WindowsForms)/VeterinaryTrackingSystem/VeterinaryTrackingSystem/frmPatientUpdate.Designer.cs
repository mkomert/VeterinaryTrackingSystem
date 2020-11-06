namespace VeterinaryTrackingSystem
{
    partial class frmPatientUpdate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPatientUpdate));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.btnConnect = new DevExpress.XtraEditors.SimpleButton();
            this.lblHastaCard = new DevExpress.XtraEditors.LabelControl();
            this.lblSuccess = new DevExpress.XtraEditors.LabelControl();
            this.lstPatients = new DevExpress.XtraEditors.ListBoxControl();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.timerSerialPort = new System.Windows.Forms.Timer(this.components);
            this.lblCustomerName = new DevExpress.XtraEditors.LabelControl();
            this.lstID = new DevExpress.XtraEditors.ListBoxControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.btnChoose = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.txtPatientAge = new DevExpress.XtraEditors.TextEdit();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.txtPatientKind = new DevExpress.XtraEditors.TextEdit();
            this.txtPatientBreed = new DevExpress.XtraEditors.TextEdit();
            this.txtPatientName = new DevExpress.XtraEditors.TextEdit();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.panelControl4 = new DevExpress.XtraEditors.PanelControl();
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.btnMinimize = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lstPatients)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lstID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPatientAge.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPatientKind.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPatientBreed.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPatientName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).BeginInit();
            this.panelControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.labelControl5);
            this.panelControl1.Controls.Add(this.btnConnect);
            this.panelControl1.Controls.Add(this.lblHastaCard);
            this.panelControl1.Controls.Add(this.lblSuccess);
            this.panelControl1.Location = new System.Drawing.Point(5, 25);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(269, 91);
            this.panelControl1.TabIndex = 1;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(14, 11);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(206, 13);
            this.labelControl5.TabIndex = 60;
            this.labelControl5.Text = "Güncellenecek Hastanın Kartını Okutun!";
            // 
            // btnConnect
            // 
            this.btnConnect.Appearance.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnConnect.Appearance.Options.UseFont = true;
            this.btnConnect.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnConnect.ImageOptions.Image")));
            this.btnConnect.Location = new System.Drawing.Point(14, 35);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(121, 37);
            this.btnConnect.TabIndex = 57;
            this.btnConnect.Text = "Bağlan";
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // lblHastaCard
            // 
            this.lblHastaCard.Appearance.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblHastaCard.Appearance.Options.UseFont = true;
            this.lblHastaCard.Location = new System.Drawing.Point(152, 57);
            this.lblHastaCard.Name = "lblHastaCard";
            this.lblHastaCard.Size = new System.Drawing.Size(0, 13);
            this.lblHastaCard.TabIndex = 58;
            // 
            // lblSuccess
            // 
            this.lblSuccess.Appearance.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSuccess.Appearance.ForeColor = System.Drawing.Color.Red;
            this.lblSuccess.Appearance.Options.UseFont = true;
            this.lblSuccess.Appearance.Options.UseForeColor = true;
            this.lblSuccess.Location = new System.Drawing.Point(152, 38);
            this.lblSuccess.Name = "lblSuccess";
            this.lblSuccess.Size = new System.Drawing.Size(80, 13);
            this.lblSuccess.TabIndex = 59;
            this.lblSuccess.Text = "Kart Okunmadı!";
            // 
            // lstPatients
            // 
            this.lstPatients.Appearance.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lstPatients.Appearance.Options.UseFont = true;
            this.lstPatients.Location = new System.Drawing.Point(11, 54);
            this.lstPatients.Name = "lstPatients";
            this.lstPatients.Size = new System.Drawing.Size(120, 95);
            this.lstPatients.TabIndex = 2;
            this.lstPatients.SelectedIndexChanged += new System.EventHandler(this.lstPatients_SelectedIndexChanged);
            // 
            // timerSerialPort
            // 
            this.timerSerialPort.Interval = 200;
            this.timerSerialPort.Tick += new System.EventHandler(this.timerSerialPort_Tick);
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.Appearance.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCustomerName.Appearance.Options.UseFont = true;
            this.lblCustomerName.Location = new System.Drawing.Point(11, 35);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(70, 13);
            this.lblCustomerName.TabIndex = 3;
            this.lblCustomerName.Text = "labelControl1";
            // 
            // lstID
            // 
            this.lstID.Appearance.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lstID.Appearance.Options.UseFont = true;
            this.lstID.Location = new System.Drawing.Point(11, 54);
            this.lstID.Name = "lstID";
            this.lstID.Size = new System.Drawing.Size(120, 95);
            this.lstID.TabIndex = 4;
            this.lstID.Visible = false;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(11, 8);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(156, 13);
            this.labelControl1.TabIndex = 5;
            this.labelControl1.Text = "Güncellenecek Hastayı Seçiniz!";
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.btnChoose);
            this.panelControl2.Controls.Add(this.lstPatients);
            this.panelControl2.Controls.Add(this.labelControl1);
            this.panelControl2.Controls.Add(this.lblCustomerName);
            this.panelControl2.Controls.Add(this.lstID);
            this.panelControl2.Location = new System.Drawing.Point(24, 29);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(231, 161);
            this.panelControl2.TabIndex = 7;
            // 
            // btnChoose
            // 
            this.btnChoose.Appearance.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnChoose.Appearance.Options.UseFont = true;
            this.btnChoose.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnChoose.ImageOptions.Image")));
            this.btnChoose.Location = new System.Drawing.Point(137, 54);
            this.btnChoose.Name = "btnChoose";
            this.btnChoose.Size = new System.Drawing.Size(86, 95);
            this.btnChoose.TabIndex = 6;
            this.btnChoose.Text = "Seç";
            this.btnChoose.Click += new System.EventHandler(this.btnChoose_Click);
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(20, 107);
            this.labelControl7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(78, 13);
            this.labelControl7.TabIndex = 70;
            this.labelControl7.Text = "Yeni Hasta Yaşı:";
            // 
            // txtPatientAge
            // 
            this.txtPatientAge.Location = new System.Drawing.Point(108, 104);
            this.txtPatientAge.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPatientAge.Name = "txtPatientAge";
            this.txtPatientAge.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtPatientAge.Properties.Appearance.Options.UseFont = true;
            this.txtPatientAge.Properties.MaxLength = 4;
            this.txtPatientAge.Size = new System.Drawing.Size(107, 20);
            this.txtPatientAge.TabIndex = 4;
            this.txtPatientAge.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPatientAge_KeyPress);
            // 
            // btnSave
            // 
            this.btnSave.Appearance.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSave.Appearance.Options.UseFont = true;
            this.btnSave.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnSave.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnSave.ImageOptions.SvgImage")));
            this.btnSave.Location = new System.Drawing.Point(15, 145);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(201, 80);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Kaydet";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(15, 83);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(83, 13);
            this.labelControl3.TabIndex = 67;
            this.labelControl3.Text = "Yeni Hasta Türü:";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(23, 59);
            this.labelControl6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(75, 13);
            this.labelControl6.TabIndex = 66;
            this.labelControl6.Text = "Yeni Hasta Irkı:";
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Location = new System.Drawing.Point(22, 35);
            this.labelControl8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(76, 13);
            this.labelControl8.TabIndex = 65;
            this.labelControl8.Text = "Yeni Hasta Adı:";
            // 
            // txtPatientKind
            // 
            this.txtPatientKind.Location = new System.Drawing.Point(108, 80);
            this.txtPatientKind.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPatientKind.Name = "txtPatientKind";
            this.txtPatientKind.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtPatientKind.Properties.Appearance.Options.UseFont = true;
            this.txtPatientKind.Size = new System.Drawing.Size(107, 20);
            this.txtPatientKind.TabIndex = 3;
            // 
            // txtPatientBreed
            // 
            this.txtPatientBreed.Location = new System.Drawing.Point(108, 56);
            this.txtPatientBreed.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPatientBreed.Name = "txtPatientBreed";
            this.txtPatientBreed.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtPatientBreed.Properties.Appearance.Options.UseFont = true;
            this.txtPatientBreed.Size = new System.Drawing.Size(107, 20);
            this.txtPatientBreed.TabIndex = 2;
            // 
            // txtPatientName
            // 
            this.txtPatientName.Location = new System.Drawing.Point(108, 32);
            this.txtPatientName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPatientName.Name = "txtPatientName";
            this.txtPatientName.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtPatientName.Properties.Appearance.Options.UseFont = true;
            this.txtPatientName.Size = new System.Drawing.Size(107, 20);
            this.txtPatientName.TabIndex = 1;
            // 
            // panelControl3
            // 
            this.panelControl3.Controls.Add(this.btnSave);
            this.panelControl3.Controls.Add(this.labelControl8);
            this.panelControl3.Controls.Add(this.txtPatientBreed);
            this.panelControl3.Controls.Add(this.labelControl6);
            this.panelControl3.Controls.Add(this.txtPatientAge);
            this.panelControl3.Controls.Add(this.labelControl7);
            this.panelControl3.Controls.Add(this.txtPatientKind);
            this.panelControl3.Controls.Add(this.labelControl3);
            this.panelControl3.Controls.Add(this.txtPatientName);
            this.panelControl3.Enabled = false;
            this.panelControl3.Location = new System.Drawing.Point(24, 30);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(231, 237);
            this.panelControl3.TabIndex = 71;
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl9.Appearance.Options.UseFont = true;
            this.labelControl9.Location = new System.Drawing.Point(5, 11);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(137, 13);
            this.labelControl9.TabIndex = 73;
            this.labelControl9.Text = "Veterinary Tracking System";
            // 
            // panelControl4
            // 
            this.panelControl4.Controls.Add(this.labelControl9);
            this.panelControl4.Controls.Add(this.btnClose);
            this.panelControl4.Controls.Add(this.btnMinimize);
            this.panelControl4.Location = new System.Drawing.Point(12, 8);
            this.panelControl4.Name = "panelControl4";
            this.panelControl4.Size = new System.Drawing.Size(280, 38);
            this.panelControl4.TabIndex = 96;
            // 
            // btnClose
            // 
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClose.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.ImageOptions.Image")));
            this.btnClose.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btnClose.Location = new System.Drawing.Point(246, 1);
            this.btnClose.Name = "btnClose";
            this.btnClose.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnClose.Size = new System.Drawing.Size(29, 36);
            this.btnClose.TabIndex = 94;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMinimize.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimize.ImageOptions.Image")));
            this.btnMinimize.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btnMinimize.Location = new System.Drawing.Point(216, 4);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnMinimize.Size = new System.Drawing.Size(29, 29);
            this.btnMinimize.TabIndex = 95;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // groupControl1
            // 
            this.groupControl1.AppearanceCaption.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupControl1.AppearanceCaption.Options.UseFont = true;
            this.groupControl1.Controls.Add(this.panelControl3);
            this.groupControl1.Location = new System.Drawing.Point(12, 381);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(280, 276);
            this.groupControl1.TabIndex = 97;
            this.groupControl1.Text = "Hasta Güncelleme Formu";
            // 
            // groupControl2
            // 
            this.groupControl2.AppearanceCaption.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupControl2.AppearanceCaption.Options.UseFont = true;
            this.groupControl2.Controls.Add(this.panelControl2);
            this.groupControl2.Location = new System.Drawing.Point(12, 177);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(280, 200);
            this.groupControl2.TabIndex = 98;
            this.groupControl2.Text = "Hasta Seçme Formu";
            // 
            // groupControl3
            // 
            this.groupControl3.AppearanceCaption.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupControl3.AppearanceCaption.Options.UseFont = true;
            this.groupControl3.Controls.Add(this.panelControl1);
            this.groupControl3.Location = new System.Drawing.Point(12, 47);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(280, 122);
            this.groupControl3.TabIndex = 99;
            this.groupControl3.Text = "Kart Okutma Formu";
            // 
            // frmPatientUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 176);
            this.Controls.Add(this.groupControl3);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.panelControl4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("frmPatientUpdate.IconOptions.Icon")));
            this.IconOptions.Image = global::VeterinaryTrackingSystem.Properties.Resources.Icon32;
            this.Name = "frmPatientUpdate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPatientUpdate";
            this.Load += new System.EventHandler(this.frmPatientUpdate_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmPatientUpdate_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmPatientUpdate_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.frmPatientUpdate_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lstPatients)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lstID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPatientAge.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPatientKind.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPatientBreed.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPatientName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            this.panelControl3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).EndInit();
            this.panelControl4.ResumeLayout(false);
            this.panelControl4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.SimpleButton btnConnect;
        private DevExpress.XtraEditors.LabelControl lblHastaCard;
        private DevExpress.XtraEditors.LabelControl lblSuccess;
        private DevExpress.XtraEditors.ListBoxControl lstPatients;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Timer timerSerialPort;
        private DevExpress.XtraEditors.LabelControl lblCustomerName;
        private DevExpress.XtraEditors.ListBoxControl lstID;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btnChoose;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.TextEdit txtPatientAge;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.TextEdit txtPatientKind;
        private DevExpress.XtraEditors.TextEdit txtPatientBreed;
        private DevExpress.XtraEditors.TextEdit txtPatientName;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.SimpleButton btnClose;
        private DevExpress.XtraEditors.SimpleButton btnMinimize;
        private DevExpress.XtraEditors.PanelControl panelControl4;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.GroupControl groupControl3;
    }
}