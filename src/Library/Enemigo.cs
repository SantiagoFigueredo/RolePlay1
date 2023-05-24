public class Enemigo : Personaje
{
    public int ValorPuntosVictoria { get; set; }

    public Enemigo(string nombre, int vida, int ataque, int valorPuntosVictoria) : base(nombre, vida, ataque)
    {
        ValorPuntosVictoria = valorPuntosVictoria;
    }

    public override void Atacar(Personaje personaje)
    {
        // Implementación del ataque del enemigo al personaje
        // Aquí se pueden aplicar las reglas de combate específicas para los enemigos
    }

    public void Morir()
    {
        ValorPuntosVictoria = 0
    }
}
