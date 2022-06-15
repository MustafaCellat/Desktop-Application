using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadimRadiatorInterface
{
    class Members
    {
        public class Country
        {
            public int id { get; set; }
            public string name { get; set; }
            public string code { get; set; }
            public int status { get; set; }
        }
        public class Location
        {
            public int id { get; set; }
            public string name { get; set; }
            public class Region
            {
                public int id { get; set; }
                public string name { get; set; }
            }
        }
        public class MemberGroup
        {
            public int id { get; set; }
            public string name { get; set; }
        }
        public class ReferredMember
        {
            public int id { get; set; }
            public string firstname { get; set; }
            public string surname { get; set; }
            public string email { get; set; }
            public string gender { get; set; }
            public string birthDate { get; set; }
            public string phoneNumber { get; set; }
            public string mobilePhoneNumber { get; set; }
            public string otherLocation { get; set; }
            public string address { get; set; }
            public string taxNumber { get; set; }
            public string tcId { get; set; }
            public string status { get; set; }
            public string lastLoginDate { get; set; }
            public string createdAt { get; set; }
            public string updatedAt { get; set; }
            public string zipCode { get; set; }
            public string commercialName { get; set; }
            public string taxOffice { get; set; }
            public string lastMailSentDate { get; set; }
            public string lastIp { get; set; }
            public double gainedPointAmount { get; set; }
            public double spentPointAmount { get; set; }
            public string allowedToCampaigns { get; set; }
            public string allowedToCampaignsUpdatedAt { get; set; }
            public double referredMemberGainedPointAmount { get; set; }
            public string district { get; set; }
            public string deviceType { get; set; }
            public string deviceInfo { get; set; }
            public class Country
            {
                public int id { get; set; }
                public string name { get; set; }
                public string code { get; set; }
                public int status { get; set; }
            }
            public class Location
            {
                public int id { get; set; }
                public string name { get; set; }
                public class Region
                {
                    public int id { get; set; }
                    public string name { get; set; }
                }
            }
            public class MemberGroup
            {
                public int id { get; set; }
                public string name { get; set; }
            }
            public class Referredmember
            {
                public int id { get; set; }
            }
            public bool kvkkStatus { get; set; }
            public string kvkkConfirmationDate { get; set; }
        }
            public class MembersInformation
        {
            public int id { get; set; }
            public string firstname { get; set; }
            public string surname { get; set; }
            public string email { get; set; }
            public string gender { get; set; }
            public string birthDate { get; set; }
            public string phoneNumber { get; set; }
            public string mobilePhoneNumber { get; set; }
            public string otherLocation { get; set; }
            public string address { get; set; }
            public string taxNumber { get; set; }
            public string tcId { get; set; }
            public string status { get; set; }
            public string lastLoginDate { get; set; }
            public string createdAt { get; set; }
            public string updatedAt { get; set; }
            public string zipCode { get; set; }
            public string commercialName { get; set; }
            public string taxOffice { get; set; }
            public string lastMailSentDate { get; set; }
            public string lastIp { get; set; }
            public double gainedPointAmount { get; set; }
            public double spentPointAmount { get; set; }
            public string allowedToCampaigns { get; set; }
            public string allowedToCampaignsUpdatedAt { get; set; }
            public double referredMemberGainedPointAmount { get; set; }
            public string district { get; set; }
            public string deviceType { get; set; }
            public string deviceInfo { get; set; }
            public Country country { get; set; }
            public Location location { get; set; }
            public MemberGroup memberGroup { get; set; }
            public ReferredMember referredMember { get; set; }
            public bool kvkkStatus { get; set; }
            public string kvkkConfirmationDate { get; set; }
        }
    }
}
