using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using HouseIt.entities;

namespace HouseIt.mappings
{
    public class ApartmentMapping : ClassMap<Apartment>
    {
        public ApartmentMapping()
        {
            Id(x => x.ApartmentNo).Column("apartment_no"); ;
            Map(x => x.FloorNo).Column("floor_no"); ;
            Map(x => x.Size).Column("size");
            HasMany(x => x.Tenants).KeyColumn("apartment_no").Inverse().Cascade.All();
            References(x => x.Building).Column("building_id").Cascade.None();
            Table("Apartments");
        }
    }
}
