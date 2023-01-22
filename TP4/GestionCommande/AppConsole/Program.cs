


using Services;

ProduitService produitService = new ProduitService();   

var list = from a in produitService.GetListeProduitWithCategorie()
            where a.IdCategorie == 1
            orderby a.IdProduit
            select a;