using System.Collections.Generic;
namespace RoleplayGame
{
    public class OrcArcher: Enemy
    {
        private int health = 100;

        public OrcArcher(string name) : base(name)
        {
            this.Name = name;

            this.AddItem(new OrcBow());
            this.AddItem(new Helmet());
        }
        
        public override int PuntosdeVictoria
        {
            get
            {
                return 2;
            }
        }
    }
}