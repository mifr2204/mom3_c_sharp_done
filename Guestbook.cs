using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using System.Text.Json;
using System.IO;

namespace mom3
{
    //guestbook class, manages a collection of GuestBookEntry
    internal class Guestbook
    {

        private List<GuestBookEntry>? _GuestBookEntries;

        //getter/setter for guestbook entries
        private List<GuestBookEntry> GuestBookEntries
        {
            get
            {
                if (_GuestBookEntries == null)
                {
                    return new List<GuestBookEntry>();
                }
                else
                {
                    return _GuestBookEntries;
                }
            }
            set
            {
                if (value == null)
                {
                    _GuestBookEntries = new List<GuestBookEntry>();
                }
                else
                {
                    _GuestBookEntries = value;
                }
            }
        }

        //constructor
        public Guestbook()
        {
            //if file does not exist, create it with an empty list of guestbook entries
            if (!File.Exists("data.json"))
            {
                this.Serialize();
            }

            //read from json file
            this.Deserialize();
        }

        //read from json file
        public void Deserialize()
        {
            //read file data.json
            StreamReader sr = new StreamReader("data.json");
            string json = sr.ReadToEnd();
            sr.Close();

            //try to deserialize file contents
            List<GuestBookEntry>? deserialized = JsonSerializer.Deserialize<List<GuestBookEntry>>(json);
            if (deserialized != null)
            {
                this.GuestBookEntries = deserialized;
            }
            
        }

        //save guestbook as serialized file
        public void Serialize()
        {
            //serialize GuestBookEntries as json
            string json = JsonSerializer.Serialize(this.GuestBookEntries);

            //save serialized data to file
            StreamWriter sw = new StreamWriter("data.json");
            sw.WriteLine(json);
            sw.Close();
        }

        //create a new guestbook entry
        public void addEntry(GuestBookEntry entry)
        {
            this.GuestBookEntries.Add(entry);

            //save the guestbook contents when a new entry is added
            this.Serialize();
        }

        //get a list of guestbook entries
        public List<GuestBookEntry> getEntries()
        {
            return this.GuestBookEntries;
        }

        //removes a guestbook entry
        public void removeEntry(GuestBookEntry entry)
        {
            this.GuestBookEntries.Remove(entry);

            //save the guestbook contents when an entry is removed
            this.Serialize();
        }
    }
}
