using QuanLyThuVien.BUS;
using QuanLyThuVien.Const;
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

namespace QuanLyThuVien
{
  public partial class fTraSach : Form
  {
    private const double HeSoPhat = 1.5;
    private CommonConstants constants = new CommonConstants();
    private BillBUS billBUS = new BillBUS();
    private BillInforBUS billInforBUS = new BillInforBUS();
    private SachBUS sachBUS = new SachBUS();
    private InforDocGiaBUS inforDocGiaBUS = new InforDocGiaBUS();

    public fTraSach()
    {
      InitializeComponent();
      Load();
    }

    new void Load()
    {
      LoadComboBoxIDDocGia();
      GetListBillInforReturn();
      GetHeaderDataGridviewBI();
      cbxMatSach.Checked = false;
    }


    // ClearAll
    void ClearAll()
    {
      txbIDBillInfor.Text = "";
      txbidBill.Text = "";
      txbMaSach.Text = "";
      txbDateCheckOut.Text = "";
      txbStatus.Text = "";
    }

    #region Datagridview
    void GetListBillInforReturn()
    {
      dtgvTraSach.DataSource = billInforBUS.GetListChiTietPhieuMuonReturn();
    }

    void GetHeaderDataGridview()
    {
      dtgvBillInfor.Columns[0].HeaderText = "ID";
      dtgvBillInfor.Columns[1].HeaderText = "Mã phiếu";
      dtgvBillInfor.Columns[2].HeaderText = "Mã sách";
      dtgvBillInfor.Columns[3].HeaderText = "Ngày trả sách";
      dtgvBillInfor.Columns[3].DefaultCellStyle.Format = "dd/MM/yyyy";
      dtgvBillInfor.Columns[4].HeaderText = "Trạng thái";
      dtgvBillInfor.Columns[5].HeaderText = "Ghi chú";
      dtgvBillInfor.Columns[6].HeaderText = "Phiếu phạt";
    }

    void GetHeaderDataGridviewBI()
    {
      dtgvTraSach.Columns[0].HeaderText = "ID";
      dtgvTraSach.Columns[1].HeaderText = "Mã phiếu";
      dtgvTraSach.Columns[2].HeaderText = "Mã sách";
      dtgvTraSach.Columns[3].HeaderText = "Ngày trả sách";
      dtgvTraSach.Columns[3].DefaultCellStyle.Format = "dd/MM/yyyy";
      dtgvTraSach.Columns[4].HeaderText = "Trạng thái";
      dtgvTraSach.Columns[5].HeaderText = "Ghi chú";
      dtgvTraSach.Columns[6].HeaderText = "Phiếu phạt";
    }

    //  Binding
    private void dtgvBillInfor_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {
      int i = dtgvBillInfor.CurrentRow.Index;
      txbIDBillInfor.Text = dtgvBillInfor.Rows[i].Cells[0].Value.ToString();
      txbidBill.Text = dtgvBillInfor.Rows[i].Cells[1].Value.ToString();
      txbMaSach.Text = dtgvBillInfor.Rows[i].Cells[2].Value.ToString();
      if (dtgvBillInfor.Rows[i].Cells[3].Value != null)
      {
        DateTime dayCheckOut = (DateTime)dtgvBillInfor.Rows[i].Cells[3].Value;
        txbDateCheckOut.Text = dayCheckOut.ToString("dd/MM/yyyy");
      }
      else
      {
        txbDateCheckOut.Text = "";
      }
      txbStatus.Text = dtgvBillInfor.Rows[i].Cells[4].Value.ToString();
      if (Equals(txbStatus.Text, "Chưa trả"))
      {
        btnAdd.Enabled = true;
      }
      else
      {
        btnAdd.Enabled = false;
      }
    }
    #endregion

    #region ComboBox
    void LoadComboBoxIDDocGia()
    {
      List<BillDTO> list = billBUS.GetListPhieuMuonChuaTra();
      List<string> listID = new List<string>();
      foreach (BillDTO item in list)
      {
        listID.Add(item.idDocGia);
      }
      listID.Sort();
      cbMaDocGia.DataSource = listID.Distinct().ToList();
    }

