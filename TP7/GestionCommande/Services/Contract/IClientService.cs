using DAL.Models;

namespace Services.Contract
{
    public interface IClientService
    {
        Task<int> Create(TClient obj);
        Task<List<TClient>> GetList();
    }
}