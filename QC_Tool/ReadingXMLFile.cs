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

        public void FillingDGVProduct()
        {
            FormApp frmApp = FormApp.getInstance();

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
            XmlDocument doc = new XmlDocument();

            string file = @".\Teste.xml";

            doc.Load(file);

            //Lê o filho de um Nó Pai específico 
            for (int i = 0; i < 2; i++)
            {
                string productName = doc.SelectSingleNode("QC_Tool").ChildNodes[0].ChildNodes[i].ChildNodes[0].InnerText;
                frmApp.comboBoxProducts.Items.Add(productName);

            }


            
            //endereco do aluno
         /*   for (int i = 0; i <= 4; i++)
            {
                frmApp.comboBoxProducts.Items.Add(doc.SelectSingleNode("Alunos").ChildNodes[3].ChildNodes[i].InnerText);
            }
            */


        }
    }
}
