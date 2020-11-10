using System;

namespace HelpLoneGame
{
    /// <summary>
    /// Barbarian class
    /// Inherits from ICharacter and ICharacterIsMelee
    /// </summary>
    public class Barbarian: ICharacter, ICharacterIsMelee
    {
        public void Bash()
        {
            Console.WriteLine("I'm bashing someone");
        }

        public void Cleave()
        {
            Console.WriteLine("I'm cleaving someone");
        }

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


        public void Slash()
        {
            Console.WriteLine("I'm slashing someone");
        }

    }
}