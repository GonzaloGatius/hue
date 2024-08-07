using ASPHue.Pages.Products;
using libraryhue.Models.Characteristics;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace ASPHue.HelperMethods.SelectLists_and_Filters
{
    public static class SelectListsManager
    {
        public static List<SelectListItem> FillProductTypesSelectList(List<ProductTypesModel> productTypes) 
        {
            List<SelectListItem> list = new List<SelectListItem>();

            foreach (var i in productTypes)
            {
                var item = new SelectListItem { Value = i.Id.ToString(), Text = SpanishTranslator.GetTranslatedProductName(i.Name)};
                list.Add(item);
            }
            return list;
        }
    }
}
