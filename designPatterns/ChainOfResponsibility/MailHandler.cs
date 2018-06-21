using System;

namespace designPatterns.ChainOfResponsibility
{
    public abstract class MailHandler
    {
        // 每個處理郵件類別都要記錄下一個
        // 能處理的人是誰
        protected MailHandler mailHandler;

        public MailHandler(MailHandler mailHandler)
        {
            this.mailHandler = mailHandler;
        }

        public void handleMail(Mail mail)
        {
            if (IsTaskResponsibility(mail))
            {
                this.TaskAction(mail);
            }
            else
            {
                this.toNext(mail);
            }
        }

        protected void toNext(Mail mail)
        {
            if (mailHandler != null)
            {
                mailHandler.handleMail(mail);
            }
            else
            {
                Console.WriteLine("已結束");
            }
        }
        
        protected abstract void TaskAction(Mail mail);
        protected abstract bool IsTaskResponsibility(Mail mail);
    }
}
