using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelOpgaveDB
{
    class Program
    {
        static void Main(string[] args)
        {
            

            using (var db = new HotelContext())
            {
                
                var Hotellist = from h in db.Hotel
                               
                                select h;
                Console.WriteLine("All hotel info: ");
                foreach (var h in Hotellist)
                {
                    Console.WriteLine(h.ToString());
                }
                var Guestlist = from g in db.Guest

                                select g;
                Console.WriteLine("All guest info: ");
                foreach (var g in Guestlist)
                {
                    Console.WriteLine(g.ToString());
                }
                Console.ReadLine();
            }
        }
    }
}
