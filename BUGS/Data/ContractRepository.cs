

using BUGS.Models;

namespace BUGS.Data
{
    public class ContractRepository
    {
        private readonly BUGSContext context;

        public ContractRepository()
        {
            context = new BUGSContext();
        }

        public List<Contract> GetContracts()
        {
            return context.Contracts.ToList();
        }
    }
}