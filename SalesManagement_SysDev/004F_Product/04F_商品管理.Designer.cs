﻿namespace SalesManagement_SysDev
{
    partial class F_商品管理
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
            this.ComboSyobunrui = new System.Windows.Forms.ComboBox();
            this.ButtonBack = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.TextboxKakaku = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TextboxSyouhinID = new System.Windows.Forms.TextBox();
            this.TextboxSyohinName = new System.Windows.Forms.TextBox();
            this.ButtonReset = new System.Windows.Forms.Button();
            this.ButtonExe = new System.Windows.Forms.Button();
            this.RadioHihyouji = new System.Windows.Forms.RadioButton();
            this.RadioKousin = new System.Windows.Forms.RadioButton();
            this.RadioKensaku = new System.Windows.Forms.RadioButton();
            this.RadioTouroku = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LblLoginDate = new System.Windows.Forms.Label();
            this.LblSoName = new System.Windows.Forms.Label();
            this.LblEmName = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.TextboxHihyouji = new System.Windows.Forms.RichTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ComboMakerName = new System.Windows.Forms.ComboBox();
            this.TextboxKataban = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TextboxColor = new System.Windows.Forms.TextBox();
            this.LblHatubaiDate = new System.Windows.Forms.Label();
            this.HatubaiDate = new System.Windows.Forms.DateTimePicker();
            this.TextboxStock = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // ComboSyobunrui
            // 
            this.ComboSyobunrui.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.ComboSyobunrui.FormattingEnabled = true;
            this.ComboSyobunrui.Location = new System.Drawing.Point(610, 315);
            this.ComboSyobunrui.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ComboSyobunrui.Name = "ComboSyobunrui";
            this.ComboSyobunrui.Size = new System.Drawing.Size(261, 33);
            this.ComboSyobunrui.TabIndex = 6;
            // 
            // ButtonBack
            // 
            this.ButtonBack.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.ButtonBack.Location = new System.Drawing.Point(1194, 36);
            this.ButtonBack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ButtonBack.Name = "ButtonBack";
            this.ButtonBack.Size = new System.Drawing.Size(165, 58);
            this.ButtonBack.TabIndex = 12;
            this.ButtonBack.Text = "戻る";
            this.ButtonBack.UseVisualStyleBackColor = true;
            this.ButtonBack.Click += new System.EventHandler(this.ButtonBack_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("MS UI Gothic", 30F);
            this.label9.Location = new System.Drawing.Point(524, 44);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(368, 50);
            this.label9.TabIndex = 4;
            this.label9.Text = "商品管理メニュー";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.label10.Location = new System.Drawing.Point(120, 411);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 25);
            this.label10.TabIndex = 121;
            this.label10.Text = "価格";
            // 
            // TextboxKakaku
            // 
            this.TextboxKakaku.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.TextboxKakaku.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.TextboxKakaku.Location = new System.Drawing.Point(189, 408);
            this.TextboxKakaku.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TextboxKakaku.MaxLength = 9;
            this.TextboxKakaku.Name = "TextboxKakaku";
            this.TextboxKakaku.Size = new System.Drawing.Size(244, 32);
            this.TextboxKakaku.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.label6.Location = new System.Drawing.Point(70, 368);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 25);
            this.label6.TabIndex = 119;
            this.label6.Text = "メーカー名";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.label5.Location = new System.Drawing.Point(516, 319);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 25);
            this.label5.TabIndex = 118;
            this.label5.Text = "小分類";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.label7.Location = new System.Drawing.Point(94, 319);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 25);
            this.label7.TabIndex = 116;
            this.label7.Text = "商品名";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.label2.Location = new System.Drawing.Point(462, 266);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 25);
            this.label2.TabIndex = 112;
            this.label2.Text = "安全在庫数";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.label1.Location = new System.Drawing.Point(97, 268);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 25);
            this.label1.TabIndex = 111;
            this.label1.Text = "商品ID";
            // 
            // TextboxSyouhinID
            // 
            this.TextboxSyouhinID.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.TextboxSyouhinID.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.TextboxSyouhinID.Location = new System.Drawing.Point(189, 264);
            this.TextboxSyouhinID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TextboxSyouhinID.MaxLength = 5;
            this.TextboxSyouhinID.Name = "TextboxSyouhinID";
            this.TextboxSyouhinID.Size = new System.Drawing.Size(244, 32);
            this.TextboxSyouhinID.TabIndex = 1;
            this.TextboxSyouhinID.Text = "※入力不要です";
            // 
            // TextboxSyohinName
            // 
            this.TextboxSyohinName.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.TextboxSyohinName.Location = new System.Drawing.Point(190, 315);
            this.TextboxSyohinName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TextboxSyohinName.MaxLength = 50;
            this.TextboxSyohinName.Name = "TextboxSyohinName";
            this.TextboxSyohinName.Size = new System.Drawing.Size(243, 32);
            this.TextboxSyohinName.TabIndex = 2;
            // 
            // ButtonReset
            // 
            this.ButtonReset.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.ButtonReset.Location = new System.Drawing.Point(571, 168);
            this.ButtonReset.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ButtonReset.Name = "ButtonReset";
            this.ButtonReset.Size = new System.Drawing.Size(165, 58);
            this.ButtonReset.TabIndex = 109;
            this.ButtonReset.TabStop = false;
            this.ButtonReset.Text = "入力リセット";
            this.ButtonReset.UseVisualStyleBackColor = true;
            this.ButtonReset.Click += new System.EventHandler(this.ButtonReset_Click);
            // 
            // ButtonExe
            // 
            this.ButtonExe.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.ButtonExe.Location = new System.Drawing.Point(1194, 168);
            this.ButtonExe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ButtonExe.Name = "ButtonExe";
            this.ButtonExe.Size = new System.Drawing.Size(165, 58);
            this.ButtonExe.TabIndex = 11;
            this.ButtonExe.Text = "実行";
            this.ButtonExe.UseVisualStyleBackColor = true;
            this.ButtonExe.Click += new System.EventHandler(this.ButtonExe_Click);
            // 
            // RadioHihyouji
            // 
            this.RadioHihyouji.AutoSize = true;
            this.RadioHihyouji.Font = new System.Drawing.Font("MS UI Gothic", 18F);
            this.RadioHihyouji.Location = new System.Drawing.Point(421, 178);
            this.RadioHihyouji.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RadioHihyouji.Name = "RadioHihyouji";
            this.RadioHihyouji.Size = new System.Drawing.Size(124, 34);
            this.RadioHihyouji.TabIndex = 108;
            this.RadioHihyouji.Text = "非表示";
            this.RadioHihyouji.UseVisualStyleBackColor = true;
            this.RadioHihyouji.CheckedChanged += new System.EventHandler(this.RadioHihyouji_CheckedChanged);
            // 
            // RadioKousin
            // 
            this.RadioKousin.AutoSize = true;
            this.RadioKousin.Font = new System.Drawing.Font("MS UI Gothic", 18F);
            this.RadioKousin.Location = new System.Drawing.Point(296, 178);
            this.RadioKousin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RadioKousin.Name = "RadioKousin";
            this.RadioKousin.Size = new System.Drawing.Size(94, 34);
            this.RadioKousin.TabIndex = 107;
            this.RadioKousin.Text = "更新";
            this.RadioKousin.UseVisualStyleBackColor = true;
            this.RadioKousin.CheckedChanged += new System.EventHandler(this.RadioKousin_CheckedChanged);
            // 
            // RadioKensaku
            // 
            this.RadioKensaku.AutoSize = true;
            this.RadioKensaku.Font = new System.Drawing.Font("MS UI Gothic", 18F);
            this.RadioKensaku.Location = new System.Drawing.Point(175, 178);
            this.RadioKensaku.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RadioKensaku.Name = "RadioKensaku";
            this.RadioKensaku.Size = new System.Drawing.Size(94, 34);
            this.RadioKensaku.TabIndex = 106;
            this.RadioKensaku.Text = "検索";
            this.RadioKensaku.UseVisualStyleBackColor = true;
            this.RadioKensaku.CheckedChanged += new System.EventHandler(this.RadioKensaku_CheckedChanged);
            // 
            // RadioTouroku
            // 
            this.RadioTouroku.AutoSize = true;
            this.RadioTouroku.Checked = true;
            this.RadioTouroku.Font = new System.Drawing.Font("MS UI Gothic", 18F);
            this.RadioTouroku.Location = new System.Drawing.Point(60, 178);
            this.RadioTouroku.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RadioTouroku.Name = "RadioTouroku";
            this.RadioTouroku.Size = new System.Drawing.Size(94, 34);
            this.RadioTouroku.TabIndex = 105;
            this.RadioTouroku.TabStop = true;
            this.RadioTouroku.Text = "登録";
            this.RadioTouroku.UseVisualStyleBackColor = true;
            this.RadioTouroku.CheckedChanged += new System.EventHandler(this.RadioTouroku_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.LblLoginDate);
            this.panel1.Controls.Add(this.LblSoName);
            this.panel1.Controls.Add(this.LblEmName);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.label17);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.ButtonBack);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1403, 142);
            this.panel1.TabIndex = 104;
            // 
            // LblLoginDate
            // 
            this.LblLoginDate.AutoSize = true;
            this.LblLoginDate.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Bold);
            this.LblLoginDate.Location = new System.Drawing.Point(187, 99);
            this.LblLoginDate.Name = "LblLoginDate";
            this.LblLoginDate.Size = new System.Drawing.Size(153, 19);
            this.LblLoginDate.TabIndex = 104;
            this.LblLoginDate.Text = "23/10/30 11:15";
            // 
            // LblSoName
            // 
            this.LblSoName.AutoSize = true;
            this.LblSoName.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Bold);
            this.LblSoName.Location = new System.Drawing.Point(187, 68);
            this.LblSoName.Name = "LblSoName";
            this.LblSoName.Size = new System.Drawing.Size(129, 19);
            this.LblSoName.TabIndex = 103;
            this.LblSoName.Text = "◯◯◯営業所";
            // 
            // LblEmName
            // 
            this.LblEmName.AutoSize = true;
            this.LblEmName.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Bold);
            this.LblEmName.Location = new System.Drawing.Point(187, 36);
            this.LblEmName.Name = "LblEmName";
            this.LblEmName.Size = new System.Drawing.Size(109, 19);
            this.LblEmName.TabIndex = 102;
            this.LblEmName.Text = "江戸川乱歩";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Bold);
            this.label14.Location = new System.Drawing.Point(52, 36);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(130, 19);
            this.label14.TabIndex = 99;
            this.label14.Text = "ログイン社員名";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Bold);
            this.label17.Location = new System.Drawing.Point(72, 99);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(110, 19);
            this.label17.TabIndex = 100;
            this.label17.Text = "ログイン日時";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Bold);
            this.label15.Location = new System.Drawing.Point(112, 68);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(69, 19);
            this.label15.TabIndex = 101;
            this.label15.Text = "営業所";
            // 
            // TextboxHihyouji
            // 
            this.TextboxHihyouji.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.TextboxHihyouji.Location = new System.Drawing.Point(1076, 324);
            this.TextboxHihyouji.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TextboxHihyouji.MaxLength = 2000;
            this.TextboxHihyouji.Name = "TextboxHihyouji";
            this.TextboxHihyouji.Size = new System.Drawing.Size(283, 120);
            this.TextboxHihyouji.TabIndex = 10;
            this.TextboxHihyouji.Text = "";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.label8.Location = new System.Drawing.Point(919, 324);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(137, 25);
            this.label8.TabIndex = 102;
            this.label8.Text = "非表示理由";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(56, 498);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1308, 349);
            this.dataGridView1.TabIndex = 100;
            this.dataGridView1.TabStop = false;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellClick);
            // 
            // ComboMakerName
            // 
            this.ComboMakerName.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.ComboMakerName.FormattingEnabled = true;
            this.ComboMakerName.Location = new System.Drawing.Point(188, 362);
            this.ComboMakerName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ComboMakerName.Name = "ComboMakerName";
            this.ComboMakerName.Size = new System.Drawing.Size(245, 33);
            this.ComboMakerName.TabIndex = 3;
            // 
            // TextboxKataban
            // 
            this.TextboxKataban.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.TextboxKataban.Location = new System.Drawing.Point(610, 361);
            this.TextboxKataban.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TextboxKataban.MaxLength = 20;
            this.TextboxKataban.Name = "TextboxKataban";
            this.TextboxKataban.Size = new System.Drawing.Size(261, 32);
            this.TextboxKataban.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.label3.Location = new System.Drawing.Point(540, 365);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 25);
            this.label3.TabIndex = 126;
            this.label3.Text = "型番";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.label4.Location = new System.Drawing.Point(568, 414);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 25);
            this.label4.TabIndex = 128;
            this.label4.Text = "色";
            // 
            // TextboxColor
            // 
            this.TextboxColor.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.TextboxColor.Location = new System.Drawing.Point(610, 409);
            this.TextboxColor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TextboxColor.MaxLength = 20;
            this.TextboxColor.Name = "TextboxColor";
            this.TextboxColor.Size = new System.Drawing.Size(261, 32);
            this.TextboxColor.TabIndex = 8;
            // 
            // LblHatubaiDate
            // 
            this.LblHatubaiDate.AutoSize = true;
            this.LblHatubaiDate.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.LblHatubaiDate.Location = new System.Drawing.Point(972, 271);
            this.LblHatubaiDate.Name = "LblHatubaiDate";
            this.LblHatubaiDate.Size = new System.Drawing.Size(87, 25);
            this.LblHatubaiDate.TabIndex = 129;
            this.LblHatubaiDate.Text = "発売日";
            // 
            // HatubaiDate
            // 
            this.HatubaiDate.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.HatubaiDate.Location = new System.Drawing.Point(1076, 266);
            this.HatubaiDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.HatubaiDate.Name = "HatubaiDate";
            this.HatubaiDate.Size = new System.Drawing.Size(283, 32);
            this.HatubaiDate.TabIndex = 9;
            // 
            // TextboxStock
            // 
            this.TextboxStock.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.TextboxStock.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.TextboxStock.Location = new System.Drawing.Point(610, 264);
            this.TextboxStock.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TextboxStock.MaxLength = 4;
            this.TextboxStock.Name = "TextboxStock";
            this.TextboxStock.Size = new System.Drawing.Size(261, 32);
            this.TextboxStock.TabIndex = 5;
            // 
            // F_商品管理
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1403, 884);
            this.Controls.Add(this.TextboxStock);
            this.Controls.Add(this.HatubaiDate);
            this.Controls.Add(this.LblHatubaiDate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TextboxColor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TextboxKataban);
            this.Controls.Add(this.ComboMakerName);
            this.Controls.Add(this.ComboSyobunrui);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.TextboxKakaku);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TextboxSyouhinID);
            this.Controls.Add(this.TextboxSyohinName);
            this.Controls.Add(this.ButtonReset);
            this.Controls.Add(this.ButtonExe);
            this.Controls.Add(this.RadioHihyouji);
            this.Controls.Add(this.RadioKousin);
            this.Controls.Add(this.RadioKensaku);
            this.Controls.Add(this.RadioTouroku);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.TextboxHihyouji);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "F_商品管理";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.F_商品管理_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox ComboSyobunrui;
        private System.Windows.Forms.Button ButtonBack;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox TextboxKakaku;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TextboxSyouhinID;
        private System.Windows.Forms.TextBox TextboxSyohinName;
        private System.Windows.Forms.Button ButtonReset;
        private System.Windows.Forms.Button ButtonExe;
        private System.Windows.Forms.RadioButton RadioHihyouji;
        private System.Windows.Forms.RadioButton RadioKousin;
        private System.Windows.Forms.RadioButton RadioKensaku;
        private System.Windows.Forms.RadioButton RadioTouroku;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox TextboxHihyouji;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox ComboMakerName;
        private System.Windows.Forms.TextBox TextboxKataban;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TextboxColor;
        private System.Windows.Forms.Label LblHatubaiDate;
        private System.Windows.Forms.DateTimePicker HatubaiDate;
        private System.Windows.Forms.TextBox TextboxStock;
        private System.Windows.Forms.Label LblLoginDate;
        private System.Windows.Forms.Label LblSoName;
        private System.Windows.Forms.Label LblEmName;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label15;
    }
}