using IntegrateTechnicalTest.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace IntegrateTechnicalTest.Model
{
    public class LeadClass
    {
        [Key]
        public int Id { get; set; }

        [StringLength(DataLength.FirstName)]
        public string FirstName { get; set; }

        [StringLength(DataLength.LastName)]
        public string LastName { get; set; }

        [StringLength(DataLength.EmailAddress)]
        public string Email { get; set; }

        public string Company { get; set; }

        public string PostCode { get; set; }

        public bool IsAcceptedTerms { get; set; }

        public DateTime DateCreated { get; set; }
    }
}
