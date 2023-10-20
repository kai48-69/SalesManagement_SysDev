namespace SalesManagement_SysDev
{
    partial class F_物流
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
            this.ButtonLogout = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ButtonZaiko = new System.Windows.Forms.Button();
            this.ButtonHattyu = new System.Windows.Forms.Button();
            this.ButtonNyuko = new System.Windows.Forms.Button();
            this.ButtonSyukko = new System.Windows.Forms.Button();
            this.ButtonSyouhin = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.ButtonLogout);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(850, 142);
            this.panel1.TabIndex = 0;
            // 
            // ButtonLogout
            // 
            this.ButtonLogout.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.ButtonLogout.Location = new System.Drawing.Point(656, 36);
            this.ButtonLogout.Name = "ButtonLogout";
            this.ButtonLogout.Size = new System.Drawing.Size(165, 58);
            this.ButtonLogout.TabIndex = 5;
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
            this.label1.Size = new System.Drawing.Size(368, 50);
            this.label1.TabIndex = 4;
            this.label1.Text = "物流管理メニュー";
            // 
            // ButtonZaiko
            // 
            this.ButtonZaiko.Font = new System.Drawing.Font("MS UI Gothic", 23F);
            this.ButtonZaiko.Location = new System.Drawing.Point(577, 341);
            this.ButtonZaiko.Name = "ButtonZaiko";
            this.ButtonZaiko.Size = new System.Drawing.Size(251, 111);
            this.ButtonZaiko.TabIndex = 3;
            this.ButtonZaiko.Text = "在庫管理";
            this.ButtonZaiko.UseVisualStyleBackColor = true;
            this.ButtonZaiko.Click += new System.EventHandler(this.button3_Click);
            // 
            // ButtonHattyu
            // 
            this.ButtonHattyu.Font = new System.Drawing.Font("MS UI Gothic", 23F);
            this.ButtonHattyu.Location = new System.Drawing.Point(25, 196);
            this.ButtonHattyu.Name = "ButtonHattyu";
            this.ButtonHattyu.Size = new System.Drawing.Size(243, 256);
            this.ButtonHattyu.TabIndex = 4;
            this.ButtonHattyu.Text = "発注管理";
            this.ButtonHattyu.UseVisualStyleBackColor = true;
            this.ButtonHattyu.Click += new System.EventHandler(this.button4_Click);
            // 
            // ButtonNyuko
            // 
            this.ButtonNyuko.Font = new System.Drawing.Font("MS UI Gothic", 23F);
            this.ButtonNyuko.Location = new System.Drawing.Point(305, 196);
            this.ButtonNyuko.Name = "ButtonNyuko";
            this.ButtonNyuko.Size = new System.Drawing.Size(243, 111);
            this.ButtonNyuko.TabIndex = 5;
            this.ButtonNyuko.Text = "入庫管理";
            this.ButtonNyuko.UseVisualStyleBackColor = true;
            this.ButtonNyuko.Click += new System.EventHandler(this.button5_Click);
            // 
            // ButtonSyukko
            // 
            this.ButtonSyukko.Font = new System.Drawing.Font("MS UI Gothic", 23F);
            this.ButtonSyukko.Location = new System.Drawing.Point(305, 341);
            this.ButtonSyukko.Name = "ButtonSyukko";
            this.ButtonSyukko.Size = new System.Drawing.Size(243, 111);
            this.ButtonSyukko.TabIndex = 6;
            this.ButtonSyukko.Text = "出庫管理";
            this.ButtonSyukko.UseVisualStyleBackColor = true;
            this.ButtonSyukko.Click += new System.EventHandler(this.button6_Click);
            // 
            // ButtonSyouhin
            // 
            this.ButtonSyouhin.Font = new System.Drawing.Font("MS UI Gothic", 23F);
            this.ButtonSyouhin.Location = new System.Drawing.Point(577, 196);
            this.ButtonSyouhin.Name = "ButtonSyouhin";
            this.ButtonSyouhin.Size = new System.Drawing.Size(243, 111);
            this.ButtonSyouhin.TabIndex = 7;
            this.ButtonSyouhin.Text = "商品管理";
            this.ButtonSyouhin.UseVisualStyleBackColor = true;
            this.ButtonSyouhin.Click += new System.EventHandler(this.button2_Click);
            // 
            // F_物流
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 510);
            this.Controls.Add(this.ButtonSyouhin);
            this.Controls.Add(this.ButtonSyukko);
            this.Controls.Add(this.ButtonNyuko);
            this.Controls.Add(this.ButtonHattyu);
            this.Controls.Add(this.ButtonZaiko);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "F_物流";
            this.Text = "Form2";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ButtonLogout;
        private System.Windows.Forms.Button ButtonZaiko;
        private System.Windows.Forms.Button ButtonHattyu;
        private System.Windows.Forms.Button ButtonNyuko;
        private System.Windows.Forms.Button ButtonSyukko;
        private System.Windows.Forms.Button ButtonSyouhin;
    }
}