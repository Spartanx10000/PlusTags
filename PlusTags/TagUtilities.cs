//--------------------------------------------------------------------------------------------------------------------
// Author: Carlos Daniel Angulo López (SpartanX10000)
// Project: PlusTag
// Class: TagUtilities.cs
// Description: This class contains the internal utilities of the library.
//--------------------------------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace PlusTags.Standard
{
   internal class TagUtilities
    {
        private static string _basePath = System.AppDomain.CurrentDomain.BaseDirectory;

        /// <summary>
        /// Retrieve the list of tags from the xml file.
        /// </summary>
        internal static List<Tag> GetTags()
        {
            Tags info;
            try
            {
                string filePath = _basePath + "Tags.xml";
                if (!File.Exists(filePath))
                {
                    CreateBaseXmlFile();
                }
                XmlSerializer s = new XmlSerializer(typeof(Tags));
                using (StreamReader sr = new StreamReader(filePath))
                {
                    info = (Tags)s.Deserialize(sr);
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            return info.Tag;
        }

        /// <summary>
        /// Create the base xml file for the tags.
        /// </summary>
        internal static void CreateBaseXmlFile()
        {
            try
            {
                XmlDocument xmlFile = new XmlDocument();
                XmlNode xmlDecl = xmlFile.CreateXmlDeclaration("1.0", "UTF-8", String.Empty);
                xmlFile.AppendChild(xmlDecl);
                XmlNode tagsNode = xmlFile.CreateElement("tags");
                xmlFile.AppendChild(tagsNode);
                XmlNode tagNode = xmlFile.CreateElement("tag");
                XmlAttribute tagAttribute = xmlFile.CreateAttribute("id");
                tagAttribute.Value = "01";
                tagNode.Attributes.Append(tagAttribute);
                tagsNode.AppendChild(tagNode);
                XmlNode valueNode = xmlFile.CreateElement("value");
                valueNode.AppendChild(xmlFile.CreateTextNode("Hello World"));
                tagNode.AppendChild(valueNode);
                xmlFile.Save(_basePath + "Tags.xml");
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
