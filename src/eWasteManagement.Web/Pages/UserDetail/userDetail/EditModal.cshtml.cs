using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using eWasteManagement.UserDetail;
using eWasteManagement.UserDetail.Dtos;
using eWasteManagement.Web.Pages.UserDetail.userDetail.ViewModels;

namespace eWasteManagement.Web.Pages.UserDetail.userDetail
{
    public class EditModalModel : eWasteManagementPageModel
    {
        [HiddenInput]
        [BindProperty(SupportsGet = true)]
        public Guid Id { get; set; }

        [BindProperty]
        public CreateEdituserDetailViewModel ViewModel { get; set; }

        private readonly IuserDetailAppService _service;

        public EditModalModel(IuserDetailAppService service)
        {
            _service = service;
        }

        public virtual async Task OnGetAsync()
        {
            var dto = await _service.GetAsync(Id);
            ViewModel = ObjectMapper.Map<userDetailDto, CreateEdituserDetailViewModel>(dto);
        }

        public virtual async Task<IActionResult> OnPostAsync()
        {
            var dto = ObjectMapper.Map<CreateEdituserDetailViewModel, CreateUpdateuserDetailDto>(ViewModel);
            await _service.UpdateAsync(Id, dto);
            return NoContent();
        }
    }
}