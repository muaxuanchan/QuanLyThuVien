using QuanLyThuVien.BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThuVien.FormPhieuThu
{
  public partial class fPhieuThu : Form
  {
    PhieuThuBUS phieuThuBUS = new PhieuThuBUS();

    public fPhieuThu()
    {
      InitializeComponent();
      Load();
    }

    private new void Load()
    {
      txbSearch.Text = "";
      rdbIdAdmin.Checked = true;

      GetListPhieuThu();
      RenameHeaderDTGV();
    }

    private void RenameHeaderDTGV()
    {
      dtgvListPhieuThu.Columns[0].HeaderText = "ID";
      dtgvListPhieuThu.Columns[1].HeaderText = "Mã admin";
      dtgvListPhieuThu.Columns[2].HeaderText = "Mã thông tin độc giả";
      dtgvListPhieuThu.Columns[3].HeaderText = "Tiền thu";
      dtgvListPhieuThu.Columns[4].HeaderText = "Ngày tạo phiếu thu";
      dtgvListPhieuThu.Columns[4].DefaultCellStyle.Format = "dd/MM/yyyy";
    }

    private void GetListPhieuThu()
    {
      dtgvListPhieuThu.DataSource = phieuThuBUS.GetListPhieuThu();
    }

    //  Làm mới
    private void btnLoad_Click(object sender, EventArgs e)
    {
      Load();
    }
    
    //  Tọa phiếu thu
    private void btnAddPhieuThu_Click(object sender, EventArgs e)
    {
      fAddPhieuThu f = new fAddPhieuThu();
      f.ShowDialog();
    }

    //  TÌm kiếm
    private void btnSearch_Click(object sender, EventArgs e)
    {
      int id = int.Parse(txbSearch.Text);

      if (rdbIdAdmin.Checked is true)
      {
        dtgvListPhieuThu.DataSource = phieuThuBUS.SearchByidAdmin(id);
      }
      else if (rdbIdInfor.Checked is true)
      {
        dtgvListPhieuThu.DataSource = phieuThuBUS.SearchByidInfor(id);
      }
    }
  }
}
