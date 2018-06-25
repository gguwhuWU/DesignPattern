using System.Collections.Generic;

namespace designPatterns.Visitor
{
    public class ObjectStructure
    {
        private List<IPerson> persons = new List<IPerson>();

        //增加元素物件
        public void Attach(IPerson person)
        {
            persons.Add(person);
        }

        //移除元素物件
        public void Detach(IPerson person)
        {
            persons.Remove(person);
        }

        //顯示
        public void Display(IAction visitor)
        {
            foreach (IPerson p in persons)
            {
                p.Accept(visitor);
            }
        }
    }
}
