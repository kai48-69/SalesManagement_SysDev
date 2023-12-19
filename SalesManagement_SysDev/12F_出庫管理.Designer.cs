namespace SalesManagement_SysDev
{
    partial class F_出庫管理
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
            this.ButtonBack = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.ButtonReset = new System.Windows.Forms.Button();
            this.ButtonExe = new System.Windows.Forms.Button();
            this.RadioHihyouji = new System.Windows.Forms.RadioButton();
            this.RadioKensaku = new System.Windows.Forms.RadioButton();
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
            this.ComboKokyakuName = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ComboEigyousyoName = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TextboxSyukkoID = new System.Windows.Forms.TextBox();
            this.ButtonKakutei = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.TextboxOrderID = new System.Windows.Forms.TextBox();
            this.RadioKakutei = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // ButtonBack
            // 
            this.ButtonBack.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.ButtonBack.Location = new System.Drawing.Point(1185, 49);
            this.ButtonBack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ButtonBack.Name = "ButtonBack";
            this.ButtonBack.Size = new System.Drawing.Size(165, 58);
            this.ButtonBack.TabIndex = 5;
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
            this.label9.Text = "出庫管理メニュー";
            // 
            // ButtonReset
            // 
            this.ButtonReset.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.ButtonReset.Location = new System.Drawing.Point(479, 173);
            this.ButtonReset.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ButtonReset.Name = "ButtonReset";
            this.ButtonReset.Size = new System.Drawing.Size(165, 44);
            this.ButtonReset.TabIndex = 72;
            this.ButtonReset.Text = "入力リセット";
            this.ButtonReset.UseVisualStyleBackColor = true;
            this.ButtonReset.Click += new System.EventHandler(this.ButtonReset_Click);
            // 
            // ButtonExe
            // 
            this.ButtonExe.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.ButtonExe.Location = new System.Drawing.Point(1185, 161);
            this.ButtonExe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ButtonExe.Name = "ButtonExe";
            this.ButtonExe.Size = new System.Drawing.Size(165, 58);
            this.ButtonExe.TabIndex = 59;
            this.ButtonExe.Text = "実行";
            this.ButtonExe.UseVisualStyleBackColor = true;
            this.ButtonExe.Click += new System.EventHandler(this.ButtonExe_Click);
            // 
            // RadioHihyouji
            // 
            this.RadioHihyouji.AutoSize = true;
            this.RadioHihyouji.Font = new System.Drawing.Font("MS UI Gothic", 18F);
            this.RadioHihyouji.Location = new System.Drawing.Point(173, 178);
            this.RadioHihyouji.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RadioHihyouji.Name = "RadioHihyouji";
            this.RadioHihyouji.Size = new System.Drawing.Size(124, 34);
            this.RadioHihyouji.TabIndex = 71;
            this.RadioHihyouji.Text = "非表示";
            this.RadioHihyouji.UseVisualStyleBackColor = true;
            this.RadioHihyouji.CheckedChanged += new System.EventHandler(this.RadioHihyouji_CheckedChanged);
            // 
            // RadioKensaku
            // 
            this.RadioKensaku.AutoSize = true;
            this.RadioKensaku.Checked = true;
            this.RadioKensaku.Font = new System.Drawing.Font("MS UI Gothic", 18F);
            this.RadioKensaku.Location = new System.Drawing.Point(53, 176);
            this.RadioKensaku.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RadioKensaku.Name = "RadioKensaku";
            this.RadioKensaku.Size = new System.Drawing.Size(94, 34);
            this.RadioKensaku.TabIndex = 70;
            this.RadioKensaku.TabStop = true;
            this.RadioKensaku.Text = "検索";
            this.RadioKensaku.UseVisualStyleBackColor = true;
            this.RadioKensaku.CheckedChanged += new System.EventHandler(this.RadioKensaku_CheckedChanged);
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
            this.panel1.TabIndex = 69;
            // 
            // LblLoginDate
            // 
            this.LblLoginDate.AutoSize = true;
            this.LblLoginDate.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Bold);
            this.LblLoginDate.Location = new System.Drawing.Point(182, 91);
            this.LblLoginDate.Name = "LblLoginDate";
            this.LblLoginDate.Size = new System.Drawing.Size(153, 19);
            this.LblLoginDate.TabIndex = 110;
            this.LblLoginDate.Text = "23/10/30 11:15";
            // 
            // LblSoName
            // 
            this.LblSoName.AutoSize = true;
            this.LblSoName.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Bold);
            this.LblSoName.Location = new System.Drawing.Point(182, 60);
            this.LblSoName.Name = "LblSoName";
            this.LblSoName.Size = new System.Drawing.Size(129, 19);
            this.LblSoName.TabIndex = 109;
            this.LblSoName.Text = "◯◯◯営業所";
            // 
            // LblEmName
            // 
            this.LblEmName.AutoSize = true;
            this.LblEmName.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Bold);
            this.LblEmName.Location = new System.Drawing.Point(182, 28);
            this.LblEmName.Name = "LblEmName";
            this.LblEmName.Size = new System.Drawing.Size(109, 19);
            this.LblEmName.TabIndex = 108;
            this.LblEmName.Text = "江戸川乱歩";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Bold);
            this.label14.Location = new System.Drawing.Point(47, 28);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(130, 19);
            this.label14.TabIndex = 105;
            this.label14.Text = "ログイン社員名";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Bold);
            this.label17.Location = new System.Drawing.Point(67, 91);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(110, 19);
            this.label17.TabIndex = 106;
            this.label17.Text = "ログイン日時";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Bold);
            this.label15.Location = new System.Drawing.Point(107, 60);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(69, 19);
            this.label15.TabIndex = 107;
            this.label15.Text = "営業所";
            // 
            // TextboxHihyouji
            // 
            this.TextboxHihyouji.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.TextboxHihyouji.Location = new System.Drawing.Point(1031, 267);
            this.TextboxHihyouji.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TextboxHihyouji.Name = "TextboxHihyouji";
            this.TextboxHihyouji.Size = new System.Drawing.Size(328, 129);
            this.TextboxHihyouji.TabIndex = 68;
            this.TextboxHihyouji.Text = "";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.label8.Location = new System.Drawing.Point(871, 270);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(137, 25);
            this.label8.TabIndex = 67;
            this.label8.Text = "非表示理由";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(51, 446);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1308, 317);
            this.dataGridView1.TabIndex = 53;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellClick);
            // 
            // ComboKokyakuName
            // 
            this.ComboKokyakuName.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.ComboKokyakuName.FormattingEnabled = true;
            this.ComboKokyakuName.Location = new System.Drawing.Point(569, 362);
            this.ComboKokyakuName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ComboKokyakuName.Name = "ComboKokyakuName";
            this.ComboKokyakuName.Size = new System.Drawing.Size(244, 33);
            this.ComboKokyakuName.TabIndex = 82;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.label4.Location = new System.Drawing.Point(474, 367);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 25);
            this.label4.TabIndex = 81;
            this.label4.Text = "顧客名";
            // 
            // ComboEigyousyoName
            // 
            this.ComboEigyousyoName.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.ComboEigyousyoName.FormattingEnabled = true;
            this.ComboEigyousyoName.Location = new System.Drawing.Point(569, 267);
            this.ComboEigyousyoName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ComboEigyousyoName.Name = "ComboEigyousyoName";
            this.ComboEigyousyoName.Size = new System.Drawing.Size(244, 33);
            this.ComboEigyousyoName.TabIndex = 78;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.label2.Location = new System.Drawing.Point(448, 269);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 25);
            this.label2.TabIndex = 77;
            this.label2.Text = "営業所名";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.label1.Location = new System.Drawing.Point(80, 270);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 25);
            this.label1.TabIndex = 76;
            this.label1.Text = "出庫ID";
            // 
            // TextboxSyukkoID
            // 
            this.TextboxSyukkoID.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.TextboxSyukkoID.Location = new System.Drawing.Point(173, 266);
            this.TextboxSyukkoID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TextboxSyukkoID.Name = "TextboxSyukkoID";
            this.TextboxSyukkoID.Size = new System.Drawing.Size(244, 32);
            this.TextboxSyukkoID.TabIndex = 75;
            // 
            // ButtonKakutei
            // 
            this.ButtonKakutei.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.ButtonKakutei.Location = new System.Drawing.Point(542, 799);
            this.ButtonKakutei.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ButtonKakutei.Name = "ButtonKakutei";
            this.ButtonKakutei.Size = new System.Drawing.Size(324, 61);
            this.ButtonKakutei.TabIndex = 96;
            this.ButtonKakutei.Text = "確定";
            this.ButtonKakutei.UseVisualStyleBackColor = true;
            this.ButtonKakutei.Click += new System.EventHandler(this.ButtonKakutei_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.label3.Location = new System.Drawing.Point(80, 368);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 25);
            this.label3.TabIndex = 98;
            this.label3.Text = "受注ID";
            // 
            // TextboxOrderID
            // 
            this.TextboxOrderID.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.TextboxOrderID.Location = new System.Drawing.Point(173, 364);
            this.TextboxOrderID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TextboxOrderID.Name = "TextboxOrderID";
            this.TextboxOrderID.Size = new System.Drawing.Size(244, 32);
            this.TextboxOrderID.TabIndex = 97;
            // 
            // RadioKakutei
            // 
            this.RadioKakutei.AutoSize = true;
            this.RadioKakutei.Font = new System.Drawing.Font("MS UI Gothic", 18F);
            this.RadioKakutei.Location = new System.Drawing.Point(313, 178);
            this.RadioKakutei.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RadioKakutei.Name = "RadioKakutei";
            this.RadioKakutei.Size = new System.Drawing.Size(94, 34);
            this.RadioKakutei.TabIndex = 99;
            this.RadioKakutei.Text = "確定";
            this.RadioKakutei.UseVisualStyleBackColor = true;
            this.RadioKakutei.CheckedChanged += new System.EventHandler(this.RadioKakutei_CheckedChanged);
            // 
            // F_出庫管理
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1403, 884);
            this.Controls.Add(this.RadioKakutei);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TextboxOrderID);
            this.Controls.Add(this.ButtonKakutei);
            this.Controls.Add(this.ComboKokyakuName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ComboEigyousyoName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TextboxSyukkoID);
            this.Controls.Add(this.ButtonReset);
            this.Controls.Add(this.ButtonExe);
            this.Controls.Add(this.RadioHihyouji);
            this.Controls.Add(this.RadioKensaku);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.TextboxHihyouji);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "F_出庫管理";
            this.Text = "F_出庫";
            this.Load += new System.EventHandler(this.F_出庫管理_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button ButtonBack;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button ButtonReset;
        private System.Windows.Forms.Button ButtonExe;
        private System.Windows.Forms.RadioButton RadioHihyouji;
        private System.Windows.Forms.RadioButton RadioKensaku;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox TextboxHihyouji;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox ComboKokyakuName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox ComboEigyousyoName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TextboxSyukkoID;
        private System.Windows.Forms.Button ButtonKakutei;
        private System.Windows.Forms.Label LblLoginDate;
        private System.Windows.Forms.Label LblSoName;
        private System.Windows.Forms.Label LblEmName;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TextboxOrderID;
        private System.Windows.Forms.RadioButton RadioKakutei;
    }
}