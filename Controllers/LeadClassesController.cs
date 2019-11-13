using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using IntegrateTechnicalTest.Data;
using IntegrateTechnicalTest.Model;
using IntegrateTechnicalTest.Services;

namespace IntegrateTechnicalTest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LeadClassesController : Base
    {
        private readonly ILeadClassService LeadClassService;
        public LeadClassesController(ILeadClassService leadClassService)
        {
            LeadClassService = leadClassService;
        }

        // GET: api/LeadClasses
        [HttpGet]
        public ActionResult<IEnumerable<LeadClass>> GetLeadClass()
        {
            return  this.LeadClassService.GetAll().ToList();
        }

        // GET: api/LeadClasses/5
        [HttpGet("{id}")]
        public ActionResult<LeadClass> GetLeadClass(int id)
        {
            var leadClass = this.LeadClassService.GetSpecific(id);

            if (leadClass == null)
            {
                return NotFound();
            }

            return leadClass;
        }

        // POST: api/LeadClasses
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<LeadClass>> PostLeadClass(LeadClass leadClass)
        {
            this.LeadClassService.Create(leadClass);

            return CreatedAtAction("GetLeadClass", new { id = leadClass.Id }, leadClass);
        }
    }
}
