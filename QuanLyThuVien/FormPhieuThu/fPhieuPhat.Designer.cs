
namespace QuanLyThuVien.FormPhieuThu
{
  partial class fPhieuPhat
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
      this.dtgvListPhieuPhat = new System.Windows.Forms.DataGridView();
      this.btnAddPhieuPhat = new System.Windows.Forms.Button();
      this.label2 = new System.Windows.Forms.Label();
      this.rdbIdInfor = new System.Windows.Forms.RadioButton();
      this.rdbIdAdmin = new System.Windows.Forms.RadioButton();
      this.txnSearch = new System.Windows.Forms.TextBox();
      this.btnSearch = new System.Windows.Forms.Button();
      this.groupBox2 = new System.Windows.Forms.GroupBox();
      this.btnLoad = new System.Windows.Forms.Button();
      ((System.ComponentModel.ISupportInitialize)(this.dtgvListPhieuPhat)).BeginInit();
      this.groupBox2.SuspendLayout();
      this.SuspendLayout();
      // 
      // dtgvListPhieuPhat
      // 
      this.dtgvListPhieuPhat.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
      this.dtgvListPhieuPhat.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      this.dtgvListPhieuPhat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dtgvListPhieuPhat.Location = new System.Drawing.Point(83, 148);
      this.dtgvListPhieuPhat.Name = "dtgvListPhieuPhat";
      this.dtgvListPhieuPhat.Size = new System.Drawing.Size(811, 345);
      this.dtgvListPhieuPhat.TabIndex = 38;
      // 
      // btnAddPhieuPhat
      // 
      this.btnAddPhieuPhat.BackColor = System.Drawing.Color.Silver;
      this.btnAddPhieuPhat.Location = new System.Drawing.Point(83, 12);
      this.btnAddPhieuPhat.Name = "btnAddPhieuPhat";
      this.btnAddPhieuPhat.Size = new System.Drawing.Size(83, 32);
      this.btnAddPhieuPhat.TabIndex = 36;
      this.btnAddPhieuPhat.Text = "Tạo phiếu";
      this.btnAddPhieuPhat.UseVisualStyleBackColor = false;
      this.btnAddPhieuPhat.Click += new System.EventHandler(this.btnAddPhieuPhat_Click);
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label2.Location = new System.Drawing.Point(405, 106);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(242, 25);
      this.label2.TabIndex = 39;
      this.label2.Text = "Danh sách phiếu phạt";
      // 
      // rdbIdInfor
      // 
      this.rdbIdInfor.AutoSize = true;
      this.rdbIdInfor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.rdbIdInfor.Location = new System.Drawing.Point(20, 44);
      this.rdbIdInfor.Name = "rdbIdInfor";
      this.rdbIdInfor.Size = new System.Drawing.Size(132, 20);
      this.rdbIdInfor.TabIndex = 1;
      this.rdbIdInfor.Text = "Theo mã thông tin";
      this.rdbIdInfor.UseVisualStyleBackColor = true;
      // 
      // rdbIdAdmin
      // 
      this.rdbIdAdmin.AutoSize = true;
      this.rdbIdAdmin.Checked = true;
      this.rdbIdAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.rdbIdAdmin.Location = new System.Drawing.Point(20, 23);
      this.rdbIdAdmin.Name = "rdbIdAdmin";
      this.rdbIdAdmin.Size = new System.Drawing.Size(120, 20);
      this.rdbIdAdmin.TabIndex = 0;
      this.rdbIdAdmin.TabStop = true;
      this.rdbIdAdmin.Text = "Theo mã admin";
      this.rdbIdAdmin.UseVisualStyleBackColor = true;
      // 
      // txnSearch
      // 
      this.txnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txnSearch.Location = new System.Drawing.Point(238, 26);
      this.txnSearch.Name = "txnSearch";
      this.txnSearch.Size = new System.Drawing.Size(198, 22);
      this.txnSearch.TabIndex = 6;
      // 
      // btnSearch
      // 
      this.btnSearch.BackColor = System.Drawing.Color.Silver;
      this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnSearch.Location = new System.Drawing.Point(452, 22);
      this.btnSearch.Name = "btnSearch";
      this.btnSearch.Size = new System.Drawing.Size(75, 30);
      this.btnSearch.TabIndex = 5;
      this.btnSearch.Text = "Tìm kiếm";
      this.btnSearch.UseVisualStyleBackColor = false;
      this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
      // 
      // groupBox2
      // 
      this.groupBox2.BackColor = System.Drawing.Color.Silver;
      this.groupBox2.Controls.Add(this.rdbIdInfor);
      this.groupBox2.Controls.Add(this.rdbIdAdmin);
      this.groupBox2.Controls.Add(this.txnSearch);
      this.groupBox2.Controls.Add(this.btnSearch);
      this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.groupBox2.Location = new System.Drawing.Point(172, 12);
      this.groupBox2.Name = "groupBox2";
      this.groupBox2.Size = new System.Drawing.Size(664, 76);
      this.groupBox2.TabIndex = 40;
      this.groupBox2.TabStop = false;
      this.groupBox2.Text = "Tìm kiếm";
      // 
      // btnLoad
      // 
      this.btnLoad.BackColor = System.Drawing.Color.Silver;
      this.btnLoad.Location = new System.Drawing.Point(83, 50);
      this.btnLoad.Name = "btnLoad";
      this.btnLoad.Size = new System.Drawing.Size(83, 32);
      this.btnLoad.TabIndex = 41;
      this.btnLoad.Text = "Làm mới";
      this.btnLoad.UseVisualStyleBackColor = false;
      this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
      // 
      // fPhieuPhat
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
      this.ClientSize = new System.Drawing.Size(977, 505);
      this.Controls.Add(this.btnLoad);
      this.Controls.Add(this.dtgvListPhieuPhat);
      this.Controls.Add(this.btnAddPhieuPhat);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.groupBox2);
      this.Name = "fPhieuPhat";
      this.Text = "Phiếu phạt";
      ((System.ComponentModel.ISupportInitialize)(this.dtgvListPhieuPhat)).EndInit();
      this.groupBox2.ResumeLayout(false);
      this.groupBox2.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.DataGridView dtgvListPhieuPhat;
    private System.Windows.Forms.Button btnAddPhieuPhat;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.RadioButton rdbIdInfor;
    private System.Windows.Forms.RadioButton rdbIdAdmin;
    private System.Windows.Forms.TextBox txnSearch;
    private System.Windows.Forms.Button btnSearch;
    private System.Windows.Forms.GroupBox groupBox2;
    private System.Windows.Forms.Button btnLoad;
  }
}