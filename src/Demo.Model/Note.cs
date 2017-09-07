using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using System.Xml.Serialization;

namespace Demo
{
    [DataContract]
    [Serializable]
    public class Note
    {
        [DataMember]
        [XmlAttribute("id")]
        public string Id { get; set; }

        [DataMember]
        [XmlAttribute("s")]
        public string Subject { get; set; }

        [DataMember]
        [XmlElement]
        public string Body { get; set; }

        [DataMember]
        [XmlAttribute("t")]
        public string Tags { get; set; }

        [DataMember]
        [XmlAttribute("by")]
        public string CreatedBy { get; set; }

        [DataMember]
        [XmlAttribute("at")]
        public DateTime CreatedAt { get; set; }

        [DataMember]
        [XmlAttribute("m")]
        public string MasterId { get; set; }

    }
}
