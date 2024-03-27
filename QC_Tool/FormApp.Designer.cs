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
            this.groupBoxLicenseNumber = new System.Windows.Forms.GroupBox();
            this.listBoxLicenseNumberInclude = new System.Windows.Forms.ListBox();
            this.listBoxLicenseNumberFile = new System.Windows.Forms.ListBox();
            this.buttonReturnLicenseNumberFile = new System.Windows.Forms.Button();
            this.labelItemPath = new System.Windows.Forms.Label();
            this.buttonPassLicenseNumberFile = new System.Windows.Forms.Button();
            this.groupBoxType = new System.Windows.Forms.GroupBox();
            this.listBoxItemTipeInclude = new System.Windows.Forms.ListBox();
            this.listBoxItemTypeFile = new System.Windows.Forms.ListBox();
            this.buttonReturnItemTypeFile = new System.Windows.Forms.Button();
            this.labelItemType = new System.Windows.Forms.Label();
            this.buttonPassItemTypeFile = new System.Windows.Forms.Button();
            this.groupBoxUserLicense = new System.Windows.Forms.GroupBox();
            this.listBoxUserInclude = new System.Windows.Forms.ListBox();
            this.listBoxUserFile = new System.Windows.Forms.ListBox();
            this.buttonReturnUserFile = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonPassUserFile = new System.Windows.Forms.Button();
            this.labelUser = new System.Windows.Forms.Label();
            this.groupBoxLicenseType = new System.Windows.Forms.GroupBox();
            this.listBoxLicenseTypeInclude = new System.Windows.Forms.ListBox();
            this.listBoxLicenseTypeFile = new System.Windows.Forms.ListBox();
            this.buttonReturnLicenseTypeFile = new System.Windows.Forms.Button();
            this.labelItemName = new System.Windows.Forms.Label();
            this.buttonPassLicenseTypeFile = new System.Windows.Forms.Button();
            this.groupBoxStation = new System.Windows.Forms.GroupBox();
            this.listBoxStationInclude = new System.Windows.Forms.ListBox();
            this.listBoxStationFile = new System.Windows.Forms.ListBox();
            this.buttonReturnBoxStationFile = new System.Windows.Forms.Button();
            this.labelBenchName = new System.Windows.Forms.Label();
            this.buttonPassBoxStationFile = new System.Windows.Forms.Button();
            this.groupBoxProduct = new System.Windows.Forms.GroupBox();
            this.listBoxProductInclude = new System.Windows.Forms.ListBox();
            this.listBoxProductNameFile = new System.Windows.Forms.ListBox();
            this.buttonReturnProductNameFile = new System.Windows.Forms.Button();
            this.buttonPassProductNameFile = new System.Windows.Forms.Button();
            this.labelProductName = new System.Windows.Forms.Label();
            this.buttonAddPath = new System.Windows.Forms.Button();
            this.labelWarning = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.buttonExit = new System.Windows.Forms.Button();
            this.groupBoxSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCheckTools)).BeginInit();
            this.groupBoxTools.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFlexLogo)).BeginInit();
            this.tabControlMain.SuspendLayout();
            this.tabPageOperator.SuspendLayout();
            this.tabPageEngineer.SuspendLayout();
            this.groupBoxLicenseNumber.SuspendLayout();
            this.groupBoxType.SuspendLayout();
            this.groupBoxUserLicense.SuspendLayout();
            this.groupBoxLicenseType.SuspendLayout();
            this.groupBoxStation.SuspendLayout();
            this.groupBoxProduct.SuspendLayout();
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
            // groupBoxLicenseNumber
            // 
            this.groupBoxLicenseNumber.Controls.Add(this.listBoxLicenseNumberInclude);
            this.groupBoxLicenseNumber.Controls.Add(this.listBoxLicenseNumberFile);
            this.groupBoxLicenseNumber.Controls.Add(this.buttonReturnLicenseNumberFile);
            this.groupBoxLicenseNumber.Controls.Add(this.labelItemPath);
            this.groupBoxLicenseNumber.Controls.Add(this.buttonPassLicenseNumberFile);
            this.groupBoxLicenseNumber.Location = new System.Drawing.Point(327, 326);
            this.groupBoxLicenseNumber.Name = "groupBoxLicenseNumber";
            this.groupBoxLicenseNumber.Size = new System.Drawing.Size(567, 155);
            this.groupBoxLicenseNumber.TabIndex = 20;
            this.groupBoxLicenseNumber.TabStop = false;
            this.groupBoxLicenseNumber.Text = "License Number";
            // 
            // listBoxLicenseNumberInclude
            // 
            this.listBoxLicenseNumberInclude.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxLicenseNumberInclude.FormattingEnabled = true;
            this.listBoxLicenseNumberInclude.HorizontalScrollbar = true;
            this.listBoxLicenseNumberInclude.Location = new System.Drawing.Point(312, 39);
            this.listBoxLicenseNumberInclude.Name = "listBoxLicenseNumberInclude";
            this.listBoxLicenseNumberInclude.Size = new System.Drawing.Size(240, 95);
            this.listBoxLicenseNumberInclude.TabIndex = 24;
            // 
            // listBoxLicenseNumberFile
            // 
            this.listBoxLicenseNumberFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxLicenseNumberFile.FormattingEnabled = true;
            this.listBoxLicenseNumberFile.HorizontalScrollbar = true;
            this.listBoxLicenseNumberFile.Location = new System.Drawing.Point(6, 39);
            this.listBoxLicenseNumberFile.Name = "listBoxLicenseNumberFile";
            this.listBoxLicenseNumberFile.Size = new System.Drawing.Size(240, 95);
            this.listBoxLicenseNumberFile.TabIndex = 22;
            // 
            // buttonReturnLicenseNumberFile
            // 
            this.buttonReturnLicenseNumberFile.Location = new System.Drawing.Point(249, 87);
            this.buttonReturnLicenseNumberFile.Name = "buttonReturnLicenseNumberFile";
            this.buttonReturnLicenseNumberFile.Size = new System.Drawing.Size(60, 42);
            this.buttonReturnLicenseNumberFile.TabIndex = 23;
            this.buttonReturnLicenseNumberFile.Text = "<<";
            this.buttonReturnLicenseNumberFile.UseVisualStyleBackColor = true;
            this.buttonReturnLicenseNumberFile.Click += new System.EventHandler(this.buttonReturnLicenseNumberFile_Click);
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
            // buttonPassLicenseNumberFile
            // 
            this.buttonPassLicenseNumberFile.Location = new System.Drawing.Point(249, 39);
            this.buttonPassLicenseNumberFile.Name = "buttonPassLicenseNumberFile";
            this.buttonPassLicenseNumberFile.Size = new System.Drawing.Size(60, 42);
            this.buttonPassLicenseNumberFile.TabIndex = 22;
            this.buttonPassLicenseNumberFile.Text = ">>";
            this.buttonPassLicenseNumberFile.UseVisualStyleBackColor = true;
            this.buttonPassLicenseNumberFile.Click += new System.EventHandler(this.buttonPassLicenseNumberFile_Click);
            // 
            // groupBoxType
            // 
            this.groupBoxType.Controls.Add(this.listBoxItemTipeInclude);
            this.groupBoxType.Controls.Add(this.listBoxItemTypeFile);
            this.groupBoxType.Controls.Add(this.buttonReturnItemTypeFile);
            this.groupBoxType.Controls.Add(this.labelItemType);
            this.groupBoxType.Controls.Add(this.buttonPassItemTypeFile);
            this.groupBoxType.Location = new System.Drawing.Point(327, 165);
            this.groupBoxType.Name = "groupBoxType";
            this.groupBoxType.Size = new System.Drawing.Size(567, 155);
            this.groupBoxType.TabIndex = 19;
            this.groupBoxType.TabStop = false;
            this.groupBoxType.Text = "Type";
            // 
            // listBoxItemTipeInclude
            // 
            this.listBoxItemTipeInclude.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxItemTipeInclude.FormattingEnabled = true;
            this.listBoxItemTipeInclude.ItemHeight = 16;
            this.listBoxItemTipeInclude.Location = new System.Drawing.Point(312, 39);
            this.listBoxItemTipeInclude.Name = "listBoxItemTipeInclude";
            this.listBoxItemTipeInclude.Size = new System.Drawing.Size(240, 100);
            this.listBoxItemTipeInclude.TabIndex = 25;
            // 
            // listBoxItemTypeFile
            // 
            this.listBoxItemTypeFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxItemTypeFile.FormattingEnabled = true;
            this.listBoxItemTypeFile.ItemHeight = 16;
            this.listBoxItemTypeFile.Location = new System.Drawing.Point(6, 35);
            this.listBoxItemTypeFile.Name = "listBoxItemTypeFile";
            this.listBoxItemTypeFile.Size = new System.Drawing.Size(240, 100);
            this.listBoxItemTypeFile.TabIndex = 20;
            // 
            // buttonReturnItemTypeFile
            // 
            this.buttonReturnItemTypeFile.Location = new System.Drawing.Point(250, 87);
            this.buttonReturnItemTypeFile.Name = "buttonReturnItemTypeFile";
            this.buttonReturnItemTypeFile.Size = new System.Drawing.Size(60, 42);
            this.buttonReturnItemTypeFile.TabIndex = 21;
            this.buttonReturnItemTypeFile.Text = "<<";
            this.buttonReturnItemTypeFile.UseVisualStyleBackColor = true;
            this.buttonReturnItemTypeFile.Click += new System.EventHandler(this.buttonReturnItemTypeFile_Click);
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
            // buttonPassItemTypeFile
            // 
            this.buttonPassItemTypeFile.Location = new System.Drawing.Point(249, 39);
            this.buttonPassItemTypeFile.Name = "buttonPassItemTypeFile";
            this.buttonPassItemTypeFile.Size = new System.Drawing.Size(60, 42);
            this.buttonPassItemTypeFile.TabIndex = 20;
            this.buttonPassItemTypeFile.Text = ">>";
            this.buttonPassItemTypeFile.UseVisualStyleBackColor = true;
            this.buttonPassItemTypeFile.Click += new System.EventHandler(this.buttonPassItemTypeFile_Click);
            // 
            // groupBoxUserLicense
            // 
            this.groupBoxUserLicense.Controls.Add(this.listBoxUserInclude);
            this.groupBoxUserLicense.Controls.Add(this.listBoxUserFile);
            this.groupBoxUserLicense.Controls.Add(this.buttonReturnUserFile);
            this.groupBoxUserLicense.Controls.Add(this.groupBox2);
            this.groupBoxUserLicense.Controls.Add(this.buttonPassUserFile);
            this.groupBoxUserLicense.Controls.Add(this.labelUser);
            this.groupBoxUserLicense.Location = new System.Drawing.Point(327, 4);
            this.groupBoxUserLicense.Name = "groupBoxUserLicense";
            this.groupBoxUserLicense.Size = new System.Drawing.Size(567, 155);
            this.groupBoxUserLicense.TabIndex = 18;
            this.groupBoxUserLicense.TabStop = false;
            this.groupBoxUserLicense.Text = "User License";
            // 
            // listBoxUserInclude
            // 
            this.listBoxUserInclude.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxUserInclude.FormattingEnabled = true;
            this.listBoxUserInclude.ItemHeight = 16;
            this.listBoxUserInclude.Location = new System.Drawing.Point(312, 39);
            this.listBoxUserInclude.Name = "listBoxUserInclude";
            this.listBoxUserInclude.Size = new System.Drawing.Size(240, 100);
            this.listBoxUserInclude.TabIndex = 24;
            // 
            // listBoxUserFile
            // 
            this.listBoxUserFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxUserFile.FormattingEnabled = true;
            this.listBoxUserFile.ItemHeight = 16;
            this.listBoxUserFile.Location = new System.Drawing.Point(6, 39);
            this.listBoxUserFile.Name = "listBoxUserFile";
            this.listBoxUserFile.Size = new System.Drawing.Size(240, 100);
            this.listBoxUserFile.TabIndex = 16;
            // 
            // buttonReturnUserFile
            // 
            this.buttonReturnUserFile.Location = new System.Drawing.Point(249, 87);
            this.buttonReturnUserFile.Name = "buttonReturnUserFile";
            this.buttonReturnUserFile.Size = new System.Drawing.Size(60, 42);
            this.buttonReturnUserFile.TabIndex = 16;
            this.buttonReturnUserFile.Text = "<<";
            this.buttonReturnUserFile.UseVisualStyleBackColor = true;
            this.buttonReturnUserFile.Click += new System.EventHandler(this.buttonReturnUserFile_Click);
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
            // buttonPassUserFile
            // 
            this.buttonPassUserFile.Location = new System.Drawing.Point(249, 39);
            this.buttonPassUserFile.Name = "buttonPassUserFile";
            this.buttonPassUserFile.Size = new System.Drawing.Size(60, 42);
            this.buttonPassUserFile.TabIndex = 15;
            this.buttonPassUserFile.Text = ">>";
            this.buttonPassUserFile.UseVisualStyleBackColor = true;
            this.buttonPassUserFile.Click += new System.EventHandler(this.buttonPassUserFile_Click);
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
            // groupBoxLicenseType
            // 
            this.groupBoxLicenseType.Controls.Add(this.listBoxLicenseTypeInclude);
            this.groupBoxLicenseType.Controls.Add(this.listBoxLicenseTypeFile);
            this.groupBoxLicenseType.Controls.Add(this.buttonReturnLicenseTypeFile);
            this.groupBoxLicenseType.Controls.Add(this.labelItemName);
            this.groupBoxLicenseType.Controls.Add(this.buttonPassLicenseTypeFile);
            this.groupBoxLicenseType.Location = new System.Drawing.Point(8, 326);
            this.groupBoxLicenseType.Name = "groupBoxLicenseType";
            this.groupBoxLicenseType.Size = new System.Drawing.Size(313, 155);
            this.groupBoxLicenseType.TabIndex = 17;
            this.groupBoxLicenseType.TabStop = false;
            this.groupBoxLicenseType.Text = "License Type";
            // 
            // listBoxLicenseTypeInclude
            // 
            this.listBoxLicenseTypeInclude.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxLicenseTypeInclude.FormattingEnabled = true;
            this.listBoxLicenseTypeInclude.ItemHeight = 16;
            this.listBoxLicenseTypeInclude.Location = new System.Drawing.Point(191, 39);
            this.listBoxLicenseTypeInclude.Name = "listBoxLicenseTypeInclude";
            this.listBoxLicenseTypeInclude.Size = new System.Drawing.Size(110, 100);
            this.listBoxLicenseTypeInclude.TabIndex = 15;
            // 
            // listBoxLicenseTypeFile
            // 
            this.listBoxLicenseTypeFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxLicenseTypeFile.FormattingEnabled = true;
            this.listBoxLicenseTypeFile.ItemHeight = 16;
            this.listBoxLicenseTypeFile.Location = new System.Drawing.Point(9, 39);
            this.listBoxLicenseTypeFile.Name = "listBoxLicenseTypeFile";
            this.listBoxLicenseTypeFile.Size = new System.Drawing.Size(110, 100);
            this.listBoxLicenseTypeFile.TabIndex = 8;
            // 
            // buttonReturnLicenseTypeFile
            // 
            this.buttonReturnLicenseTypeFile.Location = new System.Drawing.Point(125, 87);
            this.buttonReturnLicenseTypeFile.Name = "buttonReturnLicenseTypeFile";
            this.buttonReturnLicenseTypeFile.Size = new System.Drawing.Size(60, 42);
            this.buttonReturnLicenseTypeFile.TabIndex = 14;
            this.buttonReturnLicenseTypeFile.Text = "<<";
            this.buttonReturnLicenseTypeFile.UseVisualStyleBackColor = true;
            this.buttonReturnLicenseTypeFile.Click += new System.EventHandler(this.buttonReturnLicenseTypeFile_Click);
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
            // buttonPassLicenseTypeFile
            // 
            this.buttonPassLicenseTypeFile.Location = new System.Drawing.Point(125, 39);
            this.buttonPassLicenseTypeFile.Name = "buttonPassLicenseTypeFile";
            this.buttonPassLicenseTypeFile.Size = new System.Drawing.Size(60, 42);
            this.buttonPassLicenseTypeFile.TabIndex = 13;
            this.buttonPassLicenseTypeFile.Text = ">>";
            this.buttonPassLicenseTypeFile.UseVisualStyleBackColor = true;
            this.buttonPassLicenseTypeFile.Click += new System.EventHandler(this.buttonPassLicenseTypeFile_Click);
            // 
            // groupBoxStation
            // 
            this.groupBoxStation.Controls.Add(this.listBoxStationInclude);
            this.groupBoxStation.Controls.Add(this.listBoxStationFile);
            this.groupBoxStation.Controls.Add(this.buttonReturnBoxStationFile);
            this.groupBoxStation.Controls.Add(this.labelBenchName);
            this.groupBoxStation.Controls.Add(this.buttonPassBoxStationFile);
            this.groupBoxStation.Location = new System.Drawing.Point(8, 165);
            this.groupBoxStation.Name = "groupBoxStation";
            this.groupBoxStation.Size = new System.Drawing.Size(313, 155);
            this.groupBoxStation.TabIndex = 16;
            this.groupBoxStation.TabStop = false;
            this.groupBoxStation.Text = "Station";
            // 
            // listBoxStationInclude
            // 
            this.listBoxStationInclude.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxStationInclude.FormattingEnabled = true;
            this.listBoxStationInclude.ItemHeight = 16;
            this.listBoxStationInclude.Location = new System.Drawing.Point(191, 39);
            this.listBoxStationInclude.Name = "listBoxStationInclude";
            this.listBoxStationInclude.Size = new System.Drawing.Size(110, 100);
            this.listBoxStationInclude.TabIndex = 7;
            // 
            // listBoxStationFile
            // 
            this.listBoxStationFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxStationFile.FormattingEnabled = true;
            this.listBoxStationFile.ItemHeight = 16;
            this.listBoxStationFile.Location = new System.Drawing.Point(9, 39);
            this.listBoxStationFile.Name = "listBoxStationFile";
            this.listBoxStationFile.Size = new System.Drawing.Size(110, 100);
            this.listBoxStationFile.TabIndex = 6;
            // 
            // buttonReturnBoxStationFile
            // 
            this.buttonReturnBoxStationFile.Location = new System.Drawing.Point(125, 87);
            this.buttonReturnBoxStationFile.Name = "buttonReturnBoxStationFile";
            this.buttonReturnBoxStationFile.Size = new System.Drawing.Size(60, 42);
            this.buttonReturnBoxStationFile.TabIndex = 5;
            this.buttonReturnBoxStationFile.Text = "<<";
            this.buttonReturnBoxStationFile.UseVisualStyleBackColor = true;
            this.buttonReturnBoxStationFile.Click += new System.EventHandler(this.buttonReturnBoxStationFile_Click);
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
            // buttonPassBoxStationFile
            // 
            this.buttonPassBoxStationFile.Location = new System.Drawing.Point(125, 39);
            this.buttonPassBoxStationFile.Name = "buttonPassBoxStationFile";
            this.buttonPassBoxStationFile.Size = new System.Drawing.Size(60, 42);
            this.buttonPassBoxStationFile.TabIndex = 4;
            this.buttonPassBoxStationFile.Text = ">>";
            this.buttonPassBoxStationFile.UseVisualStyleBackColor = true;
            this.buttonPassBoxStationFile.Click += new System.EventHandler(this.buttonPassBoxStationFile_Click);
            // 
            // groupBoxProduct
            // 
            this.groupBoxProduct.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxProduct.Controls.Add(this.listBoxProductInclude);
            this.groupBoxProduct.Controls.Add(this.listBoxProductNameFile);
            this.groupBoxProduct.Controls.Add(this.buttonReturnProductNameFile);
            this.groupBoxProduct.Controls.Add(this.buttonPassProductNameFile);
            this.groupBoxProduct.Controls.Add(this.labelProductName);
            this.groupBoxProduct.Location = new System.Drawing.Point(8, 4);
            this.groupBoxProduct.Name = "groupBoxProduct";
            this.groupBoxProduct.Size = new System.Drawing.Size(313, 155);
            this.groupBoxProduct.TabIndex = 15;
            this.groupBoxProduct.TabStop = false;
            this.groupBoxProduct.Text = "Product";
            // 
            // listBoxProductInclude
            // 
            this.listBoxProductInclude.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxProductInclude.FormattingEnabled = true;
            this.listBoxProductInclude.ItemHeight = 16;
            this.listBoxProductInclude.Location = new System.Drawing.Point(191, 39);
            this.listBoxProductInclude.Name = "listBoxProductInclude";
            this.listBoxProductInclude.Size = new System.Drawing.Size(110, 100);
            this.listBoxProductInclude.TabIndex = 5;
            // 
            // listBoxProductNameFile
            // 
            this.listBoxProductNameFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxProductNameFile.FormattingEnabled = true;
            this.listBoxProductNameFile.ItemHeight = 16;
            this.listBoxProductNameFile.Location = new System.Drawing.Point(9, 39);
            this.listBoxProductNameFile.Name = "listBoxProductNameFile";
            this.listBoxProductNameFile.Size = new System.Drawing.Size(110, 100);
            this.listBoxProductNameFile.TabIndex = 4;
            // 
            // buttonReturnProductNameFile
            // 
            this.buttonReturnProductNameFile.Location = new System.Drawing.Point(125, 87);
            this.buttonReturnProductNameFile.Name = "buttonReturnProductNameFile";
            this.buttonReturnProductNameFile.Size = new System.Drawing.Size(60, 42);
            this.buttonReturnProductNameFile.TabIndex = 3;
            this.buttonReturnProductNameFile.Text = "<<";
            this.buttonReturnProductNameFile.UseVisualStyleBackColor = true;
            this.buttonReturnProductNameFile.Click += new System.EventHandler(this.buttonReturnProductNameFile_Click);
            // 
            // buttonPassProductNameFile
            // 
            this.buttonPassProductNameFile.Location = new System.Drawing.Point(125, 39);
            this.buttonPassProductNameFile.Name = "buttonPassProductNameFile";
            this.buttonPassProductNameFile.Size = new System.Drawing.Size(60, 42);
            this.buttonPassProductNameFile.TabIndex = 2;
            this.buttonPassProductNameFile.Text = ">>";
            this.buttonPassProductNameFile.UseVisualStyleBackColor = true;
            this.buttonPassProductNameFile.Click += new System.EventHandler(this.buttonPassProductNameFile_Click);
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
            // buttonAddPath
            // 
            this.buttonAddPath.Location = new System.Drawing.Point(915, 227);
            this.buttonAddPath.Name = "buttonAddPath";
            this.buttonAddPath.Size = new System.Drawing.Size(50, 50);
            this.buttonAddPath.TabIndex = 11;
            this.buttonAddPath.Text = "Add";
            this.buttonAddPath.UseVisualStyleBackColor = true;
            this.buttonAddPath.Click += new System.EventHandler(this.buttonAddPath_Click);
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
            this.groupBoxLicenseNumber.ResumeLayout(false);
            this.groupBoxLicenseNumber.PerformLayout();
            this.groupBoxType.ResumeLayout(false);
            this.groupBoxType.PerformLayout();
            this.groupBoxUserLicense.ResumeLayout(false);
            this.groupBoxUserLicense.PerformLayout();
            this.groupBoxLicenseType.ResumeLayout(false);
            this.groupBoxLicenseType.PerformLayout();
            this.groupBoxStation.ResumeLayout(false);
            this.groupBoxStation.PerformLayout();
            this.groupBoxProduct.ResumeLayout(false);
            this.groupBoxProduct.PerformLayout();
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
        private System.Windows.Forms.Label labelUser;
        private System.Windows.Forms.GroupBox groupBoxLicenseNumber;
        private System.Windows.Forms.GroupBox groupBoxType;
        private System.Windows.Forms.GroupBox groupBoxUserLicense;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBoxLicenseType;
        private System.Windows.Forms.GroupBox groupBoxStation;
        private System.Windows.Forms.GroupBox groupBoxProduct;
        private System.Windows.Forms.Button buttonReturnLicenseNumberFile;
        private System.Windows.Forms.Button buttonPassLicenseNumberFile;
        private System.Windows.Forms.Button buttonReturnItemTypeFile;
        private System.Windows.Forms.Button buttonPassItemTypeFile;
        private System.Windows.Forms.Button buttonReturnUserFile;
        private System.Windows.Forms.Button buttonPassUserFile;
        private System.Windows.Forms.Button buttonReturnLicenseTypeFile;
        private System.Windows.Forms.Button buttonPassLicenseTypeFile;
        private System.Windows.Forms.Button buttonReturnBoxStationFile;
        private System.Windows.Forms.Button buttonPassBoxStationFile;
        private System.Windows.Forms.Button buttonReturnProductNameFile;
        private System.Windows.Forms.Button buttonPassProductNameFile;
        public System.Windows.Forms.ListBox listBoxProductNameFile;
        public System.Windows.Forms.ListBox listBoxLicenseNumberInclude;
        public System.Windows.Forms.ListBox listBoxLicenseNumberFile;
        public System.Windows.Forms.ListBox listBoxItemTipeInclude;
        public System.Windows.Forms.ListBox listBoxItemTypeFile;
        public System.Windows.Forms.ListBox listBoxUserInclude;
        public System.Windows.Forms.ListBox listBoxUserFile;
        public System.Windows.Forms.ListBox listBoxLicenseTypeInclude;
        public System.Windows.Forms.ListBox listBoxLicenseTypeFile;
        public System.Windows.Forms.ListBox listBoxStationInclude;
        public System.Windows.Forms.ListBox listBoxStationFile;
        public System.Windows.Forms.ListBox listBoxProductInclude;
    }
}

