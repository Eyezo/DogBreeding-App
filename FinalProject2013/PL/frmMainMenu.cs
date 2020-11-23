using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FinalProject2013
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
           
        }

        private void btnDog_Click(object sender, EventArgs e)
        {
            PL.frmDog frmD = new PL.frmDog();
            frmD.Show();
        }
    }
}
