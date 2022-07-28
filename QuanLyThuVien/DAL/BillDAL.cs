using QuanLyThuVien.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVien.DAL
{
  class BillDAL
  {
    // Lấy danh sách phiếu mượn
    public List<BillDTO> GetListPhieuMuon()
    {
      List<BillDTO> list = new List<BillDTO>();
      DataTable data = DataProvider.Instance.ExecuteQuery("select * from Bill");

      foreach (DataRow item in data.Rows)
      {
        BillDTO bill = new BillDTO(item);

        list.Add(bill);
      }

      return list;
    }

    // Lấy danh sách phiếu mượn chưa trả
    public List<BillDTO> GetListPhieuMuonChuaTra()
    {
      List<BillDTO> list = new List<BillDTO>();
      DataTable data = DataProvider.Instance.ExecuteQuery("select * from Bill where status is null");

      foreach (DataRow item in data.Rows)
      {
        BillDTO bill = new BillDTO(item);

        list.Add(bill);
      }

      return list;
    }

    public List<string> GetListMaDocGiaByBillChuaTra()
    {
      List<string> list = new List<string>();
      DataTable data = DataProvider.Instance.ExecuteQuery("select  distinct idDocGia from Bill where status is null");

      foreach (var item in data.Rows)
      {
        list.Add(item.ToString());
      }

      return list;
    }

    //Lấy id bill max
    public int GetIdBillMax()
    {
      try
      {
        string query = "select MAX(id) from Bill";
        int rerult = (int)DataProvider.Instance.ExecuteScalar(query);
        return rerult;
      }
      catch (Exception)
      {

        return 0;
      }
      
    }

    // Thêm
    public bool Insert(BillDTO bill)
    {
      string query = "exec InsertBill @id , @idAdmin , @idDocGia , @soLuong , @dateCheckOut";

      int data = DataProvider.Instance.ExecuteNonQuery(query, new object[]
                  { bill.id, bill.idAdmin, bill.idDocGia, bill.soLuong, bill.dateCheckOut });
      return data > 0;
    }

    // Sửa
    public bool Update(BillDTO DTO)
    {
      string query = string.Format("exec UpdateBill @id ");
      int result = DataProvider.Instance.ExecuteNonQuery(query, new object[]
                  {DTO.id });
      return result > 0;
    }

    // Xóa
    public bool Delete(int id)
    {
      string query = string.Format("delete from Bill where id = {0}", id);
      int result = DataProvider.Instance.ExecuteNonQuery(query);
      return result > 0;
    }

    //  Tìm kiếm theo id bill
    public List<BillDTO> SearchByIDBill(int id)
    {
      List<BillDTO> list = new List<BillDTO>();

      string query = string.Format("select * from Bill where id = {0}", id);
      DataTable data = DataProvider.Instance.ExecuteQuery(query);

      foreach (DataRow item in data.Rows)
      {
        BillDTO type = new BillDTO(item);

        list.Add(type);
      }

      return list;
    }

    //  Tìm kiếm bill chưa trả
    public List<BillDTO> SearchBillChuaTraByIdDocGia(string id)
    {
      List<BillDTO> list = new List<BillDTO>();

      string query = string.Format("select * from Bill where idDocGia = N'{0}' and status is null", id);
      DataTable data = DataProvider.Instance.ExecuteQuery(query);

      foreach (DataRow item in data.Rows)
      {
        BillDTO type = new BillDTO(item);

        list.Add(type);
      }

      return list;
    }

    //  Tìm kiếm theo id đọc giả
    public List<BillDTO> SearchByIDDocGia(string id)
    {
      List<BillDTO> list = new List<BillDTO>();

      string query = string.Format("select * from Bill where idDocGia like N'%{0}%'", id.ToString());
      DataTable data = DataProvider.Instance.ExecuteQuery(query);

      foreach (DataRow item in data.Rows)
      {
        BillDTO type = new BillDTO(item);

        list.Add(type);
      }

      return list;
    }

    //  Get số lượng sách mượn của đọc giả
    public int GetSoLuongSachMuon(string idDocGia)
    {
      try
      {
        string query = string.Format("select SUM(ConLai) from Bill where idDocGia = N'{0}'", idDocGia);
        int result = (int)DataProvider.Instance.ExecuteScalar(query);

        return result;
      }
      catch (Exception)
      {

        return 0;
      }
      
    }

    // Lấy tổng số sách mượn
    public int GetAmountSachMuon()
    {

      try
      {
        string query = string.Format("select SUM(ConLai) from Bill ");
        int result = (int)DataProvider.Instance.ExecuteScalar(query);

        return result;
      }
      catch (Exception)
      {
        return 0;
      }
    }

    // Lấy số sách mượn quá hạn
    public int GetAmountSachMuonQuaHan()
    {

      try
      {
        string query = string.Format("select SUM(ConLai) from Bill where dateCheckOut < GETDATE() ");
        int result = (int)DataProvider.Instance.ExecuteScalar(query);

        return result;
      }
      catch (Exception)
      {
        return 0;
      }
    }

    // Reprot sách mượn
    public List<BillDTO> GetListReportSachMuon(DateTime from, DateTime to)
    {
      List<BillDTO> list = new List<BillDTO>();
      string query = "exec GetListReportSachMuon @from , @to ";

      DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[]
                  { from, to });

      foreach (DataRow item in data.Rows)
      {
        BillDTO bill = new BillDTO(item);

        list.Add(bill);
      }

      return list;
    }

    // Get amount report sách mượn
    public int GetAmountReportSachMuon(DateTime from, DateTime to)
    {
      try
      {
        string query = "exec GetAmountReportSachMuon @from , @to ";
        int rerult = (int)DataProvider.Instance.ExecuteScalar(query, new object[]{ from, to });
        return rerult;
      }
      catch (Exception)
      {
        return 0;
      }
    }

    // lấy số lần mượn sách
    public int GetAmountMuonSach()
    {
      string query = "select COUNT(id) from Bill";
      int data = (int)DataProvider.Instance.ExecuteScalar(query);
      return data;
    }



  }
}
