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
            this.comboBoxProducts = new System.Windows.Forms.ComboBox();
            this.comboBoxEstation = new System.Windows.Forms.ComboBox();
            this.labelProduto = new System.Windows.Forms.Label();
            this.labelEstacao = new System.Windows.Forms.Label();
            this.groupBoxSettings = new System.Windows.Forms.GroupBox();
            this.dataGridViewCheckTools = new System.Windows.Forms.DataGridView();
            this.labelCheckTools = new System.Windows.Forms.Label();
            this.groupBoxTools = new System.Windows.Forms.GroupBox();
            this.labelDeveloper = new System.Windows.Forms.Label();
            this.pictureBoxFlexLogo = new System.Windows.Forms.PictureBox();
            this.textBoxDetails = new System.Windows.Forms.TextBox();
            this.Tool = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabPageOperator = new System.Windows.Forms.TabPage();
            this.tabPageEngineer = new System.Windows.Forms.TabPage();
            this.labelName = new System.Windows.Forms.Label();
            this.groupBoxSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCheckTools)).BeginInit();
            this.groupBoxTools.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFlexLogo)).BeginInit();
            this.tabControlMain.SuspendLayout();
            this.tabPageOperator.SuspendLayout();
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
            // 
            // comboBoxEstation
            // 
            this.comboBoxEstation.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxEstation.BackColor = System.Drawing.Color.White;
            this.comboBoxEstation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxEstation.FormattingEnabled = true;
            this.comboBoxEstation.Location = new System.Drawing.Point(5, 96);
            this.comboBoxEstation.Name = "comboBoxEstation";
            this.comboBoxEstation.Size = new System.Drawing.Size(172, 21);
            this.comboBoxEstation.TabIndex = 1;
            // 
            // labelProduto
            // 
            this.labelProduto.AutoSize = true;
            this.labelProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProduto.Location = new System.Drawing.Point(2, 19);
            this.labelProduto.Name = "labelProduto";
            this.labelProduto.Size = new System.Drawing.Size(69, 20);
            this.labelProduto.TabIndex = 4;
            this.labelProduto.Text = "Produto:";
            // 
            // labelEstacao
            // 
            this.labelEstacao.AutoSize = true;
            this.labelEstacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEstacao.Location = new System.Drawing.Point(2, 76);
            this.labelEstacao.Name = "labelEstacao";
            this.labelEstacao.Size = new System.Drawing.Size(72, 20);
            this.labelEstacao.TabIndex = 5;
            this.labelEstacao.Text = "Estação:";
            // 
            // groupBoxSettings
            // 
            this.groupBoxSettings.AutoSize = true;
            this.groupBoxSettings.Controls.Add(this.labelEstacao);
            this.groupBoxSettings.Controls.Add(this.labelProduto);
            this.groupBoxSettings.Controls.Add(this.comboBoxEstation);
            this.groupBoxSettings.Controls.Add(this.comboBoxProducts);
            this.groupBoxSettings.Location = new System.Drawing.Point(3, 3);
            this.groupBoxSettings.Name = "groupBoxSettings";
            this.groupBoxSettings.Size = new System.Drawing.Size(190, 195);
            this.groupBoxSettings.TabIndex = 6;
            this.groupBoxSettings.TabStop = false;
            this.groupBoxSettings.Text = "Settings:";
            // 
            // dataGridViewCheckTools
            // 
            this.dataGridViewCheckTools.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewCheckTools.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewCheckTools.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCheckTools.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Tool,
            this.Status});
            this.dataGridViewCheckTools.Location = new System.Drawing.Point(5, 39);
            this.dataGridViewCheckTools.Name = "dataGridViewCheckTools";
            this.dataGridViewCheckTools.ReadOnly = true;
            this.dataGridViewCheckTools.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridViewCheckTools.Size = new System.Drawing.Size(562, 153);
            this.dataGridViewCheckTools.TabIndex = 9;
            // 
            // labelCheckTools
            // 
            this.labelCheckTools.AutoSize = true;
            this.labelCheckTools.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.groupBoxTools.Location = new System.Drawing.Point(199, 6);
            this.groupBoxTools.Name = "groupBoxTools";
            this.groupBoxTools.Size = new System.Drawing.Size(573, 198);
            this.groupBoxTools.TabIndex = 10;
            this.groupBoxTools.TabStop = false;
            this.groupBoxTools.Text = "Tools:";
            // 
            // labelDeveloper
            // 
            this.labelDeveloper.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelDeveloper.AutoSize = true;
            this.labelDeveloper.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDeveloper.Location = new System.Drawing.Point(2, 621);
            this.labelDeveloper.Name = "labelDeveloper";
            this.labelDeveloper.Size = new System.Drawing.Size(139, 13);
            this.labelDeveloper.TabIndex = 12;
            this.labelDeveloper.Text = "Developed by Arquimedes T.";
            // 
            // pictureBoxFlexLogo
            // 
            this.pictureBoxFlexLogo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxFlexLogo.Image = global::QC_Tool.Properties.Resources.flex1;
            this.pictureBoxFlexLogo.Location = new System.Drawing.Point(678, 4);
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
            this.textBoxDetails.Location = new System.Drawing.Point(3, 204);
            this.textBoxDetails.Multiline = true;
            this.textBoxDetails.Name = "textBoxDetails";
            this.textBoxDetails.ReadOnly = true;
            this.textBoxDetails.Size = new System.Drawing.Size(766, 340);
            this.textBoxDetails.TabIndex = 13;
            // 
            // Tool
            // 
            this.Tool.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Tool.FillWeight = 400F;
            this.Tool.HeaderText = "Tool";
            this.Tool.Name = "Tool";
            this.Tool.ReadOnly = true;
            // 
            // Status
            // 
            this.Status.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Status.FillWeight = 50F;
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            // 
            // tabControlMain
            // 
            this.tabControlMain.Controls.Add(this.tabPageOperator);
            this.tabControlMain.Controls.Add(this.tabPageEngineer);
            this.tabControlMain.Location = new System.Drawing.Point(5, 42);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(783, 576);
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
            this.tabPageOperator.Size = new System.Drawing.Size(775, 550);
            this.tabPageOperator.TabIndex = 0;
            this.tabPageOperator.Text = "Operator";
            this.tabPageOperator.UseVisualStyleBackColor = true;
            // 
            // tabPageEngineer
            // 
            this.tabPageEngineer.Location = new System.Drawing.Point(4, 22);
            this.tabPageEngineer.Name = "tabPageEngineer";
            this.tabPageEngineer.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageEngineer.Size = new System.Drawing.Size(784, 550);
            this.tabPageEngineer.TabIndex = 1;
            this.tabPageEngineer.Text = "Engineer";
            this.tabPageEngineer.UseVisualStyleBackColor = true;
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
            // FormApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 636);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.pictureBoxFlexLogo);
            this.Controls.Add(this.tabControlMain);
            this.Controls.Add(this.labelDeveloper);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormApp";
            this.Text = "QC Tool";
            this.groupBoxSettings.ResumeLayout(false);
            this.groupBoxSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCheckTools)).EndInit();
            this.groupBoxTools.ResumeLayout(false);
            this.groupBoxTools.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFlexLogo)).EndInit();
            this.tabControlMain.ResumeLayout(false);
            this.tabPageOperator.ResumeLayout(false);
            this.tabPageOperator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxProducts;
        private System.Windows.Forms.ComboBox comboBoxEstation;
        private System.Windows.Forms.Label labelProduto;
        private System.Windows.Forms.Label labelEstacao;
        private System.Windows.Forms.GroupBox groupBoxSettings;
        private System.Windows.Forms.DataGridView dataGridViewCheckTools;
        private System.Windows.Forms.Label labelCheckTools;
        private System.Windows.Forms.GroupBox groupBoxTools;
        private System.Windows.Forms.PictureBox pictureBoxFlexLogo;
        private System.Windows.Forms.Label labelDeveloper;
        private System.Windows.Forms.TextBox textBoxDetails;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tool;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabPageOperator;
        private System.Windows.Forms.TabPage tabPageEngineer;
        private System.Windows.Forms.Label labelName;
    }
}

