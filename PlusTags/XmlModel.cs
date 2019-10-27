//--------------------------------------------------------------------------------------------------------------------
// Author: Carlos Daniel Angulo López (SpartanX10000)
// Project: PlusTag
// Class: XmlModel.cs
// Description: This class contains the necessary classes to deserialize the XML file containing the tag information.
//--------------------------------------------------------------------------------------------------------------------

using System.Collections.Generic;
using System.Xml.Serialization;

namespace PlusTags.Standard
{
    /// <summary>
    /// Represents the collection of tags.
    /// </summary>
    [XmlRoot(ElementName = "tags")]
    public class Tags
    {
        [XmlElement(ElementName = "tag")]
        public List<Tag> Tag { get; set; }
    }

    /// <summary>
    /// Represents a tag.
    /// </summary>
    [XmlRoot(ElementName = "tag")]
    public class Tag
    {
        [XmlElement(ElementName = "value")]
        public List<Value> Value { get; set; }
        [XmlAttribute(AttributeName = "id")]
        public string Id { get; set; }
    }

    /// <summary>
    /// Represents a value of the tag.
    /// </summary>
    [XmlRoot(ElementName = "value")]
    public class Value
    {
        [XmlAttribute(AttributeName = "language")]
        public string Language { get; set; }
        [XmlText]
        public string Text { get; set; }
    }
}
