using Subgurim.Controles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeoIPCity
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                string ip = Console.ReadLine();
                Console.WriteLine(GetIPCity(ip).city);
            } while (true);
            Console.ReadKey();

        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ipAddress"></param>
        /// <returns></returns>
        public static Location GetIPCity(string ipAddress)
        {
            string databasePath = @"E:\TeamFondationServers\GeoIPCity\GeoIPCity\APP_DATA\GeoLiteCity.dat";// HttpContext.Current.Server.MapPath("~/app_data/geocitylite.dat");
            LookupService service = new LookupService(databasePath);
            Location loc = service.getLocation(ipAddress); 
            return loc;
        }
    }
}
