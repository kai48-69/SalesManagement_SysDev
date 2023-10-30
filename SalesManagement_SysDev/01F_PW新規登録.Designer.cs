namespace SalesManagement_SysDev
{
    partial class _01F_PW新規登録
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
            this.ButtonExit = new System.Windows.Forms.Button();
            this.Lbl_tag = new System.Windows.Forms.Label();
            this.ButtonLogin = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TextboxPW = new System.Windows.Forms.TextBox();
            this.TextboxShainID = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.ButtonExit);
            this.panel1.Controls.Add(this.Lbl_tag);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(513, 72);
            this.panel1.TabIndex = 13;
            // 
            // ButtonExit
            // 
            this.ButtonExit.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.ButtonExit.Location = new System.Drawing.Point(427, 18);
            this.ButtonExit.Name = "ButtonExit";
            this.ButtonExit.Size = new System.Drawing.Size(76, 37);
            this.ButtonExit.TabIndex = 4;
            this.ButtonExit.Text = "戻る";
            this.ButtonExit.UseVisualStyleBackColor = true;
            // 
            // Lbl_tag
            // 
            this.Lbl_tag.AutoSize = true;
            this.Lbl_tag.Font = new System.Drawing.Font("MS UI Gothic", 30F);
            this.Lbl_tag.Location = new System.Drawing.Point(10, 18);
            this.Lbl_tag.Name = "Lbl_tag";
            this.Lbl_tag.Size = new System.Drawing.Size(333, 40);
            this.Lbl_tag.TabIndex = 1;
            this.Lbl_tag.Text = "パスワード新規登録";
            // 
            // ButtonLogin
            // 
            this.ButtonLogin.Font = new System.Drawing.Font("MS UI Gothic", 30F);
            this.ButtonLogin.Location = new System.Drawing.Point(104, 254);
            this.ButtonLogin.Name = "ButtonLogin";
            this.ButtonLogin.Size = new System.Drawing.Size(328, 49);
            this.ButtonLogin.TabIndex = 10;
            this.ButtonLogin.Text = "登録";
            this.ButtonLogin.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 25F);
            this.label2.Location = new System.Drawing.Point(5, 175);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(216, 34);
            this.label2.TabIndex = 12;
            this.label2.Text = "新規パスワード";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 25F);
            this.label1.Location = new System.Drawing.Point(108, 105);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 34);
            this.label1.TabIndex = 11;
            this.label1.Text = "社員ID";
            // 
            // TextboxPW
            // 
            this.TextboxPW.Font = new System.Drawing.Font("MS UI Gothic", 25F);
            this.TextboxPW.Location = new System.Drawing.Point(243, 172);
            this.TextboxPW.Margin = new System.Windows.Forms.Padding(2);
            this.TextboxPW.Name = "TextboxPW";
            this.TextboxPW.Size = new System.Drawing.Size(242, 41);
            this.TextboxPW.TabIndex = 9;
            // 
            // TextboxShainID
            // 
            this.TextboxShainID.Font = new System.Drawing.Font("MS UI Gothic", 25F);
            this.TextboxShainID.Location = new System.Drawing.Point(243, 102);
            this.TextboxShainID.Margin = new System.Windows.Forms.Padding(2);
            this.TextboxShainID.Name = "TextboxShainID";
            this.TextboxShainID.Size = new System.Drawing.Size(242, 41);
            this.TextboxShainID.TabIndex = 8;
            // 
            // _01F_PW新規登録
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 336);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ButtonLogin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TextboxPW);
            this.Controls.Add(this.TextboxShainID);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "_01F_PW新規登録";
            this.Text = "_01F_PW新規登録";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button ButtonExit;
        private System.Windows.Forms.Label Lbl_tag;
        private System.Windows.Forms.Button ButtonLogin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TextboxPW;
        private System.Windows.Forms.TextBox TextboxShainID;
    }
}