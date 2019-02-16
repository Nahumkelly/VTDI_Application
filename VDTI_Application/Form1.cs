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
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void logInToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LogIn login = new LogIn();          //Declaring an Object for login form
            login.MdiParent = this;             //Locking login form to parent form
            login.Show();                       //Showing login form
        }

        private void gateInOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GateInOut gatein = new GateInOut();
            gatein.MdiParent = this;
            gatein.Show();
        }
    }
}
