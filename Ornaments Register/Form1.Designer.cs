namespace Ornaments_Register
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbAll = new System.Windows.Forms.RadioButton();
            this.rbOther = new System.Windows.Forms.RadioButton();
            this.rbSucc = new System.Windows.Forms.RadioButton();
            this.rbCacti = new System.Windows.Forms.RadioButton();
            this.labShow = new System.Windows.Forms.Label();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.plantsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetForPlantReg = new Ornaments_Register.DataSetForPlantReg();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtSubsp = new System.Windows.Forms.TextBox();
            this.txtReplanted = new System.Windows.Forms.TextBox();
            this.txtSource = new System.Windows.Forms.TextBox();
            this.txtSyn = new System.Windows.Forms.TextBox();
            this.txtHabit = new System.Windows.Forms.TextBox();
            this.txtFieldNo = new System.Windows.Forms.TextBox();
            this.txtSp = new System.Windows.Forms.TextBox();
            this.cboxGen = new System.Windows.Forms.ComboBox();
            this.labNotes = new System.Windows.Forms.Label();
            this.labSource = new System.Windows.Forms.Label();
            this.labReplanted = new System.Windows.Forms.Label();
            this.labSyn = new System.Windows.Forms.Label();
            this.labHabit = new System.Windows.Forms.Label();
            this.labFieldNo4 = new System.Windows.Forms.Label();
            this.labSubsp = new System.Windows.Forms.Label();
            this.labSp = new System.Windows.Forms.Label();
            this.labGen = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.createNewPlantToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveActualPlantToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteActualPlantToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uploadPictureForPlantToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
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
            this.plantsTableAdapter = new Ornaments_Register.DataSetForPlantRegTableAdapters.PlantsTableAdapter();
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
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.plantsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetForPlantReg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.rbAll);
            this.groupBox1.Controls.Add(this.rbOther);
            this.groupBox1.Controls.Add(this.rbSucc);
            this.groupBox1.Controls.Add(this.rbCacti);
            this.groupBox1.Controls.Add(this.labShow);
            this.groupBox1.Controls.Add(this.txtNotes);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.txtSubsp);
            this.groupBox1.Controls.Add(this.txtReplanted);
            this.groupBox1.Controls.Add(this.txtSource);
            this.groupBox1.Controls.Add(this.txtSyn);
            this.groupBox1.Controls.Add(this.txtHabit);
            this.groupBox1.Controls.Add(this.txtFieldNo);
            this.groupBox1.Controls.Add(this.txtSp);
            this.groupBox1.Controls.Add(this.cboxGen);
            this.groupBox1.Controls.Add(this.labNotes);
            this.groupBox1.Controls.Add(this.labSource);
            this.groupBox1.Controls.Add(this.labReplanted);
            this.groupBox1.Controls.Add(this.labSyn);
            this.groupBox1.Controls.Add(this.labHabit);
            this.groupBox1.Controls.Add(this.labFieldNo4);
            this.groupBox1.Controls.Add(this.labSubsp);
            this.groupBox1.Controls.Add(this.labSp);
            this.groupBox1.Controls.Add(this.labGen);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox1.Location = new System.Drawing.Point(12, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1125, 225);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Plant Details";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // rbAll
            // 
            this.rbAll.AutoSize = true;
            this.rbAll.Location = new System.Drawing.Point(657, 194);
            this.rbAll.Name = "rbAll";
            this.rbAll.Size = new System.Drawing.Size(115, 17);
            this.rbAll.TabIndex = 23;
            this.rbAll.TabStop = true;
            this.rbAll.Text = "All of the Plants";
            this.rbAll.UseVisualStyleBackColor = true;
            this.rbAll.CheckedChanged += new System.EventHandler(this.rbAll_CheckedChanged);
            // 
            // rbOther
            // 
            this.rbOther.AutoSize = true;
            this.rbOther.Location = new System.Drawing.Point(537, 194);
            this.rbOther.Name = "rbOther";
            this.rbOther.Size = new System.Drawing.Size(95, 17);
            this.rbOther.TabIndex = 22;
            this.rbOther.TabStop = true;
            this.rbOther.Text = "Other Plants";
            this.rbOther.UseVisualStyleBackColor = true;
            this.rbOther.CheckedChanged += new System.EventHandler(this.rbOther_CheckedChanged);
            // 
            // rbSucc
            // 
            this.rbSucc.AutoSize = true;
            this.rbSucc.Location = new System.Drawing.Point(380, 194);
            this.rbSucc.Name = "rbSucc";
            this.rbSucc.Size = new System.Drawing.Size(132, 17);
            this.rbSucc.TabIndex = 21;
            this.rbSucc.TabStop = true;
            this.rbSucc.Text = "Further Succulents";
            this.rbSucc.UseVisualStyleBackColor = true;
            this.rbSucc.CheckedChanged += new System.EventHandler(this.rbSucc_CheckedChanged);
            // 
            // rbCacti
            // 
            this.rbCacti.AutoSize = true;
            this.rbCacti.Location = new System.Drawing.Point(301, 194);
            this.rbCacti.Name = "rbCacti";
            this.rbCacti.Size = new System.Drawing.Size(54, 17);
            this.rbCacti.TabIndex = 20;
            this.rbCacti.TabStop = true;
            this.rbCacti.Text = "Cacti";
            this.rbCacti.UseVisualStyleBackColor = true;
            this.rbCacti.CheckedChanged += new System.EventHandler(this.rbCacti_CheckedChanged);
            // 
            // labShow
            // 
            this.labShow.AutoSize = true;
            this.labShow.Location = new System.Drawing.Point(10, 194);
            this.labShow.Name = "labShow";
            this.labShow.Size = new System.Drawing.Size(266, 13);
            this.labShow.TabIndex = 19;
            this.labShow.Text = "What plants would you like to see on the list?";
            // 
            // txtNotes
            // 
            this.txtNotes.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.plantsBindingSource, "Notes", true));
            this.txtNotes.Location = new System.Drawing.Point(118, 136);
            this.txtNotes.Multiline = true;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(654, 50);
            this.txtNotes.TabIndex = 17;
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
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(807, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(318, 189);
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // txtSubsp
            // 
            this.txtSubsp.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.plantsBindingSource, "Subspecies", true));
            this.txtSubsp.Location = new System.Drawing.Point(118, 47);
            this.txtSubsp.Name = "txtSubsp";
            this.txtSubsp.Size = new System.Drawing.Size(268, 20);
            this.txtSubsp.TabIndex = 11;
            this.txtSubsp.TextChanged += new System.EventHandler(this.TxtSubsp_TextChanged);
            // 
            // txtReplanted
            // 
            this.txtReplanted.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.plantsBindingSource, "Replanted", true));
            this.txtReplanted.Location = new System.Drawing.Point(504, 104);
            this.txtReplanted.Name = "txtReplanted";
            this.txtReplanted.Size = new System.Drawing.Size(268, 20);
            this.txtReplanted.TabIndex = 16;
            // 
            // txtSource
            // 
            this.txtSource.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.plantsBindingSource, "Source", true));
            this.txtSource.Location = new System.Drawing.Point(118, 105);
            this.txtSource.Margin = new System.Windows.Forms.Padding(10);
            this.txtSource.Name = "txtSource";
            this.txtSource.Size = new System.Drawing.Size(268, 20);
            this.txtSource.TabIndex = 15;
            // 
            // txtSyn
            // 
            this.txtSyn.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.plantsBindingSource, "Synonym", true));
            this.txtSyn.Location = new System.Drawing.Point(504, 75);
            this.txtSyn.Name = "txtSyn";
            this.txtSyn.Size = new System.Drawing.Size(268, 20);
            this.txtSyn.TabIndex = 14;
            // 
            // txtHabit
            // 
            this.txtHabit.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.plantsBindingSource, "Habitat", true));
            this.txtHabit.Location = new System.Drawing.Point(118, 76);
            this.txtHabit.Name = "txtHabit";
            this.txtHabit.Size = new System.Drawing.Size(268, 20);
            this.txtHabit.TabIndex = 13;
            // 
            // txtFieldNo
            // 
            this.txtFieldNo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.plantsBindingSource, "FieldNumber", true));
            this.txtFieldNo.Location = new System.Drawing.Point(504, 46);
            this.txtFieldNo.Name = "txtFieldNo";
            this.txtFieldNo.Size = new System.Drawing.Size(268, 20);
            this.txtFieldNo.TabIndex = 12;
            // 
            // txtSp
            // 
            this.txtSp.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.plantsBindingSource, "Species", true));
            this.txtSp.Location = new System.Drawing.Point(504, 17);
            this.txtSp.Name = "txtSp";
            this.txtSp.Size = new System.Drawing.Size(268, 20);
            this.txtSp.TabIndex = 10;
            // 
            // cboxGen
            // 
            this.cboxGen.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.plantsBindingSource, "Genus", true));
            this.cboxGen.FormattingEnabled = true;
            this.cboxGen.Location = new System.Drawing.Point(118, 17);
            this.cboxGen.Name = "cboxGen";
            this.cboxGen.Size = new System.Drawing.Size(268, 21);
            this.cboxGen.TabIndex = 9;
            this.cboxGen.SelectedIndexChanged += new System.EventHandler(this.CboxGen_SelectedIndexChanged);
            // 
            // labNotes
            // 
            this.labNotes.AutoSize = true;
            this.labNotes.Location = new System.Drawing.Point(7, 140);
            this.labNotes.Name = "labNotes";
            this.labNotes.Size = new System.Drawing.Size(40, 13);
            this.labNotes.TabIndex = 8;
            this.labNotes.Text = "Notes";
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
            this.labReplanted.Location = new System.Drawing.Point(422, 105);
            this.labReplanted.Name = "labReplanted";
            this.labReplanted.Size = new System.Drawing.Size(65, 13);
            this.labReplanted.TabIndex = 6;
            this.labReplanted.Text = "Replanted";
            // 
            // labSyn
            // 
            this.labSyn.AutoSize = true;
            this.labSyn.Location = new System.Drawing.Point(422, 77);
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
            this.labHabit.Size = new System.Drawing.Size(114, 13);
            this.labHabit.TabIndex = 4;
            this.labHabit.Text = "Habitat information";
            // 
            // labFieldNo4
            // 
            this.labFieldNo4.AutoSize = true;
            this.labFieldNo4.Location = new System.Drawing.Point(422, 49);
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
            this.labSp.Location = new System.Drawing.Point(422, 21);
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
            this.createNewPlantToolStripMenuItem,
            this.saveActualPlantToolStripMenuItem,
            this.deleteActualPlantToolStripMenuItem,
            this.uploadPictureForPlantToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1147, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // createNewPlantToolStripMenuItem
            // 
            this.createNewPlantToolStripMenuItem.Name = "createNewPlantToolStripMenuItem";
            this.createNewPlantToolStripMenuItem.Size = new System.Drawing.Size(108, 20);
            this.createNewPlantToolStripMenuItem.Text = "Create new plant";
            this.createNewPlantToolStripMenuItem.Click += new System.EventHandler(this.createNewPlantToolStripMenuItem_Click);
            // 
            // saveActualPlantToolStripMenuItem
            // 
            this.saveActualPlantToolStripMenuItem.Name = "saveActualPlantToolStripMenuItem";
            this.saveActualPlantToolStripMenuItem.Size = new System.Drawing.Size(108, 20);
            this.saveActualPlantToolStripMenuItem.Text = "Save actual plant";
            this.saveActualPlantToolStripMenuItem.Click += new System.EventHandler(this.saveActualPlantToolStripMenuItem_Click);
            // 
            // deleteActualPlantToolStripMenuItem
            // 
            this.deleteActualPlantToolStripMenuItem.Name = "deleteActualPlantToolStripMenuItem";
            this.deleteActualPlantToolStripMenuItem.Size = new System.Drawing.Size(117, 20);
            this.deleteActualPlantToolStripMenuItem.Text = "Delete actual plant";
            this.deleteActualPlantToolStripMenuItem.Click += new System.EventHandler(this.deleteActualPlantToolStripMenuItem_Click);
            // 
            // uploadPictureForPlantToolStripMenuItem
            // 
            this.uploadPictureForPlantToolStripMenuItem.Name = "uploadPictureForPlantToolStripMenuItem";
            this.uploadPictureForPlantToolStripMenuItem.Size = new System.Drawing.Size(145, 20);
            this.uploadPictureForPlantToolStripMenuItem.Text = "Upload picture for plant";
            this.uploadPictureForPlantToolStripMenuItem.Click += new System.EventHandler(this.uploadPictureForPlantToolStripMenuItem_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.dataGridView1.DataSource = this.plantsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 264);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(1125, 248);
            this.dataGridView1.TabIndex = 4;
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bindingNavigator1.BindingSource = this.plantsBindingSource;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator1.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bindingNavigator1.Dock = System.Windows.Forms.DockStyle.None;
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
            this.bindingNavigator1.Location = new System.Drawing.Point(851, 0);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(255, 25);
            this.bindingNavigator1.TabIndex = 5;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
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
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
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
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
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
            // plantsTableAdapter
            // 
            this.plantsTableAdapter.ClearBeforeFill = true;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.Width = 50;
            // 
            // genusDataGridViewTextBoxColumn
            // 
            this.genusDataGridViewTextBoxColumn.DataPropertyName = "Genus";
            this.genusDataGridViewTextBoxColumn.HeaderText = "Genus";
            this.genusDataGridViewTextBoxColumn.Name = "genusDataGridViewTextBoxColumn";
            this.genusDataGridViewTextBoxColumn.Width = 200;
            // 
            // speciesDataGridViewTextBoxColumn
            // 
            this.speciesDataGridViewTextBoxColumn.DataPropertyName = "Species";
            this.speciesDataGridViewTextBoxColumn.HeaderText = "Species";
            this.speciesDataGridViewTextBoxColumn.Name = "speciesDataGridViewTextBoxColumn";
            this.speciesDataGridViewTextBoxColumn.Width = 200;
            // 
            // subspeciesDataGridViewTextBoxColumn
            // 
            this.subspeciesDataGridViewTextBoxColumn.DataPropertyName = "Subspecies";
            this.subspeciesDataGridViewTextBoxColumn.HeaderText = "Subspecies";
            this.subspeciesDataGridViewTextBoxColumn.Name = "subspeciesDataGridViewTextBoxColumn";
            this.subspeciesDataGridViewTextBoxColumn.Width = 150;
            // 
            // fieldNumberDataGridViewTextBoxColumn
            // 
            this.fieldNumberDataGridViewTextBoxColumn.DataPropertyName = "FieldNumber";
            this.fieldNumberDataGridViewTextBoxColumn.HeaderText = "FieldNumber";
            this.fieldNumberDataGridViewTextBoxColumn.Name = "fieldNumberDataGridViewTextBoxColumn";
            // 
            // habitatDataGridViewTextBoxColumn
            // 
            this.habitatDataGridViewTextBoxColumn.DataPropertyName = "Habitat";
            this.habitatDataGridViewTextBoxColumn.HeaderText = "Habitat";
            this.habitatDataGridViewTextBoxColumn.Name = "habitatDataGridViewTextBoxColumn";
            this.habitatDataGridViewTextBoxColumn.Width = 110;
            // 
            // synonymDataGridViewTextBoxColumn
            // 
            this.synonymDataGridViewTextBoxColumn.DataPropertyName = "Synonym";
            this.synonymDataGridViewTextBoxColumn.HeaderText = "Synonym";
            this.synonymDataGridViewTextBoxColumn.Name = "synonymDataGridViewTextBoxColumn";
            // 
            // sourceDataGridViewTextBoxColumn
            // 
            this.sourceDataGridViewTextBoxColumn.DataPropertyName = "Source";
            this.sourceDataGridViewTextBoxColumn.HeaderText = "Source";
            this.sourceDataGridViewTextBoxColumn.Name = "sourceDataGridViewTextBoxColumn";
            this.sourceDataGridViewTextBoxColumn.Width = 70;
            // 
            // replantedDataGridViewTextBoxColumn
            // 
            this.replantedDataGridViewTextBoxColumn.DataPropertyName = "Replanted";
            this.replantedDataGridViewTextBoxColumn.HeaderText = "Replanted";
            this.replantedDataGridViewTextBoxColumn.Name = "replantedDataGridViewTextBoxColumn";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Notes";
            this.dataGridViewTextBoxColumn1.HeaderText = "Notes";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 42;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.DarkKhaki;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1147, 545);
            this.Controls.Add(this.bindingNavigator1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MaximumSize = new System.Drawing.Size(1920, 1080);
            this.Name = "Form1";
            this.Text = "Welcome to the Ornamental Plant Register!";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.plantsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetForPlantReg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cboxGen;
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
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn notesDataGridViewTextBoxColumn;
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
    }
}

