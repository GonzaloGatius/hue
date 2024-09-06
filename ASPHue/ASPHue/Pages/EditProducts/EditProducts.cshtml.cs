using ASPHue.HelperMethods.SelectLists_and_Filters;
using libraryhue.Data;
using libraryhue.DB;
using libraryhue.Models.Characteristics;
using libraryhue.Models.Products;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Threading.Tasks;

namespace ASPHue.Pages.EditProdcuts
{
    public class EditProductsModel : PageModel
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
        public int Id { get; set; }

        [BindProperty(SupportsGet = true)]
        public string Type { get; set; }

        [BindProperty]
        public ClothesModel ClothingModel { get; set; }
       
        [BindProperty]
        public BCDsModel BCDModel { get; set; }
        [BindProperty]
        public OctopusModel OctopusModel { get; set; }
        [BindProperty]
        public TanksModel TankModel { get; set; }

        [BindProperty]
        public List<SelectListItem> StatesSelectList { get; set; } = new List<SelectListItem>();

        [BindProperty]
        public List<SelectListItem> SizesSelectList { get; set; } = new List<SelectListItem>();

        public EditProductsModel(ISizesData sizesData, IStatesData statesData, IProductTypesData productTypesData, ConnectionStringData connectionStringData, INeopreneGearsData neopreneGearsData, IBCDsData bcdsData, IFinsData finsData, IHoodsData hoodsData, IMasksData masksData, IOctopusData octopusData, ITanksData tanksData, IWeightsData weightData)
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

            await SelectListsManager.FillSelectStates(statesData, StatesSelectList);
            await SelectListsManager.FillSelectSizes(sizesData, SizesSelectList);
            await GetItem(Type, Id);
            
        }

        public async Task<IActionResult> OnPostAsync()
        {
            await SelectListsManager.FillSelectStates(statesData, StatesSelectList);
            await SelectListsManager.FillSelectSizes(sizesData, SizesSelectList);
           
            await UpdateItem(Type, Id);
            int ProductTypeSelectedListId = GetItemTypeId(Type);
            return RedirectToPage("../Products/Products", new { ProductTypeSelectedListId });
            
        }
        //Viendo para que el edit de los Clothes funcione con la interfaz.
        private async Task GetItem(string productType, int id)
        {
            switch (productType)
            {
                case "Neoprene":
                    ClothingModel = await neopreneGearsData.GetById<ClothesModel>(id);
                    break;
                case "BCDs":
                    BCDModel = await bcdsData.GetById<BCDsModel>(id);
                    break;
                case "Hoods":
                    ClothingModel = await hoodsData.GetById<ClothesModel>(id);
                    break;
                case "Masks":
                    ClothingModel = await masksData.GetById<ClothesModel>(id);
                    break;
                case "Fins":
                    ClothingModel = await finsData.GetById<ClothesModel>(id);
                    break;
                case "Octopus":
                    OctopusModel = await octopusData.GetById<OctopusModel>(id);
                    break;
                case "Tanks":
                    TankModel = await tanksData.GetById<TanksModel>(id);
                    break;
                default:
                    break;
            }
        }
        private async Task UpdateItem(string productType, int id)
        {
            switch (productType)
            {
                case "Neoprene":
                    await neopreneGearsData.UpdateObject(id, ClothingModel);
                    break;
                case "BCDs":
                    await bcdsData.UpdateObject(id, BCDModel); 
                    break;
                case "Hoods":
                    await hoodsData.UpdateObject(id, ClothingModel);
                    break;
                case "Masks":
                    await masksData.UpdateObject(id, ClothingModel);
                    break;
                case "Fins":
                    await finsData.UpdateObject(id, ClothingModel);
                    break;
                case "Octopus":
                    await octopusData.UpdateObject(id, OctopusModel);
                    break;
                case "Tanks":
                    await tanksData.UpdateObject(id, TankModel);
                    break;
                default:
                    break;
            }
        }
        private int GetItemTypeId(string productType)
        {
            switch (productType)
            {
                case "Neoprene":
                    return 1;
                case "BCDs":
                    return 6;
                case "Hoods":
                    return 3;
                case "Masks":
                    return 4;
                case "Fins":
                    return 2;
                case "Octopus":
                    return 5; 
                case "Tanks":
                    return 7;
                default:
                    return 1;
            }
        }

        private async Task<bool> CheckDuplicates(string productType)
        {
            switch (productType)
            {
                case "Neoprene":
                    var neoprenes = await neopreneGearsData.GetAll<ClothesModel>();
                    return neoprenes.Any(x => x.InternNumber == ClothingModel.InternNumber);
                case "BCDs":
                    var BCDs = await bcdsData.GetAll<ClothesModel>();
                    return BCDs.Any(x => x.InternNumber == BCDModel.InternNumber);
                case "Hoods":
                    var Hoods = await hoodsData.GetAll<ClothesModel>();
                    return Hoods.Any(x => x.InternNumber == ClothingModel.InternNumber);
                case "Masks":
                    var Masks = await masksData.GetAll<ClothesModel>();
                    return Masks.Any(x => x.InternNumber == ClothingModel.InternNumber);
                case "Fins":
                    var Fins = await finsData.GetAll<ClothesModel>();
                    return Fins.Any(x => x.InternNumber == ClothingModel.InternNumber);
                case "Octopus":
                    var Octopus = await octopusData.GetAll<ClothesModel>();
                    return Octopus.Any(x => x.InternNumber == OctopusModel.InternNumber);
                case "Tanks":
                    var Tanks = await tanksData.GetAll<ClothesModel>();
                    return Tanks.Any(x => x.InternNumber == TankModel.InternNumber);
                default:
                    return true;
            }
        }
    }
}
