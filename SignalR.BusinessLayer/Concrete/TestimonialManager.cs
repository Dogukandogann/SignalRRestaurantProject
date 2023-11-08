using SignalR.BusinessLayer.Abstract;
using SignalR.DataAccessLayer.Abstract;
using SignalR.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalR.BusinessLayer.Concrete
{
    public class TestimonialManager : ITestomonialService
    {
        private readonly ITestimonialDAL _testimonialDAL;

        public TestimonialManager(ITestimonialDAL testimonialDAL)
        {
            _testimonialDAL = testimonialDAL;
        }

        public void TAdd(Testimonial entity)
        {
            _testimonialDAL.Add(entity);
        }

        public void TDelete(Testimonial entity)
        {
            _testimonialDAL.Delete(entity);
        }

        public Testimonial TGetByID(int id)
        {
           return _testimonialDAL.GetByID(id);
        }

        public List<Testimonial> TGetListAll()
        {
            return _testimonialDAL.GetListAll();
        }

        public void TUpdate(Testimonial entity)
        {
            _testimonialDAL.Update(entity);
        }
    }
}
