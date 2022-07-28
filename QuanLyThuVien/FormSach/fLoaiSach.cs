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
  public partial class fLoaiSach : Form
  {
    LoaiSachBUS loaiSachBUS = new LoaiSachBUS();

    public fLoaiSach()
    {
      InitializeComponent();
      Load();
    }

    new void Load()
    {
      GetList();
      GetHeaderText();
      LoadNewTextBox();
      btnDelete.Enabled = false;
      btnUpdate.Enabled = false;
      rdbID.Checked = true;
      txnSearch.Text = "";
      txbMaLoaiSach.ReadOnly = true;
      txbTenLoaiSach.ReadOnly = true;
    }

    //  Hiển thị danh sách
    void GetList()
    {
      dtgvLoaiSach.DataSource = loaiSachBUS.GetListLoaiSach();
    }

    //  thêm
    private void btnAdd_Click(object sender, EventArgs e)
    {
      fAddLoaiSach f = new fAddLoaiSach();
      f.ShowDialog();
    }

    // Đổi tên cột datagridview
    void GetHeaderText()
    {
      dtgvLoaiSach.Columns[0].HeaderText = "Mã Loại";
      dtgvLoaiSach.Columns[1].HeaderText = "Tên loại";
    }

    //  Làm mới textbox
    void LoadNewTextBox()
    {
      txbMaLoaiSach.Text = "";
      txbTenLoaiSach.Text = "";
    }

    private void btnUpdate_Click(object sender, EventArgs e)
    {
      string id = txbMaLoaiSach.Text;
      string name = txbTenLoaiSach.Text;

      if (string.IsNullOrEmpty(name))
      {
        MessageBox.Show("Tên thể loại sách không được để trống!");
        txbTenLoaiSach.Focus();
      }
      else
      {
        if (loaiSachBUS.Update(name, id))
        {
          MessageBox.Show("Cập nhật thông tin thành công");
          Load();
        }
      }
    }

    //  Xóa
    private void btnDelete_Click(object sender, EventArgs e)
    {
      try
      {
        string id = txbMaLoaiSach.Text;
        if (loaiSachBUS.Delete(id))
        {
          MessageBox.Show("Xóa loại sách thành công");
          Load();
        }
      }
      catch (Exception)
      {

        MessageBox.Show("Không thể xóa thể loại sách này!!!");
      }
    }

    //  Làm mới
    private void btnLoad_Click(object sender, EventArgs e)
    {
      Load();
    }

    private void btnSearch_Click(object sender, EventArgs e)
    {
      if (rdbID.Checked == true)
      {
        string id = txnSearch.Text;
        dtgvLoaiSach.DataSource = loaiSachBUS.SearchByID(id);
      }
      else if (rdbName.Checked == true)
      {
        string name = txnSearch.Text;
        dtgvLoaiSach.DataSource = loaiSachBUS.SearchByName(name);
      }
    }

    //  binding
    private void dtgvLoaiSach_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {
      int i = dtgvLoaiSach.CurrentRow.Index;
      txbMaLoaiSach.Text = dtgvLoaiSach.Rows[i].Cells[0].Value.ToString();
      txbTenLoaiSach.Text = dtgvLoaiSach.Rows[i].Cells[1].Value.ToString();
      btnDelete.Enabled = true;
      btnUpdate.Enabled = true;
      txbTenLoaiSach.ReadOnly = false;
    }
  }
}
