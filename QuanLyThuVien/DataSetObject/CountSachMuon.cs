using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVien.DataSetObject
{
  class CountSachMuon
  {
    public string id { get; set; }
    public int TongMuon { get; set; }

    public CountSachMuon(DataRow item)
    {
      id = item["id"].ToString();
      TongMuon = (int)item["TongMuon"];
    }
  }
}
