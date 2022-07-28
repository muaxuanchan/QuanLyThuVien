using QuanLyThuVien.BUS;
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
  public partial class fLoaiDocGia : Form
  {
    LoaiDocGiaBUS loaiDocGiaBUS = new LoaiDocGiaBUS();

    public fLoaiDocGia()
    {
      InitializeComponent();
      Load();
    }

    new void Load()
    {
      LoadListLoaiDocGia();
      GetHeaderText();
      LoadNewTextBox();
      btnDelete.Enabled = false;
      btnUpdate.Enabled = false;
      
    }

    // Đổi tên cột datagridview
    void GetHeaderText()
    {
      dtgvLoaiDocGia.Columns[0].HeaderText = "Mã Loại";
      dtgvLoaiDocGia.Columns[1].HeaderText = "Tên loại";

    }

    void LoadNewTextBox()
    {
      txbMaLoaiDocGia.Text = "";
      txbLoaiDocGia.Text = "";
    }

    // Load danh sách lên datagridview
    void LoadListLoaiDocGia()
    {
      dtgvLoaiDocGia.DataSource = loaiDocGiaBUS.GetListTypeDocGia();
    }

    // Thêm loại đọc giả
    private void btnAdd_Click(object sender, EventArgs e)
    {
      fAddLoaiDocGia f = new fAddLoaiDocGia();
      f.ShowDialog();
    }

    // Binding
    private void dtgvLoaiDocGia_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {
      int i = dtgvLoaiDocGia.CurrentRow.Index;
      txbMaLoaiDocGia.Text = dtgvLoaiDocGia.Rows[i].Cells[0].Value.ToString();
      txbLoaiDocGia.Text = dtgvLoaiDocGia.Rows[i].Cells[1].Value.ToString();
      btnDelete.Enabled = true;
      btnUpdate.Enabled = true;
      txbLoaiDocGia.ReadOnly = false;
    }

    // Button làm mới
    private void btnLoad_Click(object sender, EventArgs e)
    {
      Load();
      txnSearch.Text = "";
      rdbID.Checked = true;
    }

    //  Xóa loại đọc giả 
    private void btnDelete_Click(object sender, EventArgs e)
    {
      try
      {
        string id = txbMaLoaiDocGia.Text;
        if (loaiDocGiaBUS.DeleteLoaiDocGia(id))
        {
          MessageBox.Show("Xóa loại độc giả thành công");
          Load();
        }
      }
      catch (Exception)
      {

        MessageBox.Show("Không thể xóa loại độc giả này!!!");
      }
    }

    //  Sửa
    private void btnUpdate_Click(object sender, EventArgs e)
    {
      string id = txbMaLoaiDocGia.Text;
      string name = txbLoaiDocGia.Text;

      if (string.IsNullOrEmpty(name))
      {
        MessageBox.Show("Tên loại độc giả không được để trống!");
        txbLoaiDocGia.Focus();
      }
      else
      {
        if (loaiDocGiaBUS.Update(name, id))
        {
          MessageBox.Show("Sửa thông tin thành công");
          Load();
        }
      }
    }

    //  Tìm kiếm
    private void btnSearch_Click(object sender, EventArgs e)
    {
      if (rdbID.Checked == true)
      {
        string id = txnSearch.Text;
        dtgvLoaiDocGia.DataSource = loaiDocGiaBUS.SearchByID(id);
      }
      else if (rdbName.Checked == true)
      {
        string name = txnSearch.Text;
        dtgvLoaiDocGia.DataSource = loaiDocGiaBUS.SearchByName(name);
      }
    }
  }
}
