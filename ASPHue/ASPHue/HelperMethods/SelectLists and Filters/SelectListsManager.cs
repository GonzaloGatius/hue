using ASPHue.Pages.Rents;
using libraryhue.Models.Characteristics;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace ASPHue.HelperMethods.SelectLists_and_Filters
{
    public class SelectListsManager
    {


        public void FillProductTypesSelectList(List<SelectListItem> list, List<ProductTypesModel> productTypes) 
        {
            foreach (var i in productTypes)
            {
                var item = new SelectListItem { Value = i.Id.ToString(), Text = i.Name };
                list.Add(item);
            }
        }
    }
}
