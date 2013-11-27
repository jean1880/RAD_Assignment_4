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
        private Form prevForm;
        private startForm startForm;
        private productInfo productInfo;
        private Decimal cost;
        private Dictionary<String,String> computerInfo = new Dictionary<String,String>();
        private static decimal HST          = 0.13m;
        private static int COSTCOL          = 2;
        private static int GPUCOL           = 3;
        private static int HDDCOL           = 4;
        private static int CPUMANUCOL       = 5;
        private static int CPUIDCOL         = 6;
        private static int MANUFACTURERCOL  = 0;
        private static int MODELCOL         = 1;
        private static int SCREENCOL        = 7;
        private static int CONDCOL          = 8;
        private static int OSCOL            = 9;
        private static int WEIGHTCOL        = 10;
        private static int HDDSPEEDCOL      = 11;
        private static int RAMSIZECOL       = 12;
        private static int RAMTYPECOL       = 13;
        private static int RESCOL           = 14;

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
        }

        /// <summary>
        /// Set previous form
        /// </summary>
        /// <param name="prevForm"></param>
        public void setPrevForm(Form prevForm)
        {
            this.prevForm = prevForm;
        }

        /// <summary>
        /// Sets the product info form
        /// </summary>
        /// <param name="productInfo"></param>
        public void setProductInfo(productInfo productInfo)
        {
            this.productInfo = productInfo;
        }

        /// <summary>
        /// sets form location
        /// </summary>
        /// <param name="prevLocation"></param>
        public void setFormLocation(Point prevLocation)
        {
            this.Location = prevLocation;
        }

        /// <summary>
        /// On form load initialize form and fill datagrid
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void form_load(object sender, EventArgs e)
        {
            if (computerGrid.RowCount == 0)
            {
                this.productsTableAdapter.Fill(this.dollarcomputersDataSet.products); // Fill table
            }
            initialiseForm(); // initialise form
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
            this.Size           = prevForm.Size;
            this.WindowState    = prevForm.WindowState;
            this.Location       = prevForm.Location;
            this.MinimumSize    = XmlLoader.getMinimumFormSize();

            // set specific object properties
            setText();

            // Set colors
            setBoxLabelColor();
            setLabelColor();

            // set locations and sizes of elements
            updateLocations();
            updateSizes();
        }

        /// <summary>
        /// Sets form text
        /// </summary>
        private void setText()
        {
            infoBox.Text = XmlLoader.getText(infoBox.Name);
            costUserLabel.Text = XmlLoader.getText(costUserLabel.Name);
            HSTUserLabel.Text = XmlLoader.getText(HSTUserLabel.Name);
            totalUserLabel.Text = XmlLoader.getText(totalUserLabel.Name);
            cancelButton.Text = XmlLoader.getText(cancelButton.Name);
            nextButton.Text = XmlLoader.getText(nextButton.Name);
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
                (40)
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
            nextButton.Location = new Point(
                (infoBox.Location.X + infoBox.Size.Width - nextButton.Size.Width),
                (costBox.Location.Y + 10)
                );
            cancelButton.Location = new Point(
                (infoBox.Location.X + infoBox.Size.Width - cancelButton.Size.Width),
                (costBox.Location.Y + (cancelButton.Size.Height * 2) + 10)
                );
        }

        /// <summary>
        /// Update costs
        /// </summary>
        /// <param name="cost"></param>
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

        /// <summary>
        /// on row focus update labels with selected product info
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param> 
        private void row_focus(object sender, DataGridViewCellEventArgs e)
        {
            String cpuInfo = "";
            DataGridViewSelectedCellCollection selectedCells = computerGrid.SelectedCells;

            foreach (DataGridViewCell cell in selectedCells)
            {
                if (cell.ColumnIndex == GPUCOL)
                {

                    addToComputerInfo("GPU", cell.Value.ToString());
                    GPULabel.Text = cell.Value.ToString();
                }
                else if (cell.ColumnIndex == HDDCOL)
                {
                    addToComputerInfo("HDDSize", cell.Value.ToString());
                    HDDLabel.Text = cell.Value.ToString();
                }
                else if (cell.ColumnIndex == CPUMANUCOL)
                {
                    addToComputerInfo("CPUMAN", cell.Value.ToString());
                    cpuInfo = cell.Value.ToString();
                }
                else if (cell.ColumnIndex == CPUIDCOL)
                {
                    addToComputerInfo("CPUID", cell.Value.ToString());
                    cpuLabel.Text =  cpuInfo + " " + cell.Value.ToString();                    
                }
                else if (cell.ColumnIndex == MANUFACTURERCOL)
                {
                    addToComputerInfo("Manufacturer", cell.Value.ToString());
                    manufaturerLabel.Text = cell.Value.ToString();
                }
                else if (cell.ColumnIndex == MODELCOL)
                {
                    addToComputerInfo("Model", cell.Value.ToString());
                    modelLabel.Text = cell.Value.ToString();
                }
                else if (cell.ColumnIndex == COSTCOL)
                {
                    addToComputerInfo("Cost", cell.Value.ToString());
                    updateCost(cell.Value.ToString());
                }
                else if (cell.ColumnIndex == OSCOL)
                {
                    addToComputerInfo("OS", cell.Value.ToString());
                    OSLabel.Text = cell.Value.ToString();
                }
                else if (cell.ColumnIndex == SCREENCOL)
                {
                    addToComputerInfo("Screen", cell.Value.ToString());
                }
                else if (cell.ColumnIndex == CONDCOL)
                {
                    addToComputerInfo("Condition", cell.Value.ToString());
                }
                else if (cell.ColumnIndex == WEIGHTCOL)
                {
                    addToComputerInfo("Weight", cell.Value.ToString());
                }
                else if (cell.ColumnIndex == HDDSPEEDCOL)
                {
                    addToComputerInfo("HDDSpeed", cell.Value.ToString());
                }
                else if (cell.ColumnIndex == RAMSIZECOL)
                {
                    addToComputerInfo("RAMSize", cell.Value.ToString());
                }
                else if (cell.ColumnIndex == RAMTYPECOL)
                {
                    addToComputerInfo("RAMType", cell.Value.ToString());
                }
                else if (cell.ColumnIndex == RESCOL)
                {
                    addToComputerInfo("Resolution", cell.Value.ToString());
                }
            }
        }

        /// <summary>
        /// Adds new value to computer info
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>
        private void addToComputerInfo(String key, String value)
        {
            if (computerInfo.ContainsKey(key))
            {
                computerInfo.Remove(key);
            }
            computerInfo.Add(key, value);
        }

        /// <summary>
        /// Cancel selection and return to start
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cancelButton_Click(object sender, EventArgs e)
        {
            if (this.startForm == null)
            {
                startForm = new startForm();
            }
            startForm.setFormLocation(this.Location);
            startForm.Show();
            this.Hide();
        }

        /// <summary>
        /// Opens productInfo form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void nextButton_Click(object sender, EventArgs e)
        {
            if (productInfo == null)
            {
                this.productInfo = new productInfo();
            }
            productInfo.setPrevForm(this);
            productInfo.setComputerInfo(computerInfo);
            productInfo.Show();
            this.Hide();
        }

        private void fill_table(object sender, DoWorkEventArgs e)
        {
            
        }
    }
}
