using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Computer_order
{
    class xmlLoader
    {
        private Form formVar;
        private XmlDocument doc = new XmlDocument(); // Variable to store xml document into
        private Color formColor;
        private Size formSize;
        private String formTitle;
        private String formName;
        private XmlNode title;
        private static String ALLFORMS = "/data/allForms/";

        public xmlLoader(Form formVar)
        {
            this.formVar = formVar;
            this.formName = formVar.Name;
            initialize();
        }

        private void initialize()
        {
            loadXML();
            setTitle();
            setColor();
            setSize();
        }

        private void loadXML()
        {
            // Load xml data file
            this.doc.LoadXml(Properties.Resources.computer_orderForms); // load the xml file intot her doc variable   
        }

        private void setTitle()
        {
            // Get form Title
            title = doc.SelectSingleNode(ALLFORMS + "title");
            this.formTitle = title.InnerText;
        }

        private void setColor()
        {
            int red, green, blue;
            // get form color
            title = doc.SelectSingleNode(ALLFORMS + "color/red");
            red = int.Parse(title.InnerText);
            title = doc.SelectSingleNode(ALLFORMS + "color/green");
            green = int.Parse(title.InnerText);
            title = doc.SelectSingleNode(ALLFORMS + "color/blue");
            blue = int.Parse(title.InnerText);
            this.formColor = Color.FromArgb(red, green, blue);
        }

        private void setSize()
        {
            int width, height;
            // get form color
            title = doc.SelectSingleNode(ALLFORMS + "size/width");
            width = int.Parse(title.InnerText);
            title = doc.SelectSingleNode(ALLFORMS + "size/height");
            height = int.Parse(title.InnerText);
            this.formSize = new Size(width, height);
        }

        public string getTitle()
        {
            return formTitle;
        }

        public Color getFormColor()
        {
            return this.formColor;
        }

        public Size getFormSize()
        {
            return this.formSize;
        }
    }
}
