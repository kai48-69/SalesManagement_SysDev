namespace SalesManagement_SysDev
{
    partial class F_在庫管理
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
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.TextboxShouhinID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.ButtonReset = new System.Windows.Forms.Button();
            this.RadioKensaku = new System.Windows.Forms.RadioButton();
            this.ButtonExe = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.ButtonBack);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(782, 142);
            this.panel1.TabIndex = 58;
            // 
            // ButtonBack
            // 
            this.ButtonBack.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.ButtonBack.Location = new System.Drawing.Point(520, 41);
            this.ButtonBack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ButtonBack.Name = "ButtonBack";
            this.ButtonBack.Size = new System.Drawing.Size(165, 58);
            this.ButtonBack.TabIndex = 5;
            this.ButtonBack.Text = "戻る";
            this.ButtonBack.UseVisualStyleBackColor = true;
            this.ButtonBack.Click += new System.EventHandler(this.ButtonBack_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("MS UI Gothic", 30F);
            this.label6.Location = new System.Drawing.Point(234, 49);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(222, 50);
            this.label6.TabIndex = 4;
            this.label6.Text = "在庫管理";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.label5.Location = new System.Drawing.Point(397, 342);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 25);
            this.label5.TabIndex = 59;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(53, 353);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(631, 295);
            this.dataGridView1.TabIndex = 57;
            // 
            // TextboxShouhinID
            // 
            this.TextboxShouhinID.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.TextboxShouhinID.Location = new System.Drawing.Point(144, 284);
            this.TextboxShouhinID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TextboxShouhinID.Name = "TextboxShouhinID";
            this.TextboxShouhinID.Size = new System.Drawing.Size(156, 32);
            this.TextboxShouhinID.TabIndex = 56;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.label3.Location = new System.Drawing.Point(54, 289);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 25);
            this.label3.TabIndex = 52;
            this.label3.Text = "商品ID";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.checkBox1.Location = new System.Drawing.Point(462, 289);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(222, 29);
            this.checkBox1.TabIndex = 60;
            this.checkBox1.Text = "不足状態絞り込み";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // ButtonReset
            // 
            this.ButtonReset.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.ButtonReset.Location = new System.Drawing.Point(189, 175);
            this.ButtonReset.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ButtonReset.Name = "ButtonReset";
            this.ButtonReset.Size = new System.Drawing.Size(165, 42);
            this.ButtonReset.TabIndex = 101;
            this.ButtonReset.Text = "入力リセット";
            this.ButtonReset.UseVisualStyleBackColor = true;
            this.ButtonReset.Click += new System.EventHandler(this.ButtonReset_Click);
            // 
            // RadioKensaku
            // 
            this.RadioKensaku.AutoSize = true;
            this.RadioKensaku.Checked = true;
            this.RadioKensaku.Font = new System.Drawing.Font("MS UI Gothic", 18F);
            this.RadioKensaku.Location = new System.Drawing.Point(59, 177);
            this.RadioKensaku.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RadioKensaku.Name = "RadioKensaku";
            this.RadioKensaku.Size = new System.Drawing.Size(94, 34);
            this.RadioKensaku.TabIndex = 99;
            this.RadioKensaku.TabStop = true;
            this.RadioKensaku.Text = "検索";
            this.RadioKensaku.UseVisualStyleBackColor = true;
            // 
            // ButtonExe
            // 
            this.ButtonExe.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.ButtonExe.Location = new System.Drawing.Point(519, 167);
            this.ButtonExe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ButtonExe.Name = "ButtonExe";
            this.ButtonExe.Size = new System.Drawing.Size(165, 58);
            this.ButtonExe.TabIndex = 103;
            this.ButtonExe.Text = "実行";
            this.ButtonExe.UseVisualStyleBackColor = true;
            this.ButtonExe.Click += new System.EventHandler(this.ButtonExe_Click);
            // 
            // F_在庫管理
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 688);
            this.Controls.Add(this.ButtonExe);
            this.Controls.Add(this.ButtonReset);
            this.Controls.Add(this.RadioKensaku);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.TextboxShouhinID);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "F_在庫管理";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.F_在庫管理_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button ButtonBack;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox TextboxShouhinID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button ButtonReset;
        private System.Windows.Forms.RadioButton RadioKensaku;
        private System.Windows.Forms.Button ButtonExe;
    }
}