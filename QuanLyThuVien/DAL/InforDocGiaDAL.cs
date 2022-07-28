using QuanLyThuVien.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVien.DAL
{
  class InforDocGiaDAL
  {
    public List<InforDocGiaDTO> ShowList()
    {
      List<InforDocGiaDTO> list = new List<InforDocGiaDTO>();
      DataTable data = DataProvider.Instance.ExecuteQuery("select * from InforDocGia");

      foreach (DataRow item in data.Rows)
      {
        InforDocGiaDTO obj = new InforDocGiaDTO(item);

        list.Add(obj);
      }

      return list;
    }

    public List<InforDocGiaDTO> SearchByMaDocGia(string id)
    {
      List<InforDocGiaDTO> list = new List<InforDocGiaDTO>();
      string query = string.Format($"select * from InforDocGia where idDocGia = N'{id}'");
      DataTable data = DataProvider.Instance.ExecuteQuery(query);

      foreach (DataRow item in data.Rows)
      {
        InforDocGiaDTO obj = new InforDocGiaDTO(item);

        list.Add(obj);
      }

      return list;
    }

    public List<InforDocGiaDTO> GetListMaDocGiaQuaHan()
    {
      List<InforDocGiaDTO> list = new List<InforDocGiaDTO>();
      DataTable data = DataProvider.Instance.ExecuteQuery("select * from InforDocGia where countTienPhat > 0");

      foreach (DataRow item in data.Rows)
      {
        InforDocGiaDTO obj = new InforDocGiaDTO(item);

        list.Add(obj);
      }

      return list;
    }

    public List<InforDocGiaDTO> GetListMaDocGiaTraMuonOrMatSach()
    {
      List<InforDocGiaDTO> list = new List<InforDocGiaDTO>();
      DataTable data = DataProvider.Instance.ExecuteQuery("select * from InforDocGia where countSachTraMuon > 0 or countsachLamMat > 0");

      foreach (DataRow item in data.Rows)
      {
        InforDocGiaDTO obj = new InforDocGiaDTO(item);

        list.Add(obj);
      }

      return list;
    }

    public List<InforDocGiaDTO> SearchByID(string id)
    {
      List<InforDocGiaDTO> list = new List<InforDocGiaDTO>();
      DataTable data = DataProvider.Instance.ExecuteQuery($"select * from InforDocGia where idDocGia = N'{id}'");

      foreach (DataRow item in data.Rows)
      {
        InforDocGiaDTO obj = new InforDocGiaDTO(item);

        list.Add(obj);
      }

      return list;
    }

    //  UPDATE TIỀN PHẠT INFORDOCGIA TABLE
    public bool UpdateTienPhatByPhieuThu(InforDocGiaDTO obj)
    {
      string query = "exec UpdateInforDocGiaByPhieuThu @id , @countTienPhat ";
      int rerult = DataProvider.Instance.ExecuteNonQuery(query, new object[]
        { obj.id, obj.countTienPhat});
      return rerult > 0;
    }

    public bool UpdateTienPhatByPhieuPhat(InforDocGiaDTO obj)
    {
      string query = "exec UpdateInforDocGiaByPhieuPhat @idDocGia , @countTienPhat ";
      int rerult = DataProvider.Instance.ExecuteNonQuery(query, new object[]
        { obj.idDocGia, obj.countTienPhat});
      return rerult > 0;
    }

    //  UPDATE INFORDOCGIA TABLE
    public bool UpdateInforDocGia(string idDocGia)
    {
      string query = "exec UpdateDataInforDocGiaTable @idDocGia";
      int rerult = DataProvider.Instance.ExecuteNonQuery(query, new object[]
        { idDocGia});
      return rerult > 0;
    }

  }
}
