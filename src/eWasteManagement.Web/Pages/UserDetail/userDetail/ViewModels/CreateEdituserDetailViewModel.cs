using eWasteManagement.UserDetails;
using System;

using System.ComponentModel.DataAnnotations;

namespace eWasteManagement.Web.Pages.UserDetail.userDetail.ViewModels
{
    public class CreateEdituserDetailViewModel
    {
        [Display(Name = "Name")]
        public string CustomerName { get; set; }

        [Display(Name = "Gender")]
        public Sex Gender { get; set; }

        [Display(Name = "EmailID")]
        public string EmailId { get; set; }

        [Display(Name = "Date")]
        public DateTime Date { get; set; }

        [Display(Name = "Location")]
        public string Location { get; set; }

        [Display(Name = "Type")]
        public Types Type { get; set; }

        [Display(Name = "Mobile")]
        public string PhoneNo { get; set; }
    }
}