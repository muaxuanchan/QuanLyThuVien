using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVien.DTO
{
  class InforDocGiaDTO
  {
    public int id { get; set; }
    public string idDocGia { get; set; }
    public int countSachMuon { get; set; }
    public int countSachQuaHan { get; set; }
    public double countTienPhat { get; set; }

    public InforDocGiaDTO()
    {
      id = 0;
      idDocGia = "";
      countSachMuon = 0;
      countSachQuaHan = 0;
      countTienPhat = 0;
    }

    public InforDocGiaDTO(DataRow item)
    {
      id = (int)item["id"];
      idDocGia = item["idDocGia"].ToString();
      countSachMuon = (int)item["countSachMuon"];
      countSachQuaHan = (int)item["countSachQuaHan"];
      countTienPhat = (double)item["countTienPhat"];
      
    }
  }
}
