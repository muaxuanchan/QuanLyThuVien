using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVien.DTO
{
  class NoiQuyDTO
  {
    public int id { get; set; }

    public int hanDungThe { get; set; }

    public int giaHanThe { get; set; }

    public int muonToiDa { get; set; }

    public int thoiGianMuon { get; set; }

    public int tuoiMuonSach { get; set; }

    public double tienPhat { get; set; }

    public NoiQuyDTO()
    {
      id = 0;
      hanDungThe = 0;
      giaHanThe = 0;
      muonToiDa = 0;
      thoiGianMuon = 0;
      tuoiMuonSach = 0;
      tienPhat = 0;
    }

    public NoiQuyDTO(DataRow item)
    {
      id = (int)item["id"];
      hanDungThe = (int)item["hanDungThe"];
      giaHanThe = (int)item["giaHanThe"];
      muonToiDa = (int)item["muonToiDa"];
      thoiGianMuon = (int)item["thoiGianMuon"];
      tuoiMuonSach = (int)item["tuoiMuonSach"];
      tienPhat = (double)item["tienPhat"];
    }
  }
}
