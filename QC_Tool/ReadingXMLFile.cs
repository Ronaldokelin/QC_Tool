using System.Xml;
using System.IO;
using System;
using System.Windows.Forms;

namespace QC_Tool
{
    class ReadingXMLFile
    {
        XmlDocument doc = new XmlDocument();
        public string[] allProducts;
        public int indexProduct = 999;
        public int countStationName = 999;
        FormApp frmApp = FormApp.getInstance();
        DataGridView Dgv = new DataGridView();
        Utils uts = new Utils();
        Cmd command = new Cmd();
        Logger log = new Logger();

        public void FillingComboBoxProducts()
        {
            doc.Load(@".\Teste.xml");//To do
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
                string benchNameSelected = string.Empty;

                for (int i = 0; i < countStationNameOk; i++)//Searching the station choosed on comboBox
                {
                    benchNameSelected = doc.SelectSingleNode("QC_Tool").ChildNodes[0].ChildNodes[indexProduct].ChildNodes[1].ChildNodes[i].ChildNodes[0].ChildNodes[0].InnerText;
                    if (benchNameSelected == frmApp.comboBoxEstation.Text)
                        selectedStation = i;
                }

                int countTools = (doc.SelectSingleNode("QC_Tool").ChildNodes[0].ChildNodes[indexProduct].ChildNodes[1].ChildNodes[selectedStation].ChildNodes.Count) - 1;
                string[,] xmlAtributes = new string[3, countTools];

                for (int i = 1; i <= countTools; i++)
                {
                    int k = i - 1;

                    xmlAtributes[0, k] = doc.SelectSingleNode("QC_Tool").ChildNodes[0].ChildNodes[indexProduct].ChildNodes[1].ChildNodes[selectedStation].ChildNodes[i].Attributes["Name"].Value.ToString();
                    xmlAtributes[1, k] = doc.SelectSingleNode("QC_Tool").ChildNodes[0].ChildNodes[indexProduct].ChildNodes[1].ChildNodes[selectedStation].ChildNodes[i].Attributes["Type"].Value.ToString();
                    xmlAtributes[2, k] = doc.SelectSingleNode("QC_Tool").ChildNodes[0].ChildNodes[indexProduct].ChildNodes[1].ChildNodes[selectedStation].ChildNodes[i].Attributes["Path"].Value.ToString();
                    frmApp.dataGridViewCheckTools.Rows.Add();

                    if (xmlAtributes[1, k] != "Tool")
                        frmApp.dataGridViewCheckTools.Rows[i].Cells[0].Value = xmlAtributes[0, k] + "_" + xmlAtributes[2, k];

                    else
                        frmApp.dataGridViewCheckTools.Rows[i].Cells[0].Value = xmlAtributes[0, k];

                    frmApp.dataGridViewCheckTools.Rows[i].Cells[1].Value = xmlAtributes[1, k];

                    if (xmlAtributes[1, k] == "Tool")
                    {
                        if (verifyFileTool(xmlAtributes[2, k]))
                        {
                            frmApp.dataGridViewCheckTools.Rows[i].Cells[2].Value = "OK";
                            uts.cleanLabel();
                        }

                        else
                        {
                            frmApp.dataGridViewCheckTools.Rows[i].Cells[2].Value = "NOK";
                            i = countTools;
                            uts.labelError("  QUTS not found, please install the QUTS!", "red");
                        }
                    }

                    if (xmlAtributes[1, k] == "License")
                    {
                        string dateLic = command.licenseGroupID(xmlAtributes[2, k]);
                        if (dateLic != "")
                        {
                            var licExpiry = DateTime.Parse(dateLic);
                            var today = DateTime.Now;
                            var diff = licExpiry - today;

                            frmApp.dataGridViewCheckTools.Rows[i].Cells[2].Value = "OK";
                            frmApp.dataGridViewCheckTools.Rows[i].Cells[3].Value = diff.Days + " days";
                            
                            int expiry = (int)diff.TotalDays;
                            if (expiry <= 0)
                            {                                
                                frmApp.dataGridViewCheckTools.Rows[i].Cells[2].Value = "NOK";
                                frmApp.buttonActions.Enabled = true;
                            }
                        }
                        else
                        {
                            frmApp.dataGridViewCheckTools.Rows[i].Cells[2].Value = "NOK";
                            frmApp.buttonActions.Enabled = true;
                        }
                    }
                }
                Dgv.formattingDGV();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message + "");
                uts.labelError("ERROR on FillingDGVTools() method!!!", "red");
            }
        }

        private bool verifyFileTool(string path)
        {
            try
            {
                if (File.Exists(path))
                    return true;

                return false;
            }
            catch { return false; }
        }

        public void countNokLicenses(string path)
        {
            try
            {
              //  frmApp = FormApp.getInstance();
                int errorsLic = 0;

                for (int i = 0; i < frmApp.dataGridViewCheckTools.RowCount; i++)
                {
                    if (frmApp.dataGridViewCheckTools.Rows[i].Cells[2].Value.ToString() == "NOK")
                        errorsLic++;
                }

                frmApp.lic = new string[errorsLic];
                log.textBoxLog("LICENSES NOK = " + errorsLic);

                int count = 0;
                for (int i = 0; i < frmApp.dataGridViewCheckTools.RowCount; i++)
                {
                    if (frmApp.dataGridViewCheckTools.Rows[i].Cells[2].Value.ToString() == "NOK")
                    {
                        FileConfig.writeFile(path, frmApp.dataGridViewCheckTools.Rows[i].Cells[0].Value.ToString());
                        frmApp.lic[count] = frmApp.dataGridViewCheckTools.Rows[i].Cells[0].Value.ToString();
                        count++;
                    }
                }
            }
            catch { }
        }
    }
}

