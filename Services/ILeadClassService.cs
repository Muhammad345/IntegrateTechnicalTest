using IntegrateTechnicalTest.Common;
using IntegrateTechnicalTest.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IntegrateTechnicalTest.Services
{
    public interface ILeadClassService
    {
        public RepoResponse Create(LeadClass entity);
        public RepoResponse Update(LeadClass entity);
        public RepoResponse Delete(LeadClass entity);
        public IQueryable<LeadClass> GetAll();
        public LeadClass GetSpecific(int Id);
    }
}
