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
  public partial class fTacGia : Form
  {

    TacGiaBUS tacGiaBUS = new TacGiaBUS();

    public fTacGia()
    {
      InitializeComponent();
      Load();
    }

    private void btnAdd_Click(object sender, EventArgs e)
    {
      fAddTacGia f = new fAddTacGia();
      f.ShowDialog();
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
      txbMaTacGia.ReadOnly = true;
      txbTenTacGia.ReadOnly = true;
    }

    //  Hiển thị danh sách
    void GetList()
    {
      dtgvTacGia.DataSource = tacGiaBUS.GetListTacGia();
    }

    // Đổi tên cột datagridview
    void GetHeaderText()
    {
      dtgvTacGia.Columns[0].HeaderText = "Mã tác giả";
      dtgvTacGia.Columns[1].HeaderText = "Tên tác giả";
    }

    //  Làm mới textbox
    void LoadNewTextBox()
    {
      txbMaTacGia.Text = "";
      txbTenTacGia.Text = "";
    }

    //  Sửa
    private void btnUpdate_Click(object sender, EventArgs e)
    {
      string id = txbMaTacGia.Text;
      string name = txbTenTacGia.Text;

      if (string.IsNullOrEmpty(name))
      {
        MessageBox.Show("Tên tác giả không được để trống!");
        txbTenTacGia.Focus();
      }
      else
      {
        if (tacGiaBUS.Update(name, id))
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
        string id = txbMaTacGia.Text;
        if (tacGiaBUS.Delete(id))
        {
          MessageBox.Show("Xóa tác giả thành công");
          Load();
        }
      }
      catch (Exception)
      {

        MessageBox.Show("Không thể xóa tác giả này!!!");
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
        dtgvTacGia.DataSource = tacGiaBUS.SearchByID(id);
      }
      else if (rdbName.Checked == true)
      {
        string name = txnSearch.Text;
        dtgvTacGia.DataSource = tacGiaBUS.SearchByName(name);
      }
    }

    //  Binding
    private void dtgvTacGia_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {
      int i = dtgvTacGia.CurrentRow.Index;
      txbMaTacGia.Text = dtgvTacGia.Rows[i].Cells[0].Value.ToString();
      txbTenTacGia.Text = dtgvTacGia.Rows[i].Cells[1].Value.ToString();
      btnDelete.Enabled = true;
      btnUpdate.Enabled = true;
      txbTenTacGia.ReadOnly = false;
    }


  }
}
