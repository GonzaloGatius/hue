using ASPHue.Pages.Products;
using libraryhue.Data;
using libraryhue.Models.Characteristics;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace ASPHue.HelperMethods.SelectLists_and_Filters
{
    public static class SelectListsManager
    {
        public static List<SelectListItem> FillProductTypesSelectList(List<ProductTypesModel> productTypes) 
        {
            var list = new List<SelectListItem>();

            foreach (var i in productTypes)
            {
                var item = new SelectListItem { Value = i.Id.ToString(), Text = SpanishTranslator.GetTranslatedProductName(i.Name)};
                list.Add(item);
            }
            return list;
        }

        public static async Task FillSelectStates(IStatesData statesData, List<SelectListItem> statesSelectList)
        {
            var states = await statesData.GetAll<StatesModel>();
            foreach (var i in states)
            {
                var item = new SelectListItem { Value = i.Id.ToString(), Text = i.Name };
                statesSelectList.Add(item);
            }
        }

        public static async Task FillSelectSizes(ISizesData sizesData, List<SelectListItem> sizesSelectList)
        {
            var sizes = await sizesData.GetAll<SizesModel>();
            foreach (var i in sizes)
            {
                var item = new SelectListItem { Value = i.Id.ToString(), Text = i.Name };
                sizesSelectList.Add(item);
            }
        }
    }
}
