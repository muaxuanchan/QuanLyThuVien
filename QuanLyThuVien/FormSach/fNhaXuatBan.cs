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
  public partial class fNhaXuatBan : Form
  {

    NhaXuatBanBUS nhaXuatBanBUS = new NhaXuatBanBUS();

    public fNhaXuatBan()
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
      txbMaNhaXuatBan.ReadOnly = true;
      txbTenNhaXuatBan.ReadOnly = true;
    }

    //  Hiển thị danh sách
    void GetList()
    {
      dtgvNhaXuatBan.DataSource = nhaXuatBanBUS.GetListNhaXuatBan();
    }

    // Đổi tên cột datagridview
    void GetHeaderText()
    {
      dtgvNhaXuatBan.Columns[0].HeaderText = "Mã nhà xuất bản";
      dtgvNhaXuatBan.Columns[1].HeaderText = "Tên nhà xuất bản";
    }

    //  Làm mới textbox
    void LoadNewTextBox()
    {
      txbMaNhaXuatBan.Text = "";
      txbTenNhaXuatBan.Text = "";
    }

    //  Thêm
    private void btnAdd_Click(object sender, EventArgs e)
    {
      fAddNhaXuatBan f = new fAddNhaXuatBan();
      f.ShowDialog();
    }

    //  Cập nhật
    private void btnUpdate_Click(object sender, EventArgs e)
    {
      string id = txbMaNhaXuatBan.Text;
      string name = txbTenNhaXuatBan.Text;

      if (string.IsNullOrEmpty(name))
      {
        MessageBox.Show("Tên nhà xuất bản không được để trống!");
        txbTenNhaXuatBan.Focus();
      }
      else
      {
        if (nhaXuatBanBUS.Update(name, id))
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
        string id = txbMaNhaXuatBan.Text;
        if (nhaXuatBanBUS.Delete(id))
        {
          MessageBox.Show("Xóa nhà xuất bản thành công");
          Load();
        }
      }
      catch (Exception)
      {

        MessageBox.Show("Không thể xóa nhà xuất bản này!!!");
      }
    }

    //  Làm mới
    private void btnLoad_Click(object sender, EventArgs e)
    {
      Load();
    }

    //  Tìm kiếm
    private void btnSearch_Click_1(object sender, EventArgs e)
    {
      if (rdbID.Checked == true)
      {
        string id = txnSearch.Text;
        dtgvNhaXuatBan.DataSource = nhaXuatBanBUS.SearchByID(id);
      }
      else if (rdbName.Checked == true)
      {
        string name = txnSearch.Text;
        dtgvNhaXuatBan.DataSource = nhaXuatBanBUS.SearchByName(name);
      }
    }

    //  Binding
    private void dtgvNhaXuatBan_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {
      int i = dtgvNhaXuatBan.CurrentRow.Index;
      txbMaNhaXuatBan.Text = dtgvNhaXuatBan.Rows[i].Cells[0].Value.ToString();
      txbTenNhaXuatBan.Text = dtgvNhaXuatBan.Rows[i].Cells[1].Value.ToString();
      btnDelete.Enabled = true;
      btnUpdate.Enabled = true;
      txbTenNhaXuatBan.ReadOnly = false;
    }


  }
}
