using System.Xml;

namespace QC_Tool
{
    class PopulateListBoxEngineer
    {
        FormApp frmApp = FormApp.getInstance();
        XmlDocument doc = new XmlDocument();
        public string[] allProducts;
        string filePath = (@".\Teste.xml");

        public void populatelistBoxProductNameFile()
        {
            try
            {
                doc.Load(filePath);//To do
                frmApp.listBoxProductNameFile.Items.Clear();
                frmApp.listBoxProductNameFile.Items.Add("NEW...");
                int countProductName = doc.SelectSingleNode("QC_Tool").ChildNodes[0].ChildNodes.Count;

                allProducts = new string[countProductName];

                for (int i = 0; i < countProductName; i++)
                {
                    string productName = doc.SelectSingleNode("QC_Tool").ChildNodes[0].ChildNodes[i].ChildNodes[0].InnerText;
                    frmApp.listBoxProductNameFile.Items.Add(productName);
                    allProducts[i] = productName;
                }
                populateListBoxStationFile();
            }
            catch { }
        }

        public void populateListBoxStationFile()
        {
            try
            {
                frmApp.listBoxStationFile.Items.Clear();
                frmApp.listBoxStationFile.Items.Add("NEW...");

                doc.Load(filePath);//To do
                int countStationName = 999;
                int countProd = allProducts.Length;

                for (int i = 0; i < countProd; i++)
                {
                    countStationName = doc.SelectSingleNode("QC_Tool").ChildNodes[0].ChildNodes[i].ChildNodes[1].ChildNodes.Count;

                    for (int j = 0; j < countStationName; j++)
                    {
                        string stationName = doc.SelectSingleNode("QC_Tool").ChildNodes[0].ChildNodes[i].ChildNodes[1].ChildNodes[j].InnerText;

                        if (frmApp.listBoxStationFile.FindStringExact(stationName) == -1)
                            frmApp.listBoxStationFile.Items.Add(stationName);
                    }
                }
                populateAtributtesListBoxs();
            }
            catch { }
        }

        public void populateAtributtesListBoxs()
        {
            try
            {
                doc.Load(filePath);//To do
                clearAndAddNew();

                int countStationName = 999;
                int countItens = 999;
                int countProd = allProducts.Length;

                for (int i = 0; i < countProd; i++)
                {
                    countStationName = doc.SelectSingleNode("QC_Tool").ChildNodes[0].ChildNodes[i].ChildNodes[1].ChildNodes.Count;

                    for (int j = 0; j < countStationName; j++)
                    {
                        countItens = doc.SelectSingleNode("QC_Tool").ChildNodes[0].ChildNodes[i].ChildNodes[1].ChildNodes[j].ChildNodes.Count;

                        for (int k = 1; k < countItens; k++)
                        {
                            string item = doc.SelectSingleNode("QC_Tool").ChildNodes[0].ChildNodes[i].ChildNodes[1].ChildNodes[j].ChildNodes[k].Attributes[0].Value;
                            string license = doc.SelectSingleNode("QC_Tool").ChildNodes[0].ChildNodes[i].ChildNodes[1].ChildNodes[j].ChildNodes[k].Attributes[1].Value;
                            string path = doc.SelectSingleNode("QC_Tool").ChildNodes[0].ChildNodes[i].ChildNodes[1].ChildNodes[j].ChildNodes[k].Attributes[2].Value;

                            string[] itemName = item.Split('_');

                            if (frmApp.listBoxLicenseTypeFile.FindStringExact(itemName[0]) == -1)
                                frmApp.listBoxLicenseTypeFile.Items.Add(itemName[0]);

                            if (frmApp.listBoxUserFile.FindStringExact(itemName[1]) == -1)
                                frmApp.listBoxUserFile.Items.Add(itemName[1]);

                            if (frmApp.listBoxItemTypeFile.FindStringExact(license) == -1)
                                frmApp.listBoxItemTypeFile.Items.Add(license);

                            if (frmApp.listBoxLicenseNumberFile.FindStringExact(path) == -1 && license != "Tool")
                                frmApp.listBoxLicenseNumberFile.Items.Add(path);
                        }
                    }
                }
            }
            catch { }
        }

        private void clearAndAddNew()
        {
            try
            {
                frmApp.listBoxLicenseTypeFile.Items.Clear();
                frmApp.listBoxUserFile.Items.Clear();
                frmApp.listBoxItemTypeFile.Items.Clear();
                frmApp.listBoxLicenseNumberFile.Items.Clear();

                frmApp.listBoxLicenseTypeFile.Items.Add("NEW...");
                frmApp.listBoxUserFile.Items.Add("NEW...");
                frmApp.listBoxItemTypeFile.Items.Add("NEW...");
                frmApp.listBoxLicenseNumberFile.Items.Add("NEW...");
            }
            catch { }
        }
    }
}

