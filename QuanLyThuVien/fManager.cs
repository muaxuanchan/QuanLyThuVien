using QuanLyThuVien.BUS;
using QuanLyThuVien.DTO;
using QuanLyThuVien.FormPhieuThu;
using QuanLyThuVien.FormReport;
using QuanLyThuVien.FormRule;
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
  public partial class fManager : Form
  {
    TaiKhoanBUS taiKhoanBUS = new TaiKhoanBUS();

    public fManager()
    {
      InitializeComponent();
      if (!string.IsNullOrEmpty(fLogin.GetAdminInfor.user))
      {
        ChangeAcc();
      }
    }

    void ChangeAcc()
    {
      string user = fLogin.GetAdminInfor.user;
      TaiKhoanDTO acc = taiKhoanBUS.GetAccByUser(user);
      
      if (acc.quyen == 2)
      {
        Admin.Visible = false;
        LoaiSach.Visible = false;
        NhaXuatBan.Visible = false;
        TacGia.Visible = false;
      }

      if (acc.quyen == 1)
      {
        Admin.Visible = false;
        LoaiDocGia.Visible = false;
      }
    }

    private void ribbonButton1_Click(object sender, EventArgs e)
    {
      fAdmin frm = (fAdmin)Application.OpenForms["fAdmin"];

      if (frm == null)
      {
        frm = new fAdmin();
        tabControl1.TabPages.Add(frm);
      }
      else
      {
        tabControl1.TabPages[frm].Select();
      }

    }
    private void ribbonButton2_Click(object sender, EventArgs e)
    {
      fAccountInfor frm = (fAccountInfor)Application.OpenForms["fAccountInfor"];

      if (frm == null)
      {
        frm = new fAccountInfor();
        tabControl1.TabPages.Add(frm);
      }
      else
      {
        tabControl1.TabPages[frm].Select();
      }

    }

    // Mở form quản lý đọc giả 
    private void btnDocGia_Click(object sender, EventArgs e)
    {
      fDocGia frm = (fDocGia)Application.OpenForms["fDocGia"];

      if (frm == null)
      {
        frm = new fDocGia();
        tabControl1.TabPages.Add(frm);
      }
      else
      {
        tabControl1.TabPages[frm].Select();
      }
    }

    // Mở form quản lý loại đọc giả
    private void btnLoaiDocGia_Click(object sender, EventArgs e)
    {
      fLoaiDocGia frm = (fLoaiDocGia)Application.OpenForms["fLoaiDocGia"];

      if (frm == null)
      {
        frm = new fLoaiDocGia();
        tabControl1.TabPages.Add(frm);
      }
      else
      {
        tabControl1.TabPages[frm].Select();
      }
    }

    // Mở form quản lí loại sách
    private void btnLoaiSach_Click(object sender, EventArgs e)
    {
      fLoaiSach frm = (fLoaiSach)Application.OpenForms["fLoaiSach"];

      if (frm == null)
      {
        frm = new fLoaiSach();
        tabControl1.TabPages.Add(frm);
      }
      else
      {
        tabControl1.TabPages[frm].Select();
      }
    }

    // Mở form quản lý tác giả
    private void btnTacGia_Click(object sender, EventArgs e)
    {
      fTacGia frm = (fTacGia)Application.OpenForms["fTacGia"];

      if (frm == null)
      {
        frm = new fTacGia();
        tabControl1.TabPages.Add(frm);
      }
      else
      {
        tabControl1.TabPages[frm].Select();
      }
    }

    // Mở form quản lý nhà xuất bản
    private void btnNhaXuatBan_Click(object sender, EventArgs e)
    {
      fNhaXuatBan frm = (fNhaXuatBan)Application.OpenForms["fNhaXuatBan"];

      if (frm == null)
      {
        frm = new fNhaXuatBan();
        tabControl1.TabPages.Add(frm);
      }
      else
      {
        tabControl1.TabPages[frm].Select();
      }
    }

    // Mở form quản lý sách
    private void btnSach_Click(object sender, EventArgs e)
    {
      fSach frm = (fSach)Application.OpenForms["fSach"];

      if (frm == null)
      {
        frm = new fSach();
        tabControl1.TabPages.Add(frm);
      }
      else
      {
        tabControl1.TabPages[frm].Select();
      }
    }

    // Mở form quản lí sách mượn
    private void btnSachMuon_Click(object sender, EventArgs e)
    {
      fMuonSach frm = (fMuonSach)Application.OpenForms["fMuonSach"];

      if (frm == null)
      {
        frm = new fMuonSach();
        tabControl1.TabPages.Add(frm);
      }
      else
      {
        tabControl1.TabPages[frm].Select();
      }
    }

    // Mở form quản lí sách trả
    private void btnSachTra_Click(object sender, EventArgs e)
    {
      fTraSach frm = (fTraSach)Application.OpenForms["fTraSach"];

      if (frm == null)
      {
        frm = new fTraSach();
        tabControl1.TabPages.Add(frm);
      }
      else
      {
        tabControl1.TabPages[frm].Select();
      }
    }

    private void btnThongKeSach_Click(object sender, EventArgs e)
    {
      fThongKeSach frm = (fThongKeSach)Application.OpenForms["fThongKeSach"];

      if (frm == null)
      {
        frm = new fThongKeSach();
        tabControl1.TabPages.Add(frm);
      }
      else
      {
        tabControl1.TabPages[frm].Select();
      }
    }

    private void btnLogOut_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    private void btnRules_Click(object sender, EventArgs e)
    {
      fRule frm = (fRule)Application.OpenForms["fRule"];

      if (frm == null)
      {
        frm = new fRule();
        tabControl1.TabPages.Add(frm);
      }
      else
      {
        tabControl1.TabPages[frm].Select();
      }
    }

    private void btnPhieuPhat_Click(object sender, EventArgs e)
    {
      fPhieuPhat frm = (fPhieuPhat)Application.OpenForms["fPhieuPhat"];
      if (frm == null)
      {
        frm = new fPhieuPhat();
        tabControl1.TabPages.Add(frm);
      }
      else
      {
        tabControl1.TabPages[frm].Select();
      }
    }

    private void btnPhieuThu_Click(object sender, EventArgs e)
    {
      fPhieuThu frm = (fPhieuThu)Application.OpenForms["fPhieuThu"];
      if (frm == null)
      {
        frm = new fPhieuThu();
        tabControl1.TabPages.Add(frm);
      }
      else
      {
        tabControl1.TabPages[frm].Select();
      }
    }

    private void btnInforDocGia_Click(object sender, EventArgs e)
    {
      fInforDocGia frm = (fInforDocGia)Application.OpenForms["fInforDocGia"];
      if (frm == null)
      {
        frm = new fInforDocGia();
        tabControl1.TabPages.Add(frm);
      }
      else
      {
        tabControl1.TabPages[frm].Select();
      }
    }

    private void btnSearchTongHop_Click(object sender, EventArgs e)
    {
      fSearch frm = (fSearch)Application.OpenForms["fSearch"];
      if (frm == null)
      {
        frm = new fSearch();
        tabControl1.TabPages.Add(frm);
      }
      else
      {
        tabControl1.TabPages[frm].Select();
      }
    }
  }
}
