using System;

namespace designPatterns.ChainOfResponsibility.MailHandlers
{
    public class TrashMailHandler : MailHandler
    {
        public TrashMailHandler(MailHandler mailHandler) : base(mailHandler)
        {
        }

        protected override bool IsTaskResponsibility(Mail mail)
        {
            return mail.MailType == MailType.Trash;
        }

        protected override void TaskAction(Mail mail)
        {
            Console.WriteLine($"把信:{mail.Id} 放入垃圾區");
        }
    }
}
