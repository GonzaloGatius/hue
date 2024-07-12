using libraryhue.Data;
using libraryhue.DB;
using libraryhue.Models.Characteristics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Dapper;
using ASPHue.HelperMethods.SelectLists_and_Filters;
using libraryhue.Models.Products;
using System.Runtime.InteropServices.Marshalling;
using System.ComponentModel;

namespace ASPHue.Pages.Rents
{
    public class ProductsListModel : PageModel
    {

        private readonly IStatesData statesData;
        private readonly IProductTypesData productTypesData;
        private readonly ConnectionStringData connectionStringData;
        private readonly IBCDsData bcdsData;
        private readonly IFinsData finsData;
        private readonly IHoodsData hoodsData;
        private readonly IMasksData masksData;
        private readonly IOctopusData octopusData;
        private readonly ITanksData tanksData;
        private readonly IWeightsData weightData;
        private readonly INeopreneGearsData neopreneGearsData;

        [BindProperty(SupportsGet = true)]
        public int ProductTypeSelected { get; set; } = 4;

        public List<SelectListItem> productTypesSelect { get; set; }
        public List<ProductsModel> products { get; set; }
        public ProductsListModel(IStatesData statesData, IProductTypesData productTypesData, ConnectionStringData connectionStringData, INeopreneGearsData neopreneGearsData, IBCDsData bcdsData, IFinsData finsData, IHoodsData hoodsData, IMasksData masksData, IOctopusData octopusData, ITanksData tanksData, IWeightsData weightData)
        {
            this.statesData = statesData;
            this.productTypesData = productTypesData;
            this.connectionStringData = connectionStringData;
            this.bcdsData = bcdsData;
            this.finsData = finsData;
            this.hoodsData = hoodsData;
            this.masksData = masksData;
            this.octopusData = octopusData;
            this.tanksData = tanksData;
            this.weightData = weightData;
            this.neopreneGearsData = neopreneGearsData;
        }
        public async Task OnGet()
        {
            var productTypes = await productTypesData.GetAll<ProductTypesModel>();

            productTypesSelect = SelectListsManager.FillProductTypesSelectList(productTypes);

            products = await GetProducts();
        }

        private async Task<List<ProductsModel>> GetProducts()
        {
            switch (ProductTypeSelected)
            {
                case 1:
                    return await bcdsData.GetAll<ProductsModel>();
                case 2:
                    return await finsData.GetAll<ProductsModel>();
                case 3:
                    return await hoodsData.GetAll<ProductsModel>();
                case 4:
                    return await masksData.GetAll<ProductsModel>();
                case 5:
                    return await neopreneGearsData.GetAll<ProductsModel>();
                case 6:
                    return await octopusData.GetAll<ProductsModel>();
                case 7:
                    return await tanksData.GetAll<ProductsModel>();
                case 8:
                    return await weightData.GetAll<ProductsModel>();
                default: return null;


            }


        }
    }
}
