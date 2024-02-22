using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace QC_Tool
{
    class ReadingXMLFile
    {

        public void FillingDGVProduct()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(@"C:\Projetos\QC_Tool\QC_Tool\bin\Debug\Teste.xml");

            foreach(XmlNode node in doc.DocumentElement.ChildNodes)
            {
                string keys = node.InnerXml;
            }
        }
    }
}
