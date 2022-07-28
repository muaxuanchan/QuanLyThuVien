using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyThuVien.DTO;


namespace QuanLyThuVien.DAL
{
  class TaiKhoanDAL
  {

    // Lấy danh sách tài khoản
    public List<TaiKhoanDTO> GetListTaiKhoan()
    {
      List<TaiKhoanDTO> listAcc = new List<TaiKhoanDTO>();
      DataTable data = DataProvider.Instance.ExecuteQuery("select * from TaiKhoan");

      foreach (DataRow item in data.Rows)
      {
        TaiKhoanDTO acc = new TaiKhoanDTO(item);

        listAcc.Add(acc);
      }

      return listAcc;
    }

    // Thêm tài khoản vào hệ thống
    public bool InsertTaiKhoan(string userName, string passWord, string displayName, string phoneNumber, int quyen)
    {
      string query = "exec InsertAccount @userName , @passWord , @displayName , @phoneNumber , @quyen";

      int data = DataProvider.Instance.ExecuteNonQuery(query, new object[]
                  { userName, passWord, displayName, phoneNumber,quyen });
      return data > 0;
    }

    // Tìm kiếm tài khoản theo username
    public List<TaiKhoanDTO> GetAccByUserName(string userName)
    {
      List<TaiKhoanDTO> listAcc = new List<TaiKhoanDTO>();

      string query = string.Format("select * from TaiKhoan where userName like N'%{0}%'", userName);
      DataTable data = DataProvider.Instance.ExecuteQuery(query);

      foreach (DataRow item in data.Rows)
      {
        TaiKhoanDTO acc = new TaiKhoanDTO(item);

        listAcc.Add(acc);
      }

      return listAcc;
    }

    // lấy thông tin tài khoản theo username
    public TaiKhoanDTO GetAccByUser(string userName)
    {
      DataTable data = DataProvider.Instance.ExecuteQuery("select * from TaiKhoan where userName = '" + userName + "'");

      foreach (DataRow item in data.Rows)
      {
        return new TaiKhoanDTO(item);
      }

      return null;
    }

    // Kiểm tra tài khoản đăng nhập vào hệ thống
    public bool Login(string userName, string pass)
    {
      string query = string.Format("select * from TaiKhoan where userName = N'{0}' and passWord = N'{1}' and quyen != -1", userName, pass);
      DataTable rerult = DataProvider.Instance.ExecuteQuery(query);
      return rerult.Rows.Count > 0;
    }

    // Lấy số lượng tài khoản theo username
    public int GetAmountAcc(string userName)
    {
      string query = string.Format("select Count(userName) from TaiKhoan where userName = N'{0}'", userName);
      try
      {
        int sl = (int)DataProvider.Instance.ExecuteScalar(query);
        return sl;
      }
      catch (Exception)
      {
        return 0;
      }
    }

    // Delete tài khoản khỏi database
    public bool DeleteAcc(int id)
    {
      string query = String.Format("Update TaiKhoan set quyen = 2 where id={0}", id);
      int result = DataProvider.Instance.ExecuteNonQuery(query);
      return result > 0;
    }

    //  Cập nhật quyền
    public bool UpdateAcc(TaiKhoanDTO tk)
    {
      string query = String.Format("Update TaiKhoan set quyen = {0} where id={1}", tk.quyen, tk.id);
      int result = DataProvider.Instance.ExecuteNonQuery(query);
      return result > 0;
    }

    // Cập nhật thông tin cơ bản tài khoản
    public bool UpdateInforBase(TaiKhoanDTO acc)
    {
      string query = string.Format("update TaiKhoan set displayName = N'{0}', phoneNumber = N'{1}' where id = {2}",
                                      acc.displayName, acc.phoneNumber, acc.id);
      int rerult = DataProvider.Instance.ExecuteNonQuery(query);
      return rerult > 0;
    }

    // Cập nhật mật khẩu
    public bool UpdatePassWord(TaiKhoanDTO acc, string newPass)
    {
      string query = string.Format("exec UpdatePassWord @id , @pass , @newPass");
      int rerult = DataProvider.Instance.ExecuteNonQuery(query, new object[] { acc.id, acc.passWord, newPass });
      return rerult > 0;
    }
  }
}
