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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlantsForm));
            this.PlantDetailsBox = new System.Windows.Forms.GroupBox();
            this.dateTimePickerReplanted = new System.Windows.Forms.DateTimePicker();
            this.plantsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetForPlantReg = new Ornaments_Register.DataSetForPlantReg();
            this.comboType = new System.Windows.Forms.ComboBox();
            this.txtGen = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.labID = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.labSearch = new System.Windows.Forms.Label();
            this.labType = new System.Windows.Forms.Label();
            this.rbAll = new System.Windows.Forms.RadioButton();
            this.rbOther = new System.Windows.Forms.RadioButton();
            this.rbSucc = new System.Windows.Forms.RadioButton();
            this.rbCacti = new System.Windows.Forms.RadioButton();
            this.labShow = new System.Windows.Forms.Label();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
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
            this.uploadPictureForPlantToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importExcelFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
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
            this.PlantDetailsBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.plantsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetForPlantReg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.genusBindingSource)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            this.PlantsBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PlantsTableView)).BeginInit();
            this.SuspendLayout();
            // 
            // PlantDetailsBox
            // 
            this.PlantDetailsBox.BackColor = System.Drawing.Color.Transparent;
            this.PlantDetailsBox.Controls.Add(this.dateTimePickerReplanted);
            this.PlantDetailsBox.Controls.Add(this.comboType);
            this.PlantDetailsBox.Controls.Add(this.txtGen);
            this.PlantDetailsBox.Controls.Add(this.txtID);
            this.PlantDetailsBox.Controls.Add(this.labID);
            this.PlantDetailsBox.Controls.Add(this.txtSearch);
            this.PlantDetailsBox.Controls.Add(this.labSearch);
            this.PlantDetailsBox.Controls.Add(this.labType);
            this.PlantDetailsBox.Controls.Add(this.rbAll);
            this.PlantDetailsBox.Controls.Add(this.rbOther);
            this.PlantDetailsBox.Controls.Add(this.rbSucc);
            this.PlantDetailsBox.Controls.Add(this.rbCacti);
            this.PlantDetailsBox.Controls.Add(this.labShow);
            this.PlantDetailsBox.Controls.Add(this.txtNotes);
            this.PlantDetailsBox.Controls.Add(this.pictureBox1);
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
            this.PlantDetailsBox.Location = new System.Drawing.Point(14, 33);
            this.PlantDetailsBox.Name = "PlantDetailsBox";
            this.PlantDetailsBox.Size = new System.Drawing.Size(1139, 236);
            this.PlantDetailsBox.TabIndex = 0;
            this.PlantDetailsBox.TabStop = false;
            this.PlantDetailsBox.Text = "Plant Details";
            // 
            // dateTimePickerReplanted
            // 
            this.dateTimePickerReplanted.CustomFormat = "2018. nov.";
            this.dateTimePickerReplanted.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.plantsBindingSource, "Replanted", true));
            this.dateTimePickerReplanted.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerReplanted.Location = new System.Drawing.Point(874, 70);
            this.dateTimePickerReplanted.Name = "dateTimePickerReplanted";
            this.dateTimePickerReplanted.Size = new System.Drawing.Size(200, 20);
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
            this.comboType.Location = new System.Drawing.Point(635, 168);
            this.comboType.Name = "comboType";
            this.comboType.Size = new System.Drawing.Size(121, 21);
            this.comboType.TabIndex = 29;
            this.toolTipComboType.SetToolTip(this.comboType, "You can choose the type of plant");
            this.comboType.ValueMember = "Type";
            // 
            // txtGen
            // 
            this.txtGen.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.plantsBindingSource, "Genus", true));
            this.txtGen.Location = new System.Drawing.Point(103, 17);
            this.txtGen.Name = "txtGen";
            this.txtGen.Size = new System.Drawing.Size(267, 20);
            this.txtGen.TabIndex = 9;
            // 
            // txtID
            // 
            this.txtID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.plantsBindingSource, "ID", true));
            this.txtID.Location = new System.Drawing.Point(635, 137);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(121, 20);
            this.txtID.TabIndex = 18;
            // 
            // labID
            // 
            this.labID.AutoSize = true;
            this.labID.Location = new System.Drawing.Point(578, 141);
            this.labID.Name = "labID";
            this.labID.Size = new System.Drawing.Size(20, 13);
            this.labID.TabIndex = 28;
            this.labID.Text = "ID";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(635, 196);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(121, 20);
            this.txtSearch.TabIndex = 20;
            this.txtSearch.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxtSearch_KeyUp);
            // 
            // labSearch
            // 
            this.labSearch.AutoSize = true;
            this.labSearch.Location = new System.Drawing.Point(575, 200);
            this.labSearch.Name = "labSearch";
            this.labSearch.Size = new System.Drawing.Size(47, 13);
            this.labSearch.TabIndex = 26;
            this.labSearch.Text = "Search";
            // 
            // labType
            // 
            this.labType.AutoSize = true;
            this.labType.Location = new System.Drawing.Point(575, 171);
            this.labType.Name = "labType";
            this.labType.Size = new System.Drawing.Size(35, 13);
            this.labType.TabIndex = 24;
            this.labType.Text = "Type";
            // 
            // rbAll
            // 
            this.rbAll.AutoSize = true;
            this.rbAll.Location = new System.Drawing.Point(432, 198);
            this.rbAll.Name = "rbAll";
            this.rbAll.Size = new System.Drawing.Size(115, 17);
            this.rbAll.TabIndex = 24;
            this.rbAll.TabStop = true;
            this.rbAll.Text = "All of the Plants";
            this.rbAll.UseVisualStyleBackColor = true;
            this.rbAll.CheckedChanged += new System.EventHandler(this.RbAll_CheckedChanged);
            // 
            // rbOther
            // 
            this.rbOther.AutoSize = true;
            this.rbOther.Location = new System.Drawing.Point(321, 198);
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
            this.rbSucc.Location = new System.Drawing.Point(173, 198);
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
            this.rbCacti.Location = new System.Drawing.Point(103, 198);
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
            this.labShow.Location = new System.Drawing.Point(10, 200);
            this.labShow.Name = "labShow";
            this.labShow.Size = new System.Drawing.Size(77, 13);
            this.labShow.TabIndex = 19;
            this.labShow.Text = "Filter plants:";
            // 
            // txtNotes
            // 
            this.txtNotes.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.plantsBindingSource, "Notes", true));
            this.txtNotes.Location = new System.Drawing.Point(102, 136);
            this.txtNotes.Multiline = true;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(445, 50);
            this.txtNotes.TabIndex = 17;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(801, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(318, 197);
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // txtSubsp
            // 
            this.txtSubsp.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.plantsBindingSource, "Subspecies", true));
            this.txtSubsp.Location = new System.Drawing.Point(102, 47);
            this.txtSubsp.Name = "txtSubsp";
            this.txtSubsp.Size = new System.Drawing.Size(268, 20);
            this.txtSubsp.TabIndex = 11;
            // 
            // txtReplanted
            // 
            this.txtReplanted.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.plantsBindingSource, "Replanted", true));
            this.txtReplanted.Location = new System.Drawing.Point(488, 104);
            this.txtReplanted.Name = "txtReplanted";
            this.txtReplanted.Size = new System.Drawing.Size(268, 20);
            this.txtReplanted.TabIndex = 16;
            // 
            // txtSource
            // 
            this.txtSource.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.plantsBindingSource, "Source", true));
            this.txtSource.Location = new System.Drawing.Point(102, 105);
            this.txtSource.Margin = new System.Windows.Forms.Padding(10);
            this.txtSource.Name = "txtSource";
            this.txtSource.Size = new System.Drawing.Size(268, 20);
            this.txtSource.TabIndex = 15;
            // 
            // txtSyn
            // 
            this.txtSyn.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.plantsBindingSource, "Synonym", true));
            this.txtSyn.Location = new System.Drawing.Point(488, 75);
            this.txtSyn.Name = "txtSyn";
            this.txtSyn.Size = new System.Drawing.Size(268, 20);
            this.txtSyn.TabIndex = 14;
            // 
            // txtHabit
            // 
            this.txtHabit.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.plantsBindingSource, "Habitat", true));
            this.txtHabit.Location = new System.Drawing.Point(102, 76);
            this.txtHabit.Name = "txtHabit";
            this.txtHabit.Size = new System.Drawing.Size(268, 20);
            this.txtHabit.TabIndex = 13;
            // 
            // txtFieldNo
            // 
            this.txtFieldNo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.plantsBindingSource, "FieldNumber", true));
            this.txtFieldNo.Location = new System.Drawing.Point(488, 46);
            this.txtFieldNo.Name = "txtFieldNo";
            this.txtFieldNo.Size = new System.Drawing.Size(268, 20);
            this.txtFieldNo.TabIndex = 12;
            // 
            // txtSp
            // 
            this.txtSp.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtSp.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList;
            this.txtSp.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.plantsBindingSource, "Species", true));
            this.txtSp.Location = new System.Drawing.Point(488, 17);
            this.txtSp.Name = "txtSp";
            this.txtSp.Size = new System.Drawing.Size(268, 20);
            this.txtSp.TabIndex = 10;
            // 
            // labNotes
            // 
            this.labNotes.AutoSize = true;
            this.labNotes.Location = new System.Drawing.Point(7, 140);
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
            this.labSource.Location = new System.Drawing.Point(7, 105);
            this.labSource.Name = "labSource";
            this.labSource.Size = new System.Drawing.Size(47, 13);
            this.labSource.TabIndex = 7;
            this.labSource.Text = "Source";
            // 
            // labReplanted
            // 
            this.labReplanted.AutoSize = true;
            this.labReplanted.Location = new System.Drawing.Point(406, 105);
            this.labReplanted.Name = "labReplanted";
            this.labReplanted.Size = new System.Drawing.Size(65, 13);
            this.labReplanted.TabIndex = 6;
            this.labReplanted.Text = "Replanted";
            // 
            // labSyn
            // 
            this.labSyn.AutoSize = true;
            this.labSyn.Location = new System.Drawing.Point(406, 77);
            this.labSyn.Name = "labSyn";
            this.labSyn.Size = new System.Drawing.Size(57, 13);
            this.labSyn.TabIndex = 5;
            this.labSyn.Text = "Synonym";
            // 
            // labHabit
            // 
            this.labHabit.AutoSize = true;
            this.labHabit.Location = new System.Drawing.Point(7, 77);
            this.labHabit.Name = "labHabit";
            this.labHabit.Size = new System.Drawing.Size(73, 13);
            this.labHabit.TabIndex = 4;
            this.labHabit.Text = "Habitat info";
            // 
            // labFieldNo4
            // 
            this.labFieldNo4.AutoSize = true;
            this.labFieldNo4.Location = new System.Drawing.Point(406, 49);
            this.labFieldNo4.Name = "labFieldNo4";
            this.labFieldNo4.Size = new System.Drawing.Size(81, 13);
            this.labFieldNo4.TabIndex = 3;
            this.labFieldNo4.Text = "Field Number";
            // 
            // labSubsp
            // 
            this.labSubsp.AutoSize = true;
            this.labSubsp.Location = new System.Drawing.Point(7, 49);
            this.labSubsp.Name = "labSubsp";
            this.labSubsp.Size = new System.Drawing.Size(72, 13);
            this.labSubsp.TabIndex = 2;
            this.labSubsp.Text = "Subspecies";
            // 
            // labSp
            // 
            this.labSp.AutoSize = true;
            this.labSp.Location = new System.Drawing.Point(406, 21);
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
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewPlantsToolStripMenuItem,
            this.createNewPlantToolStripMenuItem,
            this.saveActualPlantToolStripMenuItem,
            this.updateActualPlantToolStripMenuItem,
            this.deleteActualPlantToolStripMenuItem,
            this.uploadPictureForPlantToolStripMenuItem,
            this.importExcelFileToolStripMenuItem,
            this.printToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1216, 24);
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
            this.viewPlantsToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.viewPlantsToolStripMenuItem.Text = "View Plants";
            // 
            // cactiToolStripMenuItem
            // 
            this.cactiToolStripMenuItem.Name = "cactiToolStripMenuItem";
            this.cactiToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.cactiToolStripMenuItem.Text = "View cacti";
            this.cactiToolStripMenuItem.Click += new System.EventHandler(this.CactiToolStripMenuItem_Click);
            // 
            // furtherSucculentsToolStripMenuItem
            // 
            this.furtherSucculentsToolStripMenuItem.Name = "furtherSucculentsToolStripMenuItem";
            this.furtherSucculentsToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.furtherSucculentsToolStripMenuItem.Text = "View further succulents";
            this.furtherSucculentsToolStripMenuItem.Click += new System.EventHandler(this.FurtherSucculentsToolStripMenuItem_Click);
            // 
            // otherPlantsToolStripMenuItem
            // 
            this.otherPlantsToolStripMenuItem.Name = "otherPlantsToolStripMenuItem";
            this.otherPlantsToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.otherPlantsToolStripMenuItem.Text = "View other plants";
            this.otherPlantsToolStripMenuItem.Click += new System.EventHandler(this.OtherPlantsToolStripMenuItem_Click);
            // 
            // viewAllPlantsToolStripMenuItem
            // 
            this.viewAllPlantsToolStripMenuItem.Name = "viewAllPlantsToolStripMenuItem";
            this.viewAllPlantsToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.viewAllPlantsToolStripMenuItem.Text = "View all plants";
            this.viewAllPlantsToolStripMenuItem.Click += new System.EventHandler(this.ViewAllPlantsToolStripMenuItem_Click);
            // 
            // createNewPlantToolStripMenuItem
            // 
            this.createNewPlantToolStripMenuItem.Name = "createNewPlantToolStripMenuItem";
            this.createNewPlantToolStripMenuItem.Size = new System.Drawing.Size(108, 20);
            this.createNewPlantToolStripMenuItem.Text = "Create new plant";
            this.createNewPlantToolStripMenuItem.Click += new System.EventHandler(this.CreateNewPlantToolStripMenuItem_Click);
            // 
            // saveActualPlantToolStripMenuItem
            // 
            this.saveActualPlantToolStripMenuItem.Name = "saveActualPlantToolStripMenuItem";
            this.saveActualPlantToolStripMenuItem.Size = new System.Drawing.Size(98, 20);
            this.saveActualPlantToolStripMenuItem.Text = "Save new plant";
            this.saveActualPlantToolStripMenuItem.Click += new System.EventHandler(this.SaveActualPlantToolStripMenuItem_Click);
            // 
            // updateActualPlantToolStripMenuItem
            // 
            this.updateActualPlantToolStripMenuItem.Name = "updateActualPlantToolStripMenuItem";
            this.updateActualPlantToolStripMenuItem.Size = new System.Drawing.Size(122, 20);
            this.updateActualPlantToolStripMenuItem.Text = "Update actual plant";
            this.updateActualPlantToolStripMenuItem.Click += new System.EventHandler(this.UpdateActualPlantToolStripMenuItem_Click);
            // 
            // deleteActualPlantToolStripMenuItem
            // 
            this.deleteActualPlantToolStripMenuItem.Name = "deleteActualPlantToolStripMenuItem";
            this.deleteActualPlantToolStripMenuItem.Size = new System.Drawing.Size(117, 20);
            this.deleteActualPlantToolStripMenuItem.Text = "Delete actual plant";
            this.deleteActualPlantToolStripMenuItem.Click += new System.EventHandler(this.DeleteActualPlantToolStripMenuItem_Click);
            // 
            // uploadPictureForPlantToolStripMenuItem
            // 
            this.uploadPictureForPlantToolStripMenuItem.Name = "uploadPictureForPlantToolStripMenuItem";
            this.uploadPictureForPlantToolStripMenuItem.Size = new System.Drawing.Size(145, 20);
            this.uploadPictureForPlantToolStripMenuItem.Text = "Upload picture for plant";
            this.uploadPictureForPlantToolStripMenuItem.Click += new System.EventHandler(this.UploadPictureForPlantToolStripMenuItem_Click);
            // 
            // importExcelFileToolStripMenuItem
            // 
            this.importExcelFileToolStripMenuItem.Name = "importExcelFileToolStripMenuItem";
            this.importExcelFileToolStripMenuItem.Size = new System.Drawing.Size(103, 20);
            this.importExcelFileToolStripMenuItem.Text = "Import Excel file";
            this.importExcelFileToolStripMenuItem.Click += new System.EventHandler(this.ImportExcelFileToolStripMenuItem_Click);
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.printToolStripMenuItem.Text = "Print";
            this.printToolStripMenuItem.Click += new System.EventHandler(this.PrintToolStripMenuItem_Click);
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bindingNavigator1.BindingSource = this.plantsBindingSource;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator1.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bindingNavigator1.Dock = System.Windows.Forms.DockStyle.None;
            this.bindingNavigator1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem});
            this.bindingNavigator1.Location = new System.Drawing.Point(866, -2);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.bindingNavigator1.Size = new System.Drawing.Size(246, 25);
            this.bindingNavigator1.TabIndex = 5;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
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
            this.PlantsBox.Location = new System.Drawing.Point(12, 276);
            this.PlantsBox.Name = "PlantsBox";
            this.PlantsBox.Size = new System.Drawing.Size(1131, 249);
            this.PlantsBox.TabIndex = 6;
            this.PlantsBox.TabStop = false;
            this.PlantsBox.Text = "Plants";
            // 
            // plantsLabelStat
            // 
            this.plantsLabelStat.AutoSize = true;
            this.plantsLabelStat.Location = new System.Drawing.Point(55, 0);
            this.plantsLabelStat.Name = "plantsLabelStat";
            this.plantsLabelStat.Size = new System.Drawing.Size(0, 13);
            this.plantsLabelStat.TabIndex = 9;
            // 
            // PlantsTableView
            // 
            this.PlantsTableView.AllowUserToAddRows = false;
            this.PlantsTableView.AllowUserToDeleteRows = false;
            this.PlantsTableView.AutoGenerateColumns = false;
            this.PlantsTableView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.PlantsTableView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.PlantsTableView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.PlantsTableView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
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
            this.PlantsTableView.Location = new System.Drawing.Point(0, 20);
            this.PlantsTableView.Name = "PlantsTableView";
            this.PlantsTableView.RowHeadersVisible = false;
            this.PlantsTableView.Size = new System.Drawing.Size(1125, 210);
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
            // PlantsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.DarkKhaki;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1216, 525);
            this.Controls.Add(this.PlantsBox);
            this.Controls.Add(this.bindingNavigator1);
            this.Controls.Add(this.PlantDetailsBox);
            this.Controls.Add(this.menuStrip1);
            this.MaximumSize = new System.Drawing.Size(1900, 980);
            this.Name = "PlantsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Welcome to the Ornamental Plant Register!";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.PlantsForm_Load);
            this.Resize += new System.EventHandler(this.PlantsForm_Resize);
            this.PlantDetailsBox.ResumeLayout(false);
            this.PlantDetailsBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.plantsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetForPlantReg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.genusBindingSource)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            this.PlantsBox.ResumeLayout(false);
            this.PlantsBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PlantsTableView)).EndInit();
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
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem createNewPlantToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveActualPlantToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteActualPlantToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uploadPictureForPlantToolStripMenuItem;
        private System.Windows.Forms.RadioButton rbAll;
        private System.Windows.Forms.RadioButton rbOther;
        private System.Windows.Forms.RadioButton rbSucc;
        private System.Windows.Forms.RadioButton rbCacti;
        private System.Windows.Forms.Label labShow;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
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
        private System.Windows.Forms.DateTimePicker dateTimePickerReplanted;
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
    }
}

