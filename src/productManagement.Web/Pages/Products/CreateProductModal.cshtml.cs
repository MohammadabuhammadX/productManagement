using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using productManagement.Products;
using System.Threading.Tasks;
using System.Linq;
using Microsoft.AspNetCore.Mvc.Rendering;
using productManagement.Dtos;

namespace productManagement.Web.Pages.Products
{
    public class CreateProductModalModel : productManagementPageModel
    {
        [BindProperty]
        public CreateEditProductViewModel Product { get; set; }
        public SelectListItem[] Categories { get; set; }

        private readonly IProductAppService _productAppService;

        public CreateProductModalModel(IProductAppService productAppService)
        {
            _productAppService = productAppService;
        }

        public async void OnGetAsync()
        {
            Product = new CreateEditProductViewModel
            {
                ReleaseDate = Clock.Now,
                StockState = ProductStockState.PreOrder,
            };

            var categoryLookup = await _productAppService.GetCategoriesAsync();
            Categories = categoryLookup.Items
                        .Select(x => new SelectListItem(x.Name, x.Id.ToString()))
                        .ToArray();
        }
        public async Task<IActionResult> OnPostAsync()
        {
            await _productAppService.CreateAsync(ObjectMapper
                .Map<CreateEditProductViewModel, CreateUpdateProductDto>(Product));
            return NoContent();
        }
    }
}
