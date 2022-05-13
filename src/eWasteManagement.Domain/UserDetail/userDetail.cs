using eWasteManagement.UserDetails;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;

namespace eWasteManagement.UserDetail
{
    public class userDetail : FullAuditedEntity<Guid>
    {
        public string CustomerName { get; set; }
        public Sex Gender { get; set; }
        public string EmailId { get; set; }
        public DateTime Date { get; set; }
        public string Location { get; set; }
        public Types Type { get; set; }
        public string PhoneNo { get; set; }

        protected userDetail()
        {
        }

        public userDetail(
            Guid id,
            string customerName,
            Sex gender,
            string emailId,
            DateTime date,
            string location,
            Types type,
            string phoneNo
        ) : base(id)
        {
            CustomerName = customerName;
            Gender = gender;
            EmailId = emailId;
            Date = date;
            Location = location;
            Type = type;
            PhoneNo = phoneNo;
        }
    }

}
