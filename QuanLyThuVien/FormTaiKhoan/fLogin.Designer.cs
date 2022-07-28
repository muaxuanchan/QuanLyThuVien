
namespace QuanLyThuVien
{
    partial class fLogin
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fLogin));
      this.txbUserName = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.txbPassWord = new System.Windows.Forms.TextBox();
      this.label5 = new System.Windows.Forms.Label();
      this.btnUpdate = new System.Windows.Forms.Button();
      this.btnAdd = new System.Windows.Forms.Button();
      this.pictureBox1 = new System.Windows.Forms.PictureBox();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
      this.SuspendLayout();
      // 
      // txbUserName
      // 
      this.txbUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txbUserName.Location = new System.Drawing.Point(16, 165);
      this.txbUserName.Margin = new System.Windows.Forms.Padding(4);
      this.txbUserName.Name = "txbUserName";
      this.txbUserName.Size = new System.Drawing.Size(220, 26);
      this.txbUserName.TabIndex = 1;
      this.txbUserName.Text = "admin";
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.Location = new System.Drawing.Point(13, 141);
      this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(120, 20);
      this.label1.TabIndex = 0;
      this.label1.Text = "Tên đăng nhập:";
      // 
      // txbPassWord
      // 
      this.txbPassWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txbPassWord.Location = new System.Drawing.Point(17, 230);
      this.txbPassWord.Margin = new System.Windows.Forms.Padding(4);
      this.txbPassWord.Name = "txbPassWord";
      this.txbPassWord.Size = new System.Drawing.Size(219, 26);
      this.txbPassWord.TabIndex = 2;
      this.txbPassWord.Text = "admin";
      this.txbPassWord.UseSystemPasswordChar = true;
      this.txbPassWord.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txbPassWord_KeyDown);
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label5.Location = new System.Drawing.Point(18, 208);
      this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(73, 18);
      this.label5.TabIndex = 0;
      this.label5.Text = "Mật khẩu:";
      // 
      // btnUpdate
      // 
      this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnUpdate.Location = new System.Drawing.Point(164, 271);
      this.btnUpdate.Margin = new System.Windows.Forms.Padding(4);
      this.btnUpdate.Name = "btnUpdate";
      this.btnUpdate.Size = new System.Drawing.Size(72, 34);
      this.btnUpdate.TabIndex = 4;
      this.btnUpdate.Text = "Thoát";
      this.btnUpdate.UseVisualStyleBackColor = true;
      this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
      // 
      // btnAdd
      // 
      this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnAdd.Location = new System.Drawing.Point(73, 271);
      this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
      this.btnAdd.Name = "btnAdd";
      this.btnAdd.Size = new System.Drawing.Size(83, 35);
      this.btnAdd.TabIndex = 3;
      this.btnAdd.Text = "Đăng nhập";
      this.btnAdd.UseVisualStyleBackColor = true;
      this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
      // 
      // pictureBox1
      // 
      this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
      this.pictureBox1.Location = new System.Drawing.Point(84, 34);
      this.pictureBox1.Name = "pictureBox1";
      this.pictureBox1.Size = new System.Drawing.Size(72, 71);
      this.pictureBox1.TabIndex = 11;
      this.pictureBox1.TabStop = false;
      // 
      // fLogin
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      this.ClientSize = new System.Drawing.Size(259, 311);
      this.Controls.Add(this.pictureBox1);
      this.Controls.Add(this.txbPassWord);
      this.Controls.Add(this.txbUserName);
      this.Controls.Add(this.btnUpdate);
      this.Controls.Add(this.label5);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.btnAdd);
      this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.Margin = new System.Windows.Forms.Padding(4);
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "fLogin";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Đăng nhập";
      this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.fLogin_FormClosing);
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txbUserName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbPassWord;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
    private System.Windows.Forms.PictureBox pictureBox1;
  }
}