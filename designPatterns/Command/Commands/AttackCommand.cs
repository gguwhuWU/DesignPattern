namespace designPatterns.Command.Commands
{
    public class AttackCommand : ICommand
    {
        private ICharacter character;

        public AttackCommand(ICharacter character)
        {
            this.character = character;
        }

        public bool CheckCommand()
        {
            return true;
        }

        public void ExcuteCommand()
        {
            character.Attack();
        }
    }
}
