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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
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
            this.TextBoxSyousaiID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // ButtonReset
            // 
            this.ButtonReset.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.ButtonReset.Location = new System.Drawing.Point(338, 138);
            this.ButtonReset.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ButtonReset.Name = "ButtonReset";
            this.ButtonReset.Size = new System.Drawing.Size(124, 34);
            this.ButtonReset.TabIndex = 50;
            this.ButtonReset.Text = "入力リセット";
            this.ButtonReset.UseVisualStyleBackColor = true;
            this.ButtonReset.Click += new System.EventHandler(this.button4_Click);
            // 
            // ButtonExe
            // 
            this.ButtonExe.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.ButtonExe.Location = new System.Drawing.Point(890, 125);
            this.ButtonExe.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ButtonExe.Name = "ButtonExe";
            this.ButtonExe.Size = new System.Drawing.Size(124, 46);
            this.ButtonExe.TabIndex = 31;
            this.ButtonExe.Text = "実行";
            this.ButtonExe.UseVisualStyleBackColor = true;
            // 
            // RadioHihyouji
            // 
            this.RadioHihyouji.AutoSize = true;
            this.RadioHihyouji.Font = new System.Drawing.Font("MS UI Gothic", 18F);
            this.RadioHihyouji.Location = new System.Drawing.Point(224, 142);
            this.RadioHihyouji.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.RadioHihyouji.Name = "RadioHihyouji";
            this.RadioHihyouji.Size = new System.Drawing.Size(100, 28);
            this.RadioHihyouji.TabIndex = 49;
            this.RadioHihyouji.Text = "非表示";
            this.RadioHihyouji.UseVisualStyleBackColor = true;
            this.RadioHihyouji.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // RadioKensaku
            // 
            this.RadioKensaku.AutoSize = true;
            this.RadioKensaku.Font = new System.Drawing.Font("MS UI Gothic", 18F);
            this.RadioKensaku.Location = new System.Drawing.Point(130, 142);
            this.RadioKensaku.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.RadioKensaku.Name = "RadioKensaku";
            this.RadioKensaku.Size = new System.Drawing.Size(76, 28);
            this.RadioKensaku.TabIndex = 47;
            this.RadioKensaku.Text = "検索";
            this.RadioKensaku.UseVisualStyleBackColor = true;
            // 
            // RadioTouroku
            // 
            this.RadioTouroku.AutoSize = true;
            this.RadioTouroku.Checked = true;
            this.RadioTouroku.Font = new System.Drawing.Font("MS UI Gothic", 18F);
            this.RadioTouroku.Location = new System.Drawing.Point(45, 142);
            this.RadioTouroku.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.RadioTouroku.Name = "RadioTouroku";
            this.RadioTouroku.Size = new System.Drawing.Size(76, 28);
            this.RadioTouroku.TabIndex = 46;
            this.RadioTouroku.TabStop = true;
            this.RadioTouroku.Text = "登録";
            this.RadioTouroku.UseVisualStyleBackColor = true;
            // 
            // ButtonBack
            // 
            this.ButtonBack.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.ButtonBack.Location = new System.Drawing.Point(890, 39);
            this.ButtonBack.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ButtonBack.Name = "ButtonBack";
            this.ButtonBack.Size = new System.Drawing.Size(124, 46);
            this.ButtonBack.TabIndex = 5;
            this.ButtonBack.Text = "戻る";
            this.ButtonBack.UseVisualStyleBackColor = true;
            this.ButtonBack.Click += new System.EventHandler(this.ButtonBack_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("MS UI Gothic", 30F);
            this.label9.Location = new System.Drawing.Point(393, 35);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(294, 40);
            this.label9.TabIndex = 4;
            this.label9.Text = "発注管理メニュー";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.label19);
            this.panel1.Controls.Add(this.label18);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.ButtonBack);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1052, 114);
            this.panel1.TabIndex = 45;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label19.Location = new System.Drawing.Point(143, 78);
            this.label19.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(41, 16);
            this.label19.TabIndex = 12;
            this.label19.Text = "◯◯";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label18.Location = new System.Drawing.Point(143, 53);
            this.label18.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(41, 16);
            this.label18.TabIndex = 11;
            this.label18.Text = "◯◯";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label16.Location = new System.Drawing.Point(143, 27);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(41, 16);
            this.label16.TabIndex = 9;
            this.label16.Text = "◯◯";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label15.Location = new System.Drawing.Point(74, 53);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(58, 16);
            this.label15.TabIndex = 8;
            this.label15.Text = "営業所";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label14.Location = new System.Drawing.Point(46, 78);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(93, 16);
            this.label14.TabIndex = 7;
            this.label14.Text = "ログイン日時";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label13.Location = new System.Drawing.Point(29, 27);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(110, 16);
            this.label13.TabIndex = 6;
            this.label13.Text = "ログイン社員名";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.label8.Location = new System.Drawing.Point(667, 334);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(109, 20);
            this.label8.TabIndex = 43;
            this.label8.Text = "非表示理由";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.label7.Location = new System.Drawing.Point(371, 251);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 20);
            this.label7.TabIndex = 41;
            this.label7.Text = "社員名";
            // 
            // TextboxSyainName
            // 
            this.TextboxSyainName.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.TextboxSyainName.Location = new System.Drawing.Point(446, 250);
            this.TextboxSyainName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TextboxSyainName.Name = "TextboxSyainName";
            this.TextboxSyainName.Size = new System.Drawing.Size(184, 27);
            this.TextboxSyainName.TabIndex = 40;
            // 
            // TextboxHattyuDate
            // 
            this.TextboxHattyuDate.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.TextboxHattyuDate.Location = new System.Drawing.Point(153, 306);
            this.TextboxHattyuDate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TextboxHattyuDate.Name = "TextboxHattyuDate";
            this.TextboxHattyuDate.Size = new System.Drawing.Size(162, 27);
            this.TextboxHattyuDate.TabIndex = 39;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.label6.Location = new System.Drawing.Point(40, 311);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 20);
            this.label6.TabIndex = 38;
            this.label6.Text = "発注年月日";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.label3.Location = new System.Drawing.Point(374, 211);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 20);
            this.label3.TabIndex = 33;
            this.label3.Text = "社員ID";
            // 
            // TextboxSyainID
            // 
            this.TextboxSyainID.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.TextboxSyainID.Location = new System.Drawing.Point(446, 210);
            this.TextboxSyainID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TextboxSyainID.Name = "TextboxSyainID";
            this.TextboxSyainID.Size = new System.Drawing.Size(184, 27);
            this.TextboxSyainID.TabIndex = 30;
            // 
            // TextboxMekarName
            // 
            this.TextboxMekarName.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.TextboxMekarName.FormattingEnabled = true;
            this.TextboxMekarName.Location = new System.Drawing.Point(446, 290);
            this.TextboxMekarName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TextboxMekarName.Name = "TextboxMekarName";
            this.TextboxMekarName.Size = new System.Drawing.Size(185, 28);
            this.TextboxMekarName.TabIndex = 29;
            this.TextboxMekarName.SelectedIndexChanged += new System.EventHandler(this.TextboxMekarName_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.label2.Location = new System.Drawing.Point(355, 294);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 20);
            this.label2.TabIndex = 28;
            this.label2.Text = "メーカー名";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.label1.Location = new System.Drawing.Point(82, 225);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 20);
            this.label1.TabIndex = 27;
            this.label1.Text = "発注ID";
            // 
            // TextBoxHattyuID
            // 
            this.TextBoxHattyuID.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.TextBoxHattyuID.Location = new System.Drawing.Point(151, 222);
            this.TextBoxHattyuID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TextBoxHattyuID.Name = "TextBoxHattyuID";
            this.TextBoxHattyuID.Size = new System.Drawing.Size(164, 27);
            this.TextBoxHattyuID.TabIndex = 26;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(32, 400);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(981, 213);
            this.dataGridView1.TabIndex = 25;
            // 
            // TextBoxSyousaiID
            // 
            this.TextBoxSyousaiID.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.TextBoxSyousaiID.Location = new System.Drawing.Point(151, 262);
            this.TextBoxSyousaiID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TextBoxSyousaiID.Name = "TextBoxSyousaiID";
            this.TextBoxSyousaiID.Size = new System.Drawing.Size(1, 27);
            this.TextBoxSyousaiID.TabIndex = 52;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.label4.Location = new System.Drawing.Point(46, 266);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 20);
            this.label4.TabIndex = 51;
            this.label4.Text = "発注詳細ID";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.textBox1.Location = new System.Drawing.Point(151, 263);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(164, 27);
            this.textBox1.TabIndex = 53;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.textBox2.Location = new System.Drawing.Point(446, 330);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(185, 27);
            this.textBox2.TabIndex = 56;
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.textBox3.Location = new System.Drawing.Point(446, 327);
            this.textBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(1, 27);
            this.textBox3.TabIndex = 55;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.label5.Location = new System.Drawing.Point(358, 334);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 20);
            this.label5.TabIndex = 54;
            this.label5.Text = "メーカーID";
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.textBox4.Location = new System.Drawing.Point(788, 290);
            this.textBox4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(224, 27);
            this.textBox4.TabIndex = 59;
            // 
            // textBox5
            // 
            this.textBox5.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.textBox5.Location = new System.Drawing.Point(497, 331);
            this.textBox5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(1, 27);
            this.textBox5.TabIndex = 58;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.label10.Location = new System.Drawing.Point(727, 294);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 20);
            this.label10.TabIndex = 57;
            this.label10.Text = "数量";
            // 
            // textBox6
            // 
            this.textBox6.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.textBox6.Location = new System.Drawing.Point(788, 211);
            this.textBox6.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(224, 27);
            this.textBox6.TabIndex = 62;
            // 
            // textBox7
            // 
            this.textBox7.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.textBox7.Location = new System.Drawing.Point(756, 210);
            this.textBox7.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(1, 27);
            this.textBox7.TabIndex = 61;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.label11.Location = new System.Drawing.Point(706, 218);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(67, 20);
            this.label11.TabIndex = 60;
            this.label11.Text = "商品ID";
            // 
            // textBox8
            // 
            this.textBox8.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.textBox8.Location = new System.Drawing.Point(788, 250);
            this.textBox8.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(224, 27);
            this.textBox8.TabIndex = 65;
            // 
            // textBox9
            // 
            this.textBox9.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.textBox9.Location = new System.Drawing.Point(756, 250);
            this.textBox9.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(1, 27);
            this.textBox9.TabIndex = 64;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.label12.Location = new System.Drawing.Point(706, 254);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(69, 20);
            this.label12.TabIndex = 63;
            this.label12.Text = "商品名";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.richTextBox1.Location = new System.Drawing.Point(788, 330);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(224, 28);
            this.richTextBox1.TabIndex = 66;
            this.richTextBox1.Text = "";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.button1.Location = new System.Drawing.Point(392, 638);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(243, 49);
            this.button1.TabIndex = 67;
            this.button1.Text = "確定";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // F_発注管理
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1052, 707);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.TextBoxSyousaiID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ButtonReset);
            this.Controls.Add(this.ButtonExe);
            this.Controls.Add(this.RadioHihyouji);
            this.Controls.Add(this.RadioKensaku);
            this.Controls.Add(this.RadioTouroku);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label8);
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
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "F_発注管理";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.F_発注管理_Load);
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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label8;
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
        private System.Windows.Forms.TextBox TextBoxSyousaiID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
    }
}