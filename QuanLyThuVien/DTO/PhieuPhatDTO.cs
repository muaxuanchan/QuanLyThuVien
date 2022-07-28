using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVien.DTO
{
  class PhieuPhatDTO
  {
    public int id { get; set; }
    public int idAdmin { get; set; }
    public int idInfor { get; set; }
    public double tienPhat { get; set; }
    public DateTime ngayTaoPhieu { get; set; }

    public PhieuPhatDTO()
    {
      id = 0;
      idAdmin = 0;
      idInfor = 0;
      tienPhat = 0;
      ngayTaoPhieu = DateTime.Now;
    }

    public PhieuPhatDTO(DataRow item)
    {
      id = (int)item["id"];
      idAdmin = (int)item["idAdmin"];
      idInfor = (int)item["idInfor"];
      tienPhat = Convert.ToDouble(item["countTienPhat"]);
      ngayTaoPhieu = (DateTime)item["ngayTaoPhieuPhat"];
    }

  }
}
