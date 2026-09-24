public class Facture : Document, IImprimable
{
    public decimal Montant { get; set; }

    public Facture(string titre, decimal montant) : base(titre)
    {
        Montant = montant;
    }

    public void Imprimer()
    {
        Console.WriteLine($"Impression du document '{Titre}' — Facture de {Montant:F2} €");
    }
}