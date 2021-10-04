namespace RoleplayGame
{
    public class Hero : Character
    {
        public Hero(string name) : base(name){

        }
        int VictoryPoints = 0;

        public override int PuntosdeVictoria
        {
            get
            {
                return VictoryPoints;
            }
        }

        //metodo que aumenta los puntos de victoria de un personaje
        public override void PuntosGanados(int puntos)
        {
            this.VictoryPoints += puntos;
        }

        //en la parte 3, los héroes se curan al obtener 5 victory points
        public void Heal()
        {
            this.Cure();
            this.VictoryPoints -= 5;
        }
    }
}