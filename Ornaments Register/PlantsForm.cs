using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ornaments_Register.Service.Interface;
using Ornaments_Register.Service.Simple;

namespace Ornaments_Register
{
    public partial class PlantsForm : Form
    {
        IConnectionCreater connectionCreater;


        public PlantsForm()
        {
            InitializeComponent();
       
        }

        private void PlantsForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetForPlantReg1.Genus' table. You can move, or remove it, as needed.
            this.genusTableAdapter.FillGenus(this.dataSetForPlantReg.Genus);

            // TODO: This line of code loads data into the 'dataSetForPlantReg.Plants' table. You can move, or remove it, as needed.
            this.plantsTableAdapter.Fill(this.dataSetForPlantReg.Plants);

        }

        private void TxtSearch_KeyUp(object sender, KeyEventArgs e)
        {
            this.plantsTableAdapter.Search(this.dataSetForPlantReg.Plants, "%" + txtSearch.Text.Trim() + "%");
        }

        private void CboxGen_KeyUp(object sender, KeyEventArgs e)
        {
            this.genusTableAdapter.SearchGenusInGenus("%" + cboxGen.Text.Trim() + "%");
        }

        private int GetNextID()
        {
            return Convert.ToInt32(this.plantsTableAdapter.GetLastID()) + 1;
        }

        private void CreateNewPlantToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cboxGen.Text = "";
            txtSp.Text = "";
            txtSubsp.Text = "";
            txtFieldNo.Text = "";
            txtHabit.Text = "";
            txtSyn.Text = "";
            txtSource.Text = "";
            txtReplanted.Text = "";
            txtNotes.Text = "";
            cboxType.Text = "";
            txtID.Text = GetNextID().ToString();
        }

        private void SaveActualPlantToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {               
            this.plantsTableAdapter.InsertPlant(Convert.ToInt32(txtID.Text.Trim()), cboxGen.Text.Trim(), txtSp.Text.Trim(), txtSubsp.Text.Trim(), txtFieldNo.Text.Trim(), txtHabit.Text.Trim(), txtSyn.Text.Trim(), txtSource.Text.Trim(), txtReplanted.Text.Trim(), txtNotes.Text.Trim(), cboxType.Text.Trim());
            // need to refresh datasource
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void DeleteActualPlantToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.plantsTableAdapter.DeletePlant(Convert.ToInt32(txtID.Text.Trim()));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void UploadPictureForPlantToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void RbCacti_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                this.plantsTableAdapter.Select_cacti(this.dataSetForPlantReg.Plants);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void RbSucc_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                this.plantsTableAdapter.Succulents(this.dataSetForPlantReg.Plants);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void RbOther_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                this.plantsTableAdapter.Select_other(this.dataSetForPlantReg.Plants);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void RbAll_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                this.plantsTableAdapter.FillBy(this.dataSetForPlantReg.Plants);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void CactiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.plantsTableAdapter.Select_cacti(this.dataSetForPlantReg.Plants);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void FurtherSucculentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.plantsTableAdapter.Succulents(this.dataSetForPlantReg.Plants);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void OtherPlantsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.plantsTableAdapter.Select_other(this.dataSetForPlantReg.Plants);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void ViewAllPlantsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.plantsTableAdapter.FillBy(this.dataSetForPlantReg.Plants);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

    }
}
