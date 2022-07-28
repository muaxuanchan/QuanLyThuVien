using QuanLyThuVien.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVien.DAL
{
  class LoaiDocGiaDAL
  {
    // Lấy danh sách loại đọc giả
    public List<LoaiDocGiaDTO> GetListTypeDocGia()
    {
      List<LoaiDocGiaDTO> listAcc = new List<LoaiDocGiaDTO>();
      DataTable data = DataProvider.Instance.ExecuteQuery("select * from LoaiDocGia");

      foreach (DataRow item in data.Rows)
      {
        LoaiDocGiaDTO acc = new LoaiDocGiaDTO(item);

        listAcc.Add(acc);
      }

      return listAcc;
    }

    // Thêm loại đọc giả
    public bool InsertLoaiDocGia(LoaiDocGiaDTO loaiDocGiaDTO)
    {
      string query = "exec InsertLoaiDocGia @id , @name";

      int data = DataProvider.Instance.ExecuteNonQuery(query, new object[]
                  { loaiDocGiaDTO.id, loaiDocGiaDTO.name});
      return data > 0;
    }

    //  Sửa
    public bool Update(string name, string id)
    {
      string query = string.Format("update LoaiDocGia set name = N'{0}' where id = N'{1}'", name.ToString(), id.ToString());
      int result = DataProvider.Instance.ExecuteNonQuery(query);
      return result > 0;
    }

    // Xóa
    public bool DeleteLoaiDocGia(string id)
    {
      string query = string.Format("delete from LoaiDocGia where id = N'{0}'", id.ToString());
      int result = DataProvider.Instance.ExecuteNonQuery(query);
      return result > 0;
    }

    //  Tìm kiếm theo mã
    public List<LoaiDocGiaDTO> SearchByID(string id)
    {
      List<LoaiDocGiaDTO> listAcc = new List<LoaiDocGiaDTO>();

      string query = string.Format("select * from LoaiDocGia where id like N'%{0}%'", id.ToString());
      DataTable data = DataProvider.Instance.ExecuteQuery(query);

      foreach (DataRow item in data.Rows)
      {
        LoaiDocGiaDTO type = new LoaiDocGiaDTO(item);

        listAcc.Add(type);
      }

      return listAcc;
    }

    //  Tìm kiếm theo tên
    public List<LoaiDocGiaDTO> SearchByName(string name)
    {
      List<LoaiDocGiaDTO> listAcc = new List<LoaiDocGiaDTO>();

      string query = string.Format("select * from LoaiDocGia where name like N'%{0}%'", name.ToString());
      DataTable data = DataProvider.Instance.ExecuteQuery(query);

      foreach (DataRow item in data.Rows)
      {
        LoaiDocGiaDTO type = new LoaiDocGiaDTO(item);

        listAcc.Add(type);
      }

      return listAcc;
    }

    //  lấy id max loại đọc giả
    public string GetIdMaxLoaiDocGia()
    {
      string query = "select MAX(id) from LoaiDocGia";
      string data = DataProvider.Instance.ExecuteScalar(query).ToString();
      return data;
    }
  }
}
