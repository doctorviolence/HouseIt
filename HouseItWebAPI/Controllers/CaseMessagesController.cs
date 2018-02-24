using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using HouseIt.entities;
using HouseIt.util;
using NHibernate;

namespace HouseItWebAPI.Controllers
{
    public class CaseMessagesController : ApiController
    {
        ISession session = NHibernateManager.BuildSessionFactory().OpenSession();

        public List<CaseMessage> GetListCaseMessages()
        {
            List<CaseMessage> caseMessages = session.Query<CaseMessage>().ToList();
            return caseMessages;
        }
    }
}
