using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using HouseIt.entities;
using HouseIt.util;
using NHibernate;

namespace HouseItWebAPI.Controllers
{
    public class TenantController : ApiController
    {
        ISession session = NHibernateManager.BuildSessionFactory().OpenSession();

        public List<Tenant> GetListTenant()
        {
            List<Tenant> tenants = session.Query<Tenant>().ToList();
            return tenants;
        }
    }
}
