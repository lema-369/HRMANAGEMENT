using System;
using System.Collections.Generic;

namespace Hello1.Models;

public partial class Employee
{
    public int EmployeeId { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public string? Email { get; set; }

    public string? Department { get; set; }

    public DateOnly? HireDate { get; set; }
}
