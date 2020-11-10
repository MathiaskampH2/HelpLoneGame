using System;

namespace HelpLoneGame
{
    /// <summary>
    /// Class Wizard
    /// Inherits methods from ICharacter, ICharacterIsMagician, ICharacterCanCastMagicSpells
    /// </summary>
    public class Wizard : ICharacter, ICharacterIsMagician, ICharacterCanCastMagicSpells
    {
        public void Die()
        {
            Console.WriteLine("I'm dying");
        }

        public void Fight()
        {
            Console.WriteLine("I'm fighting");
        }

        public void Heal()
        {
            Console.WriteLine("I'm healing");
        }

        public void Teleport(int x, int y)
        {
            Console.WriteLine("I'm teleporting to " + x + " " + y);
        }

        public void ThrowFrostNova()
        {
            Console.WriteLine("I'm throwing my frost nova");
        }

        public void ThrowMagicMissile()
        {
            Console.WriteLine("I'm throwing a magic missile");
        }
    }
}