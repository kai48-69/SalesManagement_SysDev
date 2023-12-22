namespace SalesManagement_SysDev
{
    partial class F_PW新規登録
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
            this.Lbl_tag = new System.Windows.Forms.Label();
            this.ButtonRegis = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TextboxPW = new System.Windows.Forms.TextBox();
            this.TextboxConPW = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.LblSyainName = new System.Windows.Forms.Label();
            this.LblSyainID = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.ButtonBack);
            this.panel1.Controls.Add(this.Lbl_tag);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(795, 90);
            this.panel1.TabIndex = 13;
            // 
            // ButtonBack
            // 
            this.ButtonBack.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.ButtonBack.Location = new System.Drawing.Point(564, 22);
            this.ButtonBack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ButtonBack.Name = "ButtonBack";
            this.ButtonBack.Size = new System.Drawing.Size(151, 50);
            this.ButtonBack.TabIndex = 4;
            this.ButtonBack.Text = "戻る";
            this.ButtonBack.UseVisualStyleBackColor = true;
            this.ButtonBack.Click += new System.EventHandler(this.ButtonBack_Click);
            // 
            // Lbl_tag
            // 
            this.Lbl_tag.AutoSize = true;
            this.Lbl_tag.Font = new System.Drawing.Font("MS UI Gothic", 30F);
            this.Lbl_tag.Location = new System.Drawing.Point(16, 22);
            this.Lbl_tag.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_tag.Name = "Lbl_tag";
            this.Lbl_tag.Size = new System.Drawing.Size(521, 63);
            this.Lbl_tag.TabIndex = 1;
            this.Lbl_tag.Text = "パスワード新規登録";
            // 
            // ButtonRegis
            // 
            this.ButtonRegis.Font = new System.Drawing.Font("MS UI Gothic", 30F);
            this.ButtonRegis.Location = new System.Drawing.Point(134, 497);
            this.ButtonRegis.Margin = new System.Windows.Forms.Padding(4);
            this.ButtonRegis.Name = "ButtonRegis";
            this.ButtonRegis.Size = new System.Drawing.Size(467, 61);
            this.ButtonRegis.TabIndex = 3;
            this.ButtonRegis.Text = "登録";
            this.ButtonRegis.UseVisualStyleBackColor = true;
            this.ButtonRegis.Click += new System.EventHandler(this.ButtonRegis_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 25F);
            this.label2.Location = new System.Drawing.Point(115, 306);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(223, 42);
            this.label2.TabIndex = 12;
            this.label2.Text = "新パスワード";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 25F);
            this.label1.Location = new System.Drawing.Point(194, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 42);
            this.label1.TabIndex = 11;
            this.label1.Text = "社員ID";
            // 
            // TextboxPW
            // 
            this.TextboxPW.Font = new System.Drawing.Font("MS UI Gothic", 25F);
            this.TextboxPW.Location = new System.Drawing.Point(380, 302);
            this.TextboxPW.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TextboxPW.MaxLength = 10;
            this.TextboxPW.Name = "TextboxPW";
            this.TextboxPW.PasswordChar = '*';
            this.TextboxPW.Size = new System.Drawing.Size(321, 49);
            this.TextboxPW.TabIndex = 1;
            // 
            // TextboxConPW
            // 
            this.TextboxConPW.Font = new System.Drawing.Font("MS UI Gothic", 25F);
            this.TextboxConPW.Location = new System.Drawing.Point(380, 388);
            this.TextboxConPW.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TextboxConPW.MaxLength = 10;
            this.TextboxConPW.Name = "TextboxConPW";
            this.TextboxConPW.PasswordChar = '*';
            this.TextboxConPW.Size = new System.Drawing.Size(321, 49);
            this.TextboxConPW.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 25F);
            this.label3.Location = new System.Drawing.Point(15, 397);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(333, 42);
            this.label3.TabIndex = 15;
            this.label3.Text = "新パスワード(確認)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS UI Gothic", 25F);
            this.label4.Location = new System.Drawing.Point(189, 211);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 42);
            this.label4.TabIndex = 17;
            this.label4.Text = "社員名";
            // 
            // LblSyainName
            // 
            this.LblSyainName.AutoSize = true;
            this.LblSyainName.Font = new System.Drawing.Font("MS UI Gothic", 25F);
            this.LblSyainName.Location = new System.Drawing.Point(373, 211);
            this.LblSyainName.Name = "LblSyainName";
            this.LblSyainName.Size = new System.Drawing.Size(228, 42);
            this.LblSyainName.TabIndex = 19;
            this.LblSyainName.Text = "〇〇〇〇〇";
            // 
            // LblSyainID
            // 
            this.LblSyainID.AutoSize = true;
            this.LblSyainID.Font = new System.Drawing.Font("MS UI Gothic", 25F);
            this.LblSyainID.Location = new System.Drawing.Point(373, 132);
            this.LblSyainID.Name = "LblSyainID";
            this.LblSyainID.Size = new System.Drawing.Size(186, 42);
            this.LblSyainID.TabIndex = 20;
            this.LblSyainID.Text = "〇〇〇〇";
            // 
            // F_PW新規登録
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 602);
            this.Controls.Add(this.LblSyainID);
            this.Controls.Add(this.LblSyainName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TextboxConPW);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ButtonRegis);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TextboxPW);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "F_PW新規登録";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "販売管理システム_パスワード新規登録画面";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Lbl_tag;
        private System.Windows.Forms.Button ButtonRegis;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TextboxPW;
        private System.Windows.Forms.TextBox TextboxConPW;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button ButtonBack;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label LblSyainName;
        private System.Windows.Forms.Label LblSyainID;
    }
}