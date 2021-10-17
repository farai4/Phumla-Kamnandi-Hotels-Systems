using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Phumla_Kamnandi_Hotels_Systems.Properties;
using Phumla_Kamnandi_Hotels_Systems.Data;
using System.Windows.Forms;

namespace Phumla_Kamnandi_Hotels_Systems.Presentation
{
    public partial class LogInForm : Form
    {
        #region Data Members
        StaffDB staffdb;
        #endregion

        #region Events, Buttons
        public LogInForm()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            try
            {
                staffdb = new StaffDB();
                staffdb.CheckStaff(txtStaffID.Text, txtPassword.Text);
            }
            catch (FormatException)
            {
                //handling format error if user enters wrong input 
                MessageBox.Show("Wrong Input", "Error");
                txtStaffID.Text = "";
                txtPassword.Text = "";
                txtStaffID.Focus();
            }
            catch (Exception)
            {
                MessageBox.Show("Unexpected Error", "Error");
                txtStaffID.Text = "";
                txtPassword.Text = "";
                txtStaffID.Focus();
            }
        }

        #endregion
    }
}
