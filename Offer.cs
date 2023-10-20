using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApiSampleProject.Models
{
    public class Offer
    {
        public string OfferName { get; set; }
        public List<Product> Products { get; set; }
    }
}