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
        XDocument xDocument = XDocument.Load(@".\Teste.xml");


        public void writeToXML()
        {
            if (File.Exists(filePath))
            {
                if (!verifyProductName())
                    createNewProductXML();

                else if (!verifyBenchName())
                    createNewBench();
            }
            else
                MessageBox.Show("XML FILE NOT FOUNDED!!!");
        }

        private bool verifyProductName()
        {
            if (xDocument.Elements("QC_Tool")
             .Elements("Products")
             .Elements("Product")
             .Elements("ProductName")
             .Any(x => x.Value == frmApp.textBoxProductName.Text) == true)
                return true;

            return false;
        }

        private bool verifyBenchName()
        {
            if (xDocument.Elements("QC_Tool")
             .Elements("Products")
             .Elements("Product")
             .Elements("ProductName")
             .Elements("Stations")
             .Elements("Bench")
             .Elements("BenchName")
             .Any(x => x.Value == frmApp.comboBoxBenchName.Text) == true)
                return true;

            return false;
        }

        private void createNewProductXML()
        {
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

        private void createNewBench()
        {
            XElement root = xDocument.Element("QC_Tool");
            IEnumerable<XElement> rows = root.Descendants("Bench");

            int count = -1;
            int countBench = 999;

            foreach (string product in xDocument.Descendants("ProductName"))
            {
                count++;
                if (product == frmApp.textBoxProductName.Text)
                    countBench = count;
            }
            xDocument.Element("QC_Tool").
                     Elements("Products").
                     Elements("Product").
                     Elements("ProductName").
                     ElementAt(countBench).
                     ElementsAfterSelf("Stations").
                     First().AddFirst(new XElement("Bench",
                                      new XElement("BenchName", frmApp.comboBoxBenchName.Text),
                                      new XElement("Item",
                                      new XAttribute("Name", frmApp.textBoxItemName.Text),
                                      new XAttribute("Type", frmApp.comboBoxItemType.Text),
                                      new XAttribute("Path", frmApp.textBoxItemPath.Text))));

            xDocument.Save(filePath);
        }
    }
}
