using System.Threading.Tasks;

namespace eWasteManagement.Web.Pages.UserDetail.userDetail
{
    public class IndexModel : eWasteManagementPageModel
    {
        public virtual async Task OnGetAsync()
        {
            await Task.CompletedTask;
        }
    }
}
