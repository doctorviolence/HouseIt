using HouseIt.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseIt.dal
{
    interface IApartmentRepository : IBaseRepository<Apartment>
    {
        IEnumerable<Apartment> GetApartmentsBelongingToBuilding(int BuildingId);
    }
}
