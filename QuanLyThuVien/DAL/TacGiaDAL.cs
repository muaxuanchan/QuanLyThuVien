using QuanLyThuVien.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVien.DAL
{
  class TacGiaDAL
  {
    public List<TacGiaDTO> GetListTacGia()
    {
      List<TacGiaDTO> listAcc = new List<TacGiaDTO>();
      DataTable data = DataProvider.Instance.ExecuteQuery("select * from TacGia");

      foreach (DataRow item in data.Rows)
      {
        TacGiaDTO acc = new TacGiaDTO(item);

        listAcc.Add(acc);
      }

      return listAcc;
    }

    // Thêm tác giả
    public bool Insert(TacGiaDTO DTO)
    {
      string query = "exec InsertTacGia @id , @name";

      int data = DataProvider.Instance.ExecuteNonQuery(query, new object[]
                  { DTO.id, DTO.name});
      return data > 0;
    }

    //  Sửa
    public bool Update(string name, string id)
    {
      string query = string.Format("update TacGia set name = N'{0}' where id = N'{1}'", name.ToString(), id.ToString());
      int result = DataProvider.Instance.ExecuteNonQuery(query);
      return result > 0;
    }

    // Xóa
    public bool Delete(string id)
    {
      string query = string.Format("delete from TacGia where id = N'{0}'", id.ToString());
      int result = DataProvider.Instance.ExecuteNonQuery(query);
      return result > 0;
    }

    //  Tìm kiếm theo mã
    public List<TacGiaDTO> SearchByID(string id)
    {
      List<TacGiaDTO> listAcc = new List<TacGiaDTO>();

      string query = string.Format("select * from TacGia where id like N'%{0}%'", id.ToString());
      DataTable data = DataProvider.Instance.ExecuteQuery(query);

      foreach (DataRow item in data.Rows)
      {
        TacGiaDTO type = new TacGiaDTO(item);

        listAcc.Add(type);
      }

      return listAcc;
    }

    //  Tìm kiếm theo tên
    public List<TacGiaDTO> SearchByName(string name)
    {
      List<TacGiaDTO> listAcc = new List<TacGiaDTO>();

      string query = string.Format("select * from TacGia where name like N'%{0}%'", name.ToString());
      DataTable data = DataProvider.Instance.ExecuteQuery(query);

      foreach (DataRow item in data.Rows)
      {
        TacGiaDTO type = new TacGiaDTO(item);

        listAcc.Add(type);
      }

      return listAcc;
    }

    //  Lấy id max
    public string GetIdMaxTacGia()
    {
      try
      {
        string query = "select MAX(id) from TacGia";
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
