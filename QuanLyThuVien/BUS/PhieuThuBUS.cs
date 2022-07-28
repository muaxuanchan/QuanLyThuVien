using QuanLyThuVien.DAL;
using QuanLyThuVien.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVien.BUS
{
  class PhieuThuBUS
  {
    PhieuThuDAL phieuThuDAL = new PhieuThuDAL();

    public List<PhieuThuDTO> GetListPhieuThu()
    {
      return phieuThuDAL.GetListPhieuThu();
    }

    public bool Insert(PhieuThuDTO obj)
    {
      return phieuThuDAL.Insert(obj);
    }

    public List<PhieuThuDTO> SearchByidAdmin(int id)
    {
      return phieuThuDAL.SearchByidAdmin(id);
    }

    public List<PhieuThuDTO> SearchByidInfor(int id)
    {
      return phieuThuDAL.SearchByidInfor(id);
    }
  }
}
