public class Facture : IImprimable, IExportable
{
    public string Numero { get; set; }
    public decimal Montant { get; set; }

    public Facture(string numero, decimal montant)
    {
        Numero = numero;
        Montant = montant;
    }

    public void Imprimer()
    {
        Console.WriteLine($"Impression de la facture n°{Numero} ({Montant:F2} €)");
    }

    public void Exporter(string fichier)
    {
        Console.WriteLine($"Export de la facture n°{Numero} vers : {fichier}");
    }
}