using FluentNHibernate.Mapping;
using HouseIt.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseIt.mappings
{
    public class UserMapping : ClassMap<User>
    {
        public UserMapping()
        {
            Id(x => x.Username).Column("username");
            Map(x => x.Password).Column("pw");
            //References(x => x.Manager).Column("manager_id").Unique();
            //References(x => x.Tenant).Column("tenant_id").Unique();
            Table("Users");
        }
    }
}
