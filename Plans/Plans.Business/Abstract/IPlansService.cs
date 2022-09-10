using Plan.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Plans.Business.Abstract
{
    public interface IPlansService
    {
        List<Planss> GetAllPlans();

        Planss getPlansbyID(int id);

        Planss Createplanss(Planss planss);

        Planss UpdatePlans(Planss planss);

        void DeletePlans(int id);
       
    }
}
