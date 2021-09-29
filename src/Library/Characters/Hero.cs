namespace RoleplayGame
{
    public class Hero : Character
    {
        public Hero(string name) : base(name){

        }
        int VictoryPoints = 0;

        public int Victory_Points
        {
            get
            {
                return VictoryPoints;
            }
        }

        //metodo que aumenta los puntos de victoria de un personaje
        public void PuntosGanados(int puntos)
        {
            this.VictoryPoints += puntos;
        }
    }
}