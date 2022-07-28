using OfficeOpenXml;
using QuanLyThuVien.BUS;
using QuanLyThuVien.Const;
using QuanLyThuVien.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThuVien
{
  public partial class fImportFileExcel : Form
  {
    private SachBUS sachBUS = new SachBUS();
    private DocGiaBUS docGiaBUS = new DocGiaBUS();

    public fImportFileExcel()
    {
      InitializeComponent();
      Load();
    }

    private new void Load()
    {
      string typeData = LoadDataSaved();
      if (Equals(typeData, ProgramType.btnImportFileSach.ToString()))
      {
        this.Text = "Import file sách ";
      }
      else
      {
        this.Text = "Import file độc giả";
      }
    }

    private string LoadDataSaved()
    {
      DataSet ds = new DataSet();
      string path = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + "\\" + "SaveTypeDataImportToSQL" + ".xml";
      ds.ReadXml(path);
      string data = ds.Tables["TypeOfDataImportToSql"].Rows[0][0].ToString();
      return data;
    }

    // Input new id sach
    private string GetInputNewID()
    {
      string typeData = LoadDataSaved();
      string text = "";
      int number;
      if (Equals(typeData, ProgramType.btnImportFileDocGia.ToString()))
      {
        string id = docGiaBUS.GetIdMaxDocGia();

        if (string.IsNullOrEmpty(id))
        {
          text = "DG01";
        }
        else
        {
          text = "DG";
          number = Convert.ToInt32(id.Substring(2));
          number += 1;
          if (number < 10)
          {
            text += "0";
          }

          text += number.ToString();
        }
      }
      else if (Equals(typeData, ProgramType.btnImportFileSach.ToString()))
      {
        string id = sachBUS.GetIdMaxSach();

        if (string.IsNullOrEmpty(id))
        {
          return "MS01";
        }
        else
        {
          text = "MS";
          number = Convert.ToInt32(id.Substring(2));
          number += 1;
          if (number < 10)
          {
            text += "0";
          }

          text += number.ToString();
        }
      }

      return text;
    }

    // Import file excel to datagridview
    private void ImportExcelToDataGridView(string path)
    {
      using (ExcelPackage excelPackage = new ExcelPackage(new FileInfo(path)))
      {
        ExcelWorksheet excelWorkSheet = excelPackage.Workbook.Worksheets[0];
        DataTable dataTable = new DataTable();
        for (int i = excelWorkSheet.Dimension.Start.Column; i < excelWorkSheet.Dimension.End.Column + 1; i++)
        {
          dataTable.Columns.Add(excelWorkSheet.Cells[1, i].Value.ToString());
        }

        for (int i = excelWorkSheet.Dimension.Start.Row + 1; i < excelWorkSheet.Dimension.End.Row + 1; i++)
        {
          List<string> list = new List<string>();
          for (int j = excelWorkSheet.Dimension.Start.Column; j < excelWorkSheet.Dimension.End.Column + 1; j++)
          {
            if (excelWorkSheet.Cells[i, j].Value.ToString() != "null")
            {
              list.Add(excelWorkSheet.Cells[i, j].Value.ToString());
            }
            else
            {
              list.Add("");
            }
          }

          dataTable.Rows.Add(list.ToArray());
        }

        dtgvImportFile.DataSource = dataTable;
      }
    }

    //Open file excel
    private void btnOpenFile_Click(object sender, EventArgs e)
    {
      OpenFileDialog openFileDialog = new OpenFileDialog();
      openFileDialog.Title = "Import Excel";
      openFileDialog.Filter = "Excel (*.xlsx)|*.xlsx|Excel 2003 (*.xls)|*.xls";
      if (openFileDialog.ShowDialog() == DialogResult.OK)
      {
        try
        {
          ImportExcelToDataGridView(openFileDialog.FileName);
          txbFilePath.Text = openFileDialog.FileName;
          MessageBox.Show("Nhập file thành công!");
        }
        catch (Exception ex)
        {
          MessageBox.Show("Nhập file không thành công! \n" + ex.Message);
        }
      }
    }

    #region Import file excel to sql

    // Import file excel to sql
    private void ImportExcelToSql()
    {
      try
      {
        int i = 0;
        int j = 0;
        int countRows = dtgvImportFile.Rows.Count;

        string typeData = LoadDataSaved();

        if (Equals(typeData, ProgramType.btnImportFileSach.ToString()))
        {
          SachDTO sach = new SachDTO();

          while (countRows > 0)
          {
            sach.id = GetInputNewID();
            sach.name = dtgvImportFile.Rows[i].Cells[j + 1].Value.ToString().Trim();
            sach.idCategorySach = dtgvImportFile.Rows[i].Cells[j + 2].Value.ToString().Trim();
            sach.idTacGia = dtgvImportFile.Rows[i].Cells[j + 3].Value.ToString().Trim();
            sach.idNXB = dtgvImportFile.Rows[i].Cells[j + 4].Value.ToString().Trim();
            sach.money = double.Parse(dtgvImportFile.Rows[i].Cells[j + 5].Value.ToString().Trim());
            sach.soLuong = int.Parse(dtgvImportFile.Rows[i].Cells[j + 6].Value.ToString().Trim());

            if (sachBUS.Insert(sach))
            {
              i++;
              countRows--;
            }
          }
        }
        else if (Equals(typeData, ProgramType.btnImportFileDocGia.ToString()))
        {
          DocGiaDTO docGiaDTO = new DocGiaDTO();

          while (countRows > 0)
          {
            docGiaDTO.id = GetInputNewID();
            docGiaDTO.name = dtgvImportFile.Rows[i].Cells[j + 1].Value.ToString().Trim();
            docGiaDTO.idCategoryDG = dtgvImportFile.Rows[i].Cells[j + 2].Value.ToString().Trim();
            docGiaDTO.ngaySinh = DateTime.ParseExact(dtgvImportFile.Rows[i].Cells[j + 3].Value.ToString(), "dd/MM/yyyy", null);
            docGiaDTO.phoneNumber = dtgvImportFile.Rows[i].Cells[j + 4].Value.ToString().Trim();
            docGiaDTO.diaChi = dtgvImportFile.Rows[i].Cells[j + 5].Value.ToString().Trim();
            docGiaDTO.note = dtgvImportFile.Rows[i].Cells[j + 6].Value.ToString().Trim();

            if (docGiaBUS.Insert(docGiaDTO))
            {
              i++;
              countRows--;
            }
          }
        }

        MessageBox.Show("Import dữ liệu thành công");
        this.Close();
      }
      catch (Exception ex)
      {
        MessageBox.Show("Import dữ liệu thất bại" + Environment.NewLine + ex.Message);
      }
    }

    // execute import file excel to sql
    private void btnImportFile_Click(object sender, EventArgs e)
    {
      ImportExcelToSql();
    }

    #endregion
  }
}
