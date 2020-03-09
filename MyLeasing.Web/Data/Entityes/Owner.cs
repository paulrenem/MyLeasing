using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MyLeasing.Web.Data.Entityes
{
    public class Owner
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(30, ErrorMessage = "{0} no puede tener mas de {1} caracteres")]
        public string Document { get; set; }

        [Required]
        [MaxLength(50, ErrorMessage = "{0} no puede tener mas de {1} caracteres")]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(50, ErrorMessage = "{0} no puede tener mas de {1} caracteres")]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [MaxLength(20, ErrorMessage = "{0} no puede tener mas de {1} caracteres")]
        [Display(Name = "Fixed Phone")]
        public string FixedPhone { get; set; }

        [MaxLength(20, ErrorMessage = "{0} no puede tener mas de {1} caracteres")]
        [Display(Name = "Cell Phone")]
        public string CellPhone { get; set; }

        [MaxLength(80, ErrorMessage = "{0} no puede tener mas de {1} caracteres")]
        public string Adress { get; set; }

        [Display(Name ="Full Name")]
        public string FullName => $"{FirstName} {LastName}";

        public string FullNameWithDocument => $"{FirstName} {LastName} - {Document}";

        public ICollection<Property> Properties { get; set; }

        public ICollection<Contract> Contracts { get; set; }    

    }
}
