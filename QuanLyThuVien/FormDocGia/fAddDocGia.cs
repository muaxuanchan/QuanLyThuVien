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
  public partial class fAddDocGia : Form
  {

    DocGiaBUS docGiaBUS = new DocGiaBUS();
    LoaiDocGiaBUS loaiDocGiaBUS = new LoaiDocGiaBUS();
    CommonConstants constants = new CommonConstants();

    public fAddDocGia()
    {
      InitializeComponent();
      Load();
    }

    new void Load()
    {
      LoadListLoaiDocGia();
      InputNewID();
    }

    void LoadListLoaiDocGia()
    {
      cbLoaiDG.DataSource = loaiDocGiaBUS.GetListTypeDocGia();
      cbLoaiDG.DisplayMember = "id";
    }

    // Input new id đọc giả
    void InputNewID()
    {
      string id = docGiaBUS.GetIdMaxDocGia();
      if (string.IsNullOrEmpty(id))
      {
        txbMaDG.Text = "DG01";
      }
      else
      {
        int number;
        string text = "DG";
        number = Convert.ToInt32(id.Substring(2));
        number += 1;
        if (number < 10)
        {
          text += "0";
        }

        text += number.ToString();

        txbMaDG.Text = text;
      }
    }

    //  Thêm đọc giả
    private void btnAdd_Click(object sender, EventArgs e)
    {
      DocGiaDTO docGia = new DocGiaDTO();
      docGia.id = txbMaDG.Text;
      docGia.name = txbTenDG.Text;
      docGia.idCategoryDG = cbLoaiDG.Text;
      docGia.ngaySinh = dtpNgaySinh.Value;
      docGia.diaChi = txbDiaChi.Text;
      docGia.phoneNumber = txbPhoneNumber.Text;
      docGia.note = txbNote.Text;

      if (string.IsNullOrEmpty(txbTenDG.Text))
      {
        MessageBox.Show("Tên độc giả không được để trống!");
        txbTenDG.Focus();
      }
      else if (string.IsNullOrEmpty(txbDiaChi.Text))
      {
        MessageBox.Show("Địa chỉ không được để trống!");
        txbDiaChi.Focus();
      }
      else if (string.IsNullOrEmpty(txbPhoneNumber.Text))
      {
        MessageBox.Show("Số điện thoại không được để trống!");
        txbPhoneNumber.Focus();
      }
      else if ((DateTime.Now.Year - docGia.ngaySinh.Year) < constants.TuoiMuonSach)
      {
        MessageBox.Show("Tuổi tối thiểu được đăng kí thẻ mượn sách là: " + constants.TuoiMuonSach);
        dtpNgaySinh.Focus();
      }
      else
      {
        if (docGiaBUS.Insert(docGia))
        {
          MessageBox.Show("Thêm độc giả thành công");
          this.Close();
        }
      }
    }
  }
}
