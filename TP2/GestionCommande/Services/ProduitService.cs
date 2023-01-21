
namespace Services;

public class ProduitService
{

    public List<Produit> GetProduitsStatic()
    {
        var listeProduit = new List<Produit>()
        { 
            new Produit() {Id = 1 , NomProduit = "PC Portable"},
            new Produit() {Id = 2 , NomProduit = "Ecran Dell 17 P"},
            new Produit() {Id = 3 , NomProduit = "Imprimante HP"},
            new Produit() {Id = 4 , NomProduit = "Scanner Epson"},
            new Produit() {Id = 5 , NomProduit = "GSM Motorola"},
            new Produit() {Id = 6 , NomProduit = "Clavier"},
        };

        return listeProduit;
    }

}
