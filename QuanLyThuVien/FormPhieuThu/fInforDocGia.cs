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

namespace QuanLyThuVien.FormPhieuThu
{
  public partial class fInforDocGia : Form
  {
    InforDocGiaBUS inforDocGiaBUS = new InforDocGiaBUS();
    List<InforDocGiaDTO> listIFDG = new List<InforDocGiaDTO>();
    private string placeHolderText = "Nhập mã độc giả tại đây....";

    public fInforDocGia()
    {
      InitializeComponent();
      Load();
      
    }

    private new void Load()
    {
      txbSearch.Text = placeHolderText;
      txbSearch.GotFocus += RemoveText;
      txbSearch.LostFocus += AddText;

      listIFDG =  inforDocGiaBUS.ShowList();
      GetListInforDocGia();
      ChangeNameheaderDTGV();
    }

    private void GetListInforDocGia()
    {
      dtgvInforDocGia.DataSource = listIFDG;
    }

    private void ChangeNameheaderDTGV()
    {
      dtgvInforDocGia.Columns[0].HeaderText = "ID";
      dtgvInforDocGia.Columns[1].HeaderText = "Mã độc giả";
      dtgvInforDocGia.Columns[2].HeaderText = "Sách đang mượn";
      dtgvInforDocGia.Columns[3].HeaderText = "Sách mượn quá hạn";
      dtgvInforDocGia.Columns[4].HeaderText = "Tổng tiền phạt";
    }

    //  binding
    private void dtgvInforDocGia_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {
      int i = dtgvInforDocGia.CurrentRow.Index;
      txbSTT.Text = dtgvInforDocGia.Rows[i].Cells[0].Value.ToString();
      txbMaDocGia.Text = dtgvInforDocGia.Rows[i].Cells[1].Value.ToString();
      txbCountSachMuon.Text = dtgvInforDocGia.Rows[i].Cells[2].Value.ToString();
      txbCountSachQuaHan.Text = dtgvInforDocGia.Rows[i].Cells[3].Value.ToString();
      txbCountTienPhat.Text = dtgvInforDocGia.Rows[i].Cells[4].Value.ToString();
    }

    // Tìm kiếm
    private void btnSearch_Click(object sender, EventArgs e)
    {
      string id = txbSearch.Text;
      if (Equals(id, placeHolderText))
      {
        return;
      }
      dtgvInforDocGia.DataSource = inforDocGiaBUS.SearchByMaDocGia(id);
    }

    //  Làm mới
    private void btnLoad_Click(object sender, EventArgs e)
    {
      Load();
    }

    private void RemoveText(object sender, EventArgs e)
    {
      txbSearch.Text = "";
    }

    private void AddText(object sender, EventArgs e)
    {
      if (string.IsNullOrWhiteSpace(txbSearch.Text))
      {
        txbSearch.Text = placeHolderText;
      }
      
    }

  }
}
