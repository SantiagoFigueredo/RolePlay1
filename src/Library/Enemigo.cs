public class Enemigo : Personaje
{
    public int ValorPuntosVictoria { get; set; }

    public Enemigo(string nombre, int vida, int ataque, int valorPuntosVictoria) : base(nombre, vida, ataque)
    {
        ValorPuntosVictoria = valorPuntosVictoria;
    }

    public void Morir()
    {
        ValorPuntosVictoria = 0;
    }
}
