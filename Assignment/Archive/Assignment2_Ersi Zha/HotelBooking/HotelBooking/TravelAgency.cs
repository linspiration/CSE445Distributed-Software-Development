using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace HotelBooking
{
    public class TravelAgency
    {
        public static Int32 newPrice;
        private String name;
        private MultiCellBuffer buffer;
        static Random rng = new Random();//generate random numbers
        public TravelAgency(MultiCellBuffer buffer) { this.buffer = buffer; }
        public void setName(String name) { this.name = name; }
        public String getName() { return name; }
        private Int32 needAmount;
        public void travelAgencyFunc()
        {
            for (int i = 0; i < 10; i++)
            {
                Thread.Sleep(1000);
                needAmount = rng.Next(1, 10);
            }
        }
        public void roomOnSale(Int32 oldPr, Int32 newPr)
        {
            Console.WriteLine("Agency{0} rooms are on sale: as low as ＄{1} each", name, newPr);
            //calculate the number of rooms to order
            Int32 numberOfRooms = needAmount + (oldPr-newPr)/10;
            Int32 cardNo = rng.Next(4000, 9000);
            OrderClass order = new OrderClass(name, cardNo, numberOfRooms);
            String encodeOrder = Encoder.encode(order);
            Console.WriteLine("Agency" + name + 
                " is writing the order to buffer and order information:"+order.ToString());
            buffer.setOneCell(encodeOrder);
            newPrice = newPr;
            //notify HotelSupplier to read order from buffer
            HotelSupplier h = new HotelSupplier(buffer);
            h.readOrderFromBuffer();   
        }
        public void sendConfirmation(String confirmation)
        {
            Console.WriteLine(confirmation);
        }
    }
}
