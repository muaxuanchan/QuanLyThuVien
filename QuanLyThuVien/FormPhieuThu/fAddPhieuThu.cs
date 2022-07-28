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
  public partial class fAddPhieuThu : Form
  {
    PhieuThuBUS phieuThuBUS = new PhieuThuBUS();
    InforDocGiaBUS inforDocGiaBUS = new InforDocGiaBUS();
    DocGiaBUS docGiaBUS = new DocGiaBUS();

    private double tienPhat;

    public fAddPhieuThu()
    {
      InitializeComponent();
      Load();
    }

    private new void Load()
    {
      cbMaDocGia.DataSource = inforDocGiaBUS.GetListMaDocGiaQuaHan();
      cbMaDocGia.DisplayMember = "idDocGia";
    }
    
    //  Execute in dư
    private void button1_Click(object sender, EventArgs e)
    {
      btnTaoPhieu.Enabled = true;
      double tongTienPhat = double.Parse(txbTongTienPhat.Text);
      double tienThu = (double)nudTienThu.Value;
      double conLai = tongTienPhat - tienThu;
      if (conLai >= 0)
      {
        txbConLai.Text = conLai.ToString();
        tienPhat = tienThu;
      }
      else if (conLai < 0)
      {
        txbConLai.Text = "0";
        tienPhat = tongTienPhat;
      }
    }

    private void cbMaDocGia_SelectedIndexChanged(object sender, EventArgs e)
    {
      string id = null;

      ComboBox cb = sender as ComboBox;

      if (cb.SelectedItem == null)
        return;
      InforDocGiaDTO  inforDocGia = cb.SelectedItem as InforDocGiaDTO;
      id = inforDocGia.idDocGia;
      
      List<DocGiaDTO> listDG = docGiaBUS.SearchByID(id);
      foreach (var item in listDG)
      {
        txbTenDocGia.Text = item.name;
      }

      List<InforDocGiaDTO> listIF = inforDocGiaBUS.SearchByID(id);
      foreach (var item in listIF)
      {
        txbTongTienPhat.Text = item.countTienPhat.ToString();
      }
    }

    //  Làm mới
    private void btnRefresh_Click(object sender, EventArgs e)
    {
      nudTienThu.Value = 0;
      txbConLai.Text = "";
      btnTaoPhieu.Enabled = false;
    }

    private void btnTaoPhieu_Click(object sender, EventArgs e)
    {
      PhieuThuDTO phieuThuDTO = new PhieuThuDTO();
      InforDocGiaDTO inforDocGiaDTO = new InforDocGiaDTO();
      phieuThuDTO.idAdmin = int.Parse(fLogin.GetAdminInfor.idAdmin);
      phieuThuDTO.tienThu = tienPhat;
      phieuThuDTO.ngayTaoPhieu = DateTime.Now;

      List<InforDocGiaDTO> listIF = inforDocGiaBUS.SearchByID(cbMaDocGia.Text);
      foreach (var item in listIF)
      {
        phieuThuDTO.idInfor = item.id;
        inforDocGiaDTO.id = item.id;
      }

      inforDocGiaDTO.countTienPhat = double.Parse(txbConLai.Text); 

      try
      {
        phieuThuBUS.Insert(phieuThuDTO);
        inforDocGiaBUS.UpdateTienPhatByPhieuThu(inforDocGiaDTO);
        MessageBox.Show("Lập phiếu thu thành công", "Thông báo");
        this.Close();
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message);
        
      }
    }
  }
}
