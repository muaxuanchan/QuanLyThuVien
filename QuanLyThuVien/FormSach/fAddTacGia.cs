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
  public partial class fAddTacGia : Form
  {
    TacGiaBUS tacGiaBUS = new TacGiaBUS();

    public fAddTacGia()
    {
      InitializeComponent();
      InputNewID();
    }

    // Input new id sach
    void InputNewID()
    {
      string id = tacGiaBUS.GetIdMaxTacGia();
      if (string.IsNullOrEmpty(id))
      {
        txbMaTG.Text = "TG01";
      }
      else
      {
        int number;
        string text = "TG";
        number = Convert.ToInt32(id.Substring(2));
        number += 1;
        if (number < 10)
        {
          text += "0";
        }

        text += number.ToString();

        txbMaTG.Text = text;
      }
    }

    private void btnAdd_Click(object sender, EventArgs e)
    {
      TacGiaDTO tg = new TacGiaDTO();
      tg.id = txbMaTG.Text;
      tg.name = txbTenLoaiSach.Text;
      if (string.IsNullOrEmpty(tg.id))
      {
        MessageBox.Show("Mã tác giả không được để trống!");
        txbMaTG.Focus();
      }
      else if (string.IsNullOrEmpty(tg.name))
      {
        MessageBox.Show("Tên tác giả không được để trống!");
        txbTenLoaiSach.Focus();
      }
      else
      {
        try
        {
          if (tacGiaBUS.Insert(tg))
          {
            MessageBox.Show("Thêm tác thành công");
            this.Close();
          }
        }
        catch (Exception)
        {
          MessageBox.Show("Mã tác giả đã tồn tại!");
          txbMaTG.Focus();
        }
      }
    }
  }
}
