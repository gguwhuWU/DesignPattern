using System;

namespace designPatterns.Command.Commands
{
    public class MoveFrontCommand : ICommand
    {
        private ICharacter character;
        private int distance;

        public MoveFrontCommand(ICharacter character, int distance)
        {
            this.character = character;
            this.distance = distance;
        }

        public void ExcuteCommand()
        {
            character.MoveFront(distance);
        }

        public bool CheckCommand()
        {
            if (character.MaxRange < distance)
            {
                Console.WriteLine($"請求失敗!此角色最多移動{character.MaxRange}步");
                return false;
            }

            return true;
        }
    }
}
