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
    public class BookingManager : IBookingService
    {
        private readonly IBookingDAL _bookingDAL;
        public void TAdd(Booking entity)
        {
            _bookingDAL.Add(entity);
        }

        public void TDelete(Booking entity)
        {
            _bookingDAL.Delete(entity);
        }

        public Booking TGetByID(int id)
        {
            return _bookingDAL.GetByID(id);
        }

        public List<Booking> TGetListAll()
        {
           return _bookingDAL.GetListAll();
        }

        public void TUpdate(Booking entity)
        {
            _bookingDAL.Update(entity);
        }
    }
}
