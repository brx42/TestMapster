using Mapster;
using TestMapster.Dto;
using TestMapster.Models;

namespace TestMapster.MapsterProfile;

public class OrganizationProfile : IRegister
{
    public void Register(TypeAdapterConfig config)
    {
        config.NewConfig<Organization, OrganizationSecondDto>()
            .Map(dst => dst.DtoId, src => src.Id)
            .Map(dst => dst.DtoName, src => src.Name)
            .Map(dst => dst.DtoIsLegalEntity, src => src.IsLegalEntity)
            .Map(dst => dst.DtoEmployees, src => src.Employees);
        
        config.NewConfig<OrganizationSecondDto, Organization>()
            .Map(dst => dst.Id, src => src.DtoId)
            .Map(dst => dst.Name, src => src.DtoName)
            .Map(dst => dst.IsLegalEntity, src => src.DtoIsLegalEntity)
            .Map(dst => dst.Employees, src => src.DtoEmployees);
    }
}