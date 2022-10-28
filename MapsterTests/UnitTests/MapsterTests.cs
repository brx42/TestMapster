using System.Reflection;
using Mapster;
using TestMapster.Dto;
using TestMapster.Models;
using Xunit;

namespace MapsterTests.UnitTests;

public class MapsterTests
{
    [Fact(DisplayName = "Проверка разных сценариев маппинга во всём проекте.")]
    public void ShouldCheckDifferentMappingScenariosInTheProject()
    {
        var config = TypeAdapterConfig.GlobalSettings;
        
        // Конфигурация для маппинга, даже если это просто - config.NewConfig<Source, Destination>();
        // По умолчанию - false.
        config.RequireExplicitMapping = true;
        
        // Явная конфигурация для маппинга, с подробным описанием полей - сопоставление/игнорирование.
        // По умолчанию - false.
        config.RequireDestinationMemberSource = true;
        
        config.Scan(Assembly.GetExecutingAssembly());
        config.Compile();
    }

    [Fact(DisplayName = "Проверка разных сценариев маппинга в конкретных случаях.")]
    public void ShouldCheckDifferentMappingScenariosInSpecificCase()
    {
        var config = new TypeAdapterConfig
        {
            // По умолчанию - false.
            // Конфигурация для маппинга, даже если это просто - config.NewConfig<Source, Destination>();
            RequireExplicitMapping = true,
            
            // По умолчанию - false.
            // Явная конфигурация для маппинга, с подробным описанием полей - сопоставление/игнорирование.
            RequireDestinationMemberSource = true
        };

        // Сопоставление конкретных карт маппинга.
        config.NewConfig<Organization, OrganizationLiteDto>();
        config.NewConfig<Employee, EmployeeLiteDto>();
        
        config.Compile();
    }
}