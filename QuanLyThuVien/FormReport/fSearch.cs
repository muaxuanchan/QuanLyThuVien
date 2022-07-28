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
  public partial class fSearch : Form
  {

    private string[] arrTypeSearchDocGia = new string[] { "Sách mượn", "Quá hạn" };
    private List<string> listTypeSearchDocGia = new List<string>();

    private string[] arrTypeSearchSach = new string[] { "Sách mượn", "Quá hạn" };
    private List<string> listTypeSearchSach = new List<string>();

    private string[] arrTypeSearchPhieuMuon = new string[] { "Chưa trả", "Quá hạn", "Đã trả" };
    private List<string> listTypeSearchPhieuMuon = new List<string>();

    private bool checkDocGia = false;
    private bool checkSach = false;
    private bool checkPhieuMuon = false;

    private DateTime from;
    private DateTime to;
    private DataTable data = new DataTable();

    public fSearch()
    {
      InitializeComponent();
      Load();
      plSearchDocGia.Visible = false;
      plSearchSach.Visible = false;
      plPhieuMuon.Visible = false;
    }

    public new void Load()
    {
      foreach (var item in arrTypeSearchDocGia)
      {
        listTypeSearchDocGia.Add(item.ToString());
      }
      cbTypeSearchDocGia.DataSource = listTypeSearchDocGia;

      foreach (var item in arrTypeSearchSach)
      {
        listTypeSearchSach.Add(item.ToString());
      }
      cbTypeSearchSach.DataSource = listTypeSearchSach;

      foreach (var item in arrTypeSearchPhieuMuon)
      {
        listTypeSearchPhieuMuon.Add(item.ToString());
      }
      cbTypeSearchPhieuMuon.DataSource = listTypeSearchPhieuMuon;
    }

    #region Change object search

    public void ChangeStatusNormal(ref RadioButton rb, ref DateTimePicker from, ref DateTimePicker to)
    {
      rb.Checked = false;
      from.Enabled = false;
      to.Enabled = false;
    }

    private void btnSearchDocGia_Click(object sender, EventArgs e)
    {
      txbSearchIDDocGia.Text = "";
      ChangeStatusNormal(ref rbSearchDocGia, ref dtpkDateFromSearchDocGia, ref dtpkDateToSearchDocGia);

      plSearchDocGia.Visible = true;
      plSearchSach.Visible = false;
      plPhieuMuon.Visible = false;
      checkDocGia = true;
      checkPhieuMuon = false;
      checkSach = false;
      dtgvSearch.DataSource = null;
    }

    private void btnSearchSach_Click(object sender, EventArgs e)
    {
      ChangeStatusNormal(ref rdSearchSach, ref dtpkDateFromSearchSach, ref dtpkDateToSearchSach);

      plSearchSach.Visible = true;
      plSearchDocGia.Visible = false;
      plPhieuMuon.Visible = false;
      checkSach = true;
      checkDocGia = false;
      checkPhieuMuon = false;
      dtgvSearch.DataSource = null;
    }

    private void btnSearchPhieuMuon_Click(object sender, EventArgs e)
    {
      ChangeStatusNormal(ref rbSearchPhieuMuon, ref dtpkDateFromPhieuMuon, ref dtpkDateToPhieuMuon);

      plSearchDocGia.Visible = false;
      plSearchSach.Visible = false;
      plPhieuMuon.Visible = true;
      checkPhieuMuon = true;
      checkDocGia = false;
      checkSach = false;
      dtgvSearch.DataSource = null;
    }

    #endregion

    #region Change selection with time

    public void ChangeStatus(RadioButton rb, DateTimePicker from, DateTimePicker to)
    {
      if (rb.Checked is true)
      {
        rb.Checked = false;
        from.Enabled = false;
        to.Enabled = false;
      }
      else
      {
        rb.Checked = true;
        from.Enabled = true;
        to.Enabled = true;
      }
    }

    private void btnSearch_Click(object sender, EventArgs e)
    {
      ChangeStatus(rbSearchDocGia, dtpkDateFromSearchDocGia, dtpkDateToSearchDocGia);
    }

    private void button4_Click(object sender, EventArgs e)
    {
      ChangeStatus(rdSearchSach, dtpkDateFromSearchSach, dtpkDateToSearchSach);
    }

    private void btnAddTimePhieuMuon_Click(object sender, EventArgs e)
    {
      ChangeStatus(rbSearchPhieuMuon, dtpkDateFromPhieuMuon, dtpkDateToPhieuMuon);
    }
    #endregion

    #region Change hearder text datagridview

    public void ChangeHearderTextDocGia()
    {
      dtgvSearch.Columns[0].HeaderText = "ID";
      dtgvSearch.Columns[1].HeaderText = "Mã phiếu";
      dtgvSearch.Columns[2].HeaderText = "Mã sách";
      dtgvSearch.Columns[3].HeaderText = "Ngày tạo phiếu";
      dtgvSearch.Columns[3].DefaultCellStyle.Format = "dd/MM/yyyy";
      dtgvSearch.Columns[4].HeaderText = "Ngày hẹn trả";
      dtgvSearch.Columns[4].DefaultCellStyle.Format = "dd/MM/yyyy";
      dtgvSearch.Columns[5].HeaderText = "Trạng thái mượn";
    }

    public void ChangeHearderTextSach()
    {
      dtgvSearch.Columns[0].HeaderText = "ID";
      dtgvSearch.Columns[1].HeaderText = "Mã phiếu";
      dtgvSearch.Columns[2].HeaderText = "Mã độc giả";
      dtgvSearch.Columns[3].HeaderText = "Mã sách";
      dtgvSearch.Columns[4].HeaderText = "Ngày tạo phiếu";
      dtgvSearch.Columns[4].DefaultCellStyle.Format = "dd/MM/yyyy";
      dtgvSearch.Columns[5].HeaderText = "Ngày hẹn trả";
      dtgvSearch.Columns[5].DefaultCellStyle.Format = "dd/MM/yyyy";
      dtgvSearch.Columns[6].HeaderText = "Trạng thái mượn";
    }

    public void ChangeHearderTextPhieuMuon()
    {
      dtgvSearch.Columns[0].HeaderText = "ID";
      dtgvSearch.Columns[1].HeaderText = "Mã admin";
      dtgvSearch.Columns[2].HeaderText = "Mã độc giả";
      dtgvSearch.Columns[3].HeaderText = "Số sách mượn";
      dtgvSearch.Columns[4].HeaderText = "Số sách còn lại";
      dtgvSearch.Columns[5].HeaderText = "Ngày tạo phiếu";
      dtgvSearch.Columns[5].DefaultCellStyle.Format = "dd/MM/yyyy";
      dtgvSearch.Columns[6].HeaderText = "Ngày hẹn trả";
      dtgvSearch.Columns[6].DefaultCellStyle.Format = "dd/MM/yyyy";
      dtgvSearch.Columns[7].HeaderText = "Trạng thái mượn";
    }

    #endregion

    //  Search
    private void button2_Click(object sender, EventArgs e)
    {

      //  search đọc giả
      if (checkDocGia is true)
      {
        if (Equals(cbTypeSearchDocGia.Text, "Sách mượn"))   //  Sách mượn
        {
          if (rbSearchDocGia.Checked)
          {
            from = dtpkDateFromSearchDocGia.Value;
            to = dtpkDateToSearchDocGia.Value;

            string query = "exec GetListBillInforChuaTraByMaDocGiaWithTime @idDocGia , @from , @to ";
            dtgvSearch.DataSource = DataProvider.Instance.ExecuteQuery(query, new object[]
              { txbSearchIDDocGia.Text.ToString(), from, to});
          }
          else
          {
            string query = "exec GetListBillInforChuaTraByMaDocGia @idDocGia  ";
            dtgvSearch.DataSource = DataProvider.Instance.ExecuteQuery(query, new object[]
              { txbSearchIDDocGia.Text});
          }
        }

        if (Equals(cbTypeSearchDocGia.Text, "Quá hạn"))   // sách mượn quá hạn
        {
          string query = "exec GetListBillInforQuaHanByMaDocGia @idDocGia  ";
          dtgvSearch.DataSource = DataProvider.Instance.ExecuteQuery(query, new object[]
            { txbSearchIDDocGia.Text});
        }

        ChangeHearderTextDocGia();
      }

      //  
      if (checkSach is true)
      {
        from = dtpkDateFromSearchSach.Value;
        to = dtpkDateToSearchSach.Value;
        if (string.IsNullOrEmpty(txbSearchSach.Text))
        {
          //  Sách mượn
          if (Equals(cbTypeSearchSach.Text, "Sách mượn"))   //  Sách mượn
          {
            if (rdSearchSach.Checked)
            {
              string query = "exec GetListBillInforChuaTrahWithTime @from , @to ";
              dtgvSearch.DataSource = DataProvider.Instance.ExecuteQuery(query, new object[]
                { from, to});
            }
            else
            {
              string query = "exec GetListBillInforChuaTra ";
              dtgvSearch.DataSource = DataProvider.Instance.ExecuteQuery(query);
            }
            
          }

          //  Sách mượn quá hạn
          if (Equals(cbTypeSearchSach.Text, "Quá hạn"))   // sách mượn quá hạn
          {
            string query = "exec GetListBillInforQuaHan ";
            dtgvSearch.DataSource = DataProvider.Instance.ExecuteQuery(query);
          }
        }
        else
        {
          //  Sách mượn
          if (Equals(cbTypeSearchSach.Text, "Sách mượn"))   //  Sách mượn
          {
            if (rdSearchSach.Checked)
            {
              string query = "exec GetListBillInforChuaTraByMaSachWithTime @idSach , @from , @to ";
              dtgvSearch.DataSource = DataProvider.Instance.ExecuteQuery(query, new object[]
                { txbSearchSach.Text, from, to});
            }
            else
            {
              string query = "exec GetListBillInforChuaTraByMaSach @idSach  ";
              dtgvSearch.DataSource = DataProvider.Instance.ExecuteQuery(query, new object[]
                { txbSearchSach.Text});
            }
          }

          //  Sách mượn quá hạn
          if (Equals(cbTypeSearchSach.Text, "Quá hạn"))   // sách mượn quá hạn
          {
            string query = "exec GetListBillInforQuaHanByMaSach @idSach  ";
            dtgvSearch.DataSource = DataProvider.Instance.ExecuteQuery(query, new object[]
              { txbSearchSach.Text});
          }
        }

        ChangeHearderTextSach();
      }

      //  Search phiếu mượn
      if (checkPhieuMuon is true)
      {
        from = dtpkDateFromPhieuMuon.Value;
        to = dtpkDateToPhieuMuon.Value;

        if (Equals(cbTypeSearchPhieuMuon.Text, "Chưa trả"))   //Phiếu mượn chưa trả
        {
          if (rbSearchPhieuMuon.Checked is true )
          {
            string query = "exec GetBillChuaTraWithTime @from , @to ";
            dtgvSearch.DataSource = DataProvider.Instance.ExecuteQuery(query, new object[]
              { from, to});
          }
          else
          {
            string query = "select * from Bill where status is null";
            dtgvSearch.DataSource = DataProvider.Instance.ExecuteQuery(query);
          }
        }

        if (Equals(cbTypeSearchPhieuMuon.Text, "Quá hạn"))   //  Phiếu mượn đã trả
        {
          if (rbSearchPhieuMuon.Checked is true)
          {
            string query = "exec GetBillQuaHanWithTime @from , @to ";
            dtgvSearch.DataSource = DataProvider.Instance.ExecuteQuery(query, new object[]
              { from, to});
          }
          else
          {
            string query = "exec GetBillQuaHan";
            dtgvSearch.DataSource = DataProvider.Instance.ExecuteQuery(query);
          }
        }

        if (Equals(cbTypeSearchPhieuMuon.Text, "Đã trả"))   //  Phiếu mượn đã trả
        {
          if (rbSearchPhieuMuon.Checked is true)
          {
            string query = "exec GetBillDaTraWithTime @from , @to ";
            dtgvSearch.DataSource = DataProvider.Instance.ExecuteQuery(query, new object[]
              { from, to});
          }
          else
          {
            string query = "select * from Bill where status = N'Đã trả'";
            dtgvSearch.DataSource = DataProvider.Instance.ExecuteQuery(query);
          }
        }

        ChangeHearderTextPhieuMuon();
      }

    }


  }
}
