using QuanLyThuVien.DAL;
using QuanLyThuVien.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVien.BUS
{
  class LoaiSachBUS
  {
    LoaiSachDAL loaiSachDAL = new LoaiSachDAL();

    //  Lấy danh sách
    public List<LoaiSachDTO> GetListLoaiSach()
    {
      return loaiSachDAL.GetListLoaiSach();
    }

    //  Thêm
    public bool Insert(LoaiSachDTO lsDTO)
    {
      return loaiSachDAL.Insert(lsDTO);
    }

    //  Sửa
    public bool Update(string name, string id)
    {
      return loaiSachDAL.Update(name, id);
    }

    // Xóa
    public bool Delete(string id)
    {
      return loaiSachDAL.Delete(id);
    }

    //  Tìm kiếm theo mã
    public List<LoaiSachDTO> SearchByID(string id)
    {
      return loaiSachDAL.SearchByID(id);
    }

    //  Tìm kiếm theo tên
    public List<LoaiSachDTO> SearchByName(string name)
    {
      return loaiSachDAL.SearchByName(name);
    }

    //  Lấy id max
    public string GetIdMaxLoaiSach()
    {
      return loaiSachDAL.GetIdMaxLoaiSach();
    }

  }
}
