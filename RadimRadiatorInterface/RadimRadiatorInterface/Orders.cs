using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadimRadiatorInterface
{
    class Orders
    {
        public class Maillist
        {
            public int id { get; set; }
            public string name { get; set; }
            public string email { get; set; }
            public class MaillistGroup
            {
                public int id { get; set; }
                public string name { get; set; }
            }
        }
        public class Member
        {
            public int id { get; set; }
            public string firstname { get; set; }
            public string surname { get; set; }
            public string email { get; set; }
            public string gender { get; set; }
            public string phoneNumber { get; set; }
            public string mobilePhoneNumber { get; set; }
            public string address { get; set; }
            public string status { get; set; }
            public class MemberGroup
            {
                public int id { get; set; }
                public string name { get; set; }
            }
        }
        public class OrderDetails
        {
            public int id { get; set; }
            public string varKey { get; set; }
            public string varValue { get; set; }
        }
        public class OrderItems
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
            public int isProductPromotioned { get; set; }
            public double discount { get; set; }
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
        }
        public class ShippingAddress
        {
            public int id { get; set; }
            public string firstname { get; set; }
            public string surname { get; set; }
            public string country { get; set; }
            public string location { get; set; }
            public string subLocation { get; set; }
            public string address { get; set; }
            public string phoneNumber { get; set; }
            public string mobilePhoneNumber { get; set; }
        }
        public class BillingAddress
        {
            public int id { get; set; }
            public string firstname { get; set; }
            public string surname { get; set; }
            public string country { get; set; }
            public string location { get; set; }
            public string subLocation { get; set; }
            public string address { get; set; }
            public string phoneNumber { get; set; }
            public string mobilePhoneNumber { get; set; }
            public string invoiceType { get; set; }
            public string taxNo { get; set; }
            public string taxOffice { get; set; }
            public string identityRegistrationNumber { get; set; }
        }
        public class OrdersInformation
        {
            public int id { get; set; }
            public string customerFirstname { get; set; }
            public string customerSurname { get; set; }
            public string customerEmail { get; set; }
            public string customerPhone { get; set; }
            public string paymentTypeName { get; set; }
            public string paymentProviderCode { get; set; }
            public string paymentProviderName { get; set; }
            public string paymentGatewayCode { get; set; }
            public string paymentGatewayName { get; set; }
            public string bankName { get; set; }
            public string clientIp { get; set; }
            public string userAgent { get; set; }
            public string currency { get; set; }
            public string currencyRates { get; set; }
            public double amount { get; set; }
            public double couponDiscount { get; set; }
            public double taxAmount { get; set; }
            public double promotionDiscount { get; set; }
            public double generalAmount { get; set; }
            public double shippingAmount { get; set; }
            public double additionalServiceAmount { get; set; }
            public double finalAmount { get; set; }
            public double sumOfGainedPoints { get; set; }
            public int installment { get; set; }
            public double installmentRate { get; set; }
            public int extraInstallment { get; set; }
            public string transactionId { get; set; }
            public string hasUserNote { get; set; }
            public string status { get; set; }
            public string paymentStatus { get; set; }
            public string errorMessage { get; set; }
            public string deviceType { get; set; }
            public string referrer { get; set; }
            public int invoicePrintCount { get; set; }
            public string useGiftPackage { get; set; }
            public string giftNote { get; set; }
            public string memberGroupName { get; set; }
            public string usePromotion { get; set; }
            public string shippingProviderCode { get; set; }
            public string shippingProviderName { get; set; }
            public string shippingCompanyName { get; set; }
            public string shippingPaymentType { get; set; }
            public string shippingTrackingCode { get; set; }
            public string source { get; set; }
            public string createdAt { get; set; }
            public string updatedAt { get; set; }
            public Maillist maillist { get; set; }
            public Member member { get; set; }
            public List<OrderDetails> orderDetails { get; set; }
            public List<OrderItems> orderItems { get; set; }
            public ShippingAddress shippingAddress { get; set; }
            public BillingAddress billingAddress { get; set; }
        }
    }
}
