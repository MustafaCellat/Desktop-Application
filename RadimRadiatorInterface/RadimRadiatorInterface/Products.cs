using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadimRadiatorInterface
{
    public class Products
    {
        public class Brand
        {
            public int id { get; set; }
            public string name { get; set; }
            public string distributorCode { get; set; }
        }
        public class Currency
        {
            public int id { get; set; }
            public string label { get; set; }
            public string abbr { get; set; }
        }
        public class Parent
        {
            public int id { get; set; }
            public string name { get; set; }
            public string slug { get; set; }
            public string fullName { get; set; }
            public string sku { get; set; }
            public string barcode { get; set; }
            public double price1 { get; set; }
            public int warranty { get; set; }
            public int tax { get; set; }
            public double stockAmount { get; set; }
            public double volumetricWeight { get; set; }
            public double buyingPrice { get; set; }
            public string stockTypeLabel { get; set; }
            public double discount { get; set; }
            public int discountType { get; set; }
            public double moneyOrderDiscount { get; set; }
            public int status { get; set; }
            public string taxIncluded { get; set; }
            //public string distributor { get; set; }
            public string isGifted { get; set; }
            public string gift { get; set; }
            public string customShippingDisabled { get; set; }
            public double customShippingCost { get; set; }
            public string marketPriceDetail { get; set; }
            public string createdAt { get; set; }
            public string updatedAt { get; set; }
            public string metaKeywords { get; set; }
            public string metaDescription { get; set; }
            public string canonicalUrl { get; set; }
            public string pageTitle { get; set; }
            public string hasOption { get; set; }
            public string shortDetails { get; set; }
            public string searchKeywords { get; set; }
            public string installmentThreshold { get; set; }
            public Nullable<int> homeSortOrder { get; set; }
            public Nullable<int> popularSortOrder { get; set; }
            public Nullable<int> brandSortOrder { get; set; }
            public Nullable<int> featuredSortOrder { get; set; }
            public Nullable<int> campaignedSortOrder { get; set; }
            public Nullable<int> newSortOrder { get; set; }
            public Nullable<double> discountedSortOrder { get; set; }
            public class Brand
            {
                public int id { get; set; }
                public string name { get; set; }
                public string distributorCode { get; set; }
            }
            public class Currency
            {
                public int id { get; set; }
                public string label { get; set; }
                public string abbr { get; set; }
            }
            public class Parent2
            {
                public int id { get; set; }
            }
            public class Countdown
            {
                public int id { get; set; }
                public string startDate { get; set; }
                public string endDate { get; set; }
                public string expireDate { get; set; }
                public int useCountDown { get; set; }
            }
            public class Prices
            {
                public int id { get; set; }
                public int value { get; set; }
                public int type { get; set; }
            }
            public class İmages
            {
                public int id { get; set; }
                public string filename { get; set; }
                public string extension { get; set; }
                public string directoryName { get; set; }
                public string revision { get; set; }
                public Nullable<int> sortOrder { get; set; }
            }
            public class Details
            {
                public int id { get; set; }
                public string details { get; set; }
                public string extraDetails { get; set; }
            }
            public class ProductToCategories
            {
                public int id { get; set; }
                public Nullable<int> sortOrder { get; set; }
                public int MyProperty { get; set; }
                public class Category
                {
                    public int id { get; set; }
                    public string name { get; set; }
                    public string distributorCode { get; set; }
                }
            }
        }
        public class Countdown
        {
            public int id { get; set; }
            public string startDate { get; set; }
            public string endDate { get; set; }
            public string expireDate { get; set; }
            public int useCountDown { get; set; }
        }
        public class Prices
        {
            public int id { get; set; }
            public int value { get; set; }
            public int type { get; set; }
        }
        public class İmages
        {
            public int id { get; set; }
            public string filename { get; set; }
            public string extension { get; set; }
            public string directoryName { get; set; }
            public string revision { get; set; }
            public Nullable<int> sortOrder { get; set; }
        }
        public class Details
        {
            public int id { get; set; }
            public string details { get; set; }
            public string extraDetails { get; set; }
        }
        public class ProductToCategories
        {
            public int id { get; set; }
            public Nullable<int> sortOrder { get; set; }
            public int MyProperty { get; set; }
            public class Category
            {
                public int id { get; set; }
                public string name { get; set; }
                public string distributorCode { get; set; }
            }
        }
        public class ProductsInformation
        {
            public int id { get; set; }
            public string name { get; set; }
            public string slug { get; set; }
            public string fullName { get; set; }
            public string sku { get; set; }
            public string barcode { get; set; }
            public double price1 { get; set; }
            public int warranty { get; set; }
            public int tax { get; set; }
            public double stockAmount { get; set; }
            public double volumetricWeight { get; set; }
            public double buyingPrice { get; set; }
            public string stockTypeLabel { get; set; }
            public double discount { get; set; }
            public int discountType { get; set; }
            public double moneyOrderDiscount { get; set; }
            public int status { get; set; }
            public string taxIncluded { get; set; }
            //public string distributor { get; set; }
            public string isGifted { get; set; }
            public string gift { get; set; }
            public string customShippingDisabled { get; set; }
            public double customShippingCost { get; set; }
            public string marketPriceDetail { get; set; }
            public string createdAt { get; set; }
            public string updatedAt { get; set; }
            public string metaKeywords { get; set; }
            public string metaDescription { get; set; }
            public string canonicalUrl { get; set; }
            public string pageTitle { get; set; }
            public string hasOption { get; set; }
            public string shortDetails { get; set; }
            public string searchKeywords { get; set; }
            public string installmentThreshold { get; set; }
            public Nullable<int> homeSortOrder { get; set; }
            public Nullable<int> popularSortOrder { get; set; }
            public Nullable<int> brandSortOrder { get; set; }
            public Nullable<int> featuredSortOrder { get; set; }
            public Nullable<int> campaignedSortOrder { get; set; }
            public Nullable<int> newSortOrder { get; set; }
            public Nullable<double> discountedSortOrder { get; set; }
            public Brand brand { get; set; }
            public Currency currency { get; set; }
            public Parent parent { get; set; }
            public Countdown countdown { get; set; }
            public List<Prices> pricesList { get; set; }
            public List<İmages> imagesList { get; set; }
            public List<Details> detailsList { get; set; }
            public List<ProductToCategories> productToCategories { get; set; }
        }
    }
}
