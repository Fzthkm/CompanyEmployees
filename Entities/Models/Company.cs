using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models
{
    public class Company
    {
        [Column("CompanyId")]
        public Guid Id { get; set; }
        
        [Required(ErrorMessage = "Company name is a required field.")]
        [MaxLength(60, ErrorMessage = "Maximum length for the Name is 60 characters.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Company address is require field.")]
        [MaxLength(60, ErrorMessage = "Maximum length for the address is 60 characters")]
        public string Address { get; set; }

        public string Country { get; set; }

        public DateTime CreateDate { get; set; }

        public DateTime LastModify { get; set; }

        public ICollection<Employee> Employees { get; set; }
    }
}
