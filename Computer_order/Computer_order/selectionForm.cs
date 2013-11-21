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
        private static int COSTCOL = 0;
        private static int MANUFACTURERCOL = 5;

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
            this.Location       = startForm.Location;
            this.MinimumSize    = XmlLoader.getMinimumFormSize();

            // set specific object properties
            computerGrid.MaximumSize    = XmlLoader.getItemMaxSize(computerGrid.Name);

            // Set box label colors
            infoBox.Text                = XmlLoader.getText(infoBox.Name);
            infoBox.ForeColor           = XmlLoader.getFontColor();
            cpuBox.ForeColor            = XmlLoader.getFontColor();
            manufacturerBox.ForeColor   = XmlLoader.getFontColor();
            HDDBox.ForeColor            = XmlLoader.getFontColor();

            // set label colors
            cpuLabel.ForeColor          = XmlLoader.getFontColor();
            HDDLabel.ForeColor          = XmlLoader.getFontColor();
            manufaturerLabel.ForeColor  = XmlLoader.getFontColor();
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
                (computerGrid.Size.Height + 40)
                );
            infoFlowLayoutPanel.Location = new Point(
                ((infoBox.Size.Width / 2) - (infoFlowLayoutPanel.Size.Width / 2)),
                ((infoBox.Size.Height / 2) - (infoFlowLayoutPanel.Size.Height / 2))
                );
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
            DataGridViewSelectedCellCollection selectedCells = computerGrid.SelectedCells;
            foreach (DataGridViewCell cell in selectedCells)
            {
                if (cell.ColumnIndex == MANUFACTURERCOL)
                {
                    manufaturerLabel.Text = cell.Value.ToString();
                }
            }
        }
    }
}
