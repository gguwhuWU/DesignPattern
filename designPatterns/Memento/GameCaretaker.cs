using System;
using System.Collections.Generic;
using System.Linq;

namespace designPatterns.Memento
{
    // Caretaker
    public class GameCaretaker
    {
        //這兩個欄位都要放在資料庫
        private Dictionary<string, GameMemento> mMementos;
        private int restoreNumber = 3;

        public GameCaretaker()
        {
            mMementos = new Dictionary<string, GameMemento>();
        }

        public GameMemento getMemento(string stateName)
        {
            if (!mMementos.ContainsKey(stateName))
            {
                Console.WriteLine($"讀檔失敗!{stateName}，並沒有這個檔名稱");
                return null;
            }

            return mMementos[stateName];
        }
        
        public void setMemento(string stateName, GameMemento memento)
        {
            if (mMementos.Count < restoreNumber)
            {
                AddState(stateName, memento);
            }
            else
            {
                Console.WriteLine($"已到達最大存檔次數:{restoreNumber},請充值最大次數");
            }
        }

        public void removeMemento(string stateName)
        {
            mMementos.Remove(stateName);
        }
        
        public void ShowMementos()
        {
            foreach(var state in this.getMementos())
            {
                Console.WriteLine(state);
            }
        }

        /****************************************************/
        private List<string> getMementos()
        {
            return mMementos.Keys.ToList();
        }

        private void AddState(string stateName, GameMemento memento)
        {
            if (!mMementos.ContainsKey(stateName))
            {
                mMementos.Add(stateName, memento);
            }
            else
            {
                Console.WriteLine($"存檔失敗!{stateName}已重複");
            }
        }
    }
}
