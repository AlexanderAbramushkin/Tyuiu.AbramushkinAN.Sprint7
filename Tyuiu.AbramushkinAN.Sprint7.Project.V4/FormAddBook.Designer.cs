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
            buttonAddBook_AAN = new Button();
            textBoxTitle_AAN = new TextBox();
            textBoxYearOfPubl_AAN = new TextBox();
            textBoxIsNewEdition_AAN = new TextBox();
            textBoxAuthor_AAN = new TextBox();
            textBoxPrice_AAN = new TextBox();
            textBoxAnnotation_AAN = new TextBox();
            panelAddBook_AAN = new Panel();
            labelNewBook_AAN = new Label();
            panelAddBook_AAN.SuspendLayout();
            SuspendLayout();
            // 
            // buttonAddBook_AAN
            // 
            buttonAddBook_AAN.BackColor = SystemColors.Window;
            buttonAddBook_AAN.FlatStyle = FlatStyle.Popup;
            buttonAddBook_AAN.Location = new Point(461, 321);
            buttonAddBook_AAN.Name = "buttonAddBook_AAN";
            buttonAddBook_AAN.Size = new Size(111, 28);
            buttonAddBook_AAN.TabIndex = 1;
            buttonAddBook_AAN.Text = "Добавить книгу";
            buttonAddBook_AAN.UseVisualStyleBackColor = false;
            buttonAddBook_AAN.Click += buttonAdd_AAN_Click;
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
            // textBoxAuthor_AAN
            // 
            textBoxAuthor_AAN.Location = new Point(355, 75);
            textBoxAuthor_AAN.Multiline = true;
            textBoxAuthor_AAN.Name = "textBoxAuthor_AAN";
            textBoxAuthor_AAN.PlaceholderText = "Автор произведения";
            textBoxAuthor_AAN.Size = new Size(156, 40);
            textBoxAuthor_AAN.TabIndex = 5;
            textBoxAuthor_AAN.TextAlign = HorizontalAlignment.Center;
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
            // panelAddBook_AAN
            // 
            panelAddBook_AAN.Controls.Add(labelNewBook_AAN);
            panelAddBook_AAN.Controls.Add(textBoxAnnotation_AAN);
            panelAddBook_AAN.Controls.Add(textBoxPrice_AAN);
            panelAddBook_AAN.Controls.Add(textBoxAuthor_AAN);
            panelAddBook_AAN.Controls.Add(textBoxIsNewEdition_AAN);
            panelAddBook_AAN.Controls.Add(textBoxYearOfPubl_AAN);
            panelAddBook_AAN.Controls.Add(textBoxTitle_AAN);
            panelAddBook_AAN.Controls.Add(buttonAddBook_AAN);
            panelAddBook_AAN.Dock = DockStyle.Fill;
            panelAddBook_AAN.Location = new Point(0, 0);
            panelAddBook_AAN.Name = "panelAddBook_AAN";
            panelAddBook_AAN.Size = new Size(584, 361);
            panelAddBook_AAN.TabIndex = 2;
            // 
            // labelNewBook_AAN
            // 
            labelNewBook_AAN.AutoSize = true;
            labelNewBook_AAN.Font = new Font("Segoe UI", 15F);
            labelNewBook_AAN.Location = new Point(134, 18);
            labelNewBook_AAN.Name = "labelNewBook_AAN";
            labelNewBook_AAN.Size = new Size(315, 28);
            labelNewBook_AAN.TabIndex = 8;
            labelNewBook_AAN.Text = "Заполните информацию о книге\r\n";
            // 
            // FormAddBook_AAN
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(584, 361);
            Controls.Add(panelAddBook_AAN);
            MaximumSize = new Size(600, 400);
            MinimumSize = new Size(600, 400);
            Name = "FormAddBook_AAN";
            Text = "Добавить книгу";
            panelAddBook_AAN.ResumeLayout(false);
            panelAddBook_AAN.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button buttonAddBook_AAN;
        private TextBox textBoxInfoAboutBook_AAN;
        private TextBox textBoxTitle_AAN;
        private TextBox textBoxYearOfPubl_AAN;
        private TextBox textBoxIsNewEdition_AAN;
        private TextBox textBoxAuthor_AAN;
        private TextBox textBoxPrice_AAN;
        private TextBox textBoxAnnotation_AAN;
        private Panel panelAddBook_AAN;
        private Label labelNewBook_AAN;
    }
}