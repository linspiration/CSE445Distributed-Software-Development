using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBooking
{
    public class Decoder
    {
        public static OrderClass decode(String orderinfo)
        {
            String[] orderinfos = orderinfo.Split(',');
            OrderClass order = new OrderClass(orderinfos[0],
                Convert.ToInt32(orderinfos[1]), Convert.ToInt32(orderinfos[2]));
            return order;
        }
    }
}
