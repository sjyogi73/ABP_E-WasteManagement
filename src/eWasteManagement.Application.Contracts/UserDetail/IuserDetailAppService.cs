using System;
using eWasteManagement.UserDetail.Dtos;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace eWasteManagement.UserDetail
{
    public interface IuserDetailAppService :
        ICrudAppService< 
            userDetailDto, 
            Guid, 
            PagedAndSortedResultRequestDto,
            CreateUpdateuserDetailDto,
            CreateUpdateuserDetailDto>
    {

    }
}