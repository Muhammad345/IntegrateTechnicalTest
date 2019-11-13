using IntegrateTechnicalTest.Common;
using IntegrateTechnicalTest.Model;
using IntegrateTechnicalTest.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IntegrateTechnicalTest.Services
{
    public class LeadClassService : ILeadClassService
    {
        private readonly IRepo<LeadClass> LeadClassRepo;

        public LeadClassService(IRepo<LeadClass> leadClassRepo)
        {
            this.LeadClassRepo = leadClassRepo;
        }
        public RepoResponse Create(LeadClass entity)
        {
            try
            {
                if (this.LeadClassRepo.Create(entity))
                {
                    return new RepoResponse { IsSuccessfull = true, Message = Messages.Repoistory.Create.Message };
                }

                return new RepoResponse { IsSuccessfull = false, Message = $"{Messages.Repoistory.Error.Message} LeadClassRepo" };
            }
            catch (Exception e)
            {

                return new RepoResponse { IsSuccessfull = false, Message = e.ToString() };
            }
        }

        public RepoResponse Delete(LeadClass entity)
        {
            try
            {
                if (this.LeadClassRepo.Delete(entity.Id))
                {
                    return new RepoResponse { IsSuccessfull = true, Message = Messages.Repoistory.Delete.Message };
                }

                return new RepoResponse { IsSuccessfull = false, Message = $"{Messages.Repoistory.Error.Message} LeadClassRepo" };
            }
            catch (Exception e)
            {

                return new RepoResponse { IsSuccessfull = false, Message = e.ToString() };
            }
        }

        public IQueryable<LeadClass> GetAll()
        {
            return this.LeadClassRepo.GetAll();
        }

        public LeadClass GetSpecific(int Id)
        {
            return this.LeadClassRepo.GetSpecific(Id);
        }

        public RepoResponse Update(LeadClass entity)
        {
            try
            {
                if (this.LeadClassRepo.Update(entity.Id, entity))
                {
                    return new RepoResponse { IsSuccessfull = true, Message = Messages.Repoistory.Update.Message };
                }

                return new RepoResponse { IsSuccessfull = false, Message = $"{Messages.Repoistory.Error.Message} LeadClassRepo" };
            }
            catch (Exception e)
            {

                return new RepoResponse { IsSuccessfull = false, Message = e.ToString() };
            }
        }
    }
}
