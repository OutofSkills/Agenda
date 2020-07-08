using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgendaErrors
{
    public partial class SuccesWindow : Form
    {
        public SuccesWindow()
        {
            InitializeComponent();
        }
        public void SetSuccessLabel(string v)
        {
            SuccessLabel.Text = v;
        }

        private void ExitButtonSuccess_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MinimizeButtonSuccess_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
