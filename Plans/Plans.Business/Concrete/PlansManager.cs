using Plan.Entities;
using Plans.Business.Abstract;
using Plans.DataAcessLayer.Abstract;
using Plans.DataAcessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Plans.Business.Concrete
{
    public class PlansManager : IPlansService
    {
        private IPlansRepository _plansrepository;

        public PlansManager(IPlansRepository plansRepository)
        {
            _plansrepository = plansRepository;
        }
        public Planss Createplanss(Planss planss)
        {
            return _plansrepository.Createplanss(planss);
        }

        public void DeletePlans(int id)
        {
            _plansrepository.DeletePlans(id);
        }

        public List<Planss> GetAllPlans()
        {
           return _plansrepository.GetAllPlans();
        }

        public Planss getPlansbyID(int id)
        {
            return _plansrepository.getPlansbyID(id);
        }

        public Planss UpdatePlans(Planss planss)
        {
            return _plansrepository.UpdatePlans(planss);
        }
    }
}
