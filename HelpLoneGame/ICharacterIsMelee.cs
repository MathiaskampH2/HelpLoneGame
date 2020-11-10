namespace HelpLoneGame
{
    /// <summary>
    /// Interface ICharacterIsMelee
    /// Has method that only a character that uses melee would have
    /// </summary>
    interface ICharacterIsMelee
    {
        void Bash();
        void Cleave();
        void Slash();
    }
}