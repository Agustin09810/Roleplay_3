using System.Collections.Generic;
namespace RoleplayGame
{
    public class Knight: Hero
    {
        private int health = 100;
        
        public Knight(string name) : base(name)
        {
            this.Name = name;
            
            this.health = 100;
            this.AddItem(new Sword());
            this.AddItem(new Armor());
            this.AddItem(new Shield());
        }
    }
}