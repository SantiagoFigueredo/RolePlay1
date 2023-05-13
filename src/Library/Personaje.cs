public class Personaje
{
    // Atributos
    public string Nombre { get; set; }
    public int Vida { get; set; }
    public int Ataque { get; set; }
    public List<Item> Items { get; set; }

    // Constructor
    public Personaje(string nombre, int vida, int ataque)
    {
        Nombre = nombre;
        Vida = vida;
        Ataque = ataque;
        Items = new List<Item>();
    }

    // Métodos
    public void AgregarItem(Item item)
    {
        Items.Add(item);
    }

    public void QuitarItem(Item item)
    {
        Items.Remove(item);
    }

    public int CalcularValorTotalAtaque()
    {
        int totalAtaque = ataque;
        foreach (Item item in Items)
        {
            totalAtaque += item.Ataque;
        }
        return totalAtaque;
    }

    public int CalcularValorTotalDefensa()
    {
        int totalDefensa = vida;
        foreach (Item item in Items)
        {
            totalDefensa += item.Defensa;
        }
        return totalDefensa;
    }

    public void ReducirVida(int cantidad)
    {
        Vida -= cantidad;
        if (Vida < 0)
        {
            Vida = 0;
        }
    }

    public void RestaurarVida()
    {
        // Restaurar la vida a su valor inicial (por ejemplo, vida = 100)
        Vida = 100;
    }
}
