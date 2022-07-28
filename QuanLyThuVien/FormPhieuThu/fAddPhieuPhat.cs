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

namespace QuanLyThuVien.FormPhieuThu
{
  public partial class fAddPhieuPhat : Form
  {
    private InforDocGiaBUS inforDocGiaBUS = new InforDocGiaBUS();
    private PhieuPhatBUS phieuPhatBUS = new PhieuPhatBUS();
    private DocGiaBUS docGiaBUS = new DocGiaBUS();
    private BillInforBUS billInforBUS = new BillInforBUS();
    private SachBUS sachBUS = new SachBUS();
    private CommonConstants commonConstants = new CommonConstants();
    private List<BillInforDTO> listBI = new List<BillInforDTO>();

    public fAddPhieuPhat()
    {
      InitializeComponent();
      Load();
    }

    private new void Load()
    {
      ShowIDDocGiaToComboBox();
      ShowListBillInfor();
      RenameColumnDTGV();
    }

    public void ShowIDDocGiaToComboBox()
    {
      cbMaDocGia.DataSource = inforDocGiaBUS.GetListMaDocGiaTraMuonOrMatSach();
      cbMaDocGia.DisplayMember = "idDocGia";
    }

    public void RenameColumnDTGV()
    {
      dtgvListBilInfor.Columns[0].HeaderText = "ID";
      dtgvListBilInfor.Columns[1].HeaderText = "Mã phiếu";
      dtgvListBilInfor.Columns[2].HeaderText = "Mã sách";
      dtgvListBilInfor.Columns[3].HeaderText = "Ngày trả sách";
      dtgvListBilInfor.Columns[3].DefaultCellStyle.Format = "dd/MM/yyyy";
      dtgvListBilInfor.Columns[4].HeaderText = "Trạng thái";
      dtgvListBilInfor.Columns[5].HeaderText = "Ghi chú";
      dtgvListBilInfor.Columns[6].HeaderText = "Phiếu phạt";
    }

    private void cbMaDocGia_SelectedIndexChanged(object sender, EventArgs e)
    {
      ComboBox cb = sender as ComboBox;

      if (cb.SelectedItem == null)
        return;
      InforDocGiaDTO inforDocGiaDTO = cb.SelectedItem as InforDocGiaDTO;

      List<DocGiaDTO> listDG = docGiaBUS.SearchByID(inforDocGiaDTO.idDocGia);
      foreach (var item in listDG)
      {
        txbTenDocGia.Text = item.name;
      }
      
      ShowListBillInfor();
    }

    public void ShowListBillInfor()
    {
      listBI = billInforBUS.ShowListBillInforTraMuonOrMatSachByIdDocGia(cbMaDocGia.Text);
      dtgvListBilInfor.DataSource = listBI;
      double countSachTraMuon = 0;
      double countSachMat = 0;
      double countTong = 0;
      foreach (var item in listBI)
      {
        if (Equals(item.status, "Trả muộn"))
        {
          countSachTraMuon++;
        }

        if (Equals(item.note, "Mất sách"))
        {
          SachDTO sDTO = sachBUS.GetSachByID(item.idMaSach);
          countTong += sDTO.money;
          countSachMat++;
        }
      }

      countTong += (commonConstants.TienPhat * countSachTraMuon);
      txbCountSachQuaHan.Text = countSachTraMuon.ToString();
      txbCountSachMat.Text = countSachMat.ToString();
      txbTongTien.Text = countTong.ToString();
    }

    private void btnTaoPhieu_Click(object sender, EventArgs e)
    {
      PhieuPhatDTO phieuPhatDTO = new PhieuPhatDTO();
      InforDocGiaDTO inforDocGiaDTO = new InforDocGiaDTO();
      phieuPhatDTO.idAdmin = int.Parse(fLogin.GetAdminInfor.idAdmin);
      List<InforDocGiaDTO> listIFDG = inforDocGiaBUS.SearchByID(cbMaDocGia.Text);
      foreach (var item in listIFDG)
      {
        phieuPhatDTO.idInfor = item.id;
        inforDocGiaDTO.id = item.id;
      }

      phieuPhatDTO.tienPhat = double.Parse(txbTongTien.Text);
      inforDocGiaDTO.countTienPhat = double.Parse(txbTongTien.Text);
      phieuPhatDTO.ngayTaoPhieu = dtpkNgayTaoPhieu.Value;
                 
      try
      {
        phieuPhatBUS.Insert(phieuPhatDTO);
        foreach (var item in listBI)
        {
          billInforBUS.UpdatePhieuPhat(item.id);
        }
        inforDocGiaBUS.UpdateTienPhatByPhieuPhat(inforDocGiaDTO);
        inforDocGiaBUS.UpdateInforDocGia(cbMaDocGia.Text);
        MessageBox.Show("Lập phiếu phạt thành công","Thông báo");
        this.Close();
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message);
      }

    }
  }
}
