using QuanLyThuVien.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVien.DAL
{
  class NhaXuatBanDAL
  {
    public List<NhaXuatBanDTO> GetListNhaXuatBan()
    {
      List<NhaXuatBanDTO> listAcc = new List<NhaXuatBanDTO>();
      DataTable data = DataProvider.Instance.ExecuteQuery("select * from NhaXuatBan");

      foreach (DataRow item in data.Rows)
      {
        NhaXuatBanDTO acc = new NhaXuatBanDTO(item);

        listAcc.Add(acc);
      }

      return listAcc;
    }

    // Thêm loại đọc giả
    public bool Insert(NhaXuatBanDTO DTO)
    {
      string query = "exec InsertNhaXuatBan @id , @name";

      int data = DataProvider.Instance.ExecuteNonQuery(query, new object[]
                  { DTO.id, DTO.name});
      return data > 0;
    }

    //  Sửa
    public bool Update(string name, string id)
    {
      string query = string.Format("update NhaXuatBan set name = N'{0}' where id = N'{1}'", name.ToString(), id.ToString());
      int result = DataProvider.Instance.ExecuteNonQuery(query);
      return result > 0;
    }

    // Xóa
    public bool Delete(string id)
    {
      string query = string.Format("delete from NhaXuatBan where id = N'{0}'", id.ToString());
      int result = DataProvider.Instance.ExecuteNonQuery(query);
      return result > 0;
    }

    //  Tìm kiếm theo mã
    public List<NhaXuatBanDTO> SearchByID(string id)
    {
      List<NhaXuatBanDTO> listNXB = new List<NhaXuatBanDTO>();

      string query = string.Format("select * from NhaXuatBan where id like N'%{0}%'", id.ToString());
      DataTable data = DataProvider.Instance.ExecuteQuery(query);

      foreach (DataRow item in data.Rows)
      {
        NhaXuatBanDTO type = new NhaXuatBanDTO(item);

        listNXB.Add(type);
      }

      return listNXB;
    }

    //  Tìm kiếm theo tên
    public List<NhaXuatBanDTO> SearchByName(string name)
    {
      List<NhaXuatBanDTO> listNXB = new List<NhaXuatBanDTO>();

      string query = string.Format("select * from NhaXuatBan where name like N'%{0}%'", name.ToString());
      DataTable data = DataProvider.Instance.ExecuteQuery(query);

      foreach (DataRow item in data.Rows)
      {
        NhaXuatBanDTO type = new NhaXuatBanDTO(item);

        listNXB.Add(type);
      }

      return listNXB;
    }

    //  Lấy id max
    public string GetIdMaxNhaXuatBan()
    {
      try
      {
        string query = "select MAX(id) from NhaXuatBan";
        string data = DataProvider.Instance.ExecuteScalar(query).ToString();
        return data;
      }
      catch (Exception)
      {
        return null;
      }

    }
  }
}
