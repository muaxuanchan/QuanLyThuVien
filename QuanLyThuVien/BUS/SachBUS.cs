using QuanLyThuVien.DAL;
using QuanLyThuVien.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVien.BUS
{
  class SachBUS
  {
    SachDAL sachDAL = new SachDAL();

    // Lấy list sách
    public List<SachDTO> GetListSach()
    {
      return sachDAL.GetListSach();
    }

    // Lấy list sách với số sách còn lại khác 0
    public List<SachDTO> GetListSachDifferentZero()
    {
      return sachDAL.GetListSachDifferentZero();
    }

    // Thêm
    public bool Insert(SachDTO DTO)
    {
      return sachDAL.Insert(DTO);
    }

    // Test Import file excel to sql
    public bool TestInsert(SachDTO DTO)
    {
      return sachDAL.TestInsert(DTO);
    }

    #region Update data sách
    
    //  Sửa
    public bool Update(SachDTO DTO)
    {
      return sachDAL.Update(DTO);
    }

    // Update sách theo add BillInfor
    public bool UpdateByAddBillInfor(string id)
    {
      return sachDAL.UpdateByAddBillInfor(id);
    }

    // Update sách by delete BillInfor
    public bool UpdateSachByReturnBillInfor(string id)
    {
      return sachDAL.UpdateSachByReturnBillInfor(id);
    }

    // Update sách if return mất sách
    public bool UpdateSachReturnMatSach(string id)
    {
      return sachDAL.UpdateSachReturnMatSach(id);
    }
    #endregion



    // Xóa
    public bool Delete(string id)
    {
      return sachDAL.Delete(id);
    }

    public SachDTO GetSachByID(string id)
    {
      return sachDAL.GetSachByID(id);
    }

    //  Tìm kiếm theo id
    public List<SachDTO> SearchByID(string id)
    {
      return sachDAL.SearchByID(id);
    }

    //  Tìm kiếm theo tên
    public List<SachDTO> SearchByName(string name)
    {
      return sachDAL.SearchByName(name);
    }

    // Lấy tổng số sách
    public int GetAmountSach()
    {
      return sachDAL.GetAmountSach();
    }

    // Lấy tổng số sách còn lại
    public int GetAmountSachConLai()
    {
      return sachDAL.GetAmountSachConLai();

    }

    //  Lấy id max
    public string GetIdMaxSach()
    {
      return sachDAL.GetIdMaxSach();
    }

    //  Test get id max
    public string TestGetIdMaxSach()
    {
      return sachDAL.TestGetIdMaxSach();
    }

  }
}
