
namespace QuanLyThuVien
{
  partial class fImportFileExcel
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
      this.btnOpenFile = new System.Windows.Forms.Button();
      this.txbFilePath = new System.Windows.Forms.TextBox();
      this.btnImportFile = new System.Windows.Forms.Button();
      this.dtgvImportFile = new System.Windows.Forms.DataGridView();
      ((System.ComponentModel.ISupportInitialize)(this.dtgvImportFile)).BeginInit();
      this.SuspendLayout();
      // 
      // btnOpenFile
      // 
      this.btnOpenFile.Location = new System.Drawing.Point(13, 13);
      this.btnOpenFile.Name = "btnOpenFile";
      this.btnOpenFile.Size = new System.Drawing.Size(75, 32);
      this.btnOpenFile.TabIndex = 0;
      this.btnOpenFile.Text = "Chọn file";
      this.btnOpenFile.UseVisualStyleBackColor = true;
      this.btnOpenFile.Click += new System.EventHandler(this.btnOpenFile_Click);
      // 
      // txbFilePath
      // 
      this.txbFilePath.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txbFilePath.Location = new System.Drawing.Point(94, 18);
      this.txbFilePath.Name = "txbFilePath";
      this.txbFilePath.Size = new System.Drawing.Size(538, 21);
      this.txbFilePath.TabIndex = 1;
      // 
      // btnImportFile
      // 
      this.btnImportFile.Location = new System.Drawing.Point(535, 57);
      this.btnImportFile.Name = "btnImportFile";
      this.btnImportFile.Size = new System.Drawing.Size(98, 32);
      this.btnImportFile.TabIndex = 2;
      this.btnImportFile.Text = "Import File Excel";
      this.btnImportFile.UseVisualStyleBackColor = true;
      this.btnImportFile.Click += new System.EventHandler(this.btnImportFile_Click);
      // 
      // dtgvImportFile
      // 
      this.dtgvImportFile.AllowUserToAddRows = false;
      this.dtgvImportFile.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dtgvImportFile.Location = new System.Drawing.Point(13, 95);
      this.dtgvImportFile.Name = "dtgvImportFile";
      this.dtgvImportFile.Size = new System.Drawing.Size(620, 240);
      this.dtgvImportFile.TabIndex = 3;
      // 
      // fImportFileExcel
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.Silver;
      this.ClientSize = new System.Drawing.Size(645, 362);
      this.Controls.Add(this.dtgvImportFile);
      this.Controls.Add(this.btnImportFile);
      this.Controls.Add(this.txbFilePath);
      this.Controls.Add(this.btnOpenFile);
      this.Name = "fImportFileExcel";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Import file excel";
      ((System.ComponentModel.ISupportInitialize)(this.dtgvImportFile)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button btnOpenFile;
    private System.Windows.Forms.TextBox txbFilePath;
    private System.Windows.Forms.Button btnImportFile;
    private System.Windows.Forms.DataGridView dtgvImportFile;
  }
}