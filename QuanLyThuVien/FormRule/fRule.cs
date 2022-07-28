using QuanLyThuVien.BUS;
using QuanLyThuVien.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThuVien.FormRule
{
  public partial class fRule : Form
  {
    NoiQuyBUS noiQuyBUS = new NoiQuyBUS();

    public fRule()
    {
      InitializeComponent();
      Load();
    }

    new void Load()
    {
      GetRule();

      if (fLogin.GetAdminInfor.quyen == 1)
      {
        button1.Enabled = false;
      }
    }

    private void GetRule()
    {
      List<NoiQuyDTO> list = noiQuyBUS.GetListNoiQuy();
      foreach (var item in list)
      {
        txbIDRule.Text = item.id.ToString();
        txbHanDungThe.Text = item.hanDungThe.ToString();
        txbGiaHanThe.Text = item.giaHanThe.ToString();
        txbTimeMuonSach.Text = item.thoiGianMuon.ToString();
        txbSLSachDuocMuon.Text = item.muonToiDa.ToString();
        txbOld.Text = item.tuoiMuonSach.ToString();
        txbTienPhat.Text = item.tienPhat.ToString();
      }
    }

    private void button2_Click(object sender, EventArgs e)
    {
      Load();
    }

    private void button1_Click(object sender, EventArgs e)
    {
      NoiQuyDTO nq = new NoiQuyDTO();
      try
      {
        nq.hanDungThe = int.Parse(txbHanDungThe.Text);
        nq.giaHanThe = int.Parse(txbGiaHanThe.Text);
        nq.muonToiDa = int.Parse(txbSLSachDuocMuon.Text);
        nq.thoiGianMuon = int.Parse(txbTimeMuonSach.Text);
        nq.tuoiMuonSach = int.Parse(txbOld.Text);
        nq.id = int.Parse(txbIDRule.Text);
        nq.tienPhat = double.Parse(txbTienPhat.Text);
        if (noiQuyBUS.Update(nq))
        {
          MessageBox.Show("Cập nhật nội quy thành công");
          Load();
        }
      }
      catch (Exception ex) 
      {
        MessageBox.Show("Kiểu dữ liệu nhập vào không phù hợp!!!!" + Environment.NewLine + ex.Message);
      }
    }
  }
}
