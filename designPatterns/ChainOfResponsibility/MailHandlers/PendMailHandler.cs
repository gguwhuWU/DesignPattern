using System;

namespace designPatterns.ChainOfResponsibility.MailHandlers
{
    public class PendMailHandler : MailHandler
    {
        public PendMailHandler(MailHandler mailHandler) : base(mailHandler)
        {
        }

        protected override bool IsTaskResponsibility(Mail mail)
        {
            return mail.MailType == MailType.Pend;
        }

        protected override void TaskAction(Mail mail)
        {
            Console.WriteLine($"把信:{mail.Id} 放入待處理區，並通知收信者:{mail.Recipient}-快處理");
        }
    }
}
