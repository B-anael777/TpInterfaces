var produit = new Produit("Clavier", 49.90m);
var client = new Client("Alice", "alice@example.com");
var commande = new Commande(101, 150.00m);

AfficherElement(produit);
AfficherElement(client);
AfficherElement(commande);

static void AfficherElement(IAffichable element)
{
    element.Afficher();
}