﻿namespace SalesManagement_SysDev
{
    partial class F_営業
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
            this.ButtonSyukka = new System.Windows.Forms.Button();
            this.ButtonNyuka = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LblLoginDate = new System.Windows.Forms.Label();
            this.LblSoName = new System.Windows.Forms.Label();
            this.LblEmName = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ButtonLogout = new System.Windows.Forms.Button();
            this.ButtonTyumon = new System.Windows.Forms.Button();
            this.ButtonJutyuu = new System.Windows.Forms.Button();
            this.ButtonKokyaku = new System.Windows.Forms.Button();
            this.ButtonUriage = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ButtonSyukka
            // 
            this.ButtonSyukka.Font = new System.Drawing.Font("MS UI Gothic", 23F);
            this.ButtonSyukka.Location = new System.Drawing.Point(338, 346);
            this.ButtonSyukka.Name = "ButtonSyukka";
            this.ButtonSyukka.Size = new System.Drawing.Size(242, 111);
            this.ButtonSyukka.TabIndex = 4;
            this.ButtonSyukka.Text = "出荷管理";
            this.ButtonSyukka.UseVisualStyleBackColor = true;
            this.ButtonSyukka.Click += new System.EventHandler(this.ButtonSyukka_Click);
            // 
            // ButtonNyuka
            // 
            this.ButtonNyuka.Font = new System.Drawing.Font("MS UI Gothic", 23F);
            this.ButtonNyuka.Location = new System.Drawing.Point(63, 346);
            this.ButtonNyuka.Name = "ButtonNyuka";
            this.ButtonNyuka.Size = new System.Drawing.Size(238, 111);
            this.ButtonNyuka.TabIndex = 3;
            this.ButtonNyuka.Text = "入荷管理";
            this.ButtonNyuka.UseVisualStyleBackColor = true;
            this.ButtonNyuka.Click += new System.EventHandler(this.ButtonNyuka_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.LblLoginDate);
            this.panel1.Controls.Add(this.LblSoName);
            this.panel1.Controls.Add(this.LblEmName);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.label17);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.ButtonLogout);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1026, 142);
            this.panel1.TabIndex = 4;
            // 
            // LblLoginDate
            // 
            this.LblLoginDate.AutoSize = true;
            this.LblLoginDate.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Bold);
            this.LblLoginDate.Location = new System.Drawing.Point(160, 94);
            this.LblLoginDate.Name = "LblLoginDate";
            this.LblLoginDate.Size = new System.Drawing.Size(175, 19);
            this.LblLoginDate.TabIndex = 92;
            this.LblLoginDate.Text = "2023/10/30 11:15";
            // 
            // LblSoName
            // 
            this.LblSoName.AutoSize = true;
            this.LblSoName.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Bold);
            this.LblSoName.Location = new System.Drawing.Point(160, 63);
            this.LblSoName.Name = "LblSoName";
            this.LblSoName.Size = new System.Drawing.Size(129, 19);
            this.LblSoName.TabIndex = 91;
            this.LblSoName.Text = "◯◯◯営業所";
            // 
            // LblEmName
            // 
            this.LblEmName.AutoSize = true;
            this.LblEmName.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Bold);
            this.LblEmName.Location = new System.Drawing.Point(160, 31);
            this.LblEmName.Name = "LblEmName";
            this.LblEmName.Size = new System.Drawing.Size(109, 19);
            this.LblEmName.TabIndex = 90;
            this.LblEmName.Text = "江戸川乱歩";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Bold);
            this.label14.Location = new System.Drawing.Point(27, 31);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(130, 19);
            this.label14.TabIndex = 87;
            this.label14.Text = "ログイン社員名";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Bold);
            this.label15.Location = new System.Drawing.Point(86, 63);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(69, 19);
            this.label15.TabIndex = 89;
            this.label15.Text = "営業所";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("MS UI Gothic", 11F, System.Drawing.FontStyle.Bold);
            this.label17.Location = new System.Drawing.Point(49, 94);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(110, 19);
            this.label17.TabIndex = 88;
            this.label17.Text = "ログイン日時";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 30F);
            this.label1.Location = new System.Drawing.Point(360, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(368, 50);
            this.label1.TabIndex = 3;
            this.label1.Text = "営業管理メニュー";
            // 
            // ButtonLogout
            // 
            this.ButtonLogout.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.ButtonLogout.Location = new System.Drawing.Point(794, 45);
            this.ButtonLogout.Name = "ButtonLogout";
            this.ButtonLogout.Size = new System.Drawing.Size(165, 58);
            this.ButtonLogout.TabIndex = 2;
            this.ButtonLogout.TabStop = false;
            this.ButtonLogout.Text = "ログアウト";
            this.ButtonLogout.UseVisualStyleBackColor = true;
            this.ButtonLogout.Click += new System.EventHandler(this.ButtonLogout_Click);
            // 
            // ButtonTyumon
            // 
            this.ButtonTyumon.Font = new System.Drawing.Font("MS UI Gothic", 23F);
            this.ButtonTyumon.Location = new System.Drawing.Point(338, 192);
            this.ButtonTyumon.Name = "ButtonTyumon";
            this.ButtonTyumon.Size = new System.Drawing.Size(238, 111);
            this.ButtonTyumon.TabIndex = 2;
            this.ButtonTyumon.Text = "注文管理";
            this.ButtonTyumon.UseVisualStyleBackColor = true;
            this.ButtonTyumon.Click += new System.EventHandler(this.ButtonTyumon_Click);
            // 
            // ButtonJutyuu
            // 
            this.ButtonJutyuu.Font = new System.Drawing.Font("MS UI Gothic", 23F);
            this.ButtonJutyuu.Location = new System.Drawing.Point(63, 195);
            this.ButtonJutyuu.Name = "ButtonJutyuu";
            this.ButtonJutyuu.Size = new System.Drawing.Size(242, 111);
            this.ButtonJutyuu.TabIndex = 1;
            this.ButtonJutyuu.Text = "受注管理";
            this.ButtonJutyuu.UseVisualStyleBackColor = true;
            this.ButtonJutyuu.Click += new System.EventHandler(this.ButtonJutyuu_Click);
            // 
            // ButtonKokyaku
            // 
            this.ButtonKokyaku.Font = new System.Drawing.Font("MS UI Gothic", 23F);
            this.ButtonKokyaku.Location = new System.Drawing.Point(699, 192);
            this.ButtonKokyaku.Name = "ButtonKokyaku";
            this.ButtonKokyaku.Size = new System.Drawing.Size(238, 111);
            this.ButtonKokyaku.TabIndex = 5;
            this.ButtonKokyaku.Text = "顧客管理";
            this.ButtonKokyaku.UseVisualStyleBackColor = true;
            this.ButtonKokyaku.Click += new System.EventHandler(this.ButtonKokyaku_Click);
            // 
            // ButtonUriage
            // 
            this.ButtonUriage.Font = new System.Drawing.Font("MS UI Gothic", 23F);
            this.ButtonUriage.Location = new System.Drawing.Point(699, 355);
            this.ButtonUriage.Name = "ButtonUriage";
            this.ButtonUriage.Size = new System.Drawing.Size(238, 111);
            this.ButtonUriage.TabIndex = 6;
            this.ButtonUriage.Text = "売上管理";
            this.ButtonUriage.UseVisualStyleBackColor = true;
            this.ButtonUriage.Click += new System.EventHandler(this.ButtonUriage_Click);
            // 
            // F_営業
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1026, 513);
            this.Controls.Add(this.ButtonUriage);
            this.Controls.Add(this.ButtonKokyaku);
            this.Controls.Add(this.ButtonJutyuu);
            this.Controls.Add(this.ButtonTyumon);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ButtonNyuka);
            this.Controls.Add(this.ButtonSyukka);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "F_営業";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "販売管理システム_営業管理画面";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button ButtonSyukka;
        private System.Windows.Forms.Button ButtonNyuka;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ButtonLogout;
        private System.Windows.Forms.Button ButtonTyumon;
        private System.Windows.Forms.Button ButtonJutyuu;
        private System.Windows.Forms.Button ButtonKokyaku;
        private System.Windows.Forms.Button ButtonUriage;
        private System.Windows.Forms.Label LblLoginDate;
        private System.Windows.Forms.Label LblSoName;
        private System.Windows.Forms.Label LblEmName;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label17;
    }
}