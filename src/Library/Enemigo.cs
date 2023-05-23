public class Enemigo : Personaje
{
    public int ValorPuntosVictoria { get; set; }

    public Enemigo(string nombre, int salud, int fuerza, int defensa, int valorPuntosVictoria)
        : base(nombre, salud, fuerza, defensa)
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
