public class Facture : IAffichable, IPayable
{
    public string Numero { get; set; }
    public decimal MontantHT { get; set; }
    public decimal Tva { get; set; } // Exemple: 0.20 pour 20%

    public Facture(string numero, decimal montantHT, decimal tva)
    {
        Numero = numero;
        MontantHT = montantHT;
        Tva = tva;
    }

    public void Afficher()
    {
        Console.WriteLine($"Facture {Numero} - Total TTC : {ObtenirMontant():F2} €");
    }

    public decimal ObtenirMontant()
    {
        return MontantHT * (1 + Tva);
    }
}