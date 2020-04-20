using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MyLeasing.Web.Data.Entityes
{
    public class Lessee
    {
        public int Id { get; set; }

       public User User { get; set; }

        public ICollection<Contract> Contracts { get; set; }
    }
}
