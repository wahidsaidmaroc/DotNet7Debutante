
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


    public List<ProduitWithCategorie> GetListeProduitWithCategorie()
    {
        var Produit1 = GetProduitsStatic().Where(i => i.Id == 1).FirstOrDefault();
        var Produit2 = GetProduitsStatic().Where(i => i.Id == 2).FirstOrDefault();
        var Produit3 = GetProduitsStatic().Where(i => i.Id == 3).FirstOrDefault();
        var Produit4 = GetProduitsStatic().Where(i => i.Id == 4).FirstOrDefault();
        var Produit5 = GetProduitsStatic().Where(i => i.Id == 5).FirstOrDefault();


        var list = new List<ProduitWithCategorie>();
        list.Add(new ProduitWithCategorie() { Id = 1, IdCategorie = 1, IdProduit = 1 , Produit = Produit1 });
        list.Add(new ProduitWithCategorie() { Id = 2, IdCategorie = 1, IdProduit = 2, Produit = Produit2 });
        list.Add(new ProduitWithCategorie() { Id = 3, IdCategorie = 3, IdProduit = 3, Produit = Produit3 });
        list.Add(new ProduitWithCategorie() { Id = 4, IdCategorie = 2, IdProduit = 4, Produit = Produit4 });
        list.Add(new ProduitWithCategorie() { Id = 5, IdCategorie = 2, IdProduit = 5, Produit = Produit5 });



        return list;

    }
}
