using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVien.DTO
{
  class BillDTO
  {
    public int id { get; set; }
    public int idAdmin { get; set; }
    public string idDocGia { get; set; }
    public int soLuong { get; set; }
    public int Conlai { get; set; }
    public DateTime dateCheckIn { get; set; }
    public DateTime dateCheckOut { get; set; }
    public string status { get; set; }

    public BillDTO()
    {
      this.id = 0;
      this.idAdmin = 0;
      this.idDocGia = "";
      this.soLuong = 0;
      this.Conlai = 0;
      this.dateCheckIn = DateTime.Now;
      this.dateCheckOut = DateTime.Now;
      this.status = "";
    }

    public BillDTO(DataRow item)
    {
      this.id = (int)item["id"];
      this.idAdmin = (int)item["idAdmin"];
      this.idDocGia = item["idDocGia"].ToString();
      this.soLuong = (int)item["soLuong"];
      this.Conlai = (int)item["ConLai"];
      this.dateCheckIn = (DateTime)item["dateCheckIn"];
      this.dateCheckOut = (DateTime)item["dateCheckOut"];
      this.status = item["status"].ToString();
    }
  }
}
