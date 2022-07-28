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
  public partial class fLogin : Form
  {
    public fLogin()
    {
      InitializeComponent();
    }

    TaiKhoanBUS taiKhoanBUS = new TaiKhoanBUS();

    public class GetAdminInfor
    {
      static public string user;
      static public string idAdmin;
      static public string nameAdmin;
      static public int quyen;
    }

    private void SignInApp()
    {     
      string userName = txbUserName.Text;
      GetAdminInfor.user = userName;
      TaiKhoanDTO acc = taiKhoanBUS.GetAccByUser(userName);
      GetAdminInfor.idAdmin = acc.id.ToString();
      GetAdminInfor.nameAdmin = acc.displayName;
      GetAdminInfor.quyen = acc.quyen;

      string passWord = Md5.Encrypt(txbPassWord.Text);
      if (taiKhoanBUS.Login(userName, passWord))
      {
        fManager f = new fManager();
        this.Hide();
        txbPassWord.Text = "";
        f.ShowDialog();
        this.Show();
      }
      else
      {
        MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu!!!", "Thông báo");
      }
    }

    //  Đăng nhập
    private void btnAdd_Click(object sender, EventArgs e)
    {
      SignInApp();
    }

    private void btnUpdate_Click(object sender, EventArgs e)
    {
      Application.Exit();
    }

    private void fLogin_FormClosing(object sender, FormClosingEventArgs e)
    {
      if (MessageBox.Show("Bạn có thực sự muốn thoát!!", "Thông báo", MessageBoxButtons.OKCancel) != DialogResult.OK)
      {
        e.Cancel = true;
      }
    }

    private void txbPassWord_KeyDown(object sender, KeyEventArgs e)
    {
      if (e.KeyCode == Keys.Enter)
      {
        SignInApp();
      }
    }
  }
}
