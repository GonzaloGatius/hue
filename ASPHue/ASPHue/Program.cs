using libraryhue.Data;
using libraryhue.DB;
using libraryhue;
using ASPHue.HelperMethods.SelectLists_and_Filters;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();

builder.Services.AddSingleton(new ConnectionStringData
{
    ConnectionStringName = "Default"
});
builder.Services.AddSingleton<IDataAccess, SqlDB>();

builder.Services.AddSingleton<IUserData, UserData>();
builder.Services.AddSingleton<IBCDsData, BCDsData>();
builder.Services.AddSingleton<IBrandsData, BrandsData>();
builder.Services.AddSingleton<IColorsData, ColorsData>();
builder.Services.AddSingleton<IFinsData, FinsData>();
builder.Services.AddSingleton<IHoodsData, HoodsData>();
builder.Services.AddSingleton<IMasksData, MasksData>();
builder.Services.AddSingleton<INeopreneGearsData, NeopreneGearsData>();
builder.Services.AddSingleton<IOctopusData, OctopusData>();
builder.Services.AddSingleton<IOctopusPartsData, OctopusPartsData>();
builder.Services.AddSingleton<IProductTypesData, ProductTypesData>();
builder.Services.AddSingleton<IRentalCartData, RentalCartData>();
builder.Services.AddSingleton<IRentalsData, RentalsData>();
builder.Services.AddSingleton<ISizesData, SizesData>();
builder.Services.AddSingleton<IStatesData, StatesData>();
builder.Services.AddSingleton<ITanksData, TanksData>();
builder.Services.AddSingleton<IWeightsData, WeightsData>();
builder.Services.AddSingleton<IWeightTypesData, WeightTypesData>();
builder.Services.AddSingleton<SelectListsManager, SelectListsManager>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
