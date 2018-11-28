namespace Ornaments_Register
{
    partial class PlantsForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlantsForm));
            this.PlantDetailsBox = new System.Windows.Forms.GroupBox();
            this.dateTimePickerReplanted = new System.Windows.Forms.DateTimePicker();
            this.plantsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetForPlantReg = new Ornaments_Register.DataSetForPlantReg();
            this.comboType = new System.Windows.Forms.ComboBox();
            this.txtGen = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.labType = new System.Windows.Forms.Label();
            this.labID = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.rbAll = new System.Windows.Forms.RadioButton();
            this.labSearch = new System.Windows.Forms.Label();
            this.rbOther = new System.Windows.Forms.RadioButton();
            this.rbSucc = new System.Windows.Forms.RadioButton();
            this.rbCacti = new System.Windows.Forms.RadioButton();
            this.labShow = new System.Windows.Forms.Label();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.txtSubsp = new System.Windows.Forms.TextBox();
            this.txtReplanted = new System.Windows.Forms.TextBox();
            this.txtSource = new System.Windows.Forms.TextBox();
            this.txtSyn = new System.Windows.Forms.TextBox();
            this.txtHabit = new System.Windows.Forms.TextBox();
            this.txtFieldNo = new System.Windows.Forms.TextBox();
            this.txtSp = new System.Windows.Forms.TextBox();
            this.labNotes = new System.Windows.Forms.Label();
            this.labSource = new System.Windows.Forms.Label();
            this.labReplanted = new System.Windows.Forms.Label();
            this.labSyn = new System.Windows.Forms.Label();
            this.labHabit = new System.Windows.Forms.Label();
            this.labFieldNo4 = new System.Windows.Forms.Label();
            this.labSubsp = new System.Windows.Forms.Label();
            this.labSp = new System.Windows.Forms.Label();
            this.labGen = new System.Windows.Forms.Label();
            this.genusBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.viewPlantsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cactiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.furtherSucculentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.otherPlantsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewAllPlantsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createNewPlantToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveActualPlantToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateActualPlantToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteActualPlantToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importExcelFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importFromExcelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToExcelToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.picturesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addPictureToPlantToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteImageFromPlantToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteAllImagesFromPlantToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteAllImagesFromDatabaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.PlantsBox = new System.Windows.Forms.GroupBox();
            this.plantsLabelStat = new System.Windows.Forms.Label();
            this.PlantsTableView = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.speciesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subspeciesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fieldNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.habitatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.synonymDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sourceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.replantedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fillByTypeToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.plantsTableAdapter = new Ornaments_Register.DataSetForPlantRegTableAdapters.PlantsTableAdapter();
            this.genusTableAdapter = new Ornaments_Register.DataSetForPlantRegTableAdapters.GenusTableAdapter();
            this.toolTipComboType = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipNotes = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipReplanted = new System.Windows.Forms.ToolTip(this.components);
            this.printDocumentPlants = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialogPlants = new System.Windows.Forms.PrintPreviewDialog();
            this.printDialogPlants = new System.Windows.Forms.PrintDialog();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.bindingNavigatorMoveFirstItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveNextItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigator2 = new System.Windows.Forms.BindingNavigator(this.components);
            this.toolStripButtonRefresh = new System.Windows.Forms.ToolStripButton();
            this.PictureGroupBox = new System.Windows.Forms.GroupBox();
            this.dataGridPic = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewImageColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PlantDetailsBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.plantsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetForPlantReg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.genusBindingSource)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.PlantsBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PlantsTableView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator2)).BeginInit();
            this.bindingNavigator2.SuspendLayout();
            this.PictureGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // PlantDetailsBox
            // 
            this.PlantDetailsBox.BackColor = System.Drawing.Color.Transparent;
            this.PlantDetailsBox.Controls.Add(this.dateTimePickerReplanted);
            this.PlantDetailsBox.Controls.Add(this.comboType);
            this.PlantDetailsBox.Controls.Add(this.txtGen);
            this.PlantDetailsBox.Controls.Add(this.txtID);
            this.PlantDetailsBox.Controls.Add(this.labType);
            this.PlantDetailsBox.Controls.Add(this.labID);
            this.PlantDetailsBox.Controls.Add(this.txtSearch);
            this.PlantDetailsBox.Controls.Add(this.rbAll);
            this.PlantDetailsBox.Controls.Add(this.labSearch);
            this.PlantDetailsBox.Controls.Add(this.rbOther);
            this.PlantDetailsBox.Controls.Add(this.rbSucc);
            this.PlantDetailsBox.Controls.Add(this.rbCacti);
            this.PlantDetailsBox.Controls.Add(this.labShow);
            this.PlantDetailsBox.Controls.Add(this.txtNotes);
            this.PlantDetailsBox.Controls.Add(this.txtSubsp);
            this.PlantDetailsBox.Controls.Add(this.txtReplanted);
            this.PlantDetailsBox.Controls.Add(this.txtSource);
            this.PlantDetailsBox.Controls.Add(this.txtSyn);
            this.PlantDetailsBox.Controls.Add(this.txtHabit);
            this.PlantDetailsBox.Controls.Add(this.txtFieldNo);
            this.PlantDetailsBox.Controls.Add(this.txtSp);
            this.PlantDetailsBox.Controls.Add(this.labNotes);
            this.PlantDetailsBox.Controls.Add(this.labSource);
            this.PlantDetailsBox.Controls.Add(this.labReplanted);
            this.PlantDetailsBox.Controls.Add(this.labSyn);
            this.PlantDetailsBox.Controls.Add(this.labHabit);
            this.PlantDetailsBox.Controls.Add(this.labFieldNo4);
            this.PlantDetailsBox.Controls.Add(this.labSubsp);
            this.PlantDetailsBox.Controls.Add(this.labSp);
            this.PlantDetailsBox.Controls.Add(this.labGen);
            this.PlantDetailsBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PlantDetailsBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.PlantDetailsBox.Location = new System.Drawing.Point(12, 33);
            this.PlantDetailsBox.Name = "PlantDetailsBox";
            this.PlantDetailsBox.Size = new System.Drawing.Size(465, 258);
            this.PlantDetailsBox.TabIndex = 0;
            this.PlantDetailsBox.TabStop = false;
            this.PlantDetailsBox.Text = "PLANT DETAILS";
            // 
            // dateTimePickerReplanted
            // 
            this.dateTimePickerReplanted.CustomFormat = "";
            this.dateTimePickerReplanted.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.plantsBindingSource, "Replanted", true));
            this.dateTimePickerReplanted.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerReplanted.Location = new System.Drawing.Point(332, 144);
            this.dateTimePickerReplanted.Name = "dateTimePickerReplanted";
            this.dateTimePickerReplanted.Size = new System.Drawing.Size(117, 20);
            this.dateTimePickerReplanted.TabIndex = 30;
            // 
            // plantsBindingSource
            // 
            this.plantsBindingSource.DataMember = "Plants";
            this.plantsBindingSource.DataSource = this.dataSetForPlantReg;
            // 
            // dataSetForPlantReg
            // 
            this.dataSetForPlantReg.DataSetName = "DataSetForPlantReg";
            this.dataSetForPlantReg.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboType
            // 
            this.comboType.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.plantsBindingSource, "Type", true));
            this.comboType.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.plantsBindingSource, "Type", true));
            this.comboType.DataSource = this.plantsBindingSource;
            this.comboType.DisplayMember = "Type";
            this.comboType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboType.FormattingEnabled = true;
            this.comboType.Location = new System.Drawing.Point(332, 173);
            this.comboType.Name = "comboType";
            this.comboType.Size = new System.Drawing.Size(121, 21);
            this.comboType.TabIndex = 29;
            this.comboType.TabStop = false;
            this.toolTipComboType.SetToolTip(this.comboType, "You can choose the type of plant");
            this.comboType.ValueMember = "Type";
            this.comboType.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.ComboType_DrawItem);
            this.comboType.Enter += new System.EventHandler(this.ComboBoxColor);
            this.comboType.Leave += new System.EventHandler(this.ComboBoxColor);
            // 
            // txtGen
            // 
            this.txtGen.BackColor = System.Drawing.SystemColors.Window;
            this.txtGen.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.plantsBindingSource, "Genus", true));
            this.txtGen.Location = new System.Drawing.Point(103, 17);
            this.txtGen.Name = "txtGen";
            this.txtGen.Size = new System.Drawing.Size(150, 20);
            this.txtGen.TabIndex = 9;
            this.txtGen.TabStop = false;
            this.txtGen.TextChanged += new System.EventHandler(this.TxtGen_TextChanged);
            this.txtGen.Enter += new System.EventHandler(this.BoxColor_Enter);
            this.txtGen.Leave += new System.EventHandler(this.BoxColor_Leave);
            // 
            // txtID
            // 
            this.txtID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.plantsBindingSource, "ID", true));
            this.txtID.Location = new System.Drawing.Point(362, 17);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(91, 20);
            this.txtID.TabIndex = 18;
            this.txtID.TabStop = false;
            this.txtID.Enter += new System.EventHandler(this.BoxColor_Enter);
            this.txtID.Leave += new System.EventHandler(this.BoxColor_Leave);
            // 
            // labType
            // 
            this.labType.AutoSize = true;
            this.labType.Location = new System.Drawing.Point(272, 177);
            this.labType.Name = "labType";
            this.labType.Size = new System.Drawing.Size(35, 13);
            this.labType.TabIndex = 24;
            this.labType.Text = "Type";
            // 
            // labID
            // 
            this.labID.AutoSize = true;
            this.labID.Location = new System.Drawing.Point(336, 21);
            this.labID.Name = "labID";
            this.labID.Size = new System.Drawing.Size(20, 13);
            this.labID.TabIndex = 28;
            this.labID.Text = "ID";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(332, 199);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(121, 20);
            this.txtSearch.TabIndex = 20;
            this.txtSearch.TabStop = false;
            this.txtSearch.Enter += new System.EventHandler(this.BoxColor_Enter);
            this.txtSearch.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxtSearch_KeyUp);
            this.txtSearch.Leave += new System.EventHandler(this.BoxColor_Leave);
            // 
            // rbAll
            // 
            this.rbAll.AutoSize = true;
            this.rbAll.Location = new System.Drawing.Point(381, 229);
            this.rbAll.Name = "rbAll";
            this.rbAll.Size = new System.Drawing.Size(77, 17);
            this.rbAll.TabIndex = 24;
            this.rbAll.TabStop = true;
            this.rbAll.Text = "All plants";
            this.rbAll.UseVisualStyleBackColor = true;
            this.rbAll.CheckedChanged += new System.EventHandler(this.RbAll_CheckedChanged);
            // 
            // labSearch
            // 
            this.labSearch.AutoSize = true;
            this.labSearch.Location = new System.Drawing.Point(272, 204);
            this.labSearch.Name = "labSearch";
            this.labSearch.Size = new System.Drawing.Size(47, 13);
            this.labSearch.TabIndex = 26;
            this.labSearch.Text = "Search";
            // 
            // rbOther
            // 
            this.rbOther.AutoSize = true;
            this.rbOther.Location = new System.Drawing.Point(273, 229);
            this.rbOther.Name = "rbOther";
            this.rbOther.Size = new System.Drawing.Size(95, 17);
            this.rbOther.TabIndex = 23;
            this.rbOther.TabStop = true;
            this.rbOther.Text = "Other Plants";
            this.rbOther.UseVisualStyleBackColor = true;
            this.rbOther.CheckedChanged += new System.EventHandler(this.RbOther_CheckedChanged);
            // 
            // rbSucc
            // 
            this.rbSucc.AutoSize = true;
            this.rbSucc.Location = new System.Drawing.Point(128, 229);
            this.rbSucc.Name = "rbSucc";
            this.rbSucc.Size = new System.Drawing.Size(132, 17);
            this.rbSucc.TabIndex = 22;
            this.rbSucc.TabStop = true;
            this.rbSucc.Text = "Further Succulents";
            this.rbSucc.UseVisualStyleBackColor = true;
            this.rbSucc.CheckedChanged += new System.EventHandler(this.RbSucc_CheckedChanged);
            // 
            // rbCacti
            // 
            this.rbCacti.AutoSize = true;
            this.rbCacti.Location = new System.Drawing.Point(61, 229);
            this.rbCacti.Name = "rbCacti";
            this.rbCacti.Size = new System.Drawing.Size(54, 17);
            this.rbCacti.TabIndex = 21;
            this.rbCacti.TabStop = true;
            this.rbCacti.Text = "Cacti";
            this.rbCacti.UseVisualStyleBackColor = true;
            this.rbCacti.CheckedChanged += new System.EventHandler(this.RbCacti_CheckedChanged);
            // 
            // labShow
            // 
            this.labShow.AutoSize = true;
            this.labShow.Location = new System.Drawing.Point(10, 231);
            this.labShow.Name = "labShow";
            this.labShow.Size = new System.Drawing.Size(38, 13);
            this.labShow.TabIndex = 19;
            this.labShow.Text = "View:";
            // 
            // txtNotes
            // 
            this.txtNotes.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.plantsBindingSource, "Notes", true));
            this.txtNotes.Location = new System.Drawing.Point(275, 43);
            this.txtNotes.Multiline = true;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(178, 124);
            this.txtNotes.TabIndex = 17;
            this.txtNotes.TabStop = false;
            this.txtNotes.Enter += new System.EventHandler(this.BoxColor_Enter);
            this.txtNotes.Leave += new System.EventHandler(this.BoxColor_Leave);
            // 
            // txtSubsp
            // 
            this.txtSubsp.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.plantsBindingSource, "Subspecies", true));
            this.txtSubsp.Location = new System.Drawing.Point(103, 69);
            this.txtSubsp.Name = "txtSubsp";
            this.txtSubsp.Size = new System.Drawing.Size(150, 20);
            this.txtSubsp.TabIndex = 11;
            this.txtSubsp.TabStop = false;
            this.txtSubsp.Enter += new System.EventHandler(this.BoxColor_Enter);
            this.txtSubsp.Leave += new System.EventHandler(this.BoxColor_Leave);
            // 
            // txtReplanted
            // 
            this.txtReplanted.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.plantsBindingSource, "Replanted", true));
            this.txtReplanted.Location = new System.Drawing.Point(103, 199);
            this.txtReplanted.Name = "txtReplanted";
            this.txtReplanted.Size = new System.Drawing.Size(150, 20);
            this.txtReplanted.TabIndex = 16;
            this.txtReplanted.TabStop = false;
            this.txtReplanted.Enter += new System.EventHandler(this.BoxColor_Enter);
            this.txtReplanted.Leave += new System.EventHandler(this.BoxColor_Leave);
            // 
            // txtSource
            // 
            this.txtSource.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.plantsBindingSource, "Source", true));
            this.txtSource.Location = new System.Drawing.Point(103, 173);
            this.txtSource.Margin = new System.Windows.Forms.Padding(10);
            this.txtSource.Name = "txtSource";
            this.txtSource.Size = new System.Drawing.Size(150, 20);
            this.txtSource.TabIndex = 15;
            this.txtSource.TabStop = false;
            this.txtSource.Enter += new System.EventHandler(this.BoxColor_Enter);
            this.txtSource.Leave += new System.EventHandler(this.BoxColor_Leave);
            // 
            // txtSyn
            // 
            this.txtSyn.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.plantsBindingSource, "Synonym", true));
            this.txtSyn.Location = new System.Drawing.Point(103, 147);
            this.txtSyn.Name = "txtSyn";
            this.txtSyn.Size = new System.Drawing.Size(150, 20);
            this.txtSyn.TabIndex = 14;
            this.txtSyn.TabStop = false;
            this.txtSyn.Enter += new System.EventHandler(this.BoxColor_Enter);
            this.txtSyn.Leave += new System.EventHandler(this.BoxColor_Leave);
            // 
            // txtHabit
            // 
            this.txtHabit.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.plantsBindingSource, "Habitat", true));
            this.txtHabit.Location = new System.Drawing.Point(103, 121);
            this.txtHabit.Name = "txtHabit";
            this.txtHabit.Size = new System.Drawing.Size(150, 20);
            this.txtHabit.TabIndex = 13;
            this.txtHabit.TabStop = false;
            this.txtHabit.Enter += new System.EventHandler(this.BoxColor_Enter);
            this.txtHabit.Leave += new System.EventHandler(this.BoxColor_Leave);
            // 
            // txtFieldNo
            // 
            this.txtFieldNo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.plantsBindingSource, "FieldNumber", true));
            this.txtFieldNo.Location = new System.Drawing.Point(103, 95);
            this.txtFieldNo.Name = "txtFieldNo";
            this.txtFieldNo.Size = new System.Drawing.Size(150, 20);
            this.txtFieldNo.TabIndex = 12;
            this.txtFieldNo.TabStop = false;
            this.txtFieldNo.Enter += new System.EventHandler(this.BoxColor_Enter);
            this.txtFieldNo.Leave += new System.EventHandler(this.BoxColor_Leave);
            // 
            // txtSp
            // 
            this.txtSp.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtSp.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList;
            this.txtSp.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.plantsBindingSource, "Species", true));
            this.txtSp.Location = new System.Drawing.Point(103, 43);
            this.txtSp.Name = "txtSp";
            this.txtSp.Size = new System.Drawing.Size(150, 20);
            this.txtSp.TabIndex = 10;
            this.txtSp.TabStop = false;
            this.txtSp.Enter += new System.EventHandler(this.BoxColor_Enter);
            this.txtSp.Leave += new System.EventHandler(this.BoxColor_Leave);
            // 
            // labNotes
            // 
            this.labNotes.AutoSize = true;
            this.labNotes.Location = new System.Drawing.Point(274, 21);
            this.labNotes.Name = "labNotes";
            this.labNotes.Size = new System.Drawing.Size(40, 13);
            this.labNotes.TabIndex = 8;
            this.labNotes.Text = "Notes";
            this.toolTipNotes.SetToolTip(this.labNotes, "You can save other information here: form notes like cristata, variegata etc. You" +
        " can find every snippet or character of this field using the search box.");
            // 
            // labSource
            // 
            this.labSource.AutoSize = true;
            this.labSource.Location = new System.Drawing.Point(7, 177);
            this.labSource.Name = "labSource";
            this.labSource.Size = new System.Drawing.Size(47, 13);
            this.labSource.TabIndex = 7;
            this.labSource.Text = "Source";
            // 
            // labReplanted
            // 
            this.labReplanted.AutoSize = true;
            this.labReplanted.Location = new System.Drawing.Point(7, 203);
            this.labReplanted.Name = "labReplanted";
            this.labReplanted.Size = new System.Drawing.Size(65, 13);
            this.labReplanted.TabIndex = 6;
            this.labReplanted.Text = "Replanted";
            // 
            // labSyn
            // 
            this.labSyn.AutoSize = true;
            this.labSyn.Location = new System.Drawing.Point(7, 151);
            this.labSyn.Name = "labSyn";
            this.labSyn.Size = new System.Drawing.Size(57, 13);
            this.labSyn.TabIndex = 5;
            this.labSyn.Text = "Synonym";
            // 
            // labHabit
            // 
            this.labHabit.AutoSize = true;
            this.labHabit.Location = new System.Drawing.Point(7, 125);
            this.labHabit.Name = "labHabit";
            this.labHabit.Size = new System.Drawing.Size(73, 13);
            this.labHabit.TabIndex = 4;
            this.labHabit.Text = "Habitat info";
            // 
            // labFieldNo4
            // 
            this.labFieldNo4.AutoSize = true;
            this.labFieldNo4.Location = new System.Drawing.Point(7, 99);
            this.labFieldNo4.Name = "labFieldNo4";
            this.labFieldNo4.Size = new System.Drawing.Size(81, 13);
            this.labFieldNo4.TabIndex = 3;
            this.labFieldNo4.Text = "Field Number";
            // 
            // labSubsp
            // 
            this.labSubsp.AutoSize = true;
            this.labSubsp.Location = new System.Drawing.Point(7, 73);
            this.labSubsp.Name = "labSubsp";
            this.labSubsp.Size = new System.Drawing.Size(72, 13);
            this.labSubsp.TabIndex = 2;
            this.labSubsp.Text = "Subspecies";
            // 
            // labSp
            // 
            this.labSp.AutoSize = true;
            this.labSp.Location = new System.Drawing.Point(7, 47);
            this.labSp.Name = "labSp";
            this.labSp.Size = new System.Drawing.Size(52, 13);
            this.labSp.TabIndex = 1;
            this.labSp.Text = "Species";
            // 
            // labGen
            // 
            this.labGen.AutoSize = true;
            this.labGen.Location = new System.Drawing.Point(7, 21);
            this.labGen.Name = "labGen";
            this.labGen.Size = new System.Drawing.Size(43, 13);
            this.labGen.TabIndex = 0;
            this.labGen.Text = "Genus";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewPlantsToolStripMenuItem,
            this.createNewPlantToolStripMenuItem,
            this.saveActualPlantToolStripMenuItem,
            this.updateActualPlantToolStripMenuItem,
            this.deleteActualPlantToolStripMenuItem,
            this.importExcelFileToolStripMenuItem,
            this.printToolStripMenuItem,
            this.picturesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.Size = new System.Drawing.Size(1167, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // viewPlantsToolStripMenuItem
            // 
            this.viewPlantsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cactiToolStripMenuItem,
            this.furtherSucculentsToolStripMenuItem,
            this.otherPlantsToolStripMenuItem,
            this.viewAllPlantsToolStripMenuItem});
            this.viewPlantsToolStripMenuItem.Name = "viewPlantsToolStripMenuItem";
            this.viewPlantsToolStripMenuItem.Size = new System.Drawing.Size(83, 20);
            this.viewPlantsToolStripMenuItem.Text = "View Plants";
            // 
            // cactiToolStripMenuItem
            // 
            this.cactiToolStripMenuItem.Name = "cactiToolStripMenuItem";
            this.cactiToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.cactiToolStripMenuItem.Text = "View cacti";
            this.cactiToolStripMenuItem.Click += new System.EventHandler(this.CactiToolStripMenuItem_Click);
            // 
            // furtherSucculentsToolStripMenuItem
            // 
            this.furtherSucculentsToolStripMenuItem.Name = "furtherSucculentsToolStripMenuItem";
            this.furtherSucculentsToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.furtherSucculentsToolStripMenuItem.Text = "View further succulents";
            this.furtherSucculentsToolStripMenuItem.Click += new System.EventHandler(this.FurtherSucculentsToolStripMenuItem_Click);
            // 
            // otherPlantsToolStripMenuItem
            // 
            this.otherPlantsToolStripMenuItem.Name = "otherPlantsToolStripMenuItem";
            this.otherPlantsToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.otherPlantsToolStripMenuItem.Text = "View other plants";
            this.otherPlantsToolStripMenuItem.Click += new System.EventHandler(this.OtherPlantsToolStripMenuItem_Click);
            // 
            // viewAllPlantsToolStripMenuItem
            // 
            this.viewAllPlantsToolStripMenuItem.Name = "viewAllPlantsToolStripMenuItem";
            this.viewAllPlantsToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.viewAllPlantsToolStripMenuItem.Text = "View all plants";
            this.viewAllPlantsToolStripMenuItem.Click += new System.EventHandler(this.ViewAllPlantsToolStripMenuItem_Click);
            // 
            // createNewPlantToolStripMenuItem
            // 
            this.createNewPlantToolStripMenuItem.Name = "createNewPlantToolStripMenuItem";
            this.createNewPlantToolStripMenuItem.Size = new System.Drawing.Size(114, 20);
            this.createNewPlantToolStripMenuItem.Text = "Create new plant";
            this.createNewPlantToolStripMenuItem.Click += new System.EventHandler(this.CreateNewPlantToolStripMenuItem_Click);
            // 
            // saveActualPlantToolStripMenuItem
            // 
            this.saveActualPlantToolStripMenuItem.Name = "saveActualPlantToolStripMenuItem";
            this.saveActualPlantToolStripMenuItem.Size = new System.Drawing.Size(104, 20);
            this.saveActualPlantToolStripMenuItem.Text = "Save new plant";
            this.saveActualPlantToolStripMenuItem.Click += new System.EventHandler(this.SaveActualPlantToolStripMenuItem_Click);
            // 
            // updateActualPlantToolStripMenuItem
            // 
            this.updateActualPlantToolStripMenuItem.Name = "updateActualPlantToolStripMenuItem";
            this.updateActualPlantToolStripMenuItem.Size = new System.Drawing.Size(127, 20);
            this.updateActualPlantToolStripMenuItem.Text = "Update actual plant";
            this.updateActualPlantToolStripMenuItem.Click += new System.EventHandler(this.UpdateActualPlantToolStripMenuItem_Click);
            // 
            // deleteActualPlantToolStripMenuItem
            // 
            this.deleteActualPlantToolStripMenuItem.Name = "deleteActualPlantToolStripMenuItem";
            this.deleteActualPlantToolStripMenuItem.Size = new System.Drawing.Size(124, 20);
            this.deleteActualPlantToolStripMenuItem.Text = "Delete actual plant";
            this.deleteActualPlantToolStripMenuItem.Click += new System.EventHandler(this.DeleteActualPlantToolStripMenuItem_Click);
            // 
            // importExcelFileToolStripMenuItem
            // 
            this.importExcelFileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importFromExcelToolStripMenuItem,
            this.exportToExcelToolStripMenuItem1});
            this.importExcelFileToolStripMenuItem.Name = "importExcelFileToolStripMenuItem";
            this.importExcelFileToolStripMenuItem.Size = new System.Drawing.Size(100, 20);
            this.importExcelFileToolStripMenuItem.Text = "Import/Export";
            // 
            // importFromExcelToolStripMenuItem
            // 
            this.importFromExcelToolStripMenuItem.Name = "importFromExcelToolStripMenuItem";
            this.importFromExcelToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.importFromExcelToolStripMenuItem.Text = "Import from Excel";
            this.importFromExcelToolStripMenuItem.Click += new System.EventHandler(this.ImportExcelFileToolStripMenuItem_Click);
            // 
            // exportToExcelToolStripMenuItem1
            // 
            this.exportToExcelToolStripMenuItem1.Name = "exportToExcelToolStripMenuItem1";
            this.exportToExcelToolStripMenuItem1.Size = new System.Drawing.Size(176, 22);
            this.exportToExcelToolStripMenuItem1.Text = "Export to Excel";
            this.exportToExcelToolStripMenuItem1.Click += new System.EventHandler(this.ExportToExcelToolStripMenuItem_Click);
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.printToolStripMenuItem.Text = "Print";
            this.printToolStripMenuItem.Click += new System.EventHandler(this.PrintToolStripMenuItem_Click);
            // 
            // picturesToolStripMenuItem
            // 
            this.picturesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addPictureToPlantToolStripMenuItem,
            this.deleteImageFromPlantToolStripMenuItem,
            this.deleteAllImagesFromPlantToolStripMenuItem,
            this.deleteAllImagesFromDatabaseToolStripMenuItem});
            this.picturesToolStripMenuItem.Name = "picturesToolStripMenuItem";
            this.picturesToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.picturesToolStripMenuItem.Text = "Pictures";
            // 
            // addPictureToPlantToolStripMenuItem
            // 
            this.addPictureToPlantToolStripMenuItem.Name = "addPictureToPlantToolStripMenuItem";
            this.addPictureToPlantToolStripMenuItem.Size = new System.Drawing.Size(252, 22);
            this.addPictureToPlantToolStripMenuItem.Text = "Add picture to plant";
            this.addPictureToPlantToolStripMenuItem.Click += new System.EventHandler(this.AddPictureToPlantToolStripMenuItem_Click);
            // 
            // deleteImageFromPlantToolStripMenuItem
            // 
            this.deleteImageFromPlantToolStripMenuItem.Name = "deleteImageFromPlantToolStripMenuItem";
            this.deleteImageFromPlantToolStripMenuItem.Size = new System.Drawing.Size(252, 22);
            this.deleteImageFromPlantToolStripMenuItem.Text = "Delete image from plant";
            // 
            // deleteAllImagesFromPlantToolStripMenuItem
            // 
            this.deleteAllImagesFromPlantToolStripMenuItem.Name = "deleteAllImagesFromPlantToolStripMenuItem";
            this.deleteAllImagesFromPlantToolStripMenuItem.Size = new System.Drawing.Size(252, 22);
            this.deleteAllImagesFromPlantToolStripMenuItem.Text = "Delete all images from plant";
            // 
            // deleteAllImagesFromDatabaseToolStripMenuItem
            // 
            this.deleteAllImagesFromDatabaseToolStripMenuItem.Name = "deleteAllImagesFromDatabaseToolStripMenuItem";
            this.deleteAllImagesFromDatabaseToolStripMenuItem.Size = new System.Drawing.Size(252, 22);
            this.deleteAllImagesFromDatabaseToolStripMenuItem.Text = "Delete all images from database";
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // PlantsBox
            // 
            this.PlantsBox.AutoSize = true;
            this.PlantsBox.BackColor = System.Drawing.Color.Transparent;
            this.PlantsBox.Controls.Add(this.plantsLabelStat);
            this.PlantsBox.Controls.Add(this.PlantsTableView);
            this.PlantsBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PlantsBox.Location = new System.Drawing.Point(12, 297);
            this.PlantsBox.Name = "PlantsBox";
            this.PlantsBox.Size = new System.Drawing.Size(1131, 383);
            this.PlantsBox.TabIndex = 6;
            this.PlantsBox.TabStop = false;
            this.PlantsBox.Text = "PLANTS";
            // 
            // plantsLabelStat
            // 
            this.plantsLabelStat.AutoSize = true;
            this.plantsLabelStat.Location = new System.Drawing.Point(7, 16);
            this.plantsLabelStat.Name = "plantsLabelStat";
            this.plantsLabelStat.Size = new System.Drawing.Size(12, 13);
            this.plantsLabelStat.TabIndex = 9;
            this.plantsLabelStat.Text = "*";
            // 
            // PlantsTableView
            // 
            this.PlantsTableView.AllowUserToAddRows = false;
            this.PlantsTableView.AllowUserToDeleteRows = false;
            this.PlantsTableView.AutoGenerateColumns = false;
            this.PlantsTableView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.PlantsTableView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.PlantsTableView.BackgroundColor = System.Drawing.Color.Khaki;
            this.PlantsTableView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PlantsTableView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.Peru;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.Padding = new System.Windows.Forms.Padding(3);
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.SaddleBrown;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.PlantsTableView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.PlantsTableView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PlantsTableView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.genusDataGridViewTextBoxColumn,
            this.speciesDataGridViewTextBoxColumn,
            this.subspeciesDataGridViewTextBoxColumn,
            this.fieldNumberDataGridViewTextBoxColumn,
            this.habitatDataGridViewTextBoxColumn,
            this.synonymDataGridViewTextBoxColumn,
            this.sourceDataGridViewTextBoxColumn,
            this.replantedDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn1});
            this.PlantsTableView.DataSource = this.plantsBindingSource;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.Khaki;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.SaddleBrown;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.PlantsTableView.DefaultCellStyle = dataGridViewCellStyle8;
            this.PlantsTableView.EnableHeadersVisualStyles = false;
            this.PlantsTableView.GridColor = System.Drawing.Color.SaddleBrown;
            this.PlantsTableView.Location = new System.Drawing.Point(0, 32);
            this.PlantsTableView.Name = "PlantsTableView";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.Peru;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.SaddleBrown;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.PlantsTableView.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.PlantsTableView.RowHeadersVisible = false;
            this.PlantsTableView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.PlantsTableView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.PlantsTableView.Size = new System.Drawing.Size(1125, 320);
            this.PlantsTableView.TabIndex = 8;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.FillWeight = 136.2691F;
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.MaxInputLength = 9999;
            this.iDDataGridViewTextBoxColumn.MinimumWidth = 42;
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // genusDataGridViewTextBoxColumn
            // 
            this.genusDataGridViewTextBoxColumn.DataPropertyName = "Genus";
            this.genusDataGridViewTextBoxColumn.FillWeight = 507.6143F;
            this.genusDataGridViewTextBoxColumn.HeaderText = "Genus";
            this.genusDataGridViewTextBoxColumn.MinimumWidth = 130;
            this.genusDataGridViewTextBoxColumn.Name = "genusDataGridViewTextBoxColumn";
            // 
            // speciesDataGridViewTextBoxColumn
            // 
            this.speciesDataGridViewTextBoxColumn.DataPropertyName = "Species";
            this.speciesDataGridViewTextBoxColumn.FillWeight = 44.51458F;
            this.speciesDataGridViewTextBoxColumn.HeaderText = "Species";
            this.speciesDataGridViewTextBoxColumn.MinimumWidth = 130;
            this.speciesDataGridViewTextBoxColumn.Name = "speciesDataGridViewTextBoxColumn";
            // 
            // subspeciesDataGridViewTextBoxColumn
            // 
            this.subspeciesDataGridViewTextBoxColumn.DataPropertyName = "Subspecies";
            this.subspeciesDataGridViewTextBoxColumn.FillWeight = 44.51458F;
            this.subspeciesDataGridViewTextBoxColumn.HeaderText = "Subspecies";
            this.subspeciesDataGridViewTextBoxColumn.MinimumWidth = 130;
            this.subspeciesDataGridViewTextBoxColumn.Name = "subspeciesDataGridViewTextBoxColumn";
            // 
            // fieldNumberDataGridViewTextBoxColumn
            // 
            this.fieldNumberDataGridViewTextBoxColumn.DataPropertyName = "FieldNumber";
            this.fieldNumberDataGridViewTextBoxColumn.FillWeight = 44.51458F;
            this.fieldNumberDataGridViewTextBoxColumn.HeaderText = "FieldNumber";
            this.fieldNumberDataGridViewTextBoxColumn.MinimumWidth = 100;
            this.fieldNumberDataGridViewTextBoxColumn.Name = "fieldNumberDataGridViewTextBoxColumn";
            // 
            // habitatDataGridViewTextBoxColumn
            // 
            this.habitatDataGridViewTextBoxColumn.DataPropertyName = "Habitat";
            this.habitatDataGridViewTextBoxColumn.FillWeight = 44.51458F;
            this.habitatDataGridViewTextBoxColumn.HeaderText = "Habitat";
            this.habitatDataGridViewTextBoxColumn.MinimumWidth = 100;
            this.habitatDataGridViewTextBoxColumn.Name = "habitatDataGridViewTextBoxColumn";
            // 
            // synonymDataGridViewTextBoxColumn
            // 
            this.synonymDataGridViewTextBoxColumn.DataPropertyName = "Synonym";
            this.synonymDataGridViewTextBoxColumn.FillWeight = 44.51458F;
            this.synonymDataGridViewTextBoxColumn.HeaderText = "Synonym";
            this.synonymDataGridViewTextBoxColumn.MinimumWidth = 100;
            this.synonymDataGridViewTextBoxColumn.Name = "synonymDataGridViewTextBoxColumn";
            // 
            // sourceDataGridViewTextBoxColumn
            // 
            this.sourceDataGridViewTextBoxColumn.DataPropertyName = "Source";
            this.sourceDataGridViewTextBoxColumn.FillWeight = 44.51458F;
            this.sourceDataGridViewTextBoxColumn.HeaderText = "Source";
            this.sourceDataGridViewTextBoxColumn.MinimumWidth = 70;
            this.sourceDataGridViewTextBoxColumn.Name = "sourceDataGridViewTextBoxColumn";
            // 
            // replantedDataGridViewTextBoxColumn
            // 
            this.replantedDataGridViewTextBoxColumn.DataPropertyName = "Replanted";
            this.replantedDataGridViewTextBoxColumn.FillWeight = 44.51458F;
            this.replantedDataGridViewTextBoxColumn.HeaderText = "Replanted";
            this.replantedDataGridViewTextBoxColumn.MinimumWidth = 70;
            this.replantedDataGridViewTextBoxColumn.Name = "replantedDataGridViewTextBoxColumn";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Notes";
            this.dataGridViewTextBoxColumn1.FillWeight = 44.51458F;
            this.dataGridViewTextBoxColumn1.HeaderText = "Notes";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 150;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // fillByTypeToolStripButton
            // 
            this.fillByTypeToolStripButton.Name = "fillByTypeToolStripButton";
            this.fillByTypeToolStripButton.Size = new System.Drawing.Size(23, 23);
            // 
            // plantsTableAdapter
            // 
            this.plantsTableAdapter.ClearBeforeFill = true;
            // 
            // genusTableAdapter
            // 
            this.genusTableAdapter.ClearBeforeFill = true;
            // 
            // toolTipComboType
            // 
            this.toolTipComboType.IsBalloon = true;
            // 
            // toolTipNotes
            // 
            this.toolTipNotes.IsBalloon = true;
            // 
            // toolTipReplanted
            // 
            this.toolTipReplanted.IsBalloon = true;
            // 
            // printDocumentPlants
            // 
            this.printDocumentPlants.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.PrintDocumentPlants_PrintPage);
            // 
            // printPreviewDialogPlants
            // 
            this.printPreviewDialogPlants.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialogPlants.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialogPlants.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.printPreviewDialogPlants.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialogPlants.Enabled = true;
            this.printPreviewDialogPlants.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialogPlants.Icon")));
            this.printPreviewDialogPlants.Name = "printPreviewDialogPlants";
            this.printPreviewDialogPlants.Visible = false;
            // 
            // printDialogPlants
            // 
            this.printDialogPlants.Document = this.printDocumentPlants;
            this.printDialogPlants.UseEXDialog = true;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BackgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.BackgroundWorker1_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BackgroundWorker1_RunWorkerCompleted);
            // 
            // bindingNavigatorMoveFirstItem1
            // 
            this.bindingNavigatorMoveFirstItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem1.Image")));
            this.bindingNavigatorMoveFirstItem1.Name = "bindingNavigatorMoveFirstItem1";
            this.bindingNavigatorMoveFirstItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem1.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem1.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem1
            // 
            this.bindingNavigatorMovePreviousItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem1.Image")));
            this.bindingNavigatorMovePreviousItem1.Name = "bindingNavigatorMovePreviousItem1";
            this.bindingNavigatorMovePreviousItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem1.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem1.Text = "Move previous";
            // 
            // bindingNavigatorMoveNextItem1
            // 
            this.bindingNavigatorMoveNextItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem1.Image")));
            this.bindingNavigatorMoveNextItem1.Name = "bindingNavigatorMoveNextItem1";
            this.bindingNavigatorMoveNextItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem1.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem1.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem1
            // 
            this.bindingNavigatorMoveLastItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem1.Image")));
            this.bindingNavigatorMoveLastItem1.Name = "bindingNavigatorMoveLastItem1";
            this.bindingNavigatorMoveLastItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem1.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem1.Text = "Move last";
            // 
            // bindingNavigator2
            // 
            this.bindingNavigator2.AddNewItem = null;
            this.bindingNavigator2.BackColor = System.Drawing.Color.Transparent;
            this.bindingNavigator2.BindingSource = this.plantsBindingSource;
            this.bindingNavigator2.CountItem = null;
            this.bindingNavigator2.DeleteItem = null;
            this.bindingNavigator2.Dock = System.Windows.Forms.DockStyle.None;
            this.bindingNavigator2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.bindingNavigator2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem1,
            this.bindingNavigatorMovePreviousItem1,
            this.bindingNavigatorMoveNextItem1,
            this.bindingNavigatorMoveLastItem1,
            this.toolStripButtonRefresh});
            this.bindingNavigator2.Location = new System.Drawing.Point(770, 0);
            this.bindingNavigator2.MoveFirstItem = this.bindingNavigatorMoveFirstItem1;
            this.bindingNavigator2.MoveLastItem = this.bindingNavigatorMoveLastItem1;
            this.bindingNavigator2.MoveNextItem = this.bindingNavigatorMoveNextItem1;
            this.bindingNavigator2.MovePreviousItem = this.bindingNavigatorMovePreviousItem1;
            this.bindingNavigator2.Name = "bindingNavigator2";
            this.bindingNavigator2.PositionItem = null;
            this.bindingNavigator2.Size = new System.Drawing.Size(118, 25);
            this.bindingNavigator2.TabIndex = 31;
            this.bindingNavigator2.Text = "bindingNavigator2";
            // 
            // toolStripButtonRefresh
            // 
            this.toolStripButtonRefresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonRefresh.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonRefresh.Image")));
            this.toolStripButtonRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonRefresh.Name = "toolStripButtonRefresh";
            this.toolStripButtonRefresh.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonRefresh.Text = "Refresh";
            this.toolStripButtonRefresh.Click += new System.EventHandler(this.ToolStripButtonRefresh_Click);
            // 
            // PictureGroupBox
            // 
            this.PictureGroupBox.BackColor = System.Drawing.Color.Transparent;
            this.PictureGroupBox.Controls.Add(this.dataGridPic);
            this.PictureGroupBox.Controls.Add(this.pictureBox1);
            this.PictureGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PictureGroupBox.Location = new System.Drawing.Point(489, 33);
            this.PictureGroupBox.Name = "PictureGroupBox";
            this.PictureGroupBox.Size = new System.Drawing.Size(654, 258);
            this.PictureGroupBox.TabIndex = 32;
            this.PictureGroupBox.TabStop = false;
            this.PictureGroupBox.Text = "PICTURES OF THE PLANT";
            // 
            // dataGridPic
            // 
            this.dataGridPic.AllowUserToDeleteRows = false;
            this.dataGridPic.AllowUserToResizeColumns = false;
            this.dataGridPic.AllowUserToResizeRows = false;
            this.dataGridPic.BackgroundColor = System.Drawing.Color.Peru;
            this.dataGridPic.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridPic.ColumnHeadersVisible = false;
            this.dataGridPic.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dataGridPic.Location = new System.Drawing.Point(224, 17);
            this.dataGridPic.Name = "dataGridPic";
            this.dataGridPic.RowHeadersVisible = false;
            this.dataGridPic.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridPic.Size = new System.Drawing.Size(424, 227);
            this.dataGridPic.TabIndex = 3;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Column2";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Column3";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Column4";
            this.Column4.Name = "Column4";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(10, 17);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Padding = new System.Windows.Forms.Padding(10);
            this.pictureBox1.Size = new System.Drawing.Size(204, 229);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // PlantsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.DarkKhaki;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1184, 641);
            this.Controls.Add(this.PictureGroupBox);
            this.Controls.Add(this.bindingNavigator2);
            this.Controls.Add(this.PlantsBox);
            this.Controls.Add(this.PlantDetailsBox);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.MaximumSize = new System.Drawing.Size(1900, 980);
            this.Name = "PlantsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Welcome to the Ornamental Plant Register!";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PlantsForm_FormClosing);
            this.Load += new System.EventHandler(this.PlantsForm_Load);
            this.Resize += new System.EventHandler(this.PlantsForm_Resize);
            this.PlantDetailsBox.ResumeLayout(false);
            this.PlantDetailsBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.plantsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetForPlantReg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.genusBindingSource)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.PlantsBox.ResumeLayout(false);
            this.PlantsBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PlantsTableView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator2)).EndInit();
            this.bindingNavigator2.ResumeLayout(false);
            this.bindingNavigator2.PerformLayout();
            this.PictureGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox PlantDetailsBox;
        private System.Windows.Forms.Label labNotes;
        private System.Windows.Forms.Label labSource;
        private System.Windows.Forms.Label labReplanted;
        private System.Windows.Forms.Label labSyn;
        private System.Windows.Forms.Label labHabit;
        private System.Windows.Forms.Label labFieldNo4;
        private System.Windows.Forms.Label labSubsp;
        private System.Windows.Forms.Label labSp;
        private System.Windows.Forms.Label labGen;
        private System.Windows.Forms.TextBox txtSubsp;
        private System.Windows.Forms.TextBox txtReplanted;
        private System.Windows.Forms.TextBox txtSource;
        private System.Windows.Forms.TextBox txtSyn;
        private System.Windows.Forms.TextBox txtHabit;
        private System.Windows.Forms.TextBox txtFieldNo;
        private System.Windows.Forms.TextBox txtSp;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem createNewPlantToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveActualPlantToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteActualPlantToolStripMenuItem;
        private System.Windows.Forms.RadioButton rbAll;
        private System.Windows.Forms.RadioButton rbOther;
        private System.Windows.Forms.RadioButton rbSucc;
        private System.Windows.Forms.RadioButton rbCacti;
        private System.Windows.Forms.Label labShow;
        private DataSetForPlantReg dataSetForPlantReg;
        private System.Windows.Forms.BindingSource plantsBindingSource;
        private DataSetForPlantRegTableAdapters.PlantsTableAdapter plantsTableAdapter;
        private System.Windows.Forms.ToolStripMenuItem viewPlantsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cactiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem furtherSucculentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem otherPlantsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewAllPlantsToolStripMenuItem;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label labSearch;
        private System.Windows.Forms.Label labType;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label labID;
        private System.Windows.Forms.BindingSource genusBindingSource;
        private DataSetForPlantRegTableAdapters.GenusTableAdapter genusTableAdapter;
        private System.Windows.Forms.TextBox txtGen;
        private System.Windows.Forms.ToolStripMenuItem updateActualPlantToolStripMenuItem;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.GroupBox PlantsBox;
        private System.Windows.Forms.DataGridView PlantsTableView;
        private System.Windows.Forms.ComboBox comboType;
        private System.Windows.Forms.ToolStripButton fillByTypeToolStripButton;
        private System.Windows.Forms.ToolTip toolTipComboType;
        private System.Windows.Forms.ToolTip toolTipNotes;
        private System.Windows.Forms.ToolTip toolTipReplanted;
        private System.Windows.Forms.ToolStripMenuItem importExcelFileToolStripMenuItem;
        private System.Windows.Forms.Label plantsLabelStat;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Drawing.Printing.PrintDocument printDocumentPlants;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialogPlants;
        private System.Windows.Forms.PrintDialog printDialogPlants;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn speciesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn subspeciesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fieldNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn habitatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn synonymDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sourceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn replantedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem1;
        private System.Windows.Forms.BindingNavigator bindingNavigator2;
        private System.Windows.Forms.ToolStripMenuItem importFromExcelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportToExcelToolStripMenuItem1;
        private System.Windows.Forms.ToolStripButton toolStripButtonRefresh;
        private System.Windows.Forms.GroupBox PictureGroupBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem picturesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addPictureToPlantToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteImageFromPlantToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteAllImagesFromPlantToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteAllImagesFromDatabaseToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridPic;
        private System.Windows.Forms.DataGridViewImageColumn Column1;
        private System.Windows.Forms.DataGridViewImageColumn Column2;
        private System.Windows.Forms.DataGridViewImageColumn Column3;
        private System.Windows.Forms.DataGridViewImageColumn Column4;
        private System.Windows.Forms.DateTimePicker dateTimePickerReplanted;
    }
}

