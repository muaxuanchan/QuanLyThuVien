using QuanLyThuVien.DAL;
using QuanLyThuVien.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVien.BUS
{
  class DocGiaBUS
  {
    DocGiaDAL docGiaDAL = new DocGiaDAL();

    public List<DocGiaDTO> GetListDocGia()
    {
      return docGiaDAL.GetListDocGia();
    }

    public bool Insert(DocGiaDTO docGiaDTO)
    {
      return docGiaDAL.Insert(docGiaDTO);
    }

    public bool TestInsert(DocGiaDTO docGiaDTO)
    {
      return docGiaDAL.TestInsert(docGiaDTO);
    }

    //  Sửa
    public bool Update(DocGiaDTO DTO)
    {
      return docGiaDAL.Update(DTO);
    }

    //  Xóa
    public bool Delete(string id)
    {
      return docGiaDAL.Delete(id);
    }

    //  Tìm kiếm theo id
    public List<DocGiaDTO> SearchByID(string id)
    {
      return docGiaDAL.SearchByID(id);
    }

    //  Tìm kiếm theo tên
    public List<DocGiaDTO> SearchByName(string name)
    {
      return docGiaDAL.SearchByName(name);
    }

    // lấy số lượng đọc giả
    public int GetAmountDocGia()
    {
      return docGiaDAL.GetAmountDocGia();
    }

    //  Lấy max id đọc giả
    public string GetIdMaxDocGia()
    {
      return docGiaDAL.GetIdMaxDocGia();
    }

    public string TestGetIdMaxDocGia()
    {
      return docGiaDAL.TestGetIdMaxDocGia();
    }

  }
}
