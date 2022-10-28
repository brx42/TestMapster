namespace TestMapster.Dto;

/// <summary>
/// Второе Dto организации.
/// </summary>
public class OrganizationHardDto
{
    /// <summary>
    /// Идентификатор организации.
    /// </summary>
    public int DtoId { get; set; }
    
    /// <summary>
    /// Название организации.
    /// </summary>
    public string DtoName { get; set; }
    
    /// <summary>
    /// Является ли юридическим лицом.
    /// </summary>
    public bool DtoIsLegalEntity { get; set; }
    
    /// <summary>
    /// Коллекция сотрудников в организации.
    /// </summary>
    public ICollection<EmployeeLiteDto> DtoEmployees { get; set; }
}