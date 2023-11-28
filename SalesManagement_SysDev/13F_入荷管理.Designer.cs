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
            this.LblLoginDate = new System.Windows.Forms.Label();
            this.LblSoName = new System.Windows.Forms.Label();
            this.LblEmName = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // ButtonReset
            // 
            this.ButtonReset.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.ButtonReset.Location = new System.Drawing.Point(311, 161);
            this.ButtonReset.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ButtonReset.Name = "ButtonReset";
            this.ButtonReset.Size = new System.Drawing.Size(165, 58);
            this.ButtonReset.TabIndex = 50;
            this.ButtonReset.Text = "入力リセット";
            this.ButtonReset.UseVisualStyleBackColor = true;
            this.ButtonReset.Click += new System.EventHandler(this.ButtonReset_Click);
            // 
            // ButtonJikou
            // 
            this.ButtonJikou.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.ButtonJikou.Location = new System.Drawing.Point(1187, 161);
            this.ButtonJikou.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ButtonJikou.Name = "ButtonJikou";
            this.ButtonJikou.Size = new System.Drawing.Size(165, 58);
            this.ButtonJikou.TabIndex = 31;
            this.ButtonJikou.Text = "実行";
            this.ButtonJikou.UseVisualStyleBackColor = true;
            this.ButtonJikou.Click += new System.EventHandler(this.ButtonJikou_Click);
            // 
            // RadioHihyouji
            // 
            this.RadioHihyouji.AutoSize = true;
            this.RadioHihyouji.Font = new System.Drawing.Font("MS UI Gothic", 18F);
            this.RadioHihyouji.Location = new System.Drawing.Point(171, 171);
            this.RadioHihyouji.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RadioHihyouji.Name = "RadioHihyouji";
            this.RadioHihyouji.Size = new System.Drawing.Size(124, 34);
            this.RadioHihyouji.TabIndex = 49;
            this.RadioHihyouji.Text = "非表示";
            this.RadioHihyouji.UseVisualStyleBackColor = true;
            // 
            // RadioKensaku
            // 
            this.RadioKensaku.AutoSize = true;
            this.RadioKensaku.Font = new System.Drawing.Font("MS UI Gothic", 18F);
            this.RadioKensaku.Location = new System.Drawing.Point(60, 171);
            this.RadioKensaku.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RadioKensaku.Name = "RadioKensaku";
            this.RadioKensaku.Size = new System.Drawing.Size(94, 34);
            this.RadioKensaku.TabIndex = 47;
            this.RadioKensaku.Text = "検索";
            this.RadioKensaku.UseVisualStyleBackColor = true;
            this.RadioKensaku.CheckedChanged += new System.EventHandler(this.RadioKensaku_CheckedChanged);
            // 
            // ButtonBack
            // 
            this.ButtonBack.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.ButtonBack.Location = new System.Drawing.Point(1187, 42);
            this.ButtonBack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ButtonBack.Name = "ButtonBack";
            this.ButtonBack.Size = new System.Drawing.Size(165, 58);
            this.ButtonBack.TabIndex = 5;
            this.ButtonBack.Text = "戻る";
            this.ButtonBack.UseVisualStyleBackColor = true;
            this.ButtonBack.Click += new System.EventHandler(this.ButtonBack_Click);
            // 
            // LabelTitle
            // 
            this.LabelTitle.AutoSize = true;
            this.LabelTitle.Font = new System.Drawing.Font("MS UI Gothic", 30F);
            this.LabelTitle.Location = new System.Drawing.Point(524, 44);
            this.LabelTitle.Name = "LabelTitle";
            this.LabelTitle.Size = new System.Drawing.Size(368, 50);
            this.LabelTitle.TabIndex = 4;
            this.LabelTitle.Text = "入荷管理メニュー";
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
            this.panel1.Controls.Add(this.LabelTitle);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1403, 142);
            this.panel1.TabIndex = 45;
            // 
            // TextBoxHidden
            // 
            this.TextBoxHidden.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.TextBoxHidden.Location = new System.Drawing.Point(987, 268);
            this.TextBoxHidden.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TextBoxHidden.Name = "TextBoxHidden";
            this.TextBoxHidden.Size = new System.Drawing.Size(365, 162);
            this.TextBoxHidden.TabIndex = 44;
            this.TextBoxHidden.Text = "";
            // 
            // LabelHidden
            // 
            this.LabelHidden.AutoSize = true;
            this.LabelHidden.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.LabelHidden.Location = new System.Drawing.Point(843, 268);
            this.LabelHidden.Name = "LabelHidden";
            this.LabelHidden.Size = new System.Drawing.Size(137, 25);
            this.LabelHidden.TabIndex = 43;
            this.LabelHidden.Text = "非表示理由";
            // 
            // LabelTanntouName
            // 
            this.LabelTanntouName.AutoSize = true;
            this.LabelTanntouName.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.LabelTanntouName.Location = new System.Drawing.Point(469, 410);
            this.LabelTanntouName.Name = "LabelTanntouName";
            this.LabelTanntouName.Size = new System.Drawing.Size(87, 25);
            this.LabelTanntouName.TabIndex = 41;
            this.LabelTanntouName.Text = "社員名";
            // 
            // TextBoxTanntouName
            // 
            this.TextBoxTanntouName.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.TextBoxTanntouName.Location = new System.Drawing.Point(569, 408);
            this.TextBoxTanntouName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TextBoxTanntouName.Name = "TextBoxTanntouName";
            this.TextBoxTanntouName.Size = new System.Drawing.Size(237, 32);
            this.TextBoxTanntouName.TabIndex = 40;
            // 
            // NyukaDate
            // 
            this.NyukaDate.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.NyukaDate.Location = new System.Drawing.Point(179, 364);
            this.NyukaDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.NyukaDate.Name = "NyukaDate";
            this.NyukaDate.Size = new System.Drawing.Size(237, 32);
            this.NyukaDate.TabIndex = 39;
            // 
            // LabelArrivaDate
            // 
            this.LabelArrivaDate.AutoSize = true;
            this.LabelArrivaDate.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.LabelArrivaDate.Location = new System.Drawing.Point(28, 370);
            this.LabelArrivaDate.Name = "LabelArrivaDate";
            this.LabelArrivaDate.Size = new System.Drawing.Size(137, 25);
            this.LabelArrivaDate.TabIndex = 38;
            this.LabelArrivaDate.Text = "入荷年月日";
            // 
            // ComboBoxKokyakumei
            // 
            this.ComboBoxKokyakumei.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.ComboBoxKokyakumei.FormattingEnabled = true;
            this.ComboBoxKokyakumei.Location = new System.Drawing.Point(569, 315);
            this.ComboBoxKokyakumei.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ComboBoxKokyakumei.Name = "ComboBoxKokyakumei";
            this.ComboBoxKokyakumei.Size = new System.Drawing.Size(237, 33);
            this.ComboBoxKokyakumei.TabIndex = 35;
            // 
            // LabelKokyakumei
            // 
            this.LabelKokyakumei.AutoSize = true;
            this.LabelKokyakumei.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.LabelKokyakumei.Location = new System.Drawing.Point(469, 320);
            this.LabelKokyakumei.Name = "LabelKokyakumei";
            this.LabelKokyakumei.Size = new System.Drawing.Size(87, 25);
            this.LabelKokyakumei.TabIndex = 34;
            this.LabelKokyakumei.Text = "顧客名";
            // 
            // LabelSyainnID
            // 
            this.LabelSyainnID.AutoSize = true;
            this.LabelSyainnID.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.LabelSyainnID.Location = new System.Drawing.Point(469, 362);
            this.LabelSyainnID.Name = "LabelSyainnID";
            this.LabelSyainnID.Size = new System.Drawing.Size(84, 25);
            this.LabelSyainnID.TabIndex = 33;
            this.LabelSyainnID.Text = "社員ID";
            // 
            // TextBoxSyainnID
            // 
            this.TextBoxSyainnID.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.TextBoxSyainnID.Location = new System.Drawing.Point(569, 360);
            this.TextBoxSyainnID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TextBoxSyainnID.Name = "TextBoxSyainnID";
            this.TextBoxSyainnID.Size = new System.Drawing.Size(237, 32);
            this.TextBoxSyainnID.TabIndex = 30;
            // 
            // ComboBoxEigyousyomei
            // 
            this.ComboBoxEigyousyomei.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.ComboBoxEigyousyomei.FormattingEnabled = true;
            this.ComboBoxEigyousyomei.Location = new System.Drawing.Point(181, 411);
            this.ComboBoxEigyousyomei.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ComboBoxEigyousyomei.Name = "ComboBoxEigyousyomei";
            this.ComboBoxEigyousyomei.Size = new System.Drawing.Size(235, 33);
            this.ComboBoxEigyousyomei.TabIndex = 29;
            // 
            // LabelEigyoushomei
            // 
            this.LabelEigyoushomei.AutoSize = true;
            this.LabelEigyoushomei.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.LabelEigyoushomei.Location = new System.Drawing.Point(60, 416);
            this.LabelEigyoushomei.Name = "LabelEigyoushomei";
            this.LabelEigyoushomei.Size = new System.Drawing.Size(112, 25);
            this.LabelEigyoushomei.TabIndex = 28;
            this.LabelEigyoushomei.Text = "営業所名";
            // 
            // LabelNyuukaID
            // 
            this.LabelNyuukaID.AutoSize = true;
            this.LabelNyuukaID.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.LabelNyuukaID.Location = new System.Drawing.Point(91, 272);
            this.LabelNyuukaID.Name = "LabelNyuukaID";
            this.LabelNyuukaID.Size = new System.Drawing.Size(84, 25);
            this.LabelNyuukaID.TabIndex = 27;
            this.LabelNyuukaID.Text = "入荷ID";
            // 
            // TextBoxNyuukaID
            // 
            this.TextBoxNyuukaID.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.TextBoxNyuukaID.Location = new System.Drawing.Point(181, 265);
            this.TextBoxNyuukaID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TextBoxNyuukaID.Name = "TextBoxNyuukaID";
            this.TextBoxNyuukaID.Size = new System.Drawing.Size(235, 32);
            this.TextBoxNyuukaID.TabIndex = 26;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(51, 474);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1308, 266);
            this.dataGridView1.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.label1.Location = new System.Drawing.Point(37, 319);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 25);
            this.label1.TabIndex = 53;
            this.label1.Text = "入荷詳細ID";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.textBox1.Location = new System.Drawing.Point(181, 316);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(235, 32);
            this.textBox1.TabIndex = 52;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(569, 268);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(237, 33);
            this.comboBox1.TabIndex = 55;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.label2.Location = new System.Drawing.Point(469, 272);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 25);
            this.label2.TabIndex = 54;
            this.label2.Text = "顧客ID";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.button1.Location = new System.Drawing.Point(509, 798);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(324, 61);
            this.button1.TabIndex = 56;
            this.button1.Text = "確定";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // LblLoginDate
            // 
            this.LblLoginDate.AutoSize = true;
            this.LblLoginDate.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Bold);
            this.LblLoginDate.Location = new System.Drawing.Point(176, 93);
            this.LblLoginDate.Name = "LblLoginDate";
            this.LblLoginDate.Size = new System.Drawing.Size(153, 19);
            this.LblLoginDate.TabIndex = 110;
            this.LblLoginDate.Text = "23/10/30 11:15";
            // 
            // LblSoName
            // 
            this.LblSoName.AutoSize = true;
            this.LblSoName.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Bold);
            this.LblSoName.Location = new System.Drawing.Point(176, 62);
            this.LblSoName.Name = "LblSoName";
            this.LblSoName.Size = new System.Drawing.Size(129, 19);
            this.LblSoName.TabIndex = 109;
            this.LblSoName.Text = "◯◯◯営業所";
            // 
            // LblEmName
            // 
            this.LblEmName.AutoSize = true;
            this.LblEmName.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Bold);
            this.LblEmName.Location = new System.Drawing.Point(176, 30);
            this.LblEmName.Name = "LblEmName";
            this.LblEmName.Size = new System.Drawing.Size(109, 19);
            this.LblEmName.TabIndex = 108;
            this.LblEmName.Text = "江戸川乱歩";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Bold);
            this.label14.Location = new System.Drawing.Point(41, 30);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(130, 19);
            this.label14.TabIndex = 105;
            this.label14.Text = "ログイン社員名";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Bold);
            this.label17.Location = new System.Drawing.Point(61, 93);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(110, 19);
            this.label17.TabIndex = 106;
            this.label17.Text = "ログイン日時";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Bold);
            this.label15.Location = new System.Drawing.Point(101, 62);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(69, 19);
            this.label15.TabIndex = 107;
            this.label15.Text = "営業所";
            // 
            // F_入荷管理
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1403, 884);
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
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
        private System.Windows.Forms.Label LblLoginDate;
        private System.Windows.Forms.Label LblSoName;
        private System.Windows.Forms.Label LblEmName;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label15;
    }
}