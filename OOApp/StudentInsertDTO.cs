using System;
using System.Collections.Generic;
using System.Text;

namespace OOApp;
/// <summary>
/// Public init only properties for firstname and lastname.
/// Primary constructro to initialize the properties.
/// Value-based equality with == and != operators.
/// Tostring() method for string representation of the object.
/// </summary>
/// <param name="Firstname"></param>
/// <param name="Lastname"></param>

internal record class StudentInsertDTO(string? Firstname,
    string? Lastname
)
{
}
