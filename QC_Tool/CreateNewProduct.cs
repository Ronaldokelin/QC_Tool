using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;

namespace QC_Tool
{
    class CreateNewProduct
    {
        FormApp frmApp = FormApp.getInstance();
        string filePath = (@".\Teste.xml");

        public void writeToXML()
        {
            if (File.Exists(filePath))
            {
                XDocument xDocument = XDocument.Load(filePath);
                XElement root = xDocument.Element("QC_Tool");
                IEnumerable<XElement> rows = root.Descendants("Product");
                XElement firstRow = rows.First();
                firstRow.AddBeforeSelf(
                   new XElement("Product",
                   new XElement("ProductName", frmApp.textBoxProductName.Text),

                   new XElement("Stations",
                   new XElement("Bench",
                   new XElement("BenchName", frmApp.comboBoxBenchName.Text),

                   new XElement("Item",
                   new XAttribute("Name", frmApp.textBoxItemName.Text),
                   new XAttribute("Type", frmApp.comboBoxItemType.Text),
                   new XAttribute("Path", frmApp.textBoxItemPath.Text))))));

                xDocument.Save(filePath);
            }
            else
            {
                MessageBox.Show("XML FILE NOT FOUNDED!!!");
            }
        }
    }
}
