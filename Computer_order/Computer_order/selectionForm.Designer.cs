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
            ((System.ComponentModel.ISupportInitialize)(this.computerGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dollarcomputersDataSet)).BeginInit();
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
            this.computerGrid.Name = "computerGrid";
            this.computerGrid.ReadOnly = true;
            this.computerGrid.RowTemplate.ReadOnly = true;
            this.computerGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.computerGrid.Size = new System.Drawing.Size(652, 267);
            this.computerGrid.TabIndex = 0;
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
            this.infoBox.Location = new System.Drawing.Point(81, 299);
            this.infoBox.Name = "infoBox";
            this.infoBox.Size = new System.Drawing.Size(200, 100);
            this.infoBox.TabIndex = 1;
            this.infoBox.TabStop = false;
            this.infoBox.Text = "groupBox1";
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





    }
}