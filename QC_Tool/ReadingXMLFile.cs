using System.Windows.Forms;
using System.Xml;

namespace QC_Tool
{
    class ReadingXMLFile
    {
        XmlDocument doc = new XmlDocument();
        public string[] allProducts;
        public int indexProduct = 999;
        public int countStationName = 999;
        FormApp frmApp;

        public void FillingComboBoxProducts()
        {
            frmApp = FormApp.getInstance();
            doc.Load(@".\Teste.xml");
            frmApp.comboBoxProducts.Items.Clear();

            /* XmlDocument doc = new XmlDocument();
             doc.Load(@".\Teste.xml");

             foreach (XmlNode node in doc.)

             {
                 string sla = node.ToString();
                 frmApp.comboBoxProducts.Items.Add(sla);
             }*/

            //string file = @".\Teste.xml";

            /*XmlTextReader xmlReader = new XmlTextReader(file);
            while (xmlReader.Read())
            {
                switch (xmlReader.NodeType)
                {
                    case XmlNodeType.Element:
                        string element = xmlReader.Name;

                        if (element == "Products")
                        {
                            if (xmlReader.HasAttributes)
                            {
                                while (xmlReader.MoveToNextAttribute())
                                {
                                    //Pega o valor do atributo.
                                    frmApp.comboBoxProducts.Items.Add(xmlReader.Value);
                                }
                                //   XmlNodeType.EndElement
                                //   frmApp.comboBoxProducts.Items.Add(xmlReader.Name);
                            }
                        }
                        break;

                        /*  case XmlNodeType.Text:
                              // frmApp.comboBoxProducts.Items.Add(xmlReader.Value);
                              // txtDados.Text += xmlReader.Value + Environment.NewLine;
                              break;

                          case XmlNodeType.EndElement:
                              frmApp.comboBoxProducts.Items.Add("<" + xmlReader.Name + ">");
                              //txtDados.Text += "<" + xmlReader.Name + ">" + Environment.NewLine;
                              break;                       
        }
    }*/
            int countProductName = doc.SelectSingleNode("QC_Tool").ChildNodes[0].ChildNodes.Count;
            allProducts = new string[countProductName];

            for (int i = 0; i < countProductName; i++)
            {
                string productName = doc.SelectSingleNode("QC_Tool").ChildNodes[0].ChildNodes[i].ChildNodes[0].InnerText;
                frmApp.comboBoxProducts.Items.Add(productName);
                allProducts[i] = productName;
            }
        }

        public void FillingComboBoxStations(string[] allProductsTemp)
        {
            doc.Load(@".\Teste.xml");

            int countProductName = doc.SelectSingleNode("QC_Tool").ChildNodes[0].ChildNodes.Count;

            for (int i = 0; i < allProductsTemp.Length; i++) //Searching the index of the selected product
            {
                if (allProductsTemp[i] == frmApp.comboBoxProducts.Text)
                    indexProduct = i;
            }

            countStationName = doc.SelectSingleNode("QC_Tool").ChildNodes[0].ChildNodes[indexProduct].ChildNodes[1].ChildNodes.Count;

            for (int i = 0; i < countStationName; i++) //Filling Combo Box Stations Name
            {
                string BenchName = doc.SelectSingleNode("QC_Tool").ChildNodes[0].ChildNodes[indexProduct].ChildNodes[1].ChildNodes[i].ChildNodes[0].ChildNodes[0].InnerText;
                frmApp.comboBoxEstation.Items.Add(BenchName);
            }
        }

        public void FillingDGVTools(int indexProductOk, int countStationNameOk)
        {
            try
            {
                doc.Load(@".\Teste.xml");
                int countTools = doc.SelectSingleNode("QC_Tool").ChildNodes[0].ChildNodes[indexProductOk].ChildNodes[1].ChildNodes[1].ChildNodes.Count;
                string[] tools = new string[countTools];
                int selectedStation = 999;
                frmApp.dataGridViewCheckTools.Rows.Clear();
                frmApp.PopulateToolDGV();

                for (int i = 0; i < countStationNameOk; i++)
                {
                    string BenchNameSelected = doc.SelectSingleNode("QC_Tool").ChildNodes[0].ChildNodes[indexProduct].ChildNodes[1].ChildNodes[i].ChildNodes[0].ChildNodes[0].InnerText;
                    if (BenchNameSelected == frmApp.comboBoxEstation.Text)
                        selectedStation = i;
                }

                for (int i = 1; i < countTools; i++) //Filling DGV colummn tools
                {
                    tools[i] = doc.SelectSingleNode("QC_Tool").ChildNodes[0].ChildNodes[indexProductOk].ChildNodes[1].ChildNodes[selectedStation].ChildNodes[i].InnerText;
                    frmApp.dataGridViewCheckTools.Rows.Add();
                    frmApp.dataGridViewCheckTools.Rows[i].Cells[0].Value = tools[i];

                }

            }
            catch { }
        }
    }
}
