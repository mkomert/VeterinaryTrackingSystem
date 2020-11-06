namespace VeterinaryTrackingSystem
{
    partial class frmCertificate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCertificate));
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.timerSerialPort = new System.Windows.Forms.Timer(this.components);
            this.lblCustomerName = new DevExpress.XtraEditors.LabelControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnSelect = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.cmbPatients = new DevExpress.XtraEditors.ComboBoxEdit();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.btnConnect = new DevExpress.XtraEditors.SimpleButton();
            this.lblHastaCard = new DevExpress.XtraEditors.LabelControl();
            this.lblSuccess = new DevExpress.XtraEditors.LabelControl();
            this.dateTimeVaccine = new DevExpress.XtraEditors.DateEdit();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.panelControl5 = new DevExpress.XtraEditors.PanelControl();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pnlVaccination = new DevExpress.XtraEditors.PanelControl();
            this.cmbVaccines = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.btnVaccineSave = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.pnlOperation = new DevExpress.XtraEditors.PanelControl();
            this.dateTimeOperation = new DevExpress.XtraEditors.DateEdit();
            this.btnOperationSave = new DevExpress.XtraEditors.SimpleButton();
            this.cmbOperations = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.navBarControl1 = new DevExpress.XtraNavBar.NavBarControl();
            this.navBarGroup1 = new DevExpress.XtraNavBar.NavBarGroup();
            this.navBarSeparatorItem1 = new DevExpress.XtraNavBar.NavBarSeparatorItem();
            this.navBarItem1 = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarSeparatorItem2 = new DevExpress.XtraNavBar.NavBarSeparatorItem();
            this.navBarItem2 = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarSeparatorItem3 = new DevExpress.XtraNavBar.NavBarSeparatorItem();
            this.lstID = new DevExpress.XtraEditors.ListBoxControl();
            this.lstVaccineID = new DevExpress.XtraEditors.ListBoxControl();
            this.lstOperationID = new DevExpress.XtraEditors.ListBoxControl();
            this.panelControl4 = new DevExpress.XtraEditors.PanelControl();
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.btnMinimize = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbPatients.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateTimeVaccine.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateTimeVaccine.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl5)).BeginInit();
            this.panelControl5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlVaccination)).BeginInit();
            this.pnlVaccination.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbVaccines.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlOperation)).BeginInit();
            this.pnlOperation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateTimeOperation.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateTimeOperation.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbOperations.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lstID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lstVaccineID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lstOperationID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).BeginInit();
            this.panelControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            this.SuspendLayout();
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
            this.lblCustomerName.Location = new System.Drawing.Point(14, 38);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(0, 13);
            this.lblCustomerName.TabIndex = 29;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnSelect);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Controls.Add(this.cmbPatients);
            this.panelControl1.Controls.Add(this.lblCustomerName);
            this.panelControl1.Location = new System.Drawing.Point(299, 32);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(431, 106);
            this.panelControl1.TabIndex = 30;
            // 
            // btnSelect
            // 
            this.btnSelect.Appearance.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSelect.Appearance.Options.UseFont = true;
            this.btnSelect.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSelect.ImageOptions.Image")));
            this.btnSelect.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnSelect.Location = new System.Drawing.Point(191, 56);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(153, 44);
            this.btnSelect.TabIndex = 33;
            this.btnSelect.Text = "Seç";
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(191, 14);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(57, 13);
            this.labelControl1.TabIndex = 32;
            this.labelControl1.Text = "Hastalarım:";
            // 
            // cmbPatients
            // 
            this.cmbPatients.Location = new System.Drawing.Point(191, 31);
            this.cmbPatients.Name = "cmbPatients";
            this.cmbPatients.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbPatients.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cmbPatients.Size = new System.Drawing.Size(153, 20);
            this.cmbPatients.TabIndex = 31;
            this.cmbPatients.SelectedIndexChanged += new System.EventHandler(this.cmbPatients_SelectedIndexChanged);
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.labelControl5);
            this.panelControl2.Controls.Add(this.btnConnect);
            this.panelControl2.Controls.Add(this.lblHastaCard);
            this.panelControl2.Controls.Add(this.lblSuccess);
            this.panelControl2.Location = new System.Drawing.Point(8, 32);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(285, 106);
            this.panelControl2.TabIndex = 69;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(13, 14);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(214, 13);
            this.labelControl5.TabIndex = 60;
            this.labelControl5.Text = "Karne Eklenecek Hastanın Kartını Okutun!";
            // 
            // btnConnect
            // 
            this.btnConnect.Appearance.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnConnect.Appearance.Options.UseFont = true;
            this.btnConnect.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnConnect.ImageOptions.Image")));
            this.btnConnect.Location = new System.Drawing.Point(13, 33);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(121, 45);
            this.btnConnect.TabIndex = 57;
            this.btnConnect.Text = "Bağlan";
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // lblHastaCard
            // 
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
            // dateTimeVaccine
            // 
            this.dateTimeVaccine.EditValue = null;
            this.dateTimeVaccine.Location = new System.Drawing.Point(28, 117);
            this.dateTimeVaccine.Name = "dateTimeVaccine";
            this.dateTimeVaccine.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateTimeVaccine.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateTimeVaccine.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.dateTimeVaccine.Size = new System.Drawing.Size(152, 20);
            this.dateTimeVaccine.TabIndex = 70;
            // 
            // panelControl3
            // 
            this.panelControl3.Controls.Add(this.groupControl1);
            this.panelControl3.Controls.Add(this.navBarControl1);
            this.panelControl3.Location = new System.Drawing.Point(12, 194);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(737, 286);
            this.panelControl3.TabIndex = 71;
            // 
            // groupControl1
            // 
            this.groupControl1.AppearanceCaption.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupControl1.AppearanceCaption.Options.UseFont = true;
            this.groupControl1.Controls.Add(this.panelControl5);
            this.groupControl1.Controls.Add(this.pnlVaccination);
            this.groupControl1.Controls.Add(this.pnlOperation);
            this.groupControl1.Location = new System.Drawing.Point(239, 7);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(481, 272);
            this.groupControl1.TabIndex = 80;
            // 
            // panelControl5
            // 
            this.panelControl5.Controls.Add(this.pictureBox2);
            this.panelControl5.Location = new System.Drawing.Point(19, 29);
            this.panelControl5.Name = "panelControl5";
            this.panelControl5.Size = new System.Drawing.Size(441, 233);
            this.panelControl5.TabIndex = 77;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox2.Image = global::VeterinaryTrackingSystem.Properties.Resources.Icon128;
            this.pictureBox2.Location = new System.Drawing.Point(147, 27);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(160, 180);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 107;
            this.pictureBox2.TabStop = false;
            // 
            // pnlVaccination
            // 
            this.pnlVaccination.Controls.Add(this.cmbVaccines);
            this.pnlVaccination.Controls.Add(this.dateTimeVaccine);
            this.pnlVaccination.Controls.Add(this.labelControl3);
            this.pnlVaccination.Controls.Add(this.btnVaccineSave);
            this.pnlVaccination.Controls.Add(this.labelControl7);
            this.pnlVaccination.Enabled = false;
            this.pnlVaccination.Location = new System.Drawing.Point(40, 39);
            this.pnlVaccination.Name = "pnlVaccination";
            this.pnlVaccination.Size = new System.Drawing.Size(202, 209);
            this.pnlVaccination.TabIndex = 72;
            this.pnlVaccination.Visible = false;
            // 
            // cmbVaccines
            // 
            this.cmbVaccines.Location = new System.Drawing.Point(28, 43);
            this.cmbVaccines.Name = "cmbVaccines";
            this.cmbVaccines.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbVaccines.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cmbVaccines.Size = new System.Drawing.Size(153, 20);
            this.cmbVaccines.TabIndex = 34;
            this.cmbVaccines.SelectedIndexChanged += new System.EventHandler(this.cmbVaccines_SelectedIndexChanged);
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(27, 23);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(38, 13);
            this.labelControl3.TabIndex = 72;
            this.labelControl3.Text = "Aşı Adı:";
            // 
            // btnVaccineSave
            // 
            this.btnVaccineSave.Appearance.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnVaccineSave.Appearance.Options.UseFont = true;
            this.btnVaccineSave.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnVaccineSave.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnVaccineSave.ImageOptions.SvgImage")));
            this.btnVaccineSave.Location = new System.Drawing.Point(28, 143);
            this.btnVaccineSave.Name = "btnVaccineSave";
            this.btnVaccineSave.Size = new System.Drawing.Size(153, 44);
            this.btnVaccineSave.TabIndex = 75;
            this.btnVaccineSave.Text = "Kayıt";
            this.btnVaccineSave.Click += new System.EventHandler(this.btnVaccineSave_Click);
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(27, 95);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(29, 13);
            this.labelControl7.TabIndex = 74;
            this.labelControl7.Text = "Tarih:";
            // 
            // pnlOperation
            // 
            this.pnlOperation.Controls.Add(this.dateTimeOperation);
            this.pnlOperation.Controls.Add(this.btnOperationSave);
            this.pnlOperation.Controls.Add(this.cmbOperations);
            this.pnlOperation.Controls.Add(this.labelControl6);
            this.pnlOperation.Controls.Add(this.labelControl9);
            this.pnlOperation.Enabled = false;
            this.pnlOperation.Location = new System.Drawing.Point(248, 38);
            this.pnlOperation.Name = "pnlOperation";
            this.pnlOperation.Size = new System.Drawing.Size(202, 209);
            this.pnlOperation.TabIndex = 76;
            this.pnlOperation.Visible = false;
            // 
            // dateTimeOperation
            // 
            this.dateTimeOperation.EditValue = null;
            this.dateTimeOperation.Location = new System.Drawing.Point(24, 118);
            this.dateTimeOperation.Name = "dateTimeOperation";
            this.dateTimeOperation.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateTimeOperation.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateTimeOperation.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.dateTimeOperation.Size = new System.Drawing.Size(152, 20);
            this.dateTimeOperation.TabIndex = 76;
            // 
            // btnOperationSave
            // 
            this.btnOperationSave.Appearance.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOperationSave.Appearance.Options.UseFont = true;
            this.btnOperationSave.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.btnOperationSave.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnOperationSave.ImageOptions.SvgImage")));
            this.btnOperationSave.Location = new System.Drawing.Point(25, 144);
            this.btnOperationSave.Name = "btnOperationSave";
            this.btnOperationSave.Size = new System.Drawing.Size(153, 45);
            this.btnOperationSave.TabIndex = 75;
            this.btnOperationSave.Text = "Kayıt";
            this.btnOperationSave.Click += new System.EventHandler(this.btnOperationSave_Click);
            // 
            // cmbOperations
            // 
            this.cmbOperations.Location = new System.Drawing.Point(25, 43);
            this.cmbOperations.Name = "cmbOperations";
            this.cmbOperations.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbOperations.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cmbOperations.Size = new System.Drawing.Size(153, 20);
            this.cmbOperations.TabIndex = 71;
            this.cmbOperations.SelectedIndexChanged += new System.EventHandler(this.cmbOperations_SelectedIndexChanged);
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(24, 23);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(79, 13);
            this.labelControl6.TabIndex = 73;
            this.labelControl6.Text = "Operasyon Adı:";
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl9.Appearance.Options.UseFont = true;
            this.labelControl9.Location = new System.Drawing.Point(25, 95);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(29, 13);
            this.labelControl9.TabIndex = 74;
            this.labelControl9.Text = "Tarih:";
            // 
            // navBarControl1
            // 
            this.navBarControl1.ActiveGroup = this.navBarGroup1;
            this.navBarControl1.Appearance.Background.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.navBarControl1.Appearance.Background.Options.UseFont = true;
            this.navBarControl1.Appearance.GroupBackground.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.navBarControl1.Appearance.GroupBackground.Options.UseFont = true;
            this.navBarControl1.Appearance.GroupHeader.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.navBarControl1.Appearance.GroupHeader.Options.UseFont = true;
            this.navBarControl1.Appearance.GroupHeaderActive.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.navBarControl1.Appearance.GroupHeaderActive.Options.UseFont = true;
            this.navBarControl1.Appearance.GroupHeaderHotTracked.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.navBarControl1.Appearance.GroupHeaderHotTracked.Options.UseFont = true;
            this.navBarControl1.Appearance.Item.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.navBarControl1.Appearance.Item.Options.UseFont = true;
            this.navBarControl1.Appearance.NavigationPaneHeader.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.navBarControl1.Appearance.NavigationPaneHeader.Options.UseFont = true;
            this.navBarControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.navBarControl1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.navBarControl1.Groups.AddRange(new DevExpress.XtraNavBar.NavBarGroup[] {
            this.navBarGroup1});
            this.navBarControl1.Items.AddRange(new DevExpress.XtraNavBar.NavBarItem[] {
            this.navBarSeparatorItem1,
            this.navBarItem1,
            this.navBarSeparatorItem2,
            this.navBarItem2,
            this.navBarSeparatorItem3});
            this.navBarControl1.Location = new System.Drawing.Point(2, 2);
            this.navBarControl1.Name = "navBarControl1";
            this.navBarControl1.OptionsNavPane.ExpandedWidth = 219;
            this.navBarControl1.PaintStyleKind = DevExpress.XtraNavBar.NavBarViewKind.NavigationPane;
            this.navBarControl1.Size = new System.Drawing.Size(219, 282);
            this.navBarControl1.TabIndex = 77;
            this.navBarControl1.Text = "navBarControl1";
            // 
            // navBarGroup1
            // 
            this.navBarGroup1.Caption = "Hasta Karnesi";
            this.navBarGroup1.Expanded = true;
            this.navBarGroup1.GroupStyle = DevExpress.XtraNavBar.NavBarGroupStyle.SmallIconsList;
            this.navBarGroup1.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarSeparatorItem1),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem1),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarSeparatorItem2),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem2),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarSeparatorItem3)});
            this.navBarGroup1.Name = "navBarGroup1";
            // 
            // navBarSeparatorItem1
            // 
            this.navBarSeparatorItem1.CanDrag = false;
            this.navBarSeparatorItem1.Enabled = false;
            this.navBarSeparatorItem1.Hint = null;
            this.navBarSeparatorItem1.Name = "navBarSeparatorItem1";
            // 
            // navBarItem1
            // 
            this.navBarItem1.Appearance.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.navBarItem1.Appearance.Options.UseFont = true;
            this.navBarItem1.Caption = "Aşı Ekle";
            this.navBarItem1.ImageOptions.SmallImage = global::VeterinaryTrackingSystem.Properties.Resources.add;
            this.navBarItem1.Name = "navBarItem1";
            this.navBarItem1.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarItem1_LinkClicked);
            // 
            // navBarSeparatorItem2
            // 
            this.navBarSeparatorItem2.CanDrag = false;
            this.navBarSeparatorItem2.Enabled = false;
            this.navBarSeparatorItem2.Hint = null;
            this.navBarSeparatorItem2.ImageOptions.SmallImage = global::VeterinaryTrackingSystem.Properties.Resources.add;
            this.navBarSeparatorItem2.Name = "navBarSeparatorItem2";
            // 
            // navBarItem2
            // 
            this.navBarItem2.Appearance.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.navBarItem2.Appearance.Options.UseFont = true;
            this.navBarItem2.Caption = "Operasyon Ekle";
            this.navBarItem2.ImageOptions.SmallImage = global::VeterinaryTrackingSystem.Properties.Resources.add;
            this.navBarItem2.Name = "navBarItem2";
            this.navBarItem2.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.navBarItem2_LinkClicked);
            // 
            // navBarSeparatorItem3
            // 
            this.navBarSeparatorItem3.CanDrag = false;
            this.navBarSeparatorItem3.Enabled = false;
            this.navBarSeparatorItem3.Hint = null;
            this.navBarSeparatorItem3.Name = "navBarSeparatorItem3";
            // 
            // lstID
            // 
            this.lstID.Location = new System.Drawing.Point(14, 555);
            this.lstID.Name = "lstID";
            this.lstID.Size = new System.Drawing.Size(120, 95);
            this.lstID.TabIndex = 78;
            // 
            // lstVaccineID
            // 
            this.lstVaccineID.Location = new System.Drawing.Point(140, 555);
            this.lstVaccineID.Name = "lstVaccineID";
            this.lstVaccineID.Size = new System.Drawing.Size(120, 95);
            this.lstVaccineID.TabIndex = 78;
            // 
            // lstOperationID
            // 
            this.lstOperationID.Location = new System.Drawing.Point(266, 555);
            this.lstOperationID.Name = "lstOperationID";
            this.lstOperationID.Size = new System.Drawing.Size(120, 95);
            this.lstOperationID.TabIndex = 79;
            // 
            // panelControl4
            // 
            this.panelControl4.Controls.Add(this.btnClose);
            this.panelControl4.Controls.Add(this.btnMinimize);
            this.panelControl4.Controls.Add(this.labelControl4);
            this.panelControl4.Location = new System.Drawing.Point(12, 6);
            this.panelControl4.Name = "panelControl4";
            this.panelControl4.Size = new System.Drawing.Size(737, 38);
            this.panelControl4.TabIndex = 80;
            // 
            // btnClose
            // 
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClose.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.ImageOptions.Image")));
            this.btnClose.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btnClose.Location = new System.Drawing.Point(703, 2);
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
            this.btnMinimize.Location = new System.Drawing.Point(674, 5);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnMinimize.Size = new System.Drawing.Size(29, 29);
            this.btnMinimize.TabIndex = 93;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
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
            // groupControl2
            // 
            this.groupControl2.AppearanceCaption.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupControl2.AppearanceCaption.Options.UseFont = true;
            this.groupControl2.Controls.Add(this.panelControl2);
            this.groupControl2.Controls.Add(this.panelControl1);
            this.groupControl2.Location = new System.Drawing.Point(12, 43);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(737, 150);
            this.groupControl2.TabIndex = 81;
            this.groupControl2.Text = "Karne Ekleme Formu";
            // 
            // frmCertificate
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 492);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.panelControl4);
            this.Controls.Add(this.lstOperationID);
            this.Controls.Add(this.lstVaccineID);
            this.Controls.Add(this.lstID);
            this.Controls.Add(this.panelControl3);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("frmCertificate.IconOptions.Icon")));
            this.Name = "frmCertificate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCertificate";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmCertificate_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmCertificate_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.frmCertificate_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbPatients.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateTimeVaccine.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateTimeVaccine.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl5)).EndInit();
            this.panelControl5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlVaccination)).EndInit();
            this.pnlVaccination.ResumeLayout(false);
            this.pnlVaccination.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbVaccines.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlOperation)).EndInit();
            this.pnlOperation.ResumeLayout(false);
            this.pnlOperation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateTimeOperation.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateTimeOperation.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbOperations.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lstID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lstVaccineID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lstOperationID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).EndInit();
            this.panelControl4.ResumeLayout(false);
            this.panelControl4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Timer timerSerialPort;
        private DevExpress.XtraEditors.LabelControl lblCustomerName;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton btnSelect;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.ComboBoxEdit cmbPatients;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.SimpleButton btnConnect;
        private DevExpress.XtraEditors.LabelControl lblHastaCard;
        private DevExpress.XtraEditors.LabelControl lblSuccess;
        private DevExpress.XtraEditors.DateEdit dateTimeVaccine;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private DevExpress.XtraEditors.SimpleButton btnVaccineSave;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.ComboBoxEdit cmbOperations;
        private DevExpress.XtraEditors.ComboBoxEdit cmbVaccines;
        private DevExpress.XtraNavBar.NavBarControl navBarControl1;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup1;
        private DevExpress.XtraNavBar.NavBarSeparatorItem navBarSeparatorItem1;
        private DevExpress.XtraNavBar.NavBarItem navBarItem1;
        private DevExpress.XtraNavBar.NavBarSeparatorItem navBarSeparatorItem2;
        private DevExpress.XtraNavBar.NavBarItem navBarItem2;
        private DevExpress.XtraNavBar.NavBarSeparatorItem navBarSeparatorItem3;
        private DevExpress.XtraEditors.PanelControl pnlVaccination;
        private DevExpress.XtraEditors.PanelControl pnlOperation;
        private DevExpress.XtraEditors.SimpleButton btnOperationSave;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.ListBoxControl lstID;
        private DevExpress.XtraEditors.ListBoxControl lstVaccineID;
        private DevExpress.XtraEditors.ListBoxControl lstOperationID;
        private DevExpress.XtraEditors.DateEdit dateTimeOperation;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.PanelControl panelControl4;
        private DevExpress.XtraEditors.SimpleButton btnClose;
        private DevExpress.XtraEditors.SimpleButton btnMinimize;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private DevExpress.XtraEditors.PanelControl panelControl5;
    }
}