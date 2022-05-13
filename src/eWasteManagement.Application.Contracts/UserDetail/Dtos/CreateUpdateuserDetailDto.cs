using eWasteManagement.UserDetails;
using System;
using System.ComponentModel;
namespace eWasteManagement.UserDetail.Dtos
{
    [Serializable]
    public class CreateUpdateuserDetailDto
    {
        public string CustomerName { get; set; }

        public Sex Gender { get; set; }

        public string EmailId { get; set; }

        public DateTime Date { get; set; }

        public string Location { get; set; }

        public Types Type { get; set; }

        public string PhoneNo { get; set; }
    }
}