﻿namespace SalesManagement_SysDev
{
    partial class F_入庫詳細管理
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
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ButtonTouroku = new System.Windows.Forms.Button();
            this.ComboSuuryou = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TextboxSyouhinName = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TextboxNyuukoID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TextboxSyousaiID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.ButtonBack);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1280, 171);
            this.panel1.TabIndex = 24;
            // 
            // ButtonBack
            // 
            this.ButtonBack.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.ButtonBack.Location = new System.Drawing.Point(1010, 52);
            this.ButtonBack.Name = "ButtonBack";
            this.ButtonBack.Size = new System.Drawing.Size(207, 69);
            this.ButtonBack.TabIndex = 5;
            this.ButtonBack.Text = "戻る";
            this.ButtonBack.UseVisualStyleBackColor = true;
            this.ButtonBack.Click += new System.EventHandler(this.ButtonBack_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("MS UI Gothic", 30F);
            this.label6.Location = new System.Drawing.Point(420, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(385, 60);
            this.label6.TabIndex = 4;
            this.label6.Text = "入庫詳細登録";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(63, 400);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1153, 422);
            this.dataGridView1.TabIndex = 23;
            // 
            // ButtonTouroku
            // 
            this.ButtonTouroku.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.ButtonTouroku.Location = new System.Drawing.Point(933, 224);
            this.ButtonTouroku.Name = "ButtonTouroku";
            this.ButtonTouroku.Size = new System.Drawing.Size(255, 142);
            this.ButtonTouroku.TabIndex = 19;
            this.ButtonTouroku.Text = "登録";
            this.ButtonTouroku.UseVisualStyleBackColor = true;
            this.ButtonTouroku.Click += new System.EventHandler(this.button1_Click);
            // 
            // ComboSuuryou
            // 
            this.ComboSuuryou.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.ComboSuuryou.Location = new System.Drawing.Point(600, 315);
            this.ComboSuuryou.Name = "ComboSuuryou";
            this.ComboSuuryou.Size = new System.Drawing.Size(194, 37);
            this.ComboSuuryou.TabIndex = 29;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.label4.Location = new System.Drawing.Point(515, 321);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 30);
            this.label4.TabIndex = 28;
            this.label4.Text = "数量";
            // 
            // TextboxSyouhinName
            // 
            this.TextboxSyouhinName.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.TextboxSyouhinName.FormattingEnabled = true;
            this.TextboxSyouhinName.Location = new System.Drawing.Point(600, 231);
            this.TextboxSyouhinName.Name = "TextboxSyouhinName";
            this.TextboxSyouhinName.Size = new System.Drawing.Size(191, 38);
            this.TextboxSyouhinName.TabIndex = 27;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.label3.Location = new System.Drawing.Point(483, 240);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 30);
            this.label3.TabIndex = 26;
            this.label3.Text = "商品名";
            // 
            // TextboxNyuukoID
            // 
            this.TextboxNyuukoID.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.TextboxNyuukoID.Location = new System.Drawing.Point(255, 315);
            this.TextboxNyuukoID.Name = "TextboxNyuukoID";
            this.TextboxNyuukoID.Size = new System.Drawing.Size(194, 37);
            this.TextboxNyuukoID.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.label2.Location = new System.Drawing.Point(143, 318);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 30);
            this.label2.TabIndex = 24;
            this.label2.Text = "入庫ID";
            // 
            // TextboxSyousaiID
            // 
            this.TextboxSyousaiID.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.TextboxSyousaiID.Location = new System.Drawing.Point(255, 234);
            this.TextboxSyousaiID.Name = "TextboxSyousaiID";
            this.TextboxSyousaiID.Size = new System.Drawing.Size(194, 37);
            this.TextboxSyousaiID.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.label1.Location = new System.Drawing.Point(80, 240);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 30);
            this.label1.TabIndex = 22;
            this.label1.Text = "入庫詳細ID";
            // 
            // F_入庫詳細管理
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 861);
            this.Controls.Add(this.ComboSuuryou);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.TextboxSyouhinName);
            this.Controls.Add(this.ButtonTouroku);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TextboxNyuukoID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TextboxSyousaiID);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "F_入庫詳細管理";
            this.Text = "入庫詳細管理";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button ButtonBack;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button ButtonTouroku;
        private System.Windows.Forms.TextBox ComboSuuryou;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox TextboxSyouhinName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TextboxNyuukoID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TextboxSyousaiID;
        private System.Windows.Forms.Label label1;
    }
}