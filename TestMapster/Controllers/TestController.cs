using Microsoft.AspNetCore.Mvc;
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
    
    /// <summary>
    /// Получить организацию.
    /// </summary>
    /// <returns>Организация.</returns>
    [HttpGet("simple")]
    public ActionResult<Organization> SimpleOrganization()
    {
        return Ok();
    }

    /// <summary>
    /// Получить коллекцию организаций.
    /// </summary>
    /// <returns>Коллекция организаций.</returns>
    [HttpGet("collection")]
    public ActionResult<IEnumerable<Organization>> CollectionOrganization()
    {
        return Ok();
    }

    /// <summary>
    /// Получить организацию асинхронно.
    /// </summary>
    /// <returns>Организация.</returns>
    [HttpGet("simple-async")]
    public async Task<ActionResult<Organization>> SimpleOrganizationAsync()
    {
        return Ok();
    }

    /// <summary>
    /// Получить коллекцию организаций асинхронно.
    /// </summary>
    /// <returns>Коллекция организаций.</returns>
    [HttpGet("collection-async")]
    public async Task<ActionResult<IEnumerable<Organization>>> CollectionOrganizationAsync()
    {
        return Ok();
    }
}