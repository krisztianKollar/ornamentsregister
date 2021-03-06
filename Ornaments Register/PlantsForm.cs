﻿using System;
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
using System.ComponentModel;
using Ornaments_Register.Models;
using Ornaments_Register.Service;
using System.Drawing.Drawing2D;

namespace Ornaments_Register
{
    public partial class PlantsForm : Form
    {

        IConnectionCreater connectionCreater = new SimpleConnectionCreater();
        Alert alert;
        List<PictureBox> picBoxes = new List<PictureBox>();
        List<Picture> picturesByPlant = new List<Picture>();

        public PlantsForm()
        {
            InitializeComponent();
            menuStrip1.Renderer = new MyRenderer();
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
        }

        private void PlantsForm_Load(object sender, EventArgs e)
        {
            this.picturesTableAdapter.FillPic(this.dataSetForPlantReg.Pictures);
            this.genusTableAdapter.FillGenus(this.dataSetForPlantReg.Genus);
            //this.picturesTableAdapter.FillPic(this.dataSetForPlantReg.Pictures);
            FillPicBoxes();
            rbAll.Checked = true;
            this.PictureGroupBox.Width = this.Width - (PlantDetailsBox.Width + 55);
            this.PlantsTableView.Width = this.Width - 50;
            PlantsTableView.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            PlantsTableView.DefaultCellStyle.SelectionBackColor = Color.SaddleBrown;
            ChangeBoxColor();
            ViewAll();
            
        }

