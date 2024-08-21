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
        public NeopreneGearsModel NeopreneModel { get; set; }
        [BindProperty]
        public FinsModel FinModel { get; set; }
        [BindProperty]
        public HoodsModel HoodModel { get; set; }
        [BindProperty]
        public MasksModel MaskModel { get; set; }
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
        public async void OnGetAsync()
        {
            await GetItem(Type, Id);
            await SelectListsManager.FillSelectStates(statesData, StatesSelectList);
            await SelectListsManager.FillSelectSizes(sizesData, SizesSelectList);
        }

        public async void OnPostAsync()
        {
            await SelectListsManager.FillSelectStates(statesData, StatesSelectList);
            await SelectListsManager.FillSelectSizes(sizesData, SizesSelectList);
            await UpdateItem(Type, Id, NeopreneModel);



        }
        //Viendo para que el edit de los Clothes funcione con la interfaz.
        private async Task GetItem(string productType, int id)
        {
            switch (productType)
            {
                case "Neoprene":
                    NeopreneModel = await neopreneGearsData.GetById<NeopreneGearsModel>(id);
                    break;
                case "BCDs":
                    BCDModel = await bcdsData.GetById<BCDsModel>(id);
                    break;
                case "Hoods":
                    HoodModel = await hoodsData.GetById<HoodsModel>(id);
                    break;
                case "Masks":
                    MaskModel = await masksData.GetById<MasksModel>(id);
                    break;
                case "Fins":
                    FinModel = await finsData.GetById<FinsModel>(id);
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
        private async Task UpdateItem(string productType, int id, object _obj)
        {
            switch (productType)
            {
                case "Neoprene":
                    await neopreneGearsData.UpdateObject(id, _obj);
                    break;
                case "BCDs":
                    await bcdsData.UpdateObject(id, _obj); 
                    break;
                case "Hoods":
                    await hoodsData.UpdateObject(id, _obj);
                    break;
                case "Masks":
                    await masksData.UpdateObject(id, _obj);
                    break;
                case "Fins":
                    await finsData.UpdateObject(id, _obj);
                    break;
                case "Octopus":
                    await octopusData.UpdateObject(id, _obj);
                    break;
                case "Tanks":
                    await tanksData.UpdateObject(id, _obj);
                    break;
                default:
                    break;
            }
        }
    }
}
