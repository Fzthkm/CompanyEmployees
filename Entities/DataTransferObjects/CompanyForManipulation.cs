using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entities.DataTransferObjects
{
    public abstract class CompanyForManipulation
    {
        [Required(ErrorMessage = "Company Name is a required field.")]
        [MaxLength(60, ErrorMessage = "Maximum length for the Name is 60 characters.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Company address is require field.")]
        [MaxLength(60, ErrorMessage = "Maximum length for the address is 60 characters")]
        public string Address { get; set; }

        public string Country { get; set; }

        public DateTime Date { get; set; }

        public IEnumerable<EmployeeForCreationDto> Employees { get; set; }
    }
}
