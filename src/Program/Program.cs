using System;

class Program
{
    static void Main(string[] args)
    {
        // Creación de personajes y elementos
        Personaje mago = new Mago("Gandalf", 100, 50, "Bastón Mágico");
        Elfo elfo = new Elfo("Legolas", 80, 10);
        Enano enano = new Enano("Gimli", 120, 42, 50);
        Item bastonMagico = new Item("Bastón Mágico", "Arma", 50, 50);
        Item armadura = new Item("Armadura", "Defensa", 0, 50);

        // Asignar elementos a los personajes
        mago.AgregarItem(bastonMagico);
        elfo.AgregarItem(armadura);
        enano.AgregarItem(armadura);

        // Obtener valor total de ataque de un personaje
        int ataqueTotalMago = mago.CalcularValorTotalAtaque();
        int ataqueTotalElfo = elfo.CalcularValorTotalAtaque();
        int ataqueTotalEnano = enano.CalcularValorTotalAtaque();

        // Obtener valor total de defensa de un personaje
        int defensaTotalMago = mago.CalcularValorTotalDefensa();
        int defensaTotalElfo = elfo.CalcularValorTotalDefensa();
        int defensaTotalEnano = enano.CalcularValorTotalDefensa();

        // Atacar a un personaje
        mago.Atacar(enano);
        elfo.Atacar(enano);

        // Curar a un personaje
        elfo.Curar(enano);

        // Devolver los resultados
        string resultados = "Acciones realizadas:\n\n" +
                            $"Personaje 1: {mago.Nombre}\n" +
                            $"Personaje 2: {elfo.Nombre}\n" +
                            $"Personaje 3: {enano.Nombre}\n\n" +
                            $"Valor total de ataque de {mago.Nombre}: {ataqueTotalMago}\n" +
                            $"Valor total de ataque de {elfo.Nombre}: {ataqueTotalElfo}\n" +
                            $"Valor total de ataque de {enano.Nombre}: {ataqueTotalEnano}\n\n" +
                            $"Valor total de defensa de {mago.Nombre}: {defensaTotalMago}\n" +
                            $"Valor total de defensa de {elfo.Nombre}: {defensaTotalElfo}\n" +
                            $"Valor total de defensa de {enano.Nombre}: {defensaTotalEnano}\n\n" +
                            $"Vida actualizada de {enano.Nombre}: {enano.Vida}";

        Console.WriteLine(resultados);
    }
}
