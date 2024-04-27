using OfficeOpenXml;
using QLSV.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.IO;
using System.Windows.Forms;

namespace QLSV
{
    public class ExcelFuntion
    {
        public void ToExcel(DataGridView dataGridView1, string fileName, string workSheetName)
        {
            
            Microsoft.Office.Interop.Excel.Application excel;
            Microsoft.Office.Interop.Excel.Workbook workbook;
            Microsoft.Office.Interop.Excel.Worksheet worksheet;
            try
            {
                
                excel = new Microsoft.Office.Interop.Excel.Application();
                excel.Visible = false;
                excel.DisplayAlerts = false;
                
                workbook = excel.Workbooks.Add(Type.Missing);
                worksheet = (Microsoft.Office.Interop.Excel.Worksheet)workbook.Sheets["Sheet1"];
                
                worksheet.Name = workSheetName;

                
                for (int i = 0; i < dataGridView1.ColumnCount; i++)
                {
                    worksheet.Cells[1, i + 1] = dataGridView1.Columns[i].HeaderText;
                    worksheet.Cells[1, i + 1].Interior.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Green); 
                }
                
                for (int i = 0; i < dataGridView1.RowCount; i++)
                {
                    for (int j = 0; j < dataGridView1.ColumnCount; j++)
                    {
                        if (dataGridView1.Rows[i].Cells[j].Value == null) worksheet.Cells[i + 2, j + 1] = "";
                        else worksheet.Cells[i + 2, j + 1] = dataGridView1.Rows[i].Cells[j].Value.ToString();
                        worksheet.Cells[i + 1, j + 1].Borders.LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous; 
                        worksheet.Cells[i + 1, j + 1].Borders.Weight = Microsoft.Office.Interop.Excel.XlBorderWeight.xlThin; 

                    }
                }
                
                workbook.SaveAs(fileName);
               
                workbook.Close();
                excel.Quit();
                MessageBox.Show("Xuất dữ liệu ra Excel thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                workbook = null;
                worksheet = null;
            }
        }
    
        public DataTable ReadExcelToDataTable(string filePath)
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            DataTable dataTable = new DataTable();

            using (var package = new ExcelPackage(new System.IO.FileInfo(filePath)))
            {
                ExcelWorksheet worksheet = package.Workbook.Worksheets[0]; 

                foreach (var cell in worksheet.Cells[1, 1, worksheet.Dimension.End.Row, worksheet.Dimension.End.Column])
                {
                    if (cell.Start.Row == 1)
                    {
                        
                        dataTable.Columns.Add(cell.Text);
                    }
                    else
                    {
                        if (cell.Start.Column == 1)
                        {
                            
                            DataRow newRow = dataTable.NewRow();
                            dataTable.Rows.Add(newRow);
                        }
                        
                        dataTable.Rows[dataTable.Rows.Count - 1][cell.Start.Column - 1] = cell.Text;
                    }
                }
            }

            return dataTable;
        }
    }
}
