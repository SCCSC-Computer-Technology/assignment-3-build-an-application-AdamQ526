namespace AQuinn_CPT_206_Lab3
{
    partial class StateDetailscs
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
            System.Windows.Forms.Label stateIDLabel;
            System.Windows.Forms.Label stateNameLabel;
            System.Windows.Forms.Label populationLabel;
            System.Windows.Forms.Label stateFlowerLabel;
            System.Windows.Forms.Label stateBirdLabel;
            System.Windows.Forms.Label stateColorsLabel;
            System.Windows.Forms.Label threeLargeCitiesLabel;
            System.Windows.Forms.Label stateCapitolLabel;
            System.Windows.Forms.Label flagDescLabel;
            System.Windows.Forms.Label medianIncomeLabel;
            System.Windows.Forms.Label techJobsLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StateDetailscs));
            this.stateInfoDataSet = new AQuinn_CPT_206_Lab3.StateInfoDataSet();
            this.statesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.statesTableAdapter = new AQuinn_CPT_206_Lab3.StateInfoDataSetTableAdapters.StatesTableAdapter();
            this.tableAdapterManager = new AQuinn_CPT_206_Lab3.StateInfoDataSetTableAdapters.TableAdapterManager();
            this.statesBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.statesBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.stateIDTextBox = new System.Windows.Forms.TextBox();
            this.populationTextBox = new System.Windows.Forms.TextBox();
            this.stateFlowerTextBox = new System.Windows.Forms.TextBox();
            this.stateBirdTextBox = new System.Windows.Forms.TextBox();
            this.stateColorsTextBox = new System.Windows.Forms.TextBox();
            this.threeLargeCitiesTextBox = new System.Windows.Forms.TextBox();
            this.stateCapitolTextBox = new System.Windows.Forms.TextBox();
            this.medianIncomeTextBox = new System.Windows.Forms.TextBox();
            this.techJobsTextBox = new System.Windows.Forms.TextBox();
            this.stateDrop = new System.Windows.Forms.ComboBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblFlagDesc = new System.Windows.Forms.Label();
            this.toolTiping = new System.Windows.Forms.ToolTip(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            stateIDLabel = new System.Windows.Forms.Label();
            stateNameLabel = new System.Windows.Forms.Label();
            populationLabel = new System.Windows.Forms.Label();
            stateFlowerLabel = new System.Windows.Forms.Label();
            stateBirdLabel = new System.Windows.Forms.Label();
            stateColorsLabel = new System.Windows.Forms.Label();
            threeLargeCitiesLabel = new System.Windows.Forms.Label();
            stateCapitolLabel = new System.Windows.Forms.Label();
            flagDescLabel = new System.Windows.Forms.Label();
            medianIncomeLabel = new System.Windows.Forms.Label();
            techJobsLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.stateInfoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statesBindingNavigator)).BeginInit();
            this.statesBindingNavigator.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // stateIDLabel
            // 
            stateIDLabel.AutoSize = true;
            stateIDLabel.Location = new System.Drawing.Point(26, 9);
            stateIDLabel.Name = "stateIDLabel";
            stateIDLabel.Size = new System.Drawing.Size(88, 23);
            stateIDLabel.TabIndex = 1;
            stateIDLabel.Text = "State ID:";
            // 
            // stateNameLabel
            // 
            stateNameLabel.AutoSize = true;
            stateNameLabel.Location = new System.Drawing.Point(26, 45);
            stateNameLabel.Name = "stateNameLabel";
            stateNameLabel.Size = new System.Drawing.Size(116, 23);
            stateNameLabel.TabIndex = 3;
            stateNameLabel.Text = "State Name:";
            // 
            // populationLabel
            // 
            populationLabel.AutoSize = true;
            populationLabel.Location = new System.Drawing.Point(26, 81);
            populationLabel.Name = "populationLabel";
            populationLabel.Size = new System.Drawing.Size(106, 23);
            populationLabel.TabIndex = 5;
            populationLabel.Text = "Population:";
            // 
            // stateFlowerLabel
            // 
            stateFlowerLabel.AutoSize = true;
            stateFlowerLabel.Location = new System.Drawing.Point(26, 117);
            stateFlowerLabel.Name = "stateFlowerLabel";
            stateFlowerLabel.Size = new System.Drawing.Size(125, 23);
            stateFlowerLabel.TabIndex = 7;
            stateFlowerLabel.Text = "State Flower:";
            // 
            // stateBirdLabel
            // 
            stateBirdLabel.AutoSize = true;
            stateBirdLabel.Location = new System.Drawing.Point(26, 153);
            stateBirdLabel.Name = "stateBirdLabel";
            stateBirdLabel.Size = new System.Drawing.Size(103, 23);
            stateBirdLabel.TabIndex = 9;
            stateBirdLabel.Text = "State Bird:";
            // 
            // stateColorsLabel
            // 
            stateColorsLabel.AutoSize = true;
            stateColorsLabel.Location = new System.Drawing.Point(26, 189);
            stateColorsLabel.Name = "stateColorsLabel";
            stateColorsLabel.Size = new System.Drawing.Size(122, 23);
            stateColorsLabel.TabIndex = 11;
            stateColorsLabel.Text = "State Colors:";
            // 
            // threeLargeCitiesLabel
            // 
            threeLargeCitiesLabel.AutoSize = true;
            threeLargeCitiesLabel.Location = new System.Drawing.Point(26, 225);
            threeLargeCitiesLabel.Name = "threeLargeCitiesLabel";
            threeLargeCitiesLabel.Size = new System.Drawing.Size(178, 23);
            threeLargeCitiesLabel.TabIndex = 13;
            threeLargeCitiesLabel.Text = "Three Large Cities:";
            // 
            // stateCapitolLabel
            // 
            stateCapitolLabel.AutoSize = true;
            stateCapitolLabel.Location = new System.Drawing.Point(26, 261);
            stateCapitolLabel.Name = "stateCapitolLabel";
            stateCapitolLabel.Size = new System.Drawing.Size(128, 23);
            stateCapitolLabel.TabIndex = 15;
            stateCapitolLabel.Text = "State Capitol:";
            // 
            // flagDescLabel
            // 
            flagDescLabel.AutoSize = true;
            flagDescLabel.Location = new System.Drawing.Point(26, 297);
            flagDescLabel.Name = "flagDescLabel";
            flagDescLabel.Size = new System.Drawing.Size(99, 23);
            flagDescLabel.TabIndex = 17;
            flagDescLabel.Text = "Flag Desc:";
            // 
            // medianIncomeLabel
            // 
            medianIncomeLabel.AutoSize = true;
            medianIncomeLabel.Location = new System.Drawing.Point(705, 6);
            medianIncomeLabel.Name = "medianIncomeLabel";
            medianIncomeLabel.Size = new System.Drawing.Size(146, 23);
            medianIncomeLabel.TabIndex = 19;
            medianIncomeLabel.Text = "Median Income:";
            // 
            // techJobsLabel
            // 
            techJobsLabel.AutoSize = true;
            techJobsLabel.Location = new System.Drawing.Point(705, 42);
            techJobsLabel.Name = "techJobsLabel";
            techJobsLabel.Size = new System.Drawing.Size(100, 23);
            techJobsLabel.TabIndex = 21;
            techJobsLabel.Text = "Tech Jobs:";
            // 
            // stateInfoDataSet
            // 
            this.stateInfoDataSet.DataSetName = "StateInfoDataSet";
            this.stateInfoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // statesBindingSource
            // 
            this.statesBindingSource.DataMember = "States";
            this.statesBindingSource.DataSource = this.stateInfoDataSet;
            // 
            // statesTableAdapter
            // 
            this.statesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.StatesTableAdapter = this.statesTableAdapter;
            this.tableAdapterManager.UpdateOrder = AQuinn_CPT_206_Lab3.StateInfoDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // statesBindingNavigator
            // 
            this.statesBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.statesBindingNavigator.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.statesBindingNavigator.BindingSource = this.statesBindingSource;
            this.statesBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.statesBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.statesBindingNavigator.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statesBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.bindingNavigatorDeleteItem,
            this.statesBindingNavigatorSaveItem});
            this.statesBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.statesBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.statesBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.statesBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.statesBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.statesBindingNavigator.Name = "statesBindingNavigator";
            this.statesBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.statesBindingNavigator.Size = new System.Drawing.Size(1344, 33);
            this.statesBindingNavigator.TabIndex = 0;
            this.statesBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(54, 28);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 33);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 31);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 33);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 33);
            // 
            // statesBindingNavigatorSaveItem
            // 
            this.statesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.statesBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("statesBindingNavigatorSaveItem.Image")));
            this.statesBindingNavigatorSaveItem.Name = "statesBindingNavigatorSaveItem";
            this.statesBindingNavigatorSaveItem.Size = new System.Drawing.Size(34, 28);
            this.statesBindingNavigatorSaveItem.Text = "Save Data";
            this.statesBindingNavigatorSaveItem.Click += new System.EventHandler(this.statesBindingNavigatorSaveItem_Click);
            // 
            // stateIDTextBox
            // 
            this.stateIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.statesBindingSource, "StateID", true));
            this.stateIDTextBox.Location = new System.Drawing.Point(210, 6);
            this.stateIDTextBox.Name = "stateIDTextBox";
            this.stateIDTextBox.Size = new System.Drawing.Size(154, 30);
            this.stateIDTextBox.TabIndex = 2;
            // 
            // populationTextBox
            // 
            this.populationTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.statesBindingSource, "Population", true));
            this.populationTextBox.Location = new System.Drawing.Point(210, 78);
            this.populationTextBox.Name = "populationTextBox";
            this.populationTextBox.Size = new System.Drawing.Size(154, 30);
            this.populationTextBox.TabIndex = 6;
            this.populationTextBox.TextChanged += new System.EventHandler(this.populationTextBox_TextChanged);
            // 
            // stateFlowerTextBox
            // 
            this.stateFlowerTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.statesBindingSource, "StateFlower", true));
            this.stateFlowerTextBox.Location = new System.Drawing.Point(210, 114);
            this.stateFlowerTextBox.Name = "stateFlowerTextBox";
            this.stateFlowerTextBox.Size = new System.Drawing.Size(154, 30);
            this.stateFlowerTextBox.TabIndex = 8;
            // 
            // stateBirdTextBox
            // 
            this.stateBirdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.statesBindingSource, "StateBird", true));
            this.stateBirdTextBox.Location = new System.Drawing.Point(210, 150);
            this.stateBirdTextBox.Name = "stateBirdTextBox";
            this.stateBirdTextBox.Size = new System.Drawing.Size(154, 30);
            this.stateBirdTextBox.TabIndex = 10;
            // 
            // stateColorsTextBox
            // 
            this.stateColorsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.statesBindingSource, "StateColors", true));
            this.stateColorsTextBox.Location = new System.Drawing.Point(210, 186);
            this.stateColorsTextBox.Name = "stateColorsTextBox";
            this.stateColorsTextBox.Size = new System.Drawing.Size(154, 30);
            this.stateColorsTextBox.TabIndex = 12;
            // 
            // threeLargeCitiesTextBox
            // 
            this.threeLargeCitiesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.statesBindingSource, "ThreeLargeCities", true));
            this.threeLargeCitiesTextBox.Location = new System.Drawing.Point(210, 222);
            this.threeLargeCitiesTextBox.Name = "threeLargeCitiesTextBox";
            this.threeLargeCitiesTextBox.Size = new System.Drawing.Size(154, 30);
            this.threeLargeCitiesTextBox.TabIndex = 14;
            // 
            // stateCapitolTextBox
            // 
            this.stateCapitolTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.statesBindingSource, "StateCapitol", true));
            this.stateCapitolTextBox.Location = new System.Drawing.Point(210, 258);
            this.stateCapitolTextBox.Name = "stateCapitolTextBox";
            this.stateCapitolTextBox.Size = new System.Drawing.Size(154, 30);
            this.stateCapitolTextBox.TabIndex = 16;
            // 
            // medianIncomeTextBox
            // 
            this.medianIncomeTextBox.CausesValidation = false;
            this.medianIncomeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.statesBindingSource, "MedianIncome", true));
            this.medianIncomeTextBox.Location = new System.Drawing.Point(889, 3);
            this.medianIncomeTextBox.Name = "medianIncomeTextBox";
            this.medianIncomeTextBox.Size = new System.Drawing.Size(154, 30);
            this.medianIncomeTextBox.TabIndex = 20;
            this.medianIncomeTextBox.TextChanged += new System.EventHandler(this.medianIncomeTextBox_TextChanged);
            // 
            // techJobsTextBox
            // 
            this.techJobsTextBox.CausesValidation = false;
            this.techJobsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.statesBindingSource, "TechJobs", true));
            this.techJobsTextBox.Location = new System.Drawing.Point(889, 39);
            this.techJobsTextBox.Name = "techJobsTextBox";
            this.techJobsTextBox.Size = new System.Drawing.Size(154, 30);
            this.techJobsTextBox.TabIndex = 22;
            this.techJobsTextBox.TextChanged += new System.EventHandler(this.techJobsTextBox_TextChanged);
            // 
            // stateDrop
            // 
            this.stateDrop.DataSource = this.statesBindingSource;
            this.stateDrop.DisplayMember = "StateName";
            this.stateDrop.FormattingEnabled = true;
            this.stateDrop.Location = new System.Drawing.Point(210, 43);
            this.stateDrop.Name = "stateDrop";
            this.stateDrop.Size = new System.Drawing.Size(208, 31);
            this.stateDrop.TabIndex = 23;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(33, 479);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(121, 59);
            this.btnExit.TabIndex = 24;
            this.btnExit.Text = "&Exit";
            this.toolTiping.SetToolTip(this.btnExit, "Closes details form");
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblFlagDesc
            // 
            this.lblFlagDesc.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.statesBindingSource, "FlagDesc", true));
            this.lblFlagDesc.Location = new System.Drawing.Point(206, 312);
            this.lblFlagDesc.Name = "lblFlagDesc";
            this.lblFlagDesc.Size = new System.Drawing.Size(817, 172);
            this.lblFlagDesc.TabIndex = 25;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblFlagDesc);
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.stateDrop);
            this.panel1.Controls.Add(stateIDLabel);
            this.panel1.Controls.Add(this.stateIDTextBox);
            this.panel1.Controls.Add(stateNameLabel);
            this.panel1.Controls.Add(populationLabel);
            this.panel1.Controls.Add(this.populationTextBox);
            this.panel1.Controls.Add(stateFlowerLabel);
            this.panel1.Controls.Add(this.stateFlowerTextBox);
            this.panel1.Controls.Add(stateBirdLabel);
            this.panel1.Controls.Add(this.stateBirdTextBox);
            this.panel1.Controls.Add(stateColorsLabel);
            this.panel1.Controls.Add(this.stateColorsTextBox);
            this.panel1.Controls.Add(threeLargeCitiesLabel);
            this.panel1.Controls.Add(this.threeLargeCitiesTextBox);
            this.panel1.Controls.Add(stateCapitolLabel);
            this.panel1.Controls.Add(this.stateCapitolTextBox);
            this.panel1.Controls.Add(flagDescLabel);
            this.panel1.Controls.Add(medianIncomeLabel);
            this.panel1.Controls.Add(this.medianIncomeTextBox);
            this.panel1.Controls.Add(techJobsLabel);
            this.panel1.Controls.Add(this.techJobsTextBox);
            this.panel1.Location = new System.Drawing.Point(67, 47);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1211, 589);
            this.panel1.TabIndex = 26;
            // 
            // StateDetailscs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1344, 658);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statesBindingNavigator);
            this.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "StateDetailscs";
            this.Text = "StateDetailscs";
            this.Load += new System.EventHandler(this.StateDetailscs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.stateInfoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statesBindingNavigator)).EndInit();
            this.statesBindingNavigator.ResumeLayout(false);
            this.statesBindingNavigator.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private StateInfoDataSet stateInfoDataSet;
        private System.Windows.Forms.BindingSource statesBindingSource;
        private StateInfoDataSetTableAdapters.StatesTableAdapter statesTableAdapter;
        private StateInfoDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator statesBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton statesBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox stateIDTextBox;
        private System.Windows.Forms.TextBox populationTextBox;
        private System.Windows.Forms.TextBox stateFlowerTextBox;
        private System.Windows.Forms.TextBox stateBirdTextBox;
        private System.Windows.Forms.TextBox stateColorsTextBox;
        private System.Windows.Forms.TextBox threeLargeCitiesTextBox;
        private System.Windows.Forms.TextBox stateCapitolTextBox;
        private System.Windows.Forms.TextBox medianIncomeTextBox;
        private System.Windows.Forms.TextBox techJobsTextBox;
        private System.Windows.Forms.ComboBox stateDrop;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblFlagDesc;
        private System.Windows.Forms.ToolTip toolTiping;
        private System.Windows.Forms.Panel panel1;
    }
}