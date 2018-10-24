using SMOWMS.UI.UserControl;

namespace SMOWMS.UI.MasterData
{
    partial class frmAssetsDetailEdit : Smobiler.Core.Controls.MobileForm
    {
        #region "SmobilerForm generated code "

        public frmAssetsDetailEdit()
            : base()
        {
            //This call is required by the SmobilerForm.
            InitializeComponent();

            //Add any initialization after the InitializeComponent() call
        }

        //SmobilerForm overrides dispose to clean up the component list.
        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }


        //NOTE: The following procedure is required by the SmobilerForm
        //It can be modified using the SmobilerForm.  
        //Do not modify it using the code editor.
        [System.Diagnostics.DebuggerStepThrough()]
        private void InitializeComponent()
        {
            this.Title1 = new SMOWMS.UI.UserControl.Title();
            this.plButton = new Smobiler.Core.Controls.Panel();
            this.btnSave2 = new Smobiler.Core.Controls.Button();
            this.PopType = new Smobiler.Core.Controls.PopList();
            this.CamPicture = new Smobiler.Core.Controls.Camera();
            this.plContent = new Smobiler.Core.Controls.Panel();
            this.Label14 = new Smobiler.Core.Controls.Label();
            this.txtSN = new Smobiler.Core.Controls.TextBox();
            this.DatePickerBuy = new Smobiler.Core.Controls.DatePicker();
            this.DatePickerExpiry = new Smobiler.Core.Controls.DatePicker();
            this.txtAssID = new Smobiler.Core.Controls.TextBox();
            this.label35 = new Smobiler.Core.Controls.Label();
            this.label36 = new Smobiler.Core.Controls.Label();
            this.label37 = new Smobiler.Core.Controls.Label();
            this.label38 = new Smobiler.Core.Controls.Label();
            this.label39 = new Smobiler.Core.Controls.Label();
            this.label40 = new Smobiler.Core.Controls.Label();
            this.label41 = new Smobiler.Core.Controls.Label();
            this.label42 = new Smobiler.Core.Controls.Label();
            this.label43 = new Smobiler.Core.Controls.Label();
            this.label44 = new Smobiler.Core.Controls.Label();
            this.label45 = new Smobiler.Core.Controls.Label();
            this.label46 = new Smobiler.Core.Controls.Label();
            this.txtName1 = new Smobiler.Core.Controls.TextBox();
            this.txtSPE1 = new Smobiler.Core.Controls.TextBox();
            this.txtUnit1 = new Smobiler.Core.Controls.TextBox();
            this.txtATID = new Smobiler.Core.Controls.TextBox();
            this.txtSN1 = new Smobiler.Core.Controls.TextBox();
            this.txtPrice1 = new Smobiler.Core.Controls.TextBox();
            this.panel6 = new Smobiler.Core.Controls.Panel();
            this.image2 = new Smobiler.Core.Controls.Image();
            this.label47 = new Smobiler.Core.Controls.Label();
            this.txtNote1 = new Smobiler.Core.Controls.TextBox();
            this.label48 = new Smobiler.Core.Controls.Label();
            this.txtAssId1 = new Smobiler.Core.Controls.TextBox();
            this.label49 = new Smobiler.Core.Controls.Label();
            this.txtPlace1 = new Smobiler.Core.Controls.TextBox();
            this.label50 = new Smobiler.Core.Controls.Label();
            this.label51 = new Smobiler.Core.Controls.Label();
            this.txtVendor1 = new Smobiler.Core.Controls.TextBox();
            this.txtType = new Smobiler.Core.Controls.TextBox();
            this.txtSL = new Smobiler.Core.Controls.TextBox();
            this.txtManager = new Smobiler.Core.Controls.TextBox();
            this.ImgBtnForSN = new Smobiler.Core.Controls.ImageButton();
            this.r2000Scanner1 = new Smobiler.Device.R2000Scanner();
            this.barcodeScanner1 = new Smobiler.Core.Controls.BarcodeScanner();
            this.btnSave = new Smobiler.Core.Controls.Button();
            // 
            // Title1
            // 
            this.Title1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(164)))), ((int)(((byte)(229)))));
            this.Title1.Dock = System.Windows.Forms.DockStyle.Top;
            this.Title1.FontSize = 15F;
            this.Title1.ForeColor = System.Drawing.Color.White;
            this.Title1.Name = "Title1";
            this.Title1.Size = new System.Drawing.Size(300, 40);
            this.Title1.TitleText = "�ʲ��༭";
            // 
            // plButton
            // 
            this.plButton.BackColor = System.Drawing.Color.White;
            this.plButton.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 0F);
            this.plButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.plButton.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.btnSave2});
            this.plButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.plButton.Location = new System.Drawing.Point(0, 40);
            this.plButton.Name = "plButton";
            this.plButton.Size = new System.Drawing.Size(300, 50);
            // 
            // btnSave2
            // 
            this.btnSave2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(124)))), ((int)(((byte)(246)))));
            this.btnSave2.Location = new System.Drawing.Point(12, 0);
            this.btnSave2.Name = "btnSave2";
            this.btnSave2.Size = new System.Drawing.Size(276, 38);
            this.btnSave2.Text = "����";
            this.btnSave2.Press += new System.EventHandler(this.btnSave_Press);
            // 
            // PopType
            // 
            this.PopType.Name = "PopType";
            // 
            // CamPicture
            // 
            this.CamPicture.Name = "CamPicture";
            this.CamPicture.ImageCaptured += new Smobiler.Core.Controls.CameraOnlineCallBackHandler(this.CamPicture_ImageCaptured);
            // 
            // plContent
            // 
            this.plContent.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.Label14,
            this.txtSN,
            this.DatePickerBuy,
            this.DatePickerExpiry,
            this.txtAssID,
            this.label35,
            this.label36,
            this.label37,
            this.label38,
            this.label39,
            this.label40,
            this.label41,
            this.label42,
            this.label43,
            this.label44,
            this.label45,
            this.label46,
            this.txtName1,
            this.txtSPE1,
            this.txtUnit1,
            this.txtATID,
            this.txtSN1,
            this.txtPrice1,
            this.panel6,
            this.label47,
            this.txtNote1,
            this.label48,
            this.txtAssId1,
            this.label49,
            this.txtPlace1,
            this.label50,
            this.label51,
            this.txtVendor1,
            this.txtType,
            this.txtSL,
            this.txtManager,
            this.ImgBtnForSN});
            this.plContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.plContent.Flex = 10000;
            this.plContent.Location = new System.Drawing.Point(0, 70);
            this.plContent.Name = "plContent";
            this.plContent.Scrollable = true;
            this.plContent.Size = new System.Drawing.Size(300, 410);
            // 
            // Label14
            // 
            this.Label14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.Label14.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 0F);
            this.Label14.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.Label14.Name = "Label14";
            this.Label14.Padding = new Smobiler.Core.Controls.Padding(12F, 0F, 0F, 0F);
            this.Label14.Size = new System.Drawing.Size(68, 36);
            this.Label14.Text = "�ʲ����";
            // 
            // txtSN
            // 
            this.txtSN.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.txtSN.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Right;
            this.txtSN.Location = new System.Drawing.Point(100, 135);
            this.txtSN.Name = "txtSN";
            this.txtSN.Padding = new Smobiler.Core.Controls.Padding(0F, 0F, 5F, 0F);
            this.txtSN.Size = new System.Drawing.Size(140, 40);
            this.txtSN.WaterMarkText = "(ѡ��,֧��ɨ��)";
            this.txtSN.WaterMarkTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            // 
            // DatePickerBuy
            // 
            this.DatePickerBuy.BackColor = System.Drawing.Color.White;
            this.DatePickerBuy.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 0F);
            this.DatePickerBuy.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.DatePickerBuy.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Left;
            this.DatePickerBuy.Location = new System.Drawing.Point(68, 434);
            this.DatePickerBuy.Name = "DatePickerBuy";
            this.DatePickerBuy.Padding = new Smobiler.Core.Controls.Padding(7F, 0F, 0F, 0F);
            this.DatePickerBuy.Size = new System.Drawing.Size(232, 36);
            // 
            // DatePickerExpiry
            // 
            this.DatePickerExpiry.BackColor = System.Drawing.Color.White;
            this.DatePickerExpiry.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 0F);
            this.DatePickerExpiry.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.DatePickerExpiry.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Left;
            this.DatePickerExpiry.Location = new System.Drawing.Point(68, 470);
            this.DatePickerExpiry.Name = "DatePickerExpiry";
            this.DatePickerExpiry.Padding = new Smobiler.Core.Controls.Padding(7F, 0F, 0F, 0F);
            this.DatePickerExpiry.Size = new System.Drawing.Size(232, 36);
            // 
            // txtAssID
            // 
            this.txtAssID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.txtAssID.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 0F);
            this.txtAssID.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.txtAssID.KeyboardType = Smobiler.Core.Controls.KeyboardType.Numeric;
            this.txtAssID.Location = new System.Drawing.Point(68, 0);
            this.txtAssID.Name = "txtAssID";
            this.txtAssID.Padding = new Smobiler.Core.Controls.Padding(7F, 0F, 0F, 0F);
            this.txtAssID.ReadOnly = true;
            this.txtAssID.Size = new System.Drawing.Size(232, 36);
            this.txtAssID.Text = "20";
            this.txtAssID.WaterMarkText = "(����)";
            this.txtAssID.WaterMarkTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            // 
            // label35
            // 
            this.label35.BackColor = System.Drawing.Color.White;
            this.label35.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 0F);
            this.label35.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.label35.Location = new System.Drawing.Point(0, 72);
            this.label35.Name = "label35";
            this.label35.Padding = new Smobiler.Core.Controls.Padding(12F, 0F, 0F, 0F);
            this.label35.Size = new System.Drawing.Size(68, 55);
            this.label35.Text = "ͼƬ";
            // 
            // label36
            // 
            this.label36.BackColor = System.Drawing.Color.White;
            this.label36.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 0F);
            this.label36.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.label36.Location = new System.Drawing.Point(0, 36);
            this.label36.Name = "label36";
            this.label36.Padding = new Smobiler.Core.Controls.Padding(12F, 0F, 0F, 0F);
            this.label36.Size = new System.Drawing.Size(68, 36);
            this.label36.Text = "����";
            // 
            // label37
            // 
            this.label37.BackColor = System.Drawing.Color.White;
            this.label37.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 0F);
            this.label37.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.label37.Location = new System.Drawing.Point(0, 199);
            this.label37.Name = "label37";
            this.label37.Padding = new Smobiler.Core.Controls.Padding(12F, 0F, 0F, 0F);
            this.label37.Size = new System.Drawing.Size(68, 36);
            this.label37.Text = "���";
            // 
            // label38
            // 
            this.label38.BackColor = System.Drawing.Color.White;
            this.label38.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 0F);
            this.label38.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.label38.Location = new System.Drawing.Point(0, 235);
            this.label38.Name = "label38";
            this.label38.Padding = new Smobiler.Core.Controls.Padding(12F, 0F, 0F, 0F);
            this.label38.Size = new System.Drawing.Size(68, 55);
            this.label38.Text = "����ͺ�";
            // 
            // label39
            // 
            this.label39.BackColor = System.Drawing.Color.White;
            this.label39.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 0F);
            this.label39.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.label39.Location = new System.Drawing.Point(0, 290);
            this.label39.Name = "label39";
            this.label39.Padding = new Smobiler.Core.Controls.Padding(12F, 0F, 0F, 0F);
            this.label39.Size = new System.Drawing.Size(68, 36);
            this.label39.Text = "��λ";
            // 
            // label40
            // 
            this.label40.BackColor = System.Drawing.Color.White;
            this.label40.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 0F);
            this.label40.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.label40.Location = new System.Drawing.Point(0, 362);
            this.label40.Name = "label40";
            this.label40.Padding = new Smobiler.Core.Controls.Padding(12F, 0F, 0F, 0F);
            this.label40.Size = new System.Drawing.Size(68, 36);
            this.label40.Text = "ģ����";
            // 
            // label41
            // 
            this.label41.BackColor = System.Drawing.Color.White;
            this.label41.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 0F);
            this.label41.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.label41.Location = new System.Drawing.Point(0, 398);
            this.label41.Name = "label41";
            this.label41.Padding = new Smobiler.Core.Controls.Padding(12F, 0F, 0F, 0F);
            this.label41.Size = new System.Drawing.Size(68, 36);
            this.label41.Text = "��λ";
            // 
            // label42
            // 
            this.label42.BackColor = System.Drawing.Color.White;
            this.label42.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 0F);
            this.label42.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.label42.Location = new System.Drawing.Point(0, 127);
            this.label42.Name = "label42";
            this.label42.Padding = new Smobiler.Core.Controls.Padding(12F, 0F, 0F, 0F);
            this.label42.Size = new System.Drawing.Size(68, 36);
            this.label42.Text = "SN";
            // 
            // label43
            // 
            this.label43.BackColor = System.Drawing.Color.White;
            this.label43.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 0F);
            this.label43.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.label43.Location = new System.Drawing.Point(0, 163);
            this.label43.Name = "label43";
            this.label43.Padding = new Smobiler.Core.Controls.Padding(12F, 0F, 0F, 0F);
            this.label43.Size = new System.Drawing.Size(68, 36);
            this.label43.Text = "���";
            // 
            // label44
            // 
            this.label44.BackColor = System.Drawing.Color.White;
            this.label44.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 0F);
            this.label44.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.label44.Location = new System.Drawing.Point(0, 434);
            this.label44.Name = "label44";
            this.label44.Padding = new Smobiler.Core.Controls.Padding(12F, 0F, 0F, 0F);
            this.label44.Size = new System.Drawing.Size(68, 36);
            this.label44.Text = "����ʱ��";
            // 
            // label45
            // 
            this.label45.BackColor = System.Drawing.Color.White;
            this.label45.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 0F);
            this.label45.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.label45.Name = "label45";
            this.label45.Padding = new Smobiler.Core.Controls.Padding(12F, 0F, 0F, 0F);
            this.label45.Size = new System.Drawing.Size(68, 36);
            this.label45.Text = "�ʲ����";
            // 
            // label46
            // 
            this.label46.BackColor = System.Drawing.Color.White;
            this.label46.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 0F);
            this.label46.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.label46.Location = new System.Drawing.Point(68, 72);
            this.label46.Name = "label46";
            this.label46.Padding = new Smobiler.Core.Controls.Padding(7F, 0F, 0F, 0F);
            this.label46.Size = new System.Drawing.Size(232, 55);
            // 
            // txtName1
            // 
            this.txtName1.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 0F);
            this.txtName1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.txtName1.Location = new System.Drawing.Point(68, 36);
            this.txtName1.Name = "txtName1";
            this.txtName1.Padding = new Smobiler.Core.Controls.Padding(7F, 0F, 0F, 0F);
            this.txtName1.ReadOnly = true;
            this.txtName1.Size = new System.Drawing.Size(232, 36);
            this.txtName1.WaterMarkTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            // 
            // txtSPE1
            // 
            this.txtSPE1.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 0F);
            this.txtSPE1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.txtSPE1.Location = new System.Drawing.Point(68, 235);
            this.txtSPE1.Multiline = true;
            this.txtSPE1.Name = "txtSPE1";
            this.txtSPE1.Padding = new Smobiler.Core.Controls.Padding(7F, 5F, 5F, 0F);
            this.txtSPE1.ReadOnly = true;
            this.txtSPE1.Size = new System.Drawing.Size(232, 55);
            this.txtSPE1.WaterMarkTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            // 
            // txtUnit1
            // 
            this.txtUnit1.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 0F);
            this.txtUnit1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.txtUnit1.Location = new System.Drawing.Point(68, 398);
            this.txtUnit1.Name = "txtUnit1";
            this.txtUnit1.Padding = new Smobiler.Core.Controls.Padding(7F, 0F, 0F, 0F);
            this.txtUnit1.ReadOnly = true;
            this.txtUnit1.Size = new System.Drawing.Size(232, 36);
            this.txtUnit1.WaterMarkTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            // 
            // txtATID
            // 
            this.txtATID.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 0F);
            this.txtATID.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.txtATID.KeyboardType = Smobiler.Core.Controls.KeyboardType.Numeric;
            this.txtATID.Location = new System.Drawing.Point(68, 362);
            this.txtATID.Name = "txtATID";
            this.txtATID.Padding = new Smobiler.Core.Controls.Padding(7F, 0F, 0F, 0F);
            this.txtATID.ReadOnly = true;
            this.txtATID.Size = new System.Drawing.Size(232, 36);
            this.txtATID.WaterMarkTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            // 
            // txtSN1
            // 
            this.txtSN1.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 0F);
            this.txtSN1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.txtSN1.KeyboardType = Smobiler.Core.Controls.KeyboardType.Numeric;
            this.txtSN1.Location = new System.Drawing.Point(68, 127);
            this.txtSN1.Name = "txtSN1";
            this.txtSN1.Padding = new Smobiler.Core.Controls.Padding(7F, 0F, 0F, 0F);
            this.txtSN1.ReadOnly = true;
            this.txtSN1.Size = new System.Drawing.Size(232, 36);
            this.txtSN1.WaterMarkTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            // 
            // txtPrice1
            // 
            this.txtPrice1.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 0F);
            this.txtPrice1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.txtPrice1.KeyboardType = Smobiler.Core.Controls.KeyboardType.Numeric;
            this.txtPrice1.Location = new System.Drawing.Point(68, 163);
            this.txtPrice1.Name = "txtPrice1";
            this.txtPrice1.Padding = new Smobiler.Core.Controls.Padding(7F, 0F, 0F, 0F);
            this.txtPrice1.ReadOnly = true;
            this.txtPrice1.Size = new System.Drawing.Size(232, 36);
            this.txtPrice1.WaterMarkTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.txtPrice1.TextChanged += new System.EventHandler(this.txtPrice_TextChanged);
            // 
            // panel6
            // 
            this.panel6.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.image2});
            this.panel6.Location = new System.Drawing.Point(260, 84);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(30, 30);
            this.panel6.Press += new System.EventHandler(this.PanelImg_Press);
            // 
            // image2
            // 
            this.image2.Name = "image2";
            this.image2.ResourceID = "mare";
            this.image2.Size = new System.Drawing.Size(30, 30);
            // 
            // label47
            // 
            this.label47.BackColor = System.Drawing.Color.White;
            this.label47.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 0F);
            this.label47.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.label47.Location = new System.Drawing.Point(0, 578);
            this.label47.Name = "label47";
            this.label47.Padding = new Smobiler.Core.Controls.Padding(12F, 0F, 0F, 0F);
            this.label47.Size = new System.Drawing.Size(68, 55);
            this.label47.Text = "��ע";
            // 
            // txtNote1
            // 
            this.txtNote1.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 0F);
            this.txtNote1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.txtNote1.Location = new System.Drawing.Point(68, 578);
            this.txtNote1.Multiline = true;
            this.txtNote1.Name = "txtNote1";
            this.txtNote1.Padding = new Smobiler.Core.Controls.Padding(7F, 5F, 5F, 0F);
            this.txtNote1.ReadOnly = true;
            this.txtNote1.Size = new System.Drawing.Size(232, 55);
            this.txtNote1.WaterMarkTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            // 
            // label48
            // 
            this.label48.BackColor = System.Drawing.Color.White;
            this.label48.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 0F);
            this.label48.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.label48.Location = new System.Drawing.Point(0, 470);
            this.label48.Name = "label48";
            this.label48.Padding = new Smobiler.Core.Controls.Padding(12F, 0F, 0F, 0F);
            this.label48.Size = new System.Drawing.Size(68, 36);
            this.label48.Text = "����ʱ��";
            // 
            // txtAssId1
            // 
            this.txtAssId1.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 0F);
            this.txtAssId1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.txtAssId1.KeyboardType = Smobiler.Core.Controls.KeyboardType.Numeric;
            this.txtAssId1.Location = new System.Drawing.Point(68, 0);
            this.txtAssId1.Name = "txtAssId1";
            this.txtAssId1.Padding = new Smobiler.Core.Controls.Padding(7F, 0F, 0F, 0F);
            this.txtAssId1.ReadOnly = true;
            this.txtAssId1.Size = new System.Drawing.Size(232, 36);
            this.txtAssId1.WaterMarkText = "(����)";
            this.txtAssId1.WaterMarkTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            // 
            // label49
            // 
            this.label49.BackColor = System.Drawing.Color.White;
            this.label49.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 0F);
            this.label49.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.label49.Location = new System.Drawing.Point(0, 326);
            this.label49.Name = "label49";
            this.label49.Padding = new Smobiler.Core.Controls.Padding(12F, 0F, 0F, 0F);
            this.label49.Size = new System.Drawing.Size(68, 36);
            this.label49.Text = "�ص�";
            // 
            // txtPlace1
            // 
            this.txtPlace1.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 0F);
            this.txtPlace1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.txtPlace1.KeyboardType = Smobiler.Core.Controls.KeyboardType.Numeric;
            this.txtPlace1.Location = new System.Drawing.Point(68, 326);
            this.txtPlace1.Name = "txtPlace1";
            this.txtPlace1.Padding = new Smobiler.Core.Controls.Padding(7F, 0F, 0F, 0F);
            this.txtPlace1.ReadOnly = true;
            this.txtPlace1.Size = new System.Drawing.Size(232, 36);
            this.txtPlace1.WaterMarkTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            // 
            // label50
            // 
            this.label50.BackColor = System.Drawing.Color.White;
            this.label50.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 0F);
            this.label50.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.label50.Location = new System.Drawing.Point(0, 506);
            this.label50.Name = "label50";
            this.label50.Padding = new Smobiler.Core.Controls.Padding(12F, 0F, 0F, 0F);
            this.label50.Size = new System.Drawing.Size(68, 36);
            this.label50.Text = "��Ӧ��";
            // 
            // label51
            // 
            this.label51.BackColor = System.Drawing.Color.White;
            this.label51.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 0F);
            this.label51.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.label51.Location = new System.Drawing.Point(0, 542);
            this.label51.Name = "label51";
            this.label51.Padding = new Smobiler.Core.Controls.Padding(12F, 0F, 0F, 0F);
            this.label51.Size = new System.Drawing.Size(68, 36);
            this.label51.Text = "������";
            // 
            // txtVendor1
            // 
            this.txtVendor1.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 0F);
            this.txtVendor1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.txtVendor1.KeyboardType = Smobiler.Core.Controls.KeyboardType.Numeric;
            this.txtVendor1.Location = new System.Drawing.Point(68, 506);
            this.txtVendor1.Name = "txtVendor1";
            this.txtVendor1.Padding = new Smobiler.Core.Controls.Padding(7F, 0F, 0F, 0F);
            this.txtVendor1.ReadOnly = true;
            this.txtVendor1.Size = new System.Drawing.Size(232, 36);
            this.txtVendor1.WaterMarkTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            // 
            // txtType
            // 
            this.txtType.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 0F);
            this.txtType.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.txtType.Location = new System.Drawing.Point(68, 199);
            this.txtType.Name = "txtType";
            this.txtType.Padding = new Smobiler.Core.Controls.Padding(7F, 0F, 0F, 0F);
            this.txtType.ReadOnly = true;
            this.txtType.Size = new System.Drawing.Size(232, 36);
            // 
            // txtSL
            // 
            this.txtSL.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 0F);
            this.txtSL.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.txtSL.Location = new System.Drawing.Point(68, 290);
            this.txtSL.Name = "txtSL";
            this.txtSL.Padding = new Smobiler.Core.Controls.Padding(7F, 0F, 0F, 0F);
            this.txtSL.ReadOnly = true;
            this.txtSL.Size = new System.Drawing.Size(232, 36);
            // 
            // txtManager
            // 
            this.txtManager.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 0F);
            this.txtManager.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.txtManager.Location = new System.Drawing.Point(68, 542);
            this.txtManager.Name = "txtManager";
            this.txtManager.Padding = new Smobiler.Core.Controls.Padding(7F, 0F, 0F, 0F);
            this.txtManager.ReadOnly = true;
            this.txtManager.Size = new System.Drawing.Size(232, 36);
            // 
            // ImgBtnForSN
            // 
            this.ImgBtnForSN.BackColor = System.Drawing.Color.White;
            this.ImgBtnForSN.Location = new System.Drawing.Point(260, 133);
            this.ImgBtnForSN.Name = "ImgBtnForSN";
            this.ImgBtnForSN.ResourceID = "scan";
            this.ImgBtnForSN.Size = new System.Drawing.Size(28, 28);
            this.ImgBtnForSN.Press += new System.EventHandler(this.ImgBtnForAssId_Press);
            // 
            // r2000Scanner1
            // 
            this.r2000Scanner1.Name = "r2000Scanner1";
            this.r2000Scanner1.BarcodeDataCaptured += new Smobiler.Device.R2000BarcodeScanEventHandler(this.r2000Scanner1_BarcodeDataCaptured);
            this.r2000Scanner1.RFIDDataCaptured += new Smobiler.Device.R2000RFIDScanEventHandler(this.r2000Scanner1_RFIDDataCaptured);
            // 
            // barcodeScanner1
            // 
            this.barcodeScanner1.Name = "barcodeScanner1";
            this.barcodeScanner1.BarcodeScanned += new Smobiler.Core.Controls.BarcodeScannerCallBackHandler(this.barcodeScanner1_BarcodeScanned);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(124)))), ((int)(((byte)(246)))));
            this.btnSave.BorderRadius = 0;
            this.btnSave.Location = new System.Drawing.Point(261, 12);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(30, 13);
            this.btnSave.Text = "����";
            this.btnSave.Press += new System.EventHandler(this.btnSave_Press);
            // 
            // frmAssetsDetailEdit
            // 
            this.BackColor = System.Drawing.Color.White;
            this.Components.AddRange(new Smobiler.Core.Controls.MobileComponent[] {
            this.PopType,
            this.CamPicture,
            this.r2000Scanner1,
            this.barcodeScanner1});
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.Title1,
            this.plButton,
            this.plContent,
            this.btnSave});
            this.Statusbar = new Smobiler.Core.Controls.MobileFormStatusbar(Smobiler.Core.Controls.MobileFormStatusbarStyle.Default, System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(124)))), ((int)(((byte)(246))))));
            this.KeyDown += new Smobiler.Core.Controls.KeyDownEventHandler(this.frmAssetsDetailEdit_KeyDown);
            this.Load += new System.EventHandler(this.frmAssetsDetailEdit_Load);
            this.Name = "frmAssetsDetailEdit";

        }
        #endregion

        private Title Title1;
        internal Smobiler.Core.Controls.Panel plButton;
        internal Smobiler.Core.Controls.Button btnSave2;
        internal Smobiler.Core.Controls.PopList PopType;
        internal Smobiler.Core.Controls.Camera CamPicture;
        internal Smobiler.Core.Controls.Panel plContent;
        internal Smobiler.Core.Controls.Label Label14;
        internal Smobiler.Core.Controls.TextBox txtSN;
        internal Smobiler.Core.Controls.TextBox txtAssID;
        private Smobiler.Device.R2000Scanner r2000Scanner1;
        private Smobiler.Core.Controls.BarcodeScanner barcodeScanner1;
        private Smobiler.Core.Controls.ImageButton ImgBtnForSN;
        private Smobiler.Core.Controls.Button btnSave;
        internal Smobiler.Core.Controls.DatePicker DatePickerBuy;
        internal Smobiler.Core.Controls.DatePicker DatePickerExpiry;
        internal Smobiler.Core.Controls.Label label35;
        internal Smobiler.Core.Controls.Label label36;
        internal Smobiler.Core.Controls.Label label37;
        internal Smobiler.Core.Controls.Label label38;
        internal Smobiler.Core.Controls.Label label39;
        internal Smobiler.Core.Controls.Label label40;
        internal Smobiler.Core.Controls.Label label41;
        internal Smobiler.Core.Controls.Label label42;
        internal Smobiler.Core.Controls.Label label43;
        internal Smobiler.Core.Controls.Label label44;
        internal Smobiler.Core.Controls.Label label45;
        internal Smobiler.Core.Controls.Label label46;
        internal Smobiler.Core.Controls.TextBox txtName1;
        internal Smobiler.Core.Controls.TextBox txtSPE1;
        internal Smobiler.Core.Controls.TextBox txtUnit1;
        internal Smobiler.Core.Controls.TextBox txtATID;
        internal Smobiler.Core.Controls.TextBox txtSN1;
        internal Smobiler.Core.Controls.TextBox txtPrice1;
        internal Smobiler.Core.Controls.Panel panel6;
        internal Smobiler.Core.Controls.Image image2;
        internal Smobiler.Core.Controls.Label label47;
        internal Smobiler.Core.Controls.TextBox txtNote1;
        internal Smobiler.Core.Controls.Label label48;
        internal Smobiler.Core.Controls.TextBox txtAssId1;
        internal Smobiler.Core.Controls.Label label49;
        internal Smobiler.Core.Controls.TextBox txtPlace1;
        internal Smobiler.Core.Controls.Label label50;
        internal Smobiler.Core.Controls.Label label51;
        internal Smobiler.Core.Controls.TextBox txtVendor1;
        private Smobiler.Core.Controls.TextBox txtType;
        private Smobiler.Core.Controls.TextBox txtSL;
        internal Smobiler.Core.Controls.TextBox txtManager;
    }
}