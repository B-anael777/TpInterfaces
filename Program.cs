Facture facture = new Facture("FAC-2026-01", 100.00m, 0.20m);

// Utilisation en tant qu'IAffichable
IAffichable affichable = facture;
affichable.Afficher();

// Utilisation en tant qu'IPayable
IPayable payable = facture;
Console.WriteLine($"Montant à payer : {payable.ObtenirMontant():F2} €");