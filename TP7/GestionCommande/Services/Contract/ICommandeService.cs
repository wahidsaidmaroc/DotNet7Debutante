using DAL.Models;

namespace Services.Contract
{
    public interface ICommandeService
    {
        List<Commande> GetList();

        Task<int> Create(Commande obj);
    }
}