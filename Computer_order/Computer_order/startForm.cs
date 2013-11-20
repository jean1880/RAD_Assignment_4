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
        public startForm()
        {
            InitializeComponent();
            initialiseForm();
        }

        private void initialiseForm()
        {
            xmlLoader XmlLoader = new xmlLoader(this);
            this.Text = XmlLoader.getTitle();
            this.BackColor = XmlLoader.getFormColor();
            this.Size = XmlLoader.getFormSize();
        }
    }
}
