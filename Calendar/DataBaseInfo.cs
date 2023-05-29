using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace Calendar
{
    public class JSONDatabase
    {
        private string filePath;
        public Database Database { get; set; }

        public JSONDatabase(string filePath)
        {
            this.filePath = filePath;
            Database = new Database();
        }

        public void Load()
        {
            if (File.Exists(filePath))
            {
                string json = File.ReadAllText(filePath);
                Database = JsonConvert.DeserializeObject<Database>(json);
            }
        }

        public void Save()
        {
            string json = JsonConvert.SerializeObject(Database, Formatting.Indented);
            File.WriteAllText(filePath, json);
        }
    }

    public class Database
    {
        public List<DatabaseEntry> Entries { get; set; }

        public Database()
        {
            Entries = new List<DatabaseEntry>();
        }
    }

    public class DatabaseEntry
    {
        public DateTime Date { get; set; }
        public string Note { get; set; }
    }
}