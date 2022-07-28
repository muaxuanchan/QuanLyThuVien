using QuanLyThuVien.DAL;
using QuanLyThuVien.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVien.BUS
{
  class NoiQuyBUS
  {
    NoiQuyDAL noiQuyDAL = new NoiQuyDAL();

    public List<NoiQuyDTO> GetListNoiQuy()
    {
      return noiQuyDAL.GetListNoiQuy();
    }

    // Update
    public bool Update(NoiQuyDTO DTO)
    {
      return noiQuyDAL.Update(DTO);
    }
  }
}
