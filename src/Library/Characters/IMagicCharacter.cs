namespace RoleplayGame
{
    public interface IMagicCharacter: ICharacter
    {
        void AddMagicalItem(IMagicalItem item);

        void RemoveMagicalItem(IMagicalItem item);
    }
}
