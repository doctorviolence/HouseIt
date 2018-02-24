using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using HouseIt.entities;
using HouseIt.mappings;
using NHibernate;
using NHibernate.Cfg;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HouseIt.util
{
    public class NHibernateManager
    {

        private static ISession session;

        public static ISession OpenSession()
        {
            return session = BuildSessionFactory().OpenSession();
        }

        public static ISessionFactory BuildSessionFactory()
        {
            try
            {
                ISessionFactory sf = Fluently.Configure()
                    .Database(MsSqlConfiguration.MsSql2008.ShowSql()
                    .ConnectionString("Server=FREDRIKS-DATOR;Database=HouseIt3;uid=Joanna;pwd=1234;"))
                    .Mappings(m =>
                    {
                        m.FluentMappings.AddFromAssemblyOf<Apartment>();
                        m.FluentMappings.AddFromAssemblyOf<Building>();
                        m.FluentMappings.AddFromAssemblyOf<Case>();
                        m.FluentMappings.AddFromAssemblyOf<CaseMessage>();
                        m.FluentMappings.AddFromAssemblyOf<Manager>();
                        m.FluentMappings.AddFromAssemblyOf<Tenant>();
                        m.FluentMappings.AddFromAssemblyOf<User>();
                    })
                    .BuildSessionFactory();

                return sf;
            }
            catch (Exception e)
            {
                Console.WriteLine("Wubadubdublub: " + e);
                MessageBox.Show(e.Message);
                throw e;
            }
        }
    }
}