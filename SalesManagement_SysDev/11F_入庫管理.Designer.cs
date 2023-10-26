namespace SalesManagement_SysDev
{
    partial class F_入庫管理
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
            this.ButtonSyousai = new System.Windows.Forms.Button();
            this.ButtonKakutei = new System.Windows.Forms.Button();
            this.ButtonBack = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.ButtonReset = new System.Windows.Forms.Button();
            this.ButtonExe = new System.Windows.Forms.Button();
            this.RadioHihyouji = new System.Windows.Forms.RadioButton();
            this.ButtonKensaku = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TextboxHihyouji = new System.Windows.Forms.RichTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.TextboxTantouName = new System.Windows.Forms.TextBox();
            this.Nyukadate = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.TextboxKokyaku = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TextboxSyainID = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.TextboxEigyousyoName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TextNyukoID = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // ButtonSyousai
            // 
            this.ButtonSyousai.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.ButtonSyousai.Location = new System.Drawing.Point(1083, 201);
            this.ButtonSyousai.Name = "ButtonSyousai";
            this.ButtonSyousai.Size = new System.Drawing.Size(207, 69);
            this.ButtonSyousai.TabIndex = 74;
            this.ButtonSyousai.Text = "入庫詳細へ";
            this.ButtonSyousai.UseVisualStyleBackColor = true;
            this.ButtonSyousai.Click += new System.EventHandler(this.ButtonSyousai_Click);
            // 
            // ButtonKakutei
            // 
            this.ButtonKakutei.Font = new System.Drawing.Font("MS UI Gothic", 25F);
            this.ButtonKakutei.Location = new System.Drawing.Point(593, 897);
            this.ButtonKakutei.Name = "ButtonKakutei";
            this.ButtonKakutei.Size = new System.Drawing.Size(420, 76);
            this.ButtonKakutei.TabIndex = 73;
            this.ButtonKakutei.Text = "確定";
            this.ButtonKakutei.UseVisualStyleBackColor = true;
            // 
            // ButtonBack
            // 
            this.ButtonBack.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.ButtonBack.Location = new System.Drawing.Point(1367, 57);
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
            this.label9.Location = new System.Drawing.Point(582, 68);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(440, 60);
            this.label9.TabIndex = 4;
            this.label9.Text = "入庫管理メニュー";
            // 
            // ButtonReset
            // 
            this.ButtonReset.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.ButtonReset.Location = new System.Drawing.Point(423, 208);
            this.ButtonReset.Name = "ButtonReset";
            this.ButtonReset.Size = new System.Drawing.Size(207, 52);
            this.ButtonReset.TabIndex = 72;
            this.ButtonReset.Text = "入力リセット";
            this.ButtonReset.UseVisualStyleBackColor = true;
            // 
            // ButtonExe
            // 
            this.ButtonExe.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.ButtonExe.Location = new System.Drawing.Point(1357, 201);
            this.ButtonExe.Name = "ButtonExe";
            this.ButtonExe.Size = new System.Drawing.Size(207, 69);
            this.ButtonExe.TabIndex = 59;
            this.ButtonExe.Text = "実行";
            this.ButtonExe.UseVisualStyleBackColor = true;
            // 
            // RadioHihyouji
            // 
            this.RadioHihyouji.AutoSize = true;
            this.RadioHihyouji.Font = new System.Drawing.Font("MS UI Gothic", 18F);
            this.RadioHihyouji.Location = new System.Drawing.Point(223, 213);
            this.RadioHihyouji.Name = "RadioHihyouji";
            this.RadioHihyouji.Size = new System.Drawing.Size(148, 40);
            this.RadioHihyouji.TabIndex = 71;
            this.RadioHihyouji.Text = "非表示";
            this.RadioHihyouji.UseVisualStyleBackColor = true;
            // 
            // ButtonKensaku
            // 
            this.ButtonKensaku.AutoSize = true;
            this.ButtonKensaku.Font = new System.Drawing.Font("MS UI Gothic", 18F);
            this.ButtonKensaku.Location = new System.Drawing.Point(85, 213);
            this.ButtonKensaku.Name = "ButtonKensaku";
            this.ButtonKensaku.Size = new System.Drawing.Size(112, 40);
            this.ButtonKensaku.TabIndex = 70;
            this.ButtonKensaku.Text = "検索";
            this.ButtonKensaku.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.ButtonBack);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1647, 171);
            this.panel1.TabIndex = 69;
            // 
            // TextboxHihyouji
            // 
            this.TextboxHihyouji.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.TextboxHihyouji.Location = new System.Drawing.Point(1208, 321);
            this.TextboxHihyouji.Name = "TextboxHihyouji";
            this.TextboxHihyouji.Size = new System.Drawing.Size(352, 193);
            this.TextboxHihyouji.TabIndex = 68;
            this.TextboxHihyouji.Text = "";
            this.TextboxHihyouji.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.label8.Location = new System.Drawing.Point(1025, 326);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(163, 30);
            this.label8.TabIndex = 67;
            this.label8.Text = "非表示理由";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.label7.Location = new System.Drawing.Point(525, 483);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(193, 30);
            this.label7.TabIndex = 66;
            this.label7.Text = "社員担当者名";
            // 
            // TextboxTantouName
            // 
            this.TextboxTantouName.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.TextboxTantouName.Location = new System.Drawing.Point(743, 477);
            this.TextboxTantouName.Name = "TextboxTantouName";
            this.TextboxTantouName.Size = new System.Drawing.Size(249, 37);
            this.TextboxTantouName.TabIndex = 65;
            // 
            // Nyukadate
            // 
            this.Nyukadate.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.Nyukadate.Location = new System.Drawing.Point(223, 474);
            this.Nyukadate.Name = "Nyukadate";
            this.Nyukadate.Size = new System.Drawing.Size(281, 37);
            this.Nyukadate.TabIndex = 64;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.label6.Location = new System.Drawing.Point(38, 480);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(163, 30);
            this.label6.TabIndex = 63;
            this.label6.Text = "入荷年月日";
            // 
            // TextboxKokyaku
            // 
            this.TextboxKokyaku.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.TextboxKokyaku.FormattingEnabled = true;
            this.TextboxKokyaku.Location = new System.Drawing.Point(743, 318);
            this.TextboxKokyaku.Name = "TextboxKokyaku";
            this.TextboxKokyaku.Size = new System.Drawing.Size(249, 38);
            this.TextboxKokyaku.TabIndex = 62;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.label4.Location = new System.Drawing.Point(625, 324);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 30);
            this.label4.TabIndex = 61;
            this.label4.Text = "顧客名";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.label3.Location = new System.Drawing.Point(628, 402);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 30);
            this.label3.TabIndex = 60;
            this.label3.Text = "社員ID";
            // 
            // TextboxSyainID
            // 
            this.TextboxSyainID.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.TextboxSyainID.Location = new System.Drawing.Point(743, 396);
            this.TextboxSyainID.Name = "TextboxSyainID";
            this.TextboxSyainID.Size = new System.Drawing.Size(249, 37);
            this.TextboxSyainID.TabIndex = 58;
            this.TextboxSyainID.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(227, 400);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(277, 38);
            this.comboBox1.TabIndex = 57;
            // 
            // TextboxEigyousyoName
            // 
            this.TextboxEigyousyoName.AutoSize = true;
            this.TextboxEigyousyoName.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.TextboxEigyousyoName.Location = new System.Drawing.Point(75, 406);
            this.TextboxEigyousyoName.Name = "TextboxEigyousyoName";
            this.TextboxEigyousyoName.Size = new System.Drawing.Size(133, 30);
            this.TextboxEigyousyoName.TabIndex = 56;
            this.TextboxEigyousyoName.Text = "営業所名";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.label1.Location = new System.Drawing.Point(112, 326);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 30);
            this.label1.TabIndex = 55;
            this.label1.Text = "入庫ID";
            // 
            // TextNyukoID
            // 
            this.TextNyukoID.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.TextNyukoID.Location = new System.Drawing.Point(227, 321);
            this.TextNyukoID.Name = "TextNyukoID";
            this.TextNyukoID.Size = new System.Drawing.Size(277, 37);
            this.TextNyukoID.TabIndex = 54;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(53, 555);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1510, 300);
            this.dataGridView1.TabIndex = 53;
            // 
            // F_入庫管理
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1647, 1020);
            this.Controls.Add(this.ButtonSyousai);
            this.Controls.Add(this.ButtonKakutei);
            this.Controls.Add(this.ButtonReset);
            this.Controls.Add(this.ButtonExe);
            this.Controls.Add(this.RadioHihyouji);
            this.Controls.Add(this.ButtonKensaku);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.TextboxHihyouji);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TextboxTantouName);
            this.Controls.Add(this.Nyukadate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TextboxKokyaku);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TextboxSyainID);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.TextboxEigyousyoName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TextNyukoID);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "F_入庫管理";
            this.Text = "F_入庫管理";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonSyousai;
        private System.Windows.Forms.Button ButtonKakutei;
        private System.Windows.Forms.Button ButtonBack;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button ButtonReset;
        private System.Windows.Forms.Button ButtonExe;
        private System.Windows.Forms.RadioButton RadioHihyouji;
        private System.Windows.Forms.RadioButton ButtonKensaku;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox TextboxHihyouji;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TextboxTantouName;
        private System.Windows.Forms.DateTimePicker Nyukadate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox TextboxKokyaku;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TextboxSyainID;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label TextboxEigyousyoName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TextNyukoID;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}