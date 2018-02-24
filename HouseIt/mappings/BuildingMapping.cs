using FluentNHibernate.Mapping;
using HouseIt.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseIt.mappings
{
    public class BuildingMapping : ClassMap<Building>
    {
        public BuildingMapping()
        {
            Id(x => x.BuildingId).Column("building_id"); ;
            Map(x => x.Address).Column("address"); ;
            Map(x => x.FloorLevels).Column("floor_levels"); ;
            Table("Buildings");
        }
    }
}
