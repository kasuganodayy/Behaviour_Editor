using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Behaviour_Editor
{
    [XmlType("Npc")]
    public class Npc
    {
        [XmlAttribute("Name")]
        public string name { get; set; }
        [XmlElement("Shape")]
        public Vector2 pos { get; set; }
        [XmlElement("Facing")]
        public Vector2 facing { get; set; }
        [XmlElement("Color")]
        public Colour colour { get; set; }
        [XmlElement("ObjectOwnership")]
        public List<worldObjects> objectOwned { get; set; }
        [XmlElement("InitialSchedule")]
        public schedule actionSchedule { get; set; }

        //private XmlSerializerNamespaces _namespace;

        public Npc()
        {
            //this._namespace = new XmlSerializerNamespaces(new XmlQualifiedName[] { new XmlQualifiedName(string.Empty, "urn:Objects") });
        }

        //[XmlNamespaceDeclarations]
        //public XmlSerializerNamespaces NameSpaces
        //{
        //    get { return this._namespace; }
        //}
    }
}
