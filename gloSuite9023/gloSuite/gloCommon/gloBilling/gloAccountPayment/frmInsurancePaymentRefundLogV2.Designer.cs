namespace gloAccountsV2
{
    partial class frmInsurancePaymentRefundLogV2
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
                try
                {
                    gloGlobal.cEventHelper.RemoveAllEventHandlers(this);
                }
                catch
                {
                }
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInsurancePaymentRefundLogV2));
            this.C1SuperTooltip1 = new C1.Win.C1SuperTooltip.C1SuperTooltip(this.components);
            this.btnClearInsurance = new System.Windows.Forms.Button();
            this.btnClearTray = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmbPayTray = new System.Windows.Forms.ComboBox();
            this.lblPayTray = new System.Windows.Forms.Label();
            this.btnBrowsePayTray = new System.Windows.Forms.Button();
            this.btnClearPayTray = new System.Windows.Forms.Button();
            this.btnTraySelection = new System.Windows.Forms.Button();
            this.lblPaymentTray = new System.Windows.Forms.Label();
            this.label90 = new System.Windows.Forms.Label();
            this.mskPaymentDate = new System.Windows.Forms.MaskedTextBox();
            this.mskCloseDate = new System.Windows.Forms.MaskedTextBox();
            this.txtCheckNo = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.btnSearchCompany = new System.Windows.Forms.Button();
            this.cmbUsers = new System.Windows.Forms.ComboBox();
            this.lblInsCompany = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblCloseDate = new System.Windows.Forms.Label();
            this.lblPayType = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.pnlToolStrip = new System.Windows.Forms.Panel();
            this.ts_Commands = new gloGlobal.gloToolStripIgnoreFocus();
            this.tsb_NewRefund = new System.Windows.Forms.ToolStripButton();
            this.tsb_ViewRefund = new System.Windows.Forms.ToolStripButton();
            this.tsb_Generate = new System.Windows.Forms.ToolStripButton();
            this.tsb_Cancel = new System.Windows.Forms.ToolStripButton();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.c1InsuranceRefundLog = new C1.Win.C1FlexGrid.C1FlexGrid();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            this.pnlToolStrip.SuspendLayout();
            this.ts_Commands.SuspendLayout();
            this.pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.c1InsuranceRefundLog)).BeginInit();
            this.SuspendLayout();
            // 
            // C1SuperTooltip1
            // 
            this.C1SuperTooltip1.BackgroundGradient = C1.Win.C1SuperTooltip.BackgroundGradient.None;
            this.C1SuperTooltip1.Font = new System.Drawing.Font("Tahoma", 8F);
            // 
            // btnClearInsurance
            // 
            this.btnClearInsurance.BackColor = System.Drawing.Color.Transparent;
            this.btnClearInsurance.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClearInsurance.BackgroundImage")));
            this.btnClearInsurance.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClearInsurance.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(73)))), ((int)(((byte)(125)))));
            this.btnClearInsurance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearInsurance.Image = ((System.Drawing.Image)(resources.GetObject("btnClearInsurance.Image")));
            this.btnClearInsurance.Location = new System.Drawing.Point(817, 13);
            this.btnClearInsurance.Name = "btnClearInsurance";
            this.btnClearInsurance.Size = new System.Drawing.Size(21, 21);
            this.btnClearInsurance.TabIndex = 224;
            this.btnClearInsurance.TabStop = false;
            this.toolTip1.SetToolTip(this.btnClearInsurance, "Clear Insurance Company");
            this.btnClearInsurance.UseVisualStyleBackColor = false;
            this.btnClearInsurance.Click += new System.EventHandler(this.btnClearInsurance_Click);
            this.btnClearInsurance.MouseLeave += new System.EventHandler(this.btnMouseLeave);
            this.btnClearInsurance.MouseHover += new System.EventHandler(this.btnMouseHover);
            // 
            // btnClearTray
            // 
            this.btnClearTray.BackColor = System.Drawing.Color.Transparent;
            this.btnClearTray.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClearTray.BackgroundImage")));
            this.btnClearTray.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClearTray.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(73)))), ((int)(((byte)(125)))));
            this.btnClearTray.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearTray.Image = ((System.Drawing.Image)(resources.GetObject("btnClearTray.Image")));
            this.btnClearTray.Location = new System.Drawing.Point(754, 133);
            this.btnClearTray.Name = "btnClearTray";
            this.btnClearTray.Size = new System.Drawing.Size(22, 22);
            this.btnClearTray.TabIndex = 225;
            this.btnClearTray.TabStop = false;
            this.toolTip1.SetToolTip(this.btnClearTray, "Clear Payment Tray");
            this.btnClearTray.UseVisualStyleBackColor = false;
            this.btnClearTray.Click += new System.EventHandler(this.btnClearTray_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.cmbPayTray);
            this.panel1.Controls.Add(this.lblPayTray);
            this.panel1.Controls.Add(this.btnBrowsePayTray);
            this.panel1.Controls.Add(this.btnClearTray);
            this.panel1.Controls.Add(this.btnClearPayTray);
            this.panel1.Controls.Add(this.btnClearInsurance);
            this.panel1.Controls.Add(this.btnTraySelection);
            this.panel1.Controls.Add(this.lblPaymentTray);
            this.panel1.Controls.Add(this.label90);
            this.panel1.Controls.Add(this.mskPaymentDate);
            this.panel1.Controls.Add(this.mskCloseDate);
            this.panel1.Controls.Add(this.txtCheckNo);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.btnSearchCompany);
            this.panel1.Controls.Add(this.cmbUsers);
            this.panel1.Controls.Add(this.lblInsCompany);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.lblCloseDate);
            this.panel1.Controls.Add(this.lblPayType);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 54);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.panel1.Size = new System.Drawing.Size(1109, 105);
            this.panel1.TabIndex = 1;
            // 
            // cmbPayTray
            // 
            this.cmbPayTray.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPayTray.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPayTray.FormattingEnabled = true;
            this.cmbPayTray.Location = new System.Drawing.Point(368, 38);
            this.cmbPayTray.Name = "cmbPayTray";
            this.cmbPayTray.Size = new System.Drawing.Size(417, 22);
            this.cmbPayTray.TabIndex = 2;
            this.cmbPayTray.SelectedIndexChanged += new System.EventHandler(this.cmbPayTray_SelectedIndexChanged);
            this.cmbPayTray.MouseEnter += new System.EventHandler(this.cmbPayTray_MouseEnter);
            // 
            // lblPayTray
            // 
            this.lblPayTray.AutoSize = true;
            this.lblPayTray.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPayTray.Location = new System.Drawing.Point(275, 42);
            this.lblPayTray.Name = "lblPayTray";
            this.lblPayTray.Size = new System.Drawing.Size(91, 14);
            this.lblPayTray.TabIndex = 196;
            this.lblPayTray.Text = "Payment Tray :";
            // 
            // btnBrowsePayTray
            // 
            this.btnBrowsePayTray.BackColor = System.Drawing.Color.Transparent;
            this.btnBrowsePayTray.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBrowsePayTray.BackgroundImage")));
            this.btnBrowsePayTray.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBrowsePayTray.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(73)))), ((int)(((byte)(125)))));
            this.btnBrowsePayTray.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBrowsePayTray.Image = ((System.Drawing.Image)(resources.GetObject("btnBrowsePayTray.Image")));
            this.btnBrowsePayTray.Location = new System.Drawing.Point(790, 39);
            this.btnBrowsePayTray.Name = "btnBrowsePayTray";
            this.btnBrowsePayTray.Size = new System.Drawing.Size(21, 21);
            this.btnBrowsePayTray.TabIndex = 3;
            this.toolTip1.SetToolTip(this.btnBrowsePayTray, "Select Payment Tray");
            this.btnBrowsePayTray.UseVisualStyleBackColor = false;
            this.btnBrowsePayTray.Click += new System.EventHandler(this.btnBrowsePayTray_Click);
            this.btnBrowsePayTray.MouseLeave += new System.EventHandler(this.btnMouseLeave);
            this.btnBrowsePayTray.MouseHover += new System.EventHandler(this.btnMouseHover);
            // 
            // btnClearPayTray
            // 
            this.btnClearPayTray.BackColor = System.Drawing.Color.Transparent;
            this.btnClearPayTray.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClearPayTray.BackgroundImage")));
            this.btnClearPayTray.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClearPayTray.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(73)))), ((int)(((byte)(125)))));
            this.btnClearPayTray.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearPayTray.Image = ((System.Drawing.Image)(resources.GetObject("btnClearPayTray.Image")));
            this.btnClearPayTray.Location = new System.Drawing.Point(817, 39);
            this.btnClearPayTray.Name = "btnClearPayTray";
            this.btnClearPayTray.Size = new System.Drawing.Size(21, 21);
            this.btnClearPayTray.TabIndex = 195;
            this.btnClearPayTray.TabStop = false;
            this.toolTip1.SetToolTip(this.btnClearPayTray, "Clear Payment Tray");
            this.btnClearPayTray.UseVisualStyleBackColor = false;
            this.btnClearPayTray.Click += new System.EventHandler(this.btnClearPayTray_Click);
            this.btnClearPayTray.MouseLeave += new System.EventHandler(this.btnMouseLeave);
            this.btnClearPayTray.MouseHover += new System.EventHandler(this.btnMouseHover);
            // 
            // btnTraySelection
            // 
            this.btnTraySelection.AutoEllipsis = true;
            this.btnTraySelection.BackColor = System.Drawing.Color.Transparent;
            this.btnTraySelection.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTraySelection.BackgroundImage")));
            this.btnTraySelection.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTraySelection.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTraySelection.Image = ((System.Drawing.Image)(resources.GetObject("btnTraySelection.Image")));
            this.btnTraySelection.Location = new System.Drawing.Point(727, 133);
            this.btnTraySelection.Name = "btnTraySelection";
            this.btnTraySelection.Size = new System.Drawing.Size(22, 22);
            this.btnTraySelection.TabIndex = 2;
            this.btnTraySelection.TabStop = false;
            this.toolTip1.SetToolTip(this.btnTraySelection, "Select Payment Tray");
            this.btnTraySelection.UseVisualStyleBackColor = false;
            this.btnTraySelection.Click += new System.EventHandler(this.btnTraySelection_Click);
            // 
            // lblPaymentTray
            // 
            this.lblPaymentTray.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaymentTray.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(73)))), ((int)(((byte)(125)))));
            this.lblPaymentTray.Location = new System.Drawing.Point(375, 137);
            this.lblPaymentTray.Name = "lblPaymentTray";
            this.lblPaymentTray.Size = new System.Drawing.Size(338, 14);
            this.lblPaymentTray.TabIndex = 221;
            this.lblPaymentTray.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label90
            // 
            this.label90.AutoSize = true;
            this.label90.BackColor = System.Drawing.Color.Transparent;
            this.label90.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label90.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(73)))), ((int)(((byte)(125)))));
            this.label90.Location = new System.Drawing.Point(282, 137);
            this.label90.Name = "label90";
            this.label90.Size = new System.Drawing.Size(91, 14);
            this.label90.TabIndex = 219;
            this.label90.Text = "Payment Tray :";
            this.label90.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mskPaymentDate
            // 
            this.mskPaymentDate.Location = new System.Drawing.Point(156, 68);
            this.mskPaymentDate.Mask = "00/00/0000";
            this.mskPaymentDate.Name = "mskPaymentDate";
            this.mskPaymentDate.Size = new System.Drawing.Size(97, 22);
            this.mskPaymentDate.TabIndex = 4;
            this.mskPaymentDate.ValidatingType = typeof(System.DateTime);
            this.mskPaymentDate.MouseClick += new System.Windows.Forms.MouseEventHandler(this.DateMouseClick);
            this.mskPaymentDate.Validating += new System.ComponentModel.CancelEventHandler(this.ValidateDate);
            // 
            // mskCloseDate
            // 
            this.mskCloseDate.Location = new System.Drawing.Point(156, 39);
            this.mskCloseDate.Mask = "00/00/0000";
            this.mskCloseDate.Name = "mskCloseDate";
            this.mskCloseDate.Size = new System.Drawing.Size(97, 22);
            this.mskCloseDate.TabIndex = 1;
            this.mskCloseDate.ValidatingType = typeof(System.DateTime);
            this.mskCloseDate.MouseClick += new System.Windows.Forms.MouseEventHandler(this.DateMouseClick);
            this.mskCloseDate.Validating += new System.ComponentModel.CancelEventHandler(this.ValidateDate);
            // 
            // txtCheckNo
            // 
            this.txtCheckNo.Location = new System.Drawing.Point(368, 68);
            this.txtCheckNo.MaxLength = 15;
            this.txtCheckNo.Name = "txtCheckNo";
            this.txtCheckNo.Size = new System.Drawing.Size(189, 22);
            this.txtCheckNo.TabIndex = 5;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(73)))), ((int)(((byte)(125)))));
            this.label14.Location = new System.Drawing.Point(33, 72);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(121, 14);
            this.label14.TabIndex = 218;
            this.label14.Text = "Refund Check Date :";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(73)))), ((int)(((byte)(125)))));
            this.label13.Location = new System.Drawing.Point(266, 72);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(100, 14);
            this.label13.TabIndex = 217;
            this.label13.Text = "Refund Check# :";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSearchCompany
            // 
            this.btnSearchCompany.AutoEllipsis = true;
            this.btnSearchCompany.BackColor = System.Drawing.Color.Transparent;
            this.btnSearchCompany.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSearchCompany.BackgroundImage")));
            this.btnSearchCompany.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSearchCompany.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchCompany.Image = ((System.Drawing.Image)(resources.GetObject("btnSearchCompany.Image")));
            this.btnSearchCompany.Location = new System.Drawing.Point(790, 13);
            this.btnSearchCompany.Name = "btnSearchCompany";
            this.btnSearchCompany.Size = new System.Drawing.Size(21, 21);
            this.btnSearchCompany.TabIndex = 0;
            this.btnSearchCompany.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip1.SetToolTip(this.btnSearchCompany, "Select Insurance Company");
            this.btnSearchCompany.UseVisualStyleBackColor = false;
            this.btnSearchCompany.Click += new System.EventHandler(this.btnSearchCompany_Click);
            this.btnSearchCompany.MouseLeave += new System.EventHandler(this.btnMouseLeave);
            this.btnSearchCompany.MouseHover += new System.EventHandler(this.btnMouseHover);
            // 
            // cmbUsers
            // 
            this.cmbUsers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUsers.ForeColor = System.Drawing.Color.Black;
            this.cmbUsers.FormattingEnabled = true;
            this.cmbUsers.Items.AddRange(new object[] {
            ""});
            this.cmbUsers.Location = new System.Drawing.Point(611, 68);
            this.cmbUsers.Name = "cmbUsers";
            this.cmbUsers.Size = new System.Drawing.Size(174, 22);
            this.cmbUsers.TabIndex = 6;
            this.cmbUsers.SelectedIndexChanged += new System.EventHandler(this.cmbUsers_SelectedIndexChanged);
            this.cmbUsers.MouseEnter += new System.EventHandler(this.cmbUsers_MouseEnter);
            // 
            // lblInsCompany
            // 
            this.lblInsCompany.BackColor = System.Drawing.Color.Transparent;
            this.lblInsCompany.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInsCompany.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(73)))), ((int)(((byte)(125)))));
            this.lblInsCompany.Location = new System.Drawing.Point(156, 14);
            this.lblInsCompany.Name = "lblInsCompany";
            this.lblInsCompany.Size = new System.Drawing.Size(628, 19);
            this.lblInsCompany.TabIndex = 215;
            this.lblInsCompany.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblInsCompany.MouseEnter += new System.EventHandler(this.lblInsCompany_MouseEnter);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(73)))), ((int)(((byte)(125)))));
            this.label10.Location = new System.Drawing.Point(32, 16);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(122, 14);
            this.label10.TabIndex = 211;
            this.label10.Text = "Insurance Company :";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCloseDate
            // 
            this.lblCloseDate.AutoSize = true;
            this.lblCloseDate.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCloseDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(73)))), ((int)(((byte)(125)))));
            this.lblCloseDate.Location = new System.Drawing.Point(20, 43);
            this.lblCloseDate.Name = "lblCloseDate";
            this.lblCloseDate.Size = new System.Drawing.Size(134, 14);
            this.lblCloseDate.TabIndex = 212;
            this.lblCloseDate.Text = "On / After Close Date :";
            this.lblCloseDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPayType
            // 
            this.lblPayType.AutoSize = true;
            this.lblPayType.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPayType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(73)))), ((int)(((byte)(125)))));
            this.lblPayType.Location = new System.Drawing.Point(568, 72);
            this.lblPayType.Name = "lblPayType";
            this.lblPayType.Size = new System.Drawing.Size(39, 14);
            this.lblPayType.TabIndex = 212;
            this.lblPayType.Text = "User :";
            this.lblPayType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(45)))), ((int)(((byte)(150)))));
            this.label5.Dock = System.Windows.Forms.DockStyle.Left;
            this.label5.Location = new System.Drawing.Point(3, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(1, 101);
            this.label5.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(45)))), ((int)(((byte)(150)))));
            this.label6.Dock = System.Windows.Forms.DockStyle.Right;
            this.label6.Location = new System.Drawing.Point(1105, 3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(1, 101);
            this.label6.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(45)))), ((int)(((byte)(150)))));
            this.label7.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label7.Location = new System.Drawing.Point(3, 104);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(1103, 1);
            this.label7.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(45)))), ((int)(((byte)(150)))));
            this.label8.Dock = System.Windows.Forms.DockStyle.Top;
            this.label8.Location = new System.Drawing.Point(3, 2);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(1103, 1);
            this.label8.TabIndex = 0;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Dock = System.Windows.Forms.DockStyle.Top;
            this.label9.Location = new System.Drawing.Point(3, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(1103, 2);
            this.label9.TabIndex = 14;
            // 
            // pnlToolStrip
            // 
            this.pnlToolStrip.Controls.Add(this.ts_Commands);
            this.pnlToolStrip.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlToolStrip.Location = new System.Drawing.Point(0, 0);
            this.pnlToolStrip.Name = "pnlToolStrip";
            this.pnlToolStrip.Size = new System.Drawing.Size(1109, 54);
            this.pnlToolStrip.TabIndex = 3;
            // 
            // ts_Commands
            // 
            this.ts_Commands.BackgroundImage = global::gloBilling.Properties.Resources.Img_Toolstrip;
            this.ts_Commands.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ts_Commands.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ts_Commands.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.ts_Commands.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsb_NewRefund,
            this.tsb_ViewRefund,
            this.tsb_Generate,
            this.tsb_Cancel});
            this.ts_Commands.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.ts_Commands.Location = new System.Drawing.Point(0, 0);
            this.ts_Commands.Name = "ts_Commands";
            this.ts_Commands.Size = new System.Drawing.Size(1109, 53);
            this.ts_Commands.TabIndex = 0;
            this.ts_Commands.TabStop = true;
            this.ts_Commands.Text = "ToolStrip1";
            // 
            // tsb_NewRefund
            // 
            this.tsb_NewRefund.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsb_NewRefund.Image = ((System.Drawing.Image)(resources.GetObject("tsb_NewRefund.Image")));
            this.tsb_NewRefund.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_NewRefund.Name = "tsb_NewRefund";
            this.tsb_NewRefund.Size = new System.Drawing.Size(86, 50);
            this.tsb_NewRefund.Tag = "Cancel";
            this.tsb_NewRefund.Text = "&New Refund";
            this.tsb_NewRefund.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.tsb_NewRefund.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsb_NewRefund.ToolTipText = "New Refund";
            this.tsb_NewRefund.Click += new System.EventHandler(this.tsb_NewRefund_Click);
            // 
            // tsb_ViewRefund
            // 
            this.tsb_ViewRefund.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsb_ViewRefund.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(73)))), ((int)(((byte)(125)))));
            this.tsb_ViewRefund.Image = ((System.Drawing.Image)(resources.GetObject("tsb_ViewRefund.Image")));
            this.tsb_ViewRefund.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_ViewRefund.Name = "tsb_ViewRefund";
            this.tsb_ViewRefund.Size = new System.Drawing.Size(89, 50);
            this.tsb_ViewRefund.Tag = "Cancel";
            this.tsb_ViewRefund.Text = "View R&efund";
            this.tsb_ViewRefund.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsb_ViewRefund.ToolTipText = "View Refund";
            this.tsb_ViewRefund.Click += new System.EventHandler(this.tsb_ViewRefund_Click);
            // 
            // tsb_Generate
            // 
            this.tsb_Generate.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsb_Generate.Image = ((System.Drawing.Image)(resources.GetObject("tsb_Generate.Image")));
            this.tsb_Generate.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_Generate.Name = "tsb_Generate";
            this.tsb_Generate.Size = new System.Drawing.Size(66, 50);
            this.tsb_Generate.Tag = "Cancel";
            this.tsb_Generate.Text = "&Generate";
            this.tsb_Generate.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.tsb_Generate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsb_Generate.ToolTipText = "Generate Refund Log";
            this.tsb_Generate.Click += new System.EventHandler(this.tsb_Generate_Click);
            // 
            // tsb_Cancel
            // 
            this.tsb_Cancel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsb_Cancel.Image = ((System.Drawing.Image)(resources.GetObject("tsb_Cancel.Image")));
            this.tsb_Cancel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsb_Cancel.Name = "tsb_Cancel";
            this.tsb_Cancel.Size = new System.Drawing.Size(43, 50);
            this.tsb_Cancel.Tag = "Cancel";
            this.tsb_Cancel.Text = "&Close";
            this.tsb_Cancel.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.tsb_Cancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsb_Cancel.Click += new System.EventHandler(this.tsb_Cancel_Click);
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.c1InsuranceRefundLog);
            this.pnlMain.Controls.Add(this.label3);
            this.pnlMain.Controls.Add(this.label2);
            this.pnlMain.Controls.Add(this.label12);
            this.pnlMain.Controls.Add(this.label1);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(73)))), ((int)(((byte)(125)))));
            this.pnlMain.Location = new System.Drawing.Point(0, 159);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Padding = new System.Windows.Forms.Padding(3);
            this.pnlMain.Size = new System.Drawing.Size(1109, 351);
            this.pnlMain.TabIndex = 2;
            // 
            // c1InsuranceRefundLog
            // 
            this.c1InsuranceRefundLog.AllowDragging = C1.Win.C1FlexGrid.AllowDraggingEnum.None;
            this.c1InsuranceRefundLog.AllowEditing = false;
            this.c1InsuranceRefundLog.AllowResizing = C1.Win.C1FlexGrid.AllowResizingEnum.None;
            this.c1InsuranceRefundLog.AllowSorting = C1.Win.C1FlexGrid.AllowSortingEnum.None;
            this.c1InsuranceRefundLog.AutoGenerateColumns = false;
            this.c1InsuranceRefundLog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.c1InsuranceRefundLog.BorderStyle = C1.Win.C1FlexGrid.Util.BaseControls.BorderStyleEnum.None;
            this.c1InsuranceRefundLog.ColumnInfo = "0,0,0,0,0,105,Columns:";
            this.c1InsuranceRefundLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.c1InsuranceRefundLog.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(73)))), ((int)(((byte)(125)))));
            this.c1InsuranceRefundLog.Location = new System.Drawing.Point(4, 4);
            this.c1InsuranceRefundLog.Name = "c1InsuranceRefundLog";
            this.c1InsuranceRefundLog.Rows.Count = 1;
            this.c1InsuranceRefundLog.Rows.DefaultSize = 21;
            this.c1InsuranceRefundLog.SelectionMode = C1.Win.C1FlexGrid.SelectionModeEnum.Row;
            this.c1InsuranceRefundLog.ShowButtons = C1.Win.C1FlexGrid.ShowButtonsEnum.Always;
            this.c1InsuranceRefundLog.ShowCellLabels = true;
            this.c1InsuranceRefundLog.Size = new System.Drawing.Size(1101, 343);
            this.c1InsuranceRefundLog.StyleInfo = resources.GetString("c1InsuranceRefundLog.StyleInfo");
            this.c1InsuranceRefundLog.TabIndex = 7;
            this.c1InsuranceRefundLog.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.c1InsuranceLog_MouseDoubleClick);
            this.c1InsuranceRefundLog.MouseMove += new System.Windows.Forms.MouseEventHandler(this.c1InsuranceLog_MouseMove);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(73)))), ((int)(((byte)(125)))));
            this.label3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label3.Location = new System.Drawing.Point(4, 347);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(1101, 1);
            this.label3.TabIndex = 213;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(73)))), ((int)(((byte)(125)))));
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Location = new System.Drawing.Point(4, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1101, 1);
            this.label2.TabIndex = 212;
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(73)))), ((int)(((byte)(125)))));
            this.label12.Dock = System.Windows.Forms.DockStyle.Left;
            this.label12.Location = new System.Drawing.Point(3, 3);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(1, 345);
            this.label12.TabIndex = 210;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(73)))), ((int)(((byte)(125)))));
            this.label1.Dock = System.Windows.Forms.DockStyle.Right;
            this.label1.Location = new System.Drawing.Point(1105, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1, 345);
            this.label1.TabIndex = 211;
            // 
            // frmInsurancePaymentRefundLogV2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(224)))), ((int)(((byte)(248)))));
            this.ClientSize = new System.Drawing.Size(1109, 510);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlToolStrip);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(73)))), ((int)(((byte)(125)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmInsurancePaymentRefundLogV2";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Insurance Payment Refunds";
            this.Load += new System.EventHandler(this.frmInsurancePaymentLog_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlToolStrip.ResumeLayout(false);
            this.pnlToolStrip.PerformLayout();
            this.ts_Commands.ResumeLayout(false);
            this.ts_Commands.PerformLayout();
            this.pnlMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.c1InsuranceRefundLog)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtCheckNo;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnSearchCompany;
        private System.Windows.Forms.ComboBox cmbUsers;
        private System.Windows.Forms.Label lblInsCompany;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblCloseDate;
        private System.Windows.Forms.Label lblPayType;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel pnlToolStrip;
        internal gloGlobal.gloToolStripIgnoreFocus ts_Commands;
        internal System.Windows.Forms.ToolStripButton tsb_Cancel;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label1;
        internal System.Windows.Forms.ToolStripButton tsb_NewRefund;
        private C1.Win.C1FlexGrid.C1FlexGrid c1InsuranceRefundLog;
        private System.Windows.Forms.MaskedTextBox mskCloseDate;
        private System.Windows.Forms.MaskedTextBox mskPaymentDate;
        private System.Windows.Forms.Button btnTraySelection;
        private System.Windows.Forms.Label lblPaymentTray;
        private System.Windows.Forms.Label label90;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnClearInsurance;
        private System.Windows.Forms.Button btnClearTray;
        private System.Windows.Forms.ComboBox cmbPayTray;
        internal System.Windows.Forms.Button btnBrowsePayTray;
        internal System.Windows.Forms.Button btnClearPayTray;
        private System.Windows.Forms.Label lblPayTray;
        internal System.Windows.Forms.ToolStripButton tsb_Generate;
        internal System.Windows.Forms.ToolStripButton tsb_ViewRefund;
        private C1.Win.C1SuperTooltip.C1SuperTooltip C1SuperTooltip1;
    }
}