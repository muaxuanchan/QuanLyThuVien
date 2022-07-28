using QuanLyThuVien.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVien.DAL
{
  class LoaiSachDAL
  {
    // Lấy danh sách loại đọc giả
    public List<LoaiSachDTO> GetListLoaiSach()
    {
      List<LoaiSachDTO> listAcc = new List<LoaiSachDTO>();
      DataTable data = DataProvider.Instance.ExecuteQuery("select * from LoaiSach");

      foreach (DataRow item in data.Rows)
      {
        LoaiSachDTO acc = new LoaiSachDTO(item);

        listAcc.Add(acc);
      }

      return listAcc;
    }

    // Thêm loại đọc giả
    public bool Insert(LoaiSachDTO lsDTO)
    {
      string query = "exec InsertLoaiSach @id , @name";

      int data = DataProvider.Instance.ExecuteNonQuery(query, new object[]
                  { lsDTO.id, lsDTO.name});
      return data > 0;
    }

    //  Sửa
    public bool Update(string name, string id)
    {
      string query = string.Format("update LoaiSach set name = N'{0}' where id = N'{1}'", name.ToString(), id.ToString());
      int result = DataProvider.Instance.ExecuteNonQuery(query);
      return result > 0;
    }

    // Xóa
    public bool Delete(string id)
    {
      string query = string.Format("delete from LoaiSach where id = N'{0}'", id.ToString());
      int result = DataProvider.Instance.ExecuteNonQuery(query);
      return result > 0;
    }

    //  Tìm kiếm theo mã
    public List<LoaiSachDTO> SearchByID(string id)
    {
      List<LoaiSachDTO> listLS = new List<LoaiSachDTO>();

      string query = string.Format("select * from LoaiSach where id like N'%{0}%'", id.ToString());
      DataTable data = DataProvider.Instance.ExecuteQuery(query);

      foreach (DataRow item in data.Rows)
      {
        LoaiSachDTO type = new LoaiSachDTO(item);

        listLS.Add(type);
      }

      return listLS;
    }

    //  Tìm kiếm theo tên
    public List<LoaiSachDTO> SearchByName(string name)
    {
      List<LoaiSachDTO> listLS = new List<LoaiSachDTO>();

      string query = string.Format("select * from LoaiSach where name like N'%{0}%'", name.ToString());
      DataTable data = DataProvider.Instance.ExecuteQuery(query);

      foreach (DataRow item in data.Rows)
      {
        LoaiSachDTO type = new LoaiSachDTO(item);

        listLS.Add(type);
      }

      return listLS;
    }

    //  Lấy id max
    public string GetIdMaxLoaiSach()
    {
      string query = "select MAX(id) from LoaiSach";
      string data = DataProvider.Instance.ExecuteScalar(query).ToString();
      return data;
    }

  }
}
