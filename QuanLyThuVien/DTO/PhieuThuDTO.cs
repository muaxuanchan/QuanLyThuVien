using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVien.DTO
{
  class PhieuThuDTO
  {
    public int id { get; set; }
    public int idAdmin { get; set; }
    public int idInfor { get; set; }
    public double tienThu { get; set; }
    public DateTime ngayTaoPhieu { get; set; }

    public PhieuThuDTO()
    {
      id = 0;
      idAdmin = 0;
      idInfor = 0;
      tienThu = 0;
      ngayTaoPhieu = DateTime.Now;
    }

    public PhieuThuDTO(DataRow item)
    {
      id = (int)item["id"];
      idAdmin = (int)item["idAdmin"];
      idInfor = (int)item["idInfor"];
      tienThu = Convert.ToDouble(item["countTienThu"]);
      ngayTaoPhieu = (DateTime)item["ngayTaoPhieuThu"];
    }
  }
}
