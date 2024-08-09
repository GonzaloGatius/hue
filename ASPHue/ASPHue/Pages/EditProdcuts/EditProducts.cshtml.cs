using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace ASPHue.Pages.EditProdcuts
{
    public class EditProductsModel : PageModel
    {
        [BindProperty(SupportsGet = true)]
        public string Id { get; set; }
        public void OnGet()
        {
        }
    }
}
