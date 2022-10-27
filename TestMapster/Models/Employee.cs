using TestMapster.Enum;

namespace TestMapster.Models;

/// <summary>
/// Сотрудники.
/// </summary>
public class Employee
{
    /// <summary>
    /// Идентификатор сотрудника.
    /// </summary>
    public Guid Id { get; set; }
    
    /// <summary>
    /// Имя сотрудника.
    /// </summary>
    public string Name { get; set; }
    
    /// <summary>
    /// Фамилия сотрудника.
    /// </summary>
    public string LastName { get; set; }

    /// <summary>
    /// Номер телефона.
    /// 1 - Первый номер.
    /// 2 - Второй номер.
    /// </summary>
    public PhoneNumber PhoneNumber { get; set; }

    /// <summary>
    /// Идентификатор организации.
    /// </summary>
    public int OrganizationId { get; set; }
    
    /// <summary>
    /// Организация.
    /// </summary>
    public Organization Organization { get; set; }
}