using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BUGS.Data
{
    public class Contract
    {
        public int Id { get; set; }
        public string Purchaser { get; set; } = string.Empty;
        public string Phone { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string CustStreetAdd { get; set; } = string.Empty;
        public string CustCity { get; set; } = string.Empty;
        public string CustState { get; set; } = string.Empty;
        public string CustZipCode { get; set; } = string.Empty;
        public string PropDescription { get; set; } = string.Empty;
        public string BondType { get; set; } = string.Empty;
        public string PropStreetAdd { get; set; } = string.Empty;
        public string PropCity { get; set; } = string.Empty;
        public string PropState { get; set; } = string.Empty;
        public string PropZipCode { get; set; } = string.Empty;
        public DateTime EffectiveDate { get; set; }
        public DateTime ThroughDate { get; set; }
        public string ContractPrice { get; set; }= string.Empty;
        public string RenewalFee { get; set; } = string.Empty;
        public string TransferFee { get; set; } = string.Empty;
    }
}