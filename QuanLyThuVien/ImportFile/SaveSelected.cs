using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThuVien.ImportFile
{
  class SaveSelected
  {
    private static SaveSelected instance;

    public static SaveSelected Instance
    {
      get { if (instance == null) instance = new SaveSelected(); return SaveSelected.instance; }
      private set { SaveSelected.instance = value; }
    }

    public void ExportExcel(DataGridView dataGridView, string path)
    {
      Microsoft.Office.Interop.Excel.Application application = new Microsoft.Office.Interop.Excel.Application();
      application.Application.Workbooks.Add(Type.Missing);
      for (int i = 0; i < dataGridView.Columns.Count; i++)
      {
        application.Cells[1, i + 1] = dataGridView.Columns[i].HeaderText;
      }

      for (int i = 0; i < dataGridView.Rows.Count; i++)
      {
        for (int j = 0; j < dataGridView.Columns.Count; j++)
        {
          application.Cells[i + 2, j + 1] = dataGridView.Rows[i].Cells[j].Value;
        }
      }

      application.Columns.AutoFit();
      application.ActiveWorkbook.SaveCopyAs(path);
      application.ActiveWorkbook.Saved = true;

    }

    public void ImportFileToSql(string typeData)
    {
      DataSet ds = new DataSet();
      DataTable dt = new DataTable();
      dt.TableName = "TypeOfDataImportToSql";
      dt.Columns.Add("TypeData");
      ds.Tables.Add(dt);

      DataRow dr = dt.NewRow();
      dr["typeData"] = typeData;
      dt.Rows.Add(dr);

      string namePath = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + "\\" + "SaveTypeDataImportToSQL" + ".xml";
      ds.WriteXml(namePath);
    }
  }
}
