using System;
using System.Collections.Generic;
using NHibernate;
using HouseIt.util;
using System.Windows.Forms;

namespace HouseIt.dal
{
    public class BaseRepository<T> : IBaseRepository<T> where T : class
    {

        protected static ISessionFactory _sf = NHibernateManager.BuildSessionFactory();

        public IEnumerable<T> GetEntities(T entity)
        {
            using (ISession session = _sf.OpenSession())
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
                finally
                {
                    session.Close();
                }
        }

        public T FindEntityById(object id)
        {
            using (ISession session = _sf.OpenSession())
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
                finally
                {
                    session.Close();
                }
        }

        public void CreateEntity(T entity)
        {
            using (ISession session = _sf.OpenSession())
            using (ITransaction tx = session.BeginTransaction())
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
                finally
                {
                    session.Close();
                }
        }


        public void UpdateEntity(T entity)
        {
            using (ISession session = _sf.OpenSession())
            using (ITransaction tx = session.BeginTransaction())
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
                finally
                {
                    session.Close();
                }
        }

        public void DeleteEntity(T entity)
        {
            using (ISession session = _sf.OpenSession())
            using (ITransaction tx = session.BeginTransaction())
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
                finally
                {
                    session.Close();
                }
        }


    }
}