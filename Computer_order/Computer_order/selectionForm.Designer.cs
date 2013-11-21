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
            this.costDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GPU_Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HDD_size = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CPU_brand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CPU_number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.manufacturerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.screensizeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.conditionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dollarcomputersDataSet = new Computer_order.dollarcomputersDataSet();
            this.productsTableAdapter = new Computer_order.dollarcomputersDataSetTableAdapters.productsTableAdapter();
            this.infoBox = new System.Windows.Forms.GroupBox();
            this.infoFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.manufacturerBox = new System.Windows.Forms.GroupBox();
            this.manufaturerLabel = new System.Windows.Forms.Label();
            this.cpuBox = new System.Windows.Forms.GroupBox();
            this.cpuLabel = new System.Windows.Forms.Label();
            this.HDDBox = new System.Windows.Forms.GroupBox();
            this.HDDLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.computerGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dollarcomputersDataSet)).BeginInit();
            this.infoBox.SuspendLayout();
            this.infoFlowLayoutPanel.SuspendLayout();
            this.manufacturerBox.SuspendLayout();
            this.cpuBox.SuspendLayout();
            this.HDDBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // computerGrid
            // 
            this.computerGrid.AllowUserToAddRows = false;
            this.computerGrid.AllowUserToDeleteRows = false;
            this.computerGrid.AllowUserToResizeColumns = false;
            this.computerGrid.AllowUserToResizeRows = false;
            this.computerGrid.AutoGenerateColumns = false;
            this.computerGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.computerGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.computerGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.costDataGridViewTextBoxColumn,
            this.GPU_Type,
            this.HDD_size,
            this.CPU_brand,
            this.CPU_number,
            this.manufacturerDataGridViewTextBoxColumn,
            this.modelDataGridViewTextBoxColumn,
            this.screensizeDataGridViewTextBoxColumn,
            this.conditionDataGridViewTextBoxColumn,
            this.oSDataGridViewTextBoxColumn});
            this.computerGrid.DataSource = this.productsBindingSource;
            this.computerGrid.Location = new System.Drawing.Point(12, 12);
            this.computerGrid.MultiSelect = false;
            this.computerGrid.Name = "computerGrid";
            this.computerGrid.ReadOnly = true;
            this.computerGrid.RowTemplate.ReadOnly = true;
            this.computerGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.computerGrid.Size = new System.Drawing.Size(652, 267);
            this.computerGrid.TabIndex = 0;
            this.computerGrid.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.row_focus);
            // 
            // costDataGridViewTextBoxColumn
            // 
            this.costDataGridViewTextBoxColumn.DataPropertyName = "cost";
            this.costDataGridViewTextBoxColumn.HeaderText = "cost";
            this.costDataGridViewTextBoxColumn.Name = "costDataGridViewTextBoxColumn";
            this.costDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // GPU_Type
            // 
            this.GPU_Type.DataPropertyName = "GPU_Type";
            this.GPU_Type.HeaderText = "GPU_Type";
            this.GPU_Type.Name = "GPU_Type";
            this.GPU_Type.ReadOnly = true;
            // 
            // HDD_size
            // 
            this.HDD_size.DataPropertyName = "HDD_size";
            this.HDD_size.HeaderText = "HDD_size";
            this.HDD_size.Name = "HDD_size";
            this.HDD_size.ReadOnly = true;
            // 
            // CPU_brand
            // 
            this.CPU_brand.DataPropertyName = "CPU_brand";
            this.CPU_brand.HeaderText = "CPU_brand";
            this.CPU_brand.Name = "CPU_brand";
            this.CPU_brand.ReadOnly = true;
            // 
            // CPU_number
            // 
            this.CPU_number.DataPropertyName = "CPU_number";
            this.CPU_number.HeaderText = "CPU_number";
            this.CPU_number.Name = "CPU_number";
            this.CPU_number.ReadOnly = true;
            // 
            // manufacturerDataGridViewTextBoxColumn
            // 
            this.manufacturerDataGridViewTextBoxColumn.DataPropertyName = "manufacturer";
            this.manufacturerDataGridViewTextBoxColumn.HeaderText = "manufacturer";
            this.manufacturerDataGridViewTextBoxColumn.Name = "manufacturerDataGridViewTextBoxColumn";
            this.manufacturerDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // modelDataGridViewTextBoxColumn
            // 
            this.modelDataGridViewTextBoxColumn.DataPropertyName = "model";
            this.modelDataGridViewTextBoxColumn.HeaderText = "model";
            this.modelDataGridViewTextBoxColumn.Name = "modelDataGridViewTextBoxColumn";
            this.modelDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // screensizeDataGridViewTextBoxColumn
            // 
            this.screensizeDataGridViewTextBoxColumn.DataPropertyName = "screensize";
            this.screensizeDataGridViewTextBoxColumn.HeaderText = "screensize";
            this.screensizeDataGridViewTextBoxColumn.Name = "screensizeDataGridViewTextBoxColumn";
            this.screensizeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // conditionDataGridViewTextBoxColumn
            // 
            this.conditionDataGridViewTextBoxColumn.DataPropertyName = "condition";
            this.conditionDataGridViewTextBoxColumn.HeaderText = "condition";
            this.conditionDataGridViewTextBoxColumn.Name = "conditionDataGridViewTextBoxColumn";
            this.conditionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // oSDataGridViewTextBoxColumn
            // 
            this.oSDataGridViewTextBoxColumn.DataPropertyName = "OS";
            this.oSDataGridViewTextBoxColumn.HeaderText = "OS";
            this.oSDataGridViewTextBoxColumn.Name = "oSDataGridViewTextBoxColumn";
            this.oSDataGridViewTextBoxColumn.ReadOnly = true;
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
            this.infoFlowLayoutPanel.Controls.Add(this.cpuBox);
            this.infoFlowLayoutPanel.Controls.Add(this.HDDBox);
            this.infoFlowLayoutPanel.Location = new System.Drawing.Point(6, 20);
            this.infoFlowLayoutPanel.Name = "infoFlowLayoutPanel";
            this.infoFlowLayoutPanel.Size = new System.Drawing.Size(675, 117);
            this.infoFlowLayoutPanel.TabIndex = 0;
            // 
            // manufacturerBox
            // 
            this.manufacturerBox.Controls.Add(this.manufaturerLabel);
            this.manufacturerBox.Location = new System.Drawing.Point(3, 3);
            this.manufacturerBox.Name = "manufacturerBox";
            this.manufacturerBox.Size = new System.Drawing.Size(200, 42);
            this.manufacturerBox.TabIndex = 0;
            this.manufacturerBox.TabStop = false;
            this.manufacturerBox.Text = "Manufacturer";
            // 
            // manufaturerLabel
            // 
            this.manufaturerLabel.AutoSize = true;
            this.manufaturerLabel.Location = new System.Drawing.Point(42, 20);
            this.manufaturerLabel.Name = "manufaturerLabel";
            this.manufaturerLabel.Size = new System.Drawing.Size(35, 13);
            this.manufaturerLabel.TabIndex = 0;
            this.manufaturerLabel.Text = "label1";
            // 
            // cpuBox
            // 
            this.cpuBox.Controls.Add(this.cpuLabel);
            this.cpuBox.Location = new System.Drawing.Point(209, 3);
            this.cpuBox.Name = "cpuBox";
            this.cpuBox.Size = new System.Drawing.Size(200, 42);
            this.cpuBox.TabIndex = 1;
            this.cpuBox.TabStop = false;
            this.cpuBox.Text = "CPU Info";
            // 
            // cpuLabel
            // 
            this.cpuLabel.AutoSize = true;
            this.cpuLabel.Location = new System.Drawing.Point(42, 20);
            this.cpuLabel.Name = "cpuLabel";
            this.cpuLabel.Size = new System.Drawing.Size(35, 13);
            this.cpuLabel.TabIndex = 0;
            this.cpuLabel.Text = "label2";
            // 
            // HDDBox
            // 
            this.HDDBox.Controls.Add(this.HDDLabel);
            this.HDDBox.Location = new System.Drawing.Point(415, 3);
            this.HDDBox.Name = "HDDBox";
            this.HDDBox.Size = new System.Drawing.Size(200, 42);
            this.HDDBox.TabIndex = 2;
            this.HDDBox.TabStop = false;
            this.HDDBox.Text = "Hardrive";
            // 
            // HDDLabel
            // 
            this.HDDLabel.AutoSize = true;
            this.HDDLabel.Location = new System.Drawing.Point(42, 20);
            this.HDDLabel.Name = "HDDLabel";
            this.HDDLabel.Size = new System.Drawing.Size(35, 13);
            this.HDDLabel.TabIndex = 0;
            this.HDDLabel.Text = "label2";
            // 
            // selectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 492);
            this.Controls.Add(this.infoBox);
            this.Controls.Add(this.computerGrid);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "selectionForm";
            this.Text = "selectionForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.form_closing);
            this.Load += new System.EventHandler(this.form_load);
            this.SizeChanged += new System.EventHandler(this.form_sizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.computerGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dollarcomputersDataSet)).EndInit();
            this.infoBox.ResumeLayout(false);
            this.infoFlowLayoutPanel.ResumeLayout(false);
            this.manufacturerBox.ResumeLayout(false);
            this.manufacturerBox.PerformLayout();
            this.cpuBox.ResumeLayout(false);
            this.cpuBox.PerformLayout();
            this.HDDBox.ResumeLayout(false);
            this.HDDBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView computerGrid;
        private dollarcomputersDataSet dollarcomputersDataSet;
        private System.Windows.Forms.BindingSource productsBindingSource;
        private dollarcomputersDataSetTableAdapters.productsTableAdapter productsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn costDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn GPU_Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn HDD_size;
        private System.Windows.Forms.DataGridViewTextBoxColumn CPU_brand;
        private System.Windows.Forms.DataGridViewTextBoxColumn CPU_number;
        private System.Windows.Forms.DataGridViewTextBoxColumn manufacturerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn screensizeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn conditionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn oSDataGridViewTextBoxColumn;
        private System.Windows.Forms.GroupBox infoBox;
        private System.Windows.Forms.FlowLayoutPanel infoFlowLayoutPanel;
        private System.Windows.Forms.GroupBox manufacturerBox;
        private System.Windows.Forms.Label manufaturerLabel;
        private System.Windows.Forms.GroupBox cpuBox;
        private System.Windows.Forms.Label cpuLabel;
        private System.Windows.Forms.GroupBox HDDBox;
        private System.Windows.Forms.Label HDDLabel;





    }
}