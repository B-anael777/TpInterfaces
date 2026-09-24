// Utilisation du type IAffichable avec un Produit
IAffichable element = new Produit("Clavier", 49.90m);
element.Afficher();

// La même variable référence maintenant un Client
element = new Client("Alice", "alice@example.com");
element.Afficher();