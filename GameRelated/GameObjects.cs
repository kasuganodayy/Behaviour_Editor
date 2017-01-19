using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Behaviour_Editor
{
    public class OwnedObjects
    {
        [XmlAnyAttribute]
        public XmlAttribute[] xmlAttributes
        {
            get
            {
                if(m_attributes == null)
                {
                    return null;
                }
                var xmlDoc = new XmlDocument();
                return m_attributes.Select(p => { var att = xmlDoc.CreateAttribute(p.Key); att.Value = p.Value; return att; }).ToArray();
            }
            set
            {
                if(value == null)
                {
                    m_attributes = null;
                }
                else
                {
                    m_attributes = value.ToDictionary(att => att.Name, att => att.Value);
                }
            }
        }
        //{
        //    get
        //    {
        //        var attr = new XmlDocument().CreateAttribute(XmlConvert.EncodeLocalName(m_type));
        //        attr.Value = m_name;
        //        return new[] { attr };
        //    }
        //    set
        //    {
        //        var attr = (value == null ? null : value.FirstOrDefault());
        //        if (attr == null)
        //        {
        //            m_name =
        //                m_type = string.Empty;
        //        }
        //        else
        //        {
        //            m_type = XmlConvert.DecodeName(attr.Name);
        //            m_name = attr.Value;
        //        }
        //    }
        //}

        //[XmlIgnore]
        //public string m_type;
        //[XmlIgnore]
        //public string m_name;
        [XmlIgnore]
        public Dictionary<string, string> m_attributes { get; set; }

        // parameterless constructor for XmlSerializer
        OwnedObjects() : this(string.Empty, string.Empty) { }

        public OwnedObjects(string _type, string _name)
        {
            //m_type = _type;
            //m_name = _name;
        }
    }

    public class ActionSchedule
    {
        [XmlAttribute("name")]
        public string m_name;

        ActionSchedule() : this(string.Empty) { }
        public ActionSchedule(string _name)
        {
            m_name = _name;
        }
    }
}
