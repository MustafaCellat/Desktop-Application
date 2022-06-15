using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadimRadiatorInterface
{
    class OrderItem
    {
        public class Order
        {
            public int id { get; set; }
        }
        public class Product
        {
            public int id { get; set; }
        }
        public class OrderItemCustomizations
        {
            public int id { get; set; }
            public int productCustomizationGroupId { get; set; }
            public string productCustomizationGroupName { get; set; }
            public int productCustomizationGroupSortOrder { get; set; }
            public int productCustomizationFieldId { get; set; }
            public string productCustomizationFieldType { get; set; }
            public string productCustomizationFieldName { get; set; }
            public string productCustomizationFieldValue { get; set; }
            public int cartItemAttributeId { get; set; }
        }
        public class OrderItemSubscription
        {
            public int id { get; set; }
        }
        public class OrderItemInformation
        {
            public int id { get; set; }
            public string productName { get; set; }
            public string productSku { get; set; }
            public string productBarcode { get; set; }
            public double productPrice { get; set; }
            public string productCurrency { get; set; }
            public double productQuantity { get; set; }
            public int productTax { get; set; }
            public double productDiscount { get; set; }
            public double productMoneyOrderDiscount { get; set; }
            public double productWeight { get; set; }
            public string productStockTypeLabel { get; set; }
            public string isProductPromotioned { get; set; }
            public double discount { get; set; }
            public Order order { get; set; }
            public Product product { get; set; }
            public List<OrderItemCustomizations> orderItemCustomizationsList { get; set; }
            public OrderItemSubscription orderItemSubscription { get; set; }
        }
    }
}
