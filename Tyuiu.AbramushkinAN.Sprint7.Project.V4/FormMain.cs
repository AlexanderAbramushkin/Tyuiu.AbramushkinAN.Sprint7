namespace Tyuiu.AbramushkinAN.Sprint7.Project.V4
{
    public partial class FormMain_AAN : Form
    {
        public FormMain_AAN()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {

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
