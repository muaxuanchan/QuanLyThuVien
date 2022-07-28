using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVien.DTO
{
  class DocGiaDTO
  {
    
    public string id { get; set; }
    public string name { get; set; }
    public string idCategoryDG { get; set; }
    public DateTime ngaySinh { get; set; }
    public string phoneNumber { get; set; }
    public string diaChi { get; set; }
    public DateTime ngayLamThe  { get; set; }
    public DateTime ngayHetHan { get; set; }
    public string note { get; set; }

    public DocGiaDTO()
    {
      this.id = "";
      this.name = "";
      this.idCategoryDG = "";
      this.ngaySinh = DateTime.Now;
      this.diaChi = "";
      this.phoneNumber = "";
      this.ngayLamThe = DateTime.Now;
      this.ngayHetHan = DateTime.Now;
      this.note = "";
    }

    public DocGiaDTO(DataRow item)
    {
      this.id = item["id"].ToString();
      this.name = item["name"].ToString();
      this.idCategoryDG = item["idCategoryDG"].ToString();
      this.ngaySinh = (DateTime)item["ngaySinh"];
      this.phoneNumber = item["phoneNumber"].ToString();
      this.diaChi = item["diaChi"].ToString();
      this.ngayLamThe = (DateTime)item["ngayLamThe"];
      this.ngayHetHan = (DateTime)item["ngayHetHan"];
      this.note = item["note"].ToString();
    }
  }
}
