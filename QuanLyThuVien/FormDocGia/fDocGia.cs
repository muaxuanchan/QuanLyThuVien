using QuanLyThuVien.BUS;
using QuanLyThuVien.Const;
using QuanLyThuVien.DTO;
using QuanLyThuVien.ImportFile;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThuVien
{
  public partial class fDocGia : Form
  {

    DocGiaBUS docGiaBUS = new DocGiaBUS();
    LoaiDocGiaBUS loaiDocGiaBUS = new LoaiDocGiaBUS();
    CommonConstants rule = new CommonConstants();

    public fDocGia()
    {
      InitializeComponent();
      Load();
    }

    new void Load()
    {
      LoadListDocGia();
      GetHeaderText();
      LoadNewTextBox();
      ReadOnlyTextBoxTrue();
      LoadComboBoxLoaiDocGia();
      btnDelete.Enabled = false;
      btnUpdate.Enabled = false;
      btnGiaHan.Enabled = false;
      dtpkNgaySinh.Value = DateTime.Now;
      dtpNgayLamThe.Value = DateTime.Now;
      dtpNgayHetHan.Value = DateTime.Now;

      if (fLogin.GetAdminInfor.quyen == 1)
      {
        btnAdd.Enabled = false;
        btnDelete.Enabled = false;
        btnGiaHan.Enabled = false;
        btnUpdate.Enabled = false;
        btnImportFileDocGia.Enabled = false;
      }
    }

    // Đổi tên cột datagridview
    void GetHeaderText()
    {
      dtgvDocGia.Columns[0].HeaderText = "Mã độc giả";
      dtgvDocGia.Columns[1].HeaderText = "Tên độc giả";
      dtgvDocGia.Columns[2].HeaderText = "Mã loại độc giả";
      dtgvDocGia.Columns[3].HeaderText = "Ngày sinh";
      dtgvDocGia.Columns[3].DefaultCellStyle.Format = "dd/MM/yyyy";
      dtgvDocGia.Columns[4].HeaderText = "Số điện thoại";
      dtgvDocGia.Columns[5].HeaderText = "Địa chỉ";
      dtgvDocGia.Columns[6].HeaderText = "Ngày làm thẻ";
      dtgvDocGia.Columns[6].DefaultCellStyle.Format = "dd/MM/yyyy";
      dtgvDocGia.Columns[7].HeaderText = "Ngày hết hạn";
      dtgvDocGia.Columns[7].DefaultCellStyle.Format = "dd/MM/yyyy";
      dtgvDocGia.Columns[8].HeaderText = "Ghi chú";

    }

    void LoadComboBoxLoaiDocGia()
    {
      cbLoaiDocGia.DataSource = loaiDocGiaBUS.GetListTypeDocGia();
      cbLoaiDocGia.DisplayMember = "id";
    }  

    //  Làm mới textbox
    void LoadNewTextBox()
    {
      txbMaDocGia.Text = "";
      txbTenDocGia.Text = "";
      cbLoaiDocGia.Text = "LDG01";
      txbDiaChi.Text = "";
      txbSoDienThoai.Text = "";
      dtpkNgaySinh.Value = DateTime.Now;
      dtpNgayLamThe.Value = DateTime.Now;
      dtpNgayHetHan.Value = DateTime.Now;
      txbGhiChu.Text = "";
      txnSearch.Text = "";
    }

    //  Read only text box false
    void ReadOnlyTextBoxFalse()
    {
      txbTenDocGia.ReadOnly = false;
      txbSoDienThoai.ReadOnly = false;
      txbDiaChi.ReadOnly = false;
      txbGhiChu.ReadOnly = false;
      dtpkNgaySinh.Enabled = true;
    }

    //  Read only text box true
    void ReadOnlyTextBoxTrue()
    {
      txbTenDocGia.ReadOnly = true;
      txbSoDienThoai.ReadOnly = true;
      txbDiaChi.ReadOnly = true;
      txbGhiChu.ReadOnly = true;
      dtpkNgaySinh.Enabled = false;
    }

    // Load danh sách lên datagridview
    void LoadListDocGia()
    {
      dtgvDocGia.DataSource = docGiaBUS.GetListDocGia();
    }

    //  Thêm
    private void btnAdd_Click(object sender, EventArgs e)
    {
      fAddDocGia f = new fAddDocGia();
      f.ShowDialog();
    }

    //  Sửa
    private void btnUpdate_Click(object sender, EventArgs e)
    {
      DocGiaDTO docGiaDTO = new DocGiaDTO();
      docGiaDTO.id = txbMaDocGia.Text;
      docGiaDTO.name = txbTenDocGia.Text;
      docGiaDTO.idCategoryDG = cbLoaiDocGia.Text;
      docGiaDTO.ngaySinh = dtpkNgaySinh.Value;
      docGiaDTO.phoneNumber = txbSoDienThoai.Text;
      docGiaDTO.diaChi = txbDiaChi.Text;
      docGiaDTO.note = txbGhiChu.Text;

      DateTime ngayLamThe = dtpNgayLamThe.Value;
      int old = ngayLamThe.Year - dtpkNgaySinh.Value.Year;

      if (string.IsNullOrEmpty(txbTenDocGia.Text))
      {
        MessageBox.Show("Tên độc giả không được để trống!!");
        txbTenDocGia.Focus();
      }
      else if (string.IsNullOrEmpty(cbLoaiDocGia.Text))
      {
        MessageBox.Show("Loại độc giả không được để trống!!");
        cbLoaiDocGia.Focus();
      }
      else if (string.IsNullOrEmpty(txbSoDienThoai.Text))
      {
        MessageBox.Show("Số điện thoại không được để trống!!");
        txbSoDienThoai.Focus();
      }
      else if (string.IsNullOrEmpty(txbDiaChi.Text))
      {
        MessageBox.Show("Địa chỉ không được để trống!!");
        txbDiaChi.Focus();
      }
      else if (old <  rule.TuoiMuonSach)
      {
        MessageBox.Show("Tuổi mượn sách tối thiểu là 17. Nhập lại ngày sinh");
        dtpkNgaySinh.Focus();
      }
      else
      {
        if (docGiaBUS.Update(docGiaDTO))
        {
          MessageBox.Show("Sửa thông tin thành công");
          Load();
        }
      }
    }

    //  Xóa
    private void btnDelete_Click(object sender, EventArgs e)
    {
      try
      {
        string id = txbMaDocGia.Text;
        if (docGiaBUS.Delete(id))
        {
          MessageBox.Show("Xóa độc giả thành công");
          Load();
        }
      }
      catch (Exception)
      {

        MessageBox.Show("Không thể xóa độc giả này!!!");
      }
    }

    //  Làm mới
    private void btnLoad_Click(object sender, EventArgs e)
    {
      Load();
    }

    //  Tìm kiếm
    private void btnSearch_Click(object sender, EventArgs e)
    {
      if (rdbID.Checked == true)
      {
        string id = txnSearch.Text;
        dtgvDocGia.DataSource = docGiaBUS.SearchByID(id);
      }
      else if (rdbName.Checked == true)
      {
        string name = txnSearch.Text;
        dtgvDocGia.DataSource = docGiaBUS.SearchByName(name);
      }
    }

    //  Binding
    private void dtgvDocGia_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {
      int i = dtgvDocGia.CurrentRow.Index;
      txbMaDocGia.Text = dtgvDocGia.Rows[i].Cells[0].Value.ToString();
      txbTenDocGia.Text = dtgvDocGia.Rows[i].Cells[1].Value.ToString();
      cbLoaiDocGia.Text = dtgvDocGia.Rows[i].Cells[2].Value.ToString();
      dtpkNgaySinh.Value = (DateTime)dtgvDocGia.Rows[i].Cells[3].Value;
      txbSoDienThoai.Text = dtgvDocGia.Rows[i].Cells[4].Value.ToString();
      txbDiaChi.Text = dtgvDocGia.Rows[i].Cells[5].Value.ToString();
      dtpNgayLamThe.Value = (DateTime)dtgvDocGia.Rows[i].Cells[6].Value;
      dtpNgayHetHan.Value = (DateTime)dtgvDocGia.Rows[i].Cells[7].Value;
      txbGhiChu.Text = dtgvDocGia.Rows[i].Cells[8].Value.ToString();

      btnDelete.Enabled = true;
      btnUpdate.Enabled = true;
      btnGiaHan.Enabled = true;
      ReadOnlyTextBoxFalse();
    }

    // Gia Hạn đọc giả
    private void tbnGiaHan_Click(object sender, EventArgs e)
    {
      string id = txbMaDocGia.Text;
      int time = rule.GiaHanThe;

      string query = "exec Giahan @id , @time ";
      DataProvider.Instance.ExecuteNonQuery(query, new object[] { id, time });

      string message = "Gia hạn " + txbMaDocGia.Text.Trim() + " thành công";
      MessageBox.Show(message, "Thông báo");
      Load();
    }

    // Import file to sql
    private void btnImportFileDocGia_Click(object sender, EventArgs e)
    {
      SaveSelected.Instance.ImportFileToSql(btnImportFileDocGia.Name);
      fImportFileExcel frm = new fImportFileExcel();
      frm.ShowDialog();
    }
  }
}
