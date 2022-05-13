using eWasteManagement.UserDetail.Dtos;
using eWasteManagement.Web.Pages.UserDetail.userDetail.ViewModels;
using AutoMapper;

namespace eWasteManagement.Web;

public class eWasteManagementWebAutoMapperProfile : Profile
{
    public eWasteManagementWebAutoMapperProfile()
    {
        //Define your AutoMapper configuration here for the Web project.
            CreateMap<userDetailDto, CreateEdituserDetailViewModel>();
            CreateMap<CreateEdituserDetailViewModel, CreateUpdateuserDetailDto>();
    }
}
