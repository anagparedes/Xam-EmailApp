

using System;
using System.Collections.Generic;

namespace EmailApp.Models
{
    public class Mail
    {
        public Mail(string to, string from, string subject, string body, DateTime date)
        {
            To = to;
            From = from;
            Subject = subject;
            Body = body;
            Date = date;

        }

        public string To { get; set; }
        public string From { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
        public DateTime Date { get; set; }
      
        
    }
}
