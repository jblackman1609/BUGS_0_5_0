using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BUGS.Models
{
    public class Contract
    {
        public int Id { get; set; }
        public string PropertyDesc { get; set; } = string.Empty;
        public string BondType { get; set; } = string.Empty;
        public string StreetAddress { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;
        public string State { get; set; } = string.Empty;
        public string ZipCode { get; set; } = string.Empty;
        public DateTime EffectiveDate { get; set; }
        public DateTime ThroughDate { get; set; }
        public string ContractPrice { get; set; } = string.Empty;
        public string RenewalFee { get; set; } = string.Empty;
        public string TransferFee { get; set; } = string.Empty;
        //public int PurchaserId { get; set; }
        //public Purchaser Purchaser { get; set; } = new();
        public string Name { get; set; } = string.Empty;
        public string Phone { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string PurchStreetAddress { get; set; } = string.Empty;
        public string PurchCity { get; set; } = string.Empty;
        public string PurchState { get; set; } = string.Empty;
        public string PurchZipCode { get; set; } = string.Empty;
    }
}