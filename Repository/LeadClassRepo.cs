using IntegrateTechnicalTest.Data;
using IntegrateTechnicalTest.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IntegrateTechnicalTest.Repository
{
    public class LeadClassRepo : IRepo<LeadClass>
    {
        private readonly IntegrateTechnicalTestContext _appDbContext;

        public LeadClassRepo(IntegrateTechnicalTestContext context)
        {
            _appDbContext = context;
        }
        public bool Create(LeadClass entity)
        {
            _appDbContext.LeadClass.Add(entity);
            _appDbContext.SaveChanges();

            return true;
        }

        public bool Delete(int key)
        {
            var employee = GetSpecific(key);
            if (employee == null)
            {
                return false;
            }

            _appDbContext.LeadClass.Remove(employee);
            _appDbContext.SaveChanges();

            return true;
        }

        public IQueryable<LeadClass> GetAll()
        {
            return _appDbContext.LeadClass;
        }

        public LeadClass GetSpecific(int Id)
        {
            return _appDbContext.LeadClass.Find(Id);
        }

        public bool Update(int key, LeadClass entity)
        {
            _appDbContext.Entry(entity).State = EntityState.Modified;

            try
            {
                _appDbContext.SaveChanges();
            }
            catch (DbUpdateException e)
            {
                throw e;
            }

            return true;
        }
    }
}
