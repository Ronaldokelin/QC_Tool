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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.labelQpm3 = new System.Windows.Forms.Label();
            this.textBoxQpm3Check = new System.Windows.Forms.TextBox();
            this.labelProduto = new System.Windows.Forms.Label();
            this.labelEstaçao = new System.Windows.Forms.Label();
            this.groupBoxSettings = new System.Windows.Forms.GroupBox();
            this.labelCheckTools = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Tool = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBoxSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(5, 42);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(164, 21);
            this.comboBox1.TabIndex = 0;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(5, 96);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(164, 21);
            this.comboBox2.TabIndex = 1;
            // 
            // labelQpm3
            // 
            this.labelQpm3.AutoSize = true;
            this.labelQpm3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelQpm3.Location = new System.Drawing.Point(53, 42);
            this.labelQpm3.Name = "labelQpm3";
            this.labelQpm3.Size = new System.Drawing.Size(106, 20);
            this.labelQpm3.TabIndex = 2;
            this.labelQpm3.Text = "QPM 3 Check";
            // 
            // textBoxQpm3Check
            // 
            this.textBoxQpm3Check.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.textBoxQpm3Check.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxQpm3Check.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxQpm3Check.Location = new System.Drawing.Point(165, 44);
            this.textBoxQpm3Check.Name = "textBoxQpm3Check";
            this.textBoxQpm3Check.Size = new System.Drawing.Size(38, 19);
            this.textBoxQpm3Check.TabIndex = 3;
            this.textBoxQpm3Check.Text = "to do";
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
            // labelEstaçao
            // 
            this.labelEstaçao.AutoSize = true;
            this.labelEstaçao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEstaçao.Location = new System.Drawing.Point(2, 76);
            this.labelEstaçao.Name = "labelEstaçao";
            this.labelEstaçao.Size = new System.Drawing.Size(72, 20);
            this.labelEstaçao.TabIndex = 5;
            this.labelEstaçao.Text = "Estação:";
            // 
            // groupBoxSettings
            // 
            this.groupBoxSettings.Controls.Add(this.labelEstaçao);
            this.groupBoxSettings.Controls.Add(this.labelProduto);
            this.groupBoxSettings.Controls.Add(this.comboBox2);
            this.groupBoxSettings.Controls.Add(this.comboBox1);
            this.groupBoxSettings.Location = new System.Drawing.Point(33, 80);
            this.groupBoxSettings.Name = "groupBoxSettings";
            this.groupBoxSettings.Size = new System.Drawing.Size(182, 147);
            this.groupBoxSettings.TabIndex = 6;
            this.groupBoxSettings.TabStop = false;
            this.groupBoxSettings.Text = "Settings:";
            // 
            // labelCheckTools
            // 
            this.labelCheckTools.AutoSize = true;
            this.labelCheckTools.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCheckTools.Location = new System.Drawing.Point(38, 246);
            this.labelCheckTools.Name = "labelCheckTools";
            this.labelCheckTools.Size = new System.Drawing.Size(100, 20);
            this.labelCheckTools.TabIndex = 6;
            this.labelCheckTools.Text = "Check Tools:";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(500, 264);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(100, 96);
            this.richTextBox1.TabIndex = 8;
            this.richTextBox1.Text = "";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Tool,
            this.Status});
            this.dataGridView1.Location = new System.Drawing.Point(66, 302);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 9;
            // 
            // Tool
            // 
            this.Tool.HeaderText = "Tool";
            this.Tool.Name = "Tool";
            // 
            // Status
            // 
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            // 
            // FormApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 559);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.labelCheckTools);
            this.Controls.Add(this.groupBoxSettings);
            this.Controls.Add(this.textBoxQpm3Check);
            this.Controls.Add(this.labelQpm3);
            this.Name = "FormApp";
            this.Text = "QC Tool";
            this.groupBoxSettings.ResumeLayout(false);
            this.groupBoxSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label labelQpm3;
        private System.Windows.Forms.TextBox textBoxQpm3Check;
        private System.Windows.Forms.Label labelProduto;
        private System.Windows.Forms.Label labelEstaçao;
        private System.Windows.Forms.GroupBox groupBoxSettings;
        private System.Windows.Forms.Label labelCheckTools;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tool;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
    }
}

