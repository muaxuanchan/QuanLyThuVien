
namespace QuanLyThuVien
{
    partial class fAdmin
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
      this.label2 = new System.Windows.Forms.Label();
      this.dtgvTaiKhoan = new System.Windows.Forms.DataGridView();
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.panel7 = new System.Windows.Forms.Panel();
      this.txbPhoneNumber = new System.Windows.Forms.TextBox();
      this.label7 = new System.Windows.Forms.Label();
      this.panel6 = new System.Windows.Forms.Panel();
      this.txbDisplayName = new System.Windows.Forms.TextBox();
      this.label6 = new System.Windows.Forms.Label();
      this.panel5 = new System.Windows.Forms.Panel();
      this.txbPass = new System.Windows.Forms.TextBox();
      this.label5 = new System.Windows.Forms.Label();
      this.panel3 = new System.Windows.Forms.Panel();
      this.label3 = new System.Windows.Forms.Label();
      this.panel2 = new System.Windows.Forms.Panel();
      this.txbTenTaiKhoan = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.panel1 = new System.Windows.Forms.Panel();
      this.txbID = new System.Windows.Forms.TextBox();
      this.label10 = new System.Windows.Forms.Label();
      this.btnLoad = new System.Windows.Forms.Button();
      this.btnDelete = new System.Windows.Forms.Button();
      this.btnAdd = new System.Windows.Forms.Button();
      this.btnUpdate = new System.Windows.Forms.Button();
      this.cbQuyen = new System.Windows.Forms.ComboBox();
      ((System.ComponentModel.ISupportInitialize)(this.dtgvTaiKhoan)).BeginInit();
      this.groupBox1.SuspendLayout();
      this.panel7.SuspendLayout();
      this.panel6.SuspendLayout();
      this.panel5.SuspendLayout();
      this.panel3.SuspendLayout();
      this.panel2.SuspendLayout();
      this.panel1.SuspendLayout();
      this.SuspendLayout();
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label2.Location = new System.Drawing.Point(409, 178);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(228, 25);
      this.label2.TabIndex = 17;
      this.label2.Text = "Danh sách tài khoản";
      // 
      // dtgvTaiKhoan
      // 
      this.dtgvTaiKhoan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
      this.dtgvTaiKhoan.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      this.dtgvTaiKhoan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dtgvTaiKhoan.Location = new System.Drawing.Point(76, 222);
      this.dtgvTaiKhoan.Name = "dtgvTaiKhoan";
      this.dtgvTaiKhoan.Size = new System.Drawing.Size(844, 249);
      this.dtgvTaiKhoan.TabIndex = 16;
      this.dtgvTaiKhoan.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvTaiKhoan_CellContentClick);
      // 
      // groupBox1
      // 
      this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      this.groupBox1.Controls.Add(this.panel7);
      this.groupBox1.Controls.Add(this.panel6);
      this.groupBox1.Controls.Add(this.panel5);
      this.groupBox1.Controls.Add(this.panel3);
      this.groupBox1.Controls.Add(this.panel2);
      this.groupBox1.Controls.Add(this.panel1);
      this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.groupBox1.Location = new System.Drawing.Point(75, 12);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(898, 118);
      this.groupBox1.TabIndex = 18;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Thông tin tài khoản";
      // 
      // panel7
      // 
      this.panel7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      this.panel7.Controls.Add(this.txbPhoneNumber);
      this.panel7.Controls.Add(this.label7);
      this.panel7.Location = new System.Drawing.Point(566, 26);
      this.panel7.Name = "panel7";
      this.panel7.Size = new System.Drawing.Size(308, 30);
      this.panel7.TabIndex = 2;
      // 
      // txbPhoneNumber
      // 
      this.txbPhoneNumber.Location = new System.Drawing.Point(102, 3);
      this.txbPhoneNumber.Name = "txbPhoneNumber";
      this.txbPhoneNumber.ReadOnly = true;
      this.txbPhoneNumber.Size = new System.Drawing.Size(189, 24);
      this.txbPhoneNumber.TabIndex = 1;
      // 
      // label7
      // 
      this.label7.AutoSize = true;
      this.label7.Location = new System.Drawing.Point(5, 6);
      this.label7.Name = "label7";
      this.label7.Size = new System.Drawing.Size(98, 18);
      this.label7.TabIndex = 0;
      this.label7.Text = "Số điện thoại:";
      // 
      // panel6
      // 
      this.panel6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      this.panel6.Controls.Add(this.txbDisplayName);
      this.panel6.Controls.Add(this.label6);
      this.panel6.Location = new System.Drawing.Point(280, 69);
      this.panel6.Name = "panel6";
      this.panel6.Size = new System.Drawing.Size(282, 30);
      this.panel6.TabIndex = 2;
      // 
      // txbDisplayName
      // 
      this.txbDisplayName.Location = new System.Drawing.Point(88, 3);
      this.txbDisplayName.Name = "txbDisplayName";
      this.txbDisplayName.ReadOnly = true;
      this.txbDisplayName.Size = new System.Drawing.Size(178, 24);
      this.txbDisplayName.TabIndex = 1;
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Location = new System.Drawing.Point(5, 4);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(87, 18);
      this.label6.TabIndex = 0;
      this.label6.Text = "Tên hiển thị:";
      // 
      // panel5
      // 
      this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      this.panel5.Controls.Add(this.txbPass);
      this.panel5.Controls.Add(this.label5);
      this.panel5.Location = new System.Drawing.Point(280, 23);
      this.panel5.Name = "panel5";
      this.panel5.Size = new System.Drawing.Size(282, 30);
      this.panel5.TabIndex = 2;
      // 
      // txbPass
      // 
      this.txbPass.Location = new System.Drawing.Point(88, 3);
      this.txbPass.Name = "txbPass";
      this.txbPass.ReadOnly = true;
      this.txbPass.Size = new System.Drawing.Size(178, 24);
      this.txbPass.TabIndex = 1;
      this.txbPass.UseSystemPasswordChar = true;
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Location = new System.Drawing.Point(12, 6);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(73, 18);
      this.label5.TabIndex = 0;
      this.label5.Text = "Mật khẩu:";
      // 
      // panel3
      // 
      this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      this.panel3.Controls.Add(this.cbQuyen);
      this.panel3.Controls.Add(this.label3);
      this.panel3.Location = new System.Drawing.Point(566, 68);
      this.panel3.Name = "panel3";
      this.panel3.Size = new System.Drawing.Size(308, 30);
      this.panel3.TabIndex = 2;
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(5, 4);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(55, 18);
      this.label3.TabIndex = 0;
      this.label3.Text = "Quyền:";
      // 
      // panel2
      // 
      this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      this.panel2.Controls.Add(this.txbTenTaiKhoan);
      this.panel2.Controls.Add(this.label1);
      this.panel2.Location = new System.Drawing.Point(3, 68);
      this.panel2.Name = "panel2";
      this.panel2.Size = new System.Drawing.Size(273, 29);
      this.panel2.TabIndex = 1;
      // 
      // txbTenTaiKhoan
      // 
      this.txbTenTaiKhoan.Location = new System.Drawing.Point(103, 1);
      this.txbTenTaiKhoan.Name = "txbTenTaiKhoan";
      this.txbTenTaiKhoan.ReadOnly = true;
      this.txbTenTaiKhoan.Size = new System.Drawing.Size(154, 24);
      this.txbTenTaiKhoan.TabIndex = 2;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(5, 4);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(101, 18);
      this.label1.TabIndex = 0;
      this.label1.Text = "Tên tài khoản:";
      // 
      // panel1
      // 
      this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      this.panel1.Controls.Add(this.txbID);
      this.panel1.Controls.Add(this.label10);
      this.panel1.Location = new System.Drawing.Point(3, 23);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(273, 30);
      this.panel1.TabIndex = 0;
      // 
      // txbID
      // 
      this.txbID.Location = new System.Drawing.Point(103, 4);
      this.txbID.Name = "txbID";
      this.txbID.ReadOnly = true;
      this.txbID.Size = new System.Drawing.Size(154, 24);
      this.txbID.TabIndex = 1;
      // 
      // label10
      // 
      this.label10.AutoSize = true;
      this.label10.Location = new System.Drawing.Point(5, 4);
      this.label10.Name = "label10";
      this.label10.Size = new System.Drawing.Size(97, 18);
      this.label10.TabIndex = 0;
      this.label10.Text = "Mã tài khoản:";
      // 
      // btnLoad
      // 
      this.btnLoad.BackColor = System.Drawing.Color.Silver;
      this.btnLoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnLoad.Location = new System.Drawing.Point(355, 140);
      this.btnLoad.Name = "btnLoad";
      this.btnLoad.Size = new System.Drawing.Size(75, 35);
      this.btnLoad.TabIndex = 22;
      this.btnLoad.Text = "Làm mới";
      this.btnLoad.UseVisualStyleBackColor = false;
      this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
      // 
      // btnDelete
      // 
      this.btnDelete.BackColor = System.Drawing.Color.Silver;
      this.btnDelete.Enabled = false;
      this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnDelete.Location = new System.Drawing.Point(170, 140);
      this.btnDelete.Name = "btnDelete";
      this.btnDelete.Size = new System.Drawing.Size(75, 35);
      this.btnDelete.TabIndex = 21;
      this.btnDelete.Text = "Xóa";
      this.btnDelete.UseVisualStyleBackColor = false;
      this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
      // 
      // btnAdd
      // 
      this.btnAdd.BackColor = System.Drawing.Color.Silver;
      this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnAdd.Location = new System.Drawing.Point(78, 142);
      this.btnAdd.Name = "btnAdd";
      this.btnAdd.Size = new System.Drawing.Size(75, 35);
      this.btnAdd.TabIndex = 19;
      this.btnAdd.Text = "Thêm";
      this.btnAdd.UseVisualStyleBackColor = false;
      this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
      // 
      // btnUpdate
      // 
      this.btnUpdate.BackColor = System.Drawing.Color.Silver;
      this.btnUpdate.Enabled = false;
      this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnUpdate.Location = new System.Drawing.Point(260, 140);
      this.btnUpdate.Name = "btnUpdate";
      this.btnUpdate.Size = new System.Drawing.Size(75, 35);
      this.btnUpdate.TabIndex = 23;
      this.btnUpdate.Text = "Cập nhật";
      this.btnUpdate.UseVisualStyleBackColor = false;
      this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
      // 
      // cbQuyen
      // 
      this.cbQuyen.FormattingEnabled = true;
      this.cbQuyen.Items.AddRange(new object[] {
            "0",
            "1",
            "2"});
      this.cbQuyen.Location = new System.Drawing.Point(102, 1);
      this.cbQuyen.Name = "cbQuyen";
      this.cbQuyen.Size = new System.Drawing.Size(189, 26);
      this.cbQuyen.TabIndex = 1;
      // 
      // fAdmin
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
      this.ClientSize = new System.Drawing.Size(985, 483);
      this.Controls.Add(this.btnUpdate);
      this.Controls.Add(this.btnLoad);
      this.Controls.Add(this.btnDelete);
      this.Controls.Add(this.btnAdd);
      this.Controls.Add(this.groupBox1);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.dtgvTaiKhoan);
      this.Name = "fAdmin";
      this.Text = "Quản lý tài khoản";
      ((System.ComponentModel.ISupportInitialize)(this.dtgvTaiKhoan)).EndInit();
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
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dtgvTaiKhoan;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.TextBox txbPhoneNumber;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox txbDisplayName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox txbPass;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txbID;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txbTenTaiKhoan;
    private System.Windows.Forms.Button btnUpdate;
    private System.Windows.Forms.ComboBox cbQuyen;
  }
}