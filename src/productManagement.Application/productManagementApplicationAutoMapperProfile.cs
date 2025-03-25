using AutoMapper;
using productManagement.Dtos;
using productManagement.Products;

namespace productManagement;

public class productManagementApplicationAutoMapperProfile : Profile
{
    public productManagementApplicationAutoMapperProfile()
    {
        /* You can configure your AutoMapper mapping configuration here.
         * Alternatively, you can split your mapping configurations
         * into multiple profile classes for a better organization. */
        CreateMap<Product, ProductDto>();
    }
}
