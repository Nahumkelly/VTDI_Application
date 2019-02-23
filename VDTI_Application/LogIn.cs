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

            //Create an Object
            //VTDI_Gatelog_dbEntities CTX = new VTDI_Gatelog_dbEntities();
            var CTX = new VTDI_Gatelog_dbEntities();
            var User = CTX.Users.Any(q => q.Username == UserName && q.Password == Password);

            if (User == true)
            {
                MessageBox.Show("Welcome " + UserName);
                var parent = (Form1)this.MdiParent;
                //Change the property in Form1 to true.
                parent.isLoggedIn = true;
                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid User Name or Password");
            }
        }
    }
}
