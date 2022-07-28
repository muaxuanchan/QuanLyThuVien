using QuanLyThuVien.BUS;
using QuanLyThuVien.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVien.Const
{
  class CommonConstants
  {
    private NoiQuyBUS noiQuyBUS = new NoiQuyBUS();
    private List<NoiQuyDTO> listNQ = new List<NoiQuyDTO>();

    private int id { get; set; }
    public int Id
    {
      get => id;
    }

    private int hanDungThe { get; set; }

    public int HanDungThe
    {
      get => hanDungThe;
    }

    private int giaHanThe { get; set; }
    public int GiaHanThe
    {
      get => giaHanThe;
    }
    private int muonToiDa { get; set; }
    public int MuonToiDa
    {
      get => muonToiDa;
    }
    private int thoiGianMuon { get; set; }
    public int ThoiGianMuon
    {
      get => thoiGianMuon;
    }
    private int tuoiMuonSach { get; set; }
    public int TuoiMuonSach
    {
      get => tuoiMuonSach;
    }

    private double tienPhat { get; set; }
    public double TienPhat
    {
      get => tienPhat;
    }
    public CommonConstants()
    {
      listNQ = noiQuyBUS.GetListNoiQuy();

      foreach (var item in listNQ)
      {
        id = item.id;
        hanDungThe = item.hanDungThe;
        giaHanThe = item.giaHanThe;
        muonToiDa = item.muonToiDa;
        thoiGianMuon = item.thoiGianMuon;
        tuoiMuonSach = item.tuoiMuonSach;
        tienPhat = item.tienPhat;
      }
    }
  }
}
