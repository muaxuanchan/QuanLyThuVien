using QuanLyThuVien.BUS;
using QuanLyThuVien.DataSetObject;
using QuanLyThuVien.FormReport;
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
  public partial class fThongKeSach : Form
  {
    private DataTable dt = new DataTable();
    private SachBUS sachBUS = new SachBUS();
    private BillBUS billBUS = new BillBUS();
    private BillInforBUS billInforBUS = new BillInforBUS();
    private DocGiaBUS docGiaBUS = new DocGiaBUS();

    public fThongKeSach()
    {
      InitializeComponent();
      Load();
    }

    public class GetInforReport
    {
      static public DateTime from;
      static public DateTime to;
      static public int reportType;
      static public string countTong;
      static public List<DataSetReport> listDS = new List<DataSetReport>();
    }

    new void Load()
    {

      GetAmountSach();
      GetAmountSachMuon();
      GetAmountSachQuaHan();
      GetAmountSachTraMuon();
      GetAmountSachConLai();
      GetAmountDocGia();
      GetAmountMuonSach();
      btnExport.Enabled = false;
      txbCount.Text = "";

    }

    // Đổi tên cột datagridview sách mượn
    void GetHeaderText()
    {
      dtgvReport.Columns[0].HeaderText = "Mã phiếu";
      dtgvReport.Columns[1].HeaderText = "Mã admin";
      dtgvReport.Columns[2].HeaderText = "Mã độc giả";
      dtgvReport.Columns[3].HeaderText = "Số lượng";
      dtgvReport.Columns[4].HeaderText = "Còn lại";
      dtgvReport.Columns[5].HeaderText = "Ngày tạo phiếu";
      dtgvReport.Columns[5].DefaultCellStyle.Format = "dd/MM/yyyy";
      dtgvReport.Columns[6].HeaderText = "Ngày trả sách";
      dtgvReport.Columns[6].DefaultCellStyle.Format = "dd/MM/yyyy";
      dtgvReport.Columns[7].HeaderText = "Trạng thái";
    }

    // Đổi tên cột datagridview sách trả
    void GetHeaderDataGridview()
    {
      dtgvReport.Columns[0].HeaderText = "ID";
      dtgvReport.Columns[1].HeaderText = "Mã phiếu";
      dtgvReport.Columns[2].HeaderText = "Mã sách";
      dtgvReport.Columns[3].HeaderText = "Ngày trả sách";
      dtgvReport.Columns[4].HeaderText = "Trạng thái";
    }

    // Đổi tên cột datagridview sách quá hạn
    void GetHeaderDataGridviewSachReport()
    {
      dtgvReport.Columns[0].HeaderText = "ID";
      dtgvReport.Columns[1].HeaderText = "Mã phiếu";
      dtgvReport.Columns[2].HeaderText = "Mã độc giả";
      dtgvReport.Columns[3].HeaderText = "Mã sách";
      dtgvReport.Columns[4].HeaderText = "Ngày mượn sách";
      dtgvReport.Columns[4].DefaultCellStyle.Format = "dd/MM/yyyy";
      dtgvReport.Columns[5].HeaderText = "Ngày hẹn trả";
      dtgvReport.Columns[5].DefaultCellStyle.Format = "dd/MM/yyyy";
      dtgvReport.Columns[6].HeaderText = "Ngày trả sách";
      dtgvReport.Columns[6].DefaultCellStyle.Format = "dd/MM/yyyy";
      dtgvReport.Columns[7].HeaderText = "Trạng thái";
    }

    //  Hiển thị tổng số sách
    void GetAmountSach()
    {
      txbTongSoSach.Text = sachBUS.GetAmountSach().ToString();
    }

    //  Hiển thị tổng số sách còn lại
    void GetAmountSachConLai()
    {
      txbConLai.Text = sachBUS.GetAmountSachConLai().ToString();
    }

    // Hiển thị tổng số sách đang được mượn
    void GetAmountSachMuon()
    {
      txbSachMuon.Text = billBUS.GetAmountSachMuon().ToString();
    }

    // Hiển thị sách mượn quá hạn
    void GetAmountSachQuaHan()
    {
      txbSachQuaHan.Text = billBUS.GetAmountSachMuonQuaHan().ToString();
    }

    // Hiển thị số lượng sách trả muộn
    void GetAmountSachTraMuon()
    {
      txbSachTraMuon.Text = billInforBUS.GetAmountSachTraMuon().ToString();
    }

    //  Hiển thị số lượng đọc giả
    void GetAmountDocGia()
    {
      txbAmountDocGia.Text = docGiaBUS.GetAmountDocGia().ToString();
    }

    // Hiển thị số lần mượn sách
    void GetAmountMuonSach()
    {
      txbAmountMuon.Text = billBUS.GetAmountMuonSach().ToString();
    }
    //  Làm mới
    private void btnLoad_Click(object sender, EventArgs e)
    {
      Load();
      dtgvReport.DataSource = null;
    }

    //  Thống kê
    private void btnSearch_Click(object sender, EventArgs e)
    {
      DateTime from = dtpkDateFrom.Value;
      DateTime to = dtpkDateTo.Value;

      GetInforReport.from = from;
      GetInforReport.to = to;

      if (rbSachMuon.Checked) //  thống kê bill mượn sách
      {
        int count = 0;
        string query = "exec GetListReportSoLuongSachMuon @from , @to ";
        dtgvReport.DataSource = DataProvider.Instance.ExecuteQuery(query, new object[] { from, to });
        dtgvReport.Columns[0].HeaderText = "Mã sách";
        dtgvReport.Columns[1].HeaderText = "Tổng mượn";

        for (int rows = 0; rows < dtgvReport.Rows.Count; rows++)
        {
          count += Convert.ToInt32(dtgvReport.Rows[rows].Cells[1].Value);
        }

        txbCount.Text = count.ToString();
        GetInforReport.reportType = (int)ReportType.sachMuon;
      }
      else if (rbSachTra.Checked) // Thống kê sách trả
      {
        GetInforReport.reportType = (int)ReportType.sachTra;
        string query = "exec GetListReportSachTra @from , @to ";
        dtgvReport.DataSource = DataProvider.Instance.ExecuteQuery(query, new object[] { from, to
  });
        //GetInforReport.listDS = DataProvider.Instance.ExecuteQuery(query, new object[] { from, to });
        txbCount.Text = billInforBUS.GetAmountReportSachTra(from, to).ToString();
        GetHeaderDataGridviewSachReport();
      }
      else if (rbChuaTra.Checked) //  thống kê sách chưa trả
      {
        GetInforReport.reportType = (int)ReportType.chuaTra;
        string query = "exec GetListReportChuaTra @from , @to ";
        dtgvReport.DataSource = DataProvider.Instance.ExecuteQuery(query, new object[] { from, to });
        GetHeaderDataGridviewSachReport();
        txbCount.Text = billInforBUS.GetAmountReportSachChuaTra(from, to).ToString();
      }
      else if (rbTraMuon.Checked) //  thống kê sách trả muộn
      {
        GetInforReport.reportType = (int)ReportType.traMuon;
        string query = "exec GetListReportTraMuon @from , @to ";
        dtgvReport.DataSource = DataProvider.Instance.ExecuteQuery(query, new object[] { from, to });
        GetHeaderDataGridviewSachReport();
        txbCount.Text = billInforBUS.GetAmountReportSachTraMuon(from, to).ToString();
      }
      else if (rbQuaHan.Checked) // thống kê sách mượn quá hạn
      {
        GetInforReport.reportType = (int)ReportType.quaHan;
        //string query = "exec GetListReportQuaHan @from , @to ";
        string query1 = "exec GetListReportQuaHan2";
        dtgvReport.DataSource = DataProvider.Instance.ExecuteQuery(query1);
        //txbCount.Text = billInforBUS.GetAmountReportSachQuaHan(from, to).ToString();
        txbCount.Text = dtgvReport.Rows.Count.ToString();
        //GetHeaderDataGridviewSachReport();
        dtgvReport.Columns[0].HeaderText = "ID";
        dtgvReport.Columns[1].HeaderText = "Mã phiếu";
        dtgvReport.Columns[2].HeaderText = "Mã độc giả";
        dtgvReport.Columns[3].HeaderText = "Mã sách";
        dtgvReport.Columns[4].HeaderText = "Ngày mượn sách";
        dtgvReport.Columns[4].DefaultCellStyle.Format = "dd/MM/yyyy";
        dtgvReport.Columns[5].HeaderText = "Ngày hẹn trả";
        dtgvReport.Columns[5].DefaultCellStyle.Format = "dd/MM/yyyy";
      }

      if (string.IsNullOrEmpty(txbCount.Text) || txbCount.Text == "0")
      {
        btnExport.Enabled = false;
      }
      else
      {
        btnExport.Enabled = true;
      }

      GetInforReport.countTong = txbCount.Text;
    }

    #region Xuất dữ liệu ra file excel
    //  Xuất dữ liệu ra file excel
    private void ToExcel(DataGridView dataGridView1, string fileName)
    {
      //khai báo thư viện hỗ trợ Microsoft.Office.Interop.Excel
      Microsoft.Office.Interop.Excel.Application excel;
      Microsoft.Office.Interop.Excel.Workbook workbook;
      Microsoft.Office.Interop.Excel.Worksheet worksheet;
      try
      {
        //Tạo đối tượng COM.
        excel = new Microsoft.Office.Interop.Excel.Application();
        excel.Visible = false;
        excel.DisplayAlerts = false;
        //tạo mới một Workbooks bằng phương thức add()
        workbook = excel.Workbooks.Add(Type.Missing);
        worksheet = (Microsoft.Office.Interop.Excel.Worksheet)workbook.Sheets["Sheet1"];
        //đặt tên cho sheet
        if (rbSachMuon.Checked)
        {
          worksheet.Name = "Sách mượn";
          worksheet.Cells[1, 1] = "Thống kê số lượng sách mượn";
        }
        else if (rbSachTra.Checked)
        {
          worksheet.Name = "Sách trả";
          worksheet.Cells[1, 1] = "Thống kê số lượng sách trả";
        }
        else if (rbChuaTra.Checked)
        {
          worksheet.Name = "Chưa trả";
          worksheet.Cells[1, 1] = "Thống kê số lượng sách chưa trả";
        }
        else if (rbTraMuon.Checked)
        {
          worksheet.Name = "Trả muộn";
          worksheet.Cells[1, 1] = "Thống kê số lượng sách trả muộn";
        }
        else if (rbQuaHan.Checked)
        {
          worksheet.Name = "Quá hạn";
          worksheet.Cells[1, 1] = "Thống kê số lượng sách  mượn quá hạn";
        }


        // export header trong DataGridView

        worksheet.Cells[2, 1] = lbFrom.Text;
        worksheet.Cells[2, 2] = dtpkDateFrom.Value;
        worksheet.Cells[2, 3] = lbTo.Text;
        worksheet.Cells[2, 4] = dtpkDateTo.Value;

        for (int i = 0; i < dataGridView1.ColumnCount; i++)
        {
          worksheet.Cells[3, i + 1] = dataGridView1.Columns[i].HeaderText;
        }

        // export nội dung trong DataGridView
        for (int i = 0; i < dataGridView1.RowCount; i++)
        {
          for (int j = 0; j < dataGridView1.ColumnCount; j++)
          {
            worksheet.Cells[i + 4, j + 1] = dataGridView1.Rows[i].Cells[j].Value.ToString();
          }
        }
        worksheet.Cells[dataGridView1.RowCount + 4, 1] = lbTong.Text;
        worksheet.Cells[dataGridView1.RowCount + 4, 2] = txbCount.Text;

        // sử dụng phương thức SaveAs() để lưu workbook với filename
        workbook.SaveAs(fileName);

        //đóng workbook
        workbook.Close();
        excel.Quit();
        MessageBox.Show("Xuất dữ liệu ra Excel thành công!", "Thông báo");
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message);
      }
      finally
      {
        workbook = null;
        worksheet = null;
      }
    }

    private void button1_Click(object sender, EventArgs e)
    {
      SaveFileDialog saveFileDialog1 = new SaveFileDialog();

      if (saveFileDialog1.ShowDialog() == DialogResult.OK)
      {
        //gọi hàm ToExcel() với tham số là dtgDSHS và filename từ SaveFileDialog
        ToExcel(dtgvReport, saveFileDialog1.FileName);
      }
    }
    #endregion

    #region Merge column
    // Merge column
    bool IsTheSameCellValue(int col, int row)
    {
      DataGridViewCell cell_1 = dtgvReport[col, row];
      DataGridViewCell cell_2 = dtgvReport[col, row - 1];

      if (cell_1.Value == null || cell_2.Value == null)
      {
        return false;
      }
      return cell_1.Value.ToString() == cell_2.Value.ToString();
    }

    private void dtgvReport_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
    {
      e.AdvancedBorderStyle.Bottom = DataGridViewAdvancedCellBorderStyle.None;

      if (e.RowIndex < 1 || e.ColumnIndex < 0)
      {
        e.AdvancedBorderStyle.Top = DataGridViewAdvancedCellBorderStyle.Single;
        return;
      }
      if (rbSachMuon.Checked)
      {
        if (Equals(dtgvReport.Columns[e.ColumnIndex].HeaderText, "Mã độc giả") && IsTheSameCellValue(e.ColumnIndex, e.RowIndex))
        {

          e.AdvancedBorderStyle.Top = DataGridViewAdvancedCellBorderStyle.None;
        }
        else
        {
          e.AdvancedBorderStyle.Top = dtgvReport.AdvancedCellBorderStyle.Top;
        }
      }
      else
      {
        if (Equals(dtgvReport.Columns[e.ColumnIndex].HeaderText, "Mã phiếu") && IsTheSameCellValue(e.ColumnIndex, e.RowIndex))
        {

          e.AdvancedBorderStyle.Top = DataGridViewAdvancedCellBorderStyle.None;
        }
        else
        {
          e.AdvancedBorderStyle.Top = dtgvReport.AdvancedCellBorderStyle.Top;
        }
      }

    }

    private void dtgvReport_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
    {
      if (e.RowIndex == 0)
      {
        return;
      }

      if (dtgvReport.Columns[e.ColumnIndex].HeaderText == "Mã phiếu")
      {
        if (IsTheSameCellValue(e.ColumnIndex, e.RowIndex))
        {
          e.Value = "";
          e.FormattingApplied = true;
        }
      }

      if (dtgvReport.Columns[e.ColumnIndex].HeaderText == "Mã độc giả")
      {
        if (IsTheSameCellValue(e.ColumnIndex, e.RowIndex))
        {
          e.Value = "";
          e.FormattingApplied = true;
        }
      }
    }
    #endregion


    //  Tạo báo cáo
    private void btnReport_Click(object sender, EventArgs e)
    {
      fTestReport1 testReport1 = new fTestReport1();
      testReport1.ShowDialog();
    }
  }
}
