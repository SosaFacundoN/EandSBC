using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using ExpenseTracking.Core;
using ExpenseTracking.Data;
using Microsoft.Extensions.Configuration;

namespace ExpenseTracking.Pages.AppPages
{
    public class ServicesModel : PageModel
    {
        public ServicesModel(IConfiguration config, IOperationData serviceData, IHtmlHelper htmlHelper)
        {
            this.htmlHelper = htmlHelper;
            this.config = config;
            this.serviceData = serviceData;
        }
        private readonly IHtmlHelper htmlHelper;
        private readonly IConfiguration config;
        private IOperationData serviceData;

        [BindProperty(SupportsGet = true)]
        public string SearchTerm { get; set; }
        public IEnumerable<Operation> Services { get; set; }
        public IEnumerable<SelectListItem> Type { get; set; }
        [BindProperty]
        public Service Service { get; set; }

        public IActionResult OnGet(int? serviceId)
        {
            Services = serviceData.GetOperationsByDescription(SearchTerm);
            Type = htmlHelper.GetEnumSelectList<Operation.OperationType>();

            if (serviceId.HasValue && Service.IsService == true)
            {
                Services = (IEnumerable<Operation>)serviceData.GetById(serviceId.Value);

                serviceData.Delete(Service);
                    return Page();
            }
            else
            {
                Service = new Service();
            }
            return Page();
        }

        public IActionResult OnPost()
        {
            int id = 0;
            id = Service.Id;
            id = id++;

            if (!ModelState.IsValid)
            {
                return Page();
            }
            if (Service.Id < id)
            {
                serviceData.Update(Service);
            }
            else
            {
                serviceData.Add(Service);
                Service.IsService = true;
            }
            serviceData.Commit();
            return RedirectToPage("./Services");


            /*if(Operation.Id > 0)
            {
                operationData.Update(Operation);
                operationData.Commit();
                return Page();
            }
            else
            {
                operationData.Add(Operation);
                operationData.Commit();
                return RedirectToPage("./CurrentDay", new { operationId = Operation.Id });
            }*/
        }

    }
}
