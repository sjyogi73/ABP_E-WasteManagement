using eWasteManagement.UserDetail;
using eWasteManagement.UserDetail.Dtos;
using AutoMapper;

namespace eWasteManagement;

public class eWasteManagementApplicationAutoMapperProfile : Profile
{
    public eWasteManagementApplicationAutoMapperProfile()
    {
        /* You can configure your AutoMapper mapping configuration here.
         * Alternatively, you can split your mapping configurations
         * into multiple profile classes for a better organization. */
            CreateMap<userDetail, userDetailDto>();
            CreateMap<CreateUpdateuserDetailDto, userDetail>(MemberList.Source);
    }
}
