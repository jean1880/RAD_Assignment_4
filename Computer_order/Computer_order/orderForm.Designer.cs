namespace Computer_order
{
    partial class orderForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(orderForm));
            this.nextButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.costBox = new System.Windows.Forms.GroupBox();
            this.totalUserLabel = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.costUserLabel = new System.Windows.Forms.Label();
            this.HSTLabel = new System.Windows.Forms.Label();
            this.costLabel = new System.Windows.Forms.Label();
            this.HSTUserLabel = new System.Windows.Forms.Label();
            this.costBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // nextButton
            // 
            this.nextButton.Location = new System.Drawing.Point(764, 385);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(75, 23);
            this.nextButton.TabIndex = 14;
            this.nextButton.Text = "button2";
            this.nextButton.UseVisualStyleBackColor = true;
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(764, 340);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 13;
            this.cancelButton.Text = "button1";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // costBox
            // 
            this.costBox.Controls.Add(this.totalUserLabel);
            this.costBox.Controls.Add(this.totalLabel);
            this.costBox.Controls.Add(this.costUserLabel);
            this.costBox.Controls.Add(this.HSTLabel);
            this.costBox.Controls.Add(this.costLabel);
            this.costBox.Controls.Add(this.HSTUserLabel);
            this.costBox.Location = new System.Drawing.Point(184, 75);
            this.costBox.Name = "costBox";
            this.costBox.Size = new System.Drawing.Size(200, 91);
            this.costBox.TabIndex = 17;
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
            // orderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 494);
            this.Controls.Add(this.costBox);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.cancelButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "orderForm";
            this.Text = "orderForm";
            this.costBox.ResumeLayout(false);
            this.costBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.GroupBox costBox;
        private System.Windows.Forms.Label totalUserLabel;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Label costUserLabel;
        private System.Windows.Forms.Label HSTLabel;
        private System.Windows.Forms.Label costLabel;
        private System.Windows.Forms.Label HSTUserLabel;
    }
}