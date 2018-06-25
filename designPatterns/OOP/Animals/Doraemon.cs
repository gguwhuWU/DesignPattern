namespace designPatterns.OOP.Animals
{
    public class Doraemon : Cat, IChange
    {
        public string ChangeThing(string thing)
        {
            return $"{base.ShoutSound} ,我可以從口袋拿出{thing}";
        }
    }
}
