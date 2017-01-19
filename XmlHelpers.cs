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

        public List<Npc> DeserialzeXML(string filePath, List<Npc>Npcs)
        {
            XmlSerializer serializer = new XmlSerializer(Npcs.GetType(), new XmlRootAttribute("Npcs"));

            FileStream xmlStream = new FileStream(filePath, FileMode.Open);

            try
            {
                Npcs = (List<Npc>)serializer.Deserialize(xmlStream);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.GetType().FullName);
                Console.WriteLine(ex.Message);
            }

            return Npcs;
        }
    }
}
