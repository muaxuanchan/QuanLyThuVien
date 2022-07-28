using QuanLyThuVien.DAL;
using QuanLyThuVien.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVien.BUS
{
  class PhieuPhatBUS
  {
    PhieuPhatDAL phieuPhatDAL = new PhieuPhatDAL();

    public List<PhieuPhatDTO> GetListPhieuPhat()
    {
      return phieuPhatDAL.GetListPhieuPhat();
    }

    public bool Insert(PhieuPhatDTO obj)
    {
      return phieuPhatDAL.Insert(obj);
    }

    public List<PhieuPhatDTO> SearchByidAdmin(int id)
    {
      return phieuPhatDAL.SearchByidAdmin(id);
    }

    public List<PhieuPhatDTO> SearchByidInfor(int id)
    {
      return phieuPhatDAL.SearchByidInfor(id);
    }
  }
}
