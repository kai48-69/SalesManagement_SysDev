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
            this.ButtonKakutei = new System.Windows.Forms.Button();
            this.ButtonArrivalDetail = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // ButtonReset
            // 
            this.ButtonReset.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.ButtonReset.Location = new System.Drawing.Point(423, 210);
            this.ButtonReset.Name = "ButtonReset";
            this.ButtonReset.Size = new System.Drawing.Size(207, 52);
            this.ButtonReset.TabIndex = 50;
            this.ButtonReset.Text = "入力リセット";
            this.ButtonReset.UseVisualStyleBackColor = true;
            this.ButtonReset.Click += new System.EventHandler(this.ButtonReset_Click);
            // 
            // ButtonJikou
            // 
            this.ButtonJikou.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.ButtonJikou.Location = new System.Drawing.Point(1357, 201);
            this.ButtonJikou.Name = "ButtonJikou";
            this.ButtonJikou.Size = new System.Drawing.Size(207, 69);
            this.ButtonJikou.TabIndex = 31;
            this.ButtonJikou.Text = "実行";
            this.ButtonJikou.UseVisualStyleBackColor = true;
            this.ButtonJikou.Click += new System.EventHandler(this.ButtonJikou_Click);
            // 
            // RadioHihyouji
            // 
            this.RadioHihyouji.AutoSize = true;
            this.RadioHihyouji.Font = new System.Drawing.Font("MS UI Gothic", 18F);
            this.RadioHihyouji.Location = new System.Drawing.Point(223, 213);
            this.RadioHihyouji.Name = "RadioHihyouji";
            this.RadioHihyouji.Size = new System.Drawing.Size(148, 40);
            this.RadioHihyouji.TabIndex = 49;
            this.RadioHihyouji.Text = "非表示";
            this.RadioHihyouji.UseVisualStyleBackColor = true;
            // 
            // RadioKensaku
            // 
            this.RadioKensaku.AutoSize = true;
            this.RadioKensaku.Font = new System.Drawing.Font("MS UI Gothic", 18F);
            this.RadioKensaku.Location = new System.Drawing.Point(85, 213);
            this.RadioKensaku.Name = "RadioKensaku";
            this.RadioKensaku.Size = new System.Drawing.Size(112, 40);
            this.RadioKensaku.TabIndex = 47;
            this.RadioKensaku.Text = "検索";
            this.RadioKensaku.UseVisualStyleBackColor = true;
            this.RadioKensaku.CheckedChanged += new System.EventHandler(this.RadioKensaku_CheckedChanged);
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
            // LabelTitle
            // 
            this.LabelTitle.AutoSize = true;
            this.LabelTitle.Font = new System.Drawing.Font("MS UI Gothic", 30F);
            this.LabelTitle.Location = new System.Drawing.Point(582, 68);
            this.LabelTitle.Name = "LabelTitle";
            this.LabelTitle.Size = new System.Drawing.Size(440, 60);
            this.LabelTitle.TabIndex = 4;
            this.LabelTitle.Text = "入荷管理メニュー";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.ButtonBack);
            this.panel1.Controls.Add(this.LabelTitle);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1647, 171);
            this.panel1.TabIndex = 45;
            // 
            // TextBoxHidden
            // 
            this.TextBoxHidden.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.TextBoxHidden.Location = new System.Drawing.Point(1208, 321);
            this.TextBoxHidden.Name = "TextBoxHidden";
            this.TextBoxHidden.Size = new System.Drawing.Size(352, 193);
            this.TextBoxHidden.TabIndex = 44;
            this.TextBoxHidden.Text = "";
            // 
            // LabelHidden
            // 
            this.LabelHidden.AutoSize = true;
            this.LabelHidden.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.LabelHidden.Location = new System.Drawing.Point(1023, 326);
            this.LabelHidden.Name = "LabelHidden";
            this.LabelHidden.Size = new System.Drawing.Size(163, 30);
            this.LabelHidden.TabIndex = 43;
            this.LabelHidden.Text = "非表示理由";
            // 
            // LabelTanntouName
            // 
            this.LabelTanntouName.AutoSize = true;
            this.LabelTanntouName.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.LabelTanntouName.Location = new System.Drawing.Point(525, 482);
            this.LabelTanntouName.Name = "LabelTanntouName";
            this.LabelTanntouName.Size = new System.Drawing.Size(193, 30);
            this.LabelTanntouName.TabIndex = 41;
            this.LabelTanntouName.Text = "社員担当者名";
            // 
            // TextBoxTanntouName
            // 
            this.TextBoxTanntouName.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.TextBoxTanntouName.Location = new System.Drawing.Point(743, 477);
            this.TextBoxTanntouName.Name = "TextBoxTanntouName";
            this.TextBoxTanntouName.Size = new System.Drawing.Size(249, 37);
            this.TextBoxTanntouName.TabIndex = 40;
            // 
            // NyukaDate
            // 
            this.NyukaDate.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.NyukaDate.Location = new System.Drawing.Point(223, 474);
            this.NyukaDate.Name = "NyukaDate";
            this.NyukaDate.Size = new System.Drawing.Size(276, 37);
            this.NyukaDate.TabIndex = 39;
            // 
            // LabelArrivaDate
            // 
            this.LabelArrivaDate.AutoSize = true;
            this.LabelArrivaDate.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.LabelArrivaDate.Location = new System.Drawing.Point(38, 478);
            this.LabelArrivaDate.Name = "LabelArrivaDate";
            this.LabelArrivaDate.Size = new System.Drawing.Size(163, 30);
            this.LabelArrivaDate.TabIndex = 38;
            this.LabelArrivaDate.Text = "入荷年月日";
            // 
            // ComboBoxKokyakumei
            // 
            this.ComboBoxKokyakumei.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.ComboBoxKokyakumei.FormattingEnabled = true;
            this.ComboBoxKokyakumei.Location = new System.Drawing.Point(743, 318);
            this.ComboBoxKokyakumei.Name = "ComboBoxKokyakumei";
            this.ComboBoxKokyakumei.Size = new System.Drawing.Size(249, 38);
            this.ComboBoxKokyakumei.TabIndex = 35;
            // 
            // LabelKokyakumei
            // 
            this.LabelKokyakumei.AutoSize = true;
            this.LabelKokyakumei.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.LabelKokyakumei.Location = new System.Drawing.Point(625, 324);
            this.LabelKokyakumei.Name = "LabelKokyakumei";
            this.LabelKokyakumei.Size = new System.Drawing.Size(103, 30);
            this.LabelKokyakumei.TabIndex = 34;
            this.LabelKokyakumei.Text = "顧客名";
            // 
            // LabelSyainnID
            // 
            this.LabelSyainnID.AutoSize = true;
            this.LabelSyainnID.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.LabelSyainnID.Location = new System.Drawing.Point(628, 402);
            this.LabelSyainnID.Name = "LabelSyainnID";
            this.LabelSyainnID.Size = new System.Drawing.Size(99, 30);
            this.LabelSyainnID.TabIndex = 33;
            this.LabelSyainnID.Text = "社員ID";
            // 
            // TextBoxSyainnID
            // 
            this.TextBoxSyainnID.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.TextBoxSyainnID.Location = new System.Drawing.Point(743, 396);
            this.TextBoxSyainnID.Name = "TextBoxSyainnID";
            this.TextBoxSyainnID.Size = new System.Drawing.Size(249, 37);
            this.TextBoxSyainnID.TabIndex = 30;
            // 
            // ComboBoxEigyousyomei
            // 
            this.ComboBoxEigyousyomei.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.ComboBoxEigyousyomei.FormattingEnabled = true;
            this.ComboBoxEigyousyomei.Location = new System.Drawing.Point(227, 400);
            this.ComboBoxEigyousyomei.Name = "ComboBoxEigyousyomei";
            this.ComboBoxEigyousyomei.Size = new System.Drawing.Size(272, 38);
            this.ComboBoxEigyousyomei.TabIndex = 29;
            // 
            // LabelEigyoushomei
            // 
            this.LabelEigyoushomei.AutoSize = true;
            this.LabelEigyoushomei.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.LabelEigyoushomei.Location = new System.Drawing.Point(75, 406);
            this.LabelEigyoushomei.Name = "LabelEigyoushomei";
            this.LabelEigyoushomei.Size = new System.Drawing.Size(133, 30);
            this.LabelEigyoushomei.TabIndex = 28;
            this.LabelEigyoushomei.Text = "営業所名";
            // 
            // LabelNyuukaID
            // 
            this.LabelNyuukaID.AutoSize = true;
            this.LabelNyuukaID.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.LabelNyuukaID.Location = new System.Drawing.Point(112, 326);
            this.LabelNyuukaID.Name = "LabelNyuukaID";
            this.LabelNyuukaID.Size = new System.Drawing.Size(99, 30);
            this.LabelNyuukaID.TabIndex = 27;
            this.LabelNyuukaID.Text = "入荷ID";
            // 
            // TextBoxNyuukaID
            // 
            this.TextBoxNyuukaID.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.TextBoxNyuukaID.Location = new System.Drawing.Point(227, 321);
            this.TextBoxNyuukaID.Name = "TextBoxNyuukaID";
            this.TextBoxNyuukaID.Size = new System.Drawing.Size(272, 37);
            this.TextBoxNyuukaID.TabIndex = 26;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(53, 555);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1510, 324);
            this.dataGridView1.TabIndex = 25;
            // 
            // ButtonKakutei
            // 
            this.ButtonKakutei.Font = new System.Drawing.Font("MS UI Gothic", 25F);
            this.ButtonKakutei.Location = new System.Drawing.Point(593, 909);
            this.ButtonKakutei.Name = "ButtonKakutei";
            this.ButtonKakutei.Size = new System.Drawing.Size(420, 76);
            this.ButtonKakutei.TabIndex = 51;
            this.ButtonKakutei.Text = "確定";
            this.ButtonKakutei.UseVisualStyleBackColor = true;
            this.ButtonKakutei.Click += new System.EventHandler(this.ButtonKakutei_Click);
            // 
            // ButtonArrivalDetail
            // 
            this.ButtonArrivalDetail.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.ButtonArrivalDetail.Location = new System.Drawing.Point(1083, 201);
            this.ButtonArrivalDetail.Name = "ButtonArrivalDetail";
            this.ButtonArrivalDetail.Size = new System.Drawing.Size(207, 69);
            this.ButtonArrivalDetail.TabIndex = 52;
            this.ButtonArrivalDetail.Text = "入荷詳細へ";
            this.ButtonArrivalDetail.UseVisualStyleBackColor = true;
            this.ButtonArrivalDetail.Click += new System.EventHandler(this.ButtonArrivalDetail_Click);
            // 
            // F_入荷管理
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1647, 1020);
            this.Controls.Add(this.ButtonArrivalDetail);
            this.Controls.Add(this.ButtonKakutei);
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
            this.Name = "F_入荷管理";
            this.Text = "F_入荷";
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
        private System.Windows.Forms.Button ButtonKakutei;
        private System.Windows.Forms.Button ButtonArrivalDetail;
    }
}