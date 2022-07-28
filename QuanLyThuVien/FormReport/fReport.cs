using Microsoft.Reporting.WinForms;
using QuanLyThuVien.BUS;
using QuanLyThuVien.DataSetObject;
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

namespace QuanLyThuVien.FormReport
{
  public partial class fTestReport1 : Form
  {
    private BillBUS billBUS = new BillBUS();

    public fTestReport1()
    {
      InitializeComponent();
    } 

    private void Form1_Load(object sender, EventArgs e)
    {
      int typeReport = fThongKeSach.GetInforReport.reportType;

      DateTime from = fThongKeSach.GetInforReport.from;
      DateTime to = fThongKeSach.GetInforReport.to;
      string countTong = fThongKeSach.GetInforReport.countTong;
      DateTime dateCrateReport = DateTime.Now;
      string nameAdmin = fLogin.GetAdminInfor.nameAdmin;
      string idAdmin = fLogin.GetAdminInfor.idAdmin;

      ReportParameter[] param = new ReportParameter[6];
      param[0] = new ReportParameter("dateFrom", string.Format(from.ToString("dd/MM/yyyy")));
      param[1] = new ReportParameter("dateTo", string.Format(to.ToString("dd/MM/yyyy")));
      param[2] = new ReportParameter("countTong", countTong);
      param[3] = new ReportParameter("dateCreateReport", string.Format(dateCrateReport.ToString("dd/MM/yyyy")));
      param[4] = new ReportParameter("nameAdmin", nameAdmin);
      param[5] = new ReportParameter("idAdmin", idAdmin);

      if (Equals(typeReport, (int)ReportType.sachMuon))   // Report sách mượn
      {
        List<CountSachMuon> listCountSachMuon = new List<CountSachMuon>();
        string query = "exec GetListReportSoLuongSachMuon @from , @to";
        DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { from, to });

        foreach (DataRow item in data.Rows)
        {
          CountSachMuon dsr = new CountSachMuon(item);

          listCountSachMuon.Add(dsr);
        }

        reportViewer1.LocalReport.ReportEmbeddedResource = "QuanLyThuVien.FormReport.rSachMuon.rdlc";
        this.reportViewer1.LocalReport.SetParameters(param);
        var reportDataSource = new ReportDataSource("DSCountSachMuon", listCountSachMuon);
        this.reportViewer1.LocalReport.DataSources.Clear();
        this.reportViewer1.LocalReport.DataSources.Add(reportDataSource);
        this.reportViewer1.LocalReport.DisplayName = "Tổng sách mượn";
      }
      else if (Equals(typeReport, (int)ReportType.sachTra))   //  Report sách trả
      {
        string query = "exec GetListReportSachTra @from , @to ";
        List<DataSetReport> listSachTra = new List<DataSetReport>();
        DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { from, to });

        foreach (DataRow item in data.Rows)
        {
          DataSetReport dsr = new DataSetReport(item);

          listSachTra.Add(dsr);
        }

        reportViewer1.LocalReport.ReportEmbeddedResource = "QuanLyThuVien.FormReport.rSachTra.rdlc";
        this.reportViewer1.LocalReport.SetParameters(param);
        var reportDataSource = new ReportDataSource("DSSachTraNew", listSachTra);
        this.reportViewer1.LocalReport.DataSources.Clear();
        this.reportViewer1.LocalReport.DataSources.Add(reportDataSource);
        this.reportViewer1.LocalReport.DisplayName = "Sách trả";
      }
      else if (Equals(typeReport, (int)ReportType.chuaTra)) //  Report sách chưa trả
      {
        string query = "exec GetListReportChuaTra @from , @to ";
        List<DataSetReport> listSachChuaTra = new List<DataSetReport>();
        DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { from, to });

        foreach (DataRow item in data.Rows)
        {
          DataSetReport dsr = new DataSetReport(item);

          listSachChuaTra.Add(dsr);
        }

        reportViewer1.LocalReport.ReportEmbeddedResource = "QuanLyThuVien.FormReport.rChuaTra.rdlc";
        this.reportViewer1.LocalReport.SetParameters(param);
        var reportDataSource = new ReportDataSource("DSChuaTra", listSachChuaTra);
        this.reportViewer1.LocalReport.DataSources.Clear();
        this.reportViewer1.LocalReport.DataSources.Add(reportDataSource);
        this.reportViewer1.LocalReport.DisplayName = "Sách chưa trả";
      }
      else if (Equals(typeReport, (int)ReportType.traMuon)) //  Report sách trả muộn
      {
        string query = "exec GetListReportTraMuon @from , @to ";
        List<DataSetReport> listSachTraMuon = new List<DataSetReport>();
        DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { from, to });

        foreach (DataRow item in data.Rows)
        {
          DataSetReport dsr = new DataSetReport(item);

          listSachTraMuon.Add(dsr);
        }

        reportViewer1.LocalReport.ReportEmbeddedResource = "QuanLyThuVien.FormReport.rTraMuon.rdlc";
        this.reportViewer1.LocalReport.SetParameters(param);
        var reportDataSource = new ReportDataSource("DSTraMuon", listSachTraMuon);
        this.reportViewer1.LocalReport.DataSources.Clear();
        this.reportViewer1.LocalReport.DataSources.Add(reportDataSource);
        this.reportViewer1.LocalReport.DisplayName = "Sách trả muộn";
      }
      else if (Equals(typeReport, (int)ReportType.quaHan))
      {
        string query = "exec GetListReportQuaHan2";
        List<DataSetReport> listQuaHan = new List<DataSetReport>();
        DataTable data = DataProvider.Instance.ExecuteQuery(query);

        foreach (DataRow item in data.Rows)
        {
          DataSetReport dsr = new DataSetReport(item);

          listQuaHan.Add(dsr);
        }

        reportViewer1.LocalReport.ReportEmbeddedResource = "QuanLyThuVien.FormReport.rQuaHan.rdlc";
        this.reportViewer1.LocalReport.SetParameters(param);
        var reportDataSource = new ReportDataSource("DSQuaHan2", listQuaHan);
        this.reportViewer1.LocalReport.DataSources.Clear();
        this.reportViewer1.LocalReport.DataSources.Add(reportDataSource);
        this.reportViewer1.LocalReport.DisplayName = "Sách quá hạn";
      }

      this.reportViewer1.RefreshReport();
    }
  }
}
