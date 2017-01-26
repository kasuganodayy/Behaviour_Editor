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
        static public void SerializeObjects(string filePath, Objects objects)
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

        static public Objects DeserialzeObjects(string filePath, Objects objects)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Objects));

            try
            {
                FileStream xmlStream = new FileStream(filePath, FileMode.Open);

                objects = (Objects)serializer.Deserialize(xmlStream);
                xmlStream.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().FullName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return objects;
        }

        static public Scheduling DeserializeSchedules(string filePath, Scheduling scheduling)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Scheduling));

            try
            {
                FileStream xmlStream = new FileStream(filePath, FileMode.Open);

                scheduling = (Scheduling)serializer.Deserialize(xmlStream);
                xmlStream.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().FullName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return scheduling;
        }
    }
}
