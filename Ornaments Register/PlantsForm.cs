using System;
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
using Ornaments_Register.Models;
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
            FillComboType();
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
            HideComboType();
            rbAll.Checked = true;
            ViewAll();

        }

        private void HideComboType()
        {
            comboType.Visible = false;
            txtType.Visible = true;
        }

        private void ShowComboType()
        {
            comboType.Visible = true;
            txtType.Visible = false;
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

        private void FillComboType()
        {
            try
            {
                using (SQLiteConnection conn = connectionCreater.connect())
                {
                    List<string> coll = new List<string>();
                    //List<Plant> plants = new SimplePlantService(connectionCreater).GetAll();
                    conn.Open();
                    SQLiteDataAdapter sda = new SQLiteDataAdapter("SELECT DISTINCT Type FROM Plants", conn);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        string type = dt.Rows[i]["Type"].ToString();
                        coll.Add(type);
                    }
                    comboType.DataSource = coll;
                    /*foreach (Plant plant in plants)
                    {
                        comboType.SelectedValue = plant.Type;
                    }*/
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

        private void ViewCacti()
        {
            try
            {
                HideComboType();
                this.plantsTableAdapter.Select_cacti(this.dataSetForPlantReg.Plants);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void ViewSucc()
        {
            try
            {
                HideComboType();
                this.plantsTableAdapter.Succulents(this.dataSetForPlantReg.Plants);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void ViewOther()
        {
            try
            {
                HideComboType();
                this.plantsTableAdapter.Select_other(this.dataSetForPlantReg.Plants);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void ViewAll()
        {
            try
            {
                HideComboType();
                this.plantsTableAdapter.FillBy(this.dataSetForPlantReg.Plants);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void RefreshView()
        {
            if (rbCacti.Checked)
            {
                rbCacti.Checked = true;
                ViewCacti();
            }
            else if (rbSucc.Checked)
            {
                rbSucc.Checked = true;
                ViewSucc();
            }
            else if (rbOther.Checked)
            {
                rbOther.Checked = true;
                ViewOther();
            }
            else
            {
                rbAll.Checked = true;
                ViewAll();
            }
        }

        private void SaveGenusToDb(string Genus)
        {
            if (this.genusTableAdapter.SelectByGenus(Genus).Rows.Count == 0)
                this.genusTableAdapter.InsertNewGenus(Genus);
        }

        private void CreateNewPlantToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowComboType();
            txtGen.Text = String.Empty;
            txtSp.Text = String.Empty;
            txtSubsp.Text = String.Empty;
            txtFieldNo.Text = String.Empty;
            txtHabit.Text = String.Empty;
            txtSyn.Text = String.Empty;
            txtSource.Text = String.Empty;
            txtReplanted.Text = String.Empty;
            txtNotes.Text = String.Empty;
            txtID.Text = GetNextID().ToString();
        }

        private void SaveActualPlantToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                string Genus = txtGen.Text.Length == 0 ? null : txtGen.Text.Trim();
                string Species = txtSp.Text.Length == 0 ? null : txtSp.Text.Trim();
                string Subspecies = txtSubsp.Text.Length == 0 ? null : txtSubsp.Text.Trim();
                string FieldNumber = txtFieldNo.Text.Length == 0 ? null : txtFieldNo.Text.Trim();
                string Habitat = txtHabit.Text.Length == 0 ? null : txtHabit.Text.Trim();
                string Synonym = txtSyn.Text.Length == 0 ? null : txtSyn.Text.Trim();
                string Source = txtSource.Text.Length == 0 ? null : txtSource.Text.Trim();
                string Replanted = txtReplanted.Text.Length == 0 ? null : txtReplanted.Text.Trim();
                string Notes = txtNotes.Text.Length == 0 ? null : txtNotes.Text.Trim();
                string Type = comboType.Text.Length == 0 ? null : txtType.Text.Trim();
                int ID = Convert.ToInt32(txtID.Text.Trim());
                this.plantsTableAdapter.InsertPlant(ID, Genus, Species, Subspecies, FieldNumber, Habitat, Synonym, Source, Replanted, Notes, Type);
                SaveGenusToDb(Genus);
                System.Windows.Forms.MessageBox.Show("The plant has successfully saved");
                RefreshView();
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void UpdateActualPlantToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                string Genus = txtGen.Text.Length == 0 ? null : txtGen.Text.Trim();
                string Species = txtSp.Text.Length == 0 ? null : txtSp.Text.Trim();
                string Subspecies = txtSubsp.Text.Length == 0 ? null : txtSubsp.Text.Trim();
                string FieldNumber = txtFieldNo.Text.Length == 0 ? null : txtFieldNo.Text.Trim();
                string Habitat = txtHabit.Text.Length == 0 ? null : txtHabit.Text.Trim();
                string Synonym = txtSyn.Text.Length == 0 ? null : txtSyn.Text.Trim();
                string Source = txtSource.Text.Length == 0 ? null : txtSource.Text.Trim();
                string Replanted = txtReplanted.Text.Length == 0 ? null : txtReplanted.Text.Trim();
                string Notes = txtNotes.Text.Length == 0 ? null : txtNotes.Text.Trim();
                string Type = txtType.Text.Length == 0 ? null : txtType.Text.Trim();
                int ID = Convert.ToInt32(txtID.Text.Trim());
                this.plantsTableAdapter.UpdatePlant(Genus, Species, Subspecies, FieldNumber, Habitat, Synonym, Source, Replanted, Notes, Type, ID);
                SaveGenusToDb(Genus);
                System.Windows.Forms.MessageBox.Show("The plant has successfully updated");
                RefreshView();
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
                RefreshView();
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
            ViewCacti();
        }

        private void RbSucc_CheckedChanged(object sender, EventArgs e)
        {
            ViewSucc();
        }

        private void RbOther_CheckedChanged(object sender, EventArgs e)
        {
            ViewOther();
        }

        private void RbAll_CheckedChanged(object sender, EventArgs e)
        {
            ViewAll();
        }

        private void CactiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rbCacti.Checked = true;
            ViewCacti();
        }

        private void FurtherSucculentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rbSucc.Checked = true;
            ViewSucc();
        }

        private void OtherPlantsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rbOther.Checked = true;
            ViewOther();
        }

        private void ViewAllPlantsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rbAll.Checked = true;
            ViewAll();
        }

        private void PlantsForm_Resize(object sender, EventArgs e)
        {
            PlantsBox.Width = (PlantsBox.Parent.Width / 100) * 99;
            //PlantsBox.Height = (PlantsBox.Parent.Width / 100) * 15;
            PlantsTableView.Width = PlantsTableView.Parent.Width;

            
        }

        private void ImportExcelFileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
