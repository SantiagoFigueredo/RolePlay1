public class Personaje
{
    public string Nombre { get; set; }
    public string Raza { get; set; }
    public int Nivel { get; set; }
    public int Salud { get; set; }
    public int Ataque { get; set; }
    public string Item { get; set; }

    public void Atacar(Personaje otroPersonaje)
    {
        int dano = this.Ataque - otroPersonaje.Item.Defensa;
        if (dano > 0)
        {
            otroPersonaje.Salud -= dano;
        }
    }

    public void Defender(int dano)
    {
        this.Salud -= dano;
    }
    public void{
        
    }
}
