using AutoMapper;
using productManagement.Dtos;
using productManagement.Web.Pages.Products;

namespace productManagement.Web;

public class productManagementWebAutoMapperProfile : Profile
{
    public productManagementWebAutoMapperProfile()
    {
        //Define your object mappings here, for the Web project
        CreateMap<CreateEditProductViewModel,CreateUpdateProductDto>();
    }
}
