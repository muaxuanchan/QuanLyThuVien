using QuanLyThuVien.DAL;
using QuanLyThuVien.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVien.BUS
{
  class TacGiaBUS
  {
    TacGiaDAL tacGiaDAL = new TacGiaDAL();

    //  Lấy danh sách
    public List<TacGiaDTO> GetListTacGia()
    {
      return tacGiaDAL.GetListTacGia();
    }

    //  Thêm
    public bool Insert(TacGiaDTO DTO)
    {
      return tacGiaDAL.Insert(DTO);
    }

    //  Sửa
    public bool Update(string name, string id)
    {
      return tacGiaDAL.Update(name, id);
    }

    // Xóa
    public bool Delete(string id)
    {
      return tacGiaDAL.Delete(id);
    }

    //  Tìm kiếm theo mã
    public List<TacGiaDTO> SearchByID(string id)
    {
      return tacGiaDAL.SearchByID(id);
    }

    //  Tìm kiếm theo tên
    public List<TacGiaDTO> SearchByName(string name)
    {
      return tacGiaDAL.SearchByName(name);
    }

    //  Lấy id max
    public string GetIdMaxTacGia()
    {
      return tacGiaDAL.GetIdMaxTacGia();

    }

  }
}
