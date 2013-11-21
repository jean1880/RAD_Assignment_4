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
    public partial class startForm : Form
    {
        private Size buttonSize;
        private xmlLoader XmlLoader;
        private selectionForm selectionForm = new selectionForm();

        public startForm()
        {
            InitializeComponent();
            initialiseForm();
        }

        private void initialiseForm()
        {
            this.XmlLoader = new xmlLoader(this);
            this.Text = XmlLoader.getFormTitle();
            this.BackColor = XmlLoader.getFormColor();
            this.Size = XmlLoader.getFormSize();
            this.MinimumSize = XmlLoader.getMinimumFormSize();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

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

        private void form_sizeChanged(object sender, EventArgs e)
        {
            updateSizes();
            updateLocations();            
        }

        private void form_load(object sender, EventArgs e)
        {
            updateSizes();
            updateLocations();          
            logoBox.Image = XmlLoader.getImage(logoBox.Name);
            newButton.Text = XmlLoader.getText(newButton.Name);
            loadButton.Text = XmlLoader.getText(loadButton.Name);
        }

        private void newButton_Click(object sender, EventArgs e)
        {
            selectionForm.setStartForm(this);
            selectionForm.Show();
            this.Hide();
        }

        private void form_closing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
