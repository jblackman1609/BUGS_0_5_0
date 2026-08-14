using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace BUGS.Models
{
    public class ContractViewModel
    {
        //Dropdown menus
        public List<string> BondTypes
        {
            get => new List<string> { "2 year Bond", "10 year Bond" };
        }

        public List<string> PropertyDescriptions
        {
            get => new List<string> { "Residential", "Commercial", "Church" };
        }

        public List<string> ContractPrices
        {
            get => new List<string>
            {
                "100",
                "120",
                "140",
                "150",
                "200",
                "250"
            };
        }

        public List<string> RenewalFees
        {
            get => new List<string>
            {
                "100",
                "120",
                "140",
                "150",
                "200",
                "250"
            };
        }

        public List<string> TransferFees
        {
            get => new List<string>
            {
                "100",
                "120",
                "140",
                "150",
                "200",
                "250"
            };
        }

        //SelectedItems
        public string PropertyDesc { get; set; } = string.Empty;
        public string BondType { get; set; } = string.Empty;
        public string ContractPrice { get; set; } = string.Empty;
        public string RenewalFee { get; set; } = string.Empty;
        public string TransferFee { get; set; } = string.Empty;

        //Text Boxes
        public string StreetAddress { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;
        public string State { get; set; } = string.Empty;
        public string ZipCode { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public string Phone { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string PurchStreetAddress { get; set; } = string.Empty;
        public string PurchCity { get; set; } = string.Empty;
        public string PurchState { get; set; } = string.Empty;
        public string PurchZipCode { get; set; } = string.Empty;

        //Date Pickers
        public DateTime EffectiveDate { get; set; }
        public DateTime ThroughDate { get; set; }

        //List for Grid
        public List<Contract> Contracts { get; set; } = new();
    }
}