using QuanLyThuVien.BUS;
using QuanLyThuVien.DTO;
using QuanLyThuVien.TaiKhoan;
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
  public partial class fAdmin : Form
  {
    TaiKhoanBUS taiKhoanBUS = new TaiKhoanBUS();

    private int[] arrTypeAccount = new int[] { -1, 0, 1, 2 };
    private List<int> listTypeAccount = new List<int>();

    public fAdmin()
    {
      InitializeComponent();
      Load();
    }

    private new void Load()
    {
      foreach (int item in arrTypeAccount)
      {
        listTypeAccount.Add(item);
      }

      cbQuyen.DataSource = listTypeAccount;

      GetListTaiKhoan();
      GetHeaderText();
      RefreshText();
      btnDelete.Enabled = false;
      btnUpdate.Enabled = false;
    }

    //  Hiển thị danh sách tài khoản
    void GetListTaiKhoan()
    {
      dtgvTaiKhoan.DataSource = taiKhoanBUS.GetListTaiKhoan();
    }

    // Reset textbox
    void RefreshText()
    {
      txbID.Text = "";
      txbTenTaiKhoan.Text = "";
      txbPass.Text = "";
      txbDisplayName.Text = "";
      txbPhoneNumber.Text = "";
      cbQuyen.Text = "";
    }

    // Đổi tên cột trong datagridview
    void GetHeaderText()
    {
      dtgvTaiKhoan.Columns[0].HeaderText = "Mã tài khoản";
      dtgvTaiKhoan.Columns[1].HeaderText = "User name";
      dtgvTaiKhoan.Columns[2].HeaderText = "Password";
      dtgvTaiKhoan.Columns[3].HeaderText = "Display name";
      dtgvTaiKhoan.Columns[4].HeaderText = "Phone number";
      dtgvTaiKhoan.Columns[5].HeaderText = "Type account";
    }

    //  Làm mới datagridview
    private void btnLoad_Click(object sender, EventArgs e)
    {
      Load();
    }

    // Lấy thông tin theo cellContent
    private void dtgvTaiKhoan_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {
      int i = dtgvTaiKhoan.CurrentRow.Index;
      txbID.Text = dtgvTaiKhoan.Rows[i].Cells[0].Value.ToString();
      txbTenTaiKhoan.Text = dtgvTaiKhoan.Rows[i].Cells[1].Value.ToString();
      txbPass.Text = dtgvTaiKhoan.Rows[i].Cells[2].Value.ToString();
      txbDisplayName.Text = dtgvTaiKhoan.Rows[i].Cells[3].Value.ToString();
      txbPhoneNumber.Text = dtgvTaiKhoan.Rows[i].Cells[4].Value.ToString();
      cbQuyen.Text = dtgvTaiKhoan.Rows[i].Cells[5].Value.ToString();
      btnDelete.Enabled = true;
      btnUpdate.Enabled = true;
    }

    // Thêm tài khoản
    private void btnAdd_Click(object sender, EventArgs e)
    {
      fAddTaiKhoan f = new fAddTaiKhoan();
      f.ShowDialog();
    }

    //  Xóa tài khoản
    private void btnDelete_Click(object sender, EventArgs e)
    {

      int id = Convert.ToInt32(txbID.Text);
      if (taiKhoanBUS.DeleteAcc(id))
      {
        MessageBox.Show("Xóa tài khoản thành công");
        Load();
      }

    }

    private void btnUpdate_Click(object sender, EventArgs e)
    {
      TaiKhoanDTO tk = new TaiKhoanDTO();
      tk.id = int.Parse(txbID.Text);
      tk.quyen = int.Parse(cbQuyen.Text);

      if (taiKhoanBUS.UpdateAcc(tk))
      {
        MessageBox.Show("Cập nhật quyền khoản thành công");
        Load();
      }

    }
  }
}
