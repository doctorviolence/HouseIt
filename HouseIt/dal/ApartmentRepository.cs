using HouseIt.entities;
using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HouseIt.dal
{
    public class ApartmentRepository : BaseRepository<Apartment>, IApartmentRepository
    {
        public IEnumerable<Apartment> GetApartmentsBelongingToBuilding(int BuildingId)
        {
            using (ISession session = _sf.OpenSession())
                try
                {
                    var sql = "SELECT a.* FROM Apartments a, Buildings b " +
                        "WHERE a.building_id = b.building_id " +
                        "AND b.building_id = :buildingId;";

                    IList<Apartment> Apartments = session.CreateSQLQuery(sql)
                        .AddEntity(typeof(Apartment))
                        .SetInt32("buildingId", BuildingId)
                        .List<Apartment>();
                    return Apartments;
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

    }
}
