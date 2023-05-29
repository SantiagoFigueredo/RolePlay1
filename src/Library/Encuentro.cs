public class Encuentro
{
    private List<Personaje> heroes;
    private List<Personaje> enemigos;

    public Encuentro(List<Personaje> heroes, List<Personaje> enemigos)
    {
        this.heroes = heroes;
        this.enemigos = enemigos;
    }

    public void DoEncounter()
    {
        while (heroes.Count > 0 && enemigos.Count > 0)
        {
            AtacarEnemigos();
            AtacarHeroes();
        }

        CurarHeroes();
    }

    private void AtacarEnemigos()
    {
        for (int i = 0; i < enemigos.Count; i++)
        {
            Personaje enemigo = enemigos[i];

            if (heroes.Count == 1)
            {
                heroes[0].ReducirVida(enemigo.CalcularValorTotalAtaque());
            }
            else if (heroes.Count > i)
            {
                heroes[i].ReducirVida(enemigo.CalcularValorTotalAtaque());
            }
            else
            {
                heroes[i % heroes.Count].ReducirVida(enemigo.CalcularValorTotalAtaque());
            }
        }

        heroes.RemoveAll(heroe => heroe.Vida <= 0);
    }

    private void AtacarHeroes()
    {
        foreach (Personaje heroe in heroes)
        {
            foreach (Personaje enemigo in enemigos)
            {
                enemigo.ReducirVida(heroe.CalcularValorTotalAtaque());

                if (enemigo.Vida <= 0)
                {
                    heroe.AgregarPuntosVictoria(((Enemigo)enemigo).ValorPuntosVictoria);
                }
            }
        }

        enemigos.RemoveAll(enemigo => enemigo.Vida <= 0);
    }

    private void CurarHeroes()
    {
        foreach (Personaje heroe in heroes)
        {
            if (heroe.PuntosVictoria >= 5)
            {
                heroe.RestaurarVida(heroe);
            }
        }
    }
}
