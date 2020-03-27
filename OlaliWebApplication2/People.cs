using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OlaliWebApplication2
{
    public class People
    {
        string count;
        string next;
        string previous;
        private List<Person> results;
            
        public List<Person> Results { get => results; set => results = value; }
        public string Count { get => count; set => count = value; }
        public string Next { get => next; set => next = value; }
        public string Previous { get => previous; set => previous = value; }
    }
}