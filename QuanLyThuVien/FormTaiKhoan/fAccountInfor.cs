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

namespace QuanLyThuVien
{
  public partial class fAccountInfor : Form
  {
    private TaiKhoanBUS taiKhoanBUS = new TaiKhoanBUS();
    
    public fAccountInfor()
    {
      InitializeComponent();
      if (!string.IsNullOrEmpty(fLogin.GetAdminInfor.user))
      {
        LoadInforAcc();
      }
    }

    void LoadInforAcc()
    {
      txbTenDangNhap.Text = fLogin.GetAdminInfor.user;
      TaiKhoanDTO acc = taiKhoanBUS.GetAccByUser(txbTenDangNhap.Text);
      txbTenHienThi.Text = acc.displayName.ToString();
      txbSoDienThoai.Text = acc.phoneNumber.ToString();
      txbQuyen.Text = acc.quyen.ToString();
    }

    void LoadInforPassWord()
    {
      txbMatKhauCu.Text = "";
      txbMatKhauMoi.Text = "";
      txbRepeatMatKkhau.Text = "";
    }

    void ButtonExitClick()
    {
      panelAccountInfor.Enabled = true;
      panelDoiMatKhau.Enabled = false;
      btnDoiMatKhau.Enabled = true;
      btnExit.Enabled = false;
      LoadInforPassWord();
    }

    void ButtonChangePassWordClick()
    {
      LoadInforAcc();
      panelAccountInfor.Enabled = false;
      panelDoiMatKhau.Enabled = true;
      btnDoiMatKhau.Enabled = false;
      btnExit.Enabled = true;
    }

    private void button1_Click(object sender, EventArgs e)
    {
      ButtonChangePassWordClick();
    }

    private void btnExit_Click(object sender, EventArgs e)
    {
      ButtonExitClick();
    }

    //  Cập nhật thông tin cơ bản
    private void btnUpdateAcountInfor_Click(object sender, EventArgs e)
    {
      TaiKhoanDTO acc = taiKhoanBUS.GetAccByUser(fLogin.GetAdminInfor.user);
      acc.displayName = txbTenHienThi.Text;
      acc.phoneNumber = txbSoDienThoai.Text;

      if (string.IsNullOrEmpty(acc.displayName))
      {
        MessageBox.Show("Tên hiển thị không được để trống!!!!");
        txbTenHienThi.Focus();
      }
      else if (string.IsNullOrEmpty(acc.phoneNumber))
      {
        MessageBox.Show("Số điện thoại không được để trống!!!!");
        txbSoDienThoai.Focus();
      }
      if (taiKhoanBUS.UpdateInforBase(acc))
      {
        MessageBox.Show("Cập nhật thông tin thành công.");
        LoadInforAcc();
      }
    }

    //  Cập nhật mật khẩu
    private void btnUpdateMatKhau_Click(object sender, EventArgs e)
    {
      TaiKhoanDTO acc = taiKhoanBUS.GetAccByUser(fLogin.GetAdminInfor.user);

      acc.passWord = Md5.Encrypt(txbMatKhauCu.Text);
      //acc.passWord = txbMatKhauCu.Text;
      string newPassWord = txbMatKhauMoi.Text;
      string repeatPassWord = txbRepeatMatKkhau.Text;

      if (!newPassWord.Equals(repeatPassWord))
      {
        MessageBox.Show("Mật khẩu nhập lại không đúng!!!");
        txbRepeatMatKkhau.Focus();
      }
      else
      {
        string newPass = Md5.Encrypt(repeatPassWord);
        if (taiKhoanBUS.UpdatePassWord(acc, newPass))
        {
          MessageBox.Show("Cập nhật thông tin thành công");
          LoadInforPassWord();
          ButtonExitClick();
        }
        else
        {
          MessageBox.Show("Mật khẩu cũ nhập vào không chính xác!!!");
          txbRepeatMatKkhau.Focus();
        }
      }
    }
  }
}
