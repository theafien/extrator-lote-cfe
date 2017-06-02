using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ExtratorLoteCFe.CFe;
using System.Xml;

namespace ExtratorLoteCFe.CFe
{
    class XMLFile
    {
        XmlDocument m_document;

        XmlNamespaceManager m_nsManager;

        public XMLFile(XmlDocument document)
        {

            m_document = document;
            m_nsManager = new XmlNamespaceManager(m_document.NameTable);
            m_nsManager.AddNamespace("ns", m_document.DocumentElement.NamespaceURI);           

        }

        public List<Node.ICFe> getCFes()
        {
            List<Node.ICFe> CFes = new List<Node.ICFe>();

            XmlNodeList els = m_document.GetElementsByTagName("LoteCFe");
            foreach (XmlNode node in els)
            {
                foreach (XmlNode cfe in node.ChildNodes)
                {
                    switch (cfe.Name.ToLower())
                    {
                        case "cfe":
                            CFes.Add(new Node.CFe(this, cfe));
                            break;
                        case "cfecanc":
                            CFes.Add(new Node.CFeCanc(this, cfe));
                            break;
                    }
                }
            }

            return CFes;
        }


        public XmlDocument Document
        {
            get
            {
                return m_document;
            }
        }

        public XmlNode SelectNode(string xpath)
        {
            return SelectNode(m_document.DocumentElement, xpath);
        }
        public XmlNode SelectNode(XmlNode node, string xpath)
        {
            return node.SelectSingleNode(xpath, m_nsManager);
        }

        public static XMLFile LoadFile(string filename)
        {
            XmlDataDocument doc = new XmlDataDocument();
            doc.Load(filename);
            return new XMLFile(doc);
        }

        public static List<XMLFile> LoadFile(string[] filenames)
        {
            List<XMLFile> files = new List<XMLFile>();
            foreach (string file in filenames)
            {
                files.Add(LoadFile(file));
            }
            return files;
        }


    }
}
