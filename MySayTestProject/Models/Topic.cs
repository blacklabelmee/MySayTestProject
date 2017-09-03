using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MySayTestProject.Models
{
    public class Topic
    {
        public Topic()
        {
            feedBacks = new List<feedBack>();
        }
        public int id { get; set; }
        public string text { get; set; }
        public List<feedBack> feedBacks { get; set; }

    }
}