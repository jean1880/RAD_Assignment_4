namespace Computer_order
{
    partial class productInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(productInfo));
            this.nextButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
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
            this.ramBox = new System.Windows.Forms.GroupBox();
            this.ramLabel = new System.Windows.Forms.Label();
            this.OSBox = new System.Windows.Forms.GroupBox();
            this.OSLabel = new System.Windows.Forms.Label();
            this.conditionBox = new System.Windows.Forms.GroupBox();
            this.conditionLabel = new System.Windows.Forms.Label();
            this.screenBox = new System.Windows.Forms.GroupBox();
            this.screenSizeLabel = new System.Windows.Forms.Label();
            this.weightBox = new System.Windows.Forms.GroupBox();
            this.weightLabel = new System.Windows.Forms.Label();
            this.resBox = new System.Windows.Forms.GroupBox();
            this.resLabel = new System.Windows.Forms.Label();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.costBox = new System.Windows.Forms.GroupBox();
            this.totalUserLabel = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.costUserLabel = new System.Windows.Forms.Label();
            this.HSTLabel = new System.Windows.Forms.Label();
            this.costLabel = new System.Windows.Forms.Label();
            this.HSTUserLabel = new System.Windows.Forms.Label();
            this.productsTableAdapter1 = new Computer_order.Resources.dollarcomputersDataSetTableAdapters.productsTableAdapter();
            this.dollarcomputersDataSet1 = new Computer_order.dollarcomputersDataSet();
            this.infoBox.SuspendLayout();
            this.infoFlowLayoutPanel.SuspendLayout();
            this.manufacturerBox.SuspendLayout();
            this.ModelBox.SuspendLayout();
            this.cpuBox.SuspendLayout();
            this.HDDBox.SuspendLayout();
            this.GPUBox.SuspendLayout();
            this.ramBox.SuspendLayout();
            this.OSBox.SuspendLayout();
            this.conditionBox.SuspendLayout();
            this.screenBox.SuspendLayout();
            this.weightBox.SuspendLayout();
            this.resBox.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.costBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dollarcomputersDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // nextButton
            // 
            this.nextButton.Location = new System.Drawing.Point(512, 404);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(75, 23);
            this.nextButton.TabIndex = 12;
            this.nextButton.Text = "button2";
            this.nextButton.UseVisualStyleBackColor = true;
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(512, 359);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 11;
            this.cancelButton.Text = "button1";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // infoBox
            // 
            this.infoBox.Controls.Add(this.infoFlowLayoutPanel);
            this.infoBox.Location = new System.Drawing.Point(12, 70);
            this.infoBox.Name = "infoBox";
            this.infoBox.Size = new System.Drawing.Size(833, 283);
            this.infoBox.TabIndex = 14;
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
            this.infoFlowLayoutPanel.Controls.Add(this.ramBox);
            this.infoFlowLayoutPanel.Controls.Add(this.OSBox);
            this.infoFlowLayoutPanel.Controls.Add(this.conditionBox);
            this.infoFlowLayoutPanel.Controls.Add(this.screenBox);
            this.infoFlowLayoutPanel.Controls.Add(this.weightBox);
            this.infoFlowLayoutPanel.Controls.Add(this.resBox);
            this.infoFlowLayoutPanel.Location = new System.Drawing.Point(6, 20);
            this.infoFlowLayoutPanel.Name = "infoFlowLayoutPanel";
            this.infoFlowLayoutPanel.Size = new System.Drawing.Size(821, 257);
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
            // ramBox
            // 
            this.ramBox.AutoSize = true;
            this.ramBox.Controls.Add(this.ramLabel);
            this.ramBox.Location = new System.Drawing.Point(415, 58);
            this.ramBox.MinimumSize = new System.Drawing.Size(200, 40);
            this.ramBox.Name = "ramBox";
            this.ramBox.Size = new System.Drawing.Size(200, 49);
            this.ramBox.TabIndex = 8;
            this.ramBox.TabStop = false;
            this.ramBox.Text = "RAM";
            // 
            // ramLabel
            // 
            this.ramLabel.AutoSize = true;
            this.ramLabel.Location = new System.Drawing.Point(6, 20);
            this.ramLabel.Name = "ramLabel";
            this.ramLabel.Size = new System.Drawing.Size(35, 13);
            this.ramLabel.TabIndex = 0;
            this.ramLabel.Text = "label2";
            // 
            // OSBox
            // 
            this.OSBox.AutoSize = true;
            this.OSBox.Controls.Add(this.OSLabel);
            this.OSBox.Location = new System.Drawing.Point(3, 113);
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
            // conditionBox
            // 
            this.conditionBox.AutoSize = true;
            this.conditionBox.Controls.Add(this.conditionLabel);
            this.conditionBox.Location = new System.Drawing.Point(209, 113);
            this.conditionBox.MinimumSize = new System.Drawing.Size(200, 40);
            this.conditionBox.Name = "conditionBox";
            this.conditionBox.Size = new System.Drawing.Size(200, 49);
            this.conditionBox.TabIndex = 5;
            this.conditionBox.TabStop = false;
            this.conditionBox.Text = "Condition";
            // 
            // conditionLabel
            // 
            this.conditionLabel.AutoSize = true;
            this.conditionLabel.Location = new System.Drawing.Point(6, 20);
            this.conditionLabel.Name = "conditionLabel";
            this.conditionLabel.Size = new System.Drawing.Size(35, 13);
            this.conditionLabel.TabIndex = 0;
            this.conditionLabel.Text = "label2";
            // 
            // screenBox
            // 
            this.screenBox.AutoSize = true;
            this.screenBox.Controls.Add(this.screenSizeLabel);
            this.screenBox.Location = new System.Drawing.Point(415, 113);
            this.screenBox.MinimumSize = new System.Drawing.Size(200, 40);
            this.screenBox.Name = "screenBox";
            this.screenBox.Size = new System.Drawing.Size(200, 49);
            this.screenBox.TabIndex = 6;
            this.screenBox.TabStop = false;
            this.screenBox.Text = "Screen Size";
            // 
            // screenSizeLabel
            // 
            this.screenSizeLabel.AutoSize = true;
            this.screenSizeLabel.Location = new System.Drawing.Point(6, 20);
            this.screenSizeLabel.Name = "screenSizeLabel";
            this.screenSizeLabel.Size = new System.Drawing.Size(35, 13);
            this.screenSizeLabel.TabIndex = 0;
            this.screenSizeLabel.Text = "label2";
            // 
            // weightBox
            // 
            this.weightBox.AutoSize = true;
            this.weightBox.Controls.Add(this.weightLabel);
            this.weightBox.Location = new System.Drawing.Point(3, 168);
            this.weightBox.MinimumSize = new System.Drawing.Size(200, 40);
            this.weightBox.Name = "weightBox";
            this.weightBox.Size = new System.Drawing.Size(200, 49);
            this.weightBox.TabIndex = 7;
            this.weightBox.TabStop = false;
            this.weightBox.Text = "Weight";
            // 
            // weightLabel
            // 
            this.weightLabel.AutoSize = true;
            this.weightLabel.Location = new System.Drawing.Point(6, 20);
            this.weightLabel.Name = "weightLabel";
            this.weightLabel.Size = new System.Drawing.Size(35, 13);
            this.weightLabel.TabIndex = 0;
            this.weightLabel.Text = "label2";
            // 
            // resBox
            // 
            this.resBox.AutoSize = true;
            this.resBox.Controls.Add(this.resLabel);
            this.resBox.Location = new System.Drawing.Point(209, 168);
            this.resBox.MinimumSize = new System.Drawing.Size(200, 40);
            this.resBox.Name = "resBox";
            this.resBox.Size = new System.Drawing.Size(200, 49);
            this.resBox.TabIndex = 9;
            this.resBox.TabStop = false;
            this.resBox.Text = "Resolution";
            // 
            // resLabel
            // 
            this.resLabel.AutoSize = true;
            this.resLabel.Location = new System.Drawing.Point(6, 20);
            this.resLabel.Name = "resLabel";
            this.resLabel.Size = new System.Drawing.Size(35, 13);
            this.resLabel.TabIndex = 0;
            this.resLabel.Text = "label2";
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenu,
            this.editToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(857, 24);
            this.menuStrip.TabIndex = 15;
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
            // costBox
            // 
            this.costBox.Controls.Add(this.totalUserLabel);
            this.costBox.Controls.Add(this.totalLabel);
            this.costBox.Controls.Add(this.costUserLabel);
            this.costBox.Controls.Add(this.HSTLabel);
            this.costBox.Controls.Add(this.costLabel);
            this.costBox.Controls.Add(this.HSTUserLabel);
            this.costBox.Location = new System.Drawing.Point(12, 359);
            this.costBox.Name = "costBox";
            this.costBox.Size = new System.Drawing.Size(200, 91);
            this.costBox.TabIndex = 16;
            this.costBox.TabStop = false;
            this.costBox.Text = "Cost";
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
            // productsTableAdapter1
            // 
            this.productsTableAdapter1.ClearBeforeFill = true;
            // 
            // dollarcomputersDataSet1
            // 
            this.dollarcomputersDataSet1.DataSetName = "dollarcomputersDataSet";
            this.dollarcomputersDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 565);
            this.Controls.Add(this.costBox);
            this.Controls.Add(this.menuStrip);
            this.Controls.Add(this.infoBox);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.cancelButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "productInfo";
            this.Text = "productInfo";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.form_closing);
            this.Load += new System.EventHandler(this.form_load);
            this.Resize += new System.EventHandler(this.form_sizeChanged);
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
            this.ramBox.ResumeLayout(false);
            this.ramBox.PerformLayout();
            this.OSBox.ResumeLayout(false);
            this.OSBox.PerformLayout();
            this.conditionBox.ResumeLayout(false);
            this.conditionBox.PerformLayout();
            this.screenBox.ResumeLayout(false);
            this.screenBox.PerformLayout();
            this.weightBox.ResumeLayout(false);
            this.weightBox.PerformLayout();
            this.resBox.ResumeLayout(false);
            this.resBox.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.costBox.ResumeLayout(false);
            this.costBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dollarcomputersDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.GroupBox infoBox;
        private System.Windows.Forms.FlowLayoutPanel infoFlowLayoutPanel;
        private System.Windows.Forms.GroupBox manufacturerBox;
        private System.Windows.Forms.Label manufaturerLabel;
        private System.Windows.Forms.GroupBox ModelBox;
        private System.Windows.Forms.Label modelLabel;
        private System.Windows.Forms.GroupBox cpuBox;
        private System.Windows.Forms.Label cpuLabel;
        private System.Windows.Forms.GroupBox HDDBox;
        private System.Windows.Forms.Label HDDLabel;
        private System.Windows.Forms.GroupBox GPUBox;
        private System.Windows.Forms.Label GPULabel;
        private System.Windows.Forms.GroupBox OSBox;
        private System.Windows.Forms.Label OSLabel;
        private System.Windows.Forms.GroupBox conditionBox;
        private System.Windows.Forms.Label conditionLabel;
        private System.Windows.Forms.GroupBox screenBox;
        private System.Windows.Forms.Label screenSizeLabel;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileMenu;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backToolStripMenuItem;
        private System.Windows.Forms.GroupBox costBox;
        private System.Windows.Forms.Label totalUserLabel;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Label costUserLabel;
        private System.Windows.Forms.Label HSTLabel;
        private System.Windows.Forms.Label costLabel;
        private System.Windows.Forms.Label HSTUserLabel;
        private System.Windows.Forms.GroupBox weightBox;
        private System.Windows.Forms.Label weightLabel;
        private System.Windows.Forms.GroupBox ramBox;
        private System.Windows.Forms.Label ramLabel;
        private System.Windows.Forms.GroupBox resBox;
        private System.Windows.Forms.Label resLabel;
        private Resources.dollarcomputersDataSetTableAdapters.productsTableAdapter productsTableAdapter1;
        private dollarcomputersDataSet dollarcomputersDataSet1;
    }
}