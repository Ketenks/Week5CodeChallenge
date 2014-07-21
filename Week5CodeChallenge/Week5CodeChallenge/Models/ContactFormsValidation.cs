using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Week5CodeChallenge.Models
{
    [MetadataType(typeof(ContactFormsValidation))]

    public partial class ContactForm
    {

    }
    public class ContactFormsValidation
    {
        [Required(ErrorMessage="*"), MaxLength(50)]
        public string FirstName { get; set; }
        [Required(ErrorMessage="*"), MaxLength(50)]
        public string LastName { get; set; }
        [Required(ErrorMessage="*"), EmailAddress(ErrorMessage="*")]
        public string Email { get; set; }
        [Required(ErrorMessage="*"), Phone(ErrorMessage="*")]
        public int PhoneNumber { get; set; }
        [Required(ErrorMessage="*"), MaxLength(50)]
        public string CompanyName { get; set; }
        [Required(ErrorMessage="*")]
        public string ProjectDescription { get; set; }
        [Required(ErrorMessage="*")]
        public string Comment { get; set; }
    }
}