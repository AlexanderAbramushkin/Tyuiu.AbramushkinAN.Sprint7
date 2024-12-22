using System.Diagnostics.Metrics;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;
using Tyuiu.AbramushkinAN.Sprint7.Project.V4.Lib;

namespace Tyuiu.AbramushkinAN.Sprint7.Project.V4
{
    public partial class FormMain_AAN : Form
    {
        DataService ds = new DataService();
        public FormMain_AAN()
        {
            InitializeComponent();
            dataGridViewOutData_AAN.ColumnHeaderMouseClick += dataGridViewOutData_AAN_ColumnHeaderMouseClick;
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

            
                FormAddBook_AAN formadd = new FormAddBook_AAN();
                List<Library> books = ds.GetLibraries();
                dataGridViewOutData_AAN.AutoGenerateColumns = true;
                dataGridViewOutData_AAN.DataSource = books;
                dataGridViewOutData_AAN.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dataGridViewOutData_AAN.Columns[0].HeaderText = "�����";
                dataGridViewOutData_AAN.Columns[1].HeaderText = "�������� ������������";
                dataGridViewOutData_AAN.Columns[2].HeaderText = "��� ���������";
                dataGridViewOutData_AAN.Columns[3].HeaderText = "���������";
                dataGridViewOutData_AAN.Columns[4].HeaderText = "����� �� �������?";
                dataGridViewOutData_AAN.Columns[5].HeaderText = "���������";


                chartYearOfPublication_AAN.Series.Clear();
                chartPriceOfBook_AAN.Series.Clear();

                foreach (var book in books)
                {
                    var seriesYear = chartYearOfPublication_AAN.Series.Add(book.Title);
                    seriesYear.Points.AddXY(book.Title, book.Year);
                    var seriesPrice = chartPriceOfBook_AAN.Series.Add(book.Title);
                    seriesPrice.Points.AddXY(book.Title, book.Price);
                }

                chartYearOfPublication_AAN.ChartAreas[0].AxisX.Title = "�������� �����";
                chartYearOfPublication_AAN.ChartAreas[0].AxisY.Title = "��� �������";
                chartPriceOfBook_AAN.ChartAreas[0].AxisX.Title = "�������� �����";
                chartPriceOfBook_AAN.ChartAreas[0].AxisY.Title = "����";
            
            
        }
        private void buttonUpdate_AAN_Click(object sender, EventArgs e)
        {
            
                List<Library> books = ds.GetLibraries();
                dataGridViewOutData_AAN.AutoGenerateColumns = true;
                dataGridViewOutData_AAN.DataSource = books;
                dataGridViewOutData_AAN.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

                chartYearOfPublication_AAN.Series.Clear();
                chartPriceOfBook_AAN.Series.Clear();


                foreach (var book in books)
                {
                    var seriesYear = chartYearOfPublication_AAN.Series.Add(book.Title);
                    seriesYear.Points.AddXY(book.Title, book.Year);
                    var seriesPrice = chartPriceOfBook_AAN.Series.Add(book.Title);
                    seriesPrice.Points.AddXY(book.Title, book.Price);
                }

                chartYearOfPublication_AAN.ChartAreas[0].AxisX.Title = "�������� �����";
                chartYearOfPublication_AAN.ChartAreas[0].AxisY.Title = "��� �������";
                chartPriceOfBook_AAN.ChartAreas[0].AxisX.Title = "�������� �����";
                chartPriceOfBook_AAN.ChartAreas[0].AxisY.Title = "����";
            
        }



        private DataGridView GetDataGridViewOutput()
        {
            return dataGridViewOutData_AAN;
        }


        private void dataGridViewOutData_AAN_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                int columnIndex = e.ColumnIndex;
                List<Library> books = ds.SortLibrary(columnIndex);
                dataGridViewOutData_AAN.DataSource = books;
                chartYearOfPublication_AAN.Series.Clear();
                chartPriceOfBook_AAN.Series.Clear();

