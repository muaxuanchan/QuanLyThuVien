using QuanLyThuVien.BUS;
using QuanLyThuVien.FormMuonTraSach;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThuVien
{
  public partial class fMuonSach : Form
  {
    BillBUS billBUS = new BillBUS();
    BillInforBUS billInforBUS = new BillInforBUS();

    public fMuonSach()
    {
      InitializeComponent();
      Load();
    }

    new void Load()
    {
      GetListPhieuMuon();
      GetHeaderText();
      ClearAll();
    }

    void GetListPhieuMuon()
    {
      dtgvBill.DataSource = billBUS.GetListPhieuMuonChuaTra();
    }

    // Đổi tên cột datagridview
    void GetHeaderText()
    {
      dtgvBill.Columns[0].HeaderText = "Mã phiếu";
      dtgvBill.Columns[1].HeaderText = "Mã admin";
      dtgvBill.Columns[2].HeaderText = "Mã độc giả";
      dtgvBill.Columns[3].HeaderText = "Số lượng";
      dtgvBill.Columns[4].HeaderText = "Còn lại";
      dtgvBill.Columns[5].HeaderText = "Ngày tạo phiếu";
      dtgvBill.Columns[5].DefaultCellStyle.Format = "dd/MM/yyyy";
      dtgvBill.Columns[6].HeaderText = "Ngày trả sách";
      dtgvBill.Columns[6].DefaultCellStyle.Format = "dd/MM/yyyy";
      dtgvBill.Columns[7].HeaderText = "Trạng thái";
    }

    void GetHeaderDataGridview()
    {
      dtgvBillInfor.Columns[0].HeaderText = "ID";
      dtgvBillInfor.Columns[1].HeaderText = "Mã phiếu";
      dtgvBillInfor.Columns[2].HeaderText = "Mã sách";
      dtgvBillInfor.Columns[3].HeaderText = "Ngày trả sách";
      dtgvBillInfor.Columns[4].HeaderText = "Trạng thái";
      dtgvBillInfor.Columns[5].HeaderText = "Ghi chú";
    }

    void ClearAll()
    {
      txbIDBill.Text = "";
      txbIDAdmin.Text = "";
      txbIDDocGia.Text = "";
      txbCount.Text = "";
      txbConLai.Text = "";
      dttpDateCreate.Value = DateTime.Now;
      dtpkDateCheckOut.Value = DateTime.Now;
      txnSearch.Text = "";
      rbIDBill.Checked = true;
    }

    void LoadListBillInfor(int idBill)
    {
      dtgvBillInfor.DataSource = billInforBUS.GetListByIDBill(idBill);
    }

    //  Thêm phiếu mượn
    private void btnAdd_Click(object sender, EventArgs e)
    {
      fAddPhieuMuon f = new fAddPhieuMuon();
      f.ShowDialog();
    }

    //  Làm mới
    private void btnLoad_Click(object sender, EventArgs e)
    {
      Load();
      dtgvBillInfor.DataSource = null;
    }

    private void dtgvBill_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {
      int i = dtgvBill.CurrentRow.Index;
      txbIDBill.Text = dtgvBill.Rows[i].Cells[0].Value.ToString();
      txbIDAdmin.Text = dtgvBill.Rows[i].Cells[1].Value.ToString();
      txbIDDocGia.Text = dtgvBill.Rows[i].Cells[2].Value.ToString();
      txbCount.Text = dtgvBill.Rows[i].Cells[3].Value.ToString();
      txbConLai.Text = dtgvBill.Rows[i].Cells[4].Value.ToString();
      dttpDateCreate.Value = (DateTime)dtgvBill.Rows[i].Cells[5].Value;
      dtpkDateCheckOut.Value = (DateTime)dtgvBill.Rows[i].Cells[6].Value;
      
      LoadListBillInfor(int.Parse(txbIDBill.Text));
      GetHeaderDataGridview();
    }

    private void btnSearch_Click(object sender, EventArgs e)
    {
      try
      {
        if (rbIDBill.Checked == true)
        {
          int id = int.Parse(txnSearch.Text);
          dtgvBill.DataSource = billBUS.SearchByIDBill(id);
        }
        else if (rbIDDocGia.Checked == true)
        {
          string id = txnSearch.Text;
          dtgvBill.DataSource = billBUS.SearchByIDDocGia(id);
        }
      }
      catch (Exception)
      {

        return;
      }
      
    }
  }
}
