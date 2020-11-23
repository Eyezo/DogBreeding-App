namespace FinalProject2013.PL
{
    partial class frmDoctor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tblDogBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dogBreedingDBDataSet = new FinalProject2013.DogBreedingDBDataSet();
            this.tblDogTableAdapter = new FinalProject2013.DogBreedingDBDataSetTableAdapters.tblDogTableAdapter();
            this.tableAdapterManager = new FinalProject2013.DogBreedingDBDataSetTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.tblDogBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dogBreedingDBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // tblDogBindingSource
            // 
            this.tblDogBindingSource.DataMember = "tblDog";
            this.tblDogBindingSource.DataSource = this.dogBreedingDBDataSet;
            // 
            // dogBreedingDBDataSet
            // 
            this.dogBreedingDBDataSet.DataSetName = "DogBreedingDBDataSet";
            this.dogBreedingDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblDogTableAdapter
            // 
            this.tblDogTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tblClientTableAdapter = null;
            this.tableAdapterManager.tblCostTableAdapter = null;
            this.tableAdapterManager.tblDoctorTableAdapter = null;
            this.tableAdapterManager.tblDogTableAdapter = this.tblDogTableAdapter;
            this.tableAdapterManager.tblMatingTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = FinalProject2013.DogBreedingDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // frmDoctor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Olive;
            this.ClientSize = new System.Drawing.Size(775, 698);
            this.Name = "frmDoctor";
            this.Text = "Doctor Information";
            this.Load += new System.EventHandler(this.frmDoctor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblDogBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dogBreedingDBDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DogBreedingDBDataSet dogBreedingDBDataSet;
        private System.Windows.Forms.BindingSource tblDogBindingSource;
        private DogBreedingDBDataSetTableAdapters.tblDogTableAdapter tblDogTableAdapter;
        private DogBreedingDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
    }
}