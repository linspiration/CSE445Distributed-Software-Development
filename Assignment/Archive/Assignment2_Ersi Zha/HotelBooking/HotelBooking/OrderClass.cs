using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBooking
{
    public class OrderClass
    {
        private Int32 cardNo;
        private Int32 amount;
        private String senderId;
        public OrderClass(String senderId,Int32 cardNo,Int32 amount)
        {
            this.senderId = senderId;
            this.cardNo = cardNo;
            this.amount = amount; 
        }
        public void setCardNo(int cardNo) { this.cardNo = cardNo; }
        public int getCardNo() { return cardNo;}
        public void setAmt(int amount) { this.amount = amount; }
        public int getAmt() { return amount; }
        public void setId(String senderId) { this.senderId = senderId; }
        public String getId() {return senderId;}

        public String ToString()
        {
             String order="";
             order+= "SenderId:" + senderId;
             order+= " CardNumber:" + cardNo;
             order+= " Amount:" + amount;
             return order;
        }
    }
}
