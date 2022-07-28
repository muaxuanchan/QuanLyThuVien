using QuanLyThuVien.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVien.DAL
{
  class NoiQuyDAL
  {
    //   Lấy danh sách nội qui
    public List<NoiQuyDTO> GetListNoiQuy()
    {
      List<NoiQuyDTO> listNQ = new List<NoiQuyDTO>();
      DataTable data = DataProvider.Instance.ExecuteQuery("exec GetListNoiQuy");

      foreach (DataRow item in data.Rows)
      {
        NoiQuyDTO nq = new NoiQuyDTO(item);

        listNQ.Add(nq);
      }

      return listNQ;
    }

    // Update
    public bool Update(NoiQuyDTO DTO)
    {
      string query = string.Format("exec UpdateNoiQuy @id , @hanDungThe , @giaHanThe , @muonToiDa , @thoiGianMuon , @tuoiMuonSach , @tienPhat ");
      int result = DataProvider.Instance.ExecuteNonQuery(query, new object[]
                  { DTO.id, DTO.hanDungThe, DTO.giaHanThe, DTO.muonToiDa, DTO.thoiGianMuon, DTO.tuoiMuonSach, DTO.tienPhat});
      return result > 0;
    }
  }
}
