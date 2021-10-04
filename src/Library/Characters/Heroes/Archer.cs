using System.Collections.Generic;
namespace RoleplayGame
{
    public class Archer: Hero
    {
        private int health = 100;

        public Archer(string name) : base(name)
        {
            this.Name = name;
            
            this.AddItem(new Bow());
            this.AddItem(new Helmet());
        }

    }
}