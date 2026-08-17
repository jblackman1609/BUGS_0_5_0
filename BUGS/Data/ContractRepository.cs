

using BUGS.Models;

namespace BUGS.Data
{
    public class ContractRepository
    {
        private readonly BUGSContext _context;

        public ContractRepository(BUGSContext context) => _context = context;

        public List<Contract> GetContracts()
        {
            return _context.Contracts.ToList();
        }
    }
}