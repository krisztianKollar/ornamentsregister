using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Drawing;
using System.Windows.Forms;
using Ornaments_Register.Service.Interface;
using Ornaments_Register.Service.Simple;
using System.IO;
using ExcelDataReader;
using Spire.Xls;
using System.ComponentModel;

namespace Ornaments_Register
{
    public partial class PlantsForm : Form
    {

        IConnectionCreater connectionCreater = new SimpleConnectionCreater();
        Alert alert;

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
            comboType.Visible = true;
            txtType.Visible = true;
        }

        private void ShowComboType()
        {
            comboType.Visible = true;
            txtType.Visible = false;
        }

        private void TxtSearch_KeyUp(object sender, KeyEventArgs e)
        {
             
            if (rbCacti.Checked)
            {
                this.plantsTableAdapter.Search_cacti(this.dataSetForPlantReg.Plants, "%" + txtSearch.Text.Trim() + "%");
            }
            else if (rbSucc.Checked)
            {
                this.plantsTableAdapter.Search_succulent(this.dataSetForPlantReg.Plants, "%" + txtSearch.Text.Trim() + "%");
            }
            else if (rbOther.Checked)
            {
                this.plantsTableAdapter.Search_other(this.dataSetForPlantReg.Plants, "%" + txtSearch.Text.Trim() + "%");
            }
            else
            {
                this.plantsTableAdapter.Search(this.dataSetForPlantReg.Plants, "%" + txtSearch.Text.Trim() + "%");
            }
                       
            ChangePlantsLabelStatText();
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
                    conn.Open();
                    SQLiteDataAdapter sda = new SQLiteDataAdapter("SELECT Type FROM TypeTable", conn);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        string type = dt.Rows[i]["Type"].ToString();
                        coll.Add(type);
                    }
                    comboType.DataSource = coll;                    
                }
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message);
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
                ChangePlantsLabelStatText();
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
                ChangePlantsLabelStatText();
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
                ChangePlantsLabelStatText();
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
                ChangePlantsLabelStatText();
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
                string Type = Convert.ToString(comboType.Text);
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
                int id = Convert.ToInt32(txtID.Text.Trim());
                if (id == GetNextID())
                {
                    MessageBox.Show("This ID doesn't belong to any plant. You can not update it. Please choose a real plant.");

                    RefreshView();
                }
                else
                {
                    DialogResult res = MessageBox.Show("Are you sure you want to update this plant? Existing plant with same ID will be overwritten.", "Update confirmation",
                             MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (res == DialogResult.No)
                        RefreshView();
                    else
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
                        MessageBox.Show("The plant has successfully updated");
                        RefreshView();
                    }
                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DeleteActualPlantToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(txtID.Text.Trim());
                if (id == GetNextID())
                {
                    MessageBox.Show("This ID doesn't belong to any plant.");
                    
                    RefreshView();
                }
                else
                {
                    DialogResult res = MessageBox.Show("Are you sure you want to delete this plant?", "Delete confirmation",
                             MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (res == DialogResult.No)
                        RefreshView();
                    else
                    {
                    this.plantsTableAdapter.DeletePlant(id);
                    MessageBox.Show("The plant has successfully deleted");
                    RefreshView();
                    }
                }
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
            
            if (backgroundWorker1.IsBusy != true)
            {
                alert = new Alert();
                alert.Canceled += new EventHandler<EventArgs>(ButtonCancel_Click);
                alert.Show();
                backgroundWorker1.RunWorkerAsync();
            }
        }

        private void ImportExcel()
        {
            try
            {
                IExcelDataReader excelReader;
                OpenFileDialog ope = new OpenFileDialog
                {
                    Filter = "Excel Files|*.xls;*.xlsx;*.xlsm"
                };
                if (ope.ShowDialog() == DialogResult.Cancel)
                    return;
                FileStream stream = new FileStream(ope.FileName, FileMode.Open);
                if (".xls".Equals(Path.GetExtension(ope.FileName), StringComparison.OrdinalIgnoreCase))
                {
                    excelReader = ExcelReaderFactory.CreateBinaryReader(stream);
                }
                else
                {
                    excelReader = ExcelReaderFactory.CreateOpenXmlReader(stream);
                }
                DataSet result = excelReader.AsDataSet();

                DataTable dt = result.Tables[0];
                MessageBox.Show("Importing is in process. Please be patient.");
                foreach (DataRow dr in dt.Rows)
                {
                    string Genus = Convert.ToString(dr[1]).Trim() == "" ? "?" : Convert.ToString(dr[1]).Trim();
                    string Species = Convert.ToString(dr[2]).Trim() == "" ? "?" : Convert.ToString(dr[2]).Trim();
                    string Subspecies = Convert.ToString(dr[3]).Trim() == "" ? null : Convert.ToString(dr[3]).Trim();
                    string FieldNumber = Convert.ToString(dr[4]).Trim() == "" ? null : Convert.ToString(dr[4]).Trim();
                    string Habitat = Convert.ToString(dr[5]).Trim() == "" ? null : Convert.ToString(dr[5]).Trim();
                    string Synonym = Convert.ToString(dr[6]).Trim() == "" ? null : Convert.ToString(dr[6]).Trim();
                    string Source = Convert.ToString(dr[7]).Trim() == "" ? "?" : Convert.ToString(dr[7]).Trim();
                    string Replanted = Convert.ToString(dr[8]).Trim() == "" ? null : Convert.ToString(dr[8]).Trim();
                    string Notes = Convert.ToString(dr[9]).Trim() == "" ? null : Convert.ToString(dr[9]).Trim();
                    string Type = Convert.ToString(dr[10]).Trim() == "" ? "?" : Convert.ToString(dr[10]).Trim();
                    int ID = Convert.ToInt32(Convert.ToString(dr[0]).Trim()) == 0 ? 0 : Convert.ToInt32(Convert.ToString(dr[0]).Trim());

                    this.plantsTableAdapter.InsertPlant(ID, Genus, Species, Subspecies, FieldNumber, Habitat, Synonym, Source, Replanted, Notes, Type);
                    SaveGenusToDb(Genus);
                }
                RefreshView();
                MessageBox.Show("The import is done. If there where any plants with conflicting ID, they were ignored.");
                excelReader.Close();
                stream.Close();
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            } 
        }

        private void ChangePlantsLabelStatText()
        {
            int count = PlantsTableView.RowCount;
            plantsLabelStat.Text = "You have " + count + " plants according this filter/search/view";
        }

        private void PrintToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*printPreviewDialogPlants.Document = printDocumentPlants;
            printPreviewDialogPlants.ShowDialog();*/

            PrintDialog PrintDialogPlants = new PrintDialog();
            PrintDialogPlants.AllowSomePages = true;
            PrintDialogPlants.ShowHelp = true;
            PrintDialogPlants.Document = printDocumentPlants;
            DialogResult result = PrintDialogPlants.ShowDialog();
            if (result == DialogResult.OK)
            {
                printDocumentPlants.Print();
            }
        }

        private void PrintDocumentPlants_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap bitmap = new Bitmap(this.PlantsTableView.Width, this.PlantsTableView.Height);
            PlantsTableView.DrawToBitmap(bitmap, new Rectangle(0, 0, this.PlantsTableView.Width, this.PlantsTableView.Height));
            e.Graphics.DrawImage(bitmap, 10, 10);
        }

        private void ButtonStart_Click(object sender, EventArgs e)
        {
            if (backgroundWorker1.IsBusy != true)
            {
                alert = new Alert();
                alert.Canceled += new EventHandler<EventArgs>(ButtonCancel_Click);
                alert.Show();
                backgroundWorker1.RunWorkerAsync();
            }
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            if (backgroundWorker1.WorkerSupportsCancellation == true)
            {
                backgroundWorker1.CancelAsync();
                alert.Close();
            }
        }

        private void BackgroundWorker1_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;



            for (int i = 1; i <= 10; i++)
            {
                if (worker.CancellationPending == true)
                {
                    e.Cancel = true;
                    break;
                }
                else
                {
                    worker.ReportProgress(i * 10);
                    System.Threading.Thread.Sleep(500);
                }
            }            
        }

        private void BackgroundWorker1_ProgressChanged(object sender, System.ComponentModel.ProgressChangedEventArgs e)
        {
            alert.Message = "In progress, please wait... " + e.ProgressPercentage.ToString() + "%";
            alert.ProgressValue = e.ProgressPercentage;
        }

        private void BackgroundWorker1_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled == true)
            {
                MessageBox.Show("The import was canceled."); // what about transaction? Canceled import means that part of the file is in the db, but another part is not or what?
            }
            else if (e.Error != null)
            {
                MessageBox.Show("Error: " + e.Error.Message);
            }
            else
            {
                MessageBox.Show("The import is done. If there where any plants with conflicting ID, they were ignored.");
            }
            alert.Close();
        }

        private void buttonImport_Click(object sender, EventArgs e)
        {
            ImportExcel();
        }

        private void buttonSearchOther_Click(object sender, EventArgs e)
        {
            this.plantsTableAdapter.Search_other(this.dataSetForPlantReg.Plants, "Astrophytum");
        }
    }
}
