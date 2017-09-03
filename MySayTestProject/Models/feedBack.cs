using System;

namespace MySayTestProject.Models
{
    public class feedBack
    {
        public int id { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public string userEmail { get; set; }
        public string addingDate { get; set; }
        public int topicId { get; set; }

    }
}