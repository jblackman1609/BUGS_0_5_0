using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace BUGS.Data
{
    public class ContractViewModel
    {
        public string Purchaser { get; set; } = string.Empty;
        public string Phone { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string CustStreetAdd { get; set; } = string.Empty;
        public string CustCity { get; set; } = string.Empty;
        public string CustState { get; set; } = string.Empty;
        public string CustZipCode { get; set; } = string.Empty;
        public string PropStreetAdd { get; set; } = string.Empty;
        public string PropCity { get; set; } = string.Empty;
        public string PropState { get; set; } = string.Empty;
        public string PropZipCode { get; set; } = string.Empty;
        public DateTime EffectiveDate { get; set; }
        public DateTime ThroughDate { get; set; }
        
        public string SelectedDescription { get; set; } = string.Empty;
        public string SelectedBondType { get; set; } = string.Empty;
        public string SelectedRenewalFee { get; set; } = string.Empty;
        public string SelectedContractPrice { get; set; } = string.Empty;
        public string SelectedTransferFee { get; set; } = string.Empty;

        public List<string> PropertyDescriptions { get; } = new List<string>
        {
            "Commercial", "Residential"
        };

        public List<string> BondTypes { get; } = new List<string>
        {
            "2 year Bond", "10 year Bond"
        };

        public List<string> RenewalFees { get; } = new List<string>
        {
            "100", "150", "200", "250"
        };

        public List<string> ContractPrices { get; } = new List<string>
        {
            "100", "150", "200", "250"
        };

        public List<string> TransferFees { get; } = new List<string>
        {
            "100", "150", "200", "250"
        };
    }
}