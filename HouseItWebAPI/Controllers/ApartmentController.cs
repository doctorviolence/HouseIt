using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using HouseIt.entities;
using HouseIt.util;
using NHibernate;

namespace HouseItWebAPI.Controllers
{
    public class ApartmentController : ApiController
    {
        ISession session = NHibernateManager.BuildSessionFactory().OpenSession();

        public List<Apartment> GetListApartments()
        {
            List<Apartment> apartments = session.Query<Apartment>().ToList();
            return apartments;
        }
    }
}
