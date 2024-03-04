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
        DataGridView Dgv = new DataGridView();
        public void FillingComboBoxProducts()
        {
            frmApp = FormApp.getInstance();
            doc.Load(@".\Teste.xml");
            frmApp.comboBoxProducts.Items.Clear();

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


                int selectedStation = 999;
                frmApp.dataGridViewCheckTools.Rows.Clear();
                Dgv.PopulateToolDGV();

                for (int i = 0; i < countStationNameOk; i++)//Searching the station choosed on comboBox
                {
                    string BenchNameSelected = doc.SelectSingleNode("QC_Tool").ChildNodes[0].ChildNodes[indexProduct].ChildNodes[1].ChildNodes[i].ChildNodes[0].ChildNodes[0].InnerText;
                    if (BenchNameSelected == frmApp.comboBoxEstation.Text)
                        selectedStation = i;
                }

                int countTools = (doc.SelectSingleNode("QC_Tool").ChildNodes[0].ChildNodes[indexProduct].ChildNodes[1].ChildNodes[selectedStation].ChildNodes.Count) - 1;
                string[] tools = new string[countTools];
                string[] type = new string[countTools];

                for (int i = 1; i <= countTools; i++)
                {
                    tools[i - 1] = doc.SelectSingleNode("QC_Tool").ChildNodes[0].ChildNodes[indexProduct].ChildNodes[1].ChildNodes[selectedStation].ChildNodes[i].Attributes["Name"].Value.ToString();
                    type[i - 1] = doc.SelectSingleNode("QC_Tool").ChildNodes[0].ChildNodes[indexProduct].ChildNodes[1].ChildNodes[selectedStation].ChildNodes[i].Attributes["Type"].Value.ToString();

                    frmApp.dataGridViewCheckTools.Rows.Add();
                    frmApp.dataGridViewCheckTools.Rows[i].Cells[0].Value = tools[i - 1];
                    frmApp.dataGridViewCheckTools.Rows[i].Cells[1].Value = type[i - 1];

                }



            }

            catch { frmApp.labelErrorQPM3.Text = "TO TISTI!!!"; }
        }
    }
}
