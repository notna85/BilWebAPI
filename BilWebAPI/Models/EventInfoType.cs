using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BilWebAPI.Models
{
    public class EventInfoType
    {
        private string title;
        private string description;
        private int id;

        public string Title { get; set; }
        public string Description { get; set; }
        public int ID { get; set; }

        public EventInfoType()
        {

        }
        public EventInfoType(int id)
        {
            ID = id;
        }

        public EventInfoType(string title, string description, int id)
        {
            Title = title;
            Description = description;
            ID = id;
        }
    }
}