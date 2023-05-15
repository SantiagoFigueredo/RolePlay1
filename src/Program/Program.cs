using System;

class Program
{
    static void Main(string[] args)
    {
        // Creación de personajes y elementos
        Mago mago = new Mago("Gandalf", 100, 50, "Bastón Mágico");//Mica
        Elfo elfo = new Elfo("Legolas", 80, 10); //Rodri
        Enano enano = new Enano("Teemo", 120, 42, 60);//Santi
        Item bastonMagico = new Item("Bastón Mágico", "Arma Magica", 50, 50);
        Item cervatana = new Item("Cervatana", "Arma", 50, 0);//Santi
        Item cota = new Item("Cota de Espinas", "Ropaje", 0, 40);//Santi
        Item armadura = new Item("Armadura", "Ropaje", 0, 50);//Rodri
        Item tunica = new Item("Tunica", "Ropaje", 0, 50);//Mica
        Item arco = new Item("Arco", "Arma", 0, 50);//Rodri


        // Asignar elementos a los personajes
        mago.AgregarItem(bastonMagico);
        enano.AgregarItem(cota);
        enano.AgregarItem(cervatana);
        elfo.AgregarItem(armadura);
        

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

        //Verificar si el mago tiene un hechizo en su libro de hechizos 
        Hechizo Fuego = new Hechizo("Bola de Fuego", 100);
        mago.EstudiarHechizo(Fuego);
        mago.LanzarHechizo(Fuego, enano);

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
