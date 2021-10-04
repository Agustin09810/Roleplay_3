namespace RoleplayGame
{
    public class Dragon: Enemy
    {
        private int health = 1000;

        public Dragon(string name) : base(name)
        {
            this.Name = name;

            this.AddItem(new DragonClaw());
            this.AddItem(new DragonClaw());
            this.AddItem(new DragonScale());
        }
        
        public override int PuntosdeVictoria
        {
            get
            {
                return 20;
            }
        }
    }
}