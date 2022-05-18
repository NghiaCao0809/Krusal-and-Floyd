
namespace Doan
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btnTaoDoThi = new System.Windows.Forms.Button();
            this.btnDocDoThi = new System.Windows.Forms.Button();
            this.btnTimCayKhungKruskal = new System.Windows.Forms.Button();
            this.btnTimCayKhungFloyd = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblTrangThai = new System.Windows.Forms.ToolStripStatusLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.label2.Font = new System.Drawing.Font("SVN-Aleo", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Snow;
            this.label2.Location = new System.Drawing.Point(76, -2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(628, 64);
            this.label2.TabIndex = 1;
            this.label2.Text = "Thuật toán Krusal và Floyd";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(0, -32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(800, 99);
            this.label1.TabIndex = 0;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(192, 80);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(596, 333);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "";
            // 
            // btnTaoDoThi
            // 
            this.btnTaoDoThi.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnTaoDoThi.Location = new System.Drawing.Point(23, 80);
            this.btnTaoDoThi.Name = "btnTaoDoThi";
            this.btnTaoDoThi.Size = new System.Drawing.Size(145, 71);
            this.btnTaoDoThi.TabIndex = 4;
            this.btnTaoDoThi.Text = "Tạo đồ thị";
            this.btnTaoDoThi.UseVisualStyleBackColor = true;
            this.btnTaoDoThi.Click += new System.EventHandler(this.btnTaoDoThi_Click);
            // 
            // btnDocDoThi
            // 
            this.btnDocDoThi.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDocDoThi.Location = new System.Drawing.Point(23, 165);
            this.btnDocDoThi.Name = "btnDocDoThi";
            this.btnDocDoThi.Size = new System.Drawing.Size(145, 71);
            this.btnDocDoThi.TabIndex = 5;
            this.btnDocDoThi.Text = "Đọc đồ thị";
            this.btnDocDoThi.UseVisualStyleBackColor = true;
            this.btnDocDoThi.Click += new System.EventHandler(this.btnDocDoThi_Click);
            // 
            // btnTimCayKhungKruskal
            // 
            this.btnTimCayKhungKruskal.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnTimCayKhungKruskal.Location = new System.Drawing.Point(23, 253);
            this.btnTimCayKhungKruskal.Name = "btnTimCayKhungKruskal";
            this.btnTimCayKhungKruskal.Size = new System.Drawing.Size(145, 71);
            this.btnTimCayKhungKruskal.TabIndex = 6;
            this.btnTimCayKhungKruskal.Text = "Krusal";
            this.btnTimCayKhungKruskal.UseVisualStyleBackColor = true;
            this.btnTimCayKhungKruskal.Click += new System.EventHandler(this.btnTimCayKhungKruskal_Click);
            // 
            // btnTimCayKhungFloyd
            // 
            this.btnTimCayKhungFloyd.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnTimCayKhungFloyd.Location = new System.Drawing.Point(23, 342);
            this.btnTimCayKhungFloyd.Name = "btnTimCayKhungFloyd";
            this.btnTimCayKhungFloyd.Size = new System.Drawing.Size(145, 71);
            this.btnTimCayKhungFloyd.TabIndex = 7;
            this.btnTimCayKhungFloyd.Text = "Floyd";
            this.btnTimCayKhungFloyd.UseVisualStyleBackColor = true;
            this.btnTimCayKhungFloyd.Click += new System.EventHandler(this.btnTimCayKhungFloyd_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblTrangThai});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 8;
            this.statusStrip1.Text = "statusStrip1";
            this.statusStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.statusStrip1_ItemClicked);
            // 
            // lblTrangThai
            // 
            this.lblTrangThai.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTrangThai.Name = "lblTrangThai";
            this.lblTrangThai.Size = new System.Drawing.Size(62, 17);
            this.lblTrangThai.Text = "Trạng thái:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 431);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 15);
            this.label3.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOrange;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnTimCayKhungFloyd);
            this.Controls.Add(this.btnTimCayKhungKruskal);
            this.Controls.Add(this.btnDocDoThi);
            this.Controls.Add(this.btnTaoDoThi);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btnTaoDoThi;
        private System.Windows.Forms.Button btnDocDoThi;
        private System.Windows.Forms.Button btnTimCayKhungKruskal;
        private System.Windows.Forms.Button btnTimCayKhungFloyd;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripStatusLabel lblTrangThai;
    }
}

