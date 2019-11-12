using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IntegrateTechnicalTest.Model
{
    public class LeadClass
    {
        public int Id { get; set; }
       // First Name(mandatory) b.Last Name(mandatory) c.Email(mandatory) d.Company(optional) e.Post Code(optional) f.Accept Terms(mandatory) g.Date created 3
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Company { get; set; }
        public string PostCode { get; set; }
        public bool IsAcceptedTerms { get; set; }
        public DateTime DateCreated { get; set; }
    }
}
