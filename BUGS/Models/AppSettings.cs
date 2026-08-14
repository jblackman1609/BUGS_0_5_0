using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace BUGS.Models
{
    public class AppSettings
    {
        public WordSettings WordSettings { get; set; } = new(); 
    }

    public class WordSettings
    {
        public string CompanyName { get; set; } = string.Empty;
        public string CompanyAddress { get; set; } = string.Empty;
        public string CompanyPhone { get; set; } = string.Empty;
        public string BondStatement { get; set; } = string.Empty;
        public string ContractStatement { get; set; } = string.Empty;
        public PurchaserInfo PurchaserInfo { get; set; } = new();
    }

    public class PurchaserInfo
    {
        public string Name { get; set; } = string.Empty;
        public string Phone { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string StreetAddress { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;
        public string State { get; set; } = string.Empty;
        public string ZipCode { get; set; } = string.Empty;
    }
}