namespace RoleplayGame
{
    //Debido a que la letra menciona que en el futuro habrá más de un
    //tipo de encuentro, decidí crear una Interfaz para estos sucesos
    //Por ahora, solo tendrá el método para iniciarlo
    public interface IEncounter
    {
        /// <summary>
        /// Método que da inicio al encuentro
        /// </summary>
        void DoEncounter();
    }
}