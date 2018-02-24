using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace HouseIt.entities
{
    [DataContract]
    public class Building
    {
        public Building(int BuildingId, string Address, int FloorLevels)
        {
            this.BuildingId = BuildingId;
            this.Address = Address;
            this.FloorLevels = FloorLevels;
        }

        public Building()
        {

        }

        [DataMember]
        public virtual int BuildingId { get; set; }
        [DataMember]
        public virtual string Address { get; set; }
        [DataMember]
        public virtual int FloorLevels { get; set; }

        public virtual IList<Apartment> Apartments { get; set; }

        public virtual Manager Manager { get; set; }

        public override string ToString()
        {
            return string.Format(
                "Building Id: " + BuildingId + " Address: " + Address + " Floor levels: " + FloorLevels
                );
        }
    }
}