    private void cbMaDocGia_SelectedIndexChanged(object sender, EventArgs e)
    {
      ComboBox cb = sender as ComboBox;

      if (cb.SelectedItem == null)
        return;

      //BillDTO obj = cb.SelectedItem as BillDTO;
      string obj = cb.SelectedItem as string;
      cbIDBill.DataSource = billBUS.SearchBillChuaTraByIdDocGia(obj);
      cbIDBill.DisplayMember = "id";
    }

    private void cbIDBill_SelectedIndexChanged(object sender, EventArgs e)
    {
      int id;

      ComboBox cb = sender as ComboBox;

      if (cb.SelectedItem == null)
        return;

      BillDTO b = cb.SelectedItem as BillDTO;
      id = b.id;

      List<BillDTO> listBill = billBUS.SearchByIDBill(id);
      foreach (var item in listBill)
      {
        txbIDAdmin.Text = item.idAdmin.ToString();
        txbCount.Text = item.soLuong.ToString();
        txbConLai.Text = item.Conlai.ToString();
        dttpDateCreate.Value = item.dateCheckIn;
        dtpkDateCheckOut.Value = item.dateCheckOut;
      }

      dtgvBillInfor.DataSource = billInforBUS.GetListByIDBill(id);
      GetHeaderDataGridview();
    }

    #endregion

    #region Button
    //  Trả sách
    private void btnAdd_Click(object sender, EventArgs e)
    {
      BillInforDTO bi = new BillInforDTO();
      bi.id = int.Parse(txbIDBillInfor.Text);

      DateTime dateCheckOut = dtpkDateCheckOut.Value;
      DateTime dateNow = DateTime.Now;

      TimeSpan time = dateCheckOut - dateNow;
      int countDay = time.Days;
      double countTienPhat = 0;
      if (countDay < 0)
      {
        bi.status = "Trả muộn";
        countTienPhat += constants.TienPhat;

      }
      else
      {
        bi.status = "Đã trả";
      }

      if (cbxMatSach.Checked is true)
      { 
        bi.note = "Mất sách";
        SachDTO sDTO = sachBUS.GetSachByID(txbMaSach.Text);
        countTienPhat += sDTO.money*HeSoPhat;
      }

      BillDTO b = new BillDTO();
      b.id = int.Parse(cbIDBill.Text);

      if (billInforBUS.Update(bi) && billBUS.Update(b))
      {
        MessageBox.Show("Trả sách thành công");
        int countBI = billInforBUS.GetAmountBillInforByIDBill(b.id);

        if (cbxMatSach.Checked is true)
        {
          sachBUS.UpdateSachReturnMatSach(txbMaSach.Text);
        }
        else
        {
          sachBUS.UpdateSachByReturnBillInfor(txbMaSach.Text);
        }

        InforDocGiaDTO inforDocGiaDTO = new InforDocGiaDTO();
        inforDocGiaDTO.idDocGia = cbMaDocGia.Text;
        inforDocGiaDTO.countTienPhat = countTienPhat;

        inforDocGiaBUS.UpdateInforDocGia(cbMaDocGia.Text);
        inforDocGiaBUS.UpdateTienPhatByPhieuPhat(inforDocGiaDTO);

        if (countBI > 0)
        {
          dtgvBillInfor.DataSource = billInforBUS.GetListByIDBill(b.id);
          GetHeaderDataGridview();
          txbConLai.Text = countBI.ToString();
          GetListBillInforReturn();
        }
        else
        {
          Load();
          dtgvBillInfor.DataSource = billInforBUS.GetListByIDBill(b.id);
          GetHeaderDataGridview();
        }
      }
    }

    //  Làm mới
    private void button1_Click(object sender, EventArgs e)
    {
      Load();
      ClearAll();
      btnAdd.Enabled = false;
    }
    #endregion

  }
}
