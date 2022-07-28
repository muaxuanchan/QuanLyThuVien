using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVien.DTO
{
  class NhaXuatBanDTO
  {
    public string id { get; set; }

    public string name { get; set; }

    public NhaXuatBanDTO()
    {
      this.id = "";
      this.name = "";
    }

    public NhaXuatBanDTO(DataRow item)
    {
      this.id = item["id"].ToString();
      this.name = item["name"].ToString();
    }
  }
}
