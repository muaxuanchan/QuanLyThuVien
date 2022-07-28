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
  public partial class fPhieuPhat : Form
  {
    PhieuPhatBUS phieuPhatBUS = new PhieuPhatBUS();

    public fPhieuPhat()
    {
      InitializeComponent();
      Load();
    }

    private new void Load()
    {
      txnSearch.Text = "";
      rdbIdAdmin.Checked = true;

      GetListPhieuPhat();
      RenameHeaderDTGV();
    }

    private void RenameHeaderDTGV()
    {
      dtgvListPhieuPhat.Columns[0].HeaderText = "ID";
      dtgvListPhieuPhat.Columns[1].HeaderText = "Mã admin";
      dtgvListPhieuPhat.Columns[2].HeaderText = "Mã thông tin độc giả";
      dtgvListPhieuPhat.Columns[3].HeaderText = "Tiền phạt";
      dtgvListPhieuPhat.Columns[4].HeaderText = "Ngày tạo phiếu phạt";
      dtgvListPhieuPhat.Columns[4].DefaultCellStyle.Format = "dd/MM/yyyy";
    }

    private void GetListPhieuPhat()
    {
      dtgvListPhieuPhat.DataSource = phieuPhatBUS.GetListPhieuPhat();
    }

    //  Làm mới
    private void btnLoad_Click(object sender, EventArgs e)
    {
      Load();
    }

    //  Tạo phiếu phạt
    private void btnAddPhieuPhat_Click(object sender, EventArgs e)
    {
      fAddPhieuPhat f = new fAddPhieuPhat();
      f.ShowDialog();
    }

    //  Tìm kiếm
    private void btnSearch_Click(object sender, EventArgs e)
    {
      int id = int.Parse(txnSearch.Text);

      if (rdbIdAdmin.Checked is true)
      {
        dtgvListPhieuPhat.DataSource = phieuPhatBUS.SearchByidAdmin(id);
      }
      else if (rdbIdInfor.Checked is true)
      {
        dtgvListPhieuPhat.DataSource = phieuPhatBUS.SearchByidInfor(id);
      }
    }
  }
}
