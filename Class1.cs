using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using System.IO;

namespace Behaviour_Editor
{
    public class Class1
    {
        public void SerializeTest(string filePath)
        {
            // serialize
            Npc testNPC = new Npc();
            testNPC.name = "JoeTheDayGuard";
            testNPC.pos.x = -16;
            testNPC.pos.y = 25;
            testNPC.facing.x = 1;
            testNPC.facing.y = 0;
            testNPC.colour.r =
                testNPC.colour.g =
                testNPC.colour.b = 0;
            testNPC.colour.a = 255;
            testNPC.objectOwned = new List<string>(new string[] { "JoeBed" });
            //testNPC.actionSchedule = "DayGuard";

            XmlSerializer serializer = new XmlSerializer(typeof(Npc));
            XmlWriterSettings xmlSettings = new XmlWriterSettings();
            xmlSettings.Indent = true;
            xmlSettings.OmitXmlDeclaration = true;

            FileStream xmlStream = new FileStream(filePath, FileMode.Create);
            XmlWriter xmlWriter = XmlWriter.Create(xmlStream, xmlSettings);

            serializer.Serialize(xmlWriter, testNPC, testNPC.NameSpaces);
        }
    }

    public class Npc
    {
        [XmlAttribute("Name")]
        public string name{ get; set; }
        [XmlElement("Shape")]
        public Vector2 pos { get; set; }
        [XmlElement("Facing")]
        public Vector2 facing { get; set; }
        [XmlElement("Color")]
        public Colour colour { get; set; }
        [XmlElement("ObjectOwnership")]
        public List<string> objectOwned { get; set; }
        [XmlElement("InitialSchedule")]
        public string actionSchedule { get; set; }

        private XmlSerializerNamespaces _namespace;

        public Npc()
        {
            pos = new Vector2();
            facing = new Vector2();
            colour = new Colour();

            this._namespace = new XmlSerializerNamespaces(new XmlQualifiedName[] { new XmlQualifiedName(string.Empty, "urn:Objects") });
        }

        [XmlNamespaceDeclarations]
        public XmlSerializerNamespaces NameSpaces
        {
            get { return this._namespace; }
        }
    }

    public class Vector2
    {
        [XmlAttribute]
        public decimal x;
        [XmlAttribute]
        public decimal y;
    }

    public class Colour
    {
        [XmlAttribute]
        public int r;
        [XmlAttribute]
        public int g;
        [XmlAttribute]
        public int b;
        [XmlAttribute]
        public int a;
    }
}
