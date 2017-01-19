using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Behaviour_Editor
{
    public class worldObjects
    {
        [XmlAnyAttribute]
        public XmlAttribute[] attibutes
        {
            get
            {
                var attr = new XmlDocument().CreateAttribute(XmlConvert.EncodeLocalName(type));
                attr.Value = name;
                return new[] { attr };
            }
            set
            {
                var attr = (value == null ? null : value.SingleOrDefault());
                if (attr == null)
                {
                    name =
                        type = string.Empty;
                }
                else
                {
                    type = XmlConvert.DecodeName(attr.Name);
                    name = attr.Value;
                }
            }
        }

        [XmlIgnore]
        public string type;
        [XmlIgnore]
        public string name;

        // parameterless constructor for XmlSerializer
        worldObjects() : this(string.Empty, string.Empty) { }

        public worldObjects(string _type, string _name)
        {
            type = _type;
            name = _name;
        }
    }

    public class schedule
    {
        [XmlAttribute]
        public string name;

        schedule() : this(string.Empty) { }
        public schedule(string _name)
        {
            name = _name;
        }
    }
}
