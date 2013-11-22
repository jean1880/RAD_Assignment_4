using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Computer_order
{
    /// <summary>
    /// Selection form is where the user selects which computer they wish to purchase
    /// </summary>
    public partial class selectionForm : Form
    {
        private xmlLoader XmlLoader;
        private startForm startForm;
        private Decimal cost;
        private static decimal HST = 0.13m;
        private static int COSTCOL = 2;
        private static int GPUCOL = 3;
        private static int HDDCOL = 4;
        private static int CPUMANUCOL = 5;
        private static int CPUIDCOL = 6;
        private static int MANUFACTURERCOL = 0;
        private static int MODELCOL = 1;
        private static int OSCOL = 9;

        /// <summary>
        /// This form allows the user to select the computer they wish to purchase
        /// </summary>
        public selectionForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Passes the start form to this form
        /// </summary>
        /// <param name="startForm"></param>
        public void setStartForm(startForm startForm)
        {
            this.startForm = startForm;
            this.productsTableAdapter.Fill(this.dollarcomputersDataSet.products);
        }

        /// <summary>
        /// On form load initialize form and fill datagrid
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void form_load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dollarcomputersDataSet.products' table. You can move, or remove it, as needed.
            initialiseForm();
        }

        /// <summary>
        /// Loads form data from the xml file
        /// </summary>
        private void initialiseForm()
        {
            this.XmlLoader = new xmlLoader(this);

            // Set form properties
            this.Text           = XmlLoader.getFormTitle();
            this.BackColor      = XmlLoader.getFormColor();
            this.Size           = startForm.Size;
            this.WindowState    = startForm.WindowState;
            this.Location       = startForm.Location;
            this.MinimumSize    = XmlLoader.getMinimumFormSize();

            // set specific object properties
            infoBox.Text = XmlLoader.getText(infoBox.Name);
            costUserLabel.Text = XmlLoader.getText(costUserLabel.Name);
            HSTUserLabel.Text = XmlLoader.getText(HSTUserLabel.Name);
            totalUserLabel.Text = XmlLoader.getText(totalUserLabel.Name);

            setBoxLabelColor();
            setLabelColor();

            updateLocations();
            updateSizes();
        }

        /// <summary>
        /// Sets info box group box colors
        /// </summary>
        private void setBoxLabelColor()
        {
            // Set box label colors
            infoBox.ForeColor = XmlLoader.getFontColor();
            ModelBox.ForeColor = XmlLoader.getFontColor();
            GPUBox.ForeColor = XmlLoader.getFontColor();
            cpuBox.ForeColor = XmlLoader.getFontColor();
            manufacturerBox.ForeColor = XmlLoader.getFontColor();
            HDDBox.ForeColor = XmlLoader.getFontColor();
            OSBox.ForeColor = XmlLoader.getFontColor();
            costBox.ForeColor = XmlLoader.getFontColor();
        }

        /// <summary>
        /// Sets label colors
        /// </summary>
        private void setLabelColor()
        {
            // set label colors
            cpuLabel.ForeColor = XmlLoader.getFontColor();
            HDDLabel.ForeColor = XmlLoader.getFontColor();
            manufaturerLabel.ForeColor = XmlLoader.getFontColor();
            OSLabel.ForeColor = XmlLoader.getFontColor();
            GPULabel.ForeColor = XmlLoader.getFontColor();
            modelLabel.ForeColor = XmlLoader.getFontColor();
            costLabel.ForeColor = XmlLoader.getFontColor();
            costUserLabel.ForeColor =  XmlLoader.getFontColor();
            HSTLabel.ForeColor = XmlLoader.getFontColor();
            HSTUserLabel.ForeColor = XmlLoader.getFontColor();
            totalLabel.ForeColor =  XmlLoader.getFontColor();
            totalUserLabel.ForeColor = XmlLoader.getFontColor();
        }

        /// <summary>
        /// On form size change update child object sizes and locations
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void form_sizeChanged(object sender, EventArgs e)
        {
            updateSizes();
            updateLocations();
        }

        /// <summary>
        /// Updates the sizes of objects on the form
        /// </summary>
        private void updateSizes()
        {
            Size centeredSize = new System.Drawing.Size(
                (this.Size.Width / 10)*9,
                (this.Size.Height / 3)
                );
            computerGrid.Size   = centeredSize;
            infoBox.Size        = centeredSize;
            infoFlowLayoutPanel.Size = Size.Subtract(infoBox.Size,new Size(20,30));
        }

        /// <summary>
        /// Updates the locations of objects on the form
        /// </summary>
        private void updateLocations()
        {
            computerGrid.Location = new Point(
                ((this.Size.Width / 2) - (computerGrid.Size.Width / 2)),
                (20)
                );
            infoBox.Location = new Point(
                ((this.Size.Width / 2) - (infoBox.Size.Width / 2)),
                (computerGrid.Location.Y + computerGrid.Size.Height + 20)
                );
            infoFlowLayoutPanel.Location = new Point(
                ((infoBox.Size.Width / 2) - (infoFlowLayoutPanel.Size.Width / 2)),
                ((infoBox.Size.Height / 2) - (infoFlowLayoutPanel.Size.Height / 2))
                );
            costBox.Location = new Point(
                (infoBox.Location.X),
                (infoBox.Location.Y + infoBox.Size.Height + 20)
                );
        }

        private void updateCost(String cost)
        {
            decimal hstCost, totalCost;

            if (Decimal.TryParse(cost, out this.cost))
            {
                hstCost = this.cost * HST;
                totalCost = hstCost + this.cost;

                costLabel.Text = this.cost.ToString("C");
                HSTLabel.Text = hstCost.ToString("C");
                totalLabel.Text = totalCost.ToString("C");
            }    
        }

        /// <summary>
        /// As form is closed exit the application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void form_closing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void row_focus(object sender, DataGridViewCellEventArgs e)
        {
            String cpuInfo = "";
            DataGridViewSelectedCellCollection selectedCells = computerGrid.SelectedCells;

            foreach (DataGridViewCell cell in selectedCells)
            {
                if (cell.ColumnIndex == GPUCOL)
                {
                    GPULabel.Text = cell.Value.ToString();
                }
                else if (cell.ColumnIndex == HDDCOL)
                {
                    HDDLabel.Text = cell.Value.ToString();
                }
                else if (cell.ColumnIndex == CPUMANUCOL)
                {
                    cpuInfo = cell.Value.ToString();
                }
                else if (cell.ColumnIndex == CPUIDCOL)
                {
                    cpuLabel.Text =  cpuInfo + " " + cell.Value.ToString();
                }
                else if (cell.ColumnIndex == MANUFACTURERCOL)
                {
                    manufaturerLabel.Text = cell.Value.ToString();
                }
                else if (cell.ColumnIndex == MODELCOL)
                {
                    modelLabel.Text = cell.Value.ToString();
                }
                else if (cell.ColumnIndex == COSTCOL)
                {
                    updateCost(cell.Value.ToString());
                }
                else if (cell.ColumnIndex == OSCOL)
                {
                    OSLabel.Text = cell.Value.ToString();
                }
            }
        }
    }
}
