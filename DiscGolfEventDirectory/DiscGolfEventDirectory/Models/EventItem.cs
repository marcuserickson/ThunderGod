using System;
using System.Collections.Generic;
using System.Text;
//using SQLite;

namespace DiscGolfEventDirectory
{
    class EventItem
    {
        public EventItem()
        {
        }
  //      [PrimaryKey, AutoIncrement]
        public int id { get; set; }

        public string Name { get; set; }

        public string Type { get; set; }

        public DateTime Date { get; set; }

        public string Address { get; set; }

        public string Information { get; set; }
    }
}
