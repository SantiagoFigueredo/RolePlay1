using System.Collections.Generic;

public class LibroDeHechizos
{
    // Atributos
    public List<Hechizo> Hechizos { get; set; }
    public string Nombre { get; }

    // Constructor
    public LibroDeHechizos(string nombre)
    {
        Hechizos = new List<Hechizo>();
        Nombre = nombre;
    }

    // Método para agregar un hechizo al libro
    public void AgregarHechizo(Hechizo hechizo)
    {
        Hechizos.Add(hechizo);
    }

    // Método para eliminar un hechizo del libro
    public void EliminarHechizo(Hechizo hechizo)
    {
        Hechizos.Remove(hechizo);
    }

    public bool ContieneHechizo(Hechizo hechizo)
    {
        return Hechizos.Contains(hechizo);
    }

    // Método para obtener la lista de hechizos del libro
    public List<Hechizo> ObtenerHechizos()
    {
        return Hechizos;
    }
}
