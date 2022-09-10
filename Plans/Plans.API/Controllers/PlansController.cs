using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Plan.Entities;
using Plans.Business.Abstract;
using Plans.Business.Concrete;
using System.Collections.Generic;

namespace Plans.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlansController : ControllerBase
    {
        private IPlansService _plansService;

        public PlansController(IPlansService plansService)
        {
            _plansService = plansService;
        }

        /// <summary>
        /// Tüm Planları Listele
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public List<Planss> Get()
        {
            return _plansService.GetAllPlans();
        }

        /// <summary>
        /// ID'ye göre Planı Getir
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}")]
        public Planss Get(int id)
        {
            return _plansService.getPlansbyID(id);
        }

        /// <summary>
        /// Plan Ekle
        /// </summary>
        /// <param name="plans"></param>
        /// <returns></returns>
        [HttpPost]
        public Planss Post([FromBody]Planss plans)
        {
            return _plansService.Createplanss(plans);
        }

        /// <summary>
        /// Plan Güncelle
        /// </summary>
        /// <param name="plans"></param>
        /// <returns></returns>
        [HttpPut]
        public Planss Put([FromBody] Planss plans)
        {
            return _plansService.UpdatePlans(plans);
        }


        /// <summary>
        /// Plan Sil
        /// </summary>
        /// <param name="id"></param>
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _plansService.DeletePlans(id); 
        }
    }
}
