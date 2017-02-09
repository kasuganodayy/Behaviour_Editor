using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using System.Windows.Forms;

namespace Behaviour_Editor
{
    [XmlType("Npc")]
    public class Npc
    {
        [XmlAttribute("name")]
        public string m_name { get; set; }
        [XmlElement("Shape")]
        public Vector2 m_pos { get; set; }
        [XmlElement("Facing")]
        public Vector2 m_facing { get; set; }
        [XmlElement("Color")]
        public Colour m_colour { get; set; }
        [XmlElement("ObjectOwnership")]
        public OwnedObjects m_objectOwned { get; set; }
        [XmlElement("InitialSchedule")]
        public ActionSchedule m_actionSchedule { get; set; }

        public bool AddOwnership(string key, string value)
        {
            try
            {
                if (m_objectOwned?.m_attributes.ContainsKey(key) == false &&
                m_objectOwned?.m_attributes.ContainsValue(value) == false)
                {
                    m_objectOwned?.m_attributes.Add(key, value);
                }
                else
            if (m_objectOwned == null)
                {
                    m_objectOwned = new OwnedObjects(key, value);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
                return false;
            }

            return true;
        }
    }
}
