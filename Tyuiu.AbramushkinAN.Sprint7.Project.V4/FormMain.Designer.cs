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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            panelInstruments_AAN = new Panel();
            buttonUpdate_AAN = new Button();
            buttonAdd_AAN = new Button();
            textBoxSearch_AAN = new TextBox();
            buttonSearch_AAN = new Button();
            buttonSaveFile_AAN = new Button();
            buttonUserManual_AAN = new Button();
            buttonAboutProgram_AAN = new Button();
            tableLayoutPanelData_AAN = new TableLayoutPanel();
            dataGridViewData_AAN = new DataGridView();
            dataGridViewOutData_AAN = new DataGridView();
            chartYearOfPublication_AAN = new System.Windows.Forms.DataVisualization.Charting.Chart();
            chartPriceOfBook_AAN = new System.Windows.Forms.DataVisualization.Charting.Chart();
            panelInstruments_AAN.SuspendLayout();
            tableLayoutPanelData_AAN.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewData_AAN).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOutData_AAN).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chartYearOfPublication_AAN).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chartPriceOfBook_AAN).BeginInit();
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
            textBoxSearch_AAN.Location = new Point(12, 18);
            textBoxSearch_AAN.Name = "textBoxSearch_AAN";
            textBoxSearch_AAN.PlaceholderText = "Введите название книги";
            textBoxSearch_AAN.Size = new Size(287, 23);
            textBoxSearch_AAN.TabIndex = 4;
            // 
            // buttonSearch_AAN
            // 
            buttonSearch_AAN.Anchor = AnchorStyles.Left;
            buttonSearch_AAN.Location = new Point(305, 18);
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
            // tableLayoutPanelData_AAN
            // 
            tableLayoutPanelData_AAN.ColumnCount = 2;
            tableLayoutPanelData_AAN.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanelData_AAN.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanelData_AAN.Controls.Add(dataGridViewData_AAN, 0, 0);
            tableLayoutPanelData_AAN.Controls.Add(dataGridViewOutData_AAN, 1, 0);
            tableLayoutPanelData_AAN.Controls.Add(chartYearOfPublication_AAN, 0, 1);
            tableLayoutPanelData_AAN.Controls.Add(chartPriceOfBook_AAN, 1, 1);
            tableLayoutPanelData_AAN.Dock = DockStyle.Fill;
            tableLayoutPanelData_AAN.Location = new Point(0, 68);
            tableLayoutPanelData_AAN.Name = "tableLayoutPanelData_AAN";
            tableLayoutPanelData_AAN.RowCount = 2;
            tableLayoutPanelData_AAN.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanelData_AAN.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanelData_AAN.Size = new Size(1264, 664);
            tableLayoutPanelData_AAN.TabIndex = 1;
            // 
            // dataGridViewData_AAN
            // 
            dataGridViewData_AAN.AllowUserToDeleteRows = false;
            dataGridViewData_AAN.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewData_AAN.Dock = DockStyle.Fill;
            dataGridViewData_AAN.Location = new Point(3, 3);
            dataGridViewData_AAN.Name = "dataGridViewData_AAN";
            dataGridViewData_AAN.RowHeadersVisible = false;
            dataGridViewData_AAN.Size = new Size(626, 326);
            dataGridViewData_AAN.TabIndex = 0;
            // 
            // dataGridViewOutData_AAN
            // 
            dataGridViewOutData_AAN.AllowUserToDeleteRows = false;
            dataGridViewOutData_AAN.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOutData_AAN.Dock = DockStyle.Fill;
            dataGridViewOutData_AAN.Location = new Point(635, 3);
            dataGridViewOutData_AAN.Name = "dataGridViewOutData_AAN";
            dataGridViewOutData_AAN.RowHeadersVisible = false;
            dataGridViewOutData_AAN.Size = new Size(626, 326);
            dataGridViewOutData_AAN.TabIndex = 1;
            // 
            // chartYearOfPublication_AAN
            // 
            chartArea1.Name = "ChartArea1";
            chartYearOfPublication_AAN.ChartAreas.Add(chartArea1);
            chartYearOfPublication_AAN.Dock = DockStyle.Fill;
            legend1.Name = "Legend1";
            chartYearOfPublication_AAN.Legends.Add(legend1);
            chartYearOfPublication_AAN.Location = new Point(3, 335);
            chartYearOfPublication_AAN.Name = "chartYearOfPublication_AAN";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartYearOfPublication_AAN.Series.Add(series1);
            chartYearOfPublication_AAN.Size = new Size(626, 326);
            chartYearOfPublication_AAN.TabIndex = 2;
            chartYearOfPublication_AAN.Text = "Год издания";
            // 
            // chartPriceOfBook_AAN
            // 
            chartArea2.Name = "ChartArea1";
            chartPriceOfBook_AAN.ChartAreas.Add(chartArea2);
            chartPriceOfBook_AAN.Dock = DockStyle.Fill;
            legend2.Name = "Legend1";
            chartPriceOfBook_AAN.Legends.Add(legend2);
            chartPriceOfBook_AAN.Location = new Point(635, 335);
            chartPriceOfBook_AAN.Name = "chartPriceOfBook_AAN";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            chartPriceOfBook_AAN.Series.Add(series2);
            chartPriceOfBook_AAN.Size = new Size(626, 326);
            chartPriceOfBook_AAN.TabIndex = 3;
            chartPriceOfBook_AAN.Text = "Стоимость книги";
            // 
            // FormMain_AAN
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1264, 732);
            Controls.Add(tableLayoutPanelData_AAN);
            Controls.Add(panelInstruments_AAN);
            MinimumSize = new Size(1280, 720);
            Name = "FormMain_AAN";
            Text = "Главное меню";
            Load += FormMain_Load;
            panelInstruments_AAN.ResumeLayout(false);
            panelInstruments_AAN.PerformLayout();
            tableLayoutPanelData_AAN.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewData_AAN).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOutData_AAN).EndInit();
            ((System.ComponentModel.ISupportInitialize)chartYearOfPublication_AAN).EndInit();
            ((System.ComponentModel.ISupportInitialize)chartPriceOfBook_AAN).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelInstruments_AAN;
        private Button buttonSaveFile_AAN;
        private Button buttonSearch_AAN;
        private Button buttonUserManual_AAN;
        private Button buttonAboutProgram_AAN;
        private TableLayoutPanel tableLayoutPanelData_AAN;
        private DataGridView dataGridViewData_AAN;
        private DataGridView dataGridViewOutData_AAN;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartYearOfPublication_AAN;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartPriceOfBook_AAN;
        private TextBox textBoxSearch_AAN;
        private Button buttonAdd_AAN;
        private Button buttonUpdate_AAN;
    }
}
