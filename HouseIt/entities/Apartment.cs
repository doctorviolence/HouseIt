using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace HouseIt.entities
{
    [DataContract]
    public class Apartment
    {
        public Apartment(int ApartmentNo, int Size, int FloorNo, Building Building)
        {
            this.ApartmentNo = ApartmentNo;
            this.Size = Size;
            this.FloorNo = FloorNo;
            this.Building = Building;
        }

        public Apartment()
        {

        }

        [DataMember]
        public virtual int ApartmentNo { get; set; }
        [DataMember]
        public virtual int Size { get; set; }
        [DataMember]
        public virtual int FloorNo { get; set; }
       
        public virtual Building Building { get; set; }

        public virtual IList<Tenant> Tenants { get; set; }

        public override string ToString()
        {
            return string.Format(
                "Apartment No: " + ApartmentNo + " Size: " + Size + " Floor No: " + FloorNo + " Building: " + Building.BuildingId
                );
        }
    }
}
