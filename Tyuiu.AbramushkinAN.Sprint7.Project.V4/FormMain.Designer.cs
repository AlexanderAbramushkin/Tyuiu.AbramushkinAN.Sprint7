namespace Tyuiu.AbramushkinAN.Sprint7.Project.V4
{
    partial class FormMain_AAN
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain_AAN));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            panelInstruments_AAN = new Panel();
            buttonUpdate_AAN = new Button();
            buttonAdd_AAN = new Button();
            textBoxSearch_AAN = new TextBox();
            buttonSearch_AAN = new Button();
            buttonSaveFile_AAN = new Button();
            buttonUserManual_AAN = new Button();
            buttonAboutProgram_AAN = new Button();
            chartPriceOfBook_AAN = new System.Windows.Forms.DataVisualization.Charting.Chart();
            dataGridViewOutData_AAN = new DataGridView();
            chartYearOfPublication_AAN = new System.Windows.Forms.DataVisualization.Charting.Chart();
            panelDataGrid_AAN = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            splitContainercharts_AAN = new SplitContainer();
            panelInstruments_AAN.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartPriceOfBook_AAN).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOutData_AAN).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chartYearOfPublication_AAN).BeginInit();
            panelDataGrid_AAN.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainercharts_AAN).BeginInit();
            splitContainercharts_AAN.Panel1.SuspendLayout();
            splitContainercharts_AAN.Panel2.SuspendLayout();
            splitContainercharts_AAN.SuspendLayout();
            SuspendLayout();
            // 
            // panelInstruments_AAN
            // 
            panelInstruments_AAN.Controls.Add(buttonUpdate_AAN);
            panelInstruments_AAN.Controls.Add(buttonAdd_AAN);
            panelInstruments_AAN.Controls.Add(textBoxSearch_AAN);
            panelInstruments_AAN.Controls.Add(buttonSearch_AAN);
            panelInstruments_AAN.Controls.Add(buttonSaveFile_AAN);
            panelInstruments_AAN.Controls.Add(buttonUserManual_AAN);
            panelInstruments_AAN.Controls.Add(buttonAboutProgram_AAN);
            panelInstruments_AAN.Dock = DockStyle.Top;
            panelInstruments_AAN.Location = new Point(0, 0);
            panelInstruments_AAN.Name = "panelInstruments_AAN";
            panelInstruments_AAN.Size = new Size(1264, 68);
            panelInstruments_AAN.TabIndex = 0;
            // 
            // buttonUpdate_AAN
            // 
            buttonUpdate_AAN.Anchor = AnchorStyles.Right;
            buttonUpdate_AAN.Image = (Image)resources.GetObject("buttonUpdate_AAN.Image");
            buttonUpdate_AAN.Location = new Point(724, 12);
            buttonUpdate_AAN.Name = "buttonUpdate_AAN";
            buttonUpdate_AAN.Size = new Size(44, 44);
            buttonUpdate_AAN.TabIndex = 6;
            buttonUpdate_AAN.UseVisualStyleBackColor = true;
            buttonUpdate_AAN.Click += buttonUpdate_AAN_Click;
            // 
            // buttonAdd_AAN
            // 
            buttonAdd_AAN.Anchor = AnchorStyles.Right;
            buttonAdd_AAN.Location = new Point(774, 12);
            buttonAdd_AAN.Name = "buttonAdd_AAN";
            buttonAdd_AAN.Size = new Size(115, 44);
            buttonAdd_AAN.TabIndex = 5;
            buttonAdd_AAN.Text = "Добавить произведение";
            buttonAdd_AAN.UseVisualStyleBackColor = true;
            buttonAdd_AAN.Click += buttonAdd_AAN_Click;
            // 
            // textBoxSearch_AAN
            // 
            textBoxSearch_AAN.Location = new Point(12, 23);
            textBoxSearch_AAN.Name = "textBoxSearch_AAN";
            textBoxSearch_AAN.PlaceholderText = "Введите название книги";
            textBoxSearch_AAN.Size = new Size(192, 23);
            textBoxSearch_AAN.TabIndex = 4;
            // 
            // buttonSearch_AAN
            // 
            buttonSearch_AAN.Anchor = AnchorStyles.Left;
            buttonSearch_AAN.Location = new Point(210, 18);
            buttonSearch_AAN.Name = "buttonSearch_AAN";
            buttonSearch_AAN.Size = new Size(115, 33);
            buttonSearch_AAN.TabIndex = 2;
            buttonSearch_AAN.Text = "Найти";
            buttonSearch_AAN.UseVisualStyleBackColor = true;
            buttonSearch_AAN.Click += buttonSearch_Click;
            // 
            // buttonSaveFile_AAN
            // 
            buttonSaveFile_AAN.Anchor = AnchorStyles.Right;
            buttonSaveFile_AAN.Location = new Point(895, 12);
            buttonSaveFile_AAN.Name = "buttonSaveFile_AAN";
            buttonSaveFile_AAN.Size = new Size(115, 44);
            buttonSaveFile_AAN.TabIndex = 3;
            buttonSaveFile_AAN.Text = "Сохранить в файл";
            buttonSaveFile_AAN.UseVisualStyleBackColor = true;
            buttonSaveFile_AAN.Click += button4_Click;
            // 
            // buttonUserManual_AAN
            // 
            buttonUserManual_AAN.Anchor = AnchorStyles.Right;
            buttonUserManual_AAN.Location = new Point(1137, 12);
            buttonUserManual_AAN.Name = "buttonUserManual_AAN";
            buttonUserManual_AAN.Size = new Size(115, 44);
            buttonUserManual_AAN.TabIndex = 1;
            buttonUserManual_AAN.Text = "Руководство пользователя";
            buttonUserManual_AAN.UseVisualStyleBackColor = true;
            buttonUserManual_AAN.Click += buttonUserManual_AAN_Click;
            // 
            // buttonAboutProgram_AAN
            // 
            buttonAboutProgram_AAN.Anchor = AnchorStyles.Right;
            buttonAboutProgram_AAN.Location = new Point(1016, 12);
            buttonAboutProgram_AAN.Name = "buttonAboutProgram_AAN";
            buttonAboutProgram_AAN.Size = new Size(115, 44);
            buttonAboutProgram_AAN.TabIndex = 0;
            buttonAboutProgram_AAN.Text = "О программе";
            buttonAboutProgram_AAN.UseVisualStyleBackColor = true;
            buttonAboutProgram_AAN.Click += buttonAboutProgram_AAN_Click;
            // 
            // chartPriceOfBook_AAN
            // 
            chartArea3.Name = "ChartArea1";
            chartPriceOfBook_AAN.ChartAreas.Add(chartArea3);
            chartPriceOfBook_AAN.Dock = DockStyle.Fill;
            legend3.Name = "Legend1";
            chartPriceOfBook_AAN.Legends.Add(legend3);
            chartPriceOfBook_AAN.Location = new Point(0, 0);
            chartPriceOfBook_AAN.Name = "chartPriceOfBook_AAN";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            chartPriceOfBook_AAN.Series.Add(series3);
            chartPriceOfBook_AAN.Size = new Size(605, 326);
            chartPriceOfBook_AAN.TabIndex = 3;
            chartPriceOfBook_AAN.Text = "Стоимость книги";
            chartPriceOfBook_AAN.Click += chartPriceOfBook_AAN_Click;
            // 
            // dataGridViewOutData_AAN
            // 
            dataGridViewOutData_AAN.AllowUserToDeleteRows = false;
            dataGridViewOutData_AAN.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOutData_AAN.Dock = DockStyle.Fill;
            dataGridViewOutData_AAN.Location = new Point(3, 3);
            dataGridViewOutData_AAN.Name = "dataGridViewOutData_AAN";
            dataGridViewOutData_AAN.RowHeadersVisible = false;
            dataGridViewOutData_AAN.Size = new Size(1258, 326);
            dataGridViewOutData_AAN.TabIndex = 1;
            // 
            // chartYearOfPublication_AAN
            // 
            chartArea4.Name = "ChartArea1";
            chartYearOfPublication_AAN.ChartAreas.Add(chartArea4);
            chartYearOfPublication_AAN.Dock = DockStyle.Fill;
            legend4.Name = "Legend1";
            chartYearOfPublication_AAN.Legends.Add(legend4);
            chartYearOfPublication_AAN.Location = new Point(0, 0);
            chartYearOfPublication_AAN.Name = "chartYearOfPublication_AAN";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            chartYearOfPublication_AAN.Series.Add(series4);
            chartYearOfPublication_AAN.Size = new Size(649, 326);
            chartYearOfPublication_AAN.TabIndex = 2;
            chartYearOfPublication_AAN.Text = "Год издания";
            // 
            // panelDataGrid_AAN
            // 
            panelDataGrid_AAN.Controls.Add(tableLayoutPanel1);
            panelDataGrid_AAN.Dock = DockStyle.Fill;
            panelDataGrid_AAN.Location = new Point(0, 68);
            panelDataGrid_AAN.Name = "panelDataGrid_AAN";
            panelDataGrid_AAN.Size = new Size(1264, 664);
            panelDataGrid_AAN.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(dataGridViewOutData_AAN, 0, 0);
            tableLayoutPanel1.Controls.Add(splitContainercharts_AAN, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(1264, 664);
            tableLayoutPanel1.TabIndex = 4;
            // 
            // splitContainercharts_AAN
            // 
            splitContainercharts_AAN.Dock = DockStyle.Fill;
            splitContainercharts_AAN.Location = new Point(3, 335);
            splitContainercharts_AAN.Name = "splitContainercharts_AAN";
            // 
            // splitContainercharts_AAN.Panel1
            // 
            splitContainercharts_AAN.Panel1.Controls.Add(chartYearOfPublication_AAN);
            // 
            // splitContainercharts_AAN.Panel2
            // 
            splitContainercharts_AAN.Panel2.Controls.Add(chartPriceOfBook_AAN);
            splitContainercharts_AAN.Size = new Size(1258, 326);
            splitContainercharts_AAN.SplitterDistance = 649;
            splitContainercharts_AAN.TabIndex = 2;
            // 
            // FormMain_AAN
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1264, 732);
            Controls.Add(panelDataGrid_AAN);
            Controls.Add(panelInstruments_AAN);
            MinimumSize = new Size(1280, 720);
            Name = "FormMain_AAN";
            Text = "Главное меню";
            Load += FormMain_Load;
            panelInstruments_AAN.ResumeLayout(false);
            panelInstruments_AAN.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)chartPriceOfBook_AAN).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOutData_AAN).EndInit();
            ((System.ComponentModel.ISupportInitialize)chartYearOfPublication_AAN).EndInit();
            panelDataGrid_AAN.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            splitContainercharts_AAN.Panel1.ResumeLayout(false);
            splitContainercharts_AAN.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainercharts_AAN).EndInit();
            splitContainercharts_AAN.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelInstruments_AAN;
        private Button buttonSaveFile_AAN;
        private Button buttonSearch_AAN;
        private Button buttonUserManual_AAN;
        private Button buttonAboutProgram_AAN;
        private DataGridView dataGridViewOutData_AAN;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartYearOfPublication_AAN;
        private TextBox textBoxSearch_AAN;
        private Button buttonAdd_AAN;
        private Button buttonUpdate_AAN;
        private Panel panelDataGrid_AAN;
        private TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartPriceOfBook_AAN;
        private SplitContainer splitContainercharts_AAN;
    }
}
