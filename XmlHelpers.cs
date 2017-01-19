using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using System.IO;
using System.Windows.Forms;

namespace Behaviour_Editor
{
    public class XMLHelper
    {
        public void SerializeXML(string filePath, Objects objects)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Objects));
            XmlWriterSettings xmlSettings = new XmlWriterSettings();
            xmlSettings.Indent = true;
            xmlSettings.OmitXmlDeclaration = true;

            FileStream xmlStream = new FileStream(filePath, FileMode.Create);
            XmlWriter xmlWriter = XmlWriter.Create(xmlStream, xmlSettings);

            XmlSerializerNamespaces xmlNS = new XmlSerializerNamespaces(new XmlQualifiedName[] { new XmlQualifiedName(string.Empty, "urn:Objects") });

            serializer.Serialize(xmlWriter, objects, xmlNS);

            xmlStream.Close();
        }

        public Objects DeserialzeXML(string filePath, Objects objects)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Objects));

            FileStream xmlStream = new FileStream(filePath, FileMode.Open);

            try
            {
                objects = (Objects)serializer.Deserialize(xmlStream);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().FullName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            xmlStream.Close();

            return objects;
        }
    }
}
