using QuanLyThuVien.DAL;
using QuanLyThuVien.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVien.BUS
{
  class BillBUS
  {
    BillDAL billDAL = new BillDAL();

    // Lấy danh sách phiếu mượn
    public List<BillDTO> GetListPhieuMuon()
    {
      return billDAL.GetListPhieuMuon();
    }

    // Lấy danh sách phiếu mượn chưa trả
    public List<BillDTO> GetListPhieuMuonChuaTra()
    {
      return billDAL.GetListPhieuMuonChuaTra();
    }

    public List<string> GetListMaDocGiaByBillChuaTra()
    {
      return billDAL.GetListMaDocGiaByBillChuaTra();
    }
    // Lấy id bill max
    public int GetIdBillMax()
    {
      return billDAL.GetIdBillMax();
    }

    // Thêm
    public bool Insert(BillDTO bill)
    {
      return billDAL.Insert(bill);
    }

    // Sửa
    public bool Update(BillDTO DTO)
    {
      return billDAL.Update(DTO);
    }

    // Xóa
    public bool Delete(int id)
    {
      return billDAL.Delete(id);

    }

    //  Tìm kiếm theo id bill
    public List<BillDTO> SearchByIDBill(int id)
    {
      return billDAL.SearchByIDBill(id);
    }

    //  Tìm kiếm bill chưa trả
    public List<BillDTO> SearchBillChuaTraByIdDocGia(string id)
    {
      return billDAL.SearchBillChuaTraByIdDocGia(id);
    }

    //  Tìm kiếm theo id đọc giả
    public List<BillDTO> SearchByIDDocGia(string id)
    {
      return billDAL.SearchByIDDocGia(id);
    }

    //  Get số lượng sách mượn của đọc giả
    public int GetSoLuongSachMuon(string idDocGia)
    {
      return billDAL.GetSoLuongSachMuon(idDocGia);
    }

    // Lấy tổng số sách mượn
    public int GetAmountSachMuon()
    {
      return billDAL.GetAmountSachMuon();
    }

    // Lấy số sách mượn quá hạn
    public int GetAmountSachMuonQuaHan()
    {
      return billDAL.GetAmountSachMuonQuaHan();
    }

    // Reprot sách mượn
    public List<BillDTO> GetListReportSachMuon(DateTime from, DateTime to)
    {
      return billDAL.GetListReportSachMuon(from, to);
    }

    // Get amount report sách mượn
    public int GetAmountReportSachMuon(DateTime from, DateTime to)
    {
      return billDAL.GetAmountReportSachMuon(from, to);
    }

    // lấy số lần mượn sách
    public int GetAmountMuonSach()
    {
      return billDAL.GetAmountMuonSach();
    }


  }

}
