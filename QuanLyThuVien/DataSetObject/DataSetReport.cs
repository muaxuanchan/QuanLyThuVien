using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVien.DataSetObject
{
  public class DataSetReport
  {
    public int id { get; set; }
    public int idBill { get; set; }
    public string idDocGia { get; set; }
    public string idMaSach { get; set; }
    public DateTime dateCheckIn { get; set; }
    public DateTime dateCheckOut { get; set; }
    public string dateReturn { get; set; }
    public string status { get; set; }

    public DataSetReport(DataRow item)
    {
      id = (int)item["id"];
      idBill = (int)item["idBill"];
      idDocGia = item["idDocGia"].ToString();
      idMaSach = item["idMaSach"].ToString();
      dateCheckIn = (DateTime)item["dateCheckIn"];
      dateCheckOut = (DateTime)item["dateCheckOut"];
      
      try
      {
        dateReturn = item["dateReturn"].ToString();
      }
      catch (Exception)
      {

        dateReturn = DateTime.Now.ToString();
      }

      try
      {
        status = item["status"].ToString();
      }
      catch (Exception)
      {

        status = "";
      }
      
    }
  }
}
