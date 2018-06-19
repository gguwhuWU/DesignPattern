using System;

namespace designPatterns.Command.Commands
{
    public class MoveBackCommand : ICommand
    {
        private ICharacter character;
        private int distance;

        public MoveBackCommand(ICharacter character, int distance)
        {
            this.character = character;
            this.distance = distance;
        }

        public void ExcuteCommand()
        {
            character.MoveBack(distance);
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
