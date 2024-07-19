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
using ASPHue.HelperMethods.TableManagement;
using System.Reflection;

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
        public int ProductTypeSelected { get; set; } = 1;

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
            string name = await GetSelectedProductName(ProductTypeSelected);
            switch (name)
            {
                case "Neoprene":
                    return await neopreneGearsData.GetAll<ProductsModel>();
                case "BCDs":
                    return await bcdsData.GetAll<ProductsModel>();
                case "Hoods":
                    return await hoodsData.GetAll<ProductsModel>();
                case "Masks":
                    return await masksData.GetAll<ProductsModel>();
                case "Octopus":
                    return await octopusData.GetAll<ProductsModel>();
                case "Tanks":
                    return await tanksData.GetAll<ProductsModel>();
                case "Fins":
                    return await finsData.GetAll<ProductsModel>();
                case "Weights":
                    return await weightData.GetAll<ProductsModel>();
                default: return null;
            }
        }

        public async Task<string> GetSelectedProductName(int id)
        {
            return await productTypesData.GetProductNameById<string>(id);
        }

        public async Task<bool> CheckMethod(int id, string columnName)
        {
            switch (columnName)
            {
                case "Name":
                    return ColumnChecker.CheckIfName(await GetSelectedProductName(id));
                case "Model":
                    return ColumnChecker.CheckIfModel(await GetSelectedProductName(id));
                case "Brand":
                    return ColumnChecker.CheckIfBrand(await GetSelectedProductName(id));
                case "Color":
                    return ColumnChecker.CheckIfColor(await GetSelectedProductName(id));
                case "Size":
                    return ColumnChecker.CheckIfSize(await GetSelectedProductName(id));
                case "":
                    return ColumnChecker.CheckIfBrand(await GetSelectedProductName(id));
            }
        }
    }
}
