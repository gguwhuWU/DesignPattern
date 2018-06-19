using System;
using System.Collections.Generic;

namespace designPatterns.Command
{
    /// <summary>
    /// 執行命令的物件 (receiver)
    /// </summary>
    public class Player
    {
        private IList<ICommand> commands = new List<ICommand>();
        private string name;

        public Player(string name)
        {
            this.name = name;
        }

        public void SetCommand(ICommand command)
        {
            if (command.CheckCommand())
            {
                commands.Add(command);
                Console.WriteLine($"玩家:{name}，發出 {command.ToString()} 命令");
            }
        }

        public void CancelCommand(ICommand command)
        {
            commands.Remove(command);
            Console.WriteLine($"玩家:{name}，取消 {command.ToString()} 命令");
        }

        public void Notify()
        {
            foreach(ICommand cmd in commands)
            {
                cmd.ExcuteCommand();
            }

            commands.Clear();
        }
    }
}
