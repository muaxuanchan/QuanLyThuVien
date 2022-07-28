using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThuVien.DTO
{
  public class TaiKhoanDTO
  {
    public int id { get; set; }

    public string userName { get; set; }

    public string passWord { get; set; }

    public string displayName { get; set; }

    public string phoneNumber { get; set; }

    public int quyen { get; set; }

    public TaiKhoanDTO()
    {
      this.id = 0;
      this.userName = "";
      this.passWord = "";
      this.displayName = "";
      this.phoneNumber = "";
      this.quyen = 0;
    }

    public TaiKhoanDTO(DataRow item)
    {
      this.id = (int)item["id"];
      this.userName = item["userName"].ToString();
      this.passWord = item["passWord"].ToString();
      this.displayName = item["displayName"].ToString();
      this.phoneNumber = item["phoneNumber"].ToString();
      this.quyen = (int)item["quyen"];
    }

  }
}
