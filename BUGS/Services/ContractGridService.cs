using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BUGS.Data;
using BUGS.Models;

namespace BUGS.Services
{
    public class ContractGridService
    {
        private readonly ContractRepository _repo;

        public ContractGridService(ContractRepository repo) => _repo = repo;

        public ContractViewModel GetContractGridView()
        {
            List<Contract> contracts = new();
            contracts = _repo.GetContracts();

            ContractViewModel view = new ContractViewModel()
            {
                Contracts = contracts
            };

            return view;
        }

        public ContractViewModel AddNewContractView()
        {
            return new ContractViewModel();
        }

        public void SaveContractView(ContractViewModel viewModel)
        {
            
        }
    }
}