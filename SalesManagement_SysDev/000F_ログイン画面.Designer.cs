﻿namespace SalesManagement_SysDev
{
    partial class F_ログイン画面
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
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(613, 90);
            this.panel1.TabIndex = 13;
            // 
            // ButtonExit
            // 
            this.ButtonExit.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.ButtonExit.Location = new System.Drawing.Point(472, 26);
            this.ButtonExit.Margin = new System.Windows.Forms.Padding(4);
            this.ButtonExit.Name = "ButtonExit";
            this.ButtonExit.Size = new System.Drawing.Size(101, 46);
            this.ButtonExit.TabIndex = 4;
            this.ButtonExit.Text = "終了";
            this.ButtonExit.UseVisualStyleBackColor = true;
            this.ButtonExit.Click += new System.EventHandler(this.ButtonExit_Click);
            // 
            // Lbl_tag
            // 
            this.Lbl_tag.AutoSize = true;
            this.Lbl_tag.Font = new System.Drawing.Font("MS UI Gothic", 30F);
            this.Lbl_tag.Location = new System.Drawing.Point(27, 22);
            this.Lbl_tag.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_tag.Name = "Lbl_tag";
            this.Lbl_tag.Size = new System.Drawing.Size(380, 50);
            this.Lbl_tag.TabIndex = 1;
            this.Lbl_tag.Text = "販売管理システム";
            this.Lbl_tag.DoubleClick += new System.EventHandler(this.Lbl_tag_DoubleClick);
            // 
            // ButtonLogin
            // 
            this.ButtonLogin.Font = new System.Drawing.Font("MS UI Gothic", 30F);
            this.ButtonLogin.Location = new System.Drawing.Point(96, 305);
            this.ButtonLogin.Margin = new System.Windows.Forms.Padding(4);
            this.ButtonLogin.Name = "ButtonLogin";
            this.ButtonLogin.Size = new System.Drawing.Size(437, 61);
            this.ButtonLogin.TabIndex = 3;
            this.ButtonLogin.Text = "ログイン";
            this.ButtonLogin.UseVisualStyleBackColor = true;
            this.ButtonLogin.Click += new System.EventHandler(this.ButtonLogin_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 25F);
            this.label2.Location = new System.Drawing.Point(11, 221);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 42);
            this.label2.TabIndex = 12;
            this.label2.Text = "パスワード";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 25F);
            this.label1.Location = new System.Drawing.Point(56, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 42);
            this.label1.TabIndex = 11;
            this.label1.Text = "社員ID";
            // 
            // TextboxPW
            // 
            this.TextboxPW.Font = new System.Drawing.Font("MS UI Gothic", 25F);
            this.TextboxPW.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.TextboxPW.Location = new System.Drawing.Point(243, 218);
            this.TextboxPW.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TextboxPW.MaxLength = 20;
            this.TextboxPW.Name = "TextboxPW";
            this.TextboxPW.PasswordChar = '*';
            this.TextboxPW.Size = new System.Drawing.Size(329, 49);
            this.TextboxPW.TabIndex = 2;
            // 
            // TextboxShainID
            // 
            this.TextboxShainID.CausesValidation = false;
            this.TextboxShainID.Font = new System.Drawing.Font("MS UI Gothic", 25F);
            this.TextboxShainID.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.TextboxShainID.Location = new System.Drawing.Point(243, 131);
            this.TextboxShainID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TextboxShainID.MaxLength = 20;
            this.TextboxShainID.Name = "TextboxShainID";
            this.TextboxShainID.Size = new System.Drawing.Size(329, 49);
            this.TextboxShainID.TabIndex = 1;
            // 
            // F_ログイン画面
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(607, 398);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ButtonLogin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TextboxPW);
            this.Controls.Add(this.TextboxShainID);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "F_ログイン画面";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
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