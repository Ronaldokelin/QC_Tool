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
            this.groupBoxSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCheckTools)).BeginInit();
            this.groupBoxTools.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFlexLogo)).BeginInit();
            this.tabControlMain.SuspendLayout();
            this.tabPageOperator.SuspendLayout();
            this.tabPageEngineer.SuspendLayout();
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
            this.tabPageEngineer.Controls.Add(this.textBoxUser);
            this.tabPageEngineer.Controls.Add(this.labelUser);
            this.tabPageEngineer.Controls.Add(this.comboBoxBenchName);
            this.tabPageEngineer.Controls.Add(this.buttonAddPath);
            this.tabPageEngineer.Controls.Add(this.comboBoxItemType);
            this.tabPageEngineer.Controls.Add(this.textBoxItemPath);
            this.tabPageEngineer.Controls.Add(this.labelItemPath);
            this.tabPageEngineer.Controls.Add(this.labelItemType);
            this.tabPageEngineer.Controls.Add(this.textBoxItemName);
            this.tabPageEngineer.Controls.Add(this.labelItemName);
            this.tabPageEngineer.Controls.Add(this.labelBenchName);
            this.tabPageEngineer.Controls.Add(this.textBoxProductName);
            this.tabPageEngineer.Controls.Add(this.labelProductName);
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
            this.comboBoxBenchName.Location = new System.Drawing.Point(56, 137);
            this.comboBoxBenchName.Name = "comboBoxBenchName";
            this.comboBoxBenchName.Size = new System.Drawing.Size(121, 26);
            this.comboBoxBenchName.TabIndex = 12;
            this.comboBoxBenchName.Text = "5GFR1BDTST";
            // 
            // buttonAddPath
            // 
            this.buttonAddPath.Location = new System.Drawing.Point(102, 443);
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
            this.comboBoxItemType.Location = new System.Drawing.Point(56, 325);
            this.comboBoxItemType.Name = "comboBoxItemType";
            this.comboBoxItemType.Size = new System.Drawing.Size(121, 26);
            this.comboBoxItemType.TabIndex = 10;
            this.comboBoxItemType.Text = "Tool";
            // 
            // textBoxItemPath
            // 
            this.textBoxItemPath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxItemPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxItemPath.Location = new System.Drawing.Point(56, 385);
            this.textBoxItemPath.Name = "textBoxItemPath";
            this.textBoxItemPath.Size = new System.Drawing.Size(121, 24);
            this.textBoxItemPath.TabIndex = 9;
            this.textBoxItemPath.Text = "dasdasdas";
            // 
            // labelItemPath
            // 
            this.labelItemPath.AutoSize = true;
            this.labelItemPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelItemPath.Location = new System.Drawing.Point(53, 366);
            this.labelItemPath.Name = "labelItemPath";
            this.labelItemPath.Size = new System.Drawing.Size(109, 16);
            this.labelItemPath.TabIndex = 8;
            this.labelItemPath.Text = "License Number:";
            // 
            // labelItemType
            // 
            this.labelItemType.AutoSize = true;
            this.labelItemType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelItemType.Location = new System.Drawing.Point(53, 306);
            this.labelItemType.Name = "labelItemType";
            this.labelItemType.Size = new System.Drawing.Size(68, 16);
            this.labelItemType.TabIndex = 6;
            this.labelItemType.Text = "ItemType:";
            // 
            // textBoxItemName
            // 
            this.textBoxItemName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxItemName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxItemName.Location = new System.Drawing.Point(56, 207);
            this.textBoxItemName.Name = "textBoxItemName";
            this.textBoxItemName.Size = new System.Drawing.Size(121, 24);
            this.textBoxItemName.TabIndex = 5;
            this.textBoxItemName.Text = "dasdas";
            // 
            // labelItemName
            // 
            this.labelItemName.AutoSize = true;
            this.labelItemName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelItemName.Location = new System.Drawing.Point(53, 188);
            this.labelItemName.Name = "labelItemName";
            this.labelItemName.Size = new System.Drawing.Size(93, 16);
            this.labelItemName.TabIndex = 4;
            this.labelItemName.Text = "License Type:";
            // 
            // labelBenchName
            // 
            this.labelBenchName.AutoSize = true;
            this.labelBenchName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBenchName.Location = new System.Drawing.Point(53, 118);
            this.labelBenchName.Name = "labelBenchName";
            this.labelBenchName.Size = new System.Drawing.Size(52, 16);
            this.labelBenchName.TabIndex = 2;
            this.labelBenchName.Text = "Station:";
            // 
            // textBoxProductName
            // 
            this.textBoxProductName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxProductName.Location = new System.Drawing.Point(56, 72);
            this.textBoxProductName.Name = "textBoxProductName";
            this.textBoxProductName.Size = new System.Drawing.Size(121, 24);
            this.textBoxProductName.TabIndex = 1;
            this.textBoxProductName.Text = "VENUS";
            // 
            // labelProductName
            // 
            this.labelProductName.AutoSize = true;
            this.labelProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProductName.Location = new System.Drawing.Point(53, 53);
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
            this.textBoxUser.Location = new System.Drawing.Point(56, 265);
            this.textBoxUser.Name = "textBoxUser";
            this.textBoxUser.Size = new System.Drawing.Size(121, 24);
            this.textBoxUser.TabIndex = 14;
            // 
            // labelUser
            // 
            this.labelUser.AutoSize = true;
            this.labelUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUser.Location = new System.Drawing.Point(53, 246);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(40, 16);
            this.labelUser.TabIndex = 13;
            this.labelUser.Text = "User:";
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
            this.tabPageEngineer.PerformLayout();
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
    }
}

