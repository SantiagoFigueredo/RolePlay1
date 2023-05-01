public class Enano
{
    public string Nombre { get; set; }
    public int Vida { get; set; }
    public int Ataque { get; set; }
    public int Defensa { get; set; }
    public List<Elemento> Items { get; set; }

    public Enano(string nombre, int vida, int ataque, int defensa)
    {
        Nombre = nombre;
        Vida = vida;
        Ataque = ataque;
        Defensa = defensa;
        Items = new List<Elemento>();
    }

    public void Equipar(Elemento item)
    {
        if (item != null)
        {
            if (item.Tipo == TipoElemento.Armadura)
            {
                // Si el enano ya tiene una armadura equipada, la desequipa.
                Elemento armaduraEquipada = Items.FirstOrDefault(i => i.Tipo == TipoElemento.Armadura);
                if (armaduraEquipada != null)
                {
                    Items.Remove(armaduraEquipada);
                }
            }

            Items.Add(item);
            Ataque += item.Ataque;
            Defensa += item.Defensa;
        }
    }

    public void Desequipar(Elemento item)
    {
        if (item != null && Items.Contains(item))
        {
            Items.Remove(item);
            Ataque -= item.Ataque;
            Defensa -= item.Defensa;
        }
    }

    public int GetValorTotalAtaque()
    {
        int valorAtaque = Ataque;
        foreach (Elemento item in Items)
        {
            valorAtaque += item.Ataque;
        }
        return valorAtaque;
    }

    public int GetValorTotalDefensa()
    {
        int valorDefensa = Defensa;
        foreach (Elemento item in Items)
        {
            valorDefensa += item.Defensa;
        }
        return valorDefensa;
    }

    public void Atacar(Personaje personaje)
    {
        if (personaje != null)
        {
            int valorAtaqueEnano = GetValorTotalAtaque();
            int valorDefensaPersonaje = personaje.GetValorTotalDefensa();
            int danio = valorAtaqueEnano - valorDefensaPersonaje;
            if (danio > 0)
            {
                personaje.Vida -= danio;
            }
        }
    }

    public void Curar()
    {
        Vida = VidaInicial;
    }
}
