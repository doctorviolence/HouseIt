using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using HouseIt.entities;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHibernate;
using HouseIt.util;
using System.Windows.Forms;

namespace HouseIt.dal
{
    public class BaseRepository<T> : IBaseRepository<T> where T : class
    {

        protected static ISession session = NHibernateManager.OpenSession();

        public IEnumerable<T> GetEntities(T entity)
        {
            try
            {
                var entities = session.CreateCriteria<T>().List<T>();
                return entities;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                throw e;
            }
        }

        public T FindEntityById(object id)
        {
            try
            {
                var entity = session.Get<T>(id);
                return entity;
            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message);
                throw e;
            }
        }

        public void CreateEntity(T entity)
        {
            using (ITransaction tx = session.BeginTransaction())
            {
                try
                {
                    session.Save(entity);
                    tx.Commit();
                }
                catch (Exception e)
                {
                    tx.Rollback();
                    MessageBox.Show(e.Message);
                    throw e;
                }
            }
        }

        public void UpdateEntity(T entity)
        {
            using (ITransaction tx = session.BeginTransaction())
            {
                try
                {
                    session.SaveOrUpdate(entity);
                    tx.Commit();
                }
                catch (Exception e)
                {
                    tx.Rollback();
                    MessageBox.Show(e.Message);
                    throw e;
                }
            }
        }

        public void DeleteEntity(T entity)
        {
            using (ITransaction tx = session.BeginTransaction())
            {
                try
                {
                    session.Delete(entity);
                    tx.Commit();
                }
                catch (Exception e)
                {
                    tx.Rollback();
                    MessageBox.Show(e.Message);
                    throw e;
                }
            }
        }

    }
}