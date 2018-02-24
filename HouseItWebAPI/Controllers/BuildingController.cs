using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using HouseIt.entities;
using HouseIt.util;
using NHibernate;

namespace HouseItWebAPI.Controllers
{
    public class BuildingController : ApiController
    {
        ISession session = NHibernateManager.BuildSessionFactory().OpenSession();

        public List<Building> GetListApartments()
        {
            List<Building> buildings = session.Query<Building>().ToList();
            return buildings;
        }
    }
}
