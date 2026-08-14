using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BUGS.Models
{
    public class Purchaser
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Phone { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string StreetAddress { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;
        public string State { get; set; } = string.Empty;
        public string ZipCode { get; set; } = string.Empty;
        public List<Contract> Contracts { get; set; } = new();
    }
}