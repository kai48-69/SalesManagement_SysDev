namespace SalesManagement_SysDev
{
    partial class F_出荷詳細管理
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.ButtonBack = new System.Windows.Forms.Button();
            this.label = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.TextBoxSuryo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ComboBoxShohinName = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TextBoxSyukkaID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TextBoxSyukkaShosaiID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ButtonTouroku = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.ButtonBack);
            this.panel1.Controls.Add(this.label);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1024, 142);
            this.panel1.TabIndex = 35;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // ButtonBack
            // 
            this.ButtonBack.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.ButtonBack.Location = new System.Drawing.Point(808, 44);
            this.ButtonBack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ButtonBack.Name = "ButtonBack";
            this.ButtonBack.Size = new System.Drawing.Size(165, 58);
            this.ButtonBack.TabIndex = 5;
            this.ButtonBack.Text = "戻る";
            this.ButtonBack.UseVisualStyleBackColor = true;
            this.ButtonBack.Click += new System.EventHandler(this.ButtonBack_Click);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("MS UI Gothic", 30F);
            this.label.Location = new System.Drawing.Point(336, 44);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(322, 50);
            this.label.TabIndex = 4;
            this.label.Text = "出荷詳細登録";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(51, 334);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(923, 351);
            this.dataGridView1.TabIndex = 34;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // TextBoxSuryo
            // 
            this.TextBoxSuryo.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.TextBoxSuryo.Location = new System.Drawing.Point(467, 265);
            this.TextBoxSuryo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TextBoxSuryo.Name = "TextBoxSuryo";
            this.TextBoxSuryo.Size = new System.Drawing.Size(156, 32);
            this.TextBoxSuryo.TabIndex = 33;
            this.TextBoxSuryo.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.label4.Location = new System.Drawing.Point(399, 270);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 25);
            this.label4.TabIndex = 31;
            this.label4.Text = "数量";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // ComboBoxShohinName
            // 
            this.ComboBoxShohinName.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.ComboBoxShohinName.FormattingEnabled = true;
            this.ComboBoxShohinName.Location = new System.Drawing.Point(467, 195);
            this.ComboBoxShohinName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ComboBoxShohinName.Name = "ComboBoxShohinName";
            this.ComboBoxShohinName.Size = new System.Drawing.Size(153, 33);
            this.ComboBoxShohinName.TabIndex = 30;
            this.ComboBoxShohinName.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.label2.Location = new System.Drawing.Point(373, 202);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 25);
            this.label2.TabIndex = 29;
            this.label2.Text = "商品名";
            this.label2.Click += new System.EventHandler(this.label3_Click);
            // 
            // TextBoxSyukkaID
            // 
            this.TextBoxSyukkaID.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.TextBoxSyukkaID.Location = new System.Drawing.Point(191, 265);
            this.TextBoxSyukkaID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TextBoxSyukkaID.Name = "TextBoxSyukkaID";
            this.TextBoxSyukkaID.Size = new System.Drawing.Size(156, 32);
            this.TextBoxSyukkaID.TabIndex = 28;
            this.TextBoxSyukkaID.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.label3.Location = new System.Drawing.Point(101, 268);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 25);
            this.label3.TabIndex = 27;
            this.label3.Text = "出荷ID";
            this.label3.Click += new System.EventHandler(this.label2_Click);
            // 
            // TextBoxSyukkaShosaiID
            // 
            this.TextBoxSyukkaShosaiID.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.TextBoxSyukkaShosaiID.Location = new System.Drawing.Point(191, 198);
            this.TextBoxSyukkaShosaiID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TextBoxSyukkaShosaiID.Name = "TextBoxSyukkaShosaiID";
            this.TextBoxSyukkaShosaiID.Size = new System.Drawing.Size(156, 32);
            this.TextBoxSyukkaShosaiID.TabIndex = 26;
            this.TextBoxSyukkaShosaiID.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.label1.Location = new System.Drawing.Point(51, 202);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 25);
            this.label1.TabIndex = 25;
            this.label1.Text = "出荷詳細ID";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // ButtonTouroku
            // 
            this.ButtonTouroku.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.ButtonTouroku.Location = new System.Drawing.Point(747, 186);
            this.ButtonTouroku.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ButtonTouroku.Name = "ButtonTouroku";
            this.ButtonTouroku.Size = new System.Drawing.Size(204, 119);
            this.ButtonTouroku.TabIndex = 32;
            this.ButtonTouroku.Text = "登録";
            this.ButtonTouroku.UseVisualStyleBackColor = true;
            this.ButtonTouroku.Click += new System.EventHandler(this.ButtonTouroku_Click);
            // 
            // F_出荷詳細管理
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 718);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.TextBoxSuryo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ComboBoxShohinName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TextBoxSyukkaID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TextBoxSyukkaShosaiID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ButtonTouroku);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "F_出荷詳細管理";
            this.Text = "F_出荷詳細管理";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button ButtonBack;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox TextBoxSuryo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox ComboBoxShohinName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TextBoxSyukkaID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TextBoxSyukkaShosaiID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ButtonTouroku;
    }
}