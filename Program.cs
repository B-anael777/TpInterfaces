var produit = new Produit("Clavier", 49.90m);
var client = new Client("Alice", "alice@example.com");
var commande = new Commande(101, 150.00m);

List<IAffichable> elements = new List<IAffichable>
{
    produit,
    client,
    commande
};

foreach (var element in elements)
{
    element.Afficher();
}