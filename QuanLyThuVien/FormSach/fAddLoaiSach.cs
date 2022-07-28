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
  public partial class fAddLoaiSach : Form
  {
    LoaiSachBUS loaiSachBUS = new LoaiSachBUS();

    public fAddLoaiSach()
    {
      InitializeComponent();
      InputNewID();
    }

    // Input new id sach
    void InputNewID()
    {
      string id = loaiSachBUS.GetIdMaxLoaiSach();
      if (string.IsNullOrEmpty(id))
      {
        txbMaLoaiSach.Text = "LS01";
      }
      else
      {
        int number;
        string text = "LS";
        number = Convert.ToInt32(id.Substring(2));
        number += 1;
        if (number < 10)
        {
          text += "0";
        }

        text += number.ToString();

        txbMaLoaiSach.Text = text;
      }
    }

    private void btnAdd_Click(object sender, EventArgs e)
    {
      LoaiSachDTO ls = new LoaiSachDTO();
      ls.id = txbMaLoaiSach.Text;
      ls.name = txbTenLoaiSach.Text;
      if (string.IsNullOrEmpty(ls.id))
      {
        MessageBox.Show("Mã loại sách không được để trống!");
        txbMaLoaiSach.Focus();
      }
      else if (string.IsNullOrEmpty(ls.name))
      {
        MessageBox.Show("Tên loại sách không được để trống!");
        txbTenLoaiSach.Focus();
      }
      else
      {
        try
        {
          if (loaiSachBUS.Insert(ls))
          {
            MessageBox.Show("Thêm thành công");
            this.Close();
          }
        }
        catch (Exception)
        {
          MessageBox.Show("Mã loại độc giả đã tồn tại!");
          txbMaLoaiSach.Focus();
        }
      }
    }
  }
}
