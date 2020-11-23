using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

using System.Data.SqlClient;

namespace FinalProject2013.PL
{
    public partial class FrmMating : Form
    {
        string conString = @"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Thabiso\Desktop\ProjectsC#\FinalProject2013\FinalProject2013\bin\Debug\DogBreedingDB.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True";
        SqlConnection con;
        SqlCommand com;
        BL.Mating m;
        // EnterDog enter;
        SqlDataReader dr;
        private int DoID = 0;
        System.Collections.ArrayList DogIdList = new System.Collections.ArrayList();
        public FrmMating()
        {
            InitializeComponent();
        }
        public void Insert()
        {
            try
            {



                con = new SqlConnection(conString);
                con.Open();
                m = new BL.Mating();

                MemoryStream mains = new MemoryStream();

                com = new SqlCommand("INSERT INTO tblMating (matingId, matingDate, matingPartnerName, dateFarrowBorn, numberOfDogs, numberOfBitches, totalPuppies,dogId ) VALUES ('" + int.Parse(dogIdTextBox.Text) + "','" + dogNameTextBox.Text + "','" + dogBreedTextBox.Text + "','" + dogDOBDateTimePicker.Value + "','" + dogGenderTextBox.Text + "','" + dogFatherTextBox.Text + "','" + dogMotherTextBox.Text + "', @Image)", con);
          
                com.ExecuteNonQuery();

                m.MatingId = int.Parse(dogIdTextBox.Text);

                m.MatingDate = matingDateDateTimePicker.Value;
                m.MatingPartnerName = matingPartnerNameTextBox.Text;
                m.DateFarrowBorn = dateFarrowBornDateTimePicker.Value;
                m.NumberOfDogs =int.Parse( numberOfDogsTextBox.Text);
                m.NumberOfBitches = int.Parse(numberOfBitchesTextBox.Text);
                m.TotalPuppies = int.Parse(totalPuppiesTextBox.Text);
                m.DogId = int.Parse( dogIdTextBox1.Text);
                MessageBox.Show("Success");
                con.Close();
                dogIdTextBox.Clear();
                //  dogDOBDateTimePicker.Clear();
                //dogNameTextBox.Clear();
               // dogBreedTextBox.Clear();
                //dogGenderTextBox.Clear();
                //dogFatherTextBox.Clear();
               // dogMotherTextBox.Clear();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void tblMatingBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tblMatingBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dogBreedingDBDataSet);

        }

        private void FrmMating_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dogBreedingDBDataSet.tblMating' table. You can move, or remove it, as needed.
            this.tblMatingTableAdapter.Fill(this.dogBreedingDBDataSet.tblMating);

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Insert();
        }
    }
}
