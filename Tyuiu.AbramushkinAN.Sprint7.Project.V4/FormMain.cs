using System.Diagnostics.Metrics;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.JavaScript;
using System.Text;
using System.Text.Json.Nodes;
using System.Windows.Forms;
using Tyuiu.AbramushkinAN.Sprint7.Project.V4.Lib;
using static System.Windows.Forms.DataFormats;

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
        static string JsonPath = "";

        private void FormMain_Load(object sender, EventArgs e)
        {
            buttonAdd_AAN.Enabled = false;
            buttonSaveFile_AAN.Enabled = false;
            buttonSearch_AAN.Enabled = false;
            pictureBoxUpdate_AAN.Enabled = false;
            textBoxSearch_AAN.Enabled = false;
        }

        private void buttonUpdate_AAN_Click(object sender, EventArgs e)
        {

            List<Library> books = ds.GetLibraries(JsonPath);
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

            chartYearOfPublication_AAN.ChartAreas[0].AxisX.Title = "Название книги";
            chartYearOfPublication_AAN.ChartAreas[0].AxisY.Title = "Год издания";
            chartPriceOfBook_AAN.ChartAreas[0].AxisX.Title = "Название книги";
            chartPriceOfBook_AAN.ChartAreas[0].AxisY.Title = "Цена";

        }
        
        private void buttonSearch_Click(object sender, EventArgs e)
        {
            try
            {

                List<Library> books = ds.SearchBook(JsonPath, textBoxSearch_AAN.Text);
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

                chartYearOfPublication_AAN.ChartAreas[0].AxisX.Title = "Название книги";
                chartYearOfPublication_AAN.ChartAreas[0].AxisY.Title = "Год издания";
                chartPriceOfBook_AAN.ChartAreas[0].AxisX.Title = "Название книги";
                chartPriceOfBook_AAN.ChartAreas[0].AxisY.Title = "Цена";
            }
            catch
            {
                MessageBox.Show("Обновите список книг", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        
        private void buttonSaveFile_AAN_Click(object sender, EventArgs e)
        {
            try
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
                    File.AppendAllText(filename, str + Environment.NewLine);
                    str = "";
                }
                string path = Path.GetDirectoryName(filename) + $"/{filename}";
                MessageBox.Show($"Файл успешно сохранён.\nПуть файла: {path}", "Сохранение файла", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show($"Ошибка сохранения файла, попробуйте ещё раз", "Сохранение файла", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void buttonAdd_AAN_Click(object sender, EventArgs e)
        {
            FormAddBook_AAN f = new FormAddBook_AAN(this.openFileDialogJSON_AAN.FileName);
            f.ShowDialog();
        }

        private void buttonOpenFile_AAN_Click(object sender, EventArgs e)
        {
            openFileDialogJSON_AAN.Filter = "JSON files (*.json)|*.json|All files (*.*)|*.*";
            openFileDialogJSON_AAN.ShowDialog();
            JsonPath = openFileDialogJSON_AAN.FileName;

            FormAddBook_AAN f = new FormAddBook_AAN(this.openFileDialogJSON_AAN.FileName);
            List<Library> books = ds.GetLibraries(JsonPath);
            dataGridViewOutData_AAN.AutoGenerateColumns = true;
            dataGridViewOutData_AAN.DataSource = books;
            dataGridViewOutData_AAN.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewOutData_AAN.Columns[0].HeaderText = "Автор";
            dataGridViewOutData_AAN.Columns[1].HeaderText = "Название произведения";
            dataGridViewOutData_AAN.Columns[2].HeaderText = "Год написания";
            dataGridViewOutData_AAN.Columns[3].HeaderText = "Стоимость";
            dataGridViewOutData_AAN.Columns[4].HeaderText = "Новое ли издание?";
            dataGridViewOutData_AAN.Columns[5].HeaderText = "Аннотация";


            chartYearOfPublication_AAN.Series.Clear();
            chartPriceOfBook_AAN.Series.Clear();

            foreach (var book in books)
            {
                var seriesYear = chartYearOfPublication_AAN.Series.Add(book.Title);
                seriesYear.Points.AddXY(book.Title, book.Year);
                var seriesPrice = chartPriceOfBook_AAN.Series.Add(book.Title);
                seriesPrice.Points.AddXY(book.Title, book.Price);
            }

            chartYearOfPublication_AAN.ChartAreas[0].AxisX.Title = "Название книги";
            chartYearOfPublication_AAN.ChartAreas[0].AxisY.Title = "Год издания";
            chartPriceOfBook_AAN.ChartAreas[0].AxisX.Title = "Название книги";
            chartPriceOfBook_AAN.ChartAreas[0].AxisY.Title = "Цена";

            buttonAdd_AAN.Enabled = true;
            buttonSaveFile_AAN.Enabled = true;
            buttonSearch_AAN.Enabled = true;
            pictureBoxUpdate_AAN.Enabled = true;
            textBoxSearch_AAN.Enabled = true;
        }
        private void dataGridViewOutData_AAN_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                int columnIndex = e.ColumnIndex;
                List<Library> books = ds.SortLibrary(JsonPath, columnIndex);
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

                chartYearOfPublication_AAN.ChartAreas[0].AxisX.Title = "Название книги";
                chartYearOfPublication_AAN.ChartAreas[0].AxisY.Title = "Год издания";
                chartPriceOfBook_AAN.ChartAreas[0].AxisX.Title = "Название книги";
                chartPriceOfBook_AAN.ChartAreas[0].AxisY.Title = "Цена";
            }
            catch
            {
                MessageBox.Show("Обновите список книг", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void textBoxSearch_AAN_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) 
            { 
                buttonSearch_Click(sender, e);
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


    }
}
