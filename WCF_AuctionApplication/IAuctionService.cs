using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WCF_AuctionApplication
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IAuctionService
    {

        [OperationContract]
        List<AuctionItem> GetAllAuctionItems();
        [OperationContract]
        AuctionItem GetAuctionItem(int itemNumber);
        [OperationContract]
        void CreateAuctionItem(int itemNumber, string itemDescription, int ratingPrice);
        [OperationContract]
        bool ProvideBid(int itemNumber, int bidPrice, string bidCustomName, string bidCustomPhone);
    }
    
}
