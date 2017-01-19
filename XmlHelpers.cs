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
    public class XMLHelper
    {
        public void SerializeXML(string filePath, List<Npc> Npcs)
        {
            // serialize
            //Npc testNPC = new Npc();
            //testNPC.name = "JoeTheDayGuard";
            //testNPC.pos.x = -16;
            //testNPC.pos.y = 25;
            //testNPC.facing.x = 1;
            //testNPC.facing.y = 0;
            //testNPC.colour.r =
            //    testNPC.colour.g =
            //    testNPC.colour.b = 0;
            //testNPC.colour.a = 255;
            //testNPC.objectOwned = new List<worldObjects>();
            //testNPC.objectOwned.Add(new worldObjects("bed", "JoeBed"));
            //testNPC.actionSchedule = new schedule();
            //testNPC.actionSchedule.name = "DayGuard";

            // Skip if no Npc present in List
            if(Npcs.Count <= 0)
            {
                return;
            }

            XmlSerializer serializer = new XmlSerializer(typeof(List<Npc>), new XmlRootAttribute("Npcs"));
            XmlWriterSettings xmlSettings = new XmlWriterSettings();
            xmlSettings.Indent = true;
            xmlSettings.OmitXmlDeclaration = true;

            FileStream xmlStream = new FileStream(filePath, FileMode.Create);
            XmlWriter xmlWriter = XmlWriter.Create(xmlStream, xmlSettings);

            XmlSerializerNamespaces xmlNS = new XmlSerializerNamespaces(new XmlQualifiedName[] { new XmlQualifiedName(string.Empty, "urn:Objects") });

            serializer.Serialize(xmlWriter, Npcs, xmlNS);
        }

        public void DeserialzeXML(string filePath, List<Npc>Npcs)
        {
            XmlSerializer serializer = new XmlSerializer(Npcs.GetType(), new XmlRootAttribute("Npcs"));
            XmlReaderSettings xmlSettings = new XmlReaderSettings();
            xmlSettings.CheckCharacters = false;

            FileStream xmlStream = new FileStream(filePath, FileMode.Open);
            

            Npcs = (List<Npc>)serializer.Deserialize(xmlStream);
        }
    }
}
