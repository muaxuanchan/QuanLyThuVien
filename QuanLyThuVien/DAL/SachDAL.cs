using QuanLyThuVien.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVien.DAL
{
  class SachDAL
  {
    // Lấy list sách
    public List<SachDTO> GetListSach()
    {
      List<SachDTO> list = new List<SachDTO>();
      DataTable data = DataProvider.Instance.ExecuteQuery("select * from Sach");

      foreach (DataRow item in data.Rows)
      {
        SachDTO s = new SachDTO(item);

        list.Add(s);
      }

      return list;
    }

    // Lấy list sách với số sách còn lại khác 0
    public List<SachDTO> GetListSachDifferentZero()
    {
      List<SachDTO> list = new List<SachDTO>();
      DataTable data = DataProvider.Instance.ExecuteQuery("select * from Sach where conLai != 0");

      foreach (DataRow item in data.Rows)
      {
        SachDTO s = new SachDTO(item);

        list.Add(s);
      }

      return list;
    }

    // Thêm
    public bool Insert(SachDTO DTO)
    {
      string query = "exec InsertSach @id , @name , @idCategorySach , @idTacGia , @idNXB , @money , @soLuong ";

      int data = DataProvider.Instance.ExecuteNonQuery(query, new object[]
                  { DTO.id, DTO.name, DTO.idCategorySach, DTO.idTacGia, DTO.idNXB, DTO.money, DTO.soLuong});
      return data > 0;
    }

    // Test Import file excel to sql
    public bool TestInsert(SachDTO DTO)
    {
      string query = "exec TestInsertSach @id , @name , @idCategorySach , @idTacGia , @idNXB , @money , @soLuong ";

      int data = DataProvider.Instance.ExecuteNonQuery(query, new object[]
                  { DTO.id, DTO.name, DTO.idCategorySach, DTO.idTacGia, DTO.idNXB, DTO.money, DTO.soLuong});
      return data > 0;
    }

    //  Sửa
    public bool Update(SachDTO DTO)
    {
      string query = string.Format("exec UpdateSach @id , @name , @idCategorySach , @idTacGia , @idNXB , @money , @soLuong ");
      int result = DataProvider.Instance.ExecuteNonQuery(query, new object[]
                  { DTO.id, DTO.name, DTO.idCategorySach, DTO.idTacGia, DTO.idNXB, DTO.money, DTO.soLuong});
      return result > 0;
    }

    // Update sách theo add BillInfor
    public bool UpdateByAddBillInfor(string id)
    {
      string query = string.Format("exec UpdateSachByAddBillInfor @id ");
      int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { id});
      return result > 0;
    }

    // Update sách by delete BillInfor
    public bool UpdateSachByReturnBillInfor(string id)
    {
      string query = string.Format("exec UpdateSachByDeleteBillInfor @id ");
      int result = DataProvider.Instance.ExecuteNonQuery(query, new object[] { id });
      return result > 0;
    }

    // Update sách if return mất sách
    public bool UpdateSachReturnMatSach(string id)
    {
      string query = $"update Sach set soLuong = soLuong - 1 where id = N'{id}'";
      int result = DataProvider.Instance.ExecuteNonQuery(query);
      return result > 0;
    }

    // Xóa
    public bool Delete(string id)
    {
      string query = string.Format("delete from Sach where id = N'{0}'", id.ToString());
      int result = DataProvider.Instance.ExecuteNonQuery(query);
      return result > 0;
    }

    public SachDTO GetSachByID(string id)
    {
      SachDTO s = new SachDTO();

      string query = string.Format("select * from Sach where id like N'%{0}%'", id.ToString());
      DataTable data = DataProvider.Instance.ExecuteQuery(query);

      foreach (DataRow item in data.Rows)
      {
        s = new SachDTO(item);
      }

      return s;
    }

    //  Tìm kiếm theo id
    public List<SachDTO> SearchByID(string id)
    {
      List<SachDTO> list = new List<SachDTO>();

      string query = string.Format("select * from Sach where id = N'{0}'", id.ToString());
      DataTable data = DataProvider.Instance.ExecuteQuery(query);

      foreach (DataRow item in data.Rows)
      {
        SachDTO type = new SachDTO(item);

        list.Add(type);
      }

      return list;
    }

    //  Tìm kiếm theo tên
    public List<SachDTO> SearchByName(string name)
    {
      List<SachDTO> list = new List<SachDTO>();

      string query = string.Format("select * from Sach where name like N'%{0}%'", name.ToString());
      DataTable data = DataProvider.Instance.ExecuteQuery(query);

      foreach (DataRow item in data.Rows)
      {
        SachDTO type = new SachDTO(item);

        list.Add(type);
      }

      return list;
    }

    // Lấy tổng số sách
    public int GetAmountSach()
    {
      try
      {
        string query = string.Format("select SUM(soLuong) from Sach");
        int rerult = (int)DataProvider.Instance.ExecuteScalar(query);
        return rerult;
      }
      catch (Exception)
      {
        return 0;
      }
      
    }

    // Lấy tổng số sách còn lại
    public int GetAmountSachConLai()
    {
      try
      {
        string query = string.Format("select SUM(conLai) from Sach");
        int rerult = (int)DataProvider.Instance.ExecuteScalar(query);
        return rerult;
      }
      catch (Exception)
      {
        return 0;
      }

    }

    //  Lấy id max
    public string GetIdMaxSach()
    {
      string query = "select MAX(id) from Sach";
      string data = DataProvider.Instance.ExecuteScalar(query).ToString();
      return data;
    }

    //  Test get id max
    public string TestGetIdMaxSach()
    {
      string query = "select MAX(id) from TestTableSach";
      string data = DataProvider.Instance.ExecuteScalar(query).ToString();
      return data;
    }

  }
}
