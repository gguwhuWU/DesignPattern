using designPatterns.Interpreter.Expression;

namespace designPatterns.Interpreter
{
    /// <summary>
    /// 解譯器
    /// 範例參考來源:
    /// 大話設計模式
    /// http://corrupt003-design-pattern.blogspot.com/2017/01/interpreter-pattern.html
    /// 範例來源:
    /// https://xyz.cinc.biz/2013/08/interpreter-pattern.html
    /// </summary>
    public class InterpreterExample : IPatternExample
    {
        public void DoWork()
        {
            // 待解譯文字
            Context context = new Context();
            context.Text = "b2002 a2002 b2013 a2013 c2015 c2011";

            // 解譯器
            Expression.Expression expression = null;

            while (context.Text.Length > 0)
            {
                switch (context.Text.Substring(0, 1))
                {
                    case "a":
                        expression = new ZodiacExpression(); // 生肖
                        break;
                    case "b":
                        expression = new EarthlyBranchesExpression(); // 地支
                        break;
                    case "c":
                        expression = new AstrologicalSignExpression(); // 星座
                        break;
                }

                expression.Interpret(context);
            }
        }
    }
}
