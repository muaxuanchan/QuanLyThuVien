
namespace QuanLyThuVien
{
    partial class fTacGia
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
      this.dtgvTacGia = new System.Windows.Forms.DataGridView();
      this.btnLoad = new System.Windows.Forms.Button();
      this.btnDelete = new System.Windows.Forms.Button();
      this.btnUpdate = new System.Windows.Forms.Button();
      this.btnAdd = new System.Windows.Forms.Button();
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.panel1 = new System.Windows.Forms.Panel();
      this.txbTenTacGia = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.panel9 = new System.Windows.Forms.Panel();
      this.txbMaTacGia = new System.Windows.Forms.TextBox();
      this.label9 = new System.Windows.Forms.Label();
      this.groupBox2 = new System.Windows.Forms.GroupBox();
      this.rdbName = new System.Windows.Forms.RadioButton();
      this.rdbID = new System.Windows.Forms.RadioButton();
      this.txnSearch = new System.Windows.Forms.TextBox();
      this.btnSearch = new System.Windows.Forms.Button();
      ((System.ComponentModel.ISupportInitialize)(this.dtgvTacGia)).BeginInit();
      this.groupBox1.SuspendLayout();
      this.panel1.SuspendLayout();
      this.panel9.SuspendLayout();
      this.groupBox2.SuspendLayout();
      this.SuspendLayout();
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label2.Location = new System.Drawing.Point(362, 177);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(202, 25);
      this.label2.TabIndex = 17;
      this.label2.Text = "Danh sách tác giả";
      // 
      // dtgvTacGia
      // 
      this.dtgvTacGia.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
      this.dtgvTacGia.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
      this.dtgvTacGia.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      this.dtgvTacGia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dtgvTacGia.Location = new System.Drawing.Point(50, 216);
      this.dtgvTacGia.Name = "dtgvTacGia";
      this.dtgvTacGia.Size = new System.Drawing.Size(843, 260);
      this.dtgvTacGia.TabIndex = 16;
      this.dtgvTacGia.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvTacGia_CellContentClick);
      // 
      // btnLoad
      // 
      this.btnLoad.BackColor = System.Drawing.Color.Silver;
      this.btnLoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnLoad.Location = new System.Drawing.Point(401, 123);
      this.btnLoad.Name = "btnLoad";
      this.btnLoad.Size = new System.Drawing.Size(75, 32);
      this.btnLoad.TabIndex = 13;
      this.btnLoad.Text = "Làm mới";
      this.btnLoad.UseVisualStyleBackColor = false;
      this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
      // 
      // btnDelete
      // 
      this.btnDelete.BackColor = System.Drawing.Color.Silver;
      this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnDelete.Location = new System.Drawing.Point(309, 123);
      this.btnDelete.Name = "btnDelete";
      this.btnDelete.Size = new System.Drawing.Size(75, 32);
      this.btnDelete.TabIndex = 12;
      this.btnDelete.Text = "Xóa";
      this.btnDelete.UseVisualStyleBackColor = false;
      this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
      // 
      // btnUpdate
      // 
      this.btnUpdate.BackColor = System.Drawing.Color.Silver;
      this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnUpdate.Location = new System.Drawing.Point(211, 123);
      this.btnUpdate.Name = "btnUpdate";
      this.btnUpdate.Size = new System.Drawing.Size(75, 32);
      this.btnUpdate.TabIndex = 11;
      this.btnUpdate.Text = "Sửa";
      this.btnUpdate.UseVisualStyleBackColor = false;
      this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
      // 
      // btnAdd
      // 
      this.btnAdd.BackColor = System.Drawing.Color.Silver;
      this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnAdd.Location = new System.Drawing.Point(120, 123);
      this.btnAdd.Name = "btnAdd";
      this.btnAdd.Size = new System.Drawing.Size(75, 32);
      this.btnAdd.TabIndex = 10;
      this.btnAdd.Text = "Thêm";
      this.btnAdd.UseVisualStyleBackColor = false;
      this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
      // 
      // groupBox1
      // 
      this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      this.groupBox1.Controls.Add(this.panel1);
      this.groupBox1.Controls.Add(this.panel9);
      this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.groupBox1.Location = new System.Drawing.Point(50, 18);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(843, 82);
      this.groupBox1.TabIndex = 9;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Thông tin chi tiết";
      // 
      // panel1
      // 
      this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      this.panel1.Controls.Add(this.txbTenTacGia);
      this.panel1.Controls.Add(this.label1);
      this.panel1.Location = new System.Drawing.Point(456, 25);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(315, 39);
      this.panel1.TabIndex = 6;
      // 
      // txbTenTacGia
      // 
      this.txbTenTacGia.Location = new System.Drawing.Point(94, 4);
      this.txbTenTacGia.Name = "txbTenTacGia";
      this.txbTenTacGia.Size = new System.Drawing.Size(218, 26);
      this.txbTenTacGia.TabIndex = 3;
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
      this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      this.panel9.Controls.Add(this.txbMaTacGia);
      this.panel9.Controls.Add(this.label9);
      this.panel9.Location = new System.Drawing.Point(41, 25);
      this.panel9.Name = "panel9";
      this.panel9.Size = new System.Drawing.Size(315, 39);
      this.panel9.TabIndex = 6;
      // 
      // txbMaTacGia
      // 
      this.txbMaTacGia.Location = new System.Drawing.Point(90, 4);
      this.txbMaTacGia.Name = "txbMaTacGia";
      this.txbMaTacGia.Size = new System.Drawing.Size(222, 26);
      this.txbMaTacGia.TabIndex = 3;
      // 
      // label9
      // 
      this.label9.AutoSize = true;
      this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label9.Location = new System.Drawing.Point(4, 4);
      this.label9.Name = "label9";
      this.label9.Size = new System.Drawing.Size(80, 18);
      this.label9.TabIndex = 0;
      this.label9.Text = "Mã tác giả:";
      // 
      // groupBox2
      // 
      this.groupBox2.Controls.Add(this.rdbName);
      this.groupBox2.Controls.Add(this.rdbID);
      this.groupBox2.Controls.Add(this.txnSearch);
      this.groupBox2.Controls.Add(this.btnSearch);
      this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.groupBox2.Location = new System.Drawing.Point(589, 106);
      this.groupBox2.Name = "groupBox2";
      this.groupBox2.Size = new System.Drawing.Size(304, 80);
      this.groupBox2.TabIndex = 28;
      this.groupBox2.TabStop = false;
      this.groupBox2.Text = "Tìm kiếm";
      // 
      // rdbName
      // 
      this.rdbName.AutoSize = true;
      this.rdbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.rdbName.Location = new System.Drawing.Point(115, 26);
      this.rdbName.Name = "rdbName";
      this.rdbName.Size = new System.Drawing.Size(79, 20);
      this.rdbName.TabIndex = 1;
      this.rdbName.Text = "Theo tên";
      this.rdbName.UseVisualStyleBackColor = true;
      // 
      // rdbID
      // 
      this.rdbID.AutoSize = true;
      this.rdbID.Checked = true;
      this.rdbID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.rdbID.Location = new System.Drawing.Point(20, 26);
      this.rdbID.Name = "rdbID";
      this.rdbID.Size = new System.Drawing.Size(80, 20);
      this.rdbID.TabIndex = 0;
      this.rdbID.TabStop = true;
      this.rdbID.Text = "Theo mã";
      this.rdbID.UseVisualStyleBackColor = true;
      // 
      // txnSearch
      // 
      this.txnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txnSearch.Location = new System.Drawing.Point(13, 52);
      this.txnSearch.Name = "txnSearch";
      this.txnSearch.Size = new System.Drawing.Size(198, 22);
      this.txnSearch.TabIndex = 6;
      // 
      // btnSearch
      // 
      this.btnSearch.BackColor = System.Drawing.Color.Silver;
      this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnSearch.Location = new System.Drawing.Point(217, 44);
      this.btnSearch.Name = "btnSearch";
      this.btnSearch.Size = new System.Drawing.Size(75, 30);
      this.btnSearch.TabIndex = 5;
      this.btnSearch.Text = "Tìm kiếm";
      this.btnSearch.UseVisualStyleBackColor = false;
      this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click_1);
      // 
      // fTacGia
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
      this.ClientSize = new System.Drawing.Size(964, 488);
      this.Controls.Add(this.groupBox2);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.dtgvTacGia);
      this.Controls.Add(this.btnLoad);
      this.Controls.Add(this.btnDelete);
      this.Controls.Add(this.btnUpdate);
      this.Controls.Add(this.btnAdd);
      this.Controls.Add(this.groupBox1);
      this.Name = "fTacGia";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Tác giả";
      ((System.ComponentModel.ISupportInitialize)(this.dtgvTacGia)).EndInit();
      this.groupBox1.ResumeLayout(false);
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      this.panel9.ResumeLayout(false);
      this.panel9.PerformLayout();
      this.groupBox2.ResumeLayout(false);
      this.groupBox2.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dtgvTacGia;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txbTenTacGia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.TextBox txbMaTacGia;
        private System.Windows.Forms.Label label9;
    private System.Windows.Forms.GroupBox groupBox2;
    private System.Windows.Forms.RadioButton rdbName;
    private System.Windows.Forms.RadioButton rdbID;
    private System.Windows.Forms.TextBox txnSearch;
    private System.Windows.Forms.Button btnSearch;
  }
}