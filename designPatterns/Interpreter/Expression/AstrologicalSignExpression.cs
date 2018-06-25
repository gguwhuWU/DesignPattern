using System;

namespace designPatterns.Interpreter.Expression
{
    /// <summary>
    /// 星座解譯器
    /// </summary>
    public class AstrologicalSignExpression : Expression
    {
        public override void Excute(int num)
        {
            string res = "";
            switch (num)
            {
                case 1:
                    res = "摩羯座";
                    break;
                case 2:
                    res = "水瓶座";
                    break;
                case 3:
                    res = "雙魚座";
                    break;
                case 4:
                    res = "牡羊座";
                    break;
                case 5:
                    res = "金牛座";
                    break;
                case 6:
                    res = "雙子座";
                    break;
                case 7:
                    res = "巨蟹座";
                    break;
                case 8:
                    res = "獅子座";
                    break;
                case 9:
                    res = "處女座";
                    break;
                case 10:
                    res = "天秤座";
                    break;
                case 11:
                    res = "天蠍座";
                    break;
                case 12:
                    res = "射手座";
                    break;
            }

            Console.Write(res);
        }
    }
}
