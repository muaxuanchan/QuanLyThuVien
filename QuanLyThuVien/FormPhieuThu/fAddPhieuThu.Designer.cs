
namespace QuanLyThuVien.FormPhieuThu
{
  partial class fAddPhieuThu
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
      this.btnInDu = new System.Windows.Forms.Button();
      this.panel6 = new System.Windows.Forms.Panel();
      this.label6 = new System.Windows.Forms.Label();
      this.panel7 = new System.Windows.Forms.Panel();
      this.dtpkNgayThu = new System.Windows.Forms.DateTimePicker();
      this.label7 = new System.Windows.Forms.Label();
      this.panel8 = new System.Windows.Forms.Panel();
      this.nudTienThu = new System.Windows.Forms.NumericUpDown();
      this.label8 = new System.Windows.Forms.Label();
      this.panel9 = new System.Windows.Forms.Panel();
      this.txbTongTienPhat = new System.Windows.Forms.TextBox();
      this.label9 = new System.Windows.Forms.Label();
      this.btnTaoPhieu = new System.Windows.Forms.Button();
      this.panel10 = new System.Windows.Forms.Panel();
      this.txbTenDocGia = new System.Windows.Forms.TextBox();
      this.label10 = new System.Windows.Forms.Label();
      this.panel11 = new System.Windows.Forms.Panel();
      this.cbMaDocGia = new System.Windows.Forms.ComboBox();
      this.label11 = new System.Windows.Forms.Label();
      this.btnRefresh = new System.Windows.Forms.Button();
      this.txbConLai = new System.Windows.Forms.TextBox();
      this.panel6.SuspendLayout();
      this.panel7.SuspendLayout();
      this.panel8.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.nudTienThu)).BeginInit();
      this.panel9.SuspendLayout();
      this.panel10.SuspendLayout();
      this.panel11.SuspendLayout();
      this.SuspendLayout();
      // 
      // btnInDu
      // 
      this.btnInDu.Location = new System.Drawing.Point(310, 161);
      this.btnInDu.Name = "btnInDu";
      this.btnInDu.Size = new System.Drawing.Size(61, 32);
      this.btnInDu.TabIndex = 35;
      this.btnInDu.Text = "In dư";
      this.btnInDu.UseVisualStyleBackColor = true;
      this.btnInDu.Click += new System.EventHandler(this.button1_Click);
      // 
      // panel6
      // 
      this.panel6.Controls.Add(this.txbConLai);
      this.panel6.Controls.Add(this.label6);
      this.panel6.Location = new System.Drawing.Point(12, 161);
      this.panel6.Name = "panel6";
      this.panel6.Size = new System.Drawing.Size(292, 32);
      this.panel6.TabIndex = 34;
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label6.Location = new System.Drawing.Point(4, 4);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(58, 18);
      this.label6.TabIndex = 0;
      this.label6.Text = "Còn lại:";
      // 
      // panel7
      // 
      this.panel7.Controls.Add(this.dtpkNgayThu);
      this.panel7.Controls.Add(this.label7);
      this.panel7.Location = new System.Drawing.Point(12, 194);
      this.panel7.Name = "panel7";
      this.panel7.Size = new System.Drawing.Size(362, 32);
      this.panel7.TabIndex = 33;
      // 
      // dtpkNgayThu
      // 
      this.dtpkNgayThu.CustomFormat = "dd/MM/yyyy";
      this.dtpkNgayThu.Enabled = false;
      this.dtpkNgayThu.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
      this.dtpkNgayThu.Location = new System.Drawing.Point(133, 4);
      this.dtpkNgayThu.Name = "dtpkNgayThu";
      this.dtpkNgayThu.Size = new System.Drawing.Size(226, 20);
      this.dtpkNgayThu.TabIndex = 1;
      // 
      // label7
      // 
      this.label7.AutoSize = true;
      this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label7.Location = new System.Drawing.Point(4, 4);
      this.label7.Name = "label7";
      this.label7.Size = new System.Drawing.Size(70, 18);
      this.label7.TabIndex = 0;
      this.label7.Text = "Ngày thu:";
      // 
      // panel8
      // 
      this.panel8.Controls.Add(this.nudTienThu);
      this.panel8.Controls.Add(this.label8);
      this.panel8.Location = new System.Drawing.Point(12, 126);
      this.panel8.Name = "panel8";
      this.panel8.Size = new System.Drawing.Size(362, 32);
      this.panel8.TabIndex = 32;
      // 
      // nudTienThu
      // 
      this.nudTienThu.Location = new System.Drawing.Point(133, 6);
      this.nudTienThu.Maximum = new decimal(new int[] {
            999999999,
            0,
            0,
            0});
      this.nudTienThu.Name = "nudTienThu";
      this.nudTienThu.Size = new System.Drawing.Size(226, 20);
      this.nudTienThu.TabIndex = 1;
      // 
      // label8
      // 
      this.label8.AutoSize = true;
      this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label8.Location = new System.Drawing.Point(4, 4);
      this.label8.Name = "label8";
      this.label8.Size = new System.Drawing.Size(82, 18);
      this.label8.TabIndex = 0;
      this.label8.Text = "Số tiền thu:";
      // 
      // panel9
      // 
      this.panel9.Controls.Add(this.txbTongTienPhat);
      this.panel9.Controls.Add(this.label9);
      this.panel9.Location = new System.Drawing.Point(12, 88);
      this.panel9.Name = "panel9";
      this.panel9.Size = new System.Drawing.Size(362, 32);
      this.panel9.TabIndex = 31;
      // 
      // txbTongTienPhat
      // 
      this.txbTongTienPhat.Location = new System.Drawing.Point(133, 5);
      this.txbTongTienPhat.Name = "txbTongTienPhat";
      this.txbTongTienPhat.ReadOnly = true;
      this.txbTongTienPhat.Size = new System.Drawing.Size(226, 20);
      this.txbTongTienPhat.TabIndex = 3;
      // 
      // label9
      // 
      this.label9.AutoSize = true;
      this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label9.Location = new System.Drawing.Point(4, 4);
      this.label9.Name = "label9";
      this.label9.Size = new System.Drawing.Size(105, 18);
      this.label9.TabIndex = 0;
      this.label9.Text = "Tổng tiền phạt:";
      // 
      // btnTaoPhieu
      // 
      this.btnTaoPhieu.Enabled = false;
      this.btnTaoPhieu.Location = new System.Drawing.Point(299, 232);
      this.btnTaoPhieu.Name = "btnTaoPhieu";
      this.btnTaoPhieu.Size = new System.Drawing.Size(75, 32);
      this.btnTaoPhieu.TabIndex = 30;
      this.btnTaoPhieu.Text = "Tạo phiếu";
      this.btnTaoPhieu.UseVisualStyleBackColor = true;
      this.btnTaoPhieu.Click += new System.EventHandler(this.btnTaoPhieu_Click);
      // 
      // panel10
      // 
      this.panel10.Controls.Add(this.txbTenDocGia);
      this.panel10.Controls.Add(this.label10);
      this.panel10.Location = new System.Drawing.Point(12, 50);
      this.panel10.Name = "panel10";
      this.panel10.Size = new System.Drawing.Size(362, 32);
      this.panel10.TabIndex = 29;
      // 
      // txbTenDocGia
      // 
      this.txbTenDocGia.Location = new System.Drawing.Point(133, 5);
      this.txbTenDocGia.Name = "txbTenDocGia";
      this.txbTenDocGia.ReadOnly = true;
      this.txbTenDocGia.Size = new System.Drawing.Size(226, 20);
      this.txbTenDocGia.TabIndex = 3;
      // 
      // label10
      // 
      this.label10.AutoSize = true;
      this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label10.Location = new System.Drawing.Point(4, 4);
      this.label10.Name = "label10";
      this.label10.Size = new System.Drawing.Size(85, 18);
      this.label10.TabIndex = 0;
      this.label10.Text = "Tên độc giả";
      // 
      // panel11
      // 
      this.panel11.Controls.Add(this.cbMaDocGia);
      this.panel11.Controls.Add(this.label11);
      this.panel11.Location = new System.Drawing.Point(12, 12);
      this.panel11.Name = "panel11";
      this.panel11.Size = new System.Drawing.Size(362, 32);
      this.panel11.TabIndex = 28;
      // 
      // cbMaDocGia
      // 
      this.cbMaDocGia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cbMaDocGia.FormattingEnabled = true;
      this.cbMaDocGia.Location = new System.Drawing.Point(133, 8);
      this.cbMaDocGia.Name = "cbMaDocGia";
      this.cbMaDocGia.Size = new System.Drawing.Size(226, 21);
      this.cbMaDocGia.TabIndex = 1;
      this.cbMaDocGia.SelectedIndexChanged += new System.EventHandler(this.cbMaDocGia_SelectedIndexChanged);
      // 
      // label11
      // 
      this.label11.AutoSize = true;
      this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label11.Location = new System.Drawing.Point(4, 4);
      this.label11.Name = "label11";
      this.label11.Size = new System.Drawing.Size(85, 18);
      this.label11.TabIndex = 0;
      this.label11.Text = "Mã độc giả:";
      // 
      // btnRefresh
      // 
      this.btnRefresh.Location = new System.Drawing.Point(11, 232);
      this.btnRefresh.Name = "btnRefresh";
      this.btnRefresh.Size = new System.Drawing.Size(75, 32);
      this.btnRefresh.TabIndex = 36;
      this.btnRefresh.Text = "Tạo phiếu";
      this.btnRefresh.UseVisualStyleBackColor = true;
      this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
      // 
      // txbConLai
      // 
      this.txbConLai.Location = new System.Drawing.Point(133, 5);
      this.txbConLai.Name = "txbConLai";
      this.txbConLai.ReadOnly = true;
      this.txbConLai.Size = new System.Drawing.Size(156, 20);
      this.txbConLai.TabIndex = 4;
      // 
      // fAddPhieuThu
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(388, 280);
      this.Controls.Add(this.btnRefresh);
      this.Controls.Add(this.btnInDu);
      this.Controls.Add(this.panel6);
      this.Controls.Add(this.panel7);
      this.Controls.Add(this.panel8);
      this.Controls.Add(this.panel9);
      this.Controls.Add(this.btnTaoPhieu);
      this.Controls.Add(this.panel10);
      this.Controls.Add(this.panel11);
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "fAddPhieuThu";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Tạo phiếu thu";
      this.panel6.ResumeLayout(false);
      this.panel6.PerformLayout();
      this.panel7.ResumeLayout(false);
      this.panel7.PerformLayout();
      this.panel8.ResumeLayout(false);
      this.panel8.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.nudTienThu)).EndInit();
      this.panel9.ResumeLayout(false);
      this.panel9.PerformLayout();
      this.panel10.ResumeLayout(false);
      this.panel10.PerformLayout();
      this.panel11.ResumeLayout(false);
      this.panel11.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion
    private System.Windows.Forms.Button btnInDu;
    private System.Windows.Forms.Panel panel6;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.Panel panel7;
    private System.Windows.Forms.DateTimePicker dtpkNgayThu;
    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.Panel panel8;
    private System.Windows.Forms.NumericUpDown nudTienThu;
    private System.Windows.Forms.Label label8;
    private System.Windows.Forms.Panel panel9;
    private System.Windows.Forms.TextBox txbTongTienPhat;
    private System.Windows.Forms.Label label9;
    private System.Windows.Forms.Button btnTaoPhieu;
    private System.Windows.Forms.Panel panel10;
    private System.Windows.Forms.TextBox txbTenDocGia;
    private System.Windows.Forms.Label label10;
    private System.Windows.Forms.Panel panel11;
    private System.Windows.Forms.ComboBox cbMaDocGia;
    private System.Windows.Forms.Label label11;
    private System.Windows.Forms.Button btnRefresh;
    private System.Windows.Forms.TextBox txbConLai;
  }
}