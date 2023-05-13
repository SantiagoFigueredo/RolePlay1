public class Enano : Personaje
{
    // Atributos adicionales de Enano
    public int Resistencia { get; set; }

    // Constructor de Enano
    public Enano(string nombre, int vida, int ataquePorDefecto, int resistencia) : base(nombre, vida, ataquePorDefecto)
    {
        Resistencia = resistencia;
        Vida += Resistencia / 2; // Agregar la mitad de la resistencia a la vida del enano
    }

    // Métodos adicionales de Enano (si es necesario)
    // ...
}
