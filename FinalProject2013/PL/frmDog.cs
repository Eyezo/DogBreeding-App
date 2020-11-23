using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace FinalProject2013.PL
{
    public partial class frmDog : Form
    {
        string conString = @"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Thabiso\Desktop\ProjectsC#\FinalProject2013\FinalProject2013\bin\Debug\DogBreedingDB.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True";
        SqlConnection con;
        SqlCommand com;
        BL.Dog d;
        // EnterDog enter;
        SqlDataReader dr;
        private int DoID = 0;
        System.Collections.ArrayList DogIdList = new System.Collections.ArrayList();
        public frmDog()
        {
            InitializeComponent();
        }
        public void Insert()
        {
            try
            {



                con = new SqlConnection(conString);
                con.Open();
                d = new BL.Dog();

                MemoryStream mains = new MemoryStream();
                imagePictureBox.Image.Save(mains, System.Drawing.Imaging.ImageFormat.Jpeg);
                byte[] Pic_arr = new byte[mains.Length];
                mains.Position = 0;
                mains.Read(Pic_arr, 0, Pic_arr.Length);

                com = new SqlCommand("INSERT INTO tblDog (dogId, dogName, dogBreed, dogDOB, dogGender, dogFather, dogMother, Image) VALUES ('" + int.Parse(dogIdTextBox.Text) + "','" + dogNameTextBox.Text + "','" + dogBreedTextBox.Text + "','" + dogDOBDateTimePicker.Value + "','" + dogGenderTextBox.Text + "','" + dogFatherTextBox.Text + "','" + dogMotherTextBox.Text + "', @Image)", con);
                com.Parameters.AddWithValue("@Image", Pic_arr);
                com.ExecuteNonQuery();

                d.DogId = int.Parse(dogIdTextBox.Text);

                d.DogName = dogNameTextBox.Text;
                d.DogBreed = dogBreedTextBox.Text;
                d.DogDOB = dogDOBDateTimePicker.Value;
                d.DogGender = dogGenderTextBox.Text;
                d.DogFather = dogFatherTextBox.Text;
                d.DogMother = dogMotherTextBox.Text;
             
                MessageBox.Show("Success");
                con.Close();
                dogIdTextBox.Clear();
              //  dogDOBDateTimePicker.Clear();
                dogNameTextBox.Clear();
                dogBreedTextBox.Clear();
                dogGenderTextBox.Clear();
                dogFatherTextBox.Clear();
                dogMotherTextBox.Clear();
         
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        public void UpdateGUI()
        //
        //Method Name   : void UpdateGUI()
        //Purpose       : Update the Interface with values in the database
        //Input         : none 
        //Output        : none
        {
            try
            {




                txtUpId.Text = txtSearch.Text; ;
             
                txtUpName.Enabled = true;
                txtUpBreed.Enabled = true;
                txtUpDOB.Enabled = true; ;
                txtUpGender.Enabled = true;
                txtUpFather.Enabled = true;
                txtUpMother.Enabled = true;
            


                //Populate Family Tree
                //textTreeName.Text = d.Name;
                //textTreeMother.Text = d.MotherName;
                //textTreeFather.Text = d.FatherName;


            }
            catch (Exception r)
            {
                MessageBox.Show(r.Message, "Update GUI Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog d = new OpenFileDialog();
            d.Filter = "Image files|*.jpg;*.png;*gif";
            DialogResult dl = d.ShowDialog();
            if (dl == DialogResult.Cancel)
                return;
            imagePictureBox.Image = Image.FromFile(d.FileName);
            txtBrowse.Text = d.FileName;
        }
        public int Search(int ID, BL.Dog Dog)
        {
            int rc = 0;
            bool dataRead = false;
            con = new SqlConnection(conString);

            try
            {
                con.Open();
                string strSQL = "SELECT * FROM tblDog WHERE DogId =" + ID;
                com = new SqlCommand(strSQL, con);

                IDataReader idr = com.ExecuteReader();
                dataRead = idr.Read();
                if (dataRead == false)
                {
                    rc = -1;
                }
                else
                {
                    while (dataRead)
                    {
                        d = new BL.Dog();
                        //  d.DogId = Convert.ToInt32(idr["DogId"]);
                        ID = Convert.ToInt32(idr["dogId"]);
                      
                        d.DogName = Convert.ToString(idr["dogName"]);
                        d.DogBreed = Convert.ToString(idr["dogBreed"]);
                        d.DogDOB = Convert.ToDateTime(idr["dogDOB"]);
                        d.DogGender = Convert.ToString(idr["DogGender"]);
                        d.DogFather = Convert.ToString(idr["dogFather"]);
                        d.DogMother = Convert.ToString(idr["dogMother"]);
                      

                        DoID = Convert.ToInt32(idr["DogId"]);
                        /////////////////////////////////////

                        dataRead = idr.Read();

                    }

                }
                idr.Close();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }
            return rc;


        }
        public int Delete(int ID)
        {
            int rc = 0;
            con = new SqlConnection(conString);
            try
            {
                con.Open();
                string deleteQuery = string.Format("DELETE FROM tblDog WHERE [DogId]='{0}'", ID);
                com = new SqlCommand(deleteQuery, con);
                rc = com.ExecuteNonQuery();
                if (rc == 0)
                {
                    rc = 1;
                }
                else
                {
                    rc = 0;
                }
            }
            catch (SqlException ex)
            {
                throw new DataException(ex.Message);
            }
            finally
            {
                con.Close();

            }
            return rc;
            //com = new SqlCommand
        }
        public void SaveUpdate()
        {
            d = new BL.Dog();
            con = new SqlConnection(conString);
            con.Open();
            try
            {
                com = new SqlCommand(@"UPDATE tblDog SET  dogName='" +txtUpName + "',dogBreed='" + txtUpBreed + "',dogDOB='" + DateTime.Parse(txtUpDOB.Text) + "',dogGender='" + txtUpGender + "',dogFather='" + txtUpFather + "' ,dogMother='" + txtUpMother + "'WHERE (dogId='" + int.Parse(txtSearch.Text) + "')", con);

                com.ExecuteNonQuery();

                //d.DogName = txtUpName.Text;
                //d.DogBreed = txtUpBreed.Text;
                //d.DogDOB =  DateTime.Parse( txtUpDOB.Text);
                //d.DogFather = txtUpFather.Text;
                //d.DogGender = txtUpGender.Text;
                //d.DogMother = txtUpMother.Text;
                MessageBox.Show("Success");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
          //  finally
            //{
                con.Close();
           // }
            //UpdateGUI();
        }
        public void DisplayAll()
        {
            con = new SqlConnection(conString);
            con.Open();
            try
            {
                com = new SqlCommand("SELECT * FROM tblDog ", con);
                dr = com.ExecuteReader();
                while (dr.Read())
                {
                    ListViewItem lst = new ListViewItem(dr["dogId"].ToString());
                  
                    lst.SubItems.Add(dr["dogName"].ToString());
                    lst.SubItems.Add(dr["dogBreed"].ToString());
                    lst.SubItems.Add(dr["dogDOB"].ToString());
                    lst.SubItems.Add(dr["dogGender"].ToString());
                    lst.SubItems.Add(dr["dogFather"].ToString());
                    lst.SubItems.Add(dr["dogMother"].ToString());
                
                    lstDisplay.Items.Add(lst);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void frmDog_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dogBreedingDBDataSet.tblDog' table. You can move, or remove it, as needed.
         //   this.tblDogTableAdapter.Fill(this.dogBreedingDBDataSet.tblDog);

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Insert();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            int rc = Search(int.Parse(txtSearch.Text), d);
            if (rc == 0)
            {
                txtUpId.Text = txtSearch.Text;
                txtUpName.Text = d.DogName;
              
                txtUpBreed.Text = d.DogBreed;
                txtUpDOB.Text = Convert.ToString(d.DogDOB);
                txtUpGender.Text = d.DogGender;
                txtUpFather.Text = d.DogFather;
                txtUpMother.Text = d.DogMother;
            

            }
            else
            {
                MessageBox.Show("Not Found");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int res = Delete(int.Parse(txtSearch.Text));
            if (res == 0)
            {
                MessageBox.Show("Deleted");
            }
            else
            {
                MessageBox.Show("Not Found");
            }
        }

        private void btn_Save_Update_Click(object sender, EventArgs e)
        {
            SaveUpdate();
            
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdateGUI();
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            DisplayAll();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEx_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
