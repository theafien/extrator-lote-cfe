using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;

namespace ExtratorLoteCFe.CFe.Node
{
    class CFe : Node, ICFe
    {
        public CFe(XMLFile xml, XmlNode node) :
            base(xml, node)
        {
        }

    }
}
