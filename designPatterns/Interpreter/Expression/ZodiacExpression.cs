using System;

namespace designPatterns.Interpreter.Expression
{
    /// <summary>
    /// 生肖解譯器
    /// </summary>
    public class ZodiacExpression : Expression
    {
        public override void Excute(int num)
        {
            string res = "";
            switch (num)
            {
                case 1:
                    res = "鼠";
                    break;
                case 2:
                    res = "牛";
                    break;
                case 3:
                    res = "虎";
                    break;
                case 4:
                    res = "兔";
                    break;
                case 5:
                    res = "龍";
                    break;
                case 6:
                    res = "蛇";
                    break;
                case 7:
                    res = "馬";
                    break;
                case 8:
                    res = "羊";
                    break;
                case 9:
                    res = "猴";
                    break;
                case 10:
                    res = "雞";
                    break;
                case 11:
                    res = "狗";
                    break;
                case 12:
                    res = "豬";
                    break;
            }

            Console.Write(res);
        }
    }
}
