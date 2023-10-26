namespace SalesManagement_SysDev
{
    partial class F_入荷詳細登録
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
            this.LabelTitle = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.TextBoxSuryo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ComboBoxShohinName = new System.Windows.Forms.ComboBox();
            this.LabelShohinName = new System.Windows.Forms.Label();
            this.TextBoxNyukaID = new System.Windows.Forms.TextBox();
            this.LabelNyukaID = new System.Windows.Forms.Label();
            this.TextBoxNyukaShosaiID = new System.Windows.Forms.TextBox();
            this.LabelNyukaShosaiID = new System.Windows.Forms.Label();
            this.ButtonTouroku = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.ButtonBack);
            this.panel1.Controls.Add(this.LabelTitle);
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
            // LabelTitle
            // 
            this.LabelTitle.AutoSize = true;
            this.LabelTitle.Font = new System.Drawing.Font("MS UI Gothic", 30F);
            this.LabelTitle.Location = new System.Drawing.Point(420, 52);
            this.LabelTitle.Name = "LabelTitle";
            this.LabelTitle.Size = new System.Drawing.Size(385, 60);
            this.LabelTitle.TabIndex = 4;
            this.LabelTitle.Text = "入荷詳細登録";
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
            // TextBoxSuryo
            // 
            this.TextBoxSuryo.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.TextBoxSuryo.Location = new System.Drawing.Point(583, 318);
            this.TextBoxSuryo.Name = "TextBoxSuryo";
            this.TextBoxSuryo.Size = new System.Drawing.Size(194, 37);
            this.TextBoxSuryo.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.label4.Location = new System.Drawing.Point(498, 324);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 30);
            this.label4.TabIndex = 18;
            this.label4.Text = "数量";
            // 
            // ComboBoxShohinName
            // 
            this.ComboBoxShohinName.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.ComboBoxShohinName.FormattingEnabled = true;
            this.ComboBoxShohinName.Location = new System.Drawing.Point(583, 234);
            this.ComboBoxShohinName.Name = "ComboBoxShohinName";
            this.ComboBoxShohinName.Size = new System.Drawing.Size(191, 38);
            this.ComboBoxShohinName.TabIndex = 17;
            // 
            // LabelShohinName
            // 
            this.LabelShohinName.AutoSize = true;
            this.LabelShohinName.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.LabelShohinName.Location = new System.Drawing.Point(467, 243);
            this.LabelShohinName.Name = "LabelShohinName";
            this.LabelShohinName.Size = new System.Drawing.Size(103, 30);
            this.LabelShohinName.TabIndex = 16;
            this.LabelShohinName.Text = "商品名";
            // 
            // TextBoxNyukaID
            // 
            this.TextBoxNyukaID.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.TextBoxNyukaID.Location = new System.Drawing.Point(238, 318);
            this.TextBoxNyukaID.Name = "TextBoxNyukaID";
            this.TextBoxNyukaID.Size = new System.Drawing.Size(194, 37);
            this.TextBoxNyukaID.TabIndex = 15;
            // 
            // LabelNyukaID
            // 
            this.LabelNyukaID.AutoSize = true;
            this.LabelNyukaID.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.LabelNyukaID.Location = new System.Drawing.Point(127, 321);
            this.LabelNyukaID.Name = "LabelNyukaID";
            this.LabelNyukaID.Size = new System.Drawing.Size(99, 30);
            this.LabelNyukaID.TabIndex = 14;
            this.LabelNyukaID.Text = "入荷ID";
            // 
            // TextBoxNyukaShosaiID
            // 
            this.TextBoxNyukaShosaiID.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.TextBoxNyukaShosaiID.Location = new System.Drawing.Point(238, 237);
            this.TextBoxNyukaShosaiID.Name = "TextBoxNyukaShosaiID";
            this.TextBoxNyukaShosaiID.Size = new System.Drawing.Size(194, 37);
            this.TextBoxNyukaShosaiID.TabIndex = 13;
            // 
            // LabelNyukaShosaiID
            // 
            this.LabelNyukaShosaiID.AutoSize = true;
            this.LabelNyukaShosaiID.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.LabelNyukaShosaiID.Location = new System.Drawing.Point(63, 243);
            this.LabelNyukaShosaiID.Name = "LabelNyukaShosaiID";
            this.LabelNyukaShosaiID.Size = new System.Drawing.Size(159, 30);
            this.LabelNyukaShosaiID.TabIndex = 12;
            this.LabelNyukaShosaiID.Text = "入荷詳細ID";
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
            // 
            // F_入荷詳細登録
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 861);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.TextBoxSuryo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ComboBoxShohinName);
            this.Controls.Add(this.LabelShohinName);
            this.Controls.Add(this.TextBoxNyukaID);
            this.Controls.Add(this.LabelNyukaID);
            this.Controls.Add(this.TextBoxNyukaShosaiID);
            this.Controls.Add(this.LabelNyukaShosaiID);
            this.Controls.Add(this.ButtonTouroku);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "F_入荷詳細登録";
            this.Text = "F_入荷詳細";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button ButtonBack;
        private System.Windows.Forms.Label LabelTitle;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox TextBoxSuryo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox ComboBoxShohinName;
        private System.Windows.Forms.Label LabelShohinName;
        private System.Windows.Forms.TextBox TextBoxNyukaID;
        private System.Windows.Forms.Label LabelNyukaID;
        private System.Windows.Forms.TextBox TextBoxNyukaShosaiID;
        private System.Windows.Forms.Label LabelNyukaShosaiID;
        private System.Windows.Forms.Button ButtonTouroku;
    }
}