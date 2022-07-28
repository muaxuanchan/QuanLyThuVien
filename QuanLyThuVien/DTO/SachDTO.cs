using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVien.DTO
{
  class SachDTO
  {
    public string id { get; set; }
    public string name { get; set; }
    public string idCategorySach { get; set; }
    public string idTacGia { get; set; }
    public string idNXB { get; set; }
    public double money { get; set; }
    public int soLuong { get; set; }
    public int conLai { get; set; }

    public SachDTO()
    {
      id = "";
      name = "";
      idCategorySach = "";
      idTacGia = "";
      idNXB = "";
      money = 0;
      soLuong = 0;
      conLai = 0;
    }

    public SachDTO(DataRow item)
    {
      this.id = item["id"].ToString();
      this.name = item["name"].ToString();
      this.idCategorySach = item["idCategorySach"].ToString();
      this.idTacGia = item["idTacGia"].ToString();
      this.idNXB = item["idNXB"].ToString();
      this.money = Convert.ToDouble(item["money"]);
      this.soLuong = (int)item["soLuong"];
      this.conLai = (int)item["conLai"];
    }

  }
}
