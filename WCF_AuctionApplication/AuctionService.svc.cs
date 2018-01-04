using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WCF_AuctionApplication
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IAuctionService
    {
        public void CreateAuctionItem(int itemNumber, string itemDescription, int ratingPrice)
        {
            AuctionItemRepo.Instance.CreateAuctionItem(itemNumber, itemDescription, ratingPrice);
        }

        public List<AuctionItem> GetAllAuctionItems()
        {
            return AuctionItemRepo.Instance.GetAllAuctionItems();
        }

        public AuctionItem GetAuctionItem(int itemNumber)
        {
            return AuctionItemRepo.Instance.GetAuctionItem(itemNumber);
        }

        public bool ProvideBid(int itemNumber, int bidPrice, string bidCustomName, string bidCustomPhone)
        {
            return AuctionItemRepo.Instance.ProvideBid(itemNumber, bidPrice, bidCustomName, bidCustomPhone);
        }
    }
}
