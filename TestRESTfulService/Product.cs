using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace TestRESTfulService
{
    [DataContract]
    public class Product
    {
        [DataMember]
        public int ProductId { get; set; }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public string CategoryName { get; set; }

        [DataMember]
        public int Price { get; set; }
    }

    public partial class Products
    {
        private static readonly Products _instance = new Products();

        private Products() { }

        public static Products Instance
        {
            get { return _instance; }
        }

       // public List<Product> ProductList
    }
}