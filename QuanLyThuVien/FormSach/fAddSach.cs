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

namespace QuanLyThuVien
{
  public partial class fAddSach : Form
  {
    SachBUS sachBUS = new SachBUS();
    LoaiSachBUS loaiSachBUS = new LoaiSachBUS();
    TacGiaBUS tacGiaBUS = new TacGiaBUS();
    NhaXuatBanBUS nxbBUS = new NhaXuatBanBUS();

    public fAddSach()
    {
      InitializeComponent();
      Load();
    }

    new void Load()
    {
      ShowLoaiSachInComboBox();
      ShowTacGiaInComboBox();
      ShowNXBInComboBox();
      InputNewID();
    }

    //  Hiển thị mã loại sách trong combobox
    void ShowLoaiSachInComboBox()
    {
      cbIDCategorySach.DataSource = loaiSachBUS.GetListLoaiSach();
      cbIDCategorySach.DisplayMember = "id";
    }

    // Input new id sach
    void InputNewID()
    {
      string id = sachBUS.GetIdMaxSach();
      if (string.IsNullOrEmpty(id))
      {
        txbMaSach.Text = "MS01";
      }
      else
      {
        int number;
        string text = "MS";
        number = Convert.ToInt32(id.Substring(2));
        number += 1;
        if (number <= 10)
        {
          text += "0";
        }

        text += number.ToString();

        txbMaSach.Text = text;
      }
    }

    //  Hiển thị mã tác giả trong combobox
    void ShowTacGiaInComboBox()
    {
      cbTacGia.DataSource = tacGiaBUS.GetListTacGia();
      cbTacGia.DisplayMember = "id";
    }

    //  Hiển thị mã nhà xuất bản trong combobox
    void ShowNXBInComboBox()
    {
      cbNXB.DataSource = nxbBUS.GetListNhaXuatBan();
      cbNXB.DisplayMember = "id";
    }

    private void btnAdd_Click(object sender, EventArgs e)
    {
      SachDTO sachDTO = new SachDTO();
      sachDTO.id = txbMaSach.Text;
      sachDTO.name = txbTenSach.Text;
      sachDTO.idCategorySach = cbIDCategorySach.Text;
      sachDTO.idTacGia = cbTacGia.Text;
      sachDTO.idNXB = cbNXB.Text;
      sachDTO.money = double.Parse(txbGiaTien.Text);
      sachDTO.soLuong = int.Parse(txbSoLuong.Text);

      if (string.IsNullOrEmpty(txbMaSach.Text))
      {
        MessageBox.Show("Mã sách không được để trống!");
        txbMaSach.Focus();
      }
      else if (string.IsNullOrEmpty(txbTenSach.Text))
      {
        MessageBox.Show("Tên sách không được để trống!");
        txbTenSach.Focus();
      }
      else if (string.IsNullOrEmpty(cbTacGia.Text))
      {
        MessageBox.Show("Tên tác giả không được để trống!");
        cbTacGia.Focus();
      }
      else if (string.IsNullOrEmpty(cbIDCategorySach.Text))
      {
        MessageBox.Show("Loại sách không được để trống!");
        cbIDCategorySach.Focus();
      }
      else if (string.IsNullOrEmpty(cbNXB.Text))
      {
        MessageBox.Show("Nhà xuất bản không được để trống!");
        cbNXB.Focus();
      }
      else if (sachDTO.money < 0)
      {
        MessageBox.Show("Giá tiền phải lớn hơn hoặc bằng 0!");
        txbGiaTien.Focus();
      }
      else if (sachDTO.soLuong < 0)
      {
        MessageBox.Show("Số lượng sách phải lớn hơn 0!");
        txbSoLuong.Focus();
      }
      else
      {
        try
        {
          if (sachBUS.Insert(sachDTO))
          {
            MessageBox.Show("Thêm sách thành công");
            this.Close();
          }
        }
        catch (Exception)
        {
          MessageBox.Show("Mã sách đã tồn tại!");
          txbMaSach.Focus();
        }
      }
    }
  }
}
