namespace SalesManagement_SysDev
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
            this.ButtonLogout = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ButtonHistory = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ButtonLogis
            // 
            this.ButtonLogis.Font = new System.Drawing.Font("MS UI Gothic", 23F);
            this.ButtonLogis.Location = new System.Drawing.Point(70, 340);
            this.ButtonLogis.Name = "ButtonLogis";
            this.ButtonLogis.Size = new System.Drawing.Size(331, 117);
            this.ButtonLogis.TabIndex = 1;
            this.ButtonLogis.Text = "物流管理画面へ";
            this.ButtonLogis.UseVisualStyleBackColor = true;
            this.ButtonLogis.Click += new System.EventHandler(this.button2_Click);
            // 
            // ButtonSyain
            // 
            this.ButtonSyain.Font = new System.Drawing.Font("MS UI Gothic", 23F);
            this.ButtonSyain.Location = new System.Drawing.Point(459, 177);
            this.ButtonSyain.Name = "ButtonSyain";
            this.ButtonSyain.Size = new System.Drawing.Size(336, 117);
            this.ButtonSyain.TabIndex = 2;
            this.ButtonSyain.Text = "社員管理";
            this.ButtonSyain.UseVisualStyleBackColor = true;
            this.ButtonSyain.Click += new System.EventHandler(this.button3_Click);
            // 
            // ButtonEigyou
            // 
            this.ButtonEigyou.Font = new System.Drawing.Font("MS UI Gothic", 23F);
            this.ButtonEigyou.Location = new System.Drawing.Point(70, 177);
            this.ButtonEigyou.Name = "ButtonEigyou";
            this.ButtonEigyou.Size = new System.Drawing.Size(331, 117);
            this.ButtonEigyou.TabIndex = 3;
            this.ButtonEigyou.Text = "営業管理画面へ";
            this.ButtonEigyou.UseVisualStyleBackColor = true;
            this.ButtonEigyou.Click += new System.EventHandler(this.button4_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.ButtonLogout);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Font = new System.Drawing.Font("MS UI Gothic", 8.25F);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(930, 142);
            this.panel1.TabIndex = 4;
            // 
            // ButtonLogout
            // 
            this.ButtonLogout.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.ButtonLogout.Location = new System.Drawing.Point(656, 36);
            this.ButtonLogout.Name = "ButtonLogout";
            this.ButtonLogout.Size = new System.Drawing.Size(165, 58);
            this.ButtonLogout.TabIndex = 1;
            this.ButtonLogout.Text = "ログアウト";
            this.ButtonLogout.UseVisualStyleBackColor = true;
            this.ButtonLogout.Click += new System.EventHandler(this.button7_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 30F);
            this.label1.Location = new System.Drawing.Point(237, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(355, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "本社　管理画面";
            this.label1.UseMnemonic = false;
            // 
            // ButtonHistory
            // 
            this.ButtonHistory.Font = new System.Drawing.Font("MS UI Gothic", 23F);
            this.ButtonHistory.Location = new System.Drawing.Point(459, 340);
            this.ButtonHistory.Name = "ButtonHistory";
            this.ButtonHistory.Size = new System.Drawing.Size(336, 117);
            this.ButtonHistory.TabIndex = 6;
            this.ButtonHistory.Text = "履歴";
            this.ButtonHistory.UseVisualStyleBackColor = true;
            this.ButtonHistory.Click += new System.EventHandler(this.button6_Click);
            // 
            // F_管理者
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 510);
            this.Controls.Add(this.ButtonHistory);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ButtonEigyou);
            this.Controls.Add(this.ButtonSyain);
            this.Controls.Add(this.ButtonLogis);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "F_管理者";
            this.Text = "Form1";
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
        private System.Windows.Forms.Button ButtonHistory;
        private System.Windows.Forms.Button ButtonLogout;
    }
}