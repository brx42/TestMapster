namespace TestMapster.Models;

/// <summary>
/// Организация.
/// </summary>
public class Organization
{
    /// <summary>
    /// Идентификатор организации.
    /// </summary>
    public int Id { get; set; }
    
    /// <summary>
    /// Название организации.
    /// </summary>
    public string Name { get; set; }
    
    /// <summary>
    /// Является ли юридическим лицом.
    /// </summary>
    public bool IsLegalEntity { get; set; }
    
    /// <summary>
    /// Коллекция сотрудников в организации.
    /// </summary>
    public ICollection<Employee> Employees { get; set; }
}