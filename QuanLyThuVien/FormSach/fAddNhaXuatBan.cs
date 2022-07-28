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
  public partial class fAddNhaXuatBan : Form
  {
    NhaXuatBanBUS nhaXuatBanBUS = new NhaXuatBanBUS();

    public fAddNhaXuatBan()
    {
      InitializeComponent();
      InputNewID();
    }

    // Input new id nhà xuất bản
    void InputNewID()
    {
      string id = nhaXuatBanBUS.GetIdMaxNhaXuatBan();
      if (string.IsNullOrEmpty(id))
      {
        txbMaNXB.Text = "NXB01";
      }
      else
      {
        int number;
        string text = "NXB";
        number = Convert.ToInt32(id.Substring(3));
        number += 1;
        if (number < 10)
        {
          text += "0";
        }

        text += number.ToString();

        txbMaNXB.Text = text;
      }
    }

    private void btnAdd_Click(object sender, EventArgs e)
    {
      NhaXuatBanDTO nxb = new NhaXuatBanDTO();
      nxb.id = txbMaNXB.Text;
      nxb.name = txbTenLoaiSach.Text;
      if (string.IsNullOrEmpty(nxb.id))
      {
        MessageBox.Show("Mã nhà xuất bản không được để trống!");
        txbMaNXB.Focus();
      }
      else if (string.IsNullOrEmpty(nxb.name))
      {
        MessageBox.Show("Tên nhà xuất bản không được để trống!");
        txbTenLoaiSach.Focus();
      }
      else
      {
        try
        {
          if (nhaXuatBanBUS.Insert(nxb))
          {
            MessageBox.Show("Thêm nhà xuất bản thành công");
            this.Close();
          }
        }
        catch (Exception)
        {
          MessageBox.Show("Mã nhà xuất bản đã tồn tại!");
          txbMaNXB.Focus();
        }
      }
    }
  }
}
