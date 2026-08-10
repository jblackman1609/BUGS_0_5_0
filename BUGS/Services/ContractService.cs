using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BUGS.Data;
using Microsoft.EntityFrameworkCore;

namespace BUGS.Services
{
    public class ContractService
    {
        private readonly BUGSContext context;
    
        public ContractService() => context = new BUGSContext();

        public List<Contract> GetContractsAsync()
        {
            return context.Contracts.ToList();
        }

        public void AddContract(Contract contract)
        {
            context.Add(contract);
            context.SaveChanges();
        }
    }
}