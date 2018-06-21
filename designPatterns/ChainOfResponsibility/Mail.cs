using System;
using System.Collections.Generic;

namespace designPatterns.ChainOfResponsibility
{
    public class Mail
    {
        public Mail()
        {
            Id = Guid.NewGuid().ToString();
        }

        public string Id { get; set; }
        public string Title { get; set; }
        public string Sender { get; set; }
        public string Recipient { get; set; }
        public string Content { get; set; }
        public IList<string> AttachedFilePath { get; set; }
        public DateTime CreateTime { get; set; }
        public MailType MailType { get; set; }
    }
}
