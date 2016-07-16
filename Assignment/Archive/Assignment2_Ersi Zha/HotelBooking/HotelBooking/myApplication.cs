using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace HotelBooking
{
    public delegate void priceCutEvent(Int32 oldPr, Int32 newPr);
    public class myApplication
    {
        //initiate a static mulitCellBuffer
        static MultiCellBuffer multiCellBuffer = new MultiCellBuffer();
        static void Main(string[] args)
        {
            HotelSupplier hotelSupplier = new HotelSupplier(multiCellBuffer);
            //create HotelSupplier thead and start 
            Thread threadHotelSupplier = new Thread(new ThreadStart(hotelSupplier.roomPriceFunc));
            threadHotelSupplier.Start();
            TravelAgency[] travelAgency = new TravelAgency[3];
            //create TravelAgency thead and start 
            Thread[] threadTravelAgency = new Thread[3];
            for (int i = 0; i < 3; i++)
            {
                travelAgency[i] = new TravelAgency(multiCellBuffer);
                HotelSupplier.priceCut += new priceCutEvent(travelAgency[i].roomOnSale);
                threadTravelAgency[i] = new Thread(new ThreadStart(travelAgency[i].travelAgencyFunc));
                //set thread name
                travelAgency[i].setName((i + 1).ToString());
                threadTravelAgency[i].Start();
            }
        }
    }
}
