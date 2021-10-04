using System.Collections.Generic;
using System;
using System.Linq; //Libreria usada para utilizar Where() en las listas
namespace RoleplayGame
{
    /// <summary> 
    /// Clase de los encuentros tipo combate
    /// </summary>

    public class CombatEncounter : IEncounter
    {
        public List<Character> Heroes {get; private set;}
        public List<Character> Enemies {get; private set;}
        
        public CombatEncounter(List<Character> heroes, List<Character> enemies)
        {
            this.Heroes = heroes;
            this.Enemies = enemies;
        }

        //metodo que devuelve una lista con los heroes vivos, utiliza Where() de la libreria System.Linq para filtrar 
        //a los que no cumplen con la condición "Muerto"
        public List<Character> AliveHeroes 
        {
            get
            {
                return Heroes.Where(heroe => !heroe.Muerto).ToList();
            }
        }

        public List<Character> AliveEnemies
        {
            get
            {
                return Enemies.Where(enemy => !enemy.Muerto).ToList();
            }
        }
        //en los metodos anteriores, se utiliza "=>", que es la representacion de la expresion lambda, la cual es metodo
        //sin nombre que sirve para sustituir a una instancia de delegado
        //un delegado es un TIPO que representa referencias a métodos con una lista de parámetros determinada y un tipo 
        //de valor devuelto. Se utilizan para pasar métodos como argumentos a otros métodos.
        //me pareció útil usarla acá, pues creo que es la manera más corta y eficiente de crear este método

        int indiceHeroe = 0;

        public void EnemyAttack()
        {
            foreach (var enemy in AliveEnemies)
            {
                if(AliveHeroes.Count > 0)
                {
                    var heroeAux = AliveHeroes[indiceHeroe];
                    heroeAux.ReceiveAttack(enemy.AttackValue);
                    if(heroeAux.Muerto)
                    {
                        Console.WriteLine("El héroe " + heroeAux.Name + "ha perecido en combate");
                    }
                    indiceHeroe++;
                    if (indiceHeroe >= AliveHeroes.Count)
                    {
                        indiceHeroe = 0;
                    }
                }
            }
        }

        public void HeroeAttack()
        {
            foreach (var heroe in AliveHeroes)
            {
                foreach(var enemy in AliveEnemies)
                {
                    enemy.ReceiveAttack(heroe.AttackValue);
                    if (enemy.Muerto)
                    {
                        Console.WriteLine("El villano " + enemy.Name + "ha por fin perecido en combate");
                        heroe.PuntosGanados(enemy.PuntosdeVictoria);
                    }
                }
            }
        }

        //metodo para la curacion de los heroes despues de haber conseguido 5 o mas VP
        public void Healing()
        {
            foreach (var heroe in Heroes)
            {
                while(heroe.PuntosdeVictoria >= 5)
                {
                    heroe.Cure();
                }
            }
        }

        public void DoEncounter()
        {
            while (AliveHeroes.Count > 0 && AliveEnemies.Count > 0)
            {
                EnemyAttack();
                HeroeAttack();
            }
            Healing();
        }
    }
}