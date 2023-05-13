public class Mago : Personaje
{
    // Atributos específicos del Mago
    public string BastonMagico { get; set; }
    public LibroDeHechizos LibroHechizos { get; set; }

    // Constructor
    public Mago(string nombre, int vida, int ataque, string bastonMagico) : base(nombre, vida, ataque)
    {
        BastonMagico = bastonMagico;
        LibroHechizos = new LibroDeHechizos();
    }

    // Método para lanzar un hechizo del libro de hechizos
    public void LanzarHechizo(Hechizo hechizo, Personaje personaje)
    {
        // Implementación a determinar
        // Aquí se podría definir la lógica para lanzar el hechizo contra el personaje
    }

    // Método para estudiar un nuevo hechizo y agregarlo al libro de hechizos
    public void EstudiarHechizo(Hechizo hechizo)
    {
        LibroHechizos.AgregarHechizo(hechizo);
    }
}
