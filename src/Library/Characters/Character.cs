using System.Collections.Generic;
namespace RoleplayGame

{
    public abstract class Character : ICharacter
    {
        public Character (string name)
        {
            this.Name = name;
        }


        public string Name {get; set;}

        private List<IItem> items = new List<IItem>();

        public int AttackValue 
        {
            get
            {
                int value = 0;
                foreach (IItem item in this.items)
                {
                   if (item is IAttackItem)
                    {
                        value += (item as IAttackItem).AttackValue;
                    }
                }
                return value;
            }
        }
         public int DefenseValue
        {
            get
            {
                int value = 0;
                foreach (IItem item in this.items)
                {
                    if (item is IDefenseItem)
                    {
                        value += (item as IDefenseItem).DefenseValue;
                    }
                }
                return value;
            }
        }
        public int Health
        {
            get
            {
                return this.Health;
            }
            private set
            {
                this.Health = value < 0 ? 0 : value;
            }
        }
        
        public void ReceiveAttack(int power)
        {   
            if (this.DefenseValue < power)
            {
                this.Health -= power - this.DefenseValue;
            }
        }

        public void Cure()
        {
            this.Health = 100;
        }

        public void AddItem(IItem item)
        {
            this.items.Add(item);
        }

        public void RemoveItem(IItem item)
        {
            this.items.Remove(item);
        }

    }
}