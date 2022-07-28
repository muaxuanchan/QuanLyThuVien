
namespace QuanLyThuVien.TaiKhoan
{
    partial class fAddTaiKhoan
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
      this.btnAdd = new System.Windows.Forms.Button();
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.panel7 = new System.Windows.Forms.Panel();
      this.txbPhoneNumber = new System.Windows.Forms.TextBox();
      this.label7 = new System.Windows.Forms.Label();
      this.panel6 = new System.Windows.Forms.Panel();
      this.txbDisplayName = new System.Windows.Forms.TextBox();
      this.label6 = new System.Windows.Forms.Label();
      this.panel5 = new System.Windows.Forms.Panel();
      this.txbPassWord = new System.Windows.Forms.TextBox();
      this.label5 = new System.Windows.Forms.Label();
      this.panel3 = new System.Windows.Forms.Panel();
      this.label3 = new System.Windows.Forms.Label();
      this.panel2 = new System.Windows.Forms.Panel();
      this.txbTenTaiKhoan = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.cbQuyen = new System.Windows.Forms.ComboBox();
      this.groupBox1.SuspendLayout();
      this.panel7.SuspendLayout();
      this.panel6.SuspendLayout();
      this.panel5.SuspendLayout();
      this.panel3.SuspendLayout();
      this.panel2.SuspendLayout();
      this.SuspendLayout();
      // 
      // btnAdd
      // 
      this.btnAdd.BackColor = System.Drawing.Color.Silver;
      this.btnAdd.Location = new System.Drawing.Point(514, 156);
      this.btnAdd.Name = "btnAdd";
      this.btnAdd.Size = new System.Drawing.Size(75, 33);
      this.btnAdd.TabIndex = 7;
      this.btnAdd.Text = "Thêm";
      this.btnAdd.UseVisualStyleBackColor = false;
      this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
      // 
      // groupBox1
      // 
      this.groupBox1.BackColor = System.Drawing.Color.Silver;
      this.groupBox1.Controls.Add(this.panel7);
      this.groupBox1.Controls.Add(this.panel6);
      this.groupBox1.Controls.Add(this.panel5);
      this.groupBox1.Controls.Add(this.panel3);
      this.groupBox1.Controls.Add(this.panel2);
      this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.groupBox1.Location = new System.Drawing.Point(12, 12);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(590, 141);
      this.groupBox1.TabIndex = 19;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Thông tin độc giả";
      // 
      // panel7
      // 
      this.panel7.Controls.Add(this.txbPhoneNumber);
      this.panel7.Controls.Add(this.label7);
      this.panel7.Location = new System.Drawing.Point(283, 23);
      this.panel7.Name = "panel7";
      this.panel7.Size = new System.Drawing.Size(294, 30);
      this.panel7.TabIndex = 2;
      // 
      // txbPhoneNumber
      // 
      this.txbPhoneNumber.Location = new System.Drawing.Point(104, 3);
      this.txbPhoneNumber.Name = "txbPhoneNumber";
      this.txbPhoneNumber.Size = new System.Drawing.Size(173, 24);
      this.txbPhoneNumber.TabIndex = 1;
      // 
      // label7
      // 
      this.label7.AutoSize = true;
      this.label7.Location = new System.Drawing.Point(4, 6);
      this.label7.Name = "label7";
      this.label7.Size = new System.Drawing.Size(98, 18);
      this.label7.TabIndex = 0;
      this.label7.Text = "Số điện thoại:";
      // 
      // panel6
      // 
      this.panel6.Controls.Add(this.txbDisplayName);
      this.panel6.Controls.Add(this.label6);
      this.panel6.Location = new System.Drawing.Point(6, 57);
      this.panel6.Name = "panel6";
      this.panel6.Size = new System.Drawing.Size(271, 30);
      this.panel6.TabIndex = 2;
      // 
      // txbDisplayName
      // 
      this.txbDisplayName.Location = new System.Drawing.Point(105, 3);
      this.txbDisplayName.Name = "txbDisplayName";
      this.txbDisplayName.Size = new System.Drawing.Size(149, 24);
      this.txbDisplayName.TabIndex = 1;
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Location = new System.Drawing.Point(4, 4);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(87, 18);
      this.label6.TabIndex = 0;
      this.label6.Text = "Tên hiển thị:";
      // 
      // panel5
      // 
      this.panel5.Controls.Add(this.txbPassWord);
      this.panel5.Controls.Add(this.label5);
      this.panel5.Location = new System.Drawing.Point(6, 93);
      this.panel5.Name = "panel5";
      this.panel5.Size = new System.Drawing.Size(271, 30);
      this.panel5.TabIndex = 2;
      // 
      // txbPassWord
      // 
      this.txbPassWord.Location = new System.Drawing.Point(104, 0);
      this.txbPassWord.Name = "txbPassWord";
      this.txbPassWord.Size = new System.Drawing.Size(150, 24);
      this.txbPassWord.TabIndex = 1;
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Location = new System.Drawing.Point(4, 3);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(73, 18);
      this.label5.TabIndex = 0;
      this.label5.Text = "Mật khẩu:";
      // 
      // panel3
      // 
      this.panel3.Controls.Add(this.cbQuyen);
      this.panel3.Controls.Add(this.label3);
      this.panel3.Location = new System.Drawing.Point(283, 61);
      this.panel3.Name = "panel3";
      this.panel3.Size = new System.Drawing.Size(294, 30);
      this.panel3.TabIndex = 2;
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(4, 4);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(55, 18);
      this.label3.TabIndex = 0;
      this.label3.Text = "Quyền:";
      // 
      // panel2
      // 
      this.panel2.Controls.Add(this.txbTenTaiKhoan);
      this.panel2.Controls.Add(this.label1);
      this.panel2.Location = new System.Drawing.Point(6, 23);
      this.panel2.Name = "panel2";
      this.panel2.Size = new System.Drawing.Size(271, 29);
      this.panel2.TabIndex = 1;
      // 
      // txbTenTaiKhoan
      // 
      this.txbTenTaiKhoan.Location = new System.Drawing.Point(105, 4);
      this.txbTenTaiKhoan.Name = "txbTenTaiKhoan";
      this.txbTenTaiKhoan.Size = new System.Drawing.Size(149, 24);
      this.txbTenTaiKhoan.TabIndex = 1;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(4, 4);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(101, 18);
      this.label1.TabIndex = 0;
      this.label1.Text = "Tên tài khoản:";
      // 
      // cbQuyen
      // 
      this.cbQuyen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cbQuyen.FormattingEnabled = true;
      this.cbQuyen.Items.AddRange(new object[] {
            "1",
            "0"});
      this.cbQuyen.Location = new System.Drawing.Point(104, 1);
      this.cbQuyen.Name = "cbQuyen";
      this.cbQuyen.Size = new System.Drawing.Size(173, 26);
      this.cbQuyen.TabIndex = 3;
      // 
      // fAddTaiKhoan
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
      this.ClientSize = new System.Drawing.Size(610, 191);
      this.Controls.Add(this.groupBox1);
      this.Controls.Add(this.btnAdd);
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "fAddTaiKhoan";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Thêm tài khoản";
      this.groupBox1.ResumeLayout(false);
      this.panel7.ResumeLayout(false);
      this.panel7.PerformLayout();
      this.panel6.ResumeLayout(false);
      this.panel6.PerformLayout();
      this.panel5.ResumeLayout(false);
      this.panel5.PerformLayout();
      this.panel3.ResumeLayout(false);
      this.panel3.PerformLayout();
      this.panel2.ResumeLayout(false);
      this.panel2.PerformLayout();
      this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.TextBox txbPhoneNumber;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox txbDisplayName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox txbPassWord;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txbTenTaiKhoan;
        private System.Windows.Forms.Label label1;
    private System.Windows.Forms.ComboBox cbQuyen;
  }
}