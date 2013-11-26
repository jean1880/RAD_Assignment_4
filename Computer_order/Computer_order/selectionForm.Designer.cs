namespace Computer_order
{
    partial class selectionForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(selectionForm));
            this.computerGrid = new System.Windows.Forms.DataGridView();
            this.manufacturerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GPU_Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HDD_size = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CPU_brand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CPU_number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.screensizeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.conditionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.weight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HDD_speed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RAM_size = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RAM_type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.resolution = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dollarcomputersDataSet = new Computer_order.dollarcomputersDataSet();
            this.productsTableAdapter = new Computer_order.dollarcomputersDataSetTableAdapters.productsTableAdapter();
            this.infoBox = new System.Windows.Forms.GroupBox();
            this.infoFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.manufacturerBox = new System.Windows.Forms.GroupBox();
            this.manufaturerLabel = new System.Windows.Forms.Label();
            this.ModelBox = new System.Windows.Forms.GroupBox();
            this.modelLabel = new System.Windows.Forms.Label();
            this.cpuBox = new System.Windows.Forms.GroupBox();
            this.cpuLabel = new System.Windows.Forms.Label();
            this.HDDBox = new System.Windows.Forms.GroupBox();
            this.HDDLabel = new System.Windows.Forms.Label();
            this.GPUBox = new System.Windows.Forms.GroupBox();
            this.GPULabel = new System.Windows.Forms.Label();
            this.OSBox = new System.Windows.Forms.GroupBox();
            this.OSLabel = new System.Windows.Forms.Label();
            this.costUserLabel = new System.Windows.Forms.Label();
            this.costLabel = new System.Windows.Forms.Label();
            this.HSTUserLabel = new System.Windows.Forms.Label();
            this.totalUserLabel = new System.Windows.Forms.Label();
            this.HSTLabel = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.costBox = new System.Windows.Forms.GroupBox();
            this.cancelButton = new System.Windows.Forms.Button();
            this.nextButton = new System.Windows.Forms.Button();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundFillerWorker = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.computerGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dollarcomputersDataSet)).BeginInit();
            this.infoBox.SuspendLayout();
            this.infoFlowLayoutPanel.SuspendLayout();
            this.manufacturerBox.SuspendLayout();
            this.ModelBox.SuspendLayout();
            this.cpuBox.SuspendLayout();
            this.HDDBox.SuspendLayout();
            this.GPUBox.SuspendLayout();
            this.OSBox.SuspendLayout();
            this.costBox.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // computerGrid
            // 
            this.computerGrid.AllowUserToAddRows = false;
            this.computerGrid.AllowUserToDeleteRows = false;
            this.computerGrid.AllowUserToResizeColumns = false;
            this.computerGrid.AllowUserToResizeRows = false;
            this.computerGrid.AutoGenerateColumns = false;
            this.computerGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.computerGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.computerGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.computerGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.manufacturerDataGridViewTextBoxColumn,
            this.modelDataGridViewTextBoxColumn,
            this.costDataGridViewTextBoxColumn,
            this.GPU_Type,
            this.HDD_size,
            this.CPU_brand,
            this.CPU_number,
            this.screensizeDataGridViewTextBoxColumn,
            this.conditionDataGridViewTextBoxColumn,
            this.oSDataGridViewTextBoxColumn,
            this.weight,
            this.HDD_speed,
            this.RAM_size,
            this.RAM_type,
            this.resolution});
            this.computerGrid.DataSource = this.productsBindingSource;
            this.computerGrid.Location = new System.Drawing.Point(8, 30);
            this.computerGrid.MultiSelect = false;
            this.computerGrid.Name = "computerGrid";
            this.computerGrid.ReadOnly = true;
            this.computerGrid.RowTemplate.ReadOnly = true;
            this.computerGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.computerGrid.Size = new System.Drawing.Size(1193, 267);
            this.computerGrid.TabIndex = 0;
            this.computerGrid.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.row_focus);
            // 
            // manufacturerDataGridViewTextBoxColumn
            // 
            this.manufacturerDataGridViewTextBoxColumn.DataPropertyName = "manufacturer";
            this.manufacturerDataGridViewTextBoxColumn.HeaderText = "manufacturer";
            this.manufacturerDataGridViewTextBoxColumn.Name = "manufacturerDataGridViewTextBoxColumn";
            this.manufacturerDataGridViewTextBoxColumn.ReadOnly = true;
            this.manufacturerDataGridViewTextBoxColumn.Width = 94;
            // 
            // modelDataGridViewTextBoxColumn
            // 
            this.modelDataGridViewTextBoxColumn.DataPropertyName = "model";
            this.modelDataGridViewTextBoxColumn.HeaderText = "model";
            this.modelDataGridViewTextBoxColumn.Name = "modelDataGridViewTextBoxColumn";
            this.modelDataGridViewTextBoxColumn.ReadOnly = true;
            this.modelDataGridViewTextBoxColumn.Width = 60;
            // 
            // costDataGridViewTextBoxColumn
            // 
            this.costDataGridViewTextBoxColumn.DataPropertyName = "cost";
            this.costDataGridViewTextBoxColumn.HeaderText = "cost";
            this.costDataGridViewTextBoxColumn.Name = "costDataGridViewTextBoxColumn";
            this.costDataGridViewTextBoxColumn.ReadOnly = true;
            this.costDataGridViewTextBoxColumn.Width = 52;
            // 
            // GPU_Type
            // 
            this.GPU_Type.DataPropertyName = "GPU_Type";
            this.GPU_Type.HeaderText = "GPU_Type";
            this.GPU_Type.Name = "GPU_Type";
            this.GPU_Type.ReadOnly = true;
            this.GPU_Type.Width = 85;
            // 
            // HDD_size
            // 
            this.HDD_size.DataPropertyName = "HDD_size";
            this.HDD_size.HeaderText = "HDD_size";
            this.HDD_size.Name = "HDD_size";
            this.HDD_size.ReadOnly = true;
            this.HDD_size.Width = 80;
            // 
            // CPU_brand
            // 
            this.CPU_brand.DataPropertyName = "CPU_brand";
            this.CPU_brand.HeaderText = "CPU_brand";
            this.CPU_brand.Name = "CPU_brand";
            this.CPU_brand.ReadOnly = true;
            this.CPU_brand.Width = 87;
            // 
            // CPU_number
            // 
            this.CPU_number.DataPropertyName = "CPU_number";
            this.CPU_number.HeaderText = "CPU_number";
            this.CPU_number.Name = "CPU_number";
            this.CPU_number.ReadOnly = true;
            this.CPU_number.Width = 95;
            // 
            // screensizeDataGridViewTextBoxColumn
            // 
            this.screensizeDataGridViewTextBoxColumn.DataPropertyName = "screensize";
            this.screensizeDataGridViewTextBoxColumn.HeaderText = "screensize";
            this.screensizeDataGridViewTextBoxColumn.Name = "screensizeDataGridViewTextBoxColumn";
            this.screensizeDataGridViewTextBoxColumn.ReadOnly = true;
            this.screensizeDataGridViewTextBoxColumn.Width = 82;
            // 
            // conditionDataGridViewTextBoxColumn
            // 
            this.conditionDataGridViewTextBoxColumn.DataPropertyName = "condition";
            this.conditionDataGridViewTextBoxColumn.HeaderText = "condition";
            this.conditionDataGridViewTextBoxColumn.Name = "conditionDataGridViewTextBoxColumn";
            this.conditionDataGridViewTextBoxColumn.ReadOnly = true;
            this.conditionDataGridViewTextBoxColumn.Width = 75;
            // 
            // oSDataGridViewTextBoxColumn
            // 
            this.oSDataGridViewTextBoxColumn.DataPropertyName = "OS";
            this.oSDataGridViewTextBoxColumn.HeaderText = "OS";
            this.oSDataGridViewTextBoxColumn.Name = "oSDataGridViewTextBoxColumn";
            this.oSDataGridViewTextBoxColumn.ReadOnly = true;
            this.oSDataGridViewTextBoxColumn.Width = 47;
            // 
            // weight
            // 
            this.weight.DataPropertyName = "weight";
            this.weight.HeaderText = "weight";
            this.weight.Name = "weight";
            this.weight.ReadOnly = true;
            this.weight.Width = 63;
            // 
            // HDD_speed
            // 
            this.HDD_speed.DataPropertyName = "HDD_speed";
            this.HDD_speed.HeaderText = "HDD_speed";
            this.HDD_speed.Name = "HDD_speed";
            this.HDD_speed.ReadOnly = true;
            this.HDD_speed.Width = 91;
            // 
            // RAM_size
            // 
            this.RAM_size.DataPropertyName = "RAM_size";
            this.RAM_size.HeaderText = "RAM_size";
            this.RAM_size.Name = "RAM_size";
            this.RAM_size.ReadOnly = true;
            this.RAM_size.Width = 80;
            // 
            // RAM_type
            // 
            this.RAM_type.DataPropertyName = "RAM_type";
            this.RAM_type.HeaderText = "RAM_type";
            this.RAM_type.Name = "RAM_type";
            this.RAM_type.ReadOnly = true;
            this.RAM_type.Width = 82;
            // 
            // resolution
            // 
            this.resolution.DataPropertyName = "resolution";
            this.resolution.HeaderText = "resolution";
            this.resolution.Name = "resolution";
            this.resolution.ReadOnly = true;
            this.resolution.Width = 77;
            // 
            // productsBindingSource
            // 
            this.productsBindingSource.DataMember = "products";
            this.productsBindingSource.DataSource = this.dollarcomputersDataSet;
            // 
            // dollarcomputersDataSet
            // 
            this.dollarcomputersDataSet.DataSetName = "dollarcomputersDataSet";
            this.dollarcomputersDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productsTableAdapter
            // 
            this.productsTableAdapter.ClearBeforeFill = true;
            // 
            // infoBox
            // 
            this.infoBox.Controls.Add(this.infoFlowLayoutPanel);
            this.infoBox.Location = new System.Drawing.Point(81, 299);
            this.infoBox.Name = "infoBox";
            this.infoBox.Size = new System.Drawing.Size(687, 143);
            this.infoBox.TabIndex = 1;
            this.infoBox.TabStop = false;
            this.infoBox.Text = "groupBox1";
            // 
            // infoFlowLayoutPanel
            // 
            this.infoFlowLayoutPanel.Controls.Add(this.manufacturerBox);
            this.infoFlowLayoutPanel.Controls.Add(this.ModelBox);
            this.infoFlowLayoutPanel.Controls.Add(this.cpuBox);
            this.infoFlowLayoutPanel.Controls.Add(this.HDDBox);
            this.infoFlowLayoutPanel.Controls.Add(this.GPUBox);
            this.infoFlowLayoutPanel.Controls.Add(this.OSBox);
            this.infoFlowLayoutPanel.Location = new System.Drawing.Point(6, 20);
            this.infoFlowLayoutPanel.Name = "infoFlowLayoutPanel";
            this.infoFlowLayoutPanel.Size = new System.Drawing.Size(675, 117);
            this.infoFlowLayoutPanel.TabIndex = 0;
            // 
            // manufacturerBox
            // 
            this.manufacturerBox.AutoSize = true;
            this.manufacturerBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.manufacturerBox.Controls.Add(this.manufaturerLabel);
            this.manufacturerBox.Location = new System.Drawing.Point(3, 3);
            this.manufacturerBox.MinimumSize = new System.Drawing.Size(200, 40);
            this.manufacturerBox.Name = "manufacturerBox";
            this.manufacturerBox.Size = new System.Drawing.Size(200, 49);
            this.manufacturerBox.TabIndex = 0;
            this.manufacturerBox.TabStop = false;
            this.manufacturerBox.Text = "Manufacturer";
            // 
            // manufaturerLabel
            // 
            this.manufaturerLabel.AutoSize = true;
            this.manufaturerLabel.Location = new System.Drawing.Point(6, 20);
            this.manufaturerLabel.Name = "manufaturerLabel";
            this.manufaturerLabel.Size = new System.Drawing.Size(35, 13);
            this.manufaturerLabel.TabIndex = 0;
            this.manufaturerLabel.Text = "label1";
            // 
            // ModelBox
            // 
            this.ModelBox.AutoSize = true;
            this.ModelBox.Controls.Add(this.modelLabel);
            this.ModelBox.Location = new System.Drawing.Point(209, 3);
            this.ModelBox.MinimumSize = new System.Drawing.Size(200, 40);
            this.ModelBox.Name = "ModelBox";
            this.ModelBox.Size = new System.Drawing.Size(200, 49);
            this.ModelBox.TabIndex = 4;
            this.ModelBox.TabStop = false;
            this.ModelBox.Text = "Model";
            // 
            // modelLabel
            // 
            this.modelLabel.AutoSize = true;
            this.modelLabel.Location = new System.Drawing.Point(6, 20);
            this.modelLabel.Name = "modelLabel";
            this.modelLabel.Size = new System.Drawing.Size(35, 13);
            this.modelLabel.TabIndex = 0;
            this.modelLabel.Text = "label2";
            // 
            // cpuBox
            // 
            this.cpuBox.AutoSize = true;
            this.cpuBox.Controls.Add(this.cpuLabel);
            this.cpuBox.Location = new System.Drawing.Point(415, 3);
            this.cpuBox.MinimumSize = new System.Drawing.Size(200, 40);
            this.cpuBox.Name = "cpuBox";
            this.cpuBox.Size = new System.Drawing.Size(200, 49);
            this.cpuBox.TabIndex = 1;
            this.cpuBox.TabStop = false;
            this.cpuBox.Text = "CPU Info";
            // 
            // cpuLabel
            // 
            this.cpuLabel.AutoSize = true;
            this.cpuLabel.Location = new System.Drawing.Point(6, 20);
            this.cpuLabel.Name = "cpuLabel";
            this.cpuLabel.Size = new System.Drawing.Size(35, 13);
            this.cpuLabel.TabIndex = 0;
            this.cpuLabel.Text = "label2";
            // 
            // HDDBox
            // 
            this.HDDBox.AutoSize = true;
            this.HDDBox.Controls.Add(this.HDDLabel);
            this.HDDBox.Location = new System.Drawing.Point(3, 58);
            this.HDDBox.MinimumSize = new System.Drawing.Size(200, 40);
            this.HDDBox.Name = "HDDBox";
            this.HDDBox.Size = new System.Drawing.Size(200, 49);
            this.HDDBox.TabIndex = 2;
            this.HDDBox.TabStop = false;
            this.HDDBox.Text = "Hardrive";
            // 
            // HDDLabel
            // 
            this.HDDLabel.AutoSize = true;
            this.HDDLabel.Location = new System.Drawing.Point(6, 20);
            this.HDDLabel.Name = "HDDLabel";
            this.HDDLabel.Size = new System.Drawing.Size(35, 13);
            this.HDDLabel.TabIndex = 0;
            this.HDDLabel.Text = "label2";
            // 
            // GPUBox
            // 
            this.GPUBox.AutoSize = true;
            this.GPUBox.Controls.Add(this.GPULabel);
            this.GPUBox.Location = new System.Drawing.Point(209, 58);
            this.GPUBox.MinimumSize = new System.Drawing.Size(200, 40);
            this.GPUBox.Name = "GPUBox";
            this.GPUBox.Size = new System.Drawing.Size(200, 49);
            this.GPUBox.TabIndex = 3;
            this.GPUBox.TabStop = false;
            this.GPUBox.Text = "GPU";
            // 
            // GPULabel
            // 
            this.GPULabel.AutoSize = true;
            this.GPULabel.Location = new System.Drawing.Point(6, 20);
            this.GPULabel.Name = "GPULabel";
            this.GPULabel.Size = new System.Drawing.Size(35, 13);
            this.GPULabel.TabIndex = 0;
            this.GPULabel.Text = "label2";
            // 
            // OSBox
            // 
            this.OSBox.AutoSize = true;
            this.OSBox.Controls.Add(this.OSLabel);
            this.OSBox.Location = new System.Drawing.Point(415, 58);
            this.OSBox.MinimumSize = new System.Drawing.Size(200, 40);
            this.OSBox.Name = "OSBox";
            this.OSBox.Size = new System.Drawing.Size(200, 49);
            this.OSBox.TabIndex = 3;
            this.OSBox.TabStop = false;
            this.OSBox.Text = "Operating System";
            // 
            // OSLabel
            // 
            this.OSLabel.AutoSize = true;
            this.OSLabel.Location = new System.Drawing.Point(6, 20);
            this.OSLabel.Name = "OSLabel";
            this.OSLabel.Size = new System.Drawing.Size(35, 13);
            this.OSLabel.TabIndex = 0;
            this.OSLabel.Text = "label2";
            // 
            // costUserLabel
            // 
            this.costUserLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.costUserLabel.Location = new System.Drawing.Point(6, 12);
            this.costUserLabel.Name = "costUserLabel";
            this.costUserLabel.Size = new System.Drawing.Size(100, 22);
            this.costUserLabel.TabIndex = 2;
            this.costUserLabel.Text = "label1";
            this.costUserLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // costLabel
            // 
            this.costLabel.AutoSize = true;
            this.costLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.costLabel.Location = new System.Drawing.Point(112, 13);
            this.costLabel.Name = "costLabel";
            this.costLabel.Size = new System.Drawing.Size(51, 20);
            this.costLabel.TabIndex = 3;
            this.costLabel.Text = "label1";
            // 
            // HSTUserLabel
            // 
            this.HSTUserLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HSTUserLabel.Location = new System.Drawing.Point(6, 34);
            this.HSTUserLabel.Name = "HSTUserLabel";
            this.HSTUserLabel.Size = new System.Drawing.Size(100, 22);
            this.HSTUserLabel.TabIndex = 4;
            this.HSTUserLabel.Text = "label1";
            this.HSTUserLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // totalUserLabel
            // 
            this.totalUserLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalUserLabel.Location = new System.Drawing.Point(6, 56);
            this.totalUserLabel.Name = "totalUserLabel";
            this.totalUserLabel.Size = new System.Drawing.Size(100, 22);
            this.totalUserLabel.TabIndex = 5;
            this.totalUserLabel.Text = "label1";
            this.totalUserLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // HSTLabel
            // 
            this.HSTLabel.AutoSize = true;
            this.HSTLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HSTLabel.Location = new System.Drawing.Point(112, 35);
            this.HSTLabel.Name = "HSTLabel";
            this.HSTLabel.Size = new System.Drawing.Size(51, 20);
            this.HSTLabel.TabIndex = 6;
            this.HSTLabel.Text = "label1";
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalLabel.Location = new System.Drawing.Point(112, 57);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(51, 20);
            this.totalLabel.TabIndex = 7;
            this.totalLabel.Text = "label1";
            // 
            // costBox
            // 
            this.costBox.Controls.Add(this.totalUserLabel);
            this.costBox.Controls.Add(this.totalLabel);
            this.costBox.Controls.Add(this.costUserLabel);
            this.costBox.Controls.Add(this.HSTLabel);
            this.costBox.Controls.Add(this.costLabel);
            this.costBox.Controls.Add(this.HSTUserLabel);
            this.costBox.Location = new System.Drawing.Point(258, 448);
            this.costBox.Name = "costBox";
            this.costBox.Size = new System.Drawing.Size(200, 91);
            this.costBox.TabIndex = 8;
            this.costBox.TabStop = false;
            this.costBox.Text = "Cost";
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(693, 459);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 9;
            this.cancelButton.Text = "button1";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // nextButton
            // 
            this.nextButton.Location = new System.Drawing.Point(693, 502);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(75, 23);
            this.nextButton.TabIndex = 10;
            this.nextButton.Text = "button2";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenu,
            this.editToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1213, 24);
            this.menuStrip.TabIndex = 11;
            this.menuStrip.Text = "menuStrip1";
            // 
            // fileMenu
            // 
            this.fileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileMenu.Name = "fileMenu";
            this.fileMenu.Size = new System.Drawing.Size(37, 20);
            this.fileMenu.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.openToolStripMenuItem.Text = "Open";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // backToolStripMenuItem
            // 
            this.backToolStripMenuItem.Name = "backToolStripMenuItem";
            this.backToolStripMenuItem.Size = new System.Drawing.Size(99, 22);
            this.backToolStripMenuItem.Text = "Back";
            // 
            // backgroundFillerWorker
            // 
            this.backgroundFillerWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.fill_table);
            // 
            // selectionForm
            // 
            this.AcceptButton = this.nextButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(1213, 551);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.costBox);
            this.Controls.Add(this.infoBox);
            this.Controls.Add(this.computerGrid);
            this.Controls.Add(this.menuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.Name = "selectionForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.form_closing);
            this.Load += new System.EventHandler(this.form_load);
            this.SizeChanged += new System.EventHandler(this.form_sizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.computerGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dollarcomputersDataSet)).EndInit();
            this.infoBox.ResumeLayout(false);
            this.infoFlowLayoutPanel.ResumeLayout(false);
            this.infoFlowLayoutPanel.PerformLayout();
            this.manufacturerBox.ResumeLayout(false);
            this.manufacturerBox.PerformLayout();
            this.ModelBox.ResumeLayout(false);
            this.ModelBox.PerformLayout();
            this.cpuBox.ResumeLayout(false);
            this.cpuBox.PerformLayout();
            this.HDDBox.ResumeLayout(false);
            this.HDDBox.PerformLayout();
            this.GPUBox.ResumeLayout(false);
            this.GPUBox.PerformLayout();
            this.OSBox.ResumeLayout(false);
            this.OSBox.PerformLayout();
            this.costBox.ResumeLayout(false);
            this.costBox.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView computerGrid;
        private dollarcomputersDataSet dollarcomputersDataSet;
        private System.Windows.Forms.BindingSource productsBindingSource;
        private dollarcomputersDataSetTableAdapters.productsTableAdapter productsTableAdapter;
        private System.Windows.Forms.GroupBox infoBox;
        private System.Windows.Forms.FlowLayoutPanel infoFlowLayoutPanel;
        private System.Windows.Forms.GroupBox manufacturerBox;
        private System.Windows.Forms.Label manufaturerLabel;
        private System.Windows.Forms.GroupBox cpuBox;
        private System.Windows.Forms.Label cpuLabel;
        private System.Windows.Forms.GroupBox HDDBox;
        private System.Windows.Forms.Label HDDLabel;
        private System.Windows.Forms.GroupBox ModelBox;
        private System.Windows.Forms.Label modelLabel;
        private System.Windows.Forms.GroupBox GPUBox;
        private System.Windows.Forms.Label GPULabel;
        private System.Windows.Forms.GroupBox OSBox;
        private System.Windows.Forms.Label OSLabel;
        private System.Windows.Forms.Label costUserLabel;
        private System.Windows.Forms.Label costLabel;
        private System.Windows.Forms.Label HSTUserLabel;
        private System.Windows.Forms.Label totalUserLabel;
        private System.Windows.Forms.Label HSTLabel;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.GroupBox costBox;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileMenu;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn manufacturerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn costDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn GPU_Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn HDD_size;
        private System.Windows.Forms.DataGridViewTextBoxColumn CPU_brand;
        private System.Windows.Forms.DataGridViewTextBoxColumn CPU_number;
        private System.Windows.Forms.DataGridViewTextBoxColumn screensizeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn conditionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn weight;
        private System.Windows.Forms.DataGridViewTextBoxColumn HDD_speed;
        private System.Windows.Forms.DataGridViewTextBoxColumn RAM_size;
        private System.Windows.Forms.DataGridViewTextBoxColumn RAM_type;
        private System.Windows.Forms.DataGridViewTextBoxColumn resolution;
        private System.ComponentModel.BackgroundWorker backgroundFillerWorker;





    }
}