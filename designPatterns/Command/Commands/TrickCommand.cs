using System;

namespace designPatterns.Command.Commands
{
    public class TrickCommand : ICommand
    {
        private ICharacter character;

        public TrickCommand(ICharacter character)
        {
            this.character = character;
        }

        public void ExcuteCommand()
        {
            if (character.MaxTrickNumber == 0)
            {
                Console.WriteLine("執行失敗!此角色已經無法使用絕招!");
                return;
            }

            character.Trick();
        }

        public bool CheckCommand()
        {
            if (character.MaxTrickNumber == 0)
            {
                Console.WriteLine("請求失敗!此角色已經無法使用絕招!");
                return false;
            }

            return true;
        }
    }
}
