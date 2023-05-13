public class Hechizo
{
    // Atributos
    public string Nombre { get; set; }
    public string Tipo { get; set; }
    public string Poder { get; set; }

    // Constructor
    public Hechizo(string nombre, string tipo, string poder)
    {
        Nombre = nombre;
        Tipo = tipo;
        Poder = poder;
    }

    // Método para lanzar el hechizo contra otro personaje
    public void LanzarHechizo(Personaje personaje)
    {
        // Aca puedemos implementar la lógica del hechizo, por ejemplo,
        // reducir la vida del personaje objetivo en función del poder del hechizo.
        // o capaz podemos agregar funcionalidades diferente como por ejemplo el hechizo 'abadakadabra' que mate a un personaje
    }
}
