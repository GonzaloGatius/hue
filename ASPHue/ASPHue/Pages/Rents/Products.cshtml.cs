using libraryhue.Data;
using libraryhue.DB;
using libraryhue.Models.Characteristics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Dapper;
using ASPHue.HelperMethods.SelectLists_and_Filters;

namespace ASPHue.Pages.Rents
{
    public class ProductsModel : PageModel
    {

        private readonly IStatesData statesData;
        private readonly IProductTypesData productTypesData;
        private readonly ConnectionStringData connectionStringData;
        private readonly SelectListsManager selectListsManager;

        [BindProperty]
        public int ProductTypeSelected { get; set; }

        public List<SelectListItem> productTypesModels { get; set; }

        public ProductsModel(IStatesData statesData, IProductTypesData productTypesData, ConnectionStringData connectionStringData, SelectListsManager selectListsManager)
        {
            this.statesData = statesData;
            this.productTypesData = productTypesData;
            this.connectionStringData = connectionStringData;
            this.selectListsManager = selectListsManager;
        }
        public async Task OnGet()
        {
            var productTypes = await productTypesData.GetAll<ProductTypesModel>();

            productTypesModels = selectListsManager.FillProductTypesSelectList(productTypes);
        }

        private static void CallData() { }

        //private async Task<List<ProductTypesModel>> GetAllProductTypes()
        //{
        //    List<ProductTypesModel> list = await productTypesData.GetAll<ProductTypesModel>();

        //    foreach (ProductTypesModel productType in list)
        //    {
        //        productTypesModels.Add(productType);
        //    }


        //}

    }
}
