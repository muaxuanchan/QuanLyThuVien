using QuanLyThuVien.BUS;
using QuanLyThuVien.DTO;
using QuanLyThuVien.MaHoa;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThuVien.TaiKhoan
{
  public partial class fAddTaiKhoan : Form
  {

    int[] typeAccount = new int[] { 0, 1, 2 };
    List<int> listTypeAccount = new List<int>();

    public fAddTaiKhoan()
    {
      InitializeComponent();
      Load();
    }

    TaiKhoanBUS taiKhoanBUS = new TaiKhoanBUS();

    new void Load()
    {
      foreach (int item in typeAccount)
      {
        listTypeAccount.Add(item);
      }

      cbQuyen.DataSource = listTypeAccount;
    }

    // Thêm Tài khoản
    private void btnAdd_Click(object sender, EventArgs e)
    {
      string userName = txbTenTaiKhoan.Text;
      string checkPassWord = txbPassWord.Text;
      string passWord = Md5.Encrypt(checkPassWord);
      string displayName = txbDisplayName.Text;
      string phoneNumber = txbPhoneNumber.Text;

      int numberAcc = taiKhoanBUS.GetAmountAcc(userName);

      if (numberAcc.Equals(1))
      {
        MessageBox.Show("Tên tài khoản đã tồn tại!!!!");
        txbTenTaiKhoan.Focus();
      }
      else if (string.IsNullOrEmpty(userName))
      {
        MessageBox.Show("Tên tài khoản không được để trống!!!!");
        txbTenTaiKhoan.Focus();
      }
      else if (string.IsNullOrEmpty(checkPassWord))
      {
        MessageBox.Show("Mật khẩu không được để trống!!!!");
        txbPassWord.Focus();
      }
      else if (string.IsNullOrEmpty(cbQuyen.Text))
      {
        MessageBox.Show("Quyền tài khoản không được để trống!!!");
        cbQuyen.Focus();
      }
      else
      {
        int quyen = Convert.ToInt32(cbQuyen.Text);

        if (taiKhoanBUS.InsertTaiKhoan(userName, passWord, displayName, phoneNumber, quyen))
        {
          MessageBox.Show("Thêm tài khoản thành công");
          this.Close();
        }
      }
    }
  }
}
