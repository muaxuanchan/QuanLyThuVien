using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVien.DTO
{
  class TacGiaDTO
  {
    public string id { get; set; }

    public string name { get; set; }

    public TacGiaDTO()
    {
      this.id = "";
      this.name = "";
    }

    public TacGiaDTO(DataRow item)
    {
      this.id = item["id"].ToString();
      this.name = item["name"].ToString();
    }
  }
}
