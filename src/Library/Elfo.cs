public class Elfo : Personaje
{
    // Constructor de Elfo
    public Elfo(string nombre, int vida, int ataque) : base(nombre, vida, ataque)
    {
    }

    // Método adicional de Elfo para curar a otro personaje
    public void Curar(Personaje personaje)
    {
        personaje.RestaurarVida();
    }
}
