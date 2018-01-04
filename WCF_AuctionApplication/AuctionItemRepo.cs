using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WCF_AuctionApplication
{
    public class AuctionItemRepo
    {
        private List<AuctionItem> auctionItemList = new List<AuctionItem>();
        private static AuctionItemRepo instance;
        private AuctionItemRepo() { }
        public static AuctionItemRepo Instance
        {
            get
            {
                if(instance == null)
                {
                    instance = new AuctionItemRepo();
                    instance.LoadDataIntoList();
                }
                return instance;
            }
        }

        private void LoadDataIntoList()
        {
            CreateAuctionItem(1, "Blå bold", 10);
            CreateAuctionItem(2, "Rød bold", 15);
            CreateAuctionItem(3, "Grøn bold", 20);
            CreateAuctionItem(4, "Gul bold", 35);
            CreateAuctionItem(5, "Orange bold", 40);
        }

        public List<AuctionItem> GetAllAuctionItems()
        {
            return auctionItemList;
        }
        public AuctionItem GetAuctionItem(int itemNumber)
        {
            return auctionItemList.Find(x => x.itemNumber == itemNumber);
        }
        public void CreateAuctionItem(int itemNumber, string itemDescription, int ratingPrice)
        {
            auctionItemList.Add(new AuctionItem(itemNumber, itemDescription, ratingPrice));
        }
        public bool ProvideBid(int itemNumber, int bidPrice, string bidCustomName, string bidCustomPhone)
        {
            AuctionItem item = auctionItemList.Find(x => x.itemNumber == itemNumber);

            if (item == null)
                return false;

            lock (item)
            {
                if (item.currentBid == null || bidPrice > item.currentBid.bidPrice)
                {

                    item.currentBid = new Bid(itemNumber, bidPrice, bidCustomName, bidCustomPhone);
                    return true;
                }
            }
            
            return false;
        }
    }
}