namespace Services;

public class PaysService
{

    public  Dictionary<Pays, List<string>> getPays()
    {
        var list = new Dictionary<Pays, List<string>>();
        list.Add(new Pays() { Id = 1, NomPays = "Maroc" }, new List<string>() { "Casa", "Rabat", "Fes" });
        list.Add(new Pays() { Id = 1, NomPays = "France" }, new List<string>() { "Paris", "Nanet"});
        list.Add(new Pays() { Id = 1, NomPays = "USA" }, new List<string>() { "Newyork"});
        list.Add(new Pays() { Id = 1, NomPays = "Japon"}, new List<string>() { "Tokoyo"});
        return list;
    }

}
