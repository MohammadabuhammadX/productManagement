using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using productManagement.Dtos;
using productManagement.Products;
using System;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Threading.Tasks;

namespace productManagement.Web.Pages.Products
{
    public class EditProductModalModel : productManagementPageModel
    {
        [HiddenInput]
        [BindProperty(SupportsGet = true)]
        public Guid Id { get; set; }
        [BindProperty]
        public CreateEditProductViewModel Product{ get; set; }
        public SelectListItem[] Categories { get; set; }

        private readonly IProductAppService _productAppService;

        public EditProductModalModel(IProductAppService productAppService)
        {
            _productAppService = productAppService;
        }

        public async Task OnGetAsync()
        {
            var product = await _productAppService.GetAsync(Id);
            Product = ObjectMapper.Map<ProductDto, CreateEditProductViewModel> (product);


            var categoryLookup = await _productAppService.GetCategoriesAsync();
            Categories = categoryLookup.Items
                .Select(x => new SelectListItem(x.Name, x.Id.ToString()))
                .ToArray();
        }
        public async Task<IActionResult> OnPostAsync()
        {
            await _productAppService.UpdateAsync(Id,
                ObjectMapper.Map<CreateEditProductViewModel, CreateUpdateProductDto>(Product));
            return NoContent();
        }
    }
}
