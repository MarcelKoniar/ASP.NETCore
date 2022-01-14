using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Portfolio.Models.EntityModels
{
    public class Contact: BaseModel
    {

        [Required]
        [DisplayName("First Name")]
        public string FirstName { get; set; }

        [Required]
        [DisplayName("Last Name")]
        public string LastName { get; set; }

        [Required]
        [DisplayName("Phone number")]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^[\+]?[(]?[0-9]{3}[)]?[-\s\.]?[0-9]{3}[-\s\.]?[0-9]{4,6}$", ErrorMessage = "Not a valid Phone number")]
        public string PhoneNumber { get; set; }

        [Required]
        [DisplayName("E-mail")]
        [DataType(DataType.EmailAddress, ErrorMessage = "E-mail is not valid")]
        public string Email { get; set; }

        [DisplayName("Description")]
        [MaxLength(255, ErrorMessage = "Description cannot be longer than 255 characters.")]
        public string Description { get; set; }

        [DisplayName("Zip Code")]
        [MaxLength(10)]
        public virtual string ZipCode { get; set; }

        [MaxLength(50)]
        public virtual string City { get; set; }

        [MaxLength(150)]
        public virtual string Street { get; set; }
    }
}
