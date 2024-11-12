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

        [BindProperty(SupportsGet = true)]
        public string IntNumberWarning { get; set; } = string.Empty;
       
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


            if(!await CheckDuplicates(Type))
            {
                await UpdateItem(Type, Id);
                int ProductTypeSelectedListId = GetItemTypeId(Type);
                return RedirectToPage("../Products/Products", new { ProductTypeSelectedListId });
            }
            else
            {
                IntNumberWarning = "  *Número de interno ya en uso.";
                return RedirectToPage(new {IntNumberWarning, Type, Id });
            }
            
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
                    NeopreneGearsModel neoprene = await neopreneGearsData.GetById<NeopreneGearsModel>(Id); 
                    List<ClothesModel> clothes = await neopreneGearsData.GetAll<ClothesModel>();
                    var IdRepeated = (neoprene.InternNumber !=  ClothingModel.InternNumber && clothes.Any(x => x.InternNumber == ClothingModel.InternNumber));
                    return IdRepeated;
                case "Hoods":
                    HoodsModel hood = await hoodsData.GetById<HoodsModel>(Id);
                    clothes = await hoodsData.GetAll<ClothesModel>();
                    IdRepeated = (hood.InternNumber != ClothingModel.InternNumber && clothes.Any(x => x.InternNumber == ClothingModel.InternNumber));
                    return IdRepeated;
                case "Masks":
                    MasksModel mask = await masksData.GetById<MasksModel>(Id);
                    clothes = await masksData.GetAll<ClothesModel>();
                    IdRepeated = (mask.InternNumber != ClothingModel.InternNumber && clothes.Any(x => x.InternNumber == ClothingModel.InternNumber));
                    return IdRepeated;
                case "Fins":
                    FinsModel fins = await finsData.GetById<FinsModel>(Id);
                    clothes = await finsData.GetAll<ClothesModel>();
                    IdRepeated = (fins.InternNumber != ClothingModel.InternNumber && clothes.Any(x => x.InternNumber == ClothingModel.InternNumber));
                    return IdRepeated;
                case "BCDs":
                    BCDsModel bcd = await bcdsData.GetById<BCDsModel>(Id);
                    List<BCDsModel> bcds = await bcdsData.GetAll<BCDsModel>();
                    IdRepeated = (bcd.InternNumber != ClothingModel.InternNumber && bcds.Any(x => x.InternNumber == ClothingModel.InternNumber));
                    return IdRepeated;
                case "Octopus":
                    OctopusModel octopus = await octopusData.GetById<OctopusModel>(Id);
                    List<OctopusModel> octopusList = await octopusData.GetAll<OctopusModel>();
                    IdRepeated = (octopus.InternNumber != ClothingModel.InternNumber && octopusList.Any(x => x.InternNumber == ClothingModel.InternNumber));
                    return IdRepeated;
                case "Tanks":
                    TanksModel tank = await tanksData.GetById<TanksModel>(Id);
                    List<TanksModel> tanks = await tanksData.GetAll<TanksModel>();
                    IdRepeated = (tank.InternNumber != ClothingModel.InternNumber && tanks.Any(x => x.InternNumber == ClothingModel.InternNumber));
                    return IdRepeated;
                default:
                    return true;
            }
        }
    }
}
