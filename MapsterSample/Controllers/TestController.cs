using MapsterMapper;
using Microsoft.AspNetCore.Mvc;
using TestMapster.Dto;
using TestMapster.Enum;
using TestMapster.Models;

namespace TestMapster.Controllers;

[ApiController]
[Route("api/test")]
public class TestController : ControllerBase
{
    private Organization _organization = new()
    {
        Id = 1,
        Name = "The Horde",
        IsLegalEntity = true,
        Employees = new List<Employee>
        {
            new()
            {
                Id = new Guid("312DEE80-09EC-4FDA-B9E0-EA3A304B4A68"),
                Name = "Thrall",
                LastName = "Leader of The Horde",
                PhoneNumber = PhoneNumber.FirstNumber,
                OrganizationId = 1
            },
            new()
            {
                Id = new Guid("60EE49E2-2B29-4DAF-9BF5-1DE1E429374E"),
                Name = "Garrosh",
                LastName = "Hellscream",
                PhoneNumber = PhoneNumber.SecondNumber,
                OrganizationId = 1
            },
            new()
            {
                Id = new Guid("DDA3E7AB-78DB-47F4-A6CB-CBB7441AF942"),
                Name = "Sylvanas",
                LastName = "Windrunner",
                PhoneNumber = PhoneNumber.FirstNumber,
                OrganizationId = 1
            }
        }
    };

    private readonly IMapper _mapper;

    public TestController(IMapper mapper)
    {
        _mapper = mapper;
    }

    /// <summary>
    /// Получить организацию с обычным маппингом.
    /// </summary>
    /// <returns>Организация.</returns>
    [HttpGet("simple-first")]
    public ActionResult<Organization> SimpleOrganizationFirst()
    {
        var organizationDto = _mapper.Map<OrganizationLiteDto>(_organization);

        var result = _mapper.Map<Organization>(organizationDto);
        
        return Ok(result);
    }

    /// <summary>
    /// Получить коллекцию организаций с обычным маппингом.
    /// </summary>
    /// <returns>Коллекция организаций.</returns>
    [HttpGet("collection-first")]
    public ActionResult<IEnumerable<Organization>> CollectionOrganizationFirst()
    {
        var organizations = new List<Organization> { _organization };
        
        var organizationsDto = _mapper.Map<IEnumerable<OrganizationLiteDto>>(organizations);

        var result = _mapper.Map<IEnumerable<Organization>>(organizationsDto);
        
        return Ok(result);
    }

    /// <summary>
    /// Получить организацию со сложным маппингом.
    /// </summary>
    /// <returns>Организация.</returns>
    [HttpGet("simple-second")]
    public ActionResult<Organization> SimpleOrganizationSecond()
    {
        var organizationDto = _mapper.Map<OrganizationHardDto>(_organization);

        var result = _mapper.Map<Organization>(organizationDto);
        
        return Ok(result);
    }

    /// <summary>
    /// Получить коллекцию организаций со сложным маппингом.
    /// </summary>
    /// <returns>Коллекция организаций.</returns>
    [HttpGet("collection-second")]
    public ActionResult<IEnumerable<Organization>> CollectionOrganizationSecond()
    {
        var organizations = new List<Organization> { _organization };

        var organizationsDto = _mapper.Map<IEnumerable<OrganizationHardDto>>(organizations);

        var result = _mapper.Map(organizationsDto, organizations);
        
        return Ok(result);
    }
}