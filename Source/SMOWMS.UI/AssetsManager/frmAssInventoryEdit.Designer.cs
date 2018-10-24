namespace SMOWMS.UI.AssetsManager
{
    partial class frmAssInventoryEdit : Smobiler.Core.Controls.MobileForm
    {
        #region "SmobilerForm generated code "

        public frmAssInventoryEdit()
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
            this.popMan = new Smobiler.Core.Controls.PopList();
            this.popType = new Smobiler.Core.Controls.PopList();
            this.plButton = new Smobiler.Core.Controls.Panel();
            this.btnDelete = new Smobiler.Core.Controls.Button();
            this.btnSave2 = new Smobiler.Core.Controls.Button();
            this.plContent = new Smobiler.Core.Controls.Panel();
            this.Label7 = new Smobiler.Core.Controls.Label();
            this.txtName = new Smobiler.Core.Controls.TextBox();
            this.label4 = new Smobiler.Core.Controls.Label();
            this.btnManager = new Smobiler.Core.Controls.Button();
            this.label1 = new Smobiler.Core.Controls.Label();
            this.label2 = new Smobiler.Core.Controls.Label();
            this.label3 = new Smobiler.Core.Controls.Label();
            this.label5 = new Smobiler.Core.Controls.Label();
            this.btnSL = new Smobiler.Core.Controls.Button();
            this.btnST = new Smobiler.Core.Controls.Button();
            this.btnType = new Smobiler.Core.Controls.Button();
            this.btnWareHouse = new Smobiler.Core.Controls.Button();
            this.label6 = new Smobiler.Core.Controls.Label();
            this.label8 = new Smobiler.Core.Controls.Label();
            this.label9 = new Smobiler.Core.Controls.Label();
            this.label10 = new Smobiler.Core.Controls.Label();
            this.label11 = new Smobiler.Core.Controls.Label();
            this.popSL = new Smobiler.Core.Controls.PopList();
            this.popST = new Smobiler.Core.Controls.PopList();
            this.popWH = new Smobiler.Core.Controls.PopList();
            this.btnSave = new Smobiler.Core.Controls.Button();
            // 
            // Title1
            // 
            this.Title1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(124)))), ((int)(((byte)(246)))));
            this.Title1.Dock = System.Windows.Forms.DockStyle.Top;
            this.Title1.FontSize = 15F;
            this.Title1.ForeColor = System.Drawing.Color.White;
            this.Title1.Name = "Title1";
            this.Title1.Size = new System.Drawing.Size(300, 35);
            this.Title1.TitleText = "�༭�ʲ��̵㵥";
            // 
            // popMan
            // 
            this.popMan.Name = "popMan";
            this.popMan.Selected += new System.EventHandler(this.popMan_Selected);
            // 
            // popType
            // 
            this.popType.Name = "popType";
            this.popType.Selected += new System.EventHandler(this.popType_Selected);
            // 
            // plButton
            // 
            this.plButton.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 0F);
            this.plButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.plButton.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.btnDelete,
            this.btnSave2});
            this.plButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.plButton.Location = new System.Drawing.Point(0, 468);
            this.plButton.Name = "plButton";
            this.plButton.Size = new System.Drawing.Size(300, 102);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.White;
            this.btnDelete.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btnDelete.BorderRadius = 0;
            this.btnDelete.ForeColor = System.Drawing.Color.Black;
            this.btnDelete.Location = new System.Drawing.Point(12, 48);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(276, 38);
            this.btnDelete.Text = "ɾ��";
            this.btnDelete.Press += new System.EventHandler(this.btnDelete_Press);
            // 
            // btnSave2
            // 
            this.btnSave2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(124)))), ((int)(((byte)(246)))));
            this.btnSave2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btnSave2.BorderRadius = 0;
            this.btnSave2.ForeColor = System.Drawing.Color.Black;
            this.btnSave2.Location = new System.Drawing.Point(12, 0);
            this.btnSave2.Name = "btnSave2";
            this.btnSave2.Size = new System.Drawing.Size(276, 38);
            this.btnSave2.Text = "����";
            this.btnSave2.Press += new System.EventHandler(this.btnSave_Press);
            // 
            // plContent
            // 
            this.plContent.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.Label7,
            this.txtName,
            this.label4,
            this.btnManager,
            this.label1,
            this.label2,
            this.label3,
            this.label4,
            this.label5,
            this.btnSL,
            this.btnST,
            this.btnType,
            this.btnWareHouse,
            this.label6,
            this.label8,
            this.label9,
            this.label10,
            this.label11});
            this.plContent.Flex = 1;
            this.plContent.Location = new System.Drawing.Point(0, 35);
            this.plContent.Margin = new Smobiler.Core.Controls.Margin(0F, 12F, 0F, 0F);
            this.plContent.Name = "plContent";
            this.plContent.Size = new System.Drawing.Size(300, 228);
            // 
            // Label7
            // 
            this.Label7.BackColor = System.Drawing.Color.White;
            this.Label7.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 0F);
            this.Label7.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.Label7.Name = "Label7";
            this.Label7.Padding = new Smobiler.Core.Controls.Padding(12F, 0F, 0F, 0F);
            this.Label7.Size = new System.Drawing.Size(68, 36);
            this.Label7.Text = "�̵㵥��";
            // 
            // txtName
            // 
            this.txtName.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 0F);
            this.txtName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.txtName.Location = new System.Drawing.Point(68, 0);
            this.txtName.Name = "txtName";
            this.txtName.Padding = new Smobiler.Core.Controls.Padding(7F, 0F, 0F, 0F);
            this.txtName.Size = new System.Drawing.Size(232, 36);
            this.txtName.WaterMarkText = "�����";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 0F);
            this.label4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.label4.Location = new System.Drawing.Point(0, 36);
            this.label4.Name = "label4";
            this.label4.Padding = new Smobiler.Core.Controls.Padding(12F, 0F, 0F, 0F);
            this.label4.Size = new System.Drawing.Size(68, 36);
            this.label4.Text = "�̵���";
            // 
            // btnManager
            // 
            this.btnManager.BackColor = System.Drawing.Color.White;
            this.btnManager.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 0F);
            this.btnManager.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btnManager.BorderRadius = 0;
            this.btnManager.ForeColor = System.Drawing.Color.Black;
            this.btnManager.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Left;
            this.btnManager.Location = new System.Drawing.Point(68, 36);
            this.btnManager.Name = "btnManager";
            this.btnManager.Padding = new Smobiler.Core.Controls.Padding(7F, 0F, 0F, 0F);
            this.btnManager.Size = new System.Drawing.Size(232, 36);
            this.btnManager.Text = "ѡ�񣨱��";
            this.btnManager.Press += new System.EventHandler(this.btnManager_Press);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 0F);
            this.label1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.label1.Location = new System.Drawing.Point(0, 120);
            this.label1.Name = "label1";
            this.label1.Padding = new Smobiler.Core.Controls.Padding(12F, 0F, 0F, 0F);
            this.label1.Size = new System.Drawing.Size(68, 36);
            this.label1.Text = "�ֿ�";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 0F);
            this.label2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.label2.Location = new System.Drawing.Point(0, 156);
            this.label2.Name = "label2";
            this.label2.Padding = new Smobiler.Core.Controls.Padding(12F, 0F, 0F, 0F);
            this.label2.Size = new System.Drawing.Size(68, 36);
            this.label2.Text = "�洢����";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 0F);
            this.label3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.label3.Location = new System.Drawing.Point(0, 84);
            this.label3.Name = "label3";
            this.label3.Padding = new Smobiler.Core.Controls.Padding(12F, 0F, 0F, 0F);
            this.label3.Size = new System.Drawing.Size(68, 36);
            this.label3.Text = "�ʲ�����";
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 0F);
            this.label5.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.label5.Location = new System.Drawing.Point(0, 192);
            this.label5.Name = "label5";
            this.label5.Padding = new Smobiler.Core.Controls.Padding(12F, 0F, 0F, 0F);
            this.label5.Size = new System.Drawing.Size(68, 36);
            this.label5.Text = "��λ";
            // 
            // btnSL
            // 
            this.btnSL.BackColor = System.Drawing.Color.White;
            this.btnSL.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 0F);
            this.btnSL.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btnSL.BorderRadius = 0;
            this.btnSL.ForeColor = System.Drawing.Color.Black;
            this.btnSL.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Left;
            this.btnSL.Location = new System.Drawing.Point(68, 192);
            this.btnSL.Name = "btnSL";
            this.btnSL.Padding = new Smobiler.Core.Controls.Padding(7F, 0F, 0F, 0F);
            this.btnSL.Size = new System.Drawing.Size(232, 36);
            this.btnSL.Text = "ѡ��ѡ�";
            this.btnSL.Press += new System.EventHandler(this.btnSL_Press);
            // 
            // btnST
            // 
            this.btnST.BackColor = System.Drawing.Color.White;
            this.btnST.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 0F);
            this.btnST.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btnST.BorderRadius = 0;
            this.btnST.ForeColor = System.Drawing.Color.Black;
            this.btnST.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Left;
            this.btnST.Location = new System.Drawing.Point(68, 156);
            this.btnST.Name = "btnST";
            this.btnST.Padding = new Smobiler.Core.Controls.Padding(7F, 0F, 0F, 0F);
            this.btnST.Size = new System.Drawing.Size(232, 36);
            this.btnST.Text = "ѡ��ѡ�";
            this.btnST.Press += new System.EventHandler(this.btnST_Press);
            // 
            // btnType
            // 
            this.btnType.BackColor = System.Drawing.Color.White;
            this.btnType.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 0F);
            this.btnType.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btnType.BorderRadius = 0;
            this.btnType.ForeColor = System.Drawing.Color.Black;
            this.btnType.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Left;
            this.btnType.Location = new System.Drawing.Point(68, 84);
            this.btnType.Name = "btnType";
            this.btnType.Padding = new Smobiler.Core.Controls.Padding(7F, 0F, 0F, 0F);
            this.btnType.Size = new System.Drawing.Size(232, 36);
            this.btnType.Text = "ѡ�񣨱��";
            this.btnType.Press += new System.EventHandler(this.btnType_Press);
            // 
            // btnWareHouse
            // 
            this.btnWareHouse.BackColor = System.Drawing.Color.White;
            this.btnWareHouse.Border = new Smobiler.Core.Controls.Border(0F, 1F, 0F, 0F);
            this.btnWareHouse.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btnWareHouse.BorderRadius = 0;
            this.btnWareHouse.ForeColor = System.Drawing.Color.Black;
            this.btnWareHouse.HorizontalAlignment = Smobiler.Core.Controls.HorizontalAlignment.Left;
            this.btnWareHouse.Location = new System.Drawing.Point(68, 120);
            this.btnWareHouse.Name = "btnWareHouse";
            this.btnWareHouse.Padding = new Smobiler.Core.Controls.Padding(7F, 0F, 0F, 0F);
            this.btnWareHouse.Size = new System.Drawing.Size(232, 36);
            this.btnWareHouse.Text = "ѡ�񣨱��";
            this.btnWareHouse.Press += new System.EventHandler(this.btnWareHouse_Press);
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(274, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 35);
            this.label6.Text = ">";
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(274, 85);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 35);
            this.label8.Text = ">";
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(274, 121);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 35);
            this.label9.Text = ">";
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(274, 157);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 35);
            this.label10.Text = ">";
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(274, 192);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(100, 35);
            this.label11.Text = ">";
            // 
            // popSL
            // 
            this.popSL.Name = "popSL";
            this.popSL.Selected += new System.EventHandler(this.popSL_Selected);
            // 
            // popST
            // 
            this.popST.Name = "popST";
            this.popST.Selected += new System.EventHandler(this.popST_Selected);
            // 
            // popWH
            // 
            this.popWH.Name = "popWH";
            this.popWH.Selected += new System.EventHandler(this.popWH_Selected);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(124)))), ((int)(((byte)(246)))));
            this.btnSave.BorderRadius = 0;
            this.btnSave.Location = new System.Drawing.Point(263, 12);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(30, 13);
            this.btnSave.Text = "����";
            this.btnSave.Press += new System.EventHandler(this.btnSave_Press);
            // 
            // frmAssInventoryEdit
            // 
            this.Components.AddRange(new Smobiler.Core.Controls.MobileComponent[] {
            this.popMan,
            this.popType,
            this.popSL,
            this.popST,
            this.popWH});
            this.Controls.AddRange(new Smobiler.Core.Controls.MobileControl[] {
            this.Title1,
            this.plButton,
            this.plContent,
            this.btnSave});
            this.Orientation = Smobiler.Core.Controls.FormOrientation.Portrait;
            this.Statusbar = new Smobiler.Core.Controls.MobileFormStatusbar(Smobiler.Core.Controls.MobileFormStatusbarStyle.Default, System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(124)))), ((int)(((byte)(246))))));
            this.KeyDown += new Smobiler.Core.Controls.KeyDownEventHandler(this.frmAssInventoryEdit_KeyDown);
            this.Load += new System.EventHandler(this.frmAssInventoryEdit_Load);
            this.Name = "frmAssInventoryEdit";

        }
        #endregion

        private UserControl.Title Title1;
        private Smobiler.Core.Controls.PopList popMan;
        private Smobiler.Core.Controls.PopList popType;
        internal Smobiler.Core.Controls.Panel plButton;
        internal Smobiler.Core.Controls.Button btnDelete;
        private Smobiler.Core.Controls.Panel plContent;
        internal Smobiler.Core.Controls.Label Label7;
        internal Smobiler.Core.Controls.TextBox txtName;
        internal Smobiler.Core.Controls.Label label4;
        internal Smobiler.Core.Controls.Button btnManager;
        internal Smobiler.Core.Controls.Label label1;
        internal Smobiler.Core.Controls.Label label2;
        internal Smobiler.Core.Controls.Label label3;
        internal Smobiler.Core.Controls.Label label5;
        internal Smobiler.Core.Controls.Button btnSL;
        internal Smobiler.Core.Controls.Button btnST;
        internal Smobiler.Core.Controls.Button btnType;
        internal Smobiler.Core.Controls.Button btnWareHouse;
        private Smobiler.Core.Controls.PopList popSL;
        private Smobiler.Core.Controls.PopList popST;
        private Smobiler.Core.Controls.PopList popWH;
        private Smobiler.Core.Controls.Button btnSave;
        private Smobiler.Core.Controls.Label label6;
        private Smobiler.Core.Controls.Label label8;
        private Smobiler.Core.Controls.Label label9;
        private Smobiler.Core.Controls.Label label10;
        private Smobiler.Core.Controls.Label label11;
        internal Smobiler.Core.Controls.Button btnSave2;
    }
}