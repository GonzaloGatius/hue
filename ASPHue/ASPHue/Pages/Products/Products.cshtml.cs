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
        public string ProductTypeSelectedName { get; set; }
        public List<SelectListItem> productTypesSelectList { get; set; }
        public List<NeopreneGearsModel> Neoprenes { get; set; }
        public List<BCDsModel> BDCs { get; set; }
        public List<IClothes> ClothingModel { get; set; }
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
        public async Task OnGet()
        {
            //Neoprenes = Neoprenes2.OrderBy(x => x.Notes).ToList();
            await GetProductTypeSelected();
            var productTypes = await productTypesData.GetAll<ProductTypesModel>();
            productTypesSelectList = SelectListsManager.FillProductTypesSelectList(productTypes);

            await GetProducts();
        }
        
        private async Task GetProducts()
        {
            switch (ProductTypeSelected.Name)
            {
                case "Neoprene":
                    List<NeopreneGearsModel> neopreneList = await neopreneGearsData.GetAll<NeopreneGearsModel>();
                    ClothingModel = neopreneList.Cast<IClothes>().ToList();
                    break;
                case "BCDs":
                    BDCs = await bcdsData.GetAll<BCDsModel>();
                    break;
                case "Hoods":
                    List<HoodsModel> hoodsList = await hoodsData.GetAll<HoodsModel>();
                    ClothingModel = hoodsList.Cast<IClothes>().ToList();
                    break;
                case "Masks":
                    List<MasksModel> masksList = await masksData.GetAll<MasksModel>();
                    ClothingModel = masksList.Cast<IClothes>().ToList();
                    break;
                case "Fins":
                    List<FinsModel> finsList = await finsData.GetAll<FinsModel>();
                    ClothingModel = finsList.Cast<IClothes>().ToList();
                    break;
                case "Octopus":
                    Octopus = await octopusData.GetAll<OctopusModel>();
                    break;
                case "Tanks":
                    Tanks = await tanksData.GetAll<TanksModel>();
                    break;
                default:
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
    }
}