        private void ChangeBoxColor()
        {
            TextBox[] textBoxes = new TextBox[] { txtGen, txtSp, txtSubsp, txtFieldNo, txtHabit, txtSyn, txtSource, txtReplanted, txtNotes, txtID, txtSearch };
            foreach (TextBox textBox in textBoxes)
            {
                textBox.ForeColor = Color.SaddleBrown;
            }
            comboType.ForeColor = Color.SaddleBrown;

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
                MessageBox.Show(e.Message);
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

        private void SetCurrentTypeByGenus()
        {
            string genus = txtGen.Text.Trim();
            if (this.genusTableAdapter.SelectByGenus(genus).Rows.Count == 1)
            {
                comboType.Text = this.genusTableAdapter.SelectTypeByGenus(genus).ToString();
            }
        }

        private int GetNextID()
        {
            return Convert.ToInt32(this.plantsTableAdapter.GetLastID()) + 1;
        }

        private void ViewCacti()
        {
            try
            {
                this.plantsTableAdapter.Select_cacti(this.dataSetForPlantReg.Plants);
                ChangePlantsLabelStatText();
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ViewSucc()
        {
            try
            {
                this.plantsTableAdapter.Succulents(this.dataSetForPlantReg.Plants);
                ChangePlantsLabelStatText();
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ViewOther()
        {
            try
            {
                this.plantsTableAdapter.Select_other(this.dataSetForPlantReg.Plants);
                ChangePlantsLabelStatText();
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ViewAll()
        {
            try
            {
                this.plantsTableAdapter.FillBy(this.dataSetForPlantReg.Plants);
                ChangePlantsLabelStatText();
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
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

        private bool IsGenusNew(string Genus)
        {
            if (this.genusTableAdapter.SelectByGenus(Genus).Rows.Count == 0)
                return true;
            return false;
        }

        private bool SaveGenusToDb(string Genus)
        {
            if (this.genusTableAdapter.SelectByGenus(Genus).Rows.Count == 0)
            {
                DialogResult res = MessageBox.Show(Genus.ToUpper() + " genus doesn't exists in the database. Would you like to save the genus?", "Saving new genus to db?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res == DialogResult.No)
                    return false;
                else
                {
                    this.genusTableAdapter.InsertNewGenus(Genus, comboType.Text.Trim());
                    return true;
                }
            }
            return false;
        }

        private void CreateNewPlantToolStripMenuItem_Click(object sender, EventArgs e)
        {
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
                string Genus = txtGen.Text.Trim().Length == 0 ? null : txtGen.Text.Trim();
                string Species = txtSp.Text.Trim().Length == 0 ? null : txtSp.Text.Trim();
                string Subspecies = txtSubsp.Text.Trim().Length == 0 ? null : txtSubsp.Text.Trim();
                string FieldNumber = txtFieldNo.Text.Trim().Length == 0 ? null : txtFieldNo.Text.Trim();
                string Habitat = txtHabit.Text.Trim().Length == 0 ? null : txtHabit.Text.Trim();
                string Synonym = txtSyn.Text.Trim().Length == 0 ? null : txtSyn.Text.Trim();
                string Source = txtSource.Text.Trim().Length == 0 ? null : txtSource.Text.Trim();
                string Replanted = txtReplanted.Text.Trim().Length == 0 ? null : txtReplanted.Text.Trim();
                string Notes = txtNotes.Text.Trim().Length == 0 ? null : txtNotes.Text.Trim();
                string Type = Convert.ToString(comboType.Text);
                int ID = Convert.ToInt32(txtID.Text.Trim());

                if (IsGenusNew(Genus))
                {
                    if (SaveGenusToDb(Genus))
                    {
                        this.plantsTableAdapter.InsertPlant(ID, Genus, Species, Subspecies, FieldNumber, Habitat, Synonym, Source, Replanted, Notes, Type);
                        MessageBox.Show("The plant has successfully saved");
                        RefreshView();
                    }
                    else
                    {
                        return;
                    }
                }
                else
                {
                    this.plantsTableAdapter.InsertPlant(ID, Genus, Species, Subspecies, FieldNumber, Habitat, Synonym, Source, Replanted, Notes, Type);
                    MessageBox.Show("The plant has successfully saved");
                    RefreshView();
                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void UpdateActualPlantToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(txtID.Text.Trim());
                if (id == GetNextID())
                {
                    MessageBox.Show("This ID doesn't belong to any plant. You can not update it. Please choose a real plant or press save.");

                    return;
                }
                else
                {
                    DialogResult res = MessageBox.Show("Are you sure you want to update this plant? Existing plant with same ID will be overwritten.", "Update confirmation",
                             MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (res == DialogResult.No)
                        return;
                    else
                    {
                        string Genus = txtGen.Text.Trim().Length == 0 ? null : txtGen.Text.Trim();
                        string Species = txtSp.Text.Trim().Length == 0 ? null : txtSp.Text.Trim();
                        string Subspecies = txtSubsp.Text.Trim().Length == 0 ? null : txtSubsp.Text.Trim();
                        string FieldNumber = txtFieldNo.Text.Trim().Length == 0 ? null : txtFieldNo.Text.Trim();
                        string Habitat = txtHabit.Text.Trim().Length == 0 ? null : txtHabit.Text.Trim();
                        string Synonym = txtSyn.Text.Trim().Length == 0 ? null : txtSyn.Text.Trim();
                        string Source = txtSource.Text.Trim().Length == 0 ? null : txtSource.Text.Trim();
                        string Replanted = txtReplanted.Text.Trim().Length == 0 ? null : txtReplanted.Text.Trim();
                        string Notes = txtNotes.Text.Trim().Length == 0 ? null : txtNotes.Text.Trim();
                        string Type = Convert.ToString(comboType.Text);
                        int ID = Convert.ToInt32(txtID.Text.Trim());

                        if (IsGenusNew(Genus))
                        {
                            if (SaveGenusToDb(Genus))
                            {
                                this.plantsTableAdapter.UpdatePlant(Genus, Species, Subspecies, FieldNumber, Habitat, Synonym, Source, Replanted, Notes, Type, ID);
                                MessageBox.Show("The plant has successfully updated");
                                RefreshView();
                            }
                            else
                            {
                                return;
                            }
                        }
                        else
                        {
                            this.plantsTableAdapter.UpdatePlant(Genus, Species, Subspecies, FieldNumber, Habitat, Synonym, Source, Replanted, Notes, Type, ID);
                            MessageBox.Show("The plant has successfully updated");
                            RefreshView();
                        }
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

                    return;
                }
                else
                {
                    DialogResult res = MessageBox.Show("Are you sure you want to delete this plant?", "Delete confirmation",
                             MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (res == DialogResult.No)
                        return;
                    else
                    {
                        this.plantsTableAdapter.DeletePlant(id);
                        MessageBox.Show("The plant has been successfully deleted");
                        RefreshView();
                    }
                }
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
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
            DataTable dt = ImportExcel();
            if (dt != null)
            {
                backgroundWorker1.RunWorkerAsync(dt);
                alert = new Alert();
                alert.Show();
            }
        }

        private DataTable ImportExcel()
        {
            try
            {
                DialogResult res = MessageBox.Show("Are you sure you want to import a file? If you have plants in the database, new plants with same ID will be ignored.", "Import confirmation",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res == DialogResult.No)
                {
                    RefreshView();
                    return null;
                }
                else
                {
                    IExcelDataReader excelReader;
                    OpenFileDialog ope = new OpenFileDialog
                    {
                        Filter = "Excel Files|*.xls;*.xlsx;*.xlsm"
                    };
                    if (ope.ShowDialog() == DialogResult.Cancel)
                        return null;

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

                    excelReader.Close();
                    stream.Close();
                    return dt;
                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show("There is no data from excel.");

                return null;
            }
        }

        private void ChangePlantsLabelStatText()
        {
            int count = PlantsTableView.RowCount;
            plantsLabelStat.Text = "You have " + count + " plants according this filter/search/view";
        }

        private void PrintToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintDialog PrintDialogPlants = new PrintDialog
            {
                AllowSomePages = true,
                ShowHelp = true,
                Document = printDocumentPlants
            };
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

        private void BackgroundWorker1_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;
            DataTable dt = (DataTable)e.Argument;

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                double onePercent = dt.Rows.Count / 100;
                int counter = i / ((int)Math.Ceiling(onePercent));

                if (worker.CancellationPending == true)
                {
                    e.Cancel = true;
                    break;
                }
                else
                {
                    DataRow dr = dt.Rows[i];
                    string Genus = Convert.ToString(dr[1]).Trim() == "" ? "?" : Convert.ToString(dr[1]).Trim();
                    string Species = Convert.ToString(dr[2]).Trim() == "" ? "sp." : Convert.ToString(dr[2]).Trim();
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

                    worker.ReportProgress(counter);
                }
            }
            PlantsTableView.Refresh();
        }

        private void BackgroundWorker1_ProgressChanged(object sender, System.ComponentModel.ProgressChangedEventArgs e)
        {
            alert.Message = e.ProgressPercentage.ToString() + "%";
            alert.ProgressValue = e.ProgressPercentage;
        }

        private void BackgroundWorker1_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            RefreshView();
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

        private void ExportToExcelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet("DataSetToExcel")
            {
                Locale = System.Threading.Thread.CurrentThread.CurrentCulture
            };

            DataTable dt = dataSetForPlantReg.Plants;
            DataTable dtCloned = dt.Clone();
            dtCloned.Columns[0].DataType = typeof(Int32);
            foreach (DataRow row in dt.Rows)
            {
                dtCloned.ImportRow(row);
            }

            ds.Tables.Add(dtCloned);

            ChangeTypesForExcel(ds);

            ExcelLibrary.DataSetHelper.CreateWorkbook("Ornaments_Register.xls", ds);
            MessageBox.Show("Ornaments_Register.xls has been created");
        }

        private DataSet ChangeTypesForExcel(DataSet dataSet)
        {
            try
            {
                foreach (DataTable dt in dataSet.Tables)
                    foreach (DataRow dr in dt.Rows)
                        foreach (DataColumn dc in dt.Columns)
                        {
                            if (String.IsNullOrEmpty(Convert.ToString(dr[dc])))
                            {
                                dr[dc] = string.Empty;
                            }
                        }
                return dataSet;
            }
            catch (Exception ex)
            {
                return dataSet;
            }
        }

        private void TxtGen_TextChanged(object sender, EventArgs e)
        {
            SetCurrentTypeByGenus();
        }

        private void ToolStripButtonRefresh_Click(object sender, EventArgs e)
        {
            RefreshView();
        }

        private void PlantsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to close?", "Exit now?", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void FillPicBoxes()
        {
            int cells = tableLayPanPic.ColumnCount * tableLayPanPic.RowCount;
            for (int i = 1; i <= cells; i++)
            {
                var picBox = (PictureBox)PlantsForm.ActiveForm.Controls.Find("picBox" + i, true)[0];
                picBoxes.Add(picBox);
            }
        }

        private List<Picture> PicturesByPlant()
        {
            int PlantID = Convert.ToInt32(txtID.Text.Trim());
            List<Picture> picturesByPlant = new List<Picture>();
            DataTable dt = this.picturesTableAdapter.GetDataByPlantID(PlantID);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                int picID = Convert.ToInt32(dt.Rows[i]["PicID"]);
                byte[] Data = (byte[])dt.Rows[i]["Data"];
                MemoryStream ms = new MemoryStream(Data);
                Image imageFromArray = Image.FromStream(ms);
                Picture picture = new Picture(picID, PlantID, imageFromArray);
                picturesByPlant.Add(picture);
            }
            return picturesByPlant;
        }

        private void FillPicFromDb()
        {
            ClearPicBoxes();
            picturesByPlant = PicturesByPlant();
            for (int i = 0; i < picturesByPlant.Count; i++)
            {
                for (int j = 0; j < picturesByPlant.Count; j++)
                {
                    picBoxes[j].Image = picturesByPlant[j].Image;
                    picBoxes[j].Tag = picturesByPlant[j].PicID;
                }
            }
            pictureBox1.Image = picBoxes[0].Image;
            pictureBox1.Tag = picBoxes[0].Tag;
        }

        private void ClearPicBoxes()
        {
            for (int i = 0; i < picBoxes.Count; i++)
            {
                picBoxes[i].Image = null;
            }
        }

        private void StorePic(Image picture)
        {
            int PlantID = Convert.ToInt32(txtID.Text.Trim());
            int PicID = Convert.ToInt32(this.picturesTableAdapter.GetLastPicID()) + 1;
            if (picture != null)
            {
                MemoryStream ms = new MemoryStream();
                picture.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                byte[] Data = ms.ToArray();
                ms.Close();
                this.picturesTableAdapter.InsertPic(PicID, PlantID, Data);
            }
        }

        private void OpenPic()
        {
            try
            {
                OpenFileDialog ope = new OpenFileDialog
                {
                    Filter = "Image Files  (*.jpg ; *.jpeg ; *.png ; *.gif ; *.tiff) | *.jpg; *.jpeg; *.png; *.gif; *.tiff"
                };
                ope.Multiselect = true;
                DialogResult dr = ope.ShowDialog();

                if (dr == System.Windows.Forms.DialogResult.OK)
                {
                    string[] files = ope.FileNames;
                    List<string> picNames = new List<string>();
                    int imageCount = 0;
                    foreach (PictureBox pic in picBoxes)
                        if (pic.Image != null)
                            imageCount++;
                    if (files.Length + imageCount > picBoxes.Count)
                    {
                        MessageBox.Show("You can add max. 12 images to a plant.");
                        return;
                    }

                    foreach (String file in files)
                    {
                        for (int i = 0; i < picBoxes.Count; i++)
                        {
                            if ((picBoxes[i].Image != null) || (picNames.Contains(file)))
                                continue;
                            picBoxes[i].Image = Image.FromFile(file);
                            picNames.Add(file);
                            StorePic(picBoxes[i].Image);
                        }
                    }
                    pictureBox1.Image = picBoxes[0].Image;
                    MessageBox.Show(files.Length.ToString() + " picture(s) was successfully saved to database");
                    FillPicFromDb();
                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
                //return null;
            }
        }

        private void AddPictureToPlantToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenPic();
        }

        private void BoxColor_Enter(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            textBox.BackColor = Color.SaddleBrown;
            textBox.ForeColor = Color.White;
        }

        private void BoxColor_Leave(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            textBox.BackColor = Color.White;
            textBox.ForeColor = Color.SaddleBrown;
        }

        private void ComboBoxColor(object sender, EventArgs e)
        {
            ComboBox comBox = (ComboBox)sender;

            if (comBox.BackColor == Color.White && comBox.ForeColor == Color.SaddleBrown)
            {
                comBox.BackColor = Color.SaddleBrown;
                comBox.ForeColor = Color.White;
            }
            else
            {
                comBox.BackColor = Color.White;
                comBox.ForeColor = Color.SaddleBrown;
            }

        }

        private void ComboType_DrawItem(object sender, DrawItemEventArgs e)
        {
            Brush brush = null;
            ComboBox combo;

            try
            {
                e.DrawBackground();
                combo = (ComboBox)sender;
                brush = Brushes.SaddleBrown;
                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void PicBox_Click(object sender, EventArgs e)
        {
            PictureBox pic = (PictureBox)sender;
            if (pic.Image != null)
            {
                pictureBox1.Image = pic.Image;
                pictureBox1.Tag = pic.Tag;
            }

        }

        private void PicBox_MouseHover(object sender, EventArgs e)
        {
            PictureBox pic = (PictureBox)sender;
            pic.Cursor = Cursors.Hand;
        }

        private void PicBox_MouseLeave(object sender, EventArgs e)
        {
            PictureBox pic = (PictureBox)sender;
            pic.Cursor = Cursors.Default;
        }

        private void TxtID_TextChanged(object sender, EventArgs e)
        {
            FillPicFromDb();
        }

        private void DeleteImageFromPlantToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                int id = (int)pictureBox1.Tag;

                DialogResult res = MessageBox.Show("Are you sure you want to delete the actual picture?", "Delete picture?",
                         MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res == DialogResult.No)
                    return;
                else
                {
                    this.picturesTableAdapter.DeleteByPicID(id);
                    MessageBox.Show("Picture has been successfully deleted");
                    FillPicFromDb();
                }

            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void DeleteAllImagesFromPlantToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(txtID.Text.Trim());
                if (id == GetNextID())
                {
                    MessageBox.Show("This ID doesn't belong to any picture.");
                    return;
                }
                else if (picBoxes[0].Image == null)
                {
                    MessageBox.Show("This plant hasn't got any picture.");
                    return;
                }
                else
                {
                    DialogResult res = MessageBox.Show("Are you sure you want to delete all picture from this plant?", "Delete picture?",
                             MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (res == DialogResult.No)
                        return;
                    else
                    {
                        this.picturesTableAdapter.DeleteByPlantID(id);
                        MessageBox.Show("Every picture has been successfully deleted");
                        FillPicFromDb();
                        return;
                    }
                }
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }

        private void DeleteAllImagesFromDatabaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult res = MessageBox.Show("Are you sure you want to delete all picture from the whole database?", "Delete all picture?",
                         MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res == DialogResult.No)
                    return;
                else
                {
                    this.picturesTableAdapter.DeleteAllPicFromDb();
                    MessageBox.Show("Every picture has been successfully deleted");
                    FillPicFromDb();
                    return;
                }
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }
    }
}
