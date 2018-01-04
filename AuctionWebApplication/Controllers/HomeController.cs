using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AuctionWebApplication.Models;

namespace AuctionWebApplication.Controllers
{
    public class HomeController : Controller
    {
        public async Task<IActionResult> Index()
        {

            Service1.AuctionServiceClient client = new Service1.AuctionServiceClient();
            var result = await client.GetAllAuctionItemsAsync();
            return View(result);
        }

        public async Task<IActionResult> Details(int id)
        {
            Service1.AuctionServiceClient client = new Service1.AuctionServiceClient();
            var result = await client.GetAllAuctionItemsAsync();
            var singleItem = result.Where(x => x.itemNumber == id).SingleOrDefault();
            if (singleItem != null)
            {
                return View(singleItem);
            }
            else
            {
                Response.Redirect("/");
            }

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Details(Service1.AuctionItem item)
        {
            Service1.AuctionServiceClient client = new Service1.AuctionServiceClient();
            bool success = await client.ProvideBidAsync(item.itemNumber, item.currentBid.bidPrice, item.currentBid.bidCustomName, item.currentBid.bidCustomPhone);
            string x;
            if (success)
                x = "Bid created";
            else
                x = "Something went wrong";
            ViewBag.Response = x;
            return View();
        }

        public async Task<IActionResult> About(string name)
        {
            Service1.AuctionServiceClient client = new Service1.AuctionServiceClient();
            var result = await client.GetAllAuctionItemsAsync();
            var res2 = result.Where(x => x.currentBid.bidCustomName == name);
            return View("index", res2);
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
