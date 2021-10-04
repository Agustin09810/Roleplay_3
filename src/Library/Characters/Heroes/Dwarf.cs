using System.Collections.Generic;
namespace RoleplayGame
{
    public class Dwarf: Hero
    {
        private int health = 100;

        public Dwarf(string name) : base(name)
        {
            this.Name = name;
            
            this.AddItem(new Axe());
            this.AddItem(new Helmet());
        }
    }
}