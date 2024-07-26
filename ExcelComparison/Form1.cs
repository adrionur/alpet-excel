using ClosedXML.Excel;

namespace ExcelComparison
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonGetFile_Click(object sender, EventArgs e)
        {
            Button? clickedButton = sender as Button;
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Excel files | *.xls;*.xlsx";
            ofd.Multiselect = false;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                (clickedButton?.Name == "btnExcel1" ? txtFilePath1 : txtFilePath2).Text = ofd.FileName;
            }
        }

        public static void CompareExcelColumns(string path1, string path2)
        {
            var data1 = ReadExcelColumn(path1, "L");
            var data2 = ReadExcelColumn(path2, "B");

            var commonData = data1.Intersect(data2).ToList();
            var uniqueToData1 = data1.Except(data2).ToList();
            var uniqueToData2 = data2.Except(data1).ToList();

            Console.WriteLine("Common Data:");
            commonData.ForEach(Console.WriteLine);

            Console.WriteLine("\nUnique to Data 1:");
            uniqueToData1.ForEach(Console.WriteLine);

            Console.WriteLine("\nUnique to Data 2:");
            uniqueToData2.ForEach(Console.WriteLine);
        }

        private static List<string> ReadExcelColumn(string path, string columnName)
        {
            var data = new List<string>();

            using (var workbook = new XLWorkbook(path))
            {
                var worksheet = workbook.Worksheet(1); // Get the first worksheet
                var firstColumn = worksheet.Column(columnName); // Get the A column

                foreach (var cell in firstColumn.CellsUsed())
                {
                    data.Add(cell.GetString());
                }
            }

            return data;
        }

        private void btnCompare_Click(object sender, EventArgs e)
        {
            string path1 = txtFilePath1.Text;
            string path2 = txtFilePath2.Text;
            CompareExcelColumns(path1, path2);
        }
    }
}