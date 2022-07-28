
namespace QuanLyThuVien.FormPhieuThu
{
  partial class fAddPhieuPhat
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
      this.panel4 = new System.Windows.Forms.Panel();
      this.dtpkNgayTaoPhieu = new System.Windows.Forms.DateTimePicker();
      this.label4 = new System.Windows.Forms.Label();
      this.btnTaoPhieu = new System.Windows.Forms.Button();
      this.panel3 = new System.Windows.Forms.Panel();
      this.txbCountSachMat = new System.Windows.Forms.TextBox();
      this.label3 = new System.Windows.Forms.Label();
      this.panel2 = new System.Windows.Forms.Panel();
      this.txbCountSachQuaHan = new System.Windows.Forms.TextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.dtgvListBilInfor = new System.Windows.Forms.DataGridView();
      this.panel1 = new System.Windows.Forms.Panel();
      this.txbTenDocGia = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.panel5 = new System.Windows.Forms.Panel();
      this.cbMaDocGia = new System.Windows.Forms.ComboBox();
      this.label5 = new System.Windows.Forms.Label();
      this.panel6 = new System.Windows.Forms.Panel();
      this.txbTongTien = new System.Windows.Forms.TextBox();
      this.label6 = new System.Windows.Forms.Label();
      this.panel4.SuspendLayout();
      this.panel3.SuspendLayout();
      this.panel2.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dtgvListBilInfor)).BeginInit();
      this.panel1.SuspendLayout();
      this.panel5.SuspendLayout();
      this.panel6.SuspendLayout();
      this.SuspendLayout();
      // 
      // panel4
      // 
      this.panel4.Controls.Add(this.dtpkNgayTaoPhieu);
      this.panel4.Controls.Add(this.label4);
      this.panel4.Location = new System.Drawing.Point(12, 88);
      this.panel4.Name = "panel4";
      this.panel4.Size = new System.Drawing.Size(360, 32);
      this.panel4.TabIndex = 23;
      // 
      // dtpkNgayTaoPhieu
      // 
      this.dtpkNgayTaoPhieu.CustomFormat = "dd/MM/yyyy";
      this.dtpkNgayTaoPhieu.Enabled = false;
      this.dtpkNgayTaoPhieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.dtpkNgayTaoPhieu.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
      this.dtpkNgayTaoPhieu.Location = new System.Drawing.Point(133, 4);
      this.dtpkNgayTaoPhieu.Name = "dtpkNgayTaoPhieu";
      this.dtpkNgayTaoPhieu.Size = new System.Drawing.Size(213, 21);
      this.dtpkNgayTaoPhieu.TabIndex = 17;
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label4.Location = new System.Drawing.Point(4, 4);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(110, 18);
      this.label4.TabIndex = 0;
      this.label4.Text = "Ngày tạo phiếu:";
      // 
      // btnTaoPhieu
      // 
      this.btnTaoPhieu.Location = new System.Drawing.Point(422, 324);
      this.btnTaoPhieu.Name = "btnTaoPhieu";
      this.btnTaoPhieu.Size = new System.Drawing.Size(75, 32);
      this.btnTaoPhieu.TabIndex = 22;
      this.btnTaoPhieu.Text = "Tạo phiếu";
      this.btnTaoPhieu.UseVisualStyleBackColor = true;
      this.btnTaoPhieu.Click += new System.EventHandler(this.btnTaoPhieu_Click);
      // 
      // panel3
      // 
      this.panel3.Controls.Add(this.txbCountSachMat);
      this.panel3.Controls.Add(this.label3);
      this.panel3.Location = new System.Drawing.Point(272, 282);
      this.panel3.Name = "panel3";
      this.panel3.Size = new System.Drawing.Size(225, 32);
      this.panel3.TabIndex = 21;
      // 
      // txbCountSachMat
      // 
      this.txbCountSachMat.Location = new System.Drawing.Point(106, 5);
      this.txbCountSachMat.Name = "txbCountSachMat";
      this.txbCountSachMat.ReadOnly = true;
      this.txbCountSachMat.Size = new System.Drawing.Size(109, 20);
      this.txbCountSachMat.TabIndex = 3;
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label3.Location = new System.Drawing.Point(4, 4);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(96, 18);
      this.label3.TabIndex = 0;
      this.label3.Text = "Số sách mất:";
      // 
      // panel2
      // 
      this.panel2.Controls.Add(this.txbCountSachQuaHan);
      this.panel2.Controls.Add(this.label2);
      this.panel2.Location = new System.Drawing.Point(12, 282);
      this.panel2.Name = "panel2";
      this.panel2.Size = new System.Drawing.Size(254, 32);
      this.panel2.TabIndex = 20;
      // 
      // txbCountSachQuaHan
      // 
      this.txbCountSachQuaHan.Location = new System.Drawing.Point(133, 5);
      this.txbCountSachQuaHan.Name = "txbCountSachQuaHan";
      this.txbCountSachQuaHan.ReadOnly = true;
      this.txbCountSachQuaHan.Size = new System.Drawing.Size(109, 20);
      this.txbCountSachQuaHan.TabIndex = 3;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label2.Location = new System.Drawing.Point(4, 4);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(123, 18);
      this.label2.TabIndex = 0;
      this.label2.Text = "Số sách quá hạn:";
      // 
      // dtgvListBilInfor
      // 
      this.dtgvListBilInfor.AllowUserToAddRows = false;
      this.dtgvListBilInfor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dtgvListBilInfor.Location = new System.Drawing.Point(12, 126);
      this.dtgvListBilInfor.Name = "dtgvListBilInfor";
      this.dtgvListBilInfor.Size = new System.Drawing.Size(485, 150);
      this.dtgvListBilInfor.TabIndex = 19;
      // 
      // panel1
      // 
      this.panel1.Controls.Add(this.txbTenDocGia);
      this.panel1.Controls.Add(this.label1);
      this.panel1.Location = new System.Drawing.Point(12, 50);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(360, 32);
      this.panel1.TabIndex = 18;
      // 
      // txbTenDocGia
      // 
      this.txbTenDocGia.Location = new System.Drawing.Point(133, 5);
      this.txbTenDocGia.Name = "txbTenDocGia";
      this.txbTenDocGia.ReadOnly = true;
      this.txbTenDocGia.Size = new System.Drawing.Size(213, 20);
      this.txbTenDocGia.TabIndex = 3;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.Location = new System.Drawing.Point(4, 4);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(85, 18);
      this.label1.TabIndex = 0;
      this.label1.Text = "Tên độc giả";
      // 
      // panel5
      // 
      this.panel5.Controls.Add(this.cbMaDocGia);
      this.panel5.Controls.Add(this.label5);
      this.panel5.Location = new System.Drawing.Point(12, 12);
      this.panel5.Name = "panel5";
      this.panel5.Size = new System.Drawing.Size(360, 32);
      this.panel5.TabIndex = 17;
      // 
      // cbMaDocGia
      // 
      this.cbMaDocGia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cbMaDocGia.FormattingEnabled = true;
      this.cbMaDocGia.Location = new System.Drawing.Point(133, 5);
      this.cbMaDocGia.Name = "cbMaDocGia";
      this.cbMaDocGia.Size = new System.Drawing.Size(213, 21);
      this.cbMaDocGia.TabIndex = 1;
      this.cbMaDocGia.SelectedIndexChanged += new System.EventHandler(this.cbMaDocGia_SelectedIndexChanged);
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label5.Location = new System.Drawing.Point(4, 4);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(85, 18);
      this.label5.TabIndex = 0;
      this.label5.Text = "Mã độc giả:";
      // 
      // panel6
      // 
      this.panel6.Controls.Add(this.txbTongTien);
      this.panel6.Controls.Add(this.label6);
      this.panel6.Location = new System.Drawing.Point(12, 320);
      this.panel6.Name = "panel6";
      this.panel6.Size = new System.Drawing.Size(254, 32);
      this.panel6.TabIndex = 24;
      // 
      // txbTongTien
      // 
      this.txbTongTien.Location = new System.Drawing.Point(133, 5);
      this.txbTongTien.Name = "txbTongTien";
      this.txbTongTien.ReadOnly = true;
      this.txbTongTien.Size = new System.Drawing.Size(109, 20);
      this.txbTongTien.TabIndex = 3;
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label6.Location = new System.Drawing.Point(4, 4);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(73, 18);
      this.label6.TabIndex = 0;
      this.label6.Text = "Tổng tiền:";
      // 
      // fAddPhieuPhat
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(519, 370);
      this.Controls.Add(this.panel6);
      this.Controls.Add(this.panel4);
      this.Controls.Add(this.btnTaoPhieu);
      this.Controls.Add(this.panel3);
      this.Controls.Add(this.panel2);
      this.Controls.Add(this.dtgvListBilInfor);
      this.Controls.Add(this.panel1);
      this.Controls.Add(this.panel5);
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "fAddPhieuPhat";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Tạo phiếu phạt";
      this.panel4.ResumeLayout(false);
      this.panel4.PerformLayout();
      this.panel3.ResumeLayout(false);
      this.panel3.PerformLayout();
      this.panel2.ResumeLayout(false);
      this.panel2.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dtgvListBilInfor)).EndInit();
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      this.panel5.ResumeLayout(false);
      this.panel5.PerformLayout();
      this.panel6.ResumeLayout(false);
      this.panel6.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Panel panel4;
    private System.Windows.Forms.DateTimePicker dtpkNgayTaoPhieu;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Button btnTaoPhieu;
    private System.Windows.Forms.Panel panel3;
    private System.Windows.Forms.TextBox txbCountSachMat;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Panel panel2;
    private System.Windows.Forms.TextBox txbCountSachQuaHan;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.DataGridView dtgvListBilInfor;
    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.TextBox txbTenDocGia;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Panel panel5;
    private System.Windows.Forms.ComboBox cbMaDocGia;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.Panel panel6;
    private System.Windows.Forms.TextBox txbTongTien;
    private System.Windows.Forms.Label label6;
  }
}