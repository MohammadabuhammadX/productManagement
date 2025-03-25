using productManagement.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Domain.Repositories;
using System.Linq.Dynamic.Core;


namespace productManagement.Products
{
    public class ProductAppService : productManagementAppService, IProductAppService
    {
        private readonly IRepository<Product, Guid> _productRepository;
        public ProductAppService(
            IRepository<Product, Guid> productRepository)
        {
            _productRepository = productRepository;
        }
        public async Task<PagedResultDto<ProductDto>> GetListAsync(PagedAndSortedResultRequestDto input)
        {
            var queryable = await _productRepository.WithDetailsAsync(x => x.Category);

            queryable = queryable
                .Skip(input.SkipCount)
                .Take(input.MaxResultCount)
                .OrderBy(input.Sorting ?? nameof(Product.Name));


            var products = await AsyncExecuter.ToListAsync(queryable);
            var count = await _productRepository.GetCountAsync();
            return new PagedResultDto<ProductDto>(count,ObjectMapper.Map<List<Product>, List<ProductDto>>(products));
        }
    }
}
