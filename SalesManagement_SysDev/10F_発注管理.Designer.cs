﻿namespace SalesManagement_SysDev
{
    partial class F_発注管理
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
            this.ButtonReset = new System.Windows.Forms.Button();
            this.ButtonExe = new System.Windows.Forms.Button();
            this.RadioHihyouji = new System.Windows.Forms.RadioButton();
            this.RadioKensaku = new System.Windows.Forms.RadioButton();
            this.RadioTouroku = new System.Windows.Forms.RadioButton();
            this.ButtonBack = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.ButtonSyousai = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TextboxHihyouji = new System.Windows.Forms.RichTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.ButtonKakutei = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.TextboxSyainName = new System.Windows.Forms.TextBox();
            this.TextboxHattyuDate = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TextboxSyainID = new System.Windows.Forms.TextBox();
            this.TextboxMekarName = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TextBoxHattyuID = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // ButtonReset
            // 
            this.ButtonReset.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.ButtonReset.Location = new System.Drawing.Point(563, 208);
            this.ButtonReset.Name = "ButtonReset";
            this.ButtonReset.Size = new System.Drawing.Size(207, 52);
            this.ButtonReset.TabIndex = 50;
            this.ButtonReset.Text = "入力リセット";
            this.ButtonReset.UseVisualStyleBackColor = true;
            this.ButtonReset.Click += new System.EventHandler(this.button4_Click);
            // 
            // ButtonExe
            // 
            this.ButtonExe.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.ButtonExe.Location = new System.Drawing.Point(1367, 201);
            this.ButtonExe.Name = "ButtonExe";
            this.ButtonExe.Size = new System.Drawing.Size(207, 69);
            this.ButtonExe.TabIndex = 31;
            this.ButtonExe.Text = "実行";
            this.ButtonExe.UseVisualStyleBackColor = true;
            // 
            // RadioHihyouji
            // 
            this.RadioHihyouji.AutoSize = true;
            this.RadioHihyouji.Font = new System.Drawing.Font("MS UI Gothic", 18F);
            this.RadioHihyouji.Location = new System.Drawing.Point(373, 213);
            this.RadioHihyouji.Name = "RadioHihyouji";
            this.RadioHihyouji.Size = new System.Drawing.Size(148, 40);
            this.RadioHihyouji.TabIndex = 49;
            this.RadioHihyouji.Text = "非表示";
            this.RadioHihyouji.UseVisualStyleBackColor = true;
            this.RadioHihyouji.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // RadioKensaku
            // 
            this.RadioKensaku.AutoSize = true;
            this.RadioKensaku.Font = new System.Drawing.Font("MS UI Gothic", 18F);
            this.RadioKensaku.Location = new System.Drawing.Point(218, 213);
            this.RadioKensaku.Name = "RadioKensaku";
            this.RadioKensaku.Size = new System.Drawing.Size(112, 40);
            this.RadioKensaku.TabIndex = 47;
            this.RadioKensaku.Text = "検索";
            this.RadioKensaku.UseVisualStyleBackColor = true;
            // 
            // RadioTouroku
            // 
            this.RadioTouroku.AutoSize = true;
            this.RadioTouroku.Checked = true;
            this.RadioTouroku.Font = new System.Drawing.Font("MS UI Gothic", 18F);
            this.RadioTouroku.Location = new System.Drawing.Point(75, 213);
            this.RadioTouroku.Name = "RadioTouroku";
            this.RadioTouroku.Size = new System.Drawing.Size(112, 40);
            this.RadioTouroku.TabIndex = 46;
            this.RadioTouroku.TabStop = true;
            this.RadioTouroku.Text = "登録";
            this.RadioTouroku.UseVisualStyleBackColor = true;
            // 
            // ButtonBack
            // 
            this.ButtonBack.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.ButtonBack.Location = new System.Drawing.Point(1367, 44);
            this.ButtonBack.Name = "ButtonBack";
            this.ButtonBack.Size = new System.Drawing.Size(207, 69);
            this.ButtonBack.TabIndex = 5;
            this.ButtonBack.Text = "戻る";
            this.ButtonBack.UseVisualStyleBackColor = true;
            this.ButtonBack.Click += new System.EventHandler(this.ButtonBack_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("MS UI Gothic", 30F);
            this.label9.Location = new System.Drawing.Point(582, 52);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(440, 60);
            this.label9.TabIndex = 4;
            this.label9.Text = "発注管理メニュー";
            // 
            // ButtonSyousai
            // 
            this.ButtonSyousai.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.ButtonSyousai.Location = new System.Drawing.Point(1108, 201);
            this.ButtonSyousai.Name = "ButtonSyousai";
            this.ButtonSyousai.Size = new System.Drawing.Size(207, 69);
            this.ButtonSyousai.TabIndex = 32;
            this.ButtonSyousai.Text = "発注詳細へ";
            this.ButtonSyousai.UseVisualStyleBackColor = true;
            this.ButtonSyousai.Click += new System.EventHandler(this.ButtonSyousai_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.ButtonBack);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1647, 171);
            this.panel1.TabIndex = 45;
            // 
            // TextboxHihyouji
            // 
            this.TextboxHihyouji.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.TextboxHihyouji.Location = new System.Drawing.Point(1220, 321);
            this.TextboxHihyouji.Name = "TextboxHihyouji";
            this.TextboxHihyouji.Size = new System.Drawing.Size(352, 193);
            this.TextboxHihyouji.TabIndex = 44;
            this.TextboxHihyouji.Text = "";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.label8.Location = new System.Drawing.Point(1042, 326);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(163, 30);
            this.label8.TabIndex = 43;
            this.label8.Text = "非表示理由";
            // 
            // ButtonKakutei
            // 
            this.ButtonKakutei.Font = new System.Drawing.Font("MS UI Gothic", 25F);
            this.ButtonKakutei.Location = new System.Drawing.Point(648, 915);
            this.ButtonKakutei.Name = "ButtonKakutei";
            this.ButtonKakutei.Size = new System.Drawing.Size(420, 76);
            this.ButtonKakutei.TabIndex = 42;
            this.ButtonKakutei.Text = "確定";
            this.ButtonKakutei.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.label7.Location = new System.Drawing.Point(537, 410);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(193, 30);
            this.label7.TabIndex = 41;
            this.label7.Text = "社員担当者名";
            // 
            // TextboxSyainName
            // 
            this.TextboxSyainName.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.TextboxSyainName.Location = new System.Drawing.Point(755, 405);
            this.TextboxSyainName.Name = "TextboxSyainName";
            this.TextboxSyainName.Size = new System.Drawing.Size(249, 37);
            this.TextboxSyainName.TabIndex = 40;
            // 
            // TextboxHattyuDate
            // 
            this.TextboxHattyuDate.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.TextboxHattyuDate.Location = new System.Drawing.Point(237, 462);
            this.TextboxHattyuDate.Name = "TextboxHattyuDate";
            this.TextboxHattyuDate.Size = new System.Drawing.Size(271, 37);
            this.TextboxHattyuDate.TabIndex = 39;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.label6.Location = new System.Drawing.Point(52, 466);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(163, 30);
            this.label6.TabIndex = 38;
            this.label6.Text = "発注年月日";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.label3.Location = new System.Drawing.Point(640, 332);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 30);
            this.label3.TabIndex = 33;
            this.label3.Text = "社員ID";
            // 
            // TextboxSyainID
            // 
            this.TextboxSyainID.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.TextboxSyainID.Location = new System.Drawing.Point(755, 327);
            this.TextboxSyainID.Name = "TextboxSyainID";
            this.TextboxSyainID.Size = new System.Drawing.Size(249, 37);
            this.TextboxSyainID.TabIndex = 30;
            // 
            // TextboxMekarName
            // 
            this.TextboxMekarName.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.TextboxMekarName.FormattingEnabled = true;
            this.TextboxMekarName.Location = new System.Drawing.Point(237, 400);
            this.TextboxMekarName.Name = "TextboxMekarName";
            this.TextboxMekarName.Size = new System.Drawing.Size(271, 38);
            this.TextboxMekarName.TabIndex = 29;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.label2.Location = new System.Drawing.Point(85, 406);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 30);
            this.label2.TabIndex = 28;
            this.label2.Text = "メーカー名";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.label1.Location = new System.Drawing.Point(122, 340);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 30);
            this.label1.TabIndex = 27;
            this.label1.Text = "発注ID";
            // 
            // TextBoxHattyuID
            // 
            this.TextBoxHattyuID.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.TextBoxHattyuID.Location = new System.Drawing.Point(237, 336);
            this.TextBoxHattyuID.Name = "TextBoxHattyuID";
            this.TextBoxHattyuID.Size = new System.Drawing.Size(271, 37);
            this.TextBoxHattyuID.TabIndex = 26;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(63, 543);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1510, 342);
            this.dataGridView1.TabIndex = 25;
            // 
            // F_発注管理
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1647, 1020);
            this.Controls.Add(this.ButtonReset);
            this.Controls.Add(this.ButtonExe);
            this.Controls.Add(this.RadioHihyouji);
            this.Controls.Add(this.RadioKensaku);
            this.Controls.Add(this.RadioTouroku);
            this.Controls.Add(this.ButtonSyousai);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.TextboxHihyouji);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.ButtonKakutei);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TextboxSyainName);
            this.Controls.Add(this.TextboxHattyuDate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TextboxSyainID);
            this.Controls.Add(this.TextboxMekarName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TextBoxHattyuID);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "F_発注管理";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonReset;
        private System.Windows.Forms.Button ButtonExe;
        private System.Windows.Forms.RadioButton RadioHihyouji;
        private System.Windows.Forms.RadioButton RadioKensaku;
        private System.Windows.Forms.RadioButton RadioTouroku;
        private System.Windows.Forms.Button ButtonBack;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button ButtonSyousai;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox TextboxHihyouji;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button ButtonKakutei;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TextboxSyainName;
        private System.Windows.Forms.DateTimePicker TextboxHattyuDate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TextboxSyainID;
        private System.Windows.Forms.ComboBox TextboxMekarName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TextBoxHattyuID;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}