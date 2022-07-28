using QuanLyThuVien.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVien.DAL
{
  class PhieuThuDAL
  {
    public List<PhieuThuDTO> GetListPhieuThu()
    {
      List<PhieuThuDTO> list = new List<PhieuThuDTO>();
      DataTable data = DataProvider.Instance.ExecuteQuery("select * from PhieuThu");

      foreach (DataRow item in data.Rows)
      {
        PhieuThuDTO obj = new PhieuThuDTO(item);

        list.Add(obj);
      }

      return list;
    }

    public bool Insert(PhieuThuDTO obj)
    {
      string query = "exec InsertPhieuThu @idAdmin , @idInfor , @countTienThu , @ngayTaoPhieu ";

      int data = DataProvider.Instance.ExecuteNonQuery(query, new object[]
                  { obj.idAdmin, obj.idInfor, obj.tienThu, obj.ngayTaoPhieu });
      return data > 0;
    }

    public List<PhieuThuDTO> SearchByidAdmin(int id)
    {
      string query = $"select * from PhieuThu where idAdmin = {id}";
      List<PhieuThuDTO> list = new List<PhieuThuDTO>();
      DataTable data = DataProvider.Instance.ExecuteQuery(query);

      foreach (DataRow item in data.Rows)
      {
        PhieuThuDTO obj = new PhieuThuDTO(item);

        list.Add(obj);
      }

      return list;
    }

    public List<PhieuThuDTO> SearchByidInfor(int id)
    {
      string query = $"select * from PhieuThu where idInfor = {id}";
      List<PhieuThuDTO> list = new List<PhieuThuDTO>();
      DataTable data = DataProvider.Instance.ExecuteQuery(query);

      foreach (DataRow item in data.Rows)
      {
        PhieuThuDTO obj = new PhieuThuDTO(item);

        list.Add(obj);
      }

      return list;
    }
  }
}
