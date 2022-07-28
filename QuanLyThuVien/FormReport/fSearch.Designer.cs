
namespace QuanLyThuVien.FormReport
{
  partial class fSearch
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
      this.btnSearchDocGia = new System.Windows.Forms.Button();
      this.btnSearchSach = new System.Windows.Forms.Button();
      this.plTypeSearchButton = new System.Windows.Forms.Panel();
      this.btnSearchPhieuMuon = new System.Windows.Forms.Button();
      this.plSearchDocGia = new System.Windows.Forms.Panel();
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.rbSearchDocGia = new System.Windows.Forms.RadioButton();
      this.btnSearch = new System.Windows.Forms.Button();
      this.label1 = new System.Windows.Forms.Label();
      this.lbTo = new System.Windows.Forms.Label();
      this.cbTypeSearchDocGia = new System.Windows.Forms.ComboBox();
      this.dtpkDateToSearchDocGia = new System.Windows.Forms.DateTimePicker();
      this.lbFrom = new System.Windows.Forms.Label();
      this.txbSearchIDDocGia = new System.Windows.Forms.TextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.dtpkDateFromSearchDocGia = new System.Windows.Forms.DateTimePicker();
      this.plSearchSach = new System.Windows.Forms.Panel();
      this.groupBox2 = new System.Windows.Forms.GroupBox();
      this.label9 = new System.Windows.Forms.Label();
      this.txbSearchSach = new System.Windows.Forms.TextBox();
      this.rdSearchSach = new System.Windows.Forms.RadioButton();
      this.btnAddTimeSach = new System.Windows.Forms.Button();
      this.label5 = new System.Windows.Forms.Label();
      this.dtpkDateToSearchSach = new System.Windows.Forms.DateTimePicker();
      this.label6 = new System.Windows.Forms.Label();
      this.dtpkDateFromSearchSach = new System.Windows.Forms.DateTimePicker();
      this.cbTypeSearchSach = new System.Windows.Forms.ComboBox();
      this.label3 = new System.Windows.Forms.Label();
      this.plSearchButton = new System.Windows.Forms.Panel();
      this.button2 = new System.Windows.Forms.Button();
      this.plPhieuMuon = new System.Windows.Forms.Panel();
      this.groupBox3 = new System.Windows.Forms.GroupBox();
      this.rbSearchPhieuMuon = new System.Windows.Forms.RadioButton();
      this.btnAddTimePhieuMuon = new System.Windows.Forms.Button();
      this.label7 = new System.Windows.Forms.Label();
      this.dtpkDateToPhieuMuon = new System.Windows.Forms.DateTimePicker();
      this.label8 = new System.Windows.Forms.Label();
      this.dtpkDateFromPhieuMuon = new System.Windows.Forms.DateTimePicker();
      this.cbTypeSearchPhieuMuon = new System.Windows.Forms.ComboBox();
      this.label4 = new System.Windows.Forms.Label();
      this.plDataGridView = new System.Windows.Forms.Panel();
      this.dtgvSearch = new System.Windows.Forms.DataGridView();
      this.plTypeSearchButton.SuspendLayout();
      this.plSearchDocGia.SuspendLayout();
      this.groupBox1.SuspendLayout();
      this.plSearchSach.SuspendLayout();
      this.groupBox2.SuspendLayout();
      this.plSearchButton.SuspendLayout();
      this.plPhieuMuon.SuspendLayout();
      this.groupBox3.SuspendLayout();
      this.plDataGridView.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dtgvSearch)).BeginInit();
      this.SuspendLayout();
      // 
      // btnSearchDocGia
      // 
      this.btnSearchDocGia.BackColor = System.Drawing.Color.Silver;
      this.btnSearchDocGia.Location = new System.Drawing.Point(3, 3);
      this.btnSearchDocGia.Name = "btnSearchDocGia";
      this.btnSearchDocGia.Size = new System.Drawing.Size(89, 52);
      this.btnSearchDocGia.TabIndex = 0;
      this.btnSearchDocGia.Text = "Độc giả";
      this.btnSearchDocGia.UseVisualStyleBackColor = false;
      this.btnSearchDocGia.Click += new System.EventHandler(this.btnSearchDocGia_Click);
      // 
      // btnSearchSach
      // 
      this.btnSearchSach.BackColor = System.Drawing.Color.Silver;
      this.btnSearchSach.Location = new System.Drawing.Point(232, 3);
      this.btnSearchSach.Name = "btnSearchSach";
      this.btnSearchSach.Size = new System.Drawing.Size(105, 52);
      this.btnSearchSach.TabIndex = 1;
      this.btnSearchSach.Text = "Sách";
      this.btnSearchSach.UseVisualStyleBackColor = false;
      this.btnSearchSach.Click += new System.EventHandler(this.btnSearchSach_Click);
      // 
      // plTypeSearchButton
      // 
      this.plTypeSearchButton.Controls.Add(this.btnSearchPhieuMuon);
      this.plTypeSearchButton.Controls.Add(this.btnSearchDocGia);
      this.plTypeSearchButton.Controls.Add(this.btnSearchSach);
      this.plTypeSearchButton.Dock = System.Windows.Forms.DockStyle.Top;
      this.plTypeSearchButton.Location = new System.Drawing.Point(0, 0);
      this.plTypeSearchButton.Name = "plTypeSearchButton";
      this.plTypeSearchButton.Size = new System.Drawing.Size(807, 61);
      this.plTypeSearchButton.TabIndex = 2;
      // 
      // btnSearchPhieuMuon
      // 
      this.btnSearchPhieuMuon.BackColor = System.Drawing.Color.Silver;
      this.btnSearchPhieuMuon.Location = new System.Drawing.Point(107, 3);
      this.btnSearchPhieuMuon.Name = "btnSearchPhieuMuon";
      this.btnSearchPhieuMuon.Size = new System.Drawing.Size(105, 52);
      this.btnSearchPhieuMuon.TabIndex = 2;
      this.btnSearchPhieuMuon.Text = "Phiếu mượn";
      this.btnSearchPhieuMuon.UseVisualStyleBackColor = false;
      this.btnSearchPhieuMuon.Click += new System.EventHandler(this.btnSearchPhieuMuon_Click);
      // 
      // plSearchDocGia
      // 
      this.plSearchDocGia.BackColor = System.Drawing.Color.Silver;
      this.plSearchDocGia.Controls.Add(this.groupBox1);
      this.plSearchDocGia.Dock = System.Windows.Forms.DockStyle.Top;
      this.plSearchDocGia.Location = new System.Drawing.Point(0, 61);
      this.plSearchDocGia.Name = "plSearchDocGia";
      this.plSearchDocGia.Size = new System.Drawing.Size(807, 88);
      this.plSearchDocGia.TabIndex = 3;
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.rbSearchDocGia);
      this.groupBox1.Controls.Add(this.btnSearch);
      this.groupBox1.Controls.Add(this.label1);
      this.groupBox1.Controls.Add(this.lbTo);
      this.groupBox1.Controls.Add(this.cbTypeSearchDocGia);
      this.groupBox1.Controls.Add(this.dtpkDateToSearchDocGia);
      this.groupBox1.Controls.Add(this.lbFrom);
      this.groupBox1.Controls.Add(this.txbSearchIDDocGia);
      this.groupBox1.Controls.Add(this.label2);
      this.groupBox1.Controls.Add(this.dtpkDateFromSearchDocGia);
      this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.groupBox1.Location = new System.Drawing.Point(0, 0);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(807, 88);
      this.groupBox1.TabIndex = 1;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Tìm kiếm độc giả";
      // 
      // rbSearchDocGia
      // 
      this.rbSearchDocGia.AutoSize = true;
      this.rbSearchDocGia.Location = new System.Drawing.Point(510, 23);
      this.rbSearchDocGia.Name = "rbSearchDocGia";
      this.rbSearchDocGia.Size = new System.Drawing.Size(14, 13);
      this.rbSearchDocGia.TabIndex = 5;
      this.rbSearchDocGia.UseVisualStyleBackColor = true;
      // 
      // btnSearch
      // 
      this.btnSearch.BackColor = System.Drawing.Color.Silver;
      this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnSearch.Location = new System.Drawing.Point(392, 13);
      this.btnSearch.Name = "btnSearch";
      this.btnSearch.Size = new System.Drawing.Size(113, 31);
      this.btnSearch.TabIndex = 4;
      this.btnSearch.Text = "Thêm thời gian";
      this.btnSearch.UseVisualStyleBackColor = false;
      this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(13, 26);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(124, 18);
      this.label1.TabIndex = 1;
      this.label1.Text = "Nhập mã độc giả:";
      // 
      // lbTo
      // 
      this.lbTo.AutoSize = true;
      this.lbTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lbTo.Location = new System.Drawing.Point(541, 42);
      this.lbTo.Name = "lbTo";
      this.lbTo.Size = new System.Drawing.Size(74, 18);
      this.lbTo.TabIndex = 3;
      this.lbTo.Text = "Đến ngày:";
      // 
      // cbTypeSearchDocGia
      // 
      this.cbTypeSearchDocGia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cbTypeSearchDocGia.FormattingEnabled = true;
      this.cbTypeSearchDocGia.Location = new System.Drawing.Point(179, 53);
      this.cbTypeSearchDocGia.Name = "cbTypeSearchDocGia";
      this.cbTypeSearchDocGia.Size = new System.Drawing.Size(143, 26);
      this.cbTypeSearchDocGia.TabIndex = 3;
      // 
      // dtpkDateToSearchDocGia
      // 
      this.dtpkDateToSearchDocGia.CustomFormat = "dd/MM/yyyy";
      this.dtpkDateToSearchDocGia.Enabled = false;
      this.dtpkDateToSearchDocGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.dtpkDateToSearchDocGia.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
      this.dtpkDateToSearchDocGia.Location = new System.Drawing.Point(624, 42);
      this.dtpkDateToSearchDocGia.Name = "dtpkDateToSearchDocGia";
      this.dtpkDateToSearchDocGia.Size = new System.Drawing.Size(153, 22);
      this.dtpkDateToSearchDocGia.TabIndex = 1;
      // 
      // lbFrom
      // 
      this.lbFrom.AutoSize = true;
      this.lbFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lbFrom.Location = new System.Drawing.Point(546, 16);
      this.lbFrom.Name = "lbFrom";
      this.lbFrom.Size = new System.Drawing.Size(64, 18);
      this.lbFrom.TabIndex = 2;
      this.lbFrom.Text = "Từ ngày:";
      // 
      // txbSearchIDDocGia
      // 
      this.txbSearchIDDocGia.Location = new System.Drawing.Point(180, 23);
      this.txbSearchIDDocGia.Name = "txbSearchIDDocGia";
      this.txbSearchIDDocGia.Size = new System.Drawing.Size(142, 24);
      this.txbSearchIDDocGia.TabIndex = 0;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(13, 56);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(129, 18);
      this.label2.TabIndex = 2;
      this.label2.Text = "Thông tin tìm kiếm";
      // 
      // dtpkDateFromSearchDocGia
      // 
      this.dtpkDateFromSearchDocGia.CustomFormat = "dd/MM/yyyy";
      this.dtpkDateFromSearchDocGia.Enabled = false;
      this.dtpkDateFromSearchDocGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.dtpkDateFromSearchDocGia.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
      this.dtpkDateFromSearchDocGia.Location = new System.Drawing.Point(624, 14);
      this.dtpkDateFromSearchDocGia.Name = "dtpkDateFromSearchDocGia";
      this.dtpkDateFromSearchDocGia.Size = new System.Drawing.Size(153, 22);
      this.dtpkDateFromSearchDocGia.TabIndex = 0;
      // 
      // plSearchSach
      // 
      this.plSearchSach.BackColor = System.Drawing.Color.Silver;
      this.plSearchSach.Controls.Add(this.groupBox2);
      this.plSearchSach.Dock = System.Windows.Forms.DockStyle.Top;
      this.plSearchSach.Location = new System.Drawing.Point(0, 149);
      this.plSearchSach.Name = "plSearchSach";
      this.plSearchSach.Size = new System.Drawing.Size(807, 76);
      this.plSearchSach.TabIndex = 4;
      // 
      // groupBox2
      // 
      this.groupBox2.Controls.Add(this.label9);
      this.groupBox2.Controls.Add(this.txbSearchSach);
      this.groupBox2.Controls.Add(this.rdSearchSach);
      this.groupBox2.Controls.Add(this.btnAddTimeSach);
      this.groupBox2.Controls.Add(this.label5);
      this.groupBox2.Controls.Add(this.dtpkDateToSearchSach);
      this.groupBox2.Controls.Add(this.label6);
      this.groupBox2.Controls.Add(this.dtpkDateFromSearchSach);
      this.groupBox2.Controls.Add(this.cbTypeSearchSach);
      this.groupBox2.Controls.Add(this.label3);
      this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
      this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.groupBox2.Location = new System.Drawing.Point(0, 0);
      this.groupBox2.Name = "groupBox2";
      this.groupBox2.Size = new System.Drawing.Size(807, 76);
      this.groupBox2.TabIndex = 2;
      this.groupBox2.TabStop = false;
      this.groupBox2.Text = "Tìm kiếm sách";
      // 
      // label9
      // 
      this.label9.AutoSize = true;
      this.label9.Location = new System.Drawing.Point(8, 48);
      this.label9.Name = "label9";
      this.label9.Size = new System.Drawing.Size(108, 18);
      this.label9.TabIndex = 13;
      this.label9.Text = "Nhập mã sách:";
      // 
      // txbSearchSach
      // 
      this.txbSearchSach.Location = new System.Drawing.Point(175, 46);
      this.txbSearchSach.Name = "txbSearchSach";
      this.txbSearchSach.Size = new System.Drawing.Size(142, 24);
      this.txbSearchSach.TabIndex = 12;
      // 
      // rdSearchSach
      // 
      this.rdSearchSach.AutoSize = true;
      this.rdSearchSach.Location = new System.Drawing.Point(511, 23);
      this.rdSearchSach.Name = "rdSearchSach";
      this.rdSearchSach.Size = new System.Drawing.Size(14, 13);
      this.rdSearchSach.TabIndex = 11;
      this.rdSearchSach.UseVisualStyleBackColor = true;
      // 
      // btnAddTimeSach
      // 
      this.btnAddTimeSach.BackColor = System.Drawing.Color.Silver;
      this.btnAddTimeSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnAddTimeSach.Location = new System.Drawing.Point(392, 16);
      this.btnAddTimeSach.Name = "btnAddTimeSach";
      this.btnAddTimeSach.Size = new System.Drawing.Size(113, 31);
      this.btnAddTimeSach.TabIndex = 10;
      this.btnAddTimeSach.Text = "Thêm thời gian";
      this.btnAddTimeSach.UseVisualStyleBackColor = false;
      this.btnAddTimeSach.Click += new System.EventHandler(this.button4_Click);
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label5.Location = new System.Drawing.Point(541, 42);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(74, 18);
      this.label5.TabIndex = 9;
      this.label5.Text = "Đến ngày:";
      // 
      // dtpkDateToSearchSach
      // 
      this.dtpkDateToSearchSach.CustomFormat = "dd/MM/yyyy";
      this.dtpkDateToSearchSach.Enabled = false;
      this.dtpkDateToSearchSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.dtpkDateToSearchSach.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
      this.dtpkDateToSearchSach.Location = new System.Drawing.Point(624, 42);
      this.dtpkDateToSearchSach.Name = "dtpkDateToSearchSach";
      this.dtpkDateToSearchSach.Size = new System.Drawing.Size(153, 22);
      this.dtpkDateToSearchSach.TabIndex = 7;
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label6.Location = new System.Drawing.Point(546, 16);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(64, 18);
      this.label6.TabIndex = 8;
      this.label6.Text = "Từ ngày:";
      // 
      // dtpkDateFromSearchSach
      // 
      this.dtpkDateFromSearchSach.CustomFormat = "dd/MM/yyyy";
      this.dtpkDateFromSearchSach.Enabled = false;
      this.dtpkDateFromSearchSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.dtpkDateFromSearchSach.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
      this.dtpkDateFromSearchSach.Location = new System.Drawing.Point(624, 14);
      this.dtpkDateFromSearchSach.Name = "dtpkDateFromSearchSach";
      this.dtpkDateFromSearchSach.Size = new System.Drawing.Size(153, 22);
      this.dtpkDateFromSearchSach.TabIndex = 6;
      // 
      // cbTypeSearchSach
      // 
      this.cbTypeSearchSach.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cbTypeSearchSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.cbTypeSearchSach.FormattingEnabled = true;
      this.cbTypeSearchSach.Location = new System.Drawing.Point(175, 16);
      this.cbTypeSearchSach.Name = "cbTypeSearchSach";
      this.cbTypeSearchSach.Size = new System.Drawing.Size(142, 24);
      this.cbTypeSearchSach.TabIndex = 5;
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label3.Location = new System.Drawing.Point(8, 23);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(129, 18);
      this.label3.TabIndex = 4;
      this.label3.Text = "Thông tin tìm kiếm";
      // 
      // plSearchButton
      // 
      this.plSearchButton.Controls.Add(this.button2);
      this.plSearchButton.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.plSearchButton.Location = new System.Drawing.Point(0, 470);
      this.plSearchButton.Name = "plSearchButton";
      this.plSearchButton.Size = new System.Drawing.Size(807, 45);
      this.plSearchButton.TabIndex = 5;
      // 
      // button2
      // 
      this.button2.BackColor = System.Drawing.Color.Silver;
      this.button2.Location = new System.Drawing.Point(3, 3);
      this.button2.Name = "button2";
      this.button2.Size = new System.Drawing.Size(66, 39);
      this.button2.TabIndex = 3;
      this.button2.Text = "Tìm kiếm";
      this.button2.UseVisualStyleBackColor = false;
      this.button2.Click += new System.EventHandler(this.button2_Click);
      // 
      // plPhieuMuon
      // 
      this.plPhieuMuon.BackColor = System.Drawing.Color.Silver;
      this.plPhieuMuon.Controls.Add(this.groupBox3);
      this.plPhieuMuon.Dock = System.Windows.Forms.DockStyle.Top;
      this.plPhieuMuon.Location = new System.Drawing.Point(0, 225);
      this.plPhieuMuon.Name = "plPhieuMuon";
      this.plPhieuMuon.Size = new System.Drawing.Size(807, 88);
      this.plPhieuMuon.TabIndex = 6;
      // 
      // groupBox3
      // 
      this.groupBox3.Controls.Add(this.rbSearchPhieuMuon);
      this.groupBox3.Controls.Add(this.btnAddTimePhieuMuon);
      this.groupBox3.Controls.Add(this.label7);
      this.groupBox3.Controls.Add(this.dtpkDateToPhieuMuon);
      this.groupBox3.Controls.Add(this.label8);
      this.groupBox3.Controls.Add(this.dtpkDateFromPhieuMuon);
      this.groupBox3.Controls.Add(this.cbTypeSearchPhieuMuon);
      this.groupBox3.Controls.Add(this.label4);
      this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
      this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.groupBox3.Location = new System.Drawing.Point(0, 0);
      this.groupBox3.Name = "groupBox3";
      this.groupBox3.Size = new System.Drawing.Size(807, 88);
      this.groupBox3.TabIndex = 3;
      this.groupBox3.TabStop = false;
      this.groupBox3.Text = "Tìm kiếm phiếu mượn";
      // 
      // rbSearchPhieuMuon
      // 
      this.rbSearchPhieuMuon.AutoSize = true;
      this.rbSearchPhieuMuon.Location = new System.Drawing.Point(511, 33);
      this.rbSearchPhieuMuon.Name = "rbSearchPhieuMuon";
      this.rbSearchPhieuMuon.Size = new System.Drawing.Size(14, 13);
      this.rbSearchPhieuMuon.TabIndex = 11;
      this.rbSearchPhieuMuon.UseVisualStyleBackColor = true;
      // 
      // btnAddTimePhieuMuon
      // 
      this.btnAddTimePhieuMuon.BackColor = System.Drawing.Color.Silver;
      this.btnAddTimePhieuMuon.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnAddTimePhieuMuon.Location = new System.Drawing.Point(392, 23);
      this.btnAddTimePhieuMuon.Name = "btnAddTimePhieuMuon";
      this.btnAddTimePhieuMuon.Size = new System.Drawing.Size(113, 29);
      this.btnAddTimePhieuMuon.TabIndex = 10;
      this.btnAddTimePhieuMuon.Text = "Thêm thời gian";
      this.btnAddTimePhieuMuon.UseVisualStyleBackColor = false;
      this.btnAddTimePhieuMuon.Click += new System.EventHandler(this.btnAddTimePhieuMuon_Click);
      // 
      // label7
      // 
      this.label7.AutoSize = true;
      this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label7.Location = new System.Drawing.Point(541, 52);
      this.label7.Name = "label7";
      this.label7.Size = new System.Drawing.Size(74, 18);
      this.label7.TabIndex = 9;
      this.label7.Text = "Đến ngày:";
      // 
      // dtpkDateToPhieuMuon
      // 
      this.dtpkDateToPhieuMuon.CustomFormat = "dd/MM/yyyy";
      this.dtpkDateToPhieuMuon.Enabled = false;
      this.dtpkDateToPhieuMuon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.dtpkDateToPhieuMuon.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
      this.dtpkDateToPhieuMuon.Location = new System.Drawing.Point(624, 52);
      this.dtpkDateToPhieuMuon.Name = "dtpkDateToPhieuMuon";
      this.dtpkDateToPhieuMuon.Size = new System.Drawing.Size(153, 22);
      this.dtpkDateToPhieuMuon.TabIndex = 7;
      // 
      // label8
      // 
      this.label8.AutoSize = true;
      this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label8.Location = new System.Drawing.Point(546, 26);
      this.label8.Name = "label8";
      this.label8.Size = new System.Drawing.Size(64, 18);
      this.label8.TabIndex = 8;
      this.label8.Text = "Từ ngày:";
      // 
      // dtpkDateFromPhieuMuon
      // 
      this.dtpkDateFromPhieuMuon.CustomFormat = "dd/MM/yyyy";
      this.dtpkDateFromPhieuMuon.Enabled = false;
      this.dtpkDateFromPhieuMuon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.dtpkDateFromPhieuMuon.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
      this.dtpkDateFromPhieuMuon.Location = new System.Drawing.Point(624, 24);
      this.dtpkDateFromPhieuMuon.Name = "dtpkDateFromPhieuMuon";
      this.dtpkDateFromPhieuMuon.Size = new System.Drawing.Size(153, 22);
      this.dtpkDateFromPhieuMuon.TabIndex = 6;
      // 
      // cbTypeSearchPhieuMuon
      // 
      this.cbTypeSearchPhieuMuon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cbTypeSearchPhieuMuon.FormattingEnabled = true;
      this.cbTypeSearchPhieuMuon.Location = new System.Drawing.Point(175, 24);
      this.cbTypeSearchPhieuMuon.Name = "cbTypeSearchPhieuMuon";
      this.cbTypeSearchPhieuMuon.Size = new System.Drawing.Size(142, 26);
      this.cbTypeSearchPhieuMuon.TabIndex = 5;
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(13, 34);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(129, 18);
      this.label4.TabIndex = 4;
      this.label4.Text = "Thông tin tìm kiếm";
      // 
      // plDataGridView
      // 
      this.plDataGridView.Controls.Add(this.dtgvSearch);
      this.plDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
      this.plDataGridView.Location = new System.Drawing.Point(0, 313);
      this.plDataGridView.Name = "plDataGridView";
      this.plDataGridView.Size = new System.Drawing.Size(807, 157);
      this.plDataGridView.TabIndex = 7;
      // 
      // dtgvSearch
      // 
      this.dtgvSearch.AllowUserToAddRows = false;
      this.dtgvSearch.AllowUserToDeleteRows = false;
      this.dtgvSearch.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
      this.dtgvSearch.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      this.dtgvSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dtgvSearch.Dock = System.Windows.Forms.DockStyle.Fill;
      this.dtgvSearch.Location = new System.Drawing.Point(0, 0);
      this.dtgvSearch.Name = "dtgvSearch";
      this.dtgvSearch.Size = new System.Drawing.Size(807, 157);
      this.dtgvSearch.TabIndex = 0;
      // 
      // fSearch
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
      this.ClientSize = new System.Drawing.Size(807, 515);
      this.Controls.Add(this.plDataGridView);
      this.Controls.Add(this.plPhieuMuon);
      this.Controls.Add(this.plSearchButton);
      this.Controls.Add(this.plSearchSach);
      this.Controls.Add(this.plSearchDocGia);
      this.Controls.Add(this.plTypeSearchButton);
      this.Name = "fSearch";
      this.Text = "Tra cứu thông tin";
      this.plTypeSearchButton.ResumeLayout(false);
      this.plSearchDocGia.ResumeLayout(false);
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      this.plSearchSach.ResumeLayout(false);
      this.groupBox2.ResumeLayout(false);
      this.groupBox2.PerformLayout();
      this.plSearchButton.ResumeLayout(false);
      this.plPhieuMuon.ResumeLayout(false);
      this.groupBox3.ResumeLayout(false);
      this.groupBox3.PerformLayout();
      this.plDataGridView.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.dtgvSearch)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Button btnSearchDocGia;
    private System.Windows.Forms.Button btnSearchSach;
    private System.Windows.Forms.Panel plTypeSearchButton;
    private System.Windows.Forms.Panel plSearchDocGia;
    private System.Windows.Forms.Panel plSearchSach;
    private System.Windows.Forms.Panel plSearchButton;
    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.ComboBox cbTypeSearchDocGia;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox txbSearchIDDocGia;
    private System.Windows.Forms.GroupBox groupBox2;
    private System.Windows.Forms.ComboBox cbTypeSearchSach;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Button btnSearch;
    private System.Windows.Forms.Label lbTo;
    private System.Windows.Forms.DateTimePicker dtpkDateToSearchDocGia;
    private System.Windows.Forms.Label lbFrom;
    private System.Windows.Forms.DateTimePicker dtpkDateFromSearchDocGia;
    private System.Windows.Forms.Button button2;
    private System.Windows.Forms.Button btnSearchPhieuMuon;
    private System.Windows.Forms.Button btnAddTimeSach;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.DateTimePicker dtpkDateToSearchSach;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.DateTimePicker dtpkDateFromSearchSach;
    private System.Windows.Forms.Panel plPhieuMuon;
    private System.Windows.Forms.GroupBox groupBox3;
    private System.Windows.Forms.Button btnAddTimePhieuMuon;
    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.DateTimePicker dtpkDateToPhieuMuon;
    private System.Windows.Forms.Label label8;
    private System.Windows.Forms.DateTimePicker dtpkDateFromPhieuMuon;
    private System.Windows.Forms.ComboBox cbTypeSearchPhieuMuon;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Panel plDataGridView;
    private System.Windows.Forms.DataGridView dtgvSearch;
    private System.Windows.Forms.RadioButton rbSearchDocGia;
    private System.Windows.Forms.RadioButton rdSearchSach;
    private System.Windows.Forms.RadioButton rbSearchPhieuMuon;
    private System.Windows.Forms.Label label9;
    private System.Windows.Forms.TextBox txbSearchSach;
  }
}