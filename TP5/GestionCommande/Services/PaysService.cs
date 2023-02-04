using Services;

ProduitService service = new ProduitService();

var list = service.GetProduitsStatic();


var listProduitNomId = (from a in service.GetProduitsStatic()
                  where a.NomProduit.Contains("PC Port")
                  select new {a.Id, a.NomProduit, etatObj = true ,dateCreation =DateTime.Now}).ToList();

var listParMethod = service.GetProduitsStatic()
                        .Where(i => i.NomProduit.Contains("Said"))
                        .Select(a => new { a.NomProduit, a.Id })
                        .ToList();



var listPCPortable = new List<Produit>();
foreach (var item in service.GetProduitsStatic())
{
	if (item.NomProduit.Contains("PC Portable"))
	{
        listPCPortable.Add(item);

    }
}