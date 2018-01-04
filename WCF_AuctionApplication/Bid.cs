using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace WCF_AuctionApplication
{
    [DataContract]
    public class Bid
    {
        [DataMember]
        public int itemNumber { get; set; }
        [DataMember]
        public int bidPrice { get; set; }
        [DataMember]
        public string bidCustomName { get; set; }
        [DataMember]
        public string bidCustomPhone { get; set; }
        [DataMember]
        public DateTime bidTimestamp { get; set; }

        public Bid(int itemNumber, int bidPrice, string bidCustomName, string bidCustomPhone)
        {
            this.itemNumber = itemNumber;
            this.bidPrice = bidPrice;
            this.bidCustomName = bidCustomName;
            this.bidCustomPhone = bidCustomPhone;
            bidTimestamp = DateTime.Now;
        }
    }
}