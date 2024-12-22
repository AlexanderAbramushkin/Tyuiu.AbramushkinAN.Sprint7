using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.AbramushkinAN.Sprint7.Project.V4.Lib;


namespace Tyuiu.AbramushkinAN.Sprint7.Project.V4
{
    public partial class FormAddBook_AAN : Form
    {
        DataService ds = new DataService();
        public FormAddBook_AAN()
        {
            InitializeComponent();
        }

        public class Book
        {
            public string author { get; set; }
            public string title { get; set; }
            public int year { get; set; }
            public double price { get; set; }
            public bool is_new_edition { get; set; }
            public string annotation { get; set; }
        }
        public void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string Title = textBoxTitle_AAN.Text;
                string Author = textBoxAuthor_AAN.Text;
                int YearOfPubl = Convert.ToInt32(textBoxYearOfPubl_AAN.Text);
                double Price = Convert.ToDouble(textBoxPrice_AAN.Text);
                bool IsNewEdition;
                if (textBoxIsNewEdition_AAN.Text == "Да")
                {
                    IsNewEdition = true;
                }
                else
                {
                    IsNewEdition = false;
                }
                string Annotation = textBoxAnnotation_AAN.Text;
                var book = new Book
                {
                    title = Title,
                    author = Author,
                    year = YearOfPubl,
                    price = Price,
                    is_new_edition = IsNewEdition,
                    annotation = Annotation
                };
            
                string JsonStr = JsonConvert.SerializeObject(book);
                string path = $"C:\\Users\\User\\source\\repos\\Tyuiu.AbramushkinAN.Sprint7\\Test.json";
                //File.WriteAllText(path, $"{JsonStr}\n");
                StreamWriter sw = new StreamWriter(path, true, Encoding.Default);
                sw.Write($"\t{JsonStr},\n]");
                sw.Close();
                MessageBox.Show("Книга добавлена успешно", "Добавление новой книги", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }            
            catch
            {
                MessageBox.Show("Проверьте корректность введённых данных", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
                
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBoxaAuthor_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonCloseWindow_AAN_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
