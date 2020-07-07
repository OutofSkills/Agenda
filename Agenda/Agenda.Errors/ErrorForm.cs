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
    public partial class ErrorForm : Form
    {
        public ErrorForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Set an error message in the Error Label
        /// </summary>
        /// <param name="error"></param>
        public void setLabelText(string error)
        {
            if(error!=string.Empty)
            ErrorLabel.Text = error;
        }
    }
}
