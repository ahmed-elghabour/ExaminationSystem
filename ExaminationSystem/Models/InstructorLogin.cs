﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace ExaminationSystem.Entities;

public partial class InstructorLogin
{
    public string UserName { get; set; }

    public string Password { get; set; }

    public int? InsId { get; set; }

    public virtual Instructor Ins { get; set; }
}