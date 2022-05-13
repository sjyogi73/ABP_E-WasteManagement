using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using eWasteManagement.UserDetail;
using eWasteManagement.UserDetail.Dtos;
using eWasteManagement.Web.Pages.UserDetail.userDetail.ViewModels;

namespace eWasteManagement.Web.Pages.UserDetail.userDetail
{
    public class CreateModalModel : eWasteManagementPageModel
    {
        [BindProperty]
        public CreateEdituserDetailViewModel ViewModel { get; set; }

        private readonly IuserDetailAppService _service;

        public CreateModalModel(IuserDetailAppService service)
        {
            _service = service;
        }

        public virtual async Task<IActionResult> OnPostAsync()
        {
            var dto = ObjectMapper.Map<CreateEdituserDetailViewModel, CreateUpdateuserDetailDto>(ViewModel);
            await _service.CreateAsync(dto);
            return NoContent();
        }
    }
}