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
            this.TextboxZaikoCnt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ButtonKensaku = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
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
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1024, 142);
            this.panel1.TabIndex = 58;
            // 
            // ButtonBack
            // 
            this.ButtonBack.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.ButtonBack.Location = new System.Drawing.Point(808, 44);
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
            this.label6.Location = new System.Drawing.Point(370, 44);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(222, 50);
            this.label6.TabIndex = 4;
            this.label6.Text = "在庫管理";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.label5.Location = new System.Drawing.Point(397, 301);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 25);
            this.label5.TabIndex = 59;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(51, 334);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(922, 351);
            this.dataGridView1.TabIndex = 57;
            // 
            // TextboxShouhinID
            // 
            this.TextboxShouhinID.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.TextboxShouhinID.Location = new System.Drawing.Point(191, 199);
            this.TextboxShouhinID.Name = "TextboxShouhinID";
            this.TextboxShouhinID.Size = new System.Drawing.Size(156, 32);
            this.TextboxShouhinID.TabIndex = 56;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.label3.Location = new System.Drawing.Point(101, 204);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 25);
            this.label3.TabIndex = 52;
            this.label3.Text = "商品ID";
            // 
            // TextboxZaikoCnt
            // 
            this.TextboxZaikoCnt.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.TextboxZaikoCnt.Location = new System.Drawing.Point(480, 197);
            this.TextboxZaikoCnt.Name = "TextboxZaikoCnt";
            this.TextboxZaikoCnt.Size = new System.Drawing.Size(156, 32);
            this.TextboxZaikoCnt.TabIndex = 51;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.label2.Location = new System.Drawing.Point(374, 204);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 25);
            this.label2.TabIndex = 50;
            this.label2.Text = "メーカー名　";
            // 
            // ButtonKensaku
            // 
            this.ButtonKensaku.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.ButtonKensaku.Location = new System.Drawing.Point(746, 186);
            this.ButtonKensaku.Name = "ButtonKensaku";
            this.ButtonKensaku.Size = new System.Drawing.Size(204, 119);
            this.ButtonKensaku.TabIndex = 55;
            this.ButtonKensaku.Text = "検索";
            this.ButtonKensaku.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.checkBox1.Location = new System.Drawing.Point(106, 276);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(222, 29);
            this.checkBox1.TabIndex = 60;
            this.checkBox1.Text = "不足状態絞り込み";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // F_在庫管理
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 718);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.TextboxShouhinID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TextboxZaikoCnt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ButtonKensaku);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "F_在庫管理";
            this.Text = "Form1";
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
        private System.Windows.Forms.TextBox TextboxZaikoCnt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ButtonKensaku;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}