using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVien.DTO
{
  class LoaiDocGiaDTO
  {
    public string id { get; set; }

    public string name { get; set; }

    public LoaiDocGiaDTO()
    {
      this.id = "";
      this.name = "";
    }

    public LoaiDocGiaDTO(DataRow item)
    {
      this.id = item["id"].ToString();
      this.name = item["name"].ToString();
    }
  }
}
