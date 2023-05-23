using System;

public class Mago : Personaje
{
    // Atributos adicionales de Mago
    public LibroDeHechizos LibroDeHechizos { get; set; }

    // Constructor
    public Mago(string nombre, int vida, int ataque, LibroDeHechizos libroDeHechizos) : base(nombre, vida, ataque)
    {
        LibroDeHechizos = libroDeHechizos;
    }

    // Método para lanzar un hechizo a otro personaje
    public void LanzarHechizo(Hechizo hechizo, Personaje objetivo)
    {
        if (LibroDeHechizos.ContieneHechizo(hechizo))
        {
            hechizo.LanzarHechizo(objetivo);
        }
        else
        {
            Console.WriteLine($"El mago {Nombre} no puede lanzar el hechizo {hechizo.Nombre}.");
        }
    }

    // Método para estudiar un nuevo hechizo y agregarlo al libro de hechizos
    public void EstudiarHechizo(Hechizo hechizo)
    {
        LibroDeHechizos.AgregarHechizo(hechizo);
        Console.WriteLine($"El mago {Nombre} ha estudiado el hechizo {hechizo.Nombre}.");
    }
}
