
namespace QuanLyThuVien.FormPhieuThu
{
  partial class fPhieuThu
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
      this.dtgvListPhieuThu = new System.Windows.Forms.DataGridView();
      this.btnAddPhieuThu = new System.Windows.Forms.Button();
      this.label2 = new System.Windows.Forms.Label();
      this.btnSearch = new System.Windows.Forms.Button();
      this.txbSearch = new System.Windows.Forms.TextBox();
      this.rdbIdAdmin = new System.Windows.Forms.RadioButton();
      this.rdbIdInfor = new System.Windows.Forms.RadioButton();
      this.groupBox2 = new System.Windows.Forms.GroupBox();
      this.btnLoad = new System.Windows.Forms.Button();
      ((System.ComponentModel.ISupportInitialize)(this.dtgvListPhieuThu)).BeginInit();
      this.groupBox2.SuspendLayout();
      this.SuspendLayout();
      // 
      // dtgvListPhieuThu
      // 
      this.dtgvListPhieuThu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
      this.dtgvListPhieuThu.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      this.dtgvListPhieuThu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dtgvListPhieuThu.Location = new System.Drawing.Point(94, 148);
      this.dtgvListPhieuThu.Name = "dtgvListPhieuThu";
      this.dtgvListPhieuThu.Size = new System.Drawing.Size(811, 345);
      this.dtgvListPhieuThu.TabIndex = 33;
      // 
      // btnAddPhieuThu
      // 
      this.btnAddPhieuThu.BackColor = System.Drawing.Color.Silver;
      this.btnAddPhieuThu.Location = new System.Drawing.Point(94, 12);
      this.btnAddPhieuThu.Name = "btnAddPhieuThu";
      this.btnAddPhieuThu.Size = new System.Drawing.Size(83, 32);
      this.btnAddPhieuThu.TabIndex = 29;
      this.btnAddPhieuThu.Text = "Tạo phiếu";
      this.btnAddPhieuThu.UseVisualStyleBackColor = false;
      this.btnAddPhieuThu.Click += new System.EventHandler(this.btnAddPhieuThu_Click);
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label2.Location = new System.Drawing.Point(403, 106);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(229, 25);
      this.label2.TabIndex = 34;
      this.label2.Text = "Danh sách phiếu thu";
      // 
      // btnSearch
      // 
      this.btnSearch.BackColor = System.Drawing.Color.Silver;
      this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnSearch.Location = new System.Drawing.Point(456, 26);
      this.btnSearch.Name = "btnSearch";
      this.btnSearch.Size = new System.Drawing.Size(75, 30);
      this.btnSearch.TabIndex = 5;
      this.btnSearch.Text = "Tìm kiếm";
      this.btnSearch.UseVisualStyleBackColor = false;
      this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
      // 
      // txbSearch
      // 
      this.txbSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txbSearch.Location = new System.Drawing.Point(238, 26);
      this.txbSearch.Name = "txbSearch";
      this.txbSearch.Size = new System.Drawing.Size(198, 22);
      this.txbSearch.TabIndex = 6;
      // 
      // rdbIdAdmin
      // 
      this.rdbIdAdmin.AutoSize = true;
      this.rdbIdAdmin.Checked = true;
      this.rdbIdAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.rdbIdAdmin.Location = new System.Drawing.Point(20, 22);
      this.rdbIdAdmin.Name = "rdbIdAdmin";
      this.rdbIdAdmin.Size = new System.Drawing.Size(120, 20);
      this.rdbIdAdmin.TabIndex = 0;
      this.rdbIdAdmin.TabStop = true;
      this.rdbIdAdmin.Text = "Theo mã admin";
      this.rdbIdAdmin.UseVisualStyleBackColor = true;
      // 
      // rdbIdInfor
      // 
      this.rdbIdInfor.AutoSize = true;
      this.rdbIdInfor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.rdbIdInfor.Location = new System.Drawing.Point(21, 44);
      this.rdbIdInfor.Name = "rdbIdInfor";
      this.rdbIdInfor.Size = new System.Drawing.Size(132, 20);
      this.rdbIdInfor.TabIndex = 1;
      this.rdbIdInfor.Text = "Theo mã thông tin";
      this.rdbIdInfor.UseVisualStyleBackColor = true;
      // 
      // groupBox2
      // 
      this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
      this.groupBox2.Controls.Add(this.rdbIdInfor);
      this.groupBox2.Controls.Add(this.rdbIdAdmin);
      this.groupBox2.Controls.Add(this.txbSearch);
      this.groupBox2.Controls.Add(this.btnSearch);
      this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.groupBox2.Location = new System.Drawing.Point(183, 12);
      this.groupBox2.Name = "groupBox2";
      this.groupBox2.Size = new System.Drawing.Size(664, 76);
      this.groupBox2.TabIndex = 35;
      this.groupBox2.TabStop = false;
      this.groupBox2.Text = "Tìm kiếm";
      // 
      // btnLoad
      // 
      this.btnLoad.BackColor = System.Drawing.Color.Silver;
      this.btnLoad.Location = new System.Drawing.Point(94, 50);
      this.btnLoad.Name = "btnLoad";
      this.btnLoad.Size = new System.Drawing.Size(83, 32);
      this.btnLoad.TabIndex = 36;
      this.btnLoad.Text = "Làm mới";
      this.btnLoad.UseVisualStyleBackColor = false;
      this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
      // 
      // fPhieuThu
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(977, 505);
      this.Controls.Add(this.btnLoad);
      this.Controls.Add(this.groupBox2);
      this.Controls.Add(this.dtgvListPhieuThu);
      this.Controls.Add(this.btnAddPhieuThu);
      this.Controls.Add(this.label2);
      this.Name = "fPhieuThu";
      this.Text = "Phiếu thu";
      ((System.ComponentModel.ISupportInitialize)(this.dtgvListPhieuThu)).EndInit();
      this.groupBox2.ResumeLayout(false);
      this.groupBox2.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion
    private System.Windows.Forms.DataGridView dtgvListPhieuThu;
    private System.Windows.Forms.Button btnAddPhieuThu;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Button btnSearch;
    private System.Windows.Forms.TextBox txbSearch;
    private System.Windows.Forms.RadioButton rdbIdAdmin;
    private System.Windows.Forms.RadioButton rdbIdInfor;
    private System.Windows.Forms.GroupBox groupBox2;
    private System.Windows.Forms.Button btnLoad;
  }
}