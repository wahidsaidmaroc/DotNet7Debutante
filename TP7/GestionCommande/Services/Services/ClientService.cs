using DAL.Models;
using Repos;
using Services.Contract;

namespace Services.Services;

public class ClientService : BaseService, IClientService
{
    private readonly IRepository<TClient> _clientRepo;

    public ClientService(
           IRepository<TClient> clientRepo,
           IUnitOfWork unitOfWork) : base(unitOfWork)
    {
        _clientRepo = clientRepo;
    }


    public async Task<int> Create(TClient obj)
    {

        _clientRepo.Add(obj);
        await UnitOfWork.SaveChangeAsync();
        return obj.Id;
    }

    public async Task<List<TClient>> GetList()
    {
        return await _clientRepo.GetAsync();
    }

}
