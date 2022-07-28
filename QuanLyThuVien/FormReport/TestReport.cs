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
  public partial class TestReport : Form
  {
    public TestReport()
    {
      InitializeComponent();
    }

    private void TestReport_Load(object sender, EventArgs e)
    {
      // TODO: This line of code loads data into the 'testKLTNDataSet2.BillInfor' table. You can move, or remove it, as needed.
      this.billInforTableAdapter1.Fill(this.testKLTNDataSet2.BillInfor);
      // TODO: This line of code loads data into the 'testKLTNDataSet3.BillInfor' table. You can move, or remove it, as needed.
      this.billInforTableAdapter.Fill(this.testKLTNDataSet3.BillInfor);
      // TODO: This line of code loads data into the 'testKLTNDataSet2.Bill' table. You can move, or remove it, as needed.
      this.billTableAdapter1.Fill(this.testKLTNDataSet2.Bill);
      reportViewer1.LocalReport.ReportEmbeddedResource = "QuanLyThuVien.FormReport.Report3.rdlc";
      this.docGiaTableAdapter.Fill(this.testKLTNDataSet.DocGia);

      reportViewer1.LocalReport.ReportEmbeddedResource = "QuanLyThuVien.FormReport.Report2.rdlc";
      this.billTableAdapter.Fill(this.testKLTNDataSet1.Bill);

      reportViewer1.LocalReport.ReportEmbeddedResource = "QuanLyThuVien.FormReport.Report4.rdlc";
      this.billInforTableAdapter1.Fill(testKLTNDataSet2.BillInfor);

      this.reportViewer1.RefreshReport();
    }
  }
}
