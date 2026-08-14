using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BUGS.Models;

namespace BUGS.Data
{
    public class ContractRepository
    {
        private readonly BUGSContext _context;

        public ContractRepository(BUGSContext context) => _context = context;

        public void AddContract(Contract contract)
        {
            _context.Contracts.Add(contract);
            _context.SaveChanges();
        }

        public List<Contract> GetContracts()
        {
            return _context.Contracts.ToList();
        }
    }
}