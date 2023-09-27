using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models
{
    public class Petition
    {
        public int PetitionId { get; set; }
        public string PetitionAlias { get; set; }
        public string PetitionType { get; set; }
        public string PetitionDate { get; set; }
        public string PetitionDescription { get; set; }
        //Pending, Accepted, Rejected
        public string PetitionStatus { get; set; }
        public string CitizenAfmOfPetition { get; set; }
    }
}
