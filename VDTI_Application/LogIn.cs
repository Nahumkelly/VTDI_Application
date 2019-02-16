using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VDTI_Application
{
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            var UserName = tbusername.Text;
            var Password = tbpassword.Text;

            if (UserName != "nahum" || Password != "password")
            {
                MessageBox.Show("Invalid User Name or Password");
            }
            else
            { 
                MessageBox.Show("Welcome "+UserName);
                var parent = (Form1)this.MdiParent;
               
                this.Close();
            }
        }
    }
}