                foreach (var book in books)
                {
                    var seriesYear = chartYearOfPublication_AAN.Series.Add(book.Title);
                    seriesYear.Points.AddXY(book.Title, book.Year);
                    var seriesPrice = chartPriceOfBook_AAN.Series.Add(book.Title);
                    seriesPrice.Points.AddXY(book.Title, book.Price);
                }

                chartYearOfPublication_AAN.ChartAreas[0].AxisX.Title = "�������� �����";
                chartYearOfPublication_AAN.ChartAreas[0].AxisY.Title = "��� �������";
                chartPriceOfBook_AAN.ChartAreas[0].AxisX.Title = "�������� �����";
                chartPriceOfBook_AAN.ChartAreas[0].AxisY.Title = "����";
            }
            catch
            {
                MessageBox.Show("�������� ������ ����", "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void buttonSearch_Click(object sender, EventArgs e)
        {
            try
            {
                List<Library> books = ds.SearchBook(textBoxSearch_AAN.Text);
                dataGridViewOutData_AAN.AutoGenerateColumns = true;
                dataGridViewOutData_AAN.DataSource = books;
                chartYearOfPublication_AAN.Series.Clear();
                chartPriceOfBook_AAN.Series.Clear();

                foreach (var book in books)
                {
                    var seriesYear = chartYearOfPublication_AAN.Series.Add(book.Title);
                    seriesYear.Points.AddXY(book.Title, book.Year);
                    var seriesPrice = chartPriceOfBook_AAN.Series.Add(book.Title);
                    seriesPrice.Points.AddXY(book.Title, book.Price);
                }

                chartYearOfPublication_AAN.ChartAreas[0].AxisX.Title = "�������� �����";
                chartYearOfPublication_AAN.ChartAreas[0].AxisY.Title = "��� �������";
                chartPriceOfBook_AAN.ChartAreas[0].AxisX.Title = "�������� �����";
                chartPriceOfBook_AAN.ChartAreas[0].AxisY.Title = "����";
            }
            catch
            {
                MessageBox.Show("�������� ������ ����", "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void buttonAboutProgram_AAN_Click(object sender, EventArgs e)
        {
            FormAboutProgram formAboutProgram = new FormAboutProgram();
            formAboutProgram.ShowDialog();
        }

        private void buttonUserManual_AAN_Click(object sender, EventArgs e)
        {
            FormUserManual formUserManual = new FormUserManual();
            formUserManual.ShowDialog();
        }
        private void buttonSaveFile_AAN_Click(object sender, EventArgs e)
        {
            saveFileDialogSaveLib_AAN.Filter = "CSV files (*.csv)|*.csv|All files (*.*)|*.*";
            saveFileDialogSaveLib_AAN.ShowDialog();
            string filename = saveFileDialogSaveLib_AAN.FileName;
            FileInfo fileInfo = new FileInfo(filename);
            bool fileExists = fileInfo.Exists;

            if (fileExists)
            {
                File.Delete(filename);
            }
            int rows = dataGridViewOutData_AAN.RowCount;
            int columns = dataGridViewOutData_AAN.ColumnCount;

            string str = "";
            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    if (c != columns - 1)
                    {
                        str += dataGridViewOutData_AAN.Rows[r].Cells[c].Value + ";";
                    }
                    else
                    {
                        str += dataGridViewOutData_AAN.Rows[r].Cells[c].Value;
                    }
                }
                File.AppendAllText(filename, str + Environment.NewLine,Encoding.Unicode);
                str = "";
            }

            string path = Path.GetDirectoryName(filename) + $"/{filename}";
            MessageBox.Show($"���� ������� ��������.\n ���� �����: {path}", "���������� �����", MessageBoxButtons.OK, MessageBoxIcon.Information);

           
        }


        private void buttonAdd_AAN_Click(object sender, EventArgs e)
        {
            FormAddBook_AAN formAddBook = new FormAddBook_AAN();
            formAddBook.ShowDialog();



        }
    }
}
