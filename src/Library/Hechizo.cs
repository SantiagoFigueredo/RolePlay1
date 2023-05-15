using System;

public class Hechizo
{
    // Atributos
    public string Nombre { get; set; }
    public int Poder { get; set; }

    // Constructor
    public Hechizo(string nombre, int poder)
    {
        Nombre = nombre;
        Poder = poder;
    }

    // Método para lanzar el hechizo a otro personaje
    public void LanzarHechizo(Personaje objetivo)
    {
        objetivo.ReducirVida(Poder);
        Console.WriteLine($"El hechizo {Nombre} ha sido lanzado contra {objetivo.Nombre}. ¡Ha perdido {Poder} puntos de vida!");
    }
}
