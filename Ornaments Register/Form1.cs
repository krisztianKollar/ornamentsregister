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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetForPlantReg.Plants' table. You can move, or remove it, as needed.
            this.plantsTableAdapter.Fill(this.dataSetForPlantReg.Plants);

            
        }

        private void CboxGen_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TxtSubsp_TextChanged(object sender, EventArgs e)
        {

        }

        private void createNewPlantToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void saveActualPlantToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void deleteActualPlantToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void uploadPictureForPlantToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void rbCacti_CheckedChanged(object sender, EventArgs e)
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

        private void rbSucc_CheckedChanged(object sender, EventArgs e)
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

        private void rbOther_CheckedChanged(object sender, EventArgs e)
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

        private void rbAll_CheckedChanged(object sender, EventArgs e)
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

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void cactiToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void furtherSucculentsToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void otherPlantsToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void viewAllPlantsToolStripMenuItem_Click(object sender, EventArgs e)
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
