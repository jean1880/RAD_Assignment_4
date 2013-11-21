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
    /// Splash screen to display to the user as program loads
    /// </summary>
    public partial class splash_screen : Form
    {
        /// <summary>
        /// main constructor
        /// </summary>
        public splash_screen()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
