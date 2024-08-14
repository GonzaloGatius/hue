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
        public IAccesories AccesoryModel { get; set; }
        public NeopreneGearsModel NeopreneGearModel { get; set; }
        public BCDsModel BCDModel { get; set; }
        public OctopusModel OctopusModel { get; set; }
        public TanksModel TankModel { get; set; }
        public List<SelectListItem> StatesSelectList { get; set; } = new List<SelectListItem>();
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
            await FillSelectStates();
            await FillSizesSelect();
        }

        private async Task GetItem(string productType, int id)
        {
            switch (productType)
            {
                case "Neoprene":
                    NeopreneGearModel = await neopreneGearsData.GetById<NeopreneGearsModel>(id);
                    break;
                case "BCDs":
                    BCDModel = await bcdsData.GetById<BCDsModel>(id);
                    break;
                case "Hoods":
                    AccesoryModel = await hoodsData.GetById<HoodsModel>(id);
                    break;
                case "Masks":
                    AccesoryModel = await masksData.GetById<MasksModel>(id);
                    break;
                case "Fins":
                    AccesoryModel = await finsData.GetById<FinsModel>(id);
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

        public async Task FillSelectStates()
        {
            var states = await statesData.GetAll<StatesModel>();
            foreach (var i in states)
            {
                var item = new SelectListItem { Value = i.Id.ToString(), Text = i.Name };
                StatesSelectList.Add(item);
            }
        }
        public async Task FillSizesSelect()
        {
            var sizes = await sizesData.GetAll<SizesModel>();
            foreach (var i in sizes)
            {
                var item = new SelectListItem { Value = i.Id.ToString(), Text = i.Name };
                SizesSelectList.Add(item);
            }
        }
    }
}
