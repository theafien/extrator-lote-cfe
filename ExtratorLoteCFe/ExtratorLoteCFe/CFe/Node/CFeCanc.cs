using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;

namespace ExtratorLoteCFe.CFe.Node
{
    class CFeCanc : Node, ICFe
    {
        public CFeCanc(XMLFile xml, XmlNode node) :
            base(xml, node)
        {
        }

    }
}
