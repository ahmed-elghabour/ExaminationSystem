﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace ExaminationSystem.Entities;

public partial class Student
{
    public int StdId { get; set; }

    public string StdFirstName { get; set; }

    public string StdLastName { get; set; }

    public string Address { get; set; }

    public string Gender { get; set; }

    public DateOnly BirthDate { get; set; }

    public string PhoneNumber { get; set; }

    public int? DeptId { get; set; }

    public virtual Department Dept { get; set; }

    public virtual ICollection<StdCr> StdCrs { get; set; } = new List<StdCr>();

    public virtual ICollection<StdQuesExam> StdQuesExams { get; set; } = new List<StdQuesExam>();

    public virtual ICollection<StudentLogin> StudentLogins { get; set; } = new List<StudentLogin>();

    public virtual ICollection<Instructor> Ins { get; set; } = new List<Instructor>();
}