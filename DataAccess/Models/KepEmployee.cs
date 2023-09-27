using System.Collections.Generic;

namespace DataAccess.Models
{
    public class KepEmployee
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string AccountType { get; set; }
        public string RecoveryQuestion { get; set; }
        public string RecoveryAnswer { get; set; }
        public List<Citizen> RegisteredCitizens { get; set; }
    }
}
