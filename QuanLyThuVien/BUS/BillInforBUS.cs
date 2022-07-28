using QuanLyThuVien.DAL;
using QuanLyThuVien.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVien.BUS
{
  class BillInforBUS
  {
    BillInforDAL billInforDAL = new BillInforDAL();

    // Lấy danh sách phiếu mượn
    public List<BillInforDTO> GetListChiTietPhieuMuon()
    {
      return billInforDAL.GetListChiTietPhieuMuon();
    }

    // Lấy danh sách phiếu mượn đã trả
    public List<BillInforDTO> GetListChiTietPhieuMuonReturn()
    {
      return billInforDAL.GetListChiTietPhieuMuonReturn();
    }

    // Thêm
    public bool Insert(BillInforDTO bi)
    {
      return billInforDAL.Insert(bi);
    }

    // Sửa
    public bool Update(BillInforDTO DTO)
    {
      return billInforDAL.Update(DTO);
    }

    public bool UpdatePhieuPhat(int id)
    {
      return billInforDAL.UpdatePhieuPhat(id);
    }

    //  Tìm kiếm theo idbill
    public List<BillInforDTO> GetListByIDBill(int idBill)
    {
      return billInforDAL.GetListByIDBill(idBill);
    }

    //  Get amount bill infor
    public int GetAmountBillInforByIDBill(int idBill)
    {
      return billInforDAL.GetAmountBillInforByIDBill(idBill);
    }

    // Lấy số sách trả muộn
    public int GetAmountSachTraMuon()
    {
      return billInforDAL.GetAmountSachTraMuon();
    }

    // get list report sách trả
    public List<BillInforDTO> GetListReportSachTra(DateTime from, DateTime to)
    {
      return billInforDAL.GetListReportSachTra(from, to);
    }

    // get amount report sách trả
    public int GetAmountReportSachTra(DateTime from, DateTime to)
    {
      return billInforDAL.GetAmountReportSachTra(from, to);
    }

    // get list report chưa trả
    public List<BillInforDTO> GetListReportSachChuaTra(DateTime from, DateTime to)
    {
      return billInforDAL.GetListReportSachChuaTra(from, to);
    }

    // get amount report sách chưa trả
    public int GetAmountReportSachChuaTra(DateTime from, DateTime to)
    {
      return billInforDAL.GetAmountReportSachChuaTra(from, to);
    }

    // get list report sách trả muộn
    public List<BillInforDTO> GetListReportSachTraMuon(DateTime from, DateTime to)
    {
      return billInforDAL.GetListReportSachTraMuon(from, to);
    }

    // get amount report sách trả muộn
    public int GetAmountReportSachTraMuon(DateTime from, DateTime to)
    {
      return billInforDAL.GetAmountReportSachTraMuon(from, to);
    }

    // get list report sách quá hạn
    public List<BillInforDTO> GetListReportSachQuaHan(DateTime from, DateTime to)
    {
      return billInforDAL.GetListReportSachQuaHan(from, to);
    }

    // get amount report sách quá hạn
    public int GetAmountReportSachQuaHan(DateTime from, DateTime to)
    {
      return billInforDAL.GetAmountReportSachQuaHan(from, to);
    }

    //  Get list đọc giả mượn sách quá hạn theo mã đọc giả
    public List<BillInforDTO> ShowListBillInforTraMuonOrMatSachByIdDocGia(string id)
    {
      return billInforDAL.ShowListBillInforTraMuonOrMatSachByIdDocGia(id);
    }

  }
}
