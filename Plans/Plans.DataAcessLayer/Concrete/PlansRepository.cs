using Plan.Entities;
using Plans.DataAcessLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Plans.DataAcessLayer.Concrete
{
    public class PlansRepository : IPlansRepository
    {
        public Planss Createplanss(Planss planss)
        {
            using (var planDBContext = new PlanDBContext())
            {
                planDBContext.plansss.Add(planss);
                planDBContext.SaveChanges();
                return planss;
            }
        }

        public void DeletePlans(int id)
        {
            using (var planDBContext = new PlanDBContext())
            {
                var deletedplan = getPlansbyID(id);
                planDBContext.plansss.Remove(deletedplan);
                planDBContext.SaveChanges();
            }
        }

        public List<Planss> GetAllPlans()
        {
            using (var planDBContext = new PlanDBContext())
            {
                return planDBContext.plansss.ToList();
            }
        }

        public Planss getPlansbyID(int id)
        {
            using (var planDBContext = new PlanDBContext())
            {
                return planDBContext.plansss.Find(id);
            }
        }
        

        public Planss UpdatePlans(Planss planss)
        {
            using (var planDBContext = new PlanDBContext())
            {
                planDBContext.plansss.Update(planss);
                planDBContext.SaveChanges();
                return planss;
            }
        }
    }
}
