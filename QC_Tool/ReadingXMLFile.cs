using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Linq;
using System.IO;


namespace QC_Tool
{
    class ReadingXMLFile
    {
        XmlDocument doc = new XmlDocument();
        public string[] allProducts;
        FormApp frmApp;


        public void FillingDGVProduct()
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

        public void FillingDGVStations(string[] allProductsTemp)
        {

            doc.Load(@".\Teste.xml");

            int indexProduct = 999;

            int countProductName = doc.SelectSingleNode("QC_Tool").ChildNodes[0].ChildNodes.Count;
            //allProducts = new string[countProductName];

            /*  for (int i = 0; i < countProductName; i++)
              {
                  string productName = doc.SelectSingleNode("QC_Tool").ChildNodes[0].ChildNodes[i].ChildNodes[0].InnerText;
                  allProducts[i] = productName;
              }*/

            for (int i = 0; i < allProductsTemp.Length; i++)
            {
                if (allProductsTemp[i] == frmApp.comboBoxProducts.Text)
                    indexProduct = i;
            }
            int countStationName = doc.SelectSingleNode("QC_Tool").ChildNodes[0].ChildNodes[indexProduct].ChildNodes[1].ChildNodes.Count;

            for (int i = 0; i < countStationName; i++)
            {
                string BenchName = doc.SelectSingleNode("QC_Tool").ChildNodes[0].ChildNodes[indexProduct].ChildNodes[1].ChildNodes[i].ChildNodes[0].ChildNodes[0].InnerText;
                frmApp.comboBoxEstation.Items.Add(BenchName);
            }
        }
    }
}
