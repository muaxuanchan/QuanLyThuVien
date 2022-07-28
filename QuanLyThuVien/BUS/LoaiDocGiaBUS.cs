using QuanLyThuVien.DAL;
using QuanLyThuVien.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVien.BUS
{
  class LoaiDocGiaBUS
  {
    LoaiDocGiaDAL loaiDocGiaDAL = new LoaiDocGiaDAL();

    public List<LoaiDocGiaDTO> GetListTypeDocGia()
    {
      return loaiDocGiaDAL.GetListTypeDocGia();
    }

    //  Thêm
    public bool InsertLoaiDocGia(LoaiDocGiaDTO loaiDocGiaDTO)
    {
      return loaiDocGiaDAL.InsertLoaiDocGia(loaiDocGiaDTO);
    }

    // Sửa
    public bool Update(string name, string id)
    {
      return loaiDocGiaDAL.Update(name, id);
    }  

    // Xóa
    public bool DeleteLoaiDocGia(string id)
    {
      return loaiDocGiaDAL.DeleteLoaiDocGia(id);
    }

    //  Tìm kiếm theo mã
    public List<LoaiDocGiaDTO> SearchByID(string id)
    {
      return loaiDocGiaDAL.SearchByID(id);
    }

    //  Tìm kiếm theo tên
    public List<LoaiDocGiaDTO> SearchByName(string name)
    {
      return loaiDocGiaDAL.SearchByName(name);
    }

    //  lấy id max loại đọc giả
    public string GetIdMaxLoaiDocGia()
    {
      return loaiDocGiaDAL.GetIdMaxLoaiDocGia();
    }
  }
}
