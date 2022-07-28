using QuanLyThuVien.DAL;
using QuanLyThuVien.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVien.BUS
{
  class InforDocGiaBUS
  {
    InforDocGiaDAL inforDocGiaDAL = new InforDocGiaDAL();

    public List<InforDocGiaDTO> ShowList()
    {
      return inforDocGiaDAL.ShowList();
    }

    public List<InforDocGiaDTO> SearchByMaDocGia(string id)
    {
      return inforDocGiaDAL.SearchByMaDocGia(id);
    }

    public List<InforDocGiaDTO> GetListMaDocGiaQuaHan()
    {
      return inforDocGiaDAL.GetListMaDocGiaQuaHan();
    }

    public List<InforDocGiaDTO> GetListMaDocGiaTraMuonOrMatSach()
    {
      return inforDocGiaDAL.GetListMaDocGiaTraMuonOrMatSach();
    }

    public List<InforDocGiaDTO> SearchByID(string id)
    {
      return inforDocGiaDAL.SearchByID(id);
    }

    public bool UpdateTienPhatByPhieuThu(InforDocGiaDTO obj)
    {
      return inforDocGiaDAL.UpdateTienPhatByPhieuThu(obj);
    }

    public bool UpdateTienPhatByPhieuPhat(InforDocGiaDTO obj)
    {
      return inforDocGiaDAL.UpdateTienPhatByPhieuPhat(obj);
    }

    public bool UpdateInforDocGia(string idDocGia)
    {
      return inforDocGiaDAL.UpdateInforDocGia(idDocGia);
    }
  }
}
