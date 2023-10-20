namespace SalesManagement_SysDev
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
            this.ButtonSyukka.Location = new System.Drawing.Point(26, 351);
            this.ButtonSyukka.Name = "ButtonSyukka";
            this.ButtonSyukka.Size = new System.Drawing.Size(242, 111);
            this.ButtonSyukka.TabIndex = 2;
            this.ButtonSyukka.Text = "出荷管理";
            this.ButtonSyukka.UseVisualStyleBackColor = true;
            this.ButtonSyukka.Click += new System.EventHandler(this.button3_Click);
            // 
            // ButtonNyuka
            // 
            this.ButtonNyuka.Font = new System.Drawing.Font("MS UI Gothic", 23F);
            this.ButtonNyuka.Location = new System.Drawing.Point(301, 351);
            this.ButtonNyuka.Name = "ButtonNyuka";
            this.ButtonNyuka.Size = new System.Drawing.Size(238, 111);
            this.ButtonNyuka.TabIndex = 3;
            this.ButtonNyuka.Text = "入荷管理";
            this.ButtonNyuka.UseVisualStyleBackColor = true;
            this.ButtonNyuka.Click += new System.EventHandler(this.button4_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.ButtonLogout);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(850, 142);
            this.panel1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 30F);
            this.label1.Location = new System.Drawing.Point(237, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(368, 50);
            this.label1.TabIndex = 3;
            this.label1.Text = "営業管理メニュー";
            // 
            // ButtonLogout
            // 
            this.ButtonLogout.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.ButtonLogout.Location = new System.Drawing.Point(656, 35);
            this.ButtonLogout.Name = "ButtonLogout";
            this.ButtonLogout.Size = new System.Drawing.Size(165, 58);
            this.ButtonLogout.TabIndex = 2;
            this.ButtonLogout.Text = "ログアウト";
            this.ButtonLogout.UseVisualStyleBackColor = true;
            this.ButtonLogout.Click += new System.EventHandler(this.button7_Click);
            // 
            // ButtonTyumon
            // 
            this.ButtonTyumon.Font = new System.Drawing.Font("MS UI Gothic", 23F);
            this.ButtonTyumon.Location = new System.Drawing.Point(301, 188);
            this.ButtonTyumon.Name = "ButtonTyumon";
            this.ButtonTyumon.Size = new System.Drawing.Size(238, 111);
            this.ButtonTyumon.TabIndex = 4;
            this.ButtonTyumon.Text = "注文管理";
            this.ButtonTyumon.UseVisualStyleBackColor = true;
            this.ButtonTyumon.Click += new System.EventHandler(this.button2_Click);
            // 
            // ButtonJutyuu
            // 
            this.ButtonJutyuu.Font = new System.Drawing.Font("MS UI Gothic", 23F);
            this.ButtonJutyuu.Location = new System.Drawing.Point(26, 191);
            this.ButtonJutyuu.Name = "ButtonJutyuu";
            this.ButtonJutyuu.Size = new System.Drawing.Size(242, 111);
            this.ButtonJutyuu.TabIndex = 5;
            this.ButtonJutyuu.Text = "受注管理";
            this.ButtonJutyuu.UseVisualStyleBackColor = true;
            this.ButtonJutyuu.Click += new System.EventHandler(this.button1_Click);
            // 
            // ButtonKokyaku
            // 
            this.ButtonKokyaku.Font = new System.Drawing.Font("MS UI Gothic", 23F);
            this.ButtonKokyaku.Location = new System.Drawing.Point(577, 188);
            this.ButtonKokyaku.Name = "ButtonKokyaku";
            this.ButtonKokyaku.Size = new System.Drawing.Size(238, 111);
            this.ButtonKokyaku.TabIndex = 6;
            this.ButtonKokyaku.Text = "顧客管理";
            this.ButtonKokyaku.UseVisualStyleBackColor = true;
            this.ButtonKokyaku.Click += new System.EventHandler(this.button5_Click);
            // 
            // ButtonUriage
            // 
            this.ButtonUriage.Font = new System.Drawing.Font("MS UI Gothic", 23F);
            this.ButtonUriage.Location = new System.Drawing.Point(577, 351);
            this.ButtonUriage.Name = "ButtonUriage";
            this.ButtonUriage.Size = new System.Drawing.Size(238, 111);
            this.ButtonUriage.TabIndex = 7;
            this.ButtonUriage.Text = "売上管理";
            this.ButtonUriage.UseVisualStyleBackColor = true;
            this.ButtonUriage.Click += new System.EventHandler(this.button6_Click);
            // 
            // F_営業
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 510);
            this.Controls.Add(this.ButtonUriage);
            this.Controls.Add(this.ButtonKokyaku);
            this.Controls.Add(this.ButtonJutyuu);
            this.Controls.Add(this.ButtonTyumon);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ButtonNyuka);
            this.Controls.Add(this.ButtonSyukka);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "F_営業";
            this.Text = "Form1";
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
    }
}