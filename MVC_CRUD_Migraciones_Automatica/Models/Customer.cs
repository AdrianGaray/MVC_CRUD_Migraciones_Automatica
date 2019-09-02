using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MVC_CRUD_Migraciones_Automatica.Models
{
    public class Customer
    {
        [Key]
        public int CustomerID { get; set; }

        [StringLength(30, ErrorMessage = "The field {0} must be between {2} and {1} characters", MinimumLength = 3)]
        [Required(ErrorMessage = "You must enter {0}")]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [StringLength(30, ErrorMessage = "The field {0} must be between {2} and {1} characters", MinimumLength = 3)]
        [Required(ErrorMessage = "You must enter {0}")]
        [Display(Name = "Last Name")]
        public string LasttName { get; set; }

        [DataType(DataType.PhoneNumber)]
        [DisplayFormat(DataFormatString = "{0:C2}", ApplyFormatInEditMode = false)]
        [Required(ErrorMessage = "You must enter {0}")]
        public string Phone { get; set; }

        [StringLength(30, ErrorMessage = "The field {0} must be between {2} and {1} characters", MinimumLength = 3)]
        [Required(ErrorMessage = "You must enter {0}")]
        public string Adress { get; set; }

        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }


        [StringLength(20, ErrorMessage = "The field {0} must be between {2} and {1} characters", MinimumLength = 5)]
        [Required(ErrorMessage = "You must enter {0}")]
        [Display(Name = "Document Name")]
        public string Document { get; set; }

        public int DocumentTypeID { get; set; }

        public string FullName { get { return string.Format("{0} {1}", FirstName, LasttName); } }

        public virtual DocumentType DocumentType { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
    }
}