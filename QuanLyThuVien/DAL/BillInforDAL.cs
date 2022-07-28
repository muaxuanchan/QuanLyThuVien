using QuanLyThuVien.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVien.DAL
{
  class BillInforDAL
  {
    // Lấy danh sách phiếu mượn
    public List<BillInforDTO> GetListChiTietPhieuMuon()
    {
      List<BillInforDTO> list = new List<BillInforDTO>();
      DataTable data = DataProvider.Instance.ExecuteQuery("select * from BillInfor");

      foreach (DataRow item in data.Rows)
      {
        BillInforDTO bi = new BillInforDTO(item);

        list.Add(bi);
      }

      return list;
    }

    // Lấy danh sách phiếu mượn đã trả
    public List<BillInforDTO> GetListChiTietPhieuMuonReturn()
    {
      List<BillInforDTO> list = new List<BillInforDTO>();
      DataTable data = DataProvider.Instance.ExecuteQuery("select * from BillInfor where status != N'Chưa trả'");

      foreach (DataRow item in data.Rows)
      {
        BillInforDTO bi = new BillInforDTO(item);

        list.Add(bi);
      }

      return list;
    }

    // Thêm
    public bool Insert(BillInforDTO bi)
    {
      string query = "exec InsertBillInfor @idBill , @idMaSach";

      int data = DataProvider.Instance.ExecuteNonQuery(query, new object[]
                  { bi.idBill, bi.idMaSach });
      return data > 0;
    }

    // Sửa
    public bool Update(BillInforDTO DTO)
    {
      string query = string.Format("exec UpdateBillinfor @id , @status , @note");
      int result = DataProvider.Instance.ExecuteNonQuery(query, new object[]
                  {DTO.id, DTO.status, DTO.note});
      return result > 0;
    }

    public bool UpdatePhieuPhat(int id)
    {
      string query = $"update BillInfor set phieuPhat = N'Đã tạo' where id = {id}";
      int result = DataProvider.Instance.ExecuteNonQuery(query);
      return result > 0;
    }

    //  Get list follow by idbill
    public List<BillInforDTO> GetListByIDBill(int idBill)
    {
      List<BillInforDTO> list = new List<BillInforDTO>();

      string query = string.Format("select * from BillInfor where idBill = {0}", idBill);
      DataTable data = DataProvider.Instance.ExecuteQuery(query);

      foreach (DataRow item in data.Rows)
      {
        BillInforDTO type = new BillInforDTO(item);

        list.Add(type);
      }

      return list;
    }

    //  Get amount bill infor
    public int GetAmountBillInforByIDBill(int idBill)
    {

      string query = string.Format("select COUNT(*) from BillInfor where idBill = {0} and status = N'Chưa trả'", idBill);
      int result = (int)DataProvider.Instance.ExecuteScalar(query);
      return result;
    }

    // Lấy số sách trả muộn
    public int GetAmountSachTraMuon()
    {
      string query = string.Format("select COUNT(id) from BillInfor where status = N'Trả muộn' ");
      int result = (int)DataProvider.Instance.ExecuteScalar(query);
      return result;
    }

    // get list report sách trả
    public List<BillInforDTO> GetListReportSachTra(DateTime from, DateTime to)
    {
      List<BillInforDTO> list = new List<BillInforDTO>();

      string query = "exec GetListReportSachTra @from , @to";

      DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { from, to});

      foreach (DataRow item in data.Rows)
      {
        BillInforDTO bi = new BillInforDTO(item);

        list.Add(bi);
      }

      return list;
    }

    // get amount report sách trả
    public int GetAmountReportSachTra(DateTime from, DateTime to)
    {
      string query = "exec GetAmountReportSachTra @from , @to ";
      int data = (int)DataProvider.Instance.ExecuteScalar(query, new object[] { from , to });
      return data;
    }


    // get list report chưa trả
    public List<BillInforDTO> GetListReportSachChuaTra(DateTime from, DateTime to)
    {
      List<BillInforDTO> list = new List<BillInforDTO>();

      string query = "exec GetListReportChuaTra @from , @to ";

      DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { from, to });

      foreach (DataRow item in data.Rows)
      {
        BillInforDTO bi = new BillInforDTO(item);

        list.Add(bi);
      }

      return list;
    }

    // get amount report sách chưa trả
    public int GetAmountReportSachChuaTra(DateTime from, DateTime to)
    {
      string query = "exec GetAmountReportChuaTra @from , @to ";
      int data = (int)DataProvider.Instance.ExecuteScalar(query, new object[] { from, to });
      return data;
    }

    // get list report sách trả muộn
    public List<BillInforDTO> GetListReportSachTraMuon(DateTime from, DateTime to)
    {
      List<BillInforDTO> list = new List<BillInforDTO>();

      string query = "exec GetListReportTraMuon @from , @to  ";

      DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { from, to });

      foreach (DataRow item in data.Rows)
      {
        BillInforDTO bi = new BillInforDTO(item);

        list.Add(bi);
      }

      return list;
    }

    // get amount report sách trả muộn
    public int GetAmountReportSachTraMuon(DateTime from, DateTime to)
    {
      string query = "exec GetAmountReportTraMuon @from , @to  ";
      int data = (int)DataProvider.Instance.ExecuteScalar(query, new object[] { from, to });
      return data;
    }

    // get list report sách quá hạn
    public List<BillInforDTO> GetListReportSachQuaHan(DateTime from, DateTime to)
    {
      List<BillInforDTO> list = new List<BillInforDTO>();

      string query = "exec GetListReportQuaHan @from , @to  ";

      DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { from, to });

      foreach (DataRow item in data.Rows)
      {
        BillInforDTO bi = new BillInforDTO(item);

        list.Add(bi);
      }

      return list;
    }

    // get amount report sách quá hạn
    public int GetAmountReportSachQuaHan(DateTime from, DateTime to)
    {
      string query = "exec GetAmountReportQuaHan @from , @to  ";
      int data = (int)DataProvider.Instance.ExecuteScalar(query, new object[] { from, to });
      return data;
    }

    //  Get list đọc giả mượn sách quá hạn theo mã đọc giả
    public List<BillInforDTO> ShowListBillInforTraMuonOrMatSachByIdDocGia(string id)
    {
      List<BillInforDTO> list = new List<BillInforDTO>();
      string query = "exec ShowListBillInforTraMuonOrMatSachByIdDocGia @idDocGia";
      DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[]
        { id});

      foreach (DataRow item in data.Rows)
      {
        BillInforDTO bi = new BillInforDTO(item);

        list.Add(bi);
      }

      return list;
    }

  }
}
