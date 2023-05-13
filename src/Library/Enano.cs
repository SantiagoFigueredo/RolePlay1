public class Enano : Personaje
{
    // Atributos adicionales de Enano
    public int Resistencia { get; }

    // Constructor de Enano
    public Enano(string nombre, int vida, int ataque, int resistencia) : base(nombre, vida, ataque)
    {
        Resistencia = (int)(Vida * 0.5); // Agregar la mitad de la resistencia a la vida del enano
    }
}
