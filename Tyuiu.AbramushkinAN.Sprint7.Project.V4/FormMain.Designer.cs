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
            components = new System.ComponentModel.Container();
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
            chartPriceOfBook_AAN = new System.Windows.Forms.DataVisualization.Charting.Chart();
            dataGridViewOutData_AAN = new DataGridView();
            chartYearOfPublication_AAN = new System.Windows.Forms.DataVisualization.Charting.Chart();
            panelDataGrid_AAN = new Panel();
            tableLayoutPanelDataGridandCharts_AAN = new TableLayoutPanel();
            splitContainercharts_AAN = new SplitContainer();
            toolTipSearch_AAN = new ToolTip(components);
            toolTipUpdate_AAN = new ToolTip(components);
            toolTipAddBook_AAN = new ToolTip(components);
            toolTiзAboutProgram_AAN = new ToolTip(components);
            toolTipSaveFile_AAN = new ToolTip(components);
            toolTipUserManual_AAN = new ToolTip(components);
            saveFileDialogSaveLib_AAN = new SaveFileDialog();
            panelInstruments_AAN.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartPriceOfBook_AAN).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOutData_AAN).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chartYearOfPublication_AAN).BeginInit();
            panelDataGrid_AAN.SuspendLayout();
            tableLayoutPanelDataGridandCharts_AAN.SuspendLayout();
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
            buttonUpdate_AAN.Anchor = AnchorStyles.Left;
            buttonUpdate_AAN.BackColor = SystemColors.Control;
            buttonUpdate_AAN.BackgroundImageLayout = ImageLayout.None;
            buttonUpdate_AAN.FlatAppearance.BorderColor = SystemColors.Control;
            buttonUpdate_AAN.FlatAppearance.BorderSize = 0;
            buttonUpdate_AAN.FlatStyle = FlatStyle.Popup;
            buttonUpdate_AAN.ForeColor = SystemColors.ActiveCaptionText;
            buttonUpdate_AAN.Image = (Image)resources.GetObject("buttonUpdate_AAN.Image");
            buttonUpdate_AAN.Location = new Point(12, 12);
            buttonUpdate_AAN.Name = "buttonUpdate_AAN";
            buttonUpdate_AAN.Size = new Size(44, 44);
            buttonUpdate_AAN.TabIndex = 6;
            toolTipUpdate_AAN.SetToolTip(buttonUpdate_AAN, "Нажмите на кнопку, чтобы обновить список книг\r\n");
            buttonUpdate_AAN.UseVisualStyleBackColor = false;
            buttonUpdate_AAN.Click += buttonUpdate_AAN_Click;
            // 
            // buttonAdd_AAN
            // 
            buttonAdd_AAN.Anchor = AnchorStyles.Right;
            buttonAdd_AAN.BackColor = SystemColors.Window;
            buttonAdd_AAN.BackgroundImageLayout = ImageLayout.None;
            buttonAdd_AAN.FlatStyle = FlatStyle.Popup;
            buttonAdd_AAN.Location = new Point(842, 12);
            buttonAdd_AAN.Name = "buttonAdd_AAN";
            buttonAdd_AAN.Size = new Size(115, 44);
            buttonAdd_AAN.TabIndex = 5;
            buttonAdd_AAN.Text = "Добавить произведение";
            toolTipAddBook_AAN.SetToolTip(buttonAdd_AAN, "Нажмите на кнопку, чтобы добавить книгу в список");
            buttonAdd_AAN.UseVisualStyleBackColor = false;
            buttonAdd_AAN.Click += buttonAdd_AAN_Click;
            // 
            // textBoxSearch_AAN
            // 
            textBoxSearch_AAN.Location = new Point(62, 24);
            textBoxSearch_AAN.Name = "textBoxSearch_AAN";
            textBoxSearch_AAN.PlaceholderText = "Введите название книги";
            textBoxSearch_AAN.Size = new Size(192, 23);
            textBoxSearch_AAN.TabIndex = 4;
            // 
            // buttonSearch_AAN
            // 
            buttonSearch_AAN.Anchor = AnchorStyles.Left;
            buttonSearch_AAN.BackColor = SystemColors.Window;
            buttonSearch_AAN.FlatStyle = FlatStyle.Popup;
            buttonSearch_AAN.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonSearch_AAN.ForeColor = SystemColors.ControlText;
            buttonSearch_AAN.Location = new Point(260, 12);
            buttonSearch_AAN.Name = "buttonSearch_AAN";
            buttonSearch_AAN.Size = new Size(115, 44);
            buttonSearch_AAN.TabIndex = 2;
            buttonSearch_AAN.Text = "Найти";
            toolTipSearch_AAN.SetToolTip(buttonSearch_AAN, "Напишите название книги в окне и нажмите на кнопку, чтобы выполнить поиск\r\n");
            buttonSearch_AAN.UseVisualStyleBackColor = false;
            buttonSearch_AAN.Click += buttonSearch_Click;
            // 
            // buttonSaveFile_AAN
            // 
            buttonSaveFile_AAN.Anchor = AnchorStyles.Right;
            buttonSaveFile_AAN.BackColor = SystemColors.Window;
            buttonSaveFile_AAN.FlatStyle = FlatStyle.Popup;
            buttonSaveFile_AAN.Location = new Point(963, 12);
            buttonSaveFile_AAN.Name = "buttonSaveFile_AAN";
            buttonSaveFile_AAN.Size = new Size(115, 44);
            buttonSaveFile_AAN.TabIndex = 3;
            buttonSaveFile_AAN.Text = "Сохранить в файл";
            toolTipSaveFile_AAN.SetToolTip(buttonSaveFile_AAN, "Нажмите на кнопку, чтобы сохранить список в формате CSV");
            buttonSaveFile_AAN.UseVisualStyleBackColor = false;
            buttonSaveFile_AAN.Click += buttonSaveFile_AAN_Click;
            // 
            // buttonUserManual_AAN
            // 
            buttonUserManual_AAN.Anchor = AnchorStyles.Right;
            buttonUserManual_AAN.BackColor = SystemColors.Window;
            buttonUserManual_AAN.FlatStyle = FlatStyle.Popup;
            buttonUserManual_AAN.Location = new Point(1084, 12);
            buttonUserManual_AAN.Name = "buttonUserManual_AAN";
            buttonUserManual_AAN.Size = new Size(115, 44);
            buttonUserManual_AAN.TabIndex = 1;
            buttonUserManual_AAN.Text = "Руководство пользователя";
            toolTipUserManual_AAN.SetToolTip(buttonUserManual_AAN, "Нажмите на кнопку, чтобы ознакомиться с руководством пользователя");
            buttonUserManual_AAN.UseVisualStyleBackColor = false;
            buttonUserManual_AAN.Click += buttonUserManual_AAN_Click;
            // 
            // buttonAboutProgram_AAN
            // 
            buttonAboutProgram_AAN.Anchor = AnchorStyles.Right;
            buttonAboutProgram_AAN.BackColor = SystemColors.Window;
            buttonAboutProgram_AAN.FlatStyle = FlatStyle.Popup;
            buttonAboutProgram_AAN.Image = (Image)resources.GetObject("buttonAboutProgram_AAN.Image");
            buttonAboutProgram_AAN.Location = new Point(1205, 12);
            buttonAboutProgram_AAN.Name = "buttonAboutProgram_AAN";
            buttonAboutProgram_AAN.Size = new Size(44, 44);
            buttonAboutProgram_AAN.TabIndex = 0;
            toolTiзAboutProgram_AAN.SetToolTip(buttonAboutProgram_AAN, "Нажмите на кнопку, чтобы ознакомиться с информацией о программе");
            buttonAboutProgram_AAN.UseVisualStyleBackColor = false;
            buttonAboutProgram_AAN.Click += buttonAboutProgram_AAN_Click;
            // 
            // chartPriceOfBook_AAN
            // 
            chartArea1.Name = "ChartArea1";
            chartPriceOfBook_AAN.ChartAreas.Add(chartArea1);
            chartPriceOfBook_AAN.Dock = DockStyle.Fill;
            legend1.Name = "Legend1";
            chartPriceOfBook_AAN.Legends.Add(legend1);
            chartPriceOfBook_AAN.Location = new Point(0, 0);
            chartPriceOfBook_AAN.Name = "chartPriceOfBook_AAN";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartPriceOfBook_AAN.Series.Add(series1);
            chartPriceOfBook_AAN.Size = new Size(605, 326);
            chartPriceOfBook_AAN.TabIndex = 3;
            chartPriceOfBook_AAN.Text = "Стоимость книги";
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
            chartArea2.Name = "ChartArea1";
            chartYearOfPublication_AAN.ChartAreas.Add(chartArea2);
            chartYearOfPublication_AAN.Dock = DockStyle.Fill;
            legend2.Name = "Legend1";
            chartYearOfPublication_AAN.Legends.Add(legend2);
            chartYearOfPublication_AAN.Location = new Point(0, 0);
            chartYearOfPublication_AAN.Name = "chartYearOfPublication_AAN";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            chartYearOfPublication_AAN.Series.Add(series2);
            chartYearOfPublication_AAN.Size = new Size(649, 326);
            chartYearOfPublication_AAN.TabIndex = 2;
            chartYearOfPublication_AAN.Text = "Год издания";
            // 
            // panelDataGrid_AAN
            // 
            panelDataGrid_AAN.Controls.Add(tableLayoutPanelDataGridandCharts_AAN);
            panelDataGrid_AAN.Dock = DockStyle.Fill;
            panelDataGrid_AAN.Location = new Point(0, 68);
            panelDataGrid_AAN.Name = "panelDataGrid_AAN";
            panelDataGrid_AAN.Size = new Size(1264, 664);
            panelDataGrid_AAN.TabIndex = 2;
            // 
            // tableLayoutPanelDataGridandCharts_AAN
            // 
            tableLayoutPanelDataGridandCharts_AAN.ColumnCount = 1;
            tableLayoutPanelDataGridandCharts_AAN.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanelDataGridandCharts_AAN.Controls.Add(dataGridViewOutData_AAN, 0, 0);
            tableLayoutPanelDataGridandCharts_AAN.Controls.Add(splitContainercharts_AAN, 0, 1);
            tableLayoutPanelDataGridandCharts_AAN.Dock = DockStyle.Fill;
            tableLayoutPanelDataGridandCharts_AAN.Location = new Point(0, 0);
            tableLayoutPanelDataGridandCharts_AAN.Name = "tableLayoutPanelDataGridandCharts_AAN";
            tableLayoutPanelDataGridandCharts_AAN.RowCount = 2;
            tableLayoutPanelDataGridandCharts_AAN.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanelDataGridandCharts_AAN.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanelDataGridandCharts_AAN.Size = new Size(1264, 664);
            tableLayoutPanelDataGridandCharts_AAN.TabIndex = 4;
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
            // toolTipSearch_AAN
            // 
            toolTipSearch_AAN.ToolTipIcon = ToolTipIcon.Info;
            toolTipSearch_AAN.ToolTipTitle = "Поиск книги";
            // 
            // toolTipUpdate_AAN
            // 
            toolTipUpdate_AAN.ToolTipIcon = ToolTipIcon.Info;
            toolTipUpdate_AAN.ToolTipTitle = "Перезагрузка списка книг";
            // 
            // toolTipAddBook_AAN
            // 
            toolTipAddBook_AAN.ToolTipIcon = ToolTipIcon.Info;
            toolTipAddBook_AAN.ToolTipTitle = "Добавить книгу";
            // 
            // toolTiзAboutProgram_AAN
            // 
            toolTiзAboutProgram_AAN.ToolTipIcon = ToolTipIcon.Info;
            toolTiзAboutProgram_AAN.ToolTipTitle = "О программе";
            // 
            // toolTipSaveFile_AAN
            // 
            toolTipSaveFile_AAN.ToolTipIcon = ToolTipIcon.Info;
            toolTipSaveFile_AAN.ToolTipTitle = "Сохранить список";
            // 
            // toolTipUserManual_AAN
            // 
            toolTipUserManual_AAN.ToolTipIcon = ToolTipIcon.Info;
            toolTipUserManual_AAN.ToolTipTitle = "Руководство пользователя";
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
            tableLayoutPanelDataGridandCharts_AAN.ResumeLayout(false);
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
        private TableLayoutPanel tableLayoutPanelDataGridandCharts_AAN;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartPriceOfBook_AAN;
        private SplitContainer splitContainercharts_AAN;
        private ToolTip toolTipSearch_AAN;
        private ToolTip toolTipUpdate_AAN;
        private ToolTip toolTipAddBook_AAN;
        private ToolTip toolTiзAboutProgram_AAN;
        private ToolTip toolTipSaveFile_AAN;
        private ToolTip toolTipUserManual_AAN;
        private SaveFileDialog saveFileDialogSaveLib_AAN;
    }
}
