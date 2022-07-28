
namespace QuanLyThuVien
{
    partial class fAddTacGia
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
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.panel1 = new System.Windows.Forms.Panel();
      this.txbTenLoaiSach = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.panel9 = new System.Windows.Forms.Panel();
      this.txbMaTG = new System.Windows.Forms.TextBox();
      this.label9 = new System.Windows.Forms.Label();
      this.btnAdd = new System.Windows.Forms.Button();
      this.groupBox1.SuspendLayout();
      this.panel1.SuspendLayout();
      this.panel9.SuspendLayout();
      this.SuspendLayout();
      // 
      // groupBox1
      // 
      this.groupBox1.BackColor = System.Drawing.Color.Silver;
      this.groupBox1.Controls.Add(this.panel1);
      this.groupBox1.Controls.Add(this.panel9);
      this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.groupBox1.Location = new System.Drawing.Point(7, 12);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(271, 126);
      this.groupBox1.TabIndex = 23;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Thông tin chi tiết";
      // 
      // panel1
      // 
      this.panel1.Controls.Add(this.txbTenLoaiSach);
      this.panel1.Controls.Add(this.label1);
      this.panel1.Location = new System.Drawing.Point(12, 78);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(259, 39);
      this.panel1.TabIndex = 6;
      // 
      // txbTenLoaiSach
      // 
      this.txbTenLoaiSach.Location = new System.Drawing.Point(106, 4);
      this.txbTenLoaiSach.Name = "txbTenLoaiSach";
      this.txbTenLoaiSach.Size = new System.Drawing.Size(145, 26);
      this.txbTenLoaiSach.TabIndex = 3;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.Location = new System.Drawing.Point(4, 8);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(84, 18);
      this.label1.TabIndex = 0;
      this.label1.Text = "Tên tác giả:";
      // 
      // panel9
      // 
      this.panel9.Controls.Add(this.txbMaTG);
      this.panel9.Controls.Add(this.label9);
      this.panel9.Location = new System.Drawing.Point(12, 33);
      this.panel9.Name = "panel9";
      this.panel9.Size = new System.Drawing.Size(259, 39);
      this.panel9.TabIndex = 6;
      // 
      // txbMaTG
      // 
      this.txbMaTG.Location = new System.Drawing.Point(106, 4);
      this.txbMaTG.Name = "txbMaTG";
      this.txbMaTG.ReadOnly = true;
      this.txbMaTG.Size = new System.Drawing.Size(147, 26);
      this.txbMaTG.TabIndex = 3;
      // 
      // label9
      // 
      this.label9.AutoSize = true;
      this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label9.Location = new System.Drawing.Point(3, 8);
      this.label9.Name = "label9";
      this.label9.Size = new System.Drawing.Size(80, 18);
      this.label9.TabIndex = 0;
      this.label9.Text = "Mã tác giả:";
      // 
      // btnAdd
      // 
      this.btnAdd.BackColor = System.Drawing.Color.Silver;
      this.btnAdd.Location = new System.Drawing.Point(201, 146);
      this.btnAdd.Name = "btnAdd";
      this.btnAdd.Size = new System.Drawing.Size(76, 33);
      this.btnAdd.TabIndex = 24;
      this.btnAdd.Text = "Thêm";
      this.btnAdd.UseVisualStyleBackColor = false;
      this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
      // 
      // fAddTacGia
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
      this.ClientSize = new System.Drawing.Size(289, 191);
      this.Controls.Add(this.groupBox1);
      this.Controls.Add(this.btnAdd);
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "fAddTacGia";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Thêm tác giả";
      this.groupBox1.ResumeLayout(false);
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      this.panel9.ResumeLayout(false);
      this.panel9.PerformLayout();
      this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txbTenLoaiSach;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.TextBox txbMaTG;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnAdd;
    }
}