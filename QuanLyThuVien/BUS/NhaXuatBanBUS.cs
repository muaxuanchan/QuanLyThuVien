using QuanLyThuVien.DAL;
using QuanLyThuVien.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVien.BUS
{
  class NhaXuatBanBUS
  {
    NhaXuatBanDAL nhaXuatBanDAL = new NhaXuatBanDAL();

    //  Lấy danh sách
    public List<NhaXuatBanDTO> GetListNhaXuatBan()
    {
      return nhaXuatBanDAL.GetListNhaXuatBan();
    }

    //  Thêm
    public bool Insert(NhaXuatBanDTO DTO)
    {
      return nhaXuatBanDAL.Insert(DTO);
    }

    //  Sửa
    public bool Update(string name, string id)
    {
      return nhaXuatBanDAL.Update(name, id);
    }

    // Xóa
    public bool Delete(string id)
    {
      return nhaXuatBanDAL.Delete(id);
    }

    //  Tìm kiếm theo mã
    public List<NhaXuatBanDTO> SearchByID(string id)
    {
      return nhaXuatBanDAL.SearchByID(id);
    }

    //  Tìm kiếm theo tên
    public List<NhaXuatBanDTO> SearchByName(string name)
    {
      return nhaXuatBanDAL.SearchByName(name);
    }

    //  Lấy id max
    public string GetIdMaxNhaXuatBan()
    {
      return nhaXuatBanDAL.GetIdMaxNhaXuatBan();

    }

  }
}
