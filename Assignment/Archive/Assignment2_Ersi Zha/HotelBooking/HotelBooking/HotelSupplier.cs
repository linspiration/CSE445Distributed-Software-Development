using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace HotelBooking
{

    public class HotelSupplier
    {
        public static Int32 roomPrice = 400;
        public static event priceCutEvent priceCut;//Link event to delegate
        static Random rng = new Random();
        private MultiCellBuffer buffer;
        public HotelSupplier(MultiCellBuffer buffer) { this.buffer = buffer; }
        public Int32 getPrice()
        {
            return roomPrice;
        }
        //The functon that generate random room price
        public int PricingModel() 
        {
            Thread.Sleep(500);
            return rng.Next(100, 500);
        }
        //function that change the room price
        public void roomPriceFunc()
        {
            for (Int32 i = 0; i < 10; i++)
            {
                Thread.Sleep(1000);
                Int32 newpr = PricingModel();
                Console.WriteLine("New room price is {0}", newpr);
                changePrice(newpr);
            }
        }
       
           public static void changePrice(Int32 price)
        {
            if (price < roomPrice)
            {
                if (priceCut != null)
                    priceCut(roomPrice, price);
            }
            roomPrice = price;
        }
        //read order from MultiCellBuffer
        public void readOrderFromBuffer()
        {
            //get order from the buffer and decode it 
            OrderClass order = Decoder.decode(buffer.getOneCell());
            Console.WriteLine("HotelSupplier has read the order from buffer and the order is under processing");
            orderProcessing(order);
        }
        //function that process order information
        public void orderProcessing(OrderClass order)
        {
            Int32 unitPrice = TravelAgency.newPrice;
            Int32 amount = order.getAmt();
            bool validCardNo = order.getCardNo() >= 5000 && order.getCardNo() <= 8000;
            const double locationCharge = 7.99;
            const double tax = 0.075;
            //calculate the  charge
            double amountOfCharge = unitPrice * amount;
            double totalAmountCharge = amountOfCharge + amountOfCharge * tax + locationCharge;
            String confirmation = "";
            confirmation += "********************************************************************************************\n";
            if (validCardNo) confirmation += "Congratulations!The order is completed and the order information is:"
                + order.ToString() + " The total charge is:" + totalAmountCharge+"\n";
            else confirmation += "Sorry!the order is not completed because of invalid credit card number\n";
            confirmation += "********************************************************************************************\n";
            TravelAgency travelAgency = new TravelAgency(buffer);
            //send order confirmation to travel agency
            travelAgency.sendConfirmation(confirmation);
        }
    }
}
