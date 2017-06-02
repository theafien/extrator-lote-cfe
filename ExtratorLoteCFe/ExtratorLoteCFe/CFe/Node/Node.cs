using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.IO;

namespace ExtratorLoteCFe.CFe.Node
{
    class Node : INode
    {

        protected XMLFile Xml
        {
            get;
            set;
        }


        protected XmlNode XmlNode
        {
            get;
            set;
        }

        public Node(XMLFile xml, XmlNode node)
        {
            Xml = xml;
            XmlNode = node;
        }

        public string nserieSAT
        {
            get
            {
                return SelectNodeText("./ns:infCFe/ns:ide/ns:nserieSAT");
            }
        }
        public DateTime dateEmi
        {
            get
            {
                string d = dEmi;
                string h = SelectNodeText("./ns:infCFe/ns:ide/ns:hEmi");

                DateTime dateTime = DateTime.ParseExact(String.Format("{0} {1}", d, h), "yyyyMMdd HHmmss", System.Globalization.CultureInfo.InvariantCulture);

                return dateTime; //.ToString("dd/MM/yyyy HH:mm:ss");
            }

            
        }
        public string dEmi
        {
            get
            {
                return SelectNodeText("./ns:infCFe/ns:ide/ns:dEmi");
            }
        }


        public string infCFeId

        {
            get
            {
                XmlNode node = SelectNode("./ns:infCFe");
                if (node != null)
                {
                    return node.Attributes["Id"].InnerText;
                }
                return null;
            }

        }

        public string Tipo
        {
            get
            {
                switch (XmlNode.Name)
                {
                    case "CFe":
                        return "Vendido";
                    case "CFeCanc":
                        return "Cancelado";
                }
                return "Desconhecido";
            }
        }

        public string nCFe
        {
            get
            {
                return SelectNodeText("./ns:infCFe/ns:ide/ns:nCFe");
            }
        }

        public string total
        {
            get
            {
                return "R$ " + SelectNodeText("./ns:infCFe/ns:total/ns:vCFe");
            }
        }

        public string IdLote
        {
            get
            {
                return Xml.SelectNode("./ns:idLote").InnerText;
            }
        }

        public string CNPJ
        {
            get
            {
                return SelectNodeText("./ns:infCFe/ns:emit/ns:CNPJ");
            }
        }


        protected XmlNode SelectNode(string xpath)
        {
            return Xml.SelectNode(XmlNode, xpath);
        }
        protected string SelectNodeText(string format, params object[] args)
        {
            XmlNode node = SelectNode(String.Format(format, args));
            if (node != null)
            {
                return node.InnerText;
            }
            return null;
        }

        public string FileName
        {
            get
            {
                return Path.Combine(CNPJ, dEmi.Substring(0, 6), infCFeId.Replace("CFe", "AD") + ".xml");
            }
        }

        

        public bool exportTo(string path)
        {

            string filename = Path.Combine(path, FileName);

            string dest_path = Path.GetDirectoryName(filename);


            if (!Directory.Exists(dest_path))

            {
                Directory.CreateDirectory(dest_path);
            }

            XmlWriterSettings settings = new XmlWriterSettings();
            settings.OmitXmlDeclaration = true;

            FileStream fs = File.OpenWrite(filename);
            XmlWriter xmlWriter = XmlWriter.Create(fs, settings);
            XmlNode.WriteTo(xmlWriter);
            xmlWriter.Close();
            fs.Close();

            return true;
        }

        public bool exists(string path)
        {
            return File.Exists(Path.Combine(path, FileName));
        }

    }
}
