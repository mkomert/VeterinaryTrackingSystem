namespace VeterinaryTrackingSystem
{
    partial class frmAnimal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAnimal));
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.timerSerialPort = new System.Windows.Forms.Timer(this.components);
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.btnConnect = new DevExpress.XtraEditors.SimpleButton();
            this.lblSuccess = new DevExpress.XtraEditors.LabelControl();
            this.lblHastaCard = new DevExpress.XtraEditors.LabelControl();
            this.lblCustomerSurname = new DevExpress.XtraEditors.LabelControl();
            this.lblCustomerName = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblPatients = new DevExpress.XtraEditors.LabelControl();
            this.lstPatients = new DevExpress.XtraEditors.ListBoxControl();
            this.btnNext = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.txtPatientAge = new DevExpress.XtraEditors.TextEdit();
            this.txtPatientName = new DevExpress.XtraEditors.TextEdit();
            this.txtPatientBreed = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txtPatientKind = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.panelControl4 = new DevExpress.XtraEditors.PanelControl();
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.btnMinimize = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lstPatients)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPatientAge.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPatientName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPatientBreed.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPatientKind.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).BeginInit();
            this.panelControl4.SuspendLayout();
            this.SuspendLayout();
            // 
            // timerSerialPort
            // 
            this.timerSerialPort.Interval = 200;
            this.timerSerialPort.Tick += new System.EventHandler(this.timerSerialPort_Tick);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(12, 34);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(216, 13);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Hasta Kaydetmeden Önce Bir Kart Okutun!";
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.groupControl3);
            this.panelControl2.Location = new System.Drawing.Point(7, 50);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(337, 137);
            this.panelControl2.TabIndex = 3;
            this.panelControl2.Paint += new System.Windows.Forms.PaintEventHandler(this.panelControl2_Paint);
            // 
            // groupControl3
            // 
            this.groupControl3.Appearance.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupControl3.Appearance.Options.UseFont = true;
            this.groupControl3.AppearanceCaption.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupControl3.AppearanceCaption.Options.UseFont = true;
            this.groupControl3.Controls.Add(this.btnConnect);
            this.groupControl3.Controls.Add(this.lblSuccess);
            this.groupControl3.Controls.Add(this.labelControl1);
            this.groupControl3.Controls.Add(this.lblHastaCard);
            this.groupControl3.Location = new System.Drawing.Point(5, 5);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(324, 128);
            this.groupControl3.TabIndex = 28;
            this.groupControl3.Text = "Kart Okutma";
            // 
            // btnConnect
            // 
            this.btnConnect.Appearance.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnConnect.Appearance.Options.UseFont = true;
            this.btnConnect.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnConnect.ImageOptions.Image")));
            this.btnConnect.Location = new System.Drawing.Point(12, 64);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(121, 42);
            this.btnConnect.TabIndex = 1;
            this.btnConnect.Text = "Bağlan";
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // lblSuccess
            // 
            this.lblSuccess.Appearance.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSuccess.Appearance.ForeColor = System.Drawing.Color.Red;
            this.lblSuccess.Appearance.Options.UseFont = true;
            this.lblSuccess.Appearance.Options.UseForeColor = true;
            this.lblSuccess.Location = new System.Drawing.Point(164, 64);
            this.lblSuccess.Name = "lblSuccess";
            this.lblSuccess.Size = new System.Drawing.Size(80, 13);
            this.lblSuccess.TabIndex = 8;
            this.lblSuccess.Text = "Kart Okunmadı!";
            // 
            // lblHastaCard
            // 
            this.lblHastaCard.Appearance.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblHastaCard.Appearance.Options.UseFont = true;
            this.lblHastaCard.Location = new System.Drawing.Point(164, 83);
            this.lblHastaCard.Name = "lblHastaCard";
            this.lblHastaCard.Size = new System.Drawing.Size(0, 13);
            this.lblHastaCard.TabIndex = 7;
            // 
            // lblCustomerSurname
            // 
            this.lblCustomerSurname.Appearance.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCustomerSurname.Appearance.Options.UseFont = true;
            this.lblCustomerSurname.Location = new System.Drawing.Point(62, 81);
            this.lblCustomerSurname.Name = "lblCustomerSurname";
            this.lblCustomerSurname.Size = new System.Drawing.Size(0, 13);
            this.lblCustomerSurname.TabIndex = 10;
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.Appearance.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCustomerName.Appearance.Options.UseFont = true;
            this.lblCustomerName.Location = new System.Drawing.Point(62, 62);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(0, 13);
            this.lblCustomerName.TabIndex = 9;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(21, 81);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(37, 13);
            this.labelControl3.TabIndex = 8;
            this.labelControl3.Text = "Soyadı:";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(21, 62);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(20, 13);
            this.labelControl2.TabIndex = 7;
            this.labelControl2.Text = "Adı:";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.groupControl1);
            this.panelControl1.Location = new System.Drawing.Point(7, 193);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(337, 242);
            this.panelControl1.TabIndex = 12;
            // 
            // groupControl1
            // 
            this.groupControl1.AppearanceCaption.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupControl1.AppearanceCaption.Options.UseFont = true;
            this.groupControl1.Controls.Add(this.pictureBox1);
            this.groupControl1.Controls.Add(this.lblPatients);
            this.groupControl1.Controls.Add(this.lstPatients);
            this.groupControl1.Controls.Add(this.lblCustomerName);
            this.groupControl1.Controls.Add(this.btnNext);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.lblCustomerSurname);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Location = new System.Drawing.Point(4, 7);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(325, 228);
            this.groupControl1.TabIndex = 28;
            this.groupControl1.Text = "Hasta Görüntüleme";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Image = global::VeterinaryTrackingSystem.Properties.Resources.Icon64;
            this.pictureBox1.Location = new System.Drawing.Point(21, 124);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(81, 83);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 83;
            this.pictureBox1.TabStop = false;
            // 
            // lblPatients
            // 
            this.lblPatients.Appearance.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPatients.Appearance.Options.UseFont = true;
            this.lblPatients.Location = new System.Drawing.Point(192, 41);
            this.lblPatients.Name = "lblPatients";
            this.lblPatients.Size = new System.Drawing.Size(57, 13);
            this.lblPatients.TabIndex = 13;
            this.lblPatients.Text = "Hastalarım:";
            // 
            // lstPatients
            // 
            this.lstPatients.Appearance.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lstPatients.Appearance.Options.UseFont = true;
            this.lstPatients.Location = new System.Drawing.Point(192, 60);
            this.lstPatients.Name = "lstPatients";
            this.lstPatients.Size = new System.Drawing.Size(120, 95);
            this.lstPatients.TabIndex = 12;
            // 
            // btnNext
            // 
            this.btnNext.Appearance.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnNext.Appearance.Options.UseFont = true;
            this.btnNext.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnNext.ImageOptions.SvgImage")));
            this.btnNext.Location = new System.Drawing.Point(192, 160);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(120, 47);
            this.btnNext.TabIndex = 11;
            this.btnNext.Text = "Ekle";
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // panelControl3
            // 
            this.panelControl3.Controls.Add(this.groupControl2);
            this.panelControl3.Location = new System.Drawing.Point(7, 438);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(337, 237);
            this.panelControl3.TabIndex = 23;
            this.panelControl3.Paint += new System.Windows.Forms.PaintEventHandler(this.panelControl3_Paint);
            // 
            // groupControl2
            // 
            this.groupControl2.Appearance.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupControl2.Appearance.Options.UseFont = true;
            this.groupControl2.AppearanceCaption.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupControl2.AppearanceCaption.Options.UseFont = true;
            this.groupControl2.Controls.Add(this.labelControl7);
            this.groupControl2.Controls.Add(this.btnSave);
            this.groupControl2.Controls.Add(this.txtPatientAge);
            this.groupControl2.Controls.Add(this.txtPatientName);
            this.groupControl2.Controls.Add(this.txtPatientBreed);
            this.groupControl2.Controls.Add(this.labelControl5);
            this.groupControl2.Controls.Add(this.txtPatientKind);
            this.groupControl2.Controls.Add(this.labelControl6);
            this.groupControl2.Controls.Add(this.labelControl8);
            this.groupControl2.Location = new System.Drawing.Point(9, 9);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(320, 220);
            this.groupControl2.TabIndex = 29;
            this.groupControl2.Text = "Hasta Bilgileri";
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(40, 129);
            this.labelControl7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(90, 13);
            this.labelControl7.TabIndex = 31;
            this.labelControl7.Text = "Hasta Doğum Yılı:";
            // 
            // btnSave
            // 
            this.btnSave.Appearance.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSave.Appearance.Options.UseFont = true;
            this.btnSave.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnSave.ImageOptions.SvgImage")));
            this.btnSave.Location = new System.Drawing.Point(139, 150);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(107, 46);
            this.btnSave.TabIndex = 29;
            this.btnSave.Text = "Kaydet";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtPatientAge
            // 
            this.txtPatientAge.Location = new System.Drawing.Point(139, 126);
            this.txtPatientAge.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPatientAge.Name = "txtPatientAge";
            this.txtPatientAge.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtPatientAge.Properties.Appearance.Options.UseFont = true;
            this.txtPatientAge.Properties.MaxLength = 4;
            this.txtPatientAge.Size = new System.Drawing.Size(107, 20);
            this.txtPatientAge.TabIndex = 5;
            this.txtPatientAge.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPatientAge_KeyPress);
            // 
            // txtPatientName
            // 
            this.txtPatientName.Location = new System.Drawing.Point(139, 46);
            this.txtPatientName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPatientName.Name = "txtPatientName";
            this.txtPatientName.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtPatientName.Properties.Appearance.Options.UseFont = true;
            this.txtPatientName.Size = new System.Drawing.Size(107, 20);
            this.txtPatientName.TabIndex = 2;
            // 
            // txtPatientBreed
            // 
            this.txtPatientBreed.Location = new System.Drawing.Point(139, 73);
            this.txtPatientBreed.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPatientBreed.Name = "txtPatientBreed";
            this.txtPatientBreed.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtPatientBreed.Properties.Appearance.Options.UseFont = true;
            this.txtPatientBreed.Size = new System.Drawing.Size(107, 20);
            this.txtPatientBreed.TabIndex = 3;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(71, 105);
            this.labelControl5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(59, 13);
            this.labelControl5.TabIndex = 28;
            this.labelControl5.Text = "Hasta Türü:";
            // 
            // txtPatientKind
            // 
            this.txtPatientKind.Location = new System.Drawing.Point(139, 102);
            this.txtPatientKind.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPatientKind.Name = "txtPatientKind";
            this.txtPatientKind.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtPatientKind.Properties.Appearance.Options.UseFont = true;
            this.txtPatientKind.Size = new System.Drawing.Size(107, 20);
            this.txtPatientKind.TabIndex = 4;
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(79, 76);
            this.labelControl6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(51, 13);
            this.labelControl6.TabIndex = 27;
            this.labelControl6.Text = "Hasta Irkı:";
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Location = new System.Drawing.Point(78, 49);
            this.labelControl8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(52, 13);
            this.labelControl8.TabIndex = 26;
            this.labelControl8.Text = "Hasta Adı:";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(5, 7);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(137, 13);
            this.labelControl4.TabIndex = 27;
            this.labelControl4.Text = "Veterinary Tracking System";
            // 
            // panelControl4
            // 
            this.panelControl4.Controls.Add(this.btnClose);
            this.panelControl4.Controls.Add(this.btnMinimize);
            this.panelControl4.Controls.Add(this.labelControl4);
            this.panelControl4.Location = new System.Drawing.Point(7, 12);
            this.panelControl4.Name = "panelControl4";
            this.panelControl4.Size = new System.Drawing.Size(337, 38);
            this.panelControl4.TabIndex = 28;
            // 
            // btnClose
            // 
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClose.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.ImageOptions.Image")));
            this.btnClose.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btnClose.Location = new System.Drawing.Point(303, 1);
            this.btnClose.Name = "btnClose";
            this.btnClose.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnClose.Size = new System.Drawing.Size(29, 36);
            this.btnClose.TabIndex = 92;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMinimize.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimize.ImageOptions.Image")));
            this.btnMinimize.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btnMinimize.Location = new System.Drawing.Point(273, 4);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnMinimize.Size = new System.Drawing.Size(29, 29);
            this.btnMinimize.TabIndex = 93;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // frmAnimal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 193);
            this.Controls.Add(this.panelControl4);
            this.Controls.Add(this.panelControl3);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.panelControl2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("frmAnimal.IconOptions.Icon")));
            this.IconOptions.Image = global::VeterinaryTrackingSystem.Properties.Resources.Icon32;
            this.Name = "frmAnimal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAnimal";
            this.Load += new System.EventHandler(this.frmAnimal_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmAnimal_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmAnimal_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.frmAnimal_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            this.groupControl3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lstPatients)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPatientAge.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPatientName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPatientBreed.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPatientKind.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).EndInit();
            this.panelControl4.ResumeLayout(false);
            this.panelControl4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.SimpleButton btnConnect;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Timer timerSerialPort;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.LabelControl lblHastaCard;
        private DevExpress.XtraEditors.LabelControl lblSuccess;
        private DevExpress.XtraEditors.LabelControl lblCustomerSurname;
        private DevExpress.XtraEditors.LabelControl lblCustomerName;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.TextEdit txtPatientAge;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.TextEdit txtPatientKind;
        private DevExpress.XtraEditors.TextEdit txtPatientBreed;
        private DevExpress.XtraEditors.TextEdit txtPatientName;
        private DevExpress.XtraEditors.SimpleButton btnNext;
        private DevExpress.XtraEditors.LabelControl lblPatients;
        private DevExpress.XtraEditors.ListBoxControl lstPatients;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraEditors.PanelControl panelControl4;
        private DevExpress.XtraEditors.SimpleButton btnClose;
        private DevExpress.XtraEditors.SimpleButton btnMinimize;
    }
}