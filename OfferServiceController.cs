
using System.Web.Http;
using System.Collections.Generic;
using WebApiSampleProject.Models;
using System.Linq;
namespace WebApiSampleProject.Controllers
{
    public class OfferServiceController : ApiController
    {
        public  List<Offer> GetTodaysOffers()
        {
            OfferService offerService = new OfferService();

            return  offerService.GetTodaysOffers();
        }

        public List<Product> GetAllProducts()
        {
            OfferService offerService = new OfferService();

            List<Product> products = offerService.GetAllProducts();

            List<Product> lstASCProducts = (from product in products
                         orderby product.Price
                         select product).ToList();


            List<Product> result = new List<Product>() { lstASCProducts[0], lstASCProducts[1], lstASCProducts[2] };

            return result;
        }

        public void Post(Product product)
        {
            
        }
    }
}
