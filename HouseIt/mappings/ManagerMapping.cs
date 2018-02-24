using FluentNHibernate.Mapping;
using HouseIt.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseIt.mappings
{
    class ManagerMapping : ClassMap<Manager>
    {
        public ManagerMapping()
        {
            Id(x => x.ManagerId).Column("manager_id");
            //HasOne(x => x.User).Cascade.All();
            Table("Managers");
        }
    }
}
