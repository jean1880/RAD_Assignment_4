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
    public partial class selectionForm : Form
    {
        private xmlLoader XmlLoader;
        private startForm startForm;

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
        /// On form load initialize form and fill datagrid
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void form_load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dollarcomputersDataSet.products' table. You can move, or remove it, as needed.
            initialiseForm();
            this.productsTableAdapter.Fill(this.dollarcomputersDataSet.products);
        }

        /// <summary>
        /// Loads form data from the xml file
        /// </summary>
        private void initialiseForm()
        {
            this.XmlLoader = new xmlLoader(this);
            this.Text = XmlLoader.getFormTitle();
            this.BackColor = XmlLoader.getFormColor();
            this.Size = startForm.Size;
            this.Location = startForm.Location;
            this.MinimumSize = XmlLoader.getMinimumFormSize();
            computerGrid.MaximumSize = XmlLoader.getItemMaxSize(computerGrid.Name);
            infoBox.Text = XmlLoader.getText(infoBox.Name);
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

        private void updateSizes()
        {
            Size centeredSize = new System.Drawing.Size(
                (this.Size.Width / 10)*9,
                (this.Size.Height / 3)
                );
            computerGrid.Size = centeredSize;
            infoBox.Size = centeredSize;

        }

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
        }

        private void form_closing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
