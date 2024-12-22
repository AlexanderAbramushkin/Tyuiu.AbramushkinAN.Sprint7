namespace Tyuiu.AbramushkinAN.Sprint7.Project.V4
{
    partial class FormAddBook_AAN
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBoxInfoAboutBook_AAN = new TextBox();
            buttonAddBook_AAN = new Button();
            panel1 = new Panel();
            buttonCloseWindow_AAN = new Button();
            textBoxAnnotation_AAN = new TextBox();
            textBoxPrice_AAN = new TextBox();
            textBoxAuthor_AAN = new TextBox();
            textBoxIsNewEdition_AAN = new TextBox();
            textBoxYearOfPubl_AAN = new TextBox();
            textBoxTitle_AAN = new TextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // textBoxInfoAboutBook_AAN
            // 
            textBoxInfoAboutBook_AAN.BackColor = SystemColors.Control;
            textBoxInfoAboutBook_AAN.BorderStyle = BorderStyle.None;
            textBoxInfoAboutBook_AAN.Font = new Font("Segoe UI", 15F);
            textBoxInfoAboutBook_AAN.Location = new Point(121, 12);
            textBoxInfoAboutBook_AAN.Multiline = true;
            textBoxInfoAboutBook_AAN.Name = "textBoxInfoAboutBook_AAN";
            textBoxInfoAboutBook_AAN.ReadOnly = true;
            textBoxInfoAboutBook_AAN.Size = new Size(341, 36);
            textBoxInfoAboutBook_AAN.TabIndex = 0;
            textBoxInfoAboutBook_AAN.Text = "Заполните информацию о книге";
            textBoxInfoAboutBook_AAN.TextAlign = HorizontalAlignment.Center;
            // 
            // buttonAddBook_AAN
            // 
            buttonAddBook_AAN.Location = new Point(461, 321);
            buttonAddBook_AAN.Name = "buttonAddBook_AAN";
            buttonAddBook_AAN.Size = new Size(111, 28);
            buttonAddBook_AAN.TabIndex = 1;
            buttonAddBook_AAN.Text = "Добавить книгу";
            buttonAddBook_AAN.UseVisualStyleBackColor = true;
            buttonAddBook_AAN.Click += button1_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(buttonCloseWindow_AAN);
            panel1.Controls.Add(textBoxAnnotation_AAN);
            panel1.Controls.Add(textBoxPrice_AAN);
            panel1.Controls.Add(textBoxAuthor_AAN);
            panel1.Controls.Add(textBoxIsNewEdition_AAN);
            panel1.Controls.Add(textBoxYearOfPubl_AAN);
            panel1.Controls.Add(textBoxTitle_AAN);
            panel1.Controls.Add(textBoxInfoAboutBook_AAN);
            panel1.Controls.Add(buttonAddBook_AAN);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(584, 361);
            panel1.TabIndex = 2;
            panel1.Paint += panel1_Paint;
            // 
            // buttonCloseWindow_AAN
            // 
            buttonCloseWindow_AAN.Location = new Point(344, 321);
            buttonCloseWindow_AAN.Name = "buttonCloseWindow_AAN";
            buttonCloseWindow_AAN.Size = new Size(111, 28);
            buttonCloseWindow_AAN.TabIndex = 8;
            buttonCloseWindow_AAN.Text = "Закрыть окно";
            buttonCloseWindow_AAN.UseVisualStyleBackColor = true;
            buttonCloseWindow_AAN.Click += buttonCloseWindow_AAN_Click;
            // 
            // textBoxAnnotation_AAN
            // 
            textBoxAnnotation_AAN.Location = new Point(355, 252);
            textBoxAnnotation_AAN.Multiline = true;
            textBoxAnnotation_AAN.Name = "textBoxAnnotation_AAN";
            textBoxAnnotation_AAN.PlaceholderText = "Аннотация";
            textBoxAnnotation_AAN.Size = new Size(156, 37);
            textBoxAnnotation_AAN.TabIndex = 7;
            textBoxAnnotation_AAN.TextAlign = HorizontalAlignment.Center;
            // 
            // textBoxPrice_AAN
            // 
            textBoxPrice_AAN.Location = new Point(355, 161);
            textBoxPrice_AAN.Multiline = true;
            textBoxPrice_AAN.Name = "textBoxPrice_AAN";
            textBoxPrice_AAN.PlaceholderText = "Цена книги";
            textBoxPrice_AAN.Size = new Size(156, 35);
            textBoxPrice_AAN.TabIndex = 6;
            textBoxPrice_AAN.TextAlign = HorizontalAlignment.Center;
            // 
            // textBoxAuthor_AAN
            // 
            textBoxAuthor_AAN.Location = new Point(355, 75);
            textBoxAuthor_AAN.Multiline = true;
            textBoxAuthor_AAN.Name = "textBoxAuthor_AAN";
            textBoxAuthor_AAN.PlaceholderText = "Автор произведения";
            textBoxAuthor_AAN.Size = new Size(156, 40);
            textBoxAuthor_AAN.TabIndex = 5;
            textBoxAuthor_AAN.TextAlign = HorizontalAlignment.Center;
            textBoxAuthor_AAN.TextChanged += textBoxaAuthor_TextChanged;
            // 
            // textBoxIsNewEdition_AAN
            // 
            textBoxIsNewEdition_AAN.Location = new Point(63, 252);
            textBoxIsNewEdition_AAN.Multiline = true;
            textBoxIsNewEdition_AAN.Name = "textBoxIsNewEdition_AAN";
            textBoxIsNewEdition_AAN.PlaceholderText = "Это новое издание?";
            textBoxIsNewEdition_AAN.Size = new Size(156, 37);
            textBoxIsNewEdition_AAN.TabIndex = 4;
            textBoxIsNewEdition_AAN.TextAlign = HorizontalAlignment.Center;
            // 
            // textBoxYearOfPubl_AAN
            // 
            textBoxYearOfPubl_AAN.Location = new Point(63, 161);
            textBoxYearOfPubl_AAN.Multiline = true;
            textBoxYearOfPubl_AAN.Name = "textBoxYearOfPubl_AAN";
            textBoxYearOfPubl_AAN.PlaceholderText = "Год издания";
            textBoxYearOfPubl_AAN.Size = new Size(156, 35);
            textBoxYearOfPubl_AAN.TabIndex = 3;
            textBoxYearOfPubl_AAN.TextAlign = HorizontalAlignment.Center;
            // 
            // textBoxTitle_AAN
            // 
            textBoxTitle_AAN.Location = new Point(63, 75);
            textBoxTitle_AAN.Multiline = true;
            textBoxTitle_AAN.Name = "textBoxTitle_AAN";
            textBoxTitle_AAN.PlaceholderText = "Название произведения";
            textBoxTitle_AAN.Size = new Size(156, 40);
            textBoxTitle_AAN.TabIndex = 2;
            textBoxTitle_AAN.TextAlign = HorizontalAlignment.Center;
            // 
            // FormAddBook_AAN
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(584, 361);
            Controls.Add(panel1);
            MaximumSize = new Size(600, 400);
            MinimumSize = new Size(600, 400);
            Name = "FormAddBook_AAN";
            Text = "Новая книга";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox textBoxInfoAboutBook_AAN;
        private Button buttonAddBook_AAN;
        private Panel panel1;
        private TextBox textBoxPrice_AAN;
        private TextBox textBoxAuthor_AAN;
        private TextBox textBoxIsNewEdition_AAN;
        private TextBox textBoxYearOfPubl_AAN;
        private TextBox textBoxTitle_AAN;
        private TextBox textBoxAnnotation_AAN;
        private Button buttonCloseWindow_AAN;
    }
}