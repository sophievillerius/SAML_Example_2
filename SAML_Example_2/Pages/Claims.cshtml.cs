using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace SAML_Example_2.Pages
{
    [Authorize]
    public class ClaimsModel : PageModel
    {
        public void OnGet()
        {
        }
    }
}
