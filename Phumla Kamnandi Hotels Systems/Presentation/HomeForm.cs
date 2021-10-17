using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Phumla_Kamnandi_Hotels_Systems.Presentation
{
    public partial class HomeForm : Form
    {
        public HomeForm()
        {
            InitializeComponent();
        }

        #region tool strips

        private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LogInForm log = new LogInForm(); // staff member wishes to log out
            log.ShowDialog();
            this.Hide();
        }
        #endregion
    }
}
