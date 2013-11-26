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
    public partial class productInfo : Form
    {
        private xmlLoader XmlLoader;
        private Form prevForm;
        private Dictionary<String, String> computerInfo = new Dictionary<String, String>();
        private static decimal HST = 0.13m;

        /// <summary>
        /// Construct product info form
        /// </summary>
        public productInfo()
        {
            InitializeComponent();
            initialiseForm(); // initialise form
        }

        /// <summary>
        /// On form load initialise form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void form_load(object sender, EventArgs e)
        {
            updateSizes();
            updateLocation();
            setLabelTexts();
            setLabelColor();
            setBoxLabelColor();
        }

        /// <summary>
        /// Loads form data from the xml file
        /// </summary>
        private void initialiseForm()
        {
            this.XmlLoader = new xmlLoader(this);

            // Set form properties
            this.Text = XmlLoader.getFormTitle();
            this.BackColor = XmlLoader.getFormColor();
            this.Size = prevForm.Size;
            this.WindowState = prevForm.WindowState;
            this.Location = prevForm.Location;
            this.MinimumSize = XmlLoader.getMinimumFormSize();
            
        }

        /// <summary>
        /// Sets label colors
        /// </summary>
        private void setLabelColor()
        {
            // set label colors
            cpuLabel.ForeColor              = XmlLoader.getFontColor();
            HDDLabel.ForeColor              = XmlLoader.getFontColor();
            manufaturerLabel.ForeColor      = XmlLoader.getFontColor();
            OSLabel.ForeColor               = XmlLoader.getFontColor();
            GPULabel.ForeColor              = XmlLoader.getFontColor();
            modelLabel.ForeColor            = XmlLoader.getFontColor();
            screenSizeLabel.ForeColor       = XmlLoader.getFontColor();
            conditionLabel.ForeColor        = XmlLoader.getFontColor();
            costLabel.ForeColor             = XmlLoader.getFontColor();
            costUserLabel.ForeColor         = XmlLoader.getFontColor();
            HSTLabel.ForeColor              = XmlLoader.getFontColor();
            HSTUserLabel.ForeColor          = XmlLoader.getFontColor();
            totalLabel.ForeColor            = XmlLoader.getFontColor();
            totalUserLabel.ForeColor        = XmlLoader.getFontColor();
        }

        /// <summary>
        /// Sets info box group box colors
        /// </summary>
        private void setBoxLabelColor()
        {
            // Set box label colors
            infoBox.ForeColor           = XmlLoader.getFontColor();
            ModelBox.ForeColor          = XmlLoader.getFontColor();
            GPUBox.ForeColor            = XmlLoader.getFontColor();
            cpuBox.ForeColor            = XmlLoader.getFontColor();
            manufacturerBox.ForeColor   = XmlLoader.getFontColor();
            HDDBox.ForeColor            = XmlLoader.getFontColor();
            OSBox.ForeColor             = XmlLoader.getFontColor();
            costBox.ForeColor           = XmlLoader.getFontColor();
            conditionBox.ForeColor      = XmlLoader.getFontColor();
            screenBox.ForeColor         = XmlLoader.getFontColor();
            ramBox.ForeColor            = XmlLoader.getFontColor();
        }

        private void setLabelTexts()
        {
            String cpuId, cpuType, gpu, hddSize, hddSpeed, os, manufacturer, model, screen, costString, condition, weight, ramSize, ramType;
            Decimal cost, HSTCost, totalCost;

            if (computerInfo.TryGetValue("CPUID", out cpuId) && computerInfo.TryGetValue("CPUType", out cpuType))
            {
                cpuLabel.Text = cpuType + " " + cpuId;
            }
            if (computerInfo.TryGetValue("GPU", out gpu))
            {
                GPULabel.Text = gpu;
            }
            if (computerInfo.TryGetValue("HDDSize", out hddSize) && computerInfo.TryGetValue("HDDSpeed", out hddSpeed))
            {
                HDDLabel.Text = hddSpeed + " " + hddSize;
            }
            if (computerInfo.TryGetValue("OS", out os))
            {
                OSLabel.Text = os;
            }
            if (computerInfo.TryGetValue("Manufacturer", out manufacturer))
            {
                manufaturerLabel.Text = manufacturer;
            }
            if (computerInfo.TryGetValue("Model", out model))
            {
                modelLabel.Text = model;
            }
            if (computerInfo.TryGetValue("Screen", out screen))
            {
                screenSizeLabel.Text = screen;
            }
            if (computerInfo.TryGetValue("Condition", out condition))
            {
                conditionLabel.Text = condition;
            }
            if (computerInfo.TryGetValue("Weight", out weight))
            {
                weightLabel.Text = weight;
            }
            if (computerInfo.TryGetValue("RAMSize", out ramSize) && computerInfo.TryGetValue("RAMType", out ramType))
            {
                ramLabel.Text = ramSize + " " + ramType;
            }
            if (computerInfo.TryGetValue("Cost", out costString))
            {
                if (Decimal.TryParse(costString, out cost))
                {
                    HSTCost = cost * HST;
                    totalCost = HSTCost + cost;

                    costLabel.Text = cost.ToString("C");
                    HSTLabel.Text = HSTCost.ToString("C");
                    totalLabel.Text = totalCost.ToString("C");
                }
            }

            infoBox.Text = XmlLoader.getText(infoBox.Name);
            costUserLabel.Text = XmlLoader.getText(costUserLabel.Name);
            HSTUserLabel.Text = XmlLoader.getText(HSTUserLabel.Name);
            totalUserLabel.Text = XmlLoader.getText(totalUserLabel.Name);
            cancelButton.Text = XmlLoader.getText(cancelButton.Name);
            nextButton.Text = XmlLoader.getText(nextButton.Name);
        }

        /// <summary>
        /// Set computer info
        /// </summary>
        /// <param name="computerInfo"></param>
        public void setComputerInfo(Dictionary<String,String> computerInfo)
        {
            this.computerInfo = computerInfo;
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
        /// Close application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void form_closing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// On form size changed update element sizes and locations
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void form_sizeChanged(object sender, EventArgs e)
        {
            updateSizes();
            updateLocation();
        }

        /// <summary>
        /// Update form element sizes
        /// </summary>
        private void updateSizes()
        {

            infoBox.Size = new Size(
                (this.Size.Width - 40),
                (this.Size.Height / 7) * 5
                );
            infoFlowLayoutPanel.Size = Size.Subtract(infoBox.Size, new Size(20, 30));
        }

        /// <summary>
        /// Update form locations
        /// </summary>
        private void updateLocation()
        {
            infoBox.Location = new Point(
                ((this.Size.Width / 2) - (infoBox.Size.Width / 2)),
                (40)
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
    }
}
