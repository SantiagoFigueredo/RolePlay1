using System.Collections.Generic;

public abstract class Personaje
{
    public string Nombre { get; private set; }
    public int Vida { get; protected set; }
    public int Ataque { get; private set; }
    public List<Item> Items { get; private set; }

    protected Personaje(string nombre, int vida, int ataque)
    {
        Nombre = nombre;
        Vida = vida;
        Ataque = ataque;
        Items = new List<Item>();
    }

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
        int totalAtaque = Ataque;
        foreach (Item item in Items)
        {
            totalAtaque += item.Ataque;
        }
        return totalAtaque;
    }

    public int CalcularValorTotalDefensa()
    {
        int totalDefensa = Vida;
        foreach (Item item in Items)
        {
            totalDefensa += item.Defensa;
        }
        return totalDefensa;
    }

    public void Atacar(Personaje objetivo)
    {
        int ataqueTotal = CalcularValorTotalAtaque();
        int defensaObjetivo = objetivo.CalcularValorTotalDefensa();

        int danio = ataqueTotal - defensaObjetivo;
        if (danio > 0)
        {
            objetivo.ReducirVida(danio);
        }
    }

    public void ReducirVida(int cantidad)
    {
        Vida -= cantidad;
        if (Vida < 0)
        {
            Vida = 0;
        }
    }

    public void RestaurarVida(Personaje objetivo)
    {
        Vida = objetivo.Vida + 100;
    }
}

