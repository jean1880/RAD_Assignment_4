using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Computer_order
{
    /// <summary>
    /// Main start screen
    /// </summary>
    public partial class startForm : Form
    {
        private Size buttonSize;
        private xmlLoader XmlLoader;
        private selectionForm selectionForm = new selectionForm();
        productInfo productInfo;
        private static String FILECHECK = "<computer_order loadFile>";

        /// <summary>
        /// Starting form main constructor
        /// </summary>
        public startForm()
        {
            InitializeComponent();
            initialiseForm();
        }

        /// <summary>
        /// Set initial form settings
        /// </summary>
        private void initialiseForm()
        {
            this.XmlLoader = new xmlLoader(this);
            this.Text = XmlLoader.getFormTitle();
            this.BackColor = XmlLoader.getFormColor();
            this.Size = XmlLoader.getFormSize();
            this.MinimumSize = XmlLoader.getMinimumFormSize();
            this.StartPosition = FormStartPosition.CenterScreen;

            setopenFileSettings();
        }

        /// <summary>
        /// sets openfiledialog settings
        /// </summary>
        public void setopenFileSettings()
        {
            openFileDialog.Filter = "Text Files|*.txt";
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            openFileDialog.FileName = "My_order";
            openFileDialog.AutoUpgradeEnabled = true;
            openFileDialog.Multiselect = false;
        }

        /// <summary>
        /// sets form loaction
        /// </summary>
        /// <param name="prevLocation"></param>
        public void setFormLocation(Point prevLocation)
        {
            this.Location = prevLocation;
        }

        /// <summary>
        /// Update sizes of elements
        /// </summary>
        private void updateSizes()
        {
            this.buttonSize = new System.Drawing.Size(
                (this.Size.Width / 2), 23
                );
            logoBox.Size = new System.Drawing.Size(
                (this.Size.Width / 2), (this.Size.Height / 2)
                );
            newButton.Size = buttonSize;
            loadButton.Size = buttonSize;            
        }

        /// <summary>
        /// Updates the locations of elements
        /// </summary>
        private void updateLocations()
        {
            newButton.Location = new Point(
                ((this.Size.Width / 2) - (newButton.Size.Width / 2)),
                ((this.Size.Height / 3) * 2)
                );
            loadButton.Location = new Point(
               ((this.Size.Width / 2) - (newButton.Size.Width / 2)),
               (((this.Size.Height / 3) * 2) + 25)
               );
            logoBox.Location = new Point(
                ((this.Size.Width / 2) - (logoBox.Size.Width / 2)),
                (30)
                );
        }

        /// <summary>
        /// On form resize update sizes and locations of elements
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void form_sizeChanged(object sender, EventArgs e)
        {
            updateSizes();
            updateLocations();            
        }

        /// <summary>
        /// On form load set form properties
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void form_load(object sender, EventArgs e)
        {
            updateSizes();
            updateLocations();
            logoBox.Image = XmlLoader.getImage(logoBox.Name);
            newButton.Text = XmlLoader.getText(newButton.Name);
            loadButton.Text = XmlLoader.getText(loadButton.Name);
        }

        /// <summary>
        /// Start new order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void newButton_Click(object sender, EventArgs e)
        {
            selectionForm.setPrevForm(this);
            selectionForm.setFormLocation(this.Location);
            selectionForm.Show();
            this.Hide();
        }

        /// <summary>
        /// Exit the application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void form_closing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// open load file dialog and load a saved order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void loadButton_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = openFileDialog.ShowDialog();
            if (dialogResult != DialogResult.Cancel)
            {
                try
                {
                    StreamReader fileReader = new StreamReader(
                        openFileDialog.FileName
                    );

                    String fileCheck = fileReader.ReadLine();

                    if (fileCheck.Equals(FILECHECK))
                    {
                        String productID = fileReader.ReadLine();
                        productID = productID.Substring(8);

                        int prodID;
                        if(int.TryParse(productID, out prodID))
                        {
                            if (productInfo == null)
                            {
                                productInfo = new productInfo();
                            }
                            productInfo.setProductID(prodID);
                            productInfo.setPrevForm(this);
                            productInfo.Show();
                            this.Hide();
                        }
                    }
                }
                catch(IOException err)
                {
                    System.Diagnostics.Debug.Write(err.Message);
                }
            }
        }
    }
}
