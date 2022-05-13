using System;
using eWasteManagement.Permissions;
using eWasteManagement.UserDetail.Dtos;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace eWasteManagement.UserDetail
{
    public class userDetailAppService : CrudAppService<userDetail, userDetailDto, Guid, PagedAndSortedResultRequestDto, CreateUpdateuserDetailDto, CreateUpdateuserDetailDto>,
        IuserDetailAppService
    {
        protected override string GetPolicyName { get; set; } = eWasteManagementPermissions.userDetail.Default;
        protected override string GetListPolicyName { get; set; } = eWasteManagementPermissions.userDetail.Default;
        protected override string CreatePolicyName { get; set; } = eWasteManagementPermissions.userDetail.Create;
        protected override string UpdatePolicyName { get; set; } = eWasteManagementPermissions.userDetail.Update;
        protected override string DeletePolicyName { get; set; } = eWasteManagementPermissions.userDetail.Delete;

        private readonly IuserDetailRepository _repository;
        
        public userDetailAppService(IuserDetailRepository repository) : base(repository)
        {
            _repository = repository;
        }
    }
}
