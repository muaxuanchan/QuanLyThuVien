using QuanLyThuVien.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVien.DAL
{
  class PhieuPhatDAL
  {
    public List<PhieuPhatDTO> GetListPhieuPhat()
    {
      List<PhieuPhatDTO> list = new List<PhieuPhatDTO>();
      DataTable data = DataProvider.Instance.ExecuteQuery("select * from PhieuPhat");

      foreach (DataRow item in data.Rows)
      {
        PhieuPhatDTO obj = new PhieuPhatDTO(item);

        list.Add(obj);
      }

      return list;
    }

    public bool Insert(PhieuPhatDTO obj)
    {
      string query = "InsertPhieuPhat @idAdmin , @idInfor , @tienPhat , @dateTaoPhieu ";
      int rerult = DataProvider.Instance.ExecuteNonQuery(query, new object[]
        {obj.idAdmin, obj.idInfor, obj.tienPhat, obj.ngayTaoPhieu });
      return rerult > 0;

    }

    public List<PhieuPhatDTO> SearchByidAdmin(int id)
    {
      string query = $"select * from PhieuPhat where idAdmin = {id}";
      List<PhieuPhatDTO> list = new List<PhieuPhatDTO>();
      DataTable data = DataProvider.Instance.ExecuteQuery(query);

      foreach (DataRow item in data.Rows)
      {
        PhieuPhatDTO obj = new PhieuPhatDTO(item);

        list.Add(obj);
      }

      return list;
    }
    
    public List<PhieuPhatDTO> SearchByidInfor(int id)
    {
      string query = $"select * from PhieuPhat where idInfor = {id}";
      List<PhieuPhatDTO> list = new List<PhieuPhatDTO>();
      DataTable data = DataProvider.Instance.ExecuteQuery(query);

      foreach (DataRow item in data.Rows)
      {
        PhieuPhatDTO obj = new PhieuPhatDTO(item);

        list.Add(obj);
      }

      return list;
    }
  }
}
