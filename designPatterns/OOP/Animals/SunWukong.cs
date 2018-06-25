namespace designPatterns.OOP.Animals
{
    public class SunWukong : Animal, IChange
    {
        protected override string ShoutSound
        {
            get
            {
                return "";
            }
        }

        public string ChangeThing(string thing)
        {
            return $"{base.name} ,我可以從身上的毛變出{thing}";
        }
    }
}
