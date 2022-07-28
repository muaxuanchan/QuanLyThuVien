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

namespace QuanLyThuVien.FormMuonTraSach
{
  public partial class fAddPhieuMuon : Form
  {
    TaiKhoanBUS taiKhoanBUS = new TaiKhoanBUS();
    BillBUS billBUS = new BillBUS();
    BillInforBUS billInforBUS = new BillInforBUS();
    DocGiaBUS docGiaBUS = new DocGiaBUS();
    SachBUS sachBUS = new SachBUS();
    DataTable dt = new DataTable();
    CommonConstants rule = new CommonConstants();
    InforDocGiaBUS inforDocGiaBUS = new InforDocGiaBUS();

    private int count;
    private int index;

    public fAddPhieuMuon()
    {
      InitializeComponent();
      //this.ControlBox = false;
      Load();
      btnAddPhieu.Enabled = false;
      if (string.IsNullOrEmpty(cbIDDocGia.Text))
      {
        btnAdd.Enabled = false;
        btnDelete.Enabled = false;
      }
      else
      {
        btnAdd.Enabled = true;
        btnDelete.Enabled = true;
      }
    }

    new void Load()
    {
      GetInforPhieuMuon();
      LoadComboBoxLoaiDocGia();
      LoadComboBoxMaSach();
      LoadDataTable();

    }

    void LoadDataTable()
    {
      dt.Columns.Add("Mã sách");
      dt.Columns.Add("Tên sách");
      dt.Columns.Add("Loại sách");
      dt.Columns.Add("Tác giả");
      dt.Columns.Add("Nhà xuất bản");
      dt.Columns.Add("Giá tiền");

      dtgvSachMuon.DataSource = dt;
    }

    // Hiển thị thông tin phiếu mượn
    void GetInforPhieuMuon()
    {
      int idMax = billBUS.GetIdBillMax() + 1;
      txbIDBill.Text = idMax.ToString();
      if (!string.IsNullOrEmpty(fLogin.GetAdminInfor.user))
      {
        TaiKhoanDTO acc = taiKhoanBUS.GetAccByUser(fLogin.GetAdminInfor.user);
        txbIDAdmin.Text = acc.id.ToString();
      }
    }

    // Mã đọc giả => Combobox
    void LoadComboBoxLoaiDocGia()
    {
      cbIDDocGia.DataSource = docGiaBUS.GetListDocGia();
      cbIDDocGia.DisplayMember = "id";
    }

    private void cbIDDocGia_SelectedIndexChanged(object sender, EventArgs e)
    {
      string id = null;

      ComboBox cb = sender as ComboBox;

      if (cb.SelectedItem == null)
        return;
      DocGiaDTO dg = cb.SelectedItem as DocGiaDTO;
      id = dg.id;

      List<DocGiaDTO> listDG = docGiaBUS.SearchByID(id);
      foreach (var item in listDG)
      {
        txbName.Text = item.name.ToString();
        dttpHanThe.Value = item.ngayHetHan;
      }
    }

    //  Mã sách => combobox
    void LoadComboBoxMaSach()
    {
      cbMaSach.DataSource = sachBUS.GetListSachDifferentZero();
      cbMaSach.DisplayMember = "id";
    }

    private void cbMaSach_SelectedIndexChanged(object sender, EventArgs e)
    {
      string id = null;

      ComboBox cb = sender as ComboBox;

      if (cb.SelectedItem == null)
        return;
      SachDTO s = cb.SelectedItem as SachDTO;
      id = s.id;

      List<SachDTO> listS = sachBUS.SearchByID(id);
      foreach (var item in listS)
      {
        txbTenSach.Text = item.name;
      }
    }

    //  Thêm
    private void btnAdd_Click(object sender, EventArgs e)
    {
      btnAddPhieu.Enabled = true;

      SachDTO s = new SachDTO();
      List<SachDTO> listS = sachBUS.SearchByID(cbMaSach.Text);
      foreach (var item in listS)
      {
        s = item;
        dt.Rows.Add(s.id, s.name, s.idCategorySach, s.idTacGia, s.idNXB, s.money);
      }

      count = dt.Rows.Count;
      txbCount.Text = count.ToString();
    }

    //  Xóa
    private void btnDelete_Click(object sender, EventArgs e)
    {
      try
      {
        index = dtgvSachMuon.CurrentCell.RowIndex;
        dt.Rows.RemoveAt(index);

        count = dt.Rows.Count;
        txbCount.Text = count.ToString();
        if (count == 0 || string.IsNullOrEmpty(txbCount.Text))
        {
          btnAddPhieu.Enabled = false;
        }
      }
      catch (Exception)
      {
        
        return;
      }
    }

    //  Hủy
    private void btnExit_Click(object sender, EventArgs e)
    {
      MessageBox.Show("Hủy phiếu thành công");
      this.Close();
    }

    //  Lập phiếu mượn
    private void btnAddPhieu_Click(object sender, EventArgs e)
    {
      int sachMuonMax = rule.MuonToiDa;
      int countSM = billBUS.GetSoLuongSachMuon(cbIDDocGia.Text);
      int conLai = sachMuonMax - countSM;

      BillInforDTO bi = new BillInforDTO();
      BillDTO bill = new BillDTO();
      bill.id = int.Parse(txbIDBill.Text);
      bill.idAdmin = int.Parse(txbIDAdmin.Text);
      bill.idDocGia = cbIDDocGia.Text;
      bill.soLuong = int.Parse(txbCount.Text);
      bill.dateCheckIn = dttpDateCreate.Value;

      DateTime ngayHenTra = dttpDateCreate.Value;
      DateTime hanTheDocGia = dttpHanThe.Value;
      TimeSpan time = hanTheDocGia - ngayHenTra;

      if (bill.soLuong > conLai)
      {
        string message = "Độc giả " + cbIDDocGia.Text.Trim() + " đã mượn " + countSM + "/" + sachMuonMax + " cuốn sách!!!";
        string message3 = "";
        if (conLai > 0)
        {
          message3 = "Số cuốn sách có thể mượn là: " + conLai;
        }
        else
        {
          message3 = "Số cuốn sách có thể mượn là: 0";
        }  
        
        MessageBox.Show(message + Environment.NewLine + message3, "Thông báo");
        return;
      }

      if (time.Days < 0)
      {
        string message = "Độc giả " + cbIDDocGia.Text.Trim() + " đã hết hạn thẻ đọc giả!!!";
        MessageBox.Show(message, "Thông báo");
        return;
      }

      if (billBUS.Insert(bill))
      {
        inforDocGiaBUS.UpdateInforDocGia(cbIDDocGia.Text);
        for (int i = 0; i < dtgvSachMuon.Rows.Count; i++)
        {
          bi.idBill = int.Parse(txbIDBill.Text);
          bi.idMaSach = dtgvSachMuon.Rows[i].Cells["Mã sách"].Value.ToString();
          billInforBUS.Insert(bi);
          sachBUS.UpdateByAddBillInfor(bi.idMaSach);
        }

        MessageBox.Show("Lập phiếu thành công");
      }

      this.Close();
    }
  }
}

