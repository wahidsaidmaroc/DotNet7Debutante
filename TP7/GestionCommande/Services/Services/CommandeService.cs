using DAL.Models;
using Repos;
using Services.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Services
{
    public class CommandeService : BaseService, ICommandeService
    {
        private readonly IRepository<TBonCommande> _repo;

        public CommandeService(
               IRepository<TBonCommande> repo
          ,
           IUnitOfWork unitOfWork) : base(unitOfWork)
        {
            _repo = repo;
        }

        public List<Commande> GetList()
        {
            var list = from a in _repo.GetAsync().Result
                       select new Commande
                       {
                           Id = a.Id,
                           DateCommande = a.DateCommande,
                           TotalCommande = 0
                       };


            return list.ToList();
        }

        public async Task<int> Create(Commande obj)
        {
            var cmm =new TBonCommande()
            {
                DateCommande = obj.DateCommande ,
                EtatCommande = 0,
                IdClient = 4
            };
            _repo.Add(cmm);

            await UnitOfWork.SaveChangeAsync();
            return obj.Id;
        }

    }
}
