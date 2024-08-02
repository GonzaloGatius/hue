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
        private readonly ConnectionStringData connectionStringData;
        private readonly IStatesData statesData;
        private readonly IProductTypesData productTypesData;
        private readonly IBCDsData bcdsData;
        private readonly IFinsData finsData;
        private readonly IHoodsData hoodsData;
        private readonly IMasksData masksData;
        private readonly IOctopusData octopusData;
        private readonly ITanksData tanksData;
        private readonly IWeightsData weightData;
        private readonly INeopreneGearsData neopreneGearsData;

        [BindProperty(SupportsGet = true)]
        public int ProductTypeSelectedListId { get; set; } = 1;
        public string ProductTypeSelectedName { get; set; }

        public ProductTypesModel ProductTypeSelected { get; set; }

        public List<SelectListItem> productTypesSelect { get; set; }
        public List<IProductsModel> products { get; set; }
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
            await GetProductTypeSelected();
            products = await GetProducts();
        }

        private async Task<List<IProductsModel>> GetProducts()
        {
            ProductTypeSelectedName = await GetSelectedProductName(ProductTypeSelectedListId);
            switch (ProductTypeSelectedName)
            {
                case "Neoprene":
                    return await neopreneGearsData.GetAll<IProductsModel>();
                case "BCDs":
                    return await bcdsData.GetAll<IProductsModel>(); //Viendo con interfaz.
                case "Hoods":
                    return await hoodsData.GetAll<IProductsModel>();
                case "Masks":
                    return await masksData.GetAll<IProductsModel>();
                case "Octopus":
                    return await octopusData.GetAll<IProductsModel>();
                case "Tanks":
                    return await tanksData.GetAll<IProductsModel>();
                case "Fins":
                    return await finsData.GetAll<IProductsModel>();
                case "Weights":
                    return await weightData.GetAll<IProductsModel>();
                default: return null;
            }
        }

        public async Task<string> GetSelectedProductName(int id)
        {
            return await productTypesData.GetProductNameById<string>(id);
        }

        public async Task<string> GetStateName(int id)
        {
            var state = await statesData.GetById<StatesModel>(id);
            return state.Name;
        }

        public async Task GetProductTypeSelected()
        {
            ProductTypeSelected = await productTypesData.GetById<ProductTypesModel>(ProductTypeSelectedListId);
        }



    }
}
