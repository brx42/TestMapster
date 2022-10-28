using Mapster;
using TestMapster.Dto;
using TestMapster.Models;

namespace TestMapster.MapsterProfile;

public class EmployeeProfile : IRegister
{
    public void Register(TypeAdapterConfig config)
    {
        config.NewConfig<Employee, EmployeeLiteDto>();

        config.NewConfig<EmployeeLiteDto, Employee>();
        
        
        config.NewConfig<Employee, EmployeeHardDto>()
            .Map(dst => dst.DtoId, src => src.Id)
            .Map(dst => dst.DtoName, src => src.Name)
            .Map(dst => dst.DtoLastName, src => src.LastName)
            .Map(dst => dst.DtoPhoneNumber, src => src.PhoneNumber)
            .Map(dst => dst.DtoOrganizationId, src => src.OrganizationId);

        config.NewConfig<EmployeeHardDto, Employee>()
            .Map(dst => dst.Id, src => src.DtoId)
            .Map(dst => dst.Name, src => src.DtoName)
            .Map(dst => dst.LastName, src => src.DtoLastName)
            .Map(dst => dst.PhoneNumber, src => src.DtoPhoneNumber)
            .Map(dst => dst.OrganizationId, src => src.DtoOrganizationId);
    }
}