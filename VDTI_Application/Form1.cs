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
    public partial class Form1 : Form
    {
        public bool isLoggedIn = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void logInToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowLoginForm();
        }

        private void gateInOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.isLoggedIn)
            {
                GateInOut gatein = new GateInOut();
                gatein.MdiParent = this;
                gatein.Show();
            }
            else
            {
                ShowLoginForm();
            }
        }

        private void ShowLoginForm()
        {
            LogIn login = new LogIn();          //Declaring an Object for login form
            login.MdiParent = this;             //Locking login form to parent form
            login.Show();                       //Showing login form
        }

        private void userManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("User Management");
        }

        private void schedulingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Scheduling");
        }
    }
}
