using System;
using System.Collections.Generic;
using System.Text;
using eWasteManagement.Localization;
using Volo.Abp.Application.Services;

namespace eWasteManagement;

/* Inherit your application services from this class.
 */
public abstract class eWasteManagementAppService : ApplicationService
{
    protected eWasteManagementAppService()
    {
        LocalizationResource = typeof(eWasteManagementResource);
    }
}
