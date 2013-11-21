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
        private Color formColor, fontColor;
        private Size formSize, minimumFormSize;
        private String formTitle;
        private String formName;
        private static String ALLFORMS = "/data/allForms/";
        private static String DATANODE = "/data/";

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
            setMinSize();
            setFontColor();
        }

        private void loadXML()
        {
            // Load xml data file
            this.doc.LoadXml(Properties.Resources.computer_orderForms); // load the xml file into the doc variable   
        }

        private void setTitle()
        {
            XmlNode node;
            // Get form Title
            node = doc.SelectSingleNode(ALLFORMS + "title");
            this.formTitle = node.InnerText;
        }

        private void setFontColor()
        {
            XmlNode node;
            // Get form Title
            node = doc.SelectSingleNode(ALLFORMS + "font/color");
            this.fontColor = Color.FromName(node.InnerText);
        }

        private void setColor()
        {
            XmlNode nodeR, nodeG, nodeB;
            // get form color
            nodeR = doc.SelectSingleNode(ALLFORMS + "color/red");
            nodeG = doc.SelectSingleNode(ALLFORMS + "color/green");
            nodeB = doc.SelectSingleNode(ALLFORMS + "color/blue");
            this.formColor = Color.FromArgb(int.Parse(nodeR.InnerText), int.Parse(nodeG.InnerText), int.Parse(nodeB.InnerText));
        }

        private void setSize()
        {
            XmlNode nodeW, nodeH;
            // get form Size
            nodeW = doc.SelectSingleNode(ALLFORMS + "size/width");
            nodeH = doc.SelectSingleNode(ALLFORMS + "size/height");
            this.formSize = new Size(int.Parse(nodeW.InnerText), int.Parse(nodeH.InnerText));
        }

        /// <summary>
        /// Sets minimumFormSize
        /// </summary>
        private void setMinSize()
        {
            XmlNode nodeW, nodeH;
            // get form minimum size, if not set for form, use default
            if (doc.SelectSingleNode(DATANODE + formName + "/" + "size/min-width") != null)
            {
                nodeW = doc.SelectSingleNode(DATANODE + formName + "/" + "size/min-width");
                nodeH = doc.SelectSingleNode(DATANODE + formName + "/" + "size/min-height");
            }
            else
            {
                nodeW = doc.SelectSingleNode(ALLFORMS + "size/min-width");
                nodeH = doc.SelectSingleNode(ALLFORMS + "size/min-height");
            }            
            this.minimumFormSize = new Size(int.Parse(nodeW.InnerText), int.Parse(nodeH.InnerText));
        }

        public string getFormTitle()
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

        public Size getMinimumFormSize()
        {
            return this.minimumFormSize;
        }

        public Color getFontColor()
        {
            return this.fontColor;
        }

        public Image getImage(String imageBoxName)
        {
            XmlNode node;
            node = doc.SelectSingleNode(DATANODE + formName + "/" + imageBoxName + "/resource");
            return (Image)Properties.Resources.ResourceManager.GetObject(node.InnerText);;
        }

        public String getText(String itemName)
        {
            XmlNode node;
            node = doc.SelectSingleNode(DATANODE + formName + "/" + itemName + "/text");
            return node.InnerText;
        }

        public Size getItemMaxSize(String itemName)
        {
            XmlNode nodeW, nodeH;
            nodeW = doc.SelectSingleNode(DATANODE + formName + "/" + itemName + "/size/max-width");
            nodeH = doc.SelectSingleNode(DATANODE + formName + "/" + itemName + "/size/max-height");
            return new Size(int.Parse(nodeW.InnerText), int.Parse(nodeH.InnerText)); ;
        }
    }
}
