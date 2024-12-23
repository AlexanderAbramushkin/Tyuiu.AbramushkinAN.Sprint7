using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tyuiu.AbramushkinAN.Sprint7.Project.V4
{
    public partial class FormAboutProgram : Form
    {
        public FormAboutProgram()
        {
            InitializeComponent();
        }

        private void buttonClose_AAN_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
