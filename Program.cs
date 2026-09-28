Console.WriteLine("--- Commande de 40 € ---");
AfficherTotal(40m, new LivraisonStandard());
AfficherTotal(40m, new LivraisonExpress());
AfficherTotal(40m, new RetraitMagasin());

Console.WriteLine("\n--- Commande de 100 € ---");
AfficherTotal(100m, new LivraisonStandard());
AfficherTotal(100m, new LivraisonExpress());
AfficherTotal(100m, new RetraitMagasin());

Console.WriteLine("\n--- Évolution : Livraison Internationale ---");
AfficherTotal(40m, new LivraisonInternationale());

static void AfficherTotal(decimal montantCommande, ICalculLivraison calculLivraison)
{
    decimal frais = calculLivraison.Calculer(montantCommande);
    decimal total = montantCommande + frais;

    Console.WriteLine($"Commande : {montantCommande:F2} € | Frais : {frais:F2} € | Total : {total:F2} €");
}