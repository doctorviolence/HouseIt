using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HouseIt.dal;
using HouseIt.entities;

/**
 * 
 * Tests (writing here because I am too lazy to write proper unit tests)
 * 
 **/
namespace HouseIt
{
    public class Test
    {

        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        private static Stopwatch Timer = new Stopwatch();
        private static IBaseRepository<Building> buildingRepo = new BaseRepository<Building>();
        private static IBaseRepository<Apartment> apartmentRepo = new BaseRepository<Apartment>();
        private static IBaseRepository<Tenant> tenantRepo = new BaseRepository<Tenant>();
        private static ICaseRepository caseRepo = new CaseRepository();

        public static void Main(string[] args)
        {
            log.Info("");

            CreateEntityTest();
            FindEntityTest();
            ReadEntitiesTest();

        }

        public static void CreateEntityTest()
        {
            Timer.Start();
            Building building = new Building(0, "Limhamn", 3);
            buildingRepo.CreateEntity(building);
            Timer.Stop();
            Console.WriteLine(Timer.ElapsedMilliseconds.ToString());
        }

        public static void FindEntityTest()
        {
            Timer.Start();
            Apartment a = apartmentRepo.FindEntityById(1002);
            Console.WriteLine(a.ToString());
            Timer.Stop();
            Console.WriteLine(Timer.ElapsedMilliseconds.ToString());
        }

        public static void ReadEntitiesTest()
        {
            Timer.Start();
            Tenant t = new Tenant();
            foreach (Tenant tenant in tenantRepo.GetEntities(t))
            {
                Console.WriteLine(tenant.ToString());
            }

            Timer.Stop();
            Console.WriteLine(Timer.ElapsedMilliseconds.ToString());
        }

    }
}
