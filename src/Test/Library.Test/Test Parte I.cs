using NUnit.Framework;
namespace Test.Library
{
public class PersonajeTests
{
    [SetUp]
    public void Setup()
    {
    }
    [Test]
    public void AgregarItem_AgregaItemAItems()
    {
        Personaje personaje = new Personaje("Nombre", 100, 10);
        Item item = new Item("Espada", "Arma", 5, 0);
        personaje.AgregarItem(item);
        Assert.AreEqual(1, personaje.Items.Count);
        Assert.AreEqual(item, personaje.Items[0]);
    }

    [Test]
    public void QuitarItem_QuitaItemDeItems()
    {
        Personaje personaje = new Personaje("Nombre", 100, 10);
        Item item = new Item("Espada", "Arma", 5, 0);
        personaje.AgregarItem(item);
        personaje.QuitarItem(item);
        Assert.AreEqual(0, personaje.Items.Count);
    }

    [Test]
    public void CalcularValorTotalAtaque_SumaAtaqueDePersonajeYItems()
    {
        Personaje personaje = new Personaje("Nombre", 100, 10);
        Item item1 = new Item("Espada", "Arma", 5, 0);
        Item item2 = new Item("Escudo", "Defensa", 0, 5);
        personaje.AgregarItem(item1);
        personaje.AgregarItem(item2);
        int valorTotalAtaque = personaje.CalcularValorTotalAtaque();
        Assert.AreEqual(15, valorTotalAtaque);
    }

    [Test]
    public void CalcularValorTotalDefensa_SumaVidaDePersonajeYDefensaDeItems()
    {
        Personaje personaje = new Personaje("Nombre", 100, 10);
        Item item1 = new Item("Espada", "Arma", 5, 0);
        Item item2 = new Item("Escudo", "Defensa", 0, 5);
        personaje.AgregarItem(item1);
        personaje.AgregarItem(item2);
        int valorTotalDefensa = personaje.CalcularValorTotalDefensa();
        Assert.AreEqual(110, valorTotalDefensa);
    }

    [Test]
    public void Atacar_ReducesVidaDeObjetivo()
    {
        Personaje atacante = new Personaje("Atacante", 100, 10);
        Personaje objetivo = new Personaje("Objetivo", 100, 5);
        atacante.Atacar(objetivo);
        Assert.Less(objetivo.Vida, 100);
    }

    [Test]
    public void ReducirVida_ReducesVidaDePersonaje()
    {
        Personaje personaje = new Personaje("Nombre", 100, 10);
        personaje.ReducirVida(50);
        Assert.AreEqual(50, personaje.Vida);
    }

    [Test]
    public void RestaurarVida_VidaRestauradaAlValorInicial()
    {
        Personaje personaje = new Personaje("Nombre", 100, 10);
        personaje.ReducirVida(50);
        personaje.RestaurarVida(personaje);
        Assert.AreEqual(100, personaje.Vida);
    }
}
public class ElfoTests
{
    [Test]
    public void Curar_RestauraVidaDePersonaje()
    {
        Elfo elfo = new Elfo("Nombre", 100, 10);
        Personaje personaje = new Personaje("Objetivo", 50, 5);
        elfo.RestaurarVida(personaje);
        Assert.AreEqual(100, personaje.Vida);
    }
}
public class EnanoTests
{
    [Test]
    public void Constructor_SumaMitadDeResistenciaALaVida()
    {
        Enano enano = new Enano("Nombre", 100, 10, 50);
        Assert.AreEqual(150, enano.Vida);
    }
}
public class MagoTests
{
    [Test]
    public void LanzarHechizo_HechizoExistente_LanzaHechizoAObjetivo()
    {
        Mago mago = new Mago("Mago", 100, 10, "Libro");
        Personaje objetivo = new Personaje("Objetivo", 100, 5);
        Hechizo hechizo = new Hechizo("Hechizo", 50);
        mago.EstudiarHechizo(hechizo);
        mago.LanzarHechizo(hechizo, objetivo);
        Assert.Less(objetivo.Vida, 100);
    }

    [Test]
    public void LanzarHechizo_HechizoNoExistente_NoLanzaHechizo()
    {
        Mago mago = new Mago("Mago", 100, 10, "Libro");
        Personaje objetivo = new Personaje("Objetivo", 100, 5);
        Hechizo hechizo = new Hechizo("Hechizo", 50);
        mago.LanzarHechizo(hechizo, objetivo);
        Assert.AreEqual(100, objetivo.Vida);
    }
    [Test]
    public void EstudiarHechizo_AgregaHechizoAlLibroDeHechizos()
    {
        Mago mago = new Mago("Mago", 100, 10, "Libro");
        Hechizo hechizo = new Hechizo("Hechizo", 50);
        mago.EstudiarHechizo(hechizo);

        Assert.IsTrue(mago.LibroDeHechizos.ContieneHechizo(hechizo));
    }
}
public class LibroDeHechizosTests
{
    [Test]
    public void AgregarHechizo_AgregaHechizoALibro()
    {
        LibroDeHechizos libro = new LibroDeHechizos("Libro");
        Hechizo hechizo = new Hechizo("Hechizo", 50);
        libro.AgregarHechizo(hechizo);
    }
}
}