using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Data.SqlClient;

namespace FinalProject2013.PL
{
    public partial class frmDoctor : Form
    {
        string conString = @"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Thabiso\Desktop\ProjectsC#\FinalProject2013\FinalProject2013\bin\Debug\DogBreedingDB.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True";
        SqlConnection con;
        SqlCommand com;
        BL.Dog d;
        // EnterDog enter;
        SqlDataReader dr;
        private int DoID = 0;
        System.Collections.ArrayList DogIdList = new System.Collections.ArrayList();
        public frmDoctor()
        {
            InitializeComponent();
        }

        private void tblDogBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tblDogBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dogBreedingDBDataSet);

        }

        private void frmDoctor_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dogBreedingDBDataSet.tblDog' table. You can move, or remove it, as needed.
            this.tblDogTableAdapter.Fill(this.dogBreedingDBDataSet.tblDog);

        }
       

        private void btnSave_Click(object sender, EventArgs e)
        {

        }
    }
}
