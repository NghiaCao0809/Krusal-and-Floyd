
namespace Doan
{
    partial class Floyd
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Chon1cbx = new System.Windows.Forms.ComboBox();
            this.Chaybtn = new System.Windows.Forms.Button();
            this.Chon2cbx = new System.Windows.Forms.ComboBox();
            this.Huybtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(128, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(348, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chạy thuật toán Floyd";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(44, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 42);
            this.label2.TabIndex = 1;
            this.label2.Text = "Từ đỉnh";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(44, 243);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 37);
            this.label3.TabIndex = 2;
            this.label3.Text = "Đến";
            // 
            // Chon1cbx
            // 
            this.Chon1cbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Chon1cbx.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Chon1cbx.FormattingEnabled = true;
            this.Chon1cbx.Location = new System.Drawing.Point(169, 137);
            this.Chon1cbx.Name = "Chon1cbx";
            this.Chon1cbx.Size = new System.Drawing.Size(67, 29);
            this.Chon1cbx.TabIndex = 2;
            this.Chon1cbx.SelectedIndexChanged += new System.EventHandler(this.Chon1cbx_SelectedIndexChanged);
            // 
            // Chaybtn
            // 
            this.Chaybtn.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Chaybtn.Location = new System.Drawing.Point(460, 122);
            this.Chaybtn.Name = "Chaybtn";
            this.Chaybtn.Size = new System.Drawing.Size(90, 44);
            this.Chaybtn.TabIndex = 4;
            this.Chaybtn.Text = "Chạy";
            this.Chaybtn.UseVisualStyleBackColor = true;
            this.Chaybtn.Click += new System.EventHandler(this.Chaybtn_Click);
            // 
            // Chon2cbx
            // 
            this.Chon2cbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Chon2cbx.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Chon2cbx.FormattingEnabled = true;
            this.Chon2cbx.Location = new System.Drawing.Point(169, 253);
            this.Chon2cbx.Name = "Chon2cbx";
            this.Chon2cbx.Size = new System.Drawing.Size(67, 29);
            this.Chon2cbx.TabIndex = 6;
            // 
            // Huybtn
            // 
            this.Huybtn.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Huybtn.Location = new System.Drawing.Point(460, 232);
            this.Huybtn.Name = "Huybtn";
            this.Huybtn.Size = new System.Drawing.Size(90, 46);
            this.Huybtn.TabIndex = 7;
            this.Huybtn.Text = "Hủy";
            this.Huybtn.UseVisualStyleBackColor = true;
            this.Huybtn.Click += new System.EventHandler(this.Huybtn_Click);
            // 
            // Floyd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(661, 338);
            this.Controls.Add(this.Huybtn);
            this.Controls.Add(this.Chon2cbx);
            this.Controls.Add(this.Chaybtn);
            this.Controls.Add(this.Chon1cbx);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Floyd";
            this.Text = "Floyd";
            this.Load += new System.EventHandler(this.Floyd_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox Chon1cbx;
        private System.Windows.Forms.Button Chaybtn;
        private System.Windows.Forms.ComboBox Chon2cbx;
        private System.Windows.Forms.Button Huybtn;
    }
}