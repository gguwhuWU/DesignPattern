using System;

namespace designPatterns.ChainOfResponsibility.MailHandlers
{
    public class ComplainMailHandler : MailHandler
    {
        public ComplainMailHandler(MailHandler mailHandler) : base(mailHandler)
        {
        }

        protected override bool IsTaskResponsibility(Mail mail)
        {
            return mail.MailType == MailType.Complain;
        }

        protected override void TaskAction(Mail mail)
        {
            Console.WriteLine($"把信:{mail.Id} 放入抱怨區，並添加對應的回覆抱怨內容且回信");
        }
    }
}
