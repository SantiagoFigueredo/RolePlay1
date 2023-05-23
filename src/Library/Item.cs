public class Item
{
    // Atributos
    public string Nombre { get; }
    public string Tipo { get; }
    public int Ataque { get; }
    public int Defensa { get; }

    // Constructor
    public Item(string nombre, string tipo, int ataque, int defensa)
    {
        Nombre = nombre;
        Tipo = tipo;
        Ataque = ataque;
        Defensa = defensa;
    }
}
