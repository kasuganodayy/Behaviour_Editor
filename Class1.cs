using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Behaviour_Editor
{
    public class Class1
    {
        public void SerializeTest()
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
            testNPC.objectOwned = new List<string>(){
                new string();
            }
        }
    }

    public class Npc
    {
        [XmlAttribute("Name")]
        public string name{ get; set; }
        [XmlAttribute("Shape")]
        public Vector2 pos { get; set; }
        [XmlAttribute("Facing")]
        public Vector2 facing { get; set; }
        [XmlAttribute("Color")]
        public Colour colour { get; set; }
        [XmlAttribute("ObjectOwnership")]
        public List<string> objectOwned { get; set; }
        [XmlAttribute("InitialSchedule")]
        public string actionSchedule { get; set; }
    }

    public class Vector2
    {
        [XmlAttribute]
        public decimal x;
        public decimal y;
    }

    public class Colour
    {
        [XmlAttribute]
        public int r;
        public int g;
        public int b;
        public int a;
    }
}
