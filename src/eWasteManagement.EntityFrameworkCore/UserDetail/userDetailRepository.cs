using System;
using eWasteManagement.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace eWasteManagement.UserDetail
{
    public class userDetailRepository : EfCoreRepository<eWasteManagementDbContext, userDetail, Guid>, IuserDetailRepository
    {
        public userDetailRepository(IDbContextProvider<eWasteManagementDbContext> dbContextProvider) : base(dbContextProvider)
        {
        }
    }
}