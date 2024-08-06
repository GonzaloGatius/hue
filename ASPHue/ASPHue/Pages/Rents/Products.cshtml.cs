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
        public ProductTypesModel ProductTypeSelected { get; set; }
        public List<SelectListItem> productTypesSelect { get; set; }
        public List<NeopreneGearsModel> Neoprenes { get; set; }
        public List<BCDsModel> BDCs { get; set; }
        public List<HoodsModel> Hoods { get; set; }
        public List<MasksModel> Masks { get; set; }
        public List<FinsModel> Fins { get; set; }
        public List<OctopusModel> Octopus { get; set; }
        public List<TanksModel> Tanks { get; set; }
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
            await GetProductTypeSelected();
            var productTypes = await productTypesData.GetAll<ProductTypesModel>();

            productTypesSelect = SelectListsManager.FillProductTypesSelectList(productTypes);

            await GetProducts();
        }

        private async Task GetProducts()
        {
            switch (ProductTypeSelected.Name)
            {
                case "Neoprene":
                    Neoprenes=  await neopreneGearsData.GetAll<NeopreneGearsModel>();
                    break;
                case "BCDs":
                    BDCs = await bcdsData.GetAll<BCDsModel>();
                    break;
                case "Hoods":
                    Hoods = await hoodsData.GetAll<HoodsModel>();
                    break;
                case "Masks":
                    Masks = await masksData.GetAll<MasksModel>();
                    break;
                case "Octopus":
                    Octopus = await octopusData.GetAll<OctopusModel>();
                    break;
                case "Tanks":
                    Tanks = await tanksData.GetAll<TanksModel>();
                    break;
                case "Fins":
                    Fins = await finsData.GetAll<FinsModel>();
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

        public async Task GetProductTypeSelected()
        {
            ProductTypeSelected = await productTypesData.GetById<ProductTypesModel>(ProductTypeSelectedListId);
        }
        public void GetProductName(IProductsModel product)
        {
            switch (product)
            {
                case NeopreneGearsModel neopreneGears:
                    product.Name = neopreneGears.Name;
                    break;
                case BCDsModel bCDsModel:
                    product.Name = bCDsModel.Brand + ", " + bCDsModel.Model;
                    break;
                case FinsModel finsModel:
                    product.Name = finsModel.Brand + ", " + finsModel.Model;
                    break;
                case HoodsModel hoodsModel:
                    product.Name = hoodsModel.Brand + ", " + hoodsModel.Model;
                    break;
                case MasksModel masksModel:
                    product.Name = masksModel.Brand + ", " + masksModel.Model;
                    break;
                case OctopusModel octopusModel:
                    product.Name = octopusModel.Brand + ", " + octopusModel.Model;
                    break;
                case TanksModel tanksModel:
                    product.Name = "Válvulas: " + tanksModel.TankValves + ", " + tanksModel.Capacity + " lts.";
                    break;
                default:
                    break;
            }
        }
    }
}
