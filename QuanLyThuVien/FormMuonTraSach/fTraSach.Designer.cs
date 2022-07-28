
namespace QuanLyThuVien
{
    partial class fTraSach
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
      this.panel5 = new System.Windows.Forms.Panel();
      this.dtgvBillInfor = new System.Windows.Forms.DataGridView();
      this.label5 = new System.Windows.Forms.Label();
      this.btnAdd = new System.Windows.Forms.Button();
      this.dtgvTraSach = new System.Windows.Forms.DataGridView();
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.panel8 = new System.Windows.Forms.Panel();
      this.cbMaDocGia = new System.Windows.Forms.ComboBox();
      this.label14 = new System.Windows.Forms.Label();
      this.panel7 = new System.Windows.Forms.Panel();
      this.dtpkDateCheckOut = new System.Windows.Forms.DateTimePicker();
      this.label13 = new System.Windows.Forms.Label();
      this.panel6 = new System.Windows.Forms.Panel();
      this.dttpDateCreate = new System.Windows.Forms.DateTimePicker();
      this.label6 = new System.Windows.Forms.Label();
      this.panel4 = new System.Windows.Forms.Panel();
      this.txbConLai = new System.Windows.Forms.TextBox();
      this.label4 = new System.Windows.Forms.Label();
      this.panel3 = new System.Windows.Forms.Panel();
      this.txbCount = new System.Windows.Forms.TextBox();
      this.label3 = new System.Windows.Forms.Label();
      this.panel1 = new System.Windows.Forms.Panel();
      this.txbIDAdmin = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.panel9 = new System.Windows.Forms.Panel();
      this.cbIDBill = new System.Windows.Forms.ComboBox();
      this.label9 = new System.Windows.Forms.Label();
      this.txbIDBillInfor = new System.Windows.Forms.TextBox();
      this.label7 = new System.Windows.Forms.Label();
      this.label8 = new System.Windows.Forms.Label();
      this.txbMaSach = new System.Windows.Forms.TextBox();
      this.label10 = new System.Windows.Forms.Label();
      this.label11 = new System.Windows.Forms.Label();
      this.txbStatus = new System.Windows.Forms.TextBox();
      this.label12 = new System.Windows.Forms.Label();
      this.txbidBill = new System.Windows.Forms.TextBox();
      this.txbDateCheckOut = new System.Windows.Forms.TextBox();
      this.button1 = new System.Windows.Forms.Button();
      this.cbxMatSach = new System.Windows.Forms.CheckBox();
      this.panel5.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dtgvBillInfor)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.dtgvTraSach)).BeginInit();
      this.groupBox1.SuspendLayout();
      this.panel8.SuspendLayout();
      this.panel7.SuspendLayout();
      this.panel6.SuspendLayout();
      this.panel4.SuspendLayout();
      this.panel3.SuspendLayout();
      this.panel1.SuspendLayout();
      this.panel9.SuspendLayout();
      this.SuspendLayout();
      // 
      // panel5
      // 
      this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      this.panel5.Controls.Add(this.dtgvBillInfor);
      this.panel5.Controls.Add(this.label5);
      this.panel5.Location = new System.Drawing.Point(396, 12);
      this.panel5.Name = "panel5";
      this.panel5.Size = new System.Drawing.Size(580, 168);
      this.panel5.TabIndex = 41;
      // 
      // dtgvBillInfor
      // 
      this.dtgvBillInfor.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      this.dtgvBillInfor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dtgvBillInfor.Location = new System.Drawing.Point(0, 46);
      this.dtgvBillInfor.Name = "dtgvBillInfor";
      this.dtgvBillInfor.Size = new System.Drawing.Size(580, 122);
      this.dtgvBillInfor.TabIndex = 1;
      this.dtgvBillInfor.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvBillInfor_CellContentClick);
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label5.Location = new System.Drawing.Point(194, 9);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(173, 24);
      this.label5.TabIndex = 31;
      this.label5.Text = "Chi tiết phiếu mượn";
      // 
      // btnAdd
      // 
      this.btnAdd.BackColor = System.Drawing.Color.Silver;
      this.btnAdd.Enabled = false;
      this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnAdd.Location = new System.Drawing.Point(471, 254);
      this.btnAdd.Name = "btnAdd";
      this.btnAdd.Size = new System.Drawing.Size(75, 34);
      this.btnAdd.TabIndex = 35;
      this.btnAdd.Text = "Trả sách";
      this.btnAdd.UseVisualStyleBackColor = false;
      this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
      // 
      // dtgvTraSach
      // 
      this.dtgvTraSach.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
      this.dtgvTraSach.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
      this.dtgvTraSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dtgvTraSach.Location = new System.Drawing.Point(35, 308);
      this.dtgvTraSach.Name = "dtgvTraSach";
      this.dtgvTraSach.Size = new System.Drawing.Size(941, 199);
      this.dtgvTraSach.TabIndex = 34;
      // 
      // groupBox1
      // 
      this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
      this.groupBox1.Controls.Add(this.panel8);
      this.groupBox1.Controls.Add(this.panel7);
      this.groupBox1.Controls.Add(this.panel6);
      this.groupBox1.Controls.Add(this.panel4);
      this.groupBox1.Controls.Add(this.panel3);
      this.groupBox1.Controls.Add(this.panel1);
      this.groupBox1.Controls.Add(this.panel9);
      this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.groupBox1.Location = new System.Drawing.Point(35, 12);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(345, 290);
      this.groupBox1.TabIndex = 32;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Thông tin phiếu mượn";
      // 
      // panel8
      // 
      this.panel8.Controls.Add(this.cbMaDocGia);
      this.panel8.Controls.Add(this.label14);
      this.panel8.Location = new System.Drawing.Point(7, 23);
      this.panel8.Name = "panel8";
      this.panel8.Size = new System.Drawing.Size(332, 32);
      this.panel8.TabIndex = 14;
      // 
      // cbMaDocGia
      // 
      this.cbMaDocGia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cbMaDocGia.FormattingEnabled = true;
      this.cbMaDocGia.IntegralHeight = false;
      this.cbMaDocGia.Location = new System.Drawing.Point(121, 2);
      this.cbMaDocGia.Name = "cbMaDocGia";
      this.cbMaDocGia.Size = new System.Drawing.Size(198, 28);
      this.cbMaDocGia.TabIndex = 1;
      this.cbMaDocGia.SelectedIndexChanged += new System.EventHandler(this.cbMaDocGia_SelectedIndexChanged);
      // 
      // label14
      // 
      this.label14.AutoSize = true;
      this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label14.Location = new System.Drawing.Point(4, 4);
      this.label14.Name = "label14";
      this.label14.Size = new System.Drawing.Size(85, 18);
      this.label14.TabIndex = 0;
      this.label14.Text = "Mã độc giả:";
      // 
      // panel7
      // 
      this.panel7.Controls.Add(this.dtpkDateCheckOut);
      this.panel7.Controls.Add(this.label13);
      this.panel7.Location = new System.Drawing.Point(7, 248);
      this.panel7.Name = "panel7";
      this.panel7.Size = new System.Drawing.Size(332, 32);
      this.panel7.TabIndex = 13;
      // 
      // dtpkDateCheckOut
      // 
      this.dtpkDateCheckOut.CustomFormat = "dd/MM/yyyy";
      this.dtpkDateCheckOut.Enabled = false;
      this.dtpkDateCheckOut.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
      this.dtpkDateCheckOut.Location = new System.Drawing.Point(120, 4);
      this.dtpkDateCheckOut.Name = "dtpkDateCheckOut";
      this.dtpkDateCheckOut.Size = new System.Drawing.Size(197, 26);
      this.dtpkDateCheckOut.TabIndex = 1;
      // 
      // label13
      // 
      this.label13.AutoSize = true;
      this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label13.Location = new System.Drawing.Point(4, 4);
      this.label13.Name = "label13";
      this.label13.Size = new System.Drawing.Size(103, 18);
      this.label13.TabIndex = 0;
      this.label13.Text = "Ngày trả sách:";
      // 
      // panel6
      // 
      this.panel6.Controls.Add(this.dttpDateCreate);
      this.panel6.Controls.Add(this.label6);
      this.panel6.Location = new System.Drawing.Point(7, 202);
      this.panel6.Name = "panel6";
      this.panel6.Size = new System.Drawing.Size(332, 32);
      this.panel6.TabIndex = 12;
      // 
      // dttpDateCreate
      // 
      this.dttpDateCreate.CustomFormat = "dd/MM/yyyy";
      this.dttpDateCreate.Enabled = false;
      this.dttpDateCreate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
      this.dttpDateCreate.Location = new System.Drawing.Point(120, 4);
      this.dttpDateCreate.Name = "dttpDateCreate";
      this.dttpDateCreate.Size = new System.Drawing.Size(197, 26);
      this.dttpDateCreate.TabIndex = 1;
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label6.Location = new System.Drawing.Point(4, 4);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(108, 18);
      this.label6.TabIndex = 0;
      this.label6.Text = "Ngày lập phiếu:";
      // 
      // panel4
      // 
      this.panel4.Controls.Add(this.txbConLai);
      this.panel4.Controls.Add(this.label4);
      this.panel4.Location = new System.Drawing.Point(6, 163);
      this.panel4.Name = "panel4";
      this.panel4.Size = new System.Drawing.Size(332, 32);
      this.panel4.TabIndex = 11;
      // 
      // txbConLai
      // 
      this.txbConLai.Location = new System.Drawing.Point(120, 4);
      this.txbConLai.Name = "txbConLai";
      this.txbConLai.ReadOnly = true;
      this.txbConLai.Size = new System.Drawing.Size(198, 26);
      this.txbConLai.TabIndex = 3;
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label4.Location = new System.Drawing.Point(4, 4);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(58, 18);
      this.label4.TabIndex = 0;
      this.label4.Text = "Còn lại:";
      // 
      // panel3
      // 
      this.panel3.Controls.Add(this.txbCount);
      this.panel3.Controls.Add(this.label3);
      this.panel3.Location = new System.Drawing.Point(6, 127);
      this.panel3.Name = "panel3";
      this.panel3.Size = new System.Drawing.Size(332, 32);
      this.panel3.TabIndex = 10;
      // 
      // txbCount
      // 
      this.txbCount.Location = new System.Drawing.Point(120, 4);
      this.txbCount.Name = "txbCount";
      this.txbCount.ReadOnly = true;
      this.txbCount.Size = new System.Drawing.Size(198, 26);
      this.txbCount.TabIndex = 3;
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label3.Location = new System.Drawing.Point(4, 4);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(71, 18);
      this.label3.TabIndex = 0;
      this.label3.Text = "Số lượng:";
      // 
      // panel1
      // 
      this.panel1.Controls.Add(this.txbIDAdmin);
      this.panel1.Controls.Add(this.label1);
      this.panel1.Location = new System.Drawing.Point(6, 95);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(332, 32);
      this.panel1.TabIndex = 8;
      // 
      // txbIDAdmin
      // 
      this.txbIDAdmin.Location = new System.Drawing.Point(120, 4);
      this.txbIDAdmin.Name = "txbIDAdmin";
      this.txbIDAdmin.ReadOnly = true;
      this.txbIDAdmin.Size = new System.Drawing.Size(198, 26);
      this.txbIDAdmin.TabIndex = 3;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.Location = new System.Drawing.Point(4, 4);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(77, 18);
      this.label1.TabIndex = 0;
      this.label1.Text = "Mã admin:";
      // 
      // panel9
      // 
      this.panel9.Controls.Add(this.cbIDBill);
      this.panel9.Controls.Add(this.label9);
      this.panel9.Location = new System.Drawing.Point(6, 61);
      this.panel9.Name = "panel9";
      this.panel9.Size = new System.Drawing.Size(332, 32);
      this.panel9.TabIndex = 7;
      // 
      // cbIDBill
      // 
      this.cbIDBill.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cbIDBill.FormattingEnabled = true;
      this.cbIDBill.IntegralHeight = false;
      this.cbIDBill.Location = new System.Drawing.Point(121, 2);
      this.cbIDBill.Name = "cbIDBill";
      this.cbIDBill.Size = new System.Drawing.Size(198, 28);
      this.cbIDBill.TabIndex = 1;
      this.cbIDBill.SelectedIndexChanged += new System.EventHandler(this.cbIDBill_SelectedIndexChanged);
      // 
      // label9
      // 
      this.label9.AutoSize = true;
      this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label9.Location = new System.Drawing.Point(4, 4);
      this.label9.Name = "label9";
      this.label9.Size = new System.Drawing.Size(72, 18);
      this.label9.TabIndex = 0;
      this.label9.Text = "Mã phiếu:";
      // 
      // txbIDBillInfor
      // 
      this.txbIDBillInfor.Location = new System.Drawing.Point(471, 188);
      this.txbIDBillInfor.Name = "txbIDBillInfor";
      this.txbIDBillInfor.ReadOnly = true;
      this.txbIDBillInfor.Size = new System.Drawing.Size(89, 20);
      this.txbIDBillInfor.TabIndex = 42;
      // 
      // label7
      // 
      this.label7.AutoSize = true;
      this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label7.Location = new System.Drawing.Point(393, 188);
      this.label7.Name = "label7";
      this.label7.Size = new System.Drawing.Size(22, 18);
      this.label7.TabIndex = 43;
      this.label7.Text = "ID";
      // 
      // label8
      // 
      this.label8.AutoSize = true;
      this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label8.Location = new System.Drawing.Point(591, 188);
      this.label8.Name = "label8";
      this.label8.Size = new System.Drawing.Size(69, 18);
      this.label8.TabIndex = 45;
      this.label8.Text = "Mã sách:";
      // 
      // txbMaSach
      // 
      this.txbMaSach.Location = new System.Drawing.Point(669, 188);
      this.txbMaSach.Name = "txbMaSach";
      this.txbMaSach.ReadOnly = true;
      this.txbMaSach.Size = new System.Drawing.Size(113, 20);
      this.txbMaSach.TabIndex = 44;
      // 
      // label10
      // 
      this.label10.AutoSize = true;
      this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label10.Location = new System.Drawing.Point(591, 219);
      this.label10.Name = "label10";
      this.label10.Size = new System.Drawing.Size(67, 18);
      this.label10.TabIndex = 47;
      this.label10.Text = "Ngày trả:";
      // 
      // label11
      // 
      this.label11.AutoSize = true;
      this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label11.Location = new System.Drawing.Point(805, 189);
      this.label11.Name = "label11";
      this.label11.Size = new System.Drawing.Size(77, 18);
      this.label11.TabIndex = 49;
      this.label11.Text = "Trạng thái:";
      // 
      // txbStatus
      // 
      this.txbStatus.Location = new System.Drawing.Point(888, 189);
      this.txbStatus.Name = "txbStatus";
      this.txbStatus.ReadOnly = true;
      this.txbStatus.Size = new System.Drawing.Size(88, 20);
      this.txbStatus.TabIndex = 48;
      // 
      // label12
      // 
      this.label12.AutoSize = true;
      this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label12.Location = new System.Drawing.Point(393, 219);
      this.label12.Name = "label12";
      this.label12.Size = new System.Drawing.Size(72, 18);
      this.label12.TabIndex = 51;
      this.label12.Text = "Mã phiếu:";
      // 
      // txbidBill
      // 
      this.txbidBill.Location = new System.Drawing.Point(471, 219);
      this.txbidBill.Name = "txbidBill";
      this.txbidBill.ReadOnly = true;
      this.txbidBill.Size = new System.Drawing.Size(89, 20);
      this.txbidBill.TabIndex = 50;
      // 
      // txbDateCheckOut
      // 
      this.txbDateCheckOut.Location = new System.Drawing.Point(669, 220);
      this.txbDateCheckOut.Name = "txbDateCheckOut";
      this.txbDateCheckOut.ReadOnly = true;
      this.txbDateCheckOut.Size = new System.Drawing.Size(113, 20);
      this.txbDateCheckOut.TabIndex = 52;
      // 
      // button1
      // 
      this.button1.BackColor = System.Drawing.Color.Silver;
      this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.button1.Location = new System.Drawing.Point(390, 254);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(75, 34);
      this.button1.TabIndex = 53;
      this.button1.Text = "Làm mới";
      this.button1.UseVisualStyleBackColor = false;
      this.button1.Click += new System.EventHandler(this.button1_Click);
      // 
      // cbxMatSach
      // 
      this.cbxMatSach.AutoSize = true;
      this.cbxMatSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.cbxMatSach.Location = new System.Drawing.Point(808, 220);
      this.cbxMatSach.Name = "cbxMatSach";
      this.cbxMatSach.Size = new System.Drawing.Size(88, 22);
      this.cbxMatSach.TabIndex = 54;
      this.cbxMatSach.Text = "Mất sách";
      this.cbxMatSach.UseVisualStyleBackColor = true;
      // 
      // fTraSach
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
      this.ClientSize = new System.Drawing.Size(1074, 529);
      this.Controls.Add(this.cbxMatSach);
      this.Controls.Add(this.button1);
      this.Controls.Add(this.txbDateCheckOut);
      this.Controls.Add(this.label12);
      this.Controls.Add(this.txbidBill);
      this.Controls.Add(this.label11);
      this.Controls.Add(this.txbStatus);
      this.Controls.Add(this.label10);
      this.Controls.Add(this.label8);
      this.Controls.Add(this.txbMaSach);
      this.Controls.Add(this.label7);
      this.Controls.Add(this.txbIDBillInfor);
      this.Controls.Add(this.groupBox1);
      this.Controls.Add(this.panel5);
      this.Controls.Add(this.btnAdd);
      this.Controls.Add(this.dtgvTraSach);
      this.Name = "fTraSach";
      this.Text = "Quản lý sách trả";
      this.panel5.ResumeLayout(false);
      this.panel5.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dtgvBillInfor)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.dtgvTraSach)).EndInit();
      this.groupBox1.ResumeLayout(false);
      this.panel8.ResumeLayout(false);
      this.panel8.PerformLayout();
      this.panel7.ResumeLayout(false);
      this.panel7.PerformLayout();
      this.panel6.ResumeLayout(false);
      this.panel6.PerformLayout();
      this.panel4.ResumeLayout(false);
      this.panel4.PerformLayout();
      this.panel3.ResumeLayout(false);
      this.panel3.PerformLayout();
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      this.panel9.ResumeLayout(false);
      this.panel9.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.DataGridView dtgvBillInfor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dtgvTraSach;
    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.Panel panel6;
    private System.Windows.Forms.DateTimePicker dttpDateCreate;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.Panel panel4;
    private System.Windows.Forms.TextBox txbConLai;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Panel panel3;
    private System.Windows.Forms.TextBox txbCount;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.TextBox txbIDAdmin;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Panel panel9;
    private System.Windows.Forms.Label label9;
    private System.Windows.Forms.ComboBox cbIDBill;
    private System.Windows.Forms.TextBox txbIDBillInfor;
    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.Label label8;
    private System.Windows.Forms.TextBox txbMaSach;
    private System.Windows.Forms.Label label10;
    private System.Windows.Forms.Label label11;
    private System.Windows.Forms.TextBox txbStatus;
    private System.Windows.Forms.Label label12;
    private System.Windows.Forms.TextBox txbidBill;
    private System.Windows.Forms.TextBox txbDateCheckOut;
    private System.Windows.Forms.Panel panel7;
    private System.Windows.Forms.DateTimePicker dtpkDateCheckOut;
    private System.Windows.Forms.Label label13;
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.CheckBox cbxMatSach;
    private System.Windows.Forms.Panel panel8;
    private System.Windows.Forms.ComboBox cbMaDocGia;
    private System.Windows.Forms.Label label14;
  }
}