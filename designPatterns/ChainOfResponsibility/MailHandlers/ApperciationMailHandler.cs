using System;

namespace designPatterns.ChainOfResponsibility.MailHandlers
{
    public class ApperciationMailHandler : MailHandler
    {
        public ApperciationMailHandler(MailHandler mailHandler) : base(mailHandler)
        {
        }

        protected override bool IsTaskResponsibility(Mail mail)
        {
            return mail.MailType == MailType.Apperciation;
        }

        protected override void TaskAction(Mail mail)
        {
            Console.WriteLine($"把信:{mail.Id} 放入感謝區，並添加對應的回覆感謝內容且回信");
        }
    }
}
