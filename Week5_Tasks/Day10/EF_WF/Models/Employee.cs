﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace EF_WF.Models;

public partial class Employee
{
    public int Id { get; set; }

    public string Name { get; set; }

    public decimal? Salary { get; set; }

    public string Gender { get; set; }

    public DateOnly? Hiredate { get; set; }

    public int? dept_id { get; set; }

    public virtual Department dept { get; set; }
}