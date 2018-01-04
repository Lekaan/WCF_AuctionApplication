using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace WCF_AuctionApplication
{
    [DataContract]
    public class AuctionItem
    {
        [DataMember]
        public int itemNumber { get; set; }
        [DataMember]
        public string itemDescription { get; set; }
        [DataMember]
        public int ratingPrice { get; set; }
        [DataMember]
        public Bid currentBid { get; set; }

        public AuctionItem(int itemNumber, string itemDescription, int ratingPrice)
        {
            this.itemNumber = itemNumber;
            this.itemDescription = itemDescription;
            this.ratingPrice = ratingPrice;
            currentBid = null;
        }
    }
}