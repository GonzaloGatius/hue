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
using System.Reflection;

namespace ASPHue.Pages.Products
{
    public class ProductsListModel : PageModel
    {
        private readonly ConnectionStringData connectionStringData;
        private readonly ISizesData sizesData;
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
        [BindProperty(SupportsGet = true)]
        public ProductTypesModel ProductTypeSelected { get; set; }
        [BindProperty(SupportsGet = true)]
        public string ProductTypeSelectedName { get; set; }
        public List<SelectListItem> productTypesSelectList { get; set; }
        public List<NeopreneGearsModel> Neoprenes { get; set; }
        public List<BCDsModel> BDCs { get; set; }
        public List<ClothesModel> ClothingModel { get; set; }
        public List<OctopusModel> Octopus { get; set; }
        public List<TanksModel> Tanks { get; set; }
        public ProductsListModel(ISizesData sizesData, IStatesData statesData, IProductTypesData productTypesData, ConnectionStringData connectionStringData, INeopreneGearsData neopreneGearsData, IBCDsData bcdsData, IFinsData finsData, IHoodsData hoodsData, IMasksData masksData, IOctopusData octopusData, ITanksData tanksData, IWeightsData weightData)
        {
            this.sizesData = sizesData;
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
        public async Task OnGetAsync()
        {
            var aasdf = ProductTypeSelectedListId;
            await GetProductTypeSelected();
            var productTypes = await productTypesData.GetAll<ProductTypesModel>();
            productTypesSelectList = SelectListsManager.FillProductTypesSelectList(productTypes);

            await GetProducts();
        }

        public async Task<IActionResult> OnPostDelete(int id, string type)
        {
            await GetProductTypeSelected();
            await GetProducts();
            
            await DeleteProduct(id, type);

            return RedirectToPage(new { ProductTypeSelectedListId });
        }


        private async Task GetProducts()
        {
            switch (ProductTypeSelected.Name)
            {
                case "Neoprene":
                    ClothingModel = await neopreneGearsData.GetAll<ClothesModel>();
                    break;
                case "BCDs":
                    BDCs = await bcdsData.GetAll<BCDsModel>();
                    break;
                case "Hoods":
                    ClothingModel = await hoodsData.GetAll<ClothesModel>();
                    break;
                case "Masks":
                    ClothingModel = await masksData.GetAll<ClothesModel>();
                    break;
                case "Fins":
                    ClothingModel = await finsData.GetAll<ClothesModel>();
                    break;
                case "Octopus":
                    Octopus = await octopusData.GetAll<OctopusModel>();
                    break;
                case "Tanks":
                    Tanks = await tanksData.GetAll<TanksModel>();
                    break;
                default:
                    ClothingModel = await neopreneGearsData.GetAll<ClothesModel>();
                    break;
            }
        }

        public async Task<string> GetStateName(int id)
        {
            var state = await statesData.GetById<StatesModel>(id);
            return state.Name;
        }
        public async Task<string> GetSizeName(int id)
        {
            var size = await sizesData.GetById<SizesModel>(id);
            return size.Name;
        }

        public async Task GetProductTypeSelected()
        {
            var productType =  await productTypesData.GetById<ProductTypesModel>(ProductTypeSelectedListId);
            ProductTypeSelected = productType;
            ProductTypeSelectedName = productType.Name;
        }

        public async Task DeleteProduct(int id, string type)
        {
            switch (type)
            {
                case "Neoprene":
                    await neopreneGearsData.Delete(id);
                    ProductTypeSelectedListId = 1;
                    break;
                case "BCDs":
                    await bcdsData.Delete(id);
                    ProductTypeSelectedListId = 6;
                    break;
                case "Hoods":
                    await hoodsData.Delete(id);
                    ProductTypeSelectedListId = 3;
                    break;
                case "Masks":
                    await masksData.Delete(id);
                    ProductTypeSelectedListId = 4;
                    break;
                case "Fins":
                    await finsData.Delete(id);
                    ProductTypeSelectedListId = 2;
                    break;
                case "Octopus":
                    await octopusData.Delete(id);
                    ProductTypeSelectedListId = 5;
                    break;
                case "Tanks":
                    await tanksData.Delete(id);
                    ProductTypeSelectedListId = 7;
                    break;
                default:
                    break;
            }
        }
    }
}
