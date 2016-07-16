using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBooking
{
    public class Encoder
    {
        public static String encode(OrderClass order)
        {
            String orderinfo = "";
            orderinfo += order.getId()+",";
            orderinfo += order.getCardNo()+",";
            orderinfo += order.getAmt()+",";
            return orderinfo;
        }
    }
}
