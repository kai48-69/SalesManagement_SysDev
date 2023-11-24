namespace SalesManagement_SysDev
{
    partial class F_入荷管理
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
            this.ButtonJikou = new System.Windows.Forms.Button();
            this.RadioHihyouji = new System.Windows.Forms.RadioButton();
            this.RadioKensaku = new System.Windows.Forms.RadioButton();
            this.ButtonBack = new System.Windows.Forms.Button();
            this.LabelTitle = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.TextBoxHidden = new System.Windows.Forms.RichTextBox();
            this.LabelHidden = new System.Windows.Forms.Label();
            this.LabelTanntouName = new System.Windows.Forms.Label();
            this.TextBoxTanntouName = new System.Windows.Forms.TextBox();
            this.NyukaDate = new System.Windows.Forms.DateTimePicker();
            this.LabelArrivaDate = new System.Windows.Forms.Label();
            this.ComboBoxKokyakumei = new System.Windows.Forms.ComboBox();
            this.LabelKokyakumei = new System.Windows.Forms.Label();
            this.LabelSyainnID = new System.Windows.Forms.Label();
            this.TextBoxSyainnID = new System.Windows.Forms.TextBox();
            this.ComboBoxEigyousyomei = new System.Windows.Forms.ComboBox();
            this.LabelEigyoushomei = new System.Windows.Forms.Label();
            this.LabelNyuukaID = new System.Windows.Forms.Label();
            this.TextBoxNyuukaID = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // ButtonReset
            // 
            this.ButtonReset.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.ButtonReset.Location = new System.Drawing.Point(233, 129);
            this.ButtonReset.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ButtonReset.Name = "ButtonReset";
            this.ButtonReset.Size = new System.Drawing.Size(124, 46);
            this.ButtonReset.TabIndex = 50;
            this.ButtonReset.Text = "入力リセット";
            this.ButtonReset.UseVisualStyleBackColor = true;
            this.ButtonReset.Click += new System.EventHandler(this.ButtonReset_Click);
            // 
            // ButtonJikou
            // 
            this.ButtonJikou.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.ButtonJikou.Location = new System.Drawing.Point(890, 129);
            this.ButtonJikou.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ButtonJikou.Name = "ButtonJikou";
            this.ButtonJikou.Size = new System.Drawing.Size(124, 46);
            this.ButtonJikou.TabIndex = 31;
            this.ButtonJikou.Text = "実行";
            this.ButtonJikou.UseVisualStyleBackColor = true;
            this.ButtonJikou.Click += new System.EventHandler(this.ButtonJikou_Click);
            // 
            // RadioHihyouji
            // 
            this.RadioHihyouji.AutoSize = true;
            this.RadioHihyouji.Font = new System.Drawing.Font("MS UI Gothic", 18F);
            this.RadioHihyouji.Location = new System.Drawing.Point(128, 137);
            this.RadioHihyouji.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.RadioHihyouji.Name = "RadioHihyouji";
            this.RadioHihyouji.Size = new System.Drawing.Size(100, 28);
            this.RadioHihyouji.TabIndex = 49;
            this.RadioHihyouji.Text = "非表示";
            this.RadioHihyouji.UseVisualStyleBackColor = true;
            // 
            // RadioKensaku
            // 
            this.RadioKensaku.AutoSize = true;
            this.RadioKensaku.Font = new System.Drawing.Font("MS UI Gothic", 18F);
            this.RadioKensaku.Location = new System.Drawing.Point(45, 137);
            this.RadioKensaku.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.RadioKensaku.Name = "RadioKensaku";
            this.RadioKensaku.Size = new System.Drawing.Size(76, 28);
            this.RadioKensaku.TabIndex = 47;
            this.RadioKensaku.Text = "検索";
            this.RadioKensaku.UseVisualStyleBackColor = true;
            this.RadioKensaku.CheckedChanged += new System.EventHandler(this.RadioKensaku_CheckedChanged);
            // 
            // ButtonBack
            // 
            this.ButtonBack.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.ButtonBack.Location = new System.Drawing.Point(890, 34);
            this.ButtonBack.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ButtonBack.Name = "ButtonBack";
            this.ButtonBack.Size = new System.Drawing.Size(124, 46);
            this.ButtonBack.TabIndex = 5;
            this.ButtonBack.Text = "戻る";
            this.ButtonBack.UseVisualStyleBackColor = true;
            this.ButtonBack.Click += new System.EventHandler(this.ButtonBack_Click);
            // 
            // LabelTitle
            // 
            this.LabelTitle.AutoSize = true;
            this.LabelTitle.Font = new System.Drawing.Font("MS UI Gothic", 30F);
            this.LabelTitle.Location = new System.Drawing.Point(393, 35);
            this.LabelTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelTitle.Name = "LabelTitle";
            this.LabelTitle.Size = new System.Drawing.Size(294, 40);
            this.LabelTitle.TabIndex = 4;
            this.LabelTitle.Text = "入荷管理メニュー";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.label19);
            this.panel1.Controls.Add(this.ButtonBack);
            this.panel1.Controls.Add(this.label18);
            this.panel1.Controls.Add(this.LabelTitle);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.label17);
            this.panel1.Controls.Add(this.label15);
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
            this.label19.Location = new System.Drawing.Point(149, 84);
            this.label19.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(41, 16);
            this.label19.TabIndex = 144;
            this.label19.Text = "◯◯";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label18.Location = new System.Drawing.Point(149, 59);
            this.label18.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(41, 16);
            this.label18.TabIndex = 143;
            this.label18.Text = "◯◯";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label16.Location = new System.Drawing.Point(149, 35);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(41, 16);
            this.label16.TabIndex = 142;
            this.label16.Text = "◯◯";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label14.Location = new System.Drawing.Point(35, 34);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(110, 16);
            this.label14.TabIndex = 139;
            this.label14.Text = "ログイン社員名";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label17.Location = new System.Drawing.Point(52, 84);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(93, 16);
            this.label17.TabIndex = 140;
            this.label17.Text = "ログイン日時";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label15.Location = new System.Drawing.Point(80, 59);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(58, 16);
            this.label15.TabIndex = 141;
            this.label15.Text = "営業所";
            // 
            // TextBoxHidden
            // 
            this.TextBoxHidden.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.TextBoxHidden.Location = new System.Drawing.Point(740, 214);
            this.TextBoxHidden.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TextBoxHidden.Name = "TextBoxHidden";
            this.TextBoxHidden.Size = new System.Drawing.Size(275, 130);
            this.TextBoxHidden.TabIndex = 44;
            this.TextBoxHidden.Text = "";
            // 
            // LabelHidden
            // 
            this.LabelHidden.AutoSize = true;
            this.LabelHidden.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.LabelHidden.Location = new System.Drawing.Point(632, 214);
            this.LabelHidden.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelHidden.Name = "LabelHidden";
            this.LabelHidden.Size = new System.Drawing.Size(109, 20);
            this.LabelHidden.TabIndex = 43;
            this.LabelHidden.Text = "非表示理由";
            // 
            // LabelTanntouName
            // 
            this.LabelTanntouName.AutoSize = true;
            this.LabelTanntouName.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.LabelTanntouName.Location = new System.Drawing.Point(352, 328);
            this.LabelTanntouName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelTanntouName.Name = "LabelTanntouName";
            this.LabelTanntouName.Size = new System.Drawing.Size(69, 20);
            this.LabelTanntouName.TabIndex = 41;
            this.LabelTanntouName.Text = "社員名";
            // 
            // TextBoxTanntouName
            // 
            this.TextBoxTanntouName.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.TextBoxTanntouName.Location = new System.Drawing.Point(427, 326);
            this.TextBoxTanntouName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TextBoxTanntouName.Name = "TextBoxTanntouName";
            this.TextBoxTanntouName.Size = new System.Drawing.Size(179, 27);
            this.TextBoxTanntouName.TabIndex = 40;
            // 
            // NyukaDate
            // 
            this.NyukaDate.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.NyukaDate.Location = new System.Drawing.Point(134, 291);
            this.NyukaDate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.NyukaDate.Name = "NyukaDate";
            this.NyukaDate.Size = new System.Drawing.Size(179, 27);
            this.NyukaDate.TabIndex = 39;
            // 
            // LabelArrivaDate
            // 
            this.LabelArrivaDate.AutoSize = true;
            this.LabelArrivaDate.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.LabelArrivaDate.Location = new System.Drawing.Point(21, 296);
            this.LabelArrivaDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelArrivaDate.Name = "LabelArrivaDate";
            this.LabelArrivaDate.Size = new System.Drawing.Size(109, 20);
            this.LabelArrivaDate.TabIndex = 38;
            this.LabelArrivaDate.Text = "入荷年月日";
            // 
            // ComboBoxKokyakumei
            // 
            this.ComboBoxKokyakumei.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.ComboBoxKokyakumei.FormattingEnabled = true;
            this.ComboBoxKokyakumei.Location = new System.Drawing.Point(427, 252);
            this.ComboBoxKokyakumei.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ComboBoxKokyakumei.Name = "ComboBoxKokyakumei";
            this.ComboBoxKokyakumei.Size = new System.Drawing.Size(179, 28);
            this.ComboBoxKokyakumei.TabIndex = 35;
            // 
            // LabelKokyakumei
            // 
            this.LabelKokyakumei.AutoSize = true;
            this.LabelKokyakumei.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.LabelKokyakumei.Location = new System.Drawing.Point(352, 256);
            this.LabelKokyakumei.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelKokyakumei.Name = "LabelKokyakumei";
            this.LabelKokyakumei.Size = new System.Drawing.Size(69, 20);
            this.LabelKokyakumei.TabIndex = 34;
            this.LabelKokyakumei.Text = "顧客名";
            // 
            // LabelSyainnID
            // 
            this.LabelSyainnID.AutoSize = true;
            this.LabelSyainnID.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.LabelSyainnID.Location = new System.Drawing.Point(352, 290);
            this.LabelSyainnID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelSyainnID.Name = "LabelSyainnID";
            this.LabelSyainnID.Size = new System.Drawing.Size(67, 20);
            this.LabelSyainnID.TabIndex = 33;
            this.LabelSyainnID.Text = "社員ID";
            // 
            // TextBoxSyainnID
            // 
            this.TextBoxSyainnID.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.TextBoxSyainnID.Location = new System.Drawing.Point(427, 288);
            this.TextBoxSyainnID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TextBoxSyainnID.Name = "TextBoxSyainnID";
            this.TextBoxSyainnID.Size = new System.Drawing.Size(179, 27);
            this.TextBoxSyainnID.TabIndex = 30;
            // 
            // ComboBoxEigyousyomei
            // 
            this.ComboBoxEigyousyomei.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.ComboBoxEigyousyomei.FormattingEnabled = true;
            this.ComboBoxEigyousyomei.Location = new System.Drawing.Point(136, 329);
            this.ComboBoxEigyousyomei.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ComboBoxEigyousyomei.Name = "ComboBoxEigyousyomei";
            this.ComboBoxEigyousyomei.Size = new System.Drawing.Size(177, 28);
            this.ComboBoxEigyousyomei.TabIndex = 29;
            // 
            // LabelEigyoushomei
            // 
            this.LabelEigyoushomei.AutoSize = true;
            this.LabelEigyoushomei.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.LabelEigyoushomei.Location = new System.Drawing.Point(45, 333);
            this.LabelEigyoushomei.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelEigyoushomei.Name = "LabelEigyoushomei";
            this.LabelEigyoushomei.Size = new System.Drawing.Size(89, 20);
            this.LabelEigyoushomei.TabIndex = 28;
            this.LabelEigyoushomei.Text = "営業所名";
            // 
            // LabelNyuukaID
            // 
            this.LabelNyuukaID.AutoSize = true;
            this.LabelNyuukaID.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.LabelNyuukaID.Location = new System.Drawing.Point(68, 218);
            this.LabelNyuukaID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LabelNyuukaID.Name = "LabelNyuukaID";
            this.LabelNyuukaID.Size = new System.Drawing.Size(67, 20);
            this.LabelNyuukaID.TabIndex = 27;
            this.LabelNyuukaID.Text = "入荷ID";
            // 
            // TextBoxNyuukaID
            // 
            this.TextBoxNyuukaID.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.TextBoxNyuukaID.Location = new System.Drawing.Point(136, 212);
            this.TextBoxNyuukaID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TextBoxNyuukaID.Name = "TextBoxNyuukaID";
            this.TextBoxNyuukaID.Size = new System.Drawing.Size(177, 27);
            this.TextBoxNyuukaID.TabIndex = 26;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(38, 379);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(981, 213);
            this.dataGridView1.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.label1.Location = new System.Drawing.Point(28, 255);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 20);
            this.label1.TabIndex = 53;
            this.label1.Text = "入荷詳細ID";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.textBox1.Location = new System.Drawing.Point(136, 253);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(177, 27);
            this.textBox1.TabIndex = 52;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(427, 214);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(179, 28);
            this.comboBox1.TabIndex = 55;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.label2.Location = new System.Drawing.Point(352, 218);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 20);
            this.label2.TabIndex = 54;
            this.label2.Text = "顧客ID";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.button1.Location = new System.Drawing.Point(382, 638);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(243, 49);
            this.button1.TabIndex = 56;
            this.button1.Text = "確定";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // F_入荷管理
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1052, 707);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.ButtonReset);
            this.Controls.Add(this.ButtonJikou);
            this.Controls.Add(this.RadioHihyouji);
            this.Controls.Add(this.RadioKensaku);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.TextBoxHidden);
            this.Controls.Add(this.LabelHidden);
            this.Controls.Add(this.LabelTanntouName);
            this.Controls.Add(this.TextBoxTanntouName);
            this.Controls.Add(this.NyukaDate);
            this.Controls.Add(this.LabelArrivaDate);
            this.Controls.Add(this.ComboBoxKokyakumei);
            this.Controls.Add(this.LabelKokyakumei);
            this.Controls.Add(this.LabelSyainnID);
            this.Controls.Add(this.TextBoxSyainnID);
            this.Controls.Add(this.ComboBoxEigyousyomei);
            this.Controls.Add(this.LabelEigyoushomei);
            this.Controls.Add(this.LabelNyuukaID);
            this.Controls.Add(this.TextBoxNyuukaID);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "F_入荷管理";
            this.Text = "F_入荷";
            this.Load += new System.EventHandler(this.F_入荷管理_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonReset;
        private System.Windows.Forms.Button ButtonJikou;
        private System.Windows.Forms.RadioButton RadioHihyouji;
        private System.Windows.Forms.RadioButton RadioKensaku;
        private System.Windows.Forms.Button ButtonBack;
        private System.Windows.Forms.Label LabelTitle;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox TextBoxHidden;
        private System.Windows.Forms.Label LabelHidden;
        private System.Windows.Forms.Label LabelTanntouName;
        private System.Windows.Forms.TextBox TextBoxTanntouName;
        private System.Windows.Forms.DateTimePicker NyukaDate;
        private System.Windows.Forms.Label LabelArrivaDate;
        private System.Windows.Forms.ComboBox ComboBoxKokyakumei;
        private System.Windows.Forms.Label LabelKokyakumei;
        private System.Windows.Forms.Label LabelSyainnID;
        private System.Windows.Forms.TextBox TextBoxSyainnID;
        private System.Windows.Forms.ComboBox ComboBoxEigyousyomei;
        private System.Windows.Forms.Label LabelEigyoushomei;
        private System.Windows.Forms.Label LabelNyuukaID;
        private System.Windows.Forms.TextBox TextBoxNyuukaID;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label15;
    }
}