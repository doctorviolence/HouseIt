using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using HouseIt.entities;
using HouseIt.util;
using NHibernate;

namespace HouseItWebAPI.Controllers
{
    public class CaseController : ApiController
    {
        ISession session = NHibernateManager.BuildSessionFactory().OpenSession();

        public List<Case> GetListCase()
        {
            List<Case> cases = session.Query<Case>().ToList();
            return cases;
        }
    }
}
