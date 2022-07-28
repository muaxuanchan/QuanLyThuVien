using QuanLyThuVien.DAL;
using QuanLyThuVien.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVien.BUS
{
  class TaiKhoanBUS
  {
    TaiKhoanDAL taiKhoanDAL = new TaiKhoanDAL();

    // Lấy danh sách tài khoản
    public List<DTO.TaiKhoanDTO> GetListTaiKhoan()
    {
      return taiKhoanDAL.GetListTaiKhoan();
    }

    //Thêm tài khoản vào hệ thống
    public bool InsertTaiKhoan(string userName, string passWord, string displayName, string phoneNumber, int quyen)
    {
      return taiKhoanDAL.InsertTaiKhoan(userName, passWord, displayName, phoneNumber, quyen);
    }

    // Tìm kiếm tài khoản theo username
    public List<TaiKhoanDTO> GetAccByUserName(string userName)
    {
      return taiKhoanDAL.GetAccByUserName(userName);
    }

    // Lấy thông tin tài khoản theo username
    public TaiKhoanDTO GetAccByUser(String userName)
    {
      return taiKhoanDAL.GetAccByUser(userName);
    }

    // Lấy số lượng tài khoản theo username
    public int GetAmountAcc(string username)
    {
      return (int)taiKhoanDAL.GetAmountAcc(username);
    }

    //Đăng nhập vào hệ thống
    public bool Login(string userName, string pass)
    {
      return taiKhoanDAL.Login(userName, pass);
    }

    //  Xóa tài khoản
    public bool DeleteAcc(int id)
    {
      return taiKhoanDAL.DeleteAcc(id);
    }

    //  Cập nhật quyền
    public bool UpdateAcc(TaiKhoanDTO tk)
    {
      return taiKhoanDAL.UpdateAcc(tk);
    }

    // Cập nhật thông tin cơ bản tài khoản
    public bool UpdateInforBase(TaiKhoanDTO acc)
    {
      return taiKhoanDAL.UpdateInforBase(acc);
    }

    // Cập nhật mật khẩu
    public bool UpdatePassWord(TaiKhoanDTO acc, string newPassWord)
    {
      return taiKhoanDAL.UpdatePassWord(acc, newPassWord);
    }

  }
}
