using System.Collections.Generic;
namespace RoleplayGame

{
    public abstract class Character : ICharacter
    {
        public Character (string name)
        {
            this.Name = name;
        }

        //para la parte 3, de encuentros, es necesario saber cuando el personaje está muerto
        public bool Muerto
        {
            get
            {
                return Health == 0;
            }
        }
        public abstract int PuntosdeVictoria {get;}

        public virtual void PuntosGanados(int puntos)
        {
        }

        public string Name {get; set;}

        protected List<IItem> items = new List<IItem>();

        public virtual int AttackValue 
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
         public virtual int DefenseValue
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
        public virtual int Health
        {
            get
            {
                return this.Health;
            }
            protected set
            {
                this.Health = value < 0 ? 0 : value;
            }
        }
        
        public virtual void ReceiveAttack(int power)
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