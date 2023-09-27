using System.Collections.Generic;

namespace DataAccess.Models
{
    public class Citizen
    {
        public string AFM { get; set; }
        public string AMKA { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string DateOfBirth { get; set; }
        public string Address { get; set; }
        public List<Petition> Petitions { get; set; }
    }
}
