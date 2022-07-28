using QuanLyThuVien.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVien.DAL
{
  class DocGiaDAL
  {
    // Lấy danh sách đọc giả
    public List<DocGiaDTO> GetListDocGia()
    {
      List<DocGiaDTO> listDG = new List<DocGiaDTO>();
      DataTable data = DataProvider.Instance.ExecuteQuery("select * from DocGia");

      foreach (DataRow item in data.Rows)
      {
        DocGiaDTO dg = new DocGiaDTO(item);

        listDG.Add(dg);
      }

      return listDG;
    }

    // Thêm
    public bool Insert(DocGiaDTO docGiaDTO)
    {
      string query = "exec InsertDocGia @id , @name , @idCategoryDG , @ngaySinh , @phoneNumber , @diaChi , @note ";

      int data = DataProvider.Instance.ExecuteNonQuery(query, new object[]
                  { docGiaDTO.id, docGiaDTO.name, docGiaDTO.idCategoryDG, docGiaDTO.ngaySinh, docGiaDTO.phoneNumber, docGiaDTO.diaChi, docGiaDTO.note});
      return data > 0;
    }

    public bool TestInsert(DocGiaDTO docGiaDTO)
    {
      string query = "exec InsertTestTableDocGia @id , @name , @idCategoryDG , @ngaySinh ";

      int data = DataProvider.Instance.ExecuteNonQuery(query, new object[]
                  { docGiaDTO.id, docGiaDTO.name, docGiaDTO.idCategoryDG, docGiaDTO.ngaySinh });
      return data > 0;
    }

    //  Sửa
    public bool Update(DocGiaDTO DTO)
    {
      string query = string.Format("exec UpdateDocGia @id , @name , @idCategory , @ngaySinh , @phoneNumber , @diaChi , @note ");
      int result = DataProvider.Instance.ExecuteNonQuery(query, new object[]
                  { DTO.id, DTO.name, DTO.idCategoryDG, DTO.ngaySinh, DTO.phoneNumber, DTO.diaChi, DTO.note});
      return result > 0;
    }

    // Xóa
    public bool Delete(string id)
    {
      string query = string.Format("exec DeleteDocGia @id ");
      int result = DataProvider.Instance.ExecuteNonQuery(query, new object[]
        { id});
      return result > 0;
    }

    //  Tìm kiếm theo id
    public List<DocGiaDTO> SearchByID(string id)
    {
      List<DocGiaDTO> listDG = new List<DocGiaDTO>();

      string query = string.Format("select * from DocGia where id = N'{0}'", id);
      DataTable data = DataProvider.Instance.ExecuteQuery(query);

      foreach (DataRow item in data.Rows)
      {
        DocGiaDTO type = new DocGiaDTO(item);

        listDG.Add(type);
      }

      return listDG;
    }

    //  Tìm kiếm theo tên
    public List<DocGiaDTO> SearchByName(string name)
    {
      List<DocGiaDTO> listDG = new List<DocGiaDTO>();

      string query = string.Format("select * from DocGia where name like N'%{0}%'", name.ToString());
      DataTable data = DataProvider.Instance.ExecuteQuery(query);

      foreach (DataRow item in data.Rows)
      {
        DocGiaDTO type = new DocGiaDTO(item);

        listDG.Add(type);
      }

      return listDG;
    }

    // lấy số lượng đọc giả
    public int GetAmountDocGia()
    {
      string query = "select COUNT(id) from DocGia";
      int data = (int)DataProvider.Instance.ExecuteScalar(query);
      return data;
    }

    //  Lấy max id đọc giả
    public string GetIdMaxDocGia()
    {
      string query = "select MAX(id) from DocGia";

      string data = DataProvider.Instance.ExecuteScalar(query).ToString();

      return data;
    }

    public string TestGetIdMaxDocGia()
    {
      string query = "select MAX(id) from TestTableDocGia";

      string data = DataProvider.Instance.ExecuteScalar(query).ToString();

      return data;
    }

  }
}
