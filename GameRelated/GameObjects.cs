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

        [XmlIgnore]
        public Dictionary<string, string> m_attributes { get; set; }

        // parameterless constructor for XmlSerializer
        OwnedObjects() : this(string.Empty, string.Empty) { }

        public OwnedObjects(string _type, string _name)
        {
            // Obsolete: Left over from List<OwnedObjects> version. (Before GitHub "8a83b88" Commit)
            m_attributes = new Dictionary<string, string>()
            {
                {_type, _name }
            };
        }
    }

    [XmlType("GameObject")]
    public class GameObject
    {
        [XmlAttribute("name")]
        public string m_name { get; set; }
        [XmlAttribute("type")]
        public string m_type { get; set; }
        [XmlElement("Shape")]
        public Rect m_rect { get; set; }
        [XmlElement("Color")]
        public Colour m_colour { get; set; }
    }

    [Serializable, XmlRoot("Objects")]
    public class Objects // I'm gonna so regret this class name...
    {
        public List<GameObject> GameObjects { get; set; }
        public List<Npc> Npcs { get; set; }
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
