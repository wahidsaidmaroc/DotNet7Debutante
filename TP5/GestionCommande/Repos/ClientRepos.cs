
using DAL.Data;
using DAL.Models;
using Dto;

namespace Repos;

public class ClientRepos
{
    FormationOumdinAcademyContext db = new FormationOumdinAcademyContext();
    public void Create(Client dto)
    {

        var client = new TClient()
        {
            Adresse = dto.Adresse,
            Id = dto.Id,
            Client = dto.Nom
        };
        db.TClient.Add(client);
        db.SaveChanges();
    }

    public  int LastId()
    {
        return db.TClient.Max(x => x.Id);
    }


    public bool verifierClient(string nom)
    {
        var client = db.TClient.Where(a => a.Client == nom).FirstOrDefault();
        if (client == null) { return false; } else return true;
    }

}
