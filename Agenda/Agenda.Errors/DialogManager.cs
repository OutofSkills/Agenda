using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaErrors
{
    public class DialogManager
    {
        ErrorForm errorWindow;
        SuccesWindow succesWindow;

        /// <summary>
        /// Will open a window with an error text wether there is a error
        /// </summary>
        /// <param name="v"></param>
        public void ShowErrorWindow(string v)
        {
            if (errorWindow == null)
                errorWindow = new ErrorForm();

            errorWindow.setLabelText(v);
            errorWindow.ShowDialog();
        }

        /// <summary>
        /// Will open a window with an error text wether there a task is completed successfully
        /// </summary>
        /// <param name="v"></param>
        public void ShowSuccessWindow(string v)
        {
            if (succesWindow == null)
                succesWindow = new SuccesWindow();

            succesWindow.SetSuccessLabel(v);
            succesWindow.ShowDialog();
        }
    }
}
