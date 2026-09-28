public class LivraisonStandard : ICalculLivraison
{
    public decimal Calculer(decimal montantCommande)
    {
        return montantCommande < 50m ? 5m : 0m;
    }
}