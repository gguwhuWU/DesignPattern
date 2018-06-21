using designPatterns.ChainOfResponsibility.MailHandlers;

namespace designPatterns.ChainOfResponsibility
{
    /// <summary>
    /// 責任鏈
    /// 打破 switch case / if else
    /// 範例參考來源:
    /// 大話設計模式
    /// http://corrupt003-design-pattern.blogspot.com/2017/01/chain-of-responsibility-pattern.html
    /// https://dotblogs.com.tw/hatelove/archive/2012/04/09/refactoring-replace-switch-case-with-chain-of-responsibility-pattern.aspx
    /// </summary>
    public class ChainOfResponsibilityExample : IPatternExample
    {
        public void DoWork()
        {
            MailHandler handler = 
                      new TrashMailHandler(
                      new ComplainMailHandler(
                      new NothingMailHandler(
                      new ApperciationMailHandler(
                      new PendMailHandler(null)))));

            Mail mail1 = new Mail { MailType = MailType.Trash };
            Mail mail2 = new Mail { MailType = MailType.Complain };
            Mail mail3 = new Mail { MailType = MailType.Apperciation };
            Mail mail4 = new Mail { MailType = MailType.Pend , Recipient="小陳"};
            Mail mail5 = new Mail { MailType = MailType.Nothing };

            handler.handleMail(mail1);
            handler.handleMail(mail2);
            handler.handleMail(mail3);
            handler.handleMail(mail4);
            handler.handleMail(mail5);
        }
    }
}
