using System.Diagnostics.Metrics;
using System.Runtime.CompilerServices;
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

                chartYearOfPublication_AAN.ChartAreas[0].AxisX.Title = "Название книги";
                chartYearOfPublication_AAN.ChartAreas[0].AxisY.Title = "Год издания";
                chartPriceOfBook_AAN.ChartAreas[0].AxisX.Title = "Название книги";
                chartPriceOfBook_AAN.ChartAreas[0].AxisY.Title = "Цена";
            
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


        private void dataGridViewOutputData_AAN_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panelDataGrids_AAN_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitter2_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }



        private void textBoxSearch_AAN_TextChanged(object sender, EventArgs e)
        {

        }
        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void buttonAdd_AAN_Click(object sender, EventArgs e)
        {
            FormAddBook_AAN formAddBook = new FormAddBook_AAN();
            formAddBook.ShowDialog();



        }

        private void chartPriceOfBook_AAN_Click(object sender, EventArgs e)
        {

        }
    }
}
