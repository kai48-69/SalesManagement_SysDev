namespace SalesManagement_SysDev
{
    partial class F_ログイン画面
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_CleateDabase = new System.Windows.Forms.Button();
            this.Lbl_tag = new System.Windows.Forms.Label();
            this.btn_InsertSampleData = new System.Windows.Forms.Button();
            this.TextboxShainID = new System.Windows.Forms.TextBox();
            this.TextboxPW = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ButtonLogin = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ButtonExit = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_CleateDabase
            // 
            this.btn_CleateDabase.Location = new System.Drawing.Point(661, 319);
            this.btn_CleateDabase.Name = "btn_CleateDabase";
            this.btn_CleateDabase.Size = new System.Drawing.Size(106, 49);
            this.btn_CleateDabase.TabIndex = 0;
            this.btn_CleateDabase.TabStop = false;
            this.btn_CleateDabase.Text = "データベース生成";
            this.btn_CleateDabase.UseVisualStyleBackColor = true;
            this.btn_CleateDabase.Click += new System.EventHandler(this.btn_CleateDabase_Click);
            // 
            // Lbl_tag
            // 
            this.Lbl_tag.AutoSize = true;
            this.Lbl_tag.Font = new System.Drawing.Font("MS UI Gothic", 30F);
            this.Lbl_tag.Location = new System.Drawing.Point(10, 18);
            this.Lbl_tag.Name = "Lbl_tag";
            this.Lbl_tag.Size = new System.Drawing.Size(305, 40);
            this.Lbl_tag.TabIndex = 1;
            this.Lbl_tag.Text = "販売管理システム";
            this.Lbl_tag.Click += new System.EventHandler(this.Lbl_tag_Click);
            // 
            // btn_InsertSampleData
            // 
            this.btn_InsertSampleData.Location = new System.Drawing.Point(661, 389);
            this.btn_InsertSampleData.Name = "btn_InsertSampleData";
            this.btn_InsertSampleData.Size = new System.Drawing.Size(106, 49);
            this.btn_InsertSampleData.TabIndex = 0;
            this.btn_InsertSampleData.TabStop = false;
            this.btn_InsertSampleData.Text = "サンプルデータ登録";
            this.btn_InsertSampleData.UseVisualStyleBackColor = true;
            this.btn_InsertSampleData.Click += new System.EventHandler(this.btn_InsertSampleData_Click);
            // 
            // TextboxShainID
            // 
            this.TextboxShainID.Font = new System.Drawing.Font("MS UI Gothic", 25F);
            this.TextboxShainID.Location = new System.Drawing.Point(225, 102);
            this.TextboxShainID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TextboxShainID.Name = "TextboxShainID";
            this.TextboxShainID.Size = new System.Drawing.Size(242, 41);
            this.TextboxShainID.TabIndex = 1;
            this.TextboxShainID.TextChanged += new System.EventHandler(this.TextboxShainID_TextChanged);
            // 
            // TextboxPW
            // 
            this.TextboxPW.Font = new System.Drawing.Font("MS UI Gothic", 25F);
            this.TextboxPW.Location = new System.Drawing.Point(225, 172);
            this.TextboxPW.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TextboxPW.Name = "TextboxPW";
            this.TextboxPW.Size = new System.Drawing.Size(242, 41);
            this.TextboxPW.TabIndex = 2;
            this.TextboxPW.TextChanged += new System.EventHandler(this.TextboxPW_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 25F);
            this.label1.Location = new System.Drawing.Point(75, 108);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 34);
            this.label1.TabIndex = 4;
            this.label1.Text = "社員ID";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 25F);
            this.label2.Location = new System.Drawing.Point(44, 180);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 34);
            this.label2.TabIndex = 5;
            this.label2.Text = "パスワード";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // ButtonLogin
            // 
            this.ButtonLogin.Font = new System.Drawing.Font("MS UI Gothic", 30F);
            this.ButtonLogin.Location = new System.Drawing.Point(104, 254);
            this.ButtonLogin.Name = "ButtonLogin";
            this.ButtonLogin.Size = new System.Drawing.Size(328, 49);
            this.ButtonLogin.TabIndex = 3;
            this.ButtonLogin.Text = "ログイン";
            this.ButtonLogin.UseVisualStyleBackColor = true;
            this.ButtonLogin.Click += new System.EventHandler(this.ButtonLogin_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.ButtonExit);
            this.panel1.Controls.Add(this.Lbl_tag);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(513, 72);
            this.panel1.TabIndex = 7;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // ButtonExit
            // 
            this.ButtonExit.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.ButtonExit.Location = new System.Drawing.Point(427, 18);
            this.ButtonExit.Name = "ButtonExit";
            this.ButtonExit.Size = new System.Drawing.Size(76, 37);
            this.ButtonExit.TabIndex = 4;
            this.ButtonExit.Text = "終了";
            this.ButtonExit.UseVisualStyleBackColor = true;
            this.ButtonExit.Click += new System.EventHandler(this.ButtonExit_Click);
            // 
            // F_ログイン画面
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
            this.Controls.Add(this.btn_InsertSampleData);
            this.Controls.Add(this.btn_CleateDabase);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "F_ログイン画面";
            this.Text = "販売管理システムログイン画面";
            this.Load += new System.EventHandler(this.F_ログイン画面_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_CleateDabase;
        private System.Windows.Forms.Label Lbl_tag;
        private System.Windows.Forms.Button btn_InsertSampleData;
        private System.Windows.Forms.TextBox TextboxShainID;
        private System.Windows.Forms.TextBox TextboxPW;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ButtonLogin;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button ButtonExit;
    }
}

