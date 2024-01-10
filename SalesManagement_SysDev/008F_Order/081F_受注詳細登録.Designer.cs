namespace SalesManagement_SysDev
{
    partial class F_受注詳細登録
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
            this.TextboxSuryou = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.ButtonTouroku = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ButtonBack = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TextboxSyohinID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.TextboxSyohinName = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // TextboxSuryou
            // 
            this.TextboxSuryou.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.TextboxSuryou.Location = new System.Drawing.Point(424, 154);
            this.TextboxSuryou.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TextboxSuryou.Name = "TextboxSuryou";
            this.TextboxSuryou.Size = new System.Drawing.Size(188, 32);
            this.TextboxSuryou.TabIndex = 60;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.label10.Location = new System.Drawing.Point(342, 161);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 25);
            this.label10.TabIndex = 57;
            this.label10.Text = "数量";
            // 
            // ButtonTouroku
            // 
            this.ButtonTouroku.Font = new System.Drawing.Font("MS UI Gothic", 22F);
            this.ButtonTouroku.Location = new System.Drawing.Point(648, 154);
            this.ButtonTouroku.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ButtonTouroku.Name = "ButtonTouroku";
            this.ButtonTouroku.Size = new System.Drawing.Size(160, 104);
            this.ButtonTouroku.TabIndex = 45;
            this.ButtonTouroku.Text = "登録";
            this.ButtonTouroku.UseVisualStyleBackColor = true;
            this.ButtonTouroku.Click += new System.EventHandler(this.ButtonTouroku_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.ButtonBack);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Location = new System.Drawing.Point(-131, -28);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(998, 142);
            this.panel1.TabIndex = 52;
            // 
            // ButtonBack
            // 
            this.ButtonBack.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.ButtonBack.Location = new System.Drawing.Point(815, 65);
            this.ButtonBack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ButtonBack.Name = "ButtonBack";
            this.ButtonBack.Size = new System.Drawing.Size(124, 58);
            this.ButtonBack.TabIndex = 62;
            this.ButtonBack.Text = "戻る";
            this.ButtonBack.UseVisualStyleBackColor = true;
            this.ButtonBack.Visible = false;
            this.ButtonBack.Click += new System.EventHandler(this.ButtonBack_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("MS UI Gothic", 30F);
            this.label9.Location = new System.Drawing.Point(396, 65);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(322, 50);
            this.label9.TabIndex = 4;
            this.label9.Text = "受注商品登録";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.label2.Location = new System.Drawing.Point(44, 226);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 25);
            this.label2.TabIndex = 44;
            this.label2.Text = "商品名";
            // 
            // TextboxSyohinID
            // 
            this.TextboxSyohinID.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.TextboxSyohinID.Location = new System.Drawing.Point(149, 158);
            this.TextboxSyohinID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TextboxSyohinID.Name = "TextboxSyohinID";
            this.TextboxSyohinID.Size = new System.Drawing.Size(185, 32);
            this.TextboxSyohinID.TabIndex = 48;
            this.TextboxSyohinID.TextChanged += new System.EventHandler(this.TextboxSyohinID_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.label5.Location = new System.Drawing.Point(47, 165);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 25);
            this.label5.TabIndex = 49;
            this.label5.Text = "商品ID";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(49, 299);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(759, 294);
            this.dataGridView1.TabIndex = 41;
            // 
            // TextboxSyohinName
            // 
            this.TextboxSyohinName.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.TextboxSyohinName.Location = new System.Drawing.Point(149, 226);
            this.TextboxSyohinName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TextboxSyohinName.Name = "TextboxSyohinName";
            this.TextboxSyohinName.ReadOnly = true;
            this.TextboxSyohinName.Size = new System.Drawing.Size(185, 32);
            this.TextboxSyohinName.TabIndex = 61;
            // 
            // F_受注詳細登録
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 648);
            this.Controls.Add(this.TextboxSyohinName);
            this.Controls.Add(this.TextboxSuryou);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.ButtonTouroku);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TextboxSyohinID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "F_受注詳細登録";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox TextboxSuryou;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button ButtonTouroku;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TextboxSyohinID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox TextboxSyohinName;
        private System.Windows.Forms.Button ButtonBack;
    }
}