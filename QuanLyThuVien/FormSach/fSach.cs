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
using System.IO;
using Excel = Microsoft.Office.Interop.Excel;
using OfficeOpenXml;
using QuanLyThuVien.ImportFile;

namespace QuanLyThuVien
{
  public partial class fSach : Form
  {
    SachBUS sachBUS = new SachBUS();
    LoaiSachBUS loaiSachBUS = new LoaiSachBUS();
    TacGiaBUS tacGiaBUS = new TacGiaBUS();
    NhaXuatBanBUS nxbBUS = new NhaXuatBanBUS();

    public fSach()
    {
      InitializeComponent();
      Load();
    }

    new void Load()
    {
      GetListSach();
      GetHeaderText();
      ShowLoaiSachInComboBox();
      ShowTacGiaInComboBox();
      ShowNXBInComboBox();
      LoadNewTextBox();
      OffProperty();

      btnUpdate.Enabled = false;
      btnDelete.Enabled = false;

      if (fLogin.GetAdminInfor.quyen == 2)
      {
        btnAdd.Enabled = false;
        btnDelete.Enabled = false;
        btnUpdate.Enabled = false;
        btnExportFile.Enabled = false;
        btnImportFileSach.Enabled = false;
      }
    }


    // Lấy list sách
    void GetListSach()
    {
      dtgvSach.DataSource = sachBUS.GetListSach();
    }

    //  Hiển thị mã loại sách trong combobox
    void ShowLoaiSachInComboBox()
    {
      cbLoaiSach.DataSource = loaiSachBUS.GetListLoaiSach();
      cbLoaiSach.DisplayMember = "id";
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

    void OnProperty()
    {
      txbTenSach.ReadOnly = false;
      txbSoLuong.ReadOnly = false;
      txbGiaTien.ReadOnly = false;
      cbLoaiSach.Enabled = true;
      cbTacGia.Enabled = true;
      cbNXB.Enabled = true;
    }

    void OffProperty()
    {
      txbTenSach.ReadOnly = true;
      txbSoLuong.ReadOnly = true;
      txbGiaTien.ReadOnly = true;
      cbLoaiSach.Enabled = false;
      cbTacGia.Enabled = false;
      cbNXB.Enabled = false;
    }

    // Đổi tên header
    void GetHeaderText()
    {
      dtgvSach.Columns[0].HeaderText = "Mã sách";
      dtgvSach.Columns[1].HeaderText = "Tên sách";
      dtgvSach.Columns[2].HeaderText = "Mã loại sách";
      dtgvSach.Columns[3].HeaderText = "Mã tác giả";
      dtgvSach.Columns[4].HeaderText = "Mã nhà xuất bản";
      dtgvSach.Columns[5].HeaderText = "Giá tiền";
      dtgvSach.Columns[6].HeaderText = "Số lượng";
      dtgvSach.Columns[7].HeaderText = "Còn Lại";
    }

    void LoadNewTextBox()
    {
      txbMaSach.Text = "";
      txbTenSach.Text = "";
      txbGiaTien.Text = "";
      txbSoLuong.Text = "";
      txbConLai.Text = "";
      cbLoaiSach.Text = "";
      cbTacGia.Text = "";
      cbNXB.Text = "";
    }

    // Thêm
    private void btnAdd_Click(object sender, EventArgs e)
    {
      fAddSach f = new fAddSach();
      f.ShowDialog();
    }

    //  Làm mới
    private void btnLoad_Click(object sender, EventArgs e)
    {
      Load();
    }

    // Binding
    private void dtgvSach_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {
      int i = dtgvSach.CurrentRow.Index;
      txbMaSach.Text = dtgvSach.Rows[i].Cells[0].Value.ToString();
      txbTenSach.Text = dtgvSach.Rows[i].Cells[1].Value.ToString();
      cbLoaiSach.Text = dtgvSach.Rows[i].Cells[2].Value.ToString();
      cbTacGia.Text = dtgvSach.Rows[i].Cells[3].Value.ToString();
      cbNXB.Text = dtgvSach.Rows[i].Cells[4].Value.ToString();
      txbGiaTien.Text = dtgvSach.Rows[i].Cells[5].Value.ToString();
      txbSoLuong.Text = dtgvSach.Rows[i].Cells[6].Value.ToString();
      txbConLai.Text = dtgvSach.Rows[i].Cells[7].Value.ToString();

      btnUpdate.Enabled = true;
      btnDelete.Enabled = true;

      OnProperty();
    }

    //  Tìm kiếm
    private void btnSearch_Click(object sender, EventArgs e)
    {
      if (rdbID.Checked == true)
      {
        string id = txnSearch.Text;
        dtgvSach.DataSource = sachBUS.SearchByID(id);
      }
      else if (rdbName.Checked == true)
      {
        string name = txnSearch.Text;
        dtgvSach.DataSource = sachBUS.SearchByName(name);
      }
    }

    private void btnDelete_Click(object sender, EventArgs e)
    {
      try
      {
        string id = txbMaSach.Text;
        if (sachBUS.Delete(id))
        {
          MessageBox.Show("Xóa sách thành công");
          Load();
        }
      }
      catch (Exception)
      {
        MessageBox.Show("Không thể xóa sách này này!!!");
      }
    }

    private void btnUpdate_Click(object sender, EventArgs e)
    {
      SachDTO sachDTO = new SachDTO();
      sachDTO.id = txbMaSach.Text;
      sachDTO.name = txbTenSach.Text;
      sachDTO.idCategorySach = cbLoaiSach.Text;
      sachDTO.idTacGia = cbTacGia.Text;
      sachDTO.idNXB = cbNXB.Text;
      sachDTO.money = double.Parse(txbGiaTien.Text);
      sachDTO.soLuong = int.Parse(txbSoLuong.Text);
      sachDTO.conLai = int.Parse(txbConLai.Text);

      if (string.IsNullOrEmpty(txbTenSach.Text))
      {
        MessageBox.Show("Tên sách không được để trống!!");
        txbTenSach.Focus();
      }
      else if (string.IsNullOrEmpty(cbLoaiSach.Text))
      {
        MessageBox.Show("Loại sách không được để trống!!");
        cbLoaiSach.Focus();
      }
      else if (string.IsNullOrEmpty(cbTacGia.Text))
      {
        MessageBox.Show("Tác giả không được để trống!!");
        cbTacGia.Focus();
      }
      else if (string.IsNullOrEmpty(cbNXB.Text))
      {
        MessageBox.Show("Nhà xuất bản không được để trống!!");
        cbNXB.Focus();
      }
      else if (sachDTO.money < 0)
      {
        MessageBox.Show("Giá tiền phải lớn hơn 0!");
        txbGiaTien.Focus();
      }
      else if (sachDTO.soLuong < sachDTO.conLai)
      {
        MessageBox.Show("Số lượng không hợp lý!!!");
        txbSoLuong.Focus();
      }
      else
      {
        if (sachBUS.Update(sachDTO))
        {
          MessageBox.Show("Sửa thông tin thành công");
          Load();
        }
      }
    }

    #region Export/Import file excel

    // xuất dữ liệu ra excel
    private void button1_Click(object sender, EventArgs e)
    {
      SaveFileDialog saveFileDialog = new SaveFileDialog();
      saveFileDialog.Title = "Export Excel";
      saveFileDialog.Filter = "Excel (*.xlsx)|*.xlsx|Excel 2003 (*.xls)|*.xls";
      if (saveFileDialog.ShowDialog() == DialogResult.OK)
      {
        try
        {
          SaveSelected.Instance.ExportExcel(dtgvSach, saveFileDialog.FileName);
          MessageBox.Show("Xuất file thành công!");
        }
        catch (Exception ex)
        {
          MessageBox.Show("Xuất file không thành công! \n" + ex.Message);
        }
      }
    }

    // open dialog Import excel
    private void btnImportFile_Click(object sender, EventArgs e)
    {
      SaveSelected.Instance.ImportFileToSql(btnImportFileSach.Name);
      fImportFileExcel frm = new fImportFileExcel();
      frm.ShowDialog();
    }

    #endregion
  }
}

