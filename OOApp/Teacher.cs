using System;
using System.Collections.Generic;
using System.Text;

namespace OOApp;
/// <summary>
/// Defines a teacher POCO class
/// </summary>
internal class Teacher
{
    private int _id;
    private string? _firstname;
    private string? _lastname;

    public Teacher()
    {
    }

    public Teacher(int id, string? firstname, string? lastname)
    {
        Id = id;
        Firstname = firstname;
        Lastname = lastname;
    }

    public int Id { get => _id; set => _id = value; }
    public string? Firstname { get => _firstname; set => _firstname = value; }
    public string? Lastname { get => _lastname; set => _lastname = value; }

    
}
