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
  public partial class fAddLoaiDocGia : Form
  {
    LoaiDocGiaBUS loaiDocGiaBUS = new LoaiDocGiaBUS();

    public fAddLoaiDocGia()
    {
      InitializeComponent();
      InputNewID();
    }

    // Input new id loại đọc giả
    void InputNewID()
    {
      string id = loaiDocGiaBUS.GetIdMaxLoaiDocGia();
      if (string.IsNullOrEmpty(id))
      {
        txbMaLoaiDocGia.Text = "LDG01";
      }
      else
      {
        int number;
        string text = "LDG";
        number = Convert.ToInt32(id.Substring(3));
        number += 1;
        if (number < 10)
        {
          text += "0";
        }

        text += number.ToString();

        txbMaLoaiDocGia.Text = text;
      }
    }

    //  Thêm loại đọc giả
    private void btnAdd_Click(object sender, EventArgs e)
    {
      LoaiDocGiaDTO loaiDocGia = new LoaiDocGiaDTO();
      loaiDocGia.id = txbMaLoaiDocGia.Text;
      loaiDocGia.name = txbTenLoaiDocGia.Text;
      if (string.IsNullOrEmpty(loaiDocGia.id))
      {
        MessageBox.Show("Mã loại độc giả không được để trống!");
        txbMaLoaiDocGia.Focus();
      }
      else if (string.IsNullOrEmpty(loaiDocGia.name))
      {
        MessageBox.Show("Tên loại độc giả không được để trống!");
        txbTenLoaiDocGia.Focus();
      }
      else
      {
        try
        {
          if (loaiDocGiaBUS.InsertLoaiDocGia(loaiDocGia))
          {
            MessageBox.Show("Thêm thành công");
            this.Close();
          }
        }
        catch (Exception)
        {
          MessageBox.Show("Mã loại độc giả đã tồn tại!");
          txbMaLoaiDocGia.Focus();
        }
      }
      

    }
  }
}
