using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVien.DTO
{
  class LoaiSachDTO
  {
    public string id { get; set; }

    public string name { get; set; }

    public LoaiSachDTO()
    {
      this.id = "";
      this.name = "";
    }

    public LoaiSachDTO(DataRow item)
    {
      this.id = item["id"].ToString();
      this.name = item["name"].ToString();
    }
  }
}
