using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVien.DTO
{
  class BillInforDTO
  {
    public int id { get; set; }
    
    public int idBill { get; set; }
    
    public string idMaSach { get; set; }
    
    public DateTime? dateReturn { get; set; }
    
    public string status { get; set; }
    
    public string note { get; set; }

    public string phieuPhat { get; set; }

    public BillInforDTO()
    {
      this.id = 0;
      this.idBill = 0;
      this.idMaSach = "";
      this.dateReturn = DateTime.Now;
      this.status = "";
      this.note = "";
      this.phieuPhat = "";
    }

    public BillInforDTO(DataRow item)
    {
      this.id = (int)item["id"];
      this.idBill = (int)item["idBill"];
      this.idMaSach = item["idMaSach"].ToString();
      if (!string.IsNullOrEmpty(item["dateReturn"].ToString()))
      {
        this.dateReturn = (DateTime)item["dateReturn"];
      }
      else
      {
        this.dateReturn = null;
      }
      
      this.status = item["status"].ToString();
      this.note = item["note"].ToString();
      this.phieuPhat = item["phieuPhat"].ToString();
    }
  }
}
