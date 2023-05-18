using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace Calendar
{
    public class XMLDatabase
    {
        private string filePath;
        public Database Database { get; set; }

        public XMLDatabase(string filePath)
        {
            this.filePath = filePath;
            Database = new Database();
        }

        public void Load()
        {
            if (File.Exists(filePath))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(Database));

                using (StreamReader reader = new StreamReader(filePath))
                {
                    Database = (Database)serializer.Deserialize(reader);
                }
            }
        }

        public void Save()
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Database));

            using (StreamWriter writer = new StreamWriter(filePath))
            {
                serializer.Serialize(writer, Database);
            }
        }
    }

    [XmlRoot("CalendarDatabase")]
    public class Database
    {
        [XmlElement("Entry")]
        public List<DatabaseEntry> Entries { get; set; }

        public Database()
        {
            Entries = new List<DatabaseEntry>();
        }
    }

    public class DatabaseEntry
    {
        [XmlElement("Date")]
        public DateTime Date { get; set; }

        [XmlElement("Note")]
        public string Note { get; set; }
    }
}