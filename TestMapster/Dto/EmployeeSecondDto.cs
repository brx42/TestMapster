using TestMapster.Enum;

namespace TestMapster.Dto;

/// <summary>
/// Второе Dto сотрудника.
/// </summary>
public class EmployeeSecondDto
{
    /// <summary>
    /// Имя сотрудника.
    /// </summary>
    public string DtoName { get; set; }
    
    /// <summary>
    /// Фамилия сотрудника.
    /// </summary>
    public string DtoLastName { get; set; }

    /// <summary>
    /// Номер телефона.
    /// 1 - Первый номер.
    /// 2 - Второй номер.
    /// </summary>
    public PhoneNumber DtoPhoneNumber { get; set; }

    /// <summary>
    /// Идентификатор организации.
    /// </summary>
    public int DtoOrganizationId { get; set; }
}