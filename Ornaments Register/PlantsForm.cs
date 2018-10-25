﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;
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

        IConnectionCreater connectionCreater = new SimpleConnectionCreater();

        public PlantsForm()
        {
            InitializeComponent();
            AutoCmpltTxtGen();
            AutoCmpltTxtSp();
            AutoCmpltTxtSubsp();
            AutoCmpltTxtFieldNo();
            AutoCmpltTxtHabit();
            AutoCmpltTxtSyn();
            AutoCmpltTxtSource();
            AutoCmpltTxtReplanted();
            AutoCmpltTxtNotes();
            AutoCmpltTxtType();
        }

        private void PlantsForm_Load(object sender, EventArgs e)
        {
            this.genusTableAdapter.FillGenus(this.dataSetForPlantReg.Genus);

            this.plantsTableAdapter.Fill(this.dataSetForPlantReg.Plants);

        }

        private void TxtSearch_KeyUp(object sender, KeyEventArgs e)
        {
            this.plantsTableAdapter.Search(this.dataSetForPlantReg.Plants, "%" + txtSearch.Text.Trim() + "%");
        }



        private void AutoCmpltTxtField(string sql, TextBox txtField, string column)
        {
            txtField.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtField.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            AutoCompleteStringCollection coll = new AutoCompleteStringCollection();
            try
            {
                using (SQLiteConnection conn = connectionCreater.connect())
                {
                    conn.Open();
                    SQLiteDataAdapter sda = new SQLiteDataAdapter(sql, conn);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        string fieldName = dt.Rows[i][column].ToString();
                        coll.Add(fieldName);
                    }
                    txtField.AutoCompleteCustomSource = coll;
                }
            }
            catch (SqlException e)
            {
                System.Windows.Forms.MessageBox.Show(e.Message);
            }
        }

        private void AutoCmpltTxtGen()
        {
            AutoCmpltTxtField("SELECT Genus FROM Genus", txtGen, "Genus");
        }

        private void AutoCmpltTxtSp()
        {
            AutoCmpltTxtField("SELECT Species FROM Plants", txtSp, "Species");
        }

        private void AutoCmpltTxtSubsp()
        {
            AutoCmpltTxtField("SELECT Subspecies FROM Plants", txtSubsp, "Subspecies");
        }

        private void AutoCmpltTxtFieldNo()
        {
            AutoCmpltTxtField("SELECT FieldNumber FROM Plants", txtFieldNo, "FieldNumber");
        }

        private void AutoCmpltTxtHabit()
        {
            AutoCmpltTxtField("SELECT Habitat FROM Plants", txtHabit, "Habitat");
        }

private void AutoCmpltTxtSyn()
        {
            AutoCmpltTxtField("SELECT Synonym FROM Plants", txtSyn, "Synonym");
        }

private void AutoCmpltTxtSource()
        {
            AutoCmpltTxtField("SELECT Source FROM Plants", txtSource, "source");
        }

private void AutoCmpltTxtReplanted()
        {
            AutoCmpltTxtField("SELECT Replanted FROM Plants", txtReplanted, "Replanted");
        }

private void AutoCmpltTxtNotes()
        {
            AutoCmpltTxtField("SELECT Notes FROM Plants", txtNotes, "Notes");
        }

private void AutoCmpltTxtType()
        {
            AutoCmpltTxtField("SELECT Type FROM Plants", txtType, "Type");
        }


        private int GetNextID()
        {
            return Convert.ToInt32(this.plantsTableAdapter.GetLastID()) + 1;
        }

        private void CreateNewPlantToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtGen.Text = null;
            txtSp.Text = null;
            txtSubsp.Text = null;
            txtFieldNo.Text = null;
            txtHabit.Text = null;
            txtSyn.Text = null;
            txtSource.Text = null;
            txtReplanted.Text = null;
            txtNotes.Text = null;
            txtType.Text = null;
            txtID.Text = GetNextID().ToString();
        }

        private void SaveActualPlantToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {               
                this.plantsTableAdapter.InsertPlant(Convert.ToInt32(txtID.Text.Trim()), txtGen.Text.Trim(), txtSp.Text.Trim(), txtSubsp.Text.Trim(), txtFieldNo.Text.Trim(), txtHabit.Text.Trim(), txtSyn.Text.Trim(), txtSource.Text.Trim(), txtReplanted.Text.Trim(), txtNotes.Text.Trim(), txtType.Text.Trim());
                // need to refresh datasource
                System.Windows.Forms.MessageBox.Show("The plant has successfully saved");
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
                System.Windows.Forms.MessageBox.Show("The plant has successfully deleted");
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
