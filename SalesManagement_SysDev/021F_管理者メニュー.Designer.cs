﻿namespace SalesManagement_SysDev
{
    partial class F_管理者
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
            this.ButtonLogis = new System.Windows.Forms.Button();
            this.ButtonSyain = new System.Windows.Forms.Button();
            this.ButtonEigyou = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LblLoginDate = new System.Windows.Forms.Label();
            this.ButtonLogout = new System.Windows.Forms.Button();
            this.LblSoName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LblEmName = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ButtonLogis
            // 
            this.ButtonLogis.Font = new System.Drawing.Font("MS UI Gothic", 23F);
            this.ButtonLogis.Location = new System.Drawing.Point(359, 185);
            this.ButtonLogis.Name = "ButtonLogis";
            this.ButtonLogis.Size = new System.Drawing.Size(283, 289);
            this.ButtonLogis.TabIndex = 2;
            this.ButtonLogis.Text = "物流管理画面";
            this.ButtonLogis.UseVisualStyleBackColor = true;
            this.ButtonLogis.Click += new System.EventHandler(this.ButtonLogis_Click);
            // 
            // ButtonSyain
            // 
            this.ButtonSyain.Font = new System.Drawing.Font("MS UI Gothic", 23F);
            this.ButtonSyain.Location = new System.Drawing.Point(684, 185);
            this.ButtonSyain.Name = "ButtonSyain";
            this.ButtonSyain.Size = new System.Drawing.Size(275, 289);
            this.ButtonSyain.TabIndex = 3;
            this.ButtonSyain.Text = "社員管理";
            this.ButtonSyain.UseVisualStyleBackColor = true;
            this.ButtonSyain.Click += new System.EventHandler(this.ButtonSyain_Click);
            // 
            // ButtonEigyou
            // 
            this.ButtonEigyou.Font = new System.Drawing.Font("MS UI Gothic", 23F);
            this.ButtonEigyou.Location = new System.Drawing.Point(32, 185);
            this.ButtonEigyou.Name = "ButtonEigyou";
            this.ButtonEigyou.Size = new System.Drawing.Size(290, 289);
            this.ButtonEigyou.TabIndex = 1;
            this.ButtonEigyou.Text = "営業管理画面";
            this.ButtonEigyou.UseVisualStyleBackColor = true;
            this.ButtonEigyou.Click += new System.EventHandler(this.ButtonEigyou_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.LblLoginDate);
            this.panel1.Controls.Add(this.ButtonLogout);
            this.panel1.Controls.Add(this.LblSoName);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.LblEmName);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.label17);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Font = new System.Drawing.Font("MS UI Gothic", 8.25F);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(992, 142);
            this.panel1.TabIndex = 4;
            // 
            // LblLoginDate
            // 
            this.LblLoginDate.AutoSize = true;
            this.LblLoginDate.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Bold);
            this.LblLoginDate.Location = new System.Drawing.Point(144, 93);
            this.LblLoginDate.Name = "LblLoginDate";
            this.LblLoginDate.Size = new System.Drawing.Size(153, 19);
            this.LblLoginDate.TabIndex = 92;
            this.LblLoginDate.Text = "23/10/30 11:15";
            // 
            // ButtonLogout
            // 
            this.ButtonLogout.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.ButtonLogout.Location = new System.Drawing.Point(784, 45);
            this.ButtonLogout.Name = "ButtonLogout";
            this.ButtonLogout.Size = new System.Drawing.Size(174, 59);
            this.ButtonLogout.TabIndex = 1;
            this.ButtonLogout.TabStop = false;
            this.ButtonLogout.Text = "ログアウト";
            this.ButtonLogout.UseVisualStyleBackColor = true;
            this.ButtonLogout.Click += new System.EventHandler(this.ButtonLogout_Click);
            // 
            // LblSoName
            // 
            this.LblSoName.AutoSize = true;
            this.LblSoName.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Bold);
            this.LblSoName.Location = new System.Drawing.Point(144, 62);
            this.LblSoName.Name = "LblSoName";
            this.LblSoName.Size = new System.Drawing.Size(129, 19);
            this.LblSoName.TabIndex = 91;
            this.LblSoName.Text = "◯◯◯営業所";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 30F);
            this.label1.Location = new System.Drawing.Point(334, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(368, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "本社管理メニュー";
            this.label1.UseMnemonic = false;
            // 
            // LblEmName
            // 
            this.LblEmName.AutoSize = true;
            this.LblEmName.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Bold);
            this.LblEmName.Location = new System.Drawing.Point(144, 30);
            this.LblEmName.Name = "LblEmName";
            this.LblEmName.Size = new System.Drawing.Size(109, 19);
            this.LblEmName.TabIndex = 90;
            this.LblEmName.Text = "江戸川乱歩";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Bold);
            this.label14.Location = new System.Drawing.Point(9, 30);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(130, 19);
            this.label14.TabIndex = 87;
            this.label14.Text = "ログイン社員名";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Bold);
            this.label17.Location = new System.Drawing.Point(29, 93);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(110, 19);
            this.label17.TabIndex = 88;
            this.label17.Text = "ログイン日時";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Bold);
            this.label15.Location = new System.Drawing.Point(69, 62);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(69, 19);
            this.label15.TabIndex = 89;
            this.label15.Text = "営業所";
            // 
            // F_管理者
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(993, 513);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ButtonEigyou);
            this.Controls.Add(this.ButtonSyain);
            this.Controls.Add(this.ButtonLogis);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "F_管理者";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "販売管理システム_本社管理画面";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button ButtonLogis;
        private System.Windows.Forms.Button ButtonSyain;
        private System.Windows.Forms.Button ButtonEigyou;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ButtonLogout;
        private System.Windows.Forms.Label LblLoginDate;
        private System.Windows.Forms.Label LblSoName;
        private System.Windows.Forms.Label LblEmName;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label15;
    }
}