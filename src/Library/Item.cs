public class Item
{
    // Atributos
    public string Nombre { get; set; }
    public string Tipo { get; set; }
    public int Ataque { get; set; }
    public int Defensa { get; set; }

    // Constructor
    public Item(string nombre, string tipo, int ataque, int defensa)
    {
        Nombre = nombre;
        Tipo = tipo;
        Ataque = ataque;
        Defensa = defensa;
    }
}
