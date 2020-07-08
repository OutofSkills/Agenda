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

        Point lastPoint;

        private void SuccesMovePanel_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void SuccesMovePanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }
    }
}
