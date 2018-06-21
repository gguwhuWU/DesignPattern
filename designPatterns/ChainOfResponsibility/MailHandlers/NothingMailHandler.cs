using System;

namespace designPatterns.ChainOfResponsibility.MailHandlers
{
    public class NothingMailHandler : MailHandler
    {
        public NothingMailHandler(MailHandler mailHandler) : base(mailHandler)
        {
        }

        protected override bool IsTaskResponsibility(Mail mail)
        {
            return mail.MailType == MailType.Nothing;
        }

        protected override void TaskAction(Mail mail)
        {
            Console.WriteLine($"把信:{mail.Id} 放入不用處理區");
        }
    }
}
