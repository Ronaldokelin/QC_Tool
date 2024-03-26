namespace QC_Tool
{
    partial class FormApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormApp));
            this.comboBoxProducts = new System.Windows.Forms.ComboBox();
            this.comboBoxEstation = new System.Windows.Forms.ComboBox();
            this.labelProduto = new System.Windows.Forms.Label();
            this.labelEstacao = new System.Windows.Forms.Label();
            this.groupBoxSettings = new System.Windows.Forms.GroupBox();
            this.buttonActions = new System.Windows.Forms.Button();
            this.dataGridViewCheckTools = new System.Windows.Forms.DataGridView();
            this.Tool = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnExpiryDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelCheckTools = new System.Windows.Forms.Label();
            this.groupBoxTools = new System.Windows.Forms.GroupBox();
            this.labelDeveloper = new System.Windows.Forms.Label();
            this.pictureBoxFlexLogo = new System.Windows.Forms.PictureBox();
            this.textBoxDetails = new System.Windows.Forms.TextBox();
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabPageOperator = new System.Windows.Forms.TabPage();
            this.tabPageEngineer = new System.Windows.Forms.TabPage();
            this.comboBoxBenchName = new System.Windows.Forms.ComboBox();
            this.buttonAddPath = new System.Windows.Forms.Button();
            this.comboBoxItemType = new System.Windows.Forms.ComboBox();
            this.textBoxItemPath = new System.Windows.Forms.TextBox();
            this.labelItemPath = new System.Windows.Forms.Label();
            this.labelItemType = new System.Windows.Forms.Label();
            this.textBoxItemName = new System.Windows.Forms.TextBox();
            this.labelItemName = new System.Windows.Forms.Label();
            this.labelBenchName = new System.Windows.Forms.Label();
            this.textBoxProductName = new System.Windows.Forms.TextBox();
            this.labelProductName = new System.Windows.Forms.Label();
            this.labelWarning = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.buttonExit = new System.Windows.Forms.Button();
            this.textBoxUser = new System.Windows.Forms.TextBox();
            this.labelUser = new System.Windows.Forms.Label();
            this.groupBoxProduct = new System.Windows.Forms.GroupBox();
            this.groupBoxStation = new System.Windows.Forms.GroupBox();
            this.groupBoxLicenseType = new System.Windows.Forms.GroupBox();
            this.groupBoxUserLicense = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBoxType = new System.Windows.Forms.GroupBox();
            this.groupBoxLicenseNumber = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.groupBoxSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCheckTools)).BeginInit();
            this.groupBoxTools.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFlexLogo)).BeginInit();
            this.tabControlMain.SuspendLayout();
            this.tabPageOperator.SuspendLayout();
            this.tabPageEngineer.SuspendLayout();
            this.groupBoxProduct.SuspendLayout();
            this.groupBoxStation.SuspendLayout();
            this.groupBoxLicenseType.SuspendLayout();
            this.groupBoxUserLicense.SuspendLayout();
            this.groupBoxType.SuspendLayout();
            this.groupBoxLicenseNumber.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBoxProducts
            // 
            this.comboBoxProducts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxProducts.BackColor = System.Drawing.Color.White;
            this.comboBoxProducts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxProducts.FormattingEnabled = true;
            this.comboBoxProducts.Location = new System.Drawing.Point(5, 42);
            this.comboBoxProducts.Name = "comboBoxProducts";
            this.comboBoxProducts.Size = new System.Drawing.Size(172, 21);
            this.comboBoxProducts.TabIndex = 0;
            this.comboBoxProducts.SelectedIndexChanged += new System.EventHandler(this.comboBoxProducts_SelectedIndexChanged);
            // 
            // comboBoxEstation
            // 
            this.comboBoxEstation.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxEstation.BackColor = System.Drawing.Color.White;
            this.comboBoxEstation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxEstation.Enabled = false;
            this.comboBoxEstation.FormattingEnabled = true;
            this.comboBoxEstation.Location = new System.Drawing.Point(5, 96);
            this.comboBoxEstation.Name = "comboBoxEstation";
            this.comboBoxEstation.Size = new System.Drawing.Size(172, 21);
            this.comboBoxEstation.TabIndex = 1;
            this.comboBoxEstation.SelectedIndexChanged += new System.EventHandler(this.comboBoxEstation_SelectedIndexChanged);
            // 
            // labelProduto
            // 
            this.labelProduto.AutoSize = true;
            this.labelProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProduto.Location = new System.Drawing.Point(2, 19);
            this.labelProduto.Name = "labelProduto";
            this.labelProduto.Size = new System.Drawing.Size(68, 20);
            this.labelProduto.TabIndex = 4;
            this.labelProduto.Text = "Product:";
            // 
            // labelEstacao
            // 
            this.labelEstacao.AutoSize = true;
            this.labelEstacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEstacao.Location = new System.Drawing.Point(2, 76);
            this.labelEstacao.Name = "labelEstacao";
            this.labelEstacao.Size = new System.Drawing.Size(64, 20);
            this.labelEstacao.TabIndex = 5;
            this.labelEstacao.Text = "Station:";
            // 
            // groupBoxSettings
            // 
            this.groupBoxSettings.Controls.Add(this.buttonActions);
            this.groupBoxSettings.Controls.Add(this.labelEstacao);
            this.groupBoxSettings.Controls.Add(this.labelProduto);
            this.groupBoxSettings.Controls.Add(this.comboBoxEstation);
            this.groupBoxSettings.Controls.Add(this.comboBoxProducts);
            this.groupBoxSettings.Location = new System.Drawing.Point(3, 3);
            this.groupBoxSettings.Name = "groupBoxSettings";
            this.groupBoxSettings.Size = new System.Drawing.Size(190, 194);
            this.groupBoxSettings.TabIndex = 6;
            this.groupBoxSettings.TabStop = false;
            this.groupBoxSettings.Text = "Settings:";
            // 
            // buttonActions
            // 
            this.buttonActions.Enabled = false;
            this.buttonActions.Location = new System.Drawing.Point(5, 142);
            this.buttonActions.Name = "buttonActions";
            this.buttonActions.Size = new System.Drawing.Size(171, 30);
            this.buttonActions.TabIndex = 6;
            this.buttonActions.Text = "GET LICENSE ID";
            this.buttonActions.UseVisualStyleBackColor = true;
            this.buttonActions.Click += new System.EventHandler(this.buttonActions_Click);
            // 
            // dataGridViewCheckTools
            // 
            this.dataGridViewCheckTools.AllowUserToAddRows = false;
            this.dataGridViewCheckTools.AllowUserToDeleteRows = false;
            this.dataGridViewCheckTools.AllowUserToResizeColumns = false;
            this.dataGridViewCheckTools.AllowUserToResizeRows = false;
            this.dataGridViewCheckTools.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewCheckTools.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewCheckTools.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCheckTools.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Tool,
            this.Type,
            this.Status,
            this.ColumnExpiryDate});
            this.dataGridViewCheckTools.Location = new System.Drawing.Point(5, 39);
            this.dataGridViewCheckTools.Name = "dataGridViewCheckTools";
            this.dataGridViewCheckTools.ReadOnly = true;
            this.dataGridViewCheckTools.RowTemplate.ReadOnly = true;
            this.dataGridViewCheckTools.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridViewCheckTools.ShowEditingIcon = false;
            this.dataGridViewCheckTools.Size = new System.Drawing.Size(758, 153);
            this.dataGridViewCheckTools.TabIndex = 9;
            // 
            // Tool
            // 
            this.Tool.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Tool.FillWeight = 336F;
            this.Tool.HeaderText = "Required Tool / Software";
            this.Tool.Name = "Tool";
            this.Tool.ReadOnly = true;
            this.Tool.Width = 390;
            // 
            // Type
            // 
            this.Type.FillWeight = 90F;
            this.Type.HeaderText = "Type";
            this.Type.Name = "Type";
            this.Type.ReadOnly = true;
            this.Type.Width = 75;
            // 
            // Status
            // 
            this.Status.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Status.FillWeight = 20F;
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            // 
            // ColumnExpiryDate
            // 
            this.ColumnExpiryDate.HeaderText = "Expiry Date";
            this.ColumnExpiryDate.Name = "ColumnExpiryDate";
            this.ColumnExpiryDate.ReadOnly = true;
            this.ColumnExpiryDate.Width = 120;
            // 
            // labelCheckTools
            // 
            this.labelCheckTools.AutoSize = true;
            this.labelCheckTools.BackColor = System.Drawing.Color.Transparent;
            this.labelCheckTools.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCheckTools.ForeColor = System.Drawing.Color.Black;
            this.labelCheckTools.Location = new System.Drawing.Point(1, 16);
            this.labelCheckTools.Name = "labelCheckTools";
            this.labelCheckTools.Size = new System.Drawing.Size(100, 20);
            this.labelCheckTools.TabIndex = 6;
            this.labelCheckTools.Text = "Check Tools:";
            // 
            // groupBoxTools
            // 
            this.groupBoxTools.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxTools.AutoSize = true;
            this.groupBoxTools.Controls.Add(this.dataGridViewCheckTools);
            this.groupBoxTools.Controls.Add(this.labelCheckTools);
            this.groupBoxTools.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxTools.ForeColor = System.Drawing.Color.White;
            this.groupBoxTools.Location = new System.Drawing.Point(199, 6);
            this.groupBoxTools.Name = "groupBoxTools";
            this.groupBoxTools.Size = new System.Drawing.Size(769, 198);
            this.groupBoxTools.TabIndex = 10;
            this.groupBoxTools.TabStop = false;
            // 
            // labelDeveloper
            // 
            this.labelDeveloper.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelDeveloper.AutoSize = true;
            this.labelDeveloper.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDeveloper.Location = new System.Drawing.Point(2, 636);
            this.labelDeveloper.Name = "labelDeveloper";
            this.labelDeveloper.Size = new System.Drawing.Size(163, 13);
            this.labelDeveloper.TabIndex = 12;
            this.labelDeveloper.Text = "Developed by Arquimedes Miguel";
            // 
            // pictureBoxFlexLogo
            // 
            this.pictureBoxFlexLogo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxFlexLogo.Image = global::QC_Tool.Properties.Resources.flex1;
            this.pictureBoxFlexLogo.Location = new System.Drawing.Point(865, 4);
            this.pictureBoxFlexLogo.Name = "pictureBoxFlexLogo";
            this.pictureBoxFlexLogo.Size = new System.Drawing.Size(119, 54);
            this.pictureBoxFlexLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxFlexLogo.TabIndex = 11;
            this.pictureBoxFlexLogo.TabStop = false;
            // 
            // textBoxDetails
            // 
            this.textBoxDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxDetails.BackColor = System.Drawing.Color.White;
            this.textBoxDetails.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDetails.Location = new System.Drawing.Point(3, 204);
            this.textBoxDetails.Multiline = true;
            this.textBoxDetails.Name = "textBoxDetails";
            this.textBoxDetails.ReadOnly = true;
            this.textBoxDetails.Size = new System.Drawing.Size(962, 298);
            this.textBoxDetails.TabIndex = 13;
            // 
            // tabControlMain
            // 
            this.tabControlMain.Controls.Add(this.tabPageOperator);
            this.tabControlMain.Controls.Add(this.tabPageEngineer);
            this.tabControlMain.Location = new System.Drawing.Point(5, 42);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(979, 534);
            this.tabControlMain.TabIndex = 14;
            // 
            // tabPageOperator
            // 
            this.tabPageOperator.Controls.Add(this.groupBoxSettings);
            this.tabPageOperator.Controls.Add(this.textBoxDetails);
            this.tabPageOperator.Controls.Add(this.groupBoxTools);
            this.tabPageOperator.Location = new System.Drawing.Point(4, 22);
            this.tabPageOperator.Name = "tabPageOperator";
            this.tabPageOperator.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageOperator.Size = new System.Drawing.Size(971, 508);
            this.tabPageOperator.TabIndex = 0;
            this.tabPageOperator.Text = "Operator";
            this.tabPageOperator.UseVisualStyleBackColor = true;
            // 
            // tabPageEngineer
            // 
            this.tabPageEngineer.Controls.Add(this.groupBoxLicenseNumber);
            this.tabPageEngineer.Controls.Add(this.groupBoxType);
            this.tabPageEngineer.Controls.Add(this.groupBoxUserLicense);
            this.tabPageEngineer.Controls.Add(this.groupBoxLicenseType);
            this.tabPageEngineer.Controls.Add(this.groupBoxStation);
            this.tabPageEngineer.Controls.Add(this.groupBoxProduct);
            this.tabPageEngineer.Controls.Add(this.buttonAddPath);
            this.tabPageEngineer.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPageEngineer.Location = new System.Drawing.Point(4, 22);
            this.tabPageEngineer.Name = "tabPageEngineer";
            this.tabPageEngineer.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageEngineer.Size = new System.Drawing.Size(971, 508);
            this.tabPageEngineer.TabIndex = 1;
            this.tabPageEngineer.Text = "Engineer";
            this.tabPageEngineer.UseVisualStyleBackColor = true;
            // 
            // comboBoxBenchName
            // 
            this.comboBoxBenchName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxBenchName.FormattingEnabled = true;
            this.comboBoxBenchName.Items.AddRange(new object[] {
            "5GFR1BDTST",
            "BrdTest",
            "LCDCAL"});
            this.comboBoxBenchName.Location = new System.Drawing.Point(9, 39);
            this.comboBoxBenchName.Name = "comboBoxBenchName";
            this.comboBoxBenchName.Size = new System.Drawing.Size(121, 26);
            this.comboBoxBenchName.TabIndex = 12;
            this.comboBoxBenchName.Text = "5GFR1BDTST";
            // 
            // buttonAddPath
            // 
            this.buttonAddPath.Location = new System.Drawing.Point(891, 380);
            this.buttonAddPath.Name = "buttonAddPath";
            this.buttonAddPath.Size = new System.Drawing.Size(75, 30);
            this.buttonAddPath.TabIndex = 11;
            this.buttonAddPath.Text = "Add";
            this.buttonAddPath.UseVisualStyleBackColor = true;
            this.buttonAddPath.Click += new System.EventHandler(this.buttonAddPath_Click);
            // 
            // comboBoxItemType
            // 
            this.comboBoxItemType.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxItemType.FormattingEnabled = true;
            this.comboBoxItemType.Items.AddRange(new object[] {
            "Tool",
            "License"});
            this.comboBoxItemType.Location = new System.Drawing.Point(16, 39);
            this.comboBoxItemType.Name = "comboBoxItemType";
            this.comboBoxItemType.Size = new System.Drawing.Size(121, 26);
            this.comboBoxItemType.TabIndex = 10;
            this.comboBoxItemType.Text = "Tool";
            // 
            // textBoxItemPath
            // 
            this.textBoxItemPath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxItemPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxItemPath.Location = new System.Drawing.Point(16, 39);
            this.textBoxItemPath.Name = "textBoxItemPath";
            this.textBoxItemPath.Size = new System.Drawing.Size(150, 24);
            this.textBoxItemPath.TabIndex = 9;
            this.textBoxItemPath.Text = "dasdasdas";
            // 
            // labelItemPath
            // 
            this.labelItemPath.AutoSize = true;
            this.labelItemPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelItemPath.Location = new System.Drawing.Point(13, 20);
            this.labelItemPath.Name = "labelItemPath";
            this.labelItemPath.Size = new System.Drawing.Size(109, 16);
            this.labelItemPath.TabIndex = 8;
            this.labelItemPath.Text = "License Number:";
            // 
            // labelItemType
            // 
            this.labelItemType.AutoSize = true;
            this.labelItemType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelItemType.Location = new System.Drawing.Point(13, 20);
            this.labelItemType.Name = "labelItemType";
            this.labelItemType.Size = new System.Drawing.Size(68, 16);
            this.labelItemType.TabIndex = 6;
            this.labelItemType.Text = "ItemType:";
            // 
            // textBoxItemName
            // 
            this.textBoxItemName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxItemName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxItemName.Location = new System.Drawing.Point(9, 39);
            this.textBoxItemName.Name = "textBoxItemName";
            this.textBoxItemName.Size = new System.Drawing.Size(150, 24);
            this.textBoxItemName.TabIndex = 5;
            this.textBoxItemName.Text = "dasdas";
            // 
            // labelItemName
            // 
            this.labelItemName.AutoSize = true;
            this.labelItemName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelItemName.Location = new System.Drawing.Point(6, 20);
            this.labelItemName.Name = "labelItemName";
            this.labelItemName.Size = new System.Drawing.Size(93, 16);
            this.labelItemName.TabIndex = 4;
            this.labelItemName.Text = "License Type:";
            // 
            // labelBenchName
            // 
            this.labelBenchName.AutoSize = true;
            this.labelBenchName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBenchName.Location = new System.Drawing.Point(6, 20);
            this.labelBenchName.Name = "labelBenchName";
            this.labelBenchName.Size = new System.Drawing.Size(52, 16);
            this.labelBenchName.TabIndex = 2;
            this.labelBenchName.Text = "Station:";
            // 
            // textBoxProductName
            // 
            this.textBoxProductName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxProductName.Location = new System.Drawing.Point(10, 39);
            this.textBoxProductName.Multiline = true;
            this.textBoxProductName.Name = "textBoxProductName";
            this.textBoxProductName.Size = new System.Drawing.Size(150, 20);
            this.textBoxProductName.TabIndex = 1;
            this.textBoxProductName.Text = "VENUS";
            // 
            // labelProductName
            // 
            this.labelProductName.AutoSize = true;
            this.labelProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProductName.Location = new System.Drawing.Point(6, 20);
            this.labelProductName.Name = "labelProductName";
            this.labelProductName.Size = new System.Drawing.Size(94, 16);
            this.labelProductName.TabIndex = 0;
            this.labelProductName.Text = "ProductName:";
            // 
            // labelWarning
            // 
            this.labelWarning.Enabled = false;
            this.labelWarning.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWarning.Location = new System.Drawing.Point(10, 576);
            this.labelWarning.Name = "labelWarning";
            this.labelWarning.Size = new System.Drawing.Size(965, 42);
            this.labelWarning.TabIndex = 14;
            this.labelWarning.Text = "warning";
            this.labelWarning.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelWarning.Visible = false;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Segoe UI", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.labelName.Location = new System.Drawing.Point(5, 2);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(118, 37);
            this.labelName.TabIndex = 15;
            this.labelName.Text = "QC Tool";
            // 
            // buttonExit
            // 
            this.buttonExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonExit.BackColor = System.Drawing.Color.White;
            this.buttonExit.Location = new System.Drawing.Point(902, 624);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(75, 23);
            this.buttonExit.TabIndex = 16;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // textBoxUser
            // 
            this.textBoxUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUser.Location = new System.Drawing.Point(16, 39);
            this.textBoxUser.Name = "textBoxUser";
            this.textBoxUser.Size = new System.Drawing.Size(150, 24);
            this.textBoxUser.TabIndex = 14;
            // 
            // labelUser
            // 
            this.labelUser.AutoSize = true;
            this.labelUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUser.Location = new System.Drawing.Point(13, 20);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(40, 16);
            this.labelUser.TabIndex = 13;
            this.labelUser.Text = "User:";
            // 
            // groupBoxProduct
            // 
            this.groupBoxProduct.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxProduct.Controls.Add(this.textBox1);
            this.groupBoxProduct.Controls.Add(this.button2);
            this.groupBoxProduct.Controls.Add(this.button1);
            this.groupBoxProduct.Controls.Add(this.labelProductName);
            this.groupBoxProduct.Controls.Add(this.textBoxProductName);
            this.groupBoxProduct.Location = new System.Drawing.Point(8, 13);
            this.groupBoxProduct.Name = "groupBoxProduct";
            this.groupBoxProduct.Size = new System.Drawing.Size(400, 155);
            this.groupBoxProduct.TabIndex = 15;
            this.groupBoxProduct.TabStop = false;
            this.groupBoxProduct.Text = "Product";
            // 
            // groupBoxStation
            // 
            this.groupBoxStation.Controls.Add(this.textBox2);
            this.groupBoxStation.Controls.Add(this.button3);
            this.groupBoxStation.Controls.Add(this.labelBenchName);
            this.groupBoxStation.Controls.Add(this.button4);
            this.groupBoxStation.Controls.Add(this.comboBoxBenchName);
            this.groupBoxStation.Location = new System.Drawing.Point(8, 174);
            this.groupBoxStation.Name = "groupBoxStation";
            this.groupBoxStation.Size = new System.Drawing.Size(400, 155);
            this.groupBoxStation.TabIndex = 16;
            this.groupBoxStation.TabStop = false;
            this.groupBoxStation.Text = "Station";
            // 
            // groupBoxLicenseType
            // 
            this.groupBoxLicenseType.Controls.Add(this.textBox3);
            this.groupBoxLicenseType.Controls.Add(this.button5);
            this.groupBoxLicenseType.Controls.Add(this.labelItemName);
            this.groupBoxLicenseType.Controls.Add(this.button6);
            this.groupBoxLicenseType.Controls.Add(this.textBoxItemName);
            this.groupBoxLicenseType.Location = new System.Drawing.Point(8, 335);
            this.groupBoxLicenseType.Name = "groupBoxLicenseType";
            this.groupBoxLicenseType.Size = new System.Drawing.Size(400, 155);
            this.groupBoxLicenseType.TabIndex = 17;
            this.groupBoxLicenseType.TabStop = false;
            this.groupBoxLicenseType.Text = "License Type";
            // 
            // groupBoxUserLicense
            // 
            this.groupBoxUserLicense.Controls.Add(this.textBox4);
            this.groupBoxUserLicense.Controls.Add(this.button7);
            this.groupBoxUserLicense.Controls.Add(this.groupBox2);
            this.groupBoxUserLicense.Controls.Add(this.button8);
            this.groupBoxUserLicense.Controls.Add(this.textBoxUser);
            this.groupBoxUserLicense.Controls.Add(this.labelUser);
            this.groupBoxUserLicense.Location = new System.Drawing.Point(423, 13);
            this.groupBoxUserLicense.Name = "groupBoxUserLicense";
            this.groupBoxUserLicense.Size = new System.Drawing.Size(400, 155);
            this.groupBoxUserLicense.TabIndex = 18;
            this.groupBoxUserLicense.TabStop = false;
            this.groupBoxUserLicense.Text = "User License";
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(0, 161);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(299, 155);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // groupBoxType
            // 
            this.groupBoxType.Controls.Add(this.textBox5);
            this.groupBoxType.Controls.Add(this.button9);
            this.groupBoxType.Controls.Add(this.labelItemType);
            this.groupBoxType.Controls.Add(this.button10);
            this.groupBoxType.Controls.Add(this.comboBoxItemType);
            this.groupBoxType.Location = new System.Drawing.Point(423, 174);
            this.groupBoxType.Name = "groupBoxType";
            this.groupBoxType.Size = new System.Drawing.Size(400, 155);
            this.groupBoxType.TabIndex = 19;
            this.groupBoxType.TabStop = false;
            this.groupBoxType.Text = "Type";
            // 
            // groupBoxLicenseNumber
            // 
            this.groupBoxLicenseNumber.Controls.Add(this.textBox6);
            this.groupBoxLicenseNumber.Controls.Add(this.button11);
            this.groupBoxLicenseNumber.Controls.Add(this.labelItemPath);
            this.groupBoxLicenseNumber.Controls.Add(this.button12);
            this.groupBoxLicenseNumber.Controls.Add(this.textBoxItemPath);
            this.groupBoxLicenseNumber.Location = new System.Drawing.Point(423, 335);
            this.groupBoxLicenseNumber.Name = "groupBoxLicenseNumber";
            this.groupBoxLicenseNumber.Size = new System.Drawing.Size(400, 155);
            this.groupBoxLicenseNumber.TabIndex = 20;
            this.groupBoxLicenseNumber.TabStop = false;
            this.groupBoxLicenseNumber.Text = "License Number";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(165, 39);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(60, 42);
            this.button1.TabIndex = 2;
            this.button1.Text = ">>";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(165, 87);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(60, 42);
            this.button2.TabIndex = 3;
            this.button2.Text = "<<";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(165, 87);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(60, 42);
            this.button3.TabIndex = 5;
            this.button3.Text = "<<";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(165, 39);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(60, 42);
            this.button4.TabIndex = 4;
            this.button4.Text = ">>";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(165, 87);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(60, 42);
            this.button5.TabIndex = 14;
            this.button5.Text = "<<";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(165, 39);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(60, 42);
            this.button6.TabIndex = 13;
            this.button6.Text = ">>";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(172, 87);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(60, 42);
            this.button7.TabIndex = 16;
            this.button7.Text = "<<";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(172, 39);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(60, 42);
            this.button8.TabIndex = 15;
            this.button8.Text = ">>";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(172, 87);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(60, 42);
            this.button9.TabIndex = 21;
            this.button9.Text = "<<";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(172, 39);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(60, 42);
            this.button10.TabIndex = 20;
            this.button10.Text = ">>";
            this.button10.UseVisualStyleBackColor = true;
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(172, 71);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(60, 42);
            this.button11.TabIndex = 23;
            this.button11.Text = "<<";
            this.button11.UseVisualStyleBackColor = true;
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(172, 23);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(60, 42);
            this.button12.TabIndex = 22;
            this.button12.Text = ">>";
            this.button12.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(231, 39);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(150, 24);
            this.textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(231, 39);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(150, 24);
            this.textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(231, 38);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(150, 24);
            this.textBox3.TabIndex = 13;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(244, 39);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(150, 24);
            this.textBox4.TabIndex = 15;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(238, 39);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(150, 24);
            this.textBox5.TabIndex = 20;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(238, 39);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(150, 24);
            this.textBox6.TabIndex = 22;
            // 
            // FormApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(987, 652);
            this.ControlBox = false;
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.pictureBoxFlexLogo);
            this.Controls.Add(this.labelWarning);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.tabControlMain);
            this.Controls.Add(this.labelDeveloper);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormApp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QC Tool  -  v1.0";
            this.groupBoxSettings.ResumeLayout(false);
            this.groupBoxSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCheckTools)).EndInit();
            this.groupBoxTools.ResumeLayout(false);
            this.groupBoxTools.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFlexLogo)).EndInit();
            this.tabControlMain.ResumeLayout(false);
            this.tabPageOperator.ResumeLayout(false);
            this.tabPageOperator.PerformLayout();
            this.tabPageEngineer.ResumeLayout(false);
            this.groupBoxProduct.ResumeLayout(false);
            this.groupBoxProduct.PerformLayout();
            this.groupBoxStation.ResumeLayout(false);
            this.groupBoxStation.PerformLayout();
            this.groupBoxLicenseType.ResumeLayout(false);
            this.groupBoxLicenseType.PerformLayout();
            this.groupBoxUserLicense.ResumeLayout(false);
            this.groupBoxUserLicense.PerformLayout();
            this.groupBoxType.ResumeLayout(false);
            this.groupBoxType.PerformLayout();
            this.groupBoxLicenseNumber.ResumeLayout(false);
            this.groupBoxLicenseNumber.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelProduto;
        private System.Windows.Forms.Label labelEstacao;
        private System.Windows.Forms.GroupBox groupBoxSettings;
        private System.Windows.Forms.Label labelCheckTools;
        private System.Windows.Forms.GroupBox groupBoxTools;
        private System.Windows.Forms.PictureBox pictureBoxFlexLogo;
        private System.Windows.Forms.Label labelDeveloper;
        private System.Windows.Forms.TabPage tabPageOperator;
        private System.Windows.Forms.TabPage tabPageEngineer;
        private System.Windows.Forms.Label labelName;
        public System.Windows.Forms.ComboBox comboBoxProducts;
        public System.Windows.Forms.ComboBox comboBoxEstation;
        public System.Windows.Forms.DataGridView dataGridViewCheckTools;
        public System.Windows.Forms.Label labelWarning;
        public System.Windows.Forms.TabControl tabControlMain;
        public System.Windows.Forms.Button buttonActions;
        public System.Windows.Forms.TextBox textBoxDetails;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tool;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnExpiryDate;
        public System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Label labelItemPath;
        private System.Windows.Forms.Label labelItemType;
        private System.Windows.Forms.Label labelItemName;
        private System.Windows.Forms.Label labelBenchName;
        private System.Windows.Forms.Label labelProductName;
        public System.Windows.Forms.Button buttonAddPath;
        public System.Windows.Forms.ComboBox comboBoxItemType;
        public System.Windows.Forms.TextBox textBoxItemPath;
        public System.Windows.Forms.TextBox textBoxItemName;
        public System.Windows.Forms.TextBox textBoxProductName;
        public System.Windows.Forms.ComboBox comboBoxBenchName;
        public System.Windows.Forms.TextBox textBoxUser;
        private System.Windows.Forms.Label labelUser;
        private System.Windows.Forms.GroupBox groupBoxLicenseNumber;
        private System.Windows.Forms.GroupBox groupBoxType;
        private System.Windows.Forms.GroupBox groupBoxUserLicense;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBoxLicenseType;
        private System.Windows.Forms.GroupBox groupBoxStation;
        private System.Windows.Forms.GroupBox groupBoxProduct;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}

