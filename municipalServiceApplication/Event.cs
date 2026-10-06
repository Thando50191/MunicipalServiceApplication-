using System;

namespace MunicipalServiceApplication
{
    public class Event
    {
        public string Name { get; set; }
        public string Category { get; set; }
        public DateTime Date { get; set; }
        public string Location { get; set; }
        public string Description { get; set; }

        public Event(string name, string category, DateTime date, string location, string description)
        {
            Name = name;
            Category = category;
            Date = date;
            Location = location;
            Description = description;
        }

        public override string ToString()
        {
            return $"{Name} - {Category} - {Date:dd MMMM yyyy}";
        }
    }
}