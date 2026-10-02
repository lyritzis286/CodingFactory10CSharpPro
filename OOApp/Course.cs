using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace OOApp;

internal class Course
{
    private int _id;
    private string? _name;

    public int Id {  get => _id; init => _id = value; }
    public string? Name {  get => _name; private set => _name = value; }

}
