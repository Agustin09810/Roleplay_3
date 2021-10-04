using System.Collections.Generic;
namespace RoleplayGame
{
    public class Orc: Enemy
    {
        private int health = 100;

        public Orc(string name) : base(name)
        {
            this.Name = name;

            this.AddItem(new Axe());
            this.AddItem(new Shield());
            this.AddItem(new Helmet());
            this.AddItem(new Armor());
        }
        
        public override int PuntosdeVictoria
        {
            get
            {
                return 3;
            }
        }
    }
}