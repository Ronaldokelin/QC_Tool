using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            doc.Load(filePath);//To do
            frmApp.listBoxProductNameFile.Items.Clear();
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

        public void populateListBoxStationFile()
        {
            int countStationName = 999;
            int countProductName = doc.SelectSingleNode("QC_Tool").ChildNodes[0].ChildNodes.Count;
            int countProd = allProducts.Length;
            string[] allStationName = new string[20];
            int count = 0;

            for (int i = 0; i < countProd; i++)
            {
                countStationName = doc.SelectSingleNode("QC_Tool").ChildNodes[0].ChildNodes[i].ChildNodes[1].ChildNodes.Count;

                for (int j = 0; j < countStationName; j++)
                {
                    string stationName = doc.SelectSingleNode("QC_Tool").ChildNodes[0].ChildNodes[i].ChildNodes[1].ChildNodes[j].InnerText;

                    if (frmApp.listBoxStationFile.FindStringExact(stationName) == -1)
                    {
                        allStationName[count] = stationName;
                        frmApp.listBoxStationFile.Items.Add(stationName);
                        count++;
                    }
                }
            }
            populateListBoxLicenseTypeFile();
        }

        public void populateListBoxLicenseTypeFile()
        {
            frmApp.listBoxLicenseTypeFile.Items.Clear();
            frmApp.listBoxUserFile.Items.Clear();
            int countStationName = 999;
            int countItens = 999;
            //int countProductName = doc.SelectSingleNode("QC_Tool").ChildNodes[0].ChildNodes.Count;
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
                        string[] itemName = item.Split('_');
                        if (frmApp.listBoxLicenseTypeFile.FindStringExact(itemName[0]) == -1)
                        {
                            frmApp.listBoxLicenseTypeFile.Items.Add(itemName[0]);
                            frmApp.listBoxUserFile.Items.Add(itemName[1]);
                        }
                    }
                }
            }
        }


    }
}

