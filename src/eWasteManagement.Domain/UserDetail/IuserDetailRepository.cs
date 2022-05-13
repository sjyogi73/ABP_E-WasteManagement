using System;
using Volo.Abp.Domain.Repositories;

namespace eWasteManagement.UserDetail
{
    public interface IuserDetailRepository : IRepository<userDetail, Guid>
    {
    }
}