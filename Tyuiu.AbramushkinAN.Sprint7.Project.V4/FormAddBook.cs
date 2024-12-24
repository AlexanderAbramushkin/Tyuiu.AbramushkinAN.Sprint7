using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.InteropServices.JavaScript;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Tyuiu.AbramushkinAN.Sprint7.Project.V4.Lib;
using static System.Windows.Forms.DataFormats;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace Tyuiu.AbramushkinAN.Sprint7.Project.V4
{
    public partial class FormAddBook_AAN : Form
    {
        DataService ds = new DataService();
        public FormAddBook_AAN(string data)
        {
            InitializeComponent();

            this.data = data;
        }
        string data;

        public class Book
        {
            public string author { get; set; }
            public string title { get; set; }
            public int year { get; set; }
            public int price { get; set; }
            public bool is_new_edition { get; set; }
            public string annotation { get; set; }
        }
        public void buttonAdd_AAN_Click(object sender, EventArgs e)
        {
            FormMain_AAN formmain = new FormMain_AAN();
            try
            {
                string Title = textBoxTitle_AAN.Text;
                string Author = textBoxAuthor_AAN.Text;
                int YearOfPubl = Convert.ToInt32(textBoxYearOfPubl_AAN.Text);
                int Price = Convert.ToInt32(textBoxPrice_AAN.Text);
                bool IsNewEdition = false;
                if (textBoxIsNewEdition_AAN.Text == "Да" || textBoxIsNewEdition_AAN.Text == "да")
                {
                    IsNewEdition = true;
                }
                else if (textBoxIsNewEdition_AAN.Text == "Нет" || textBoxIsNewEdition_AAN.Text == "нет")
                {
                    IsNewEdition = false;
                }
                else
                {
                    throw new Exception();
                }
                string Annotation = textBoxAnnotation_AAN.Text;
                var book = new Book
                {
                    title = Title.Trim(),
                    author = Author.Trim(),
                    year = YearOfPubl,
                    price = Price,
                    is_new_edition = IsNewEdition,
                    annotation = Annotation.Trim()
                };
            string JsonPath = data;
                string JsonStr = JsonConvert.SerializeObject(book);
                string[] JSON = File.ReadAllLines(JsonPath);
                File.WriteAllLines(JsonPath, JSON);
                for (int i = 0; i < JSON.Length; i++)
                {
                    if(JSON[i] == "]")
                    {
                        JSON[i] = "";
                        JSON = JSON.Where(x => !string.IsNullOrWhiteSpace(x)).ToArray();
                    }    
                }
                File.Delete(JsonPath);
                StreamWriter sw = new StreamWriter(JsonPath, true, Encoding.Default);
                for (int i = 0; i < JSON.Length; i++)
                {
                    sw.WriteLine(JSON[i]);
                }
                sw.Write($"    {JsonStr},\n]");
                sw.Close();
                MessageBox.Show("Книга добавлена успешно", "Добавление новой книги", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }            
            catch
            {
                MessageBox.Show("Проверьте корректность введённых данных", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

}

     
    }
}
