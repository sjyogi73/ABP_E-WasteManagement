using eWasteManagement.UserDetails;
using System;
using Volo.Abp.Application.Dtos;

namespace eWasteManagement.UserDetail.Dtos
{
    [Serializable]
    public class userDetailDto : FullAuditedEntityDto<Guid>
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