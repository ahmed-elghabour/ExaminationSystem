﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace ExaminationSystem.Entities;

public partial class StdQuesExam
{
    public int QuestionId { get; set; }

    public string StdAnswer { get; set; }

    public int? ExamId { get; set; }

    public int? StdId { get; set; }

    public virtual Exam Exam { get; set; }

    public virtual Question Question { get; set; }

    public virtual Student Std { get; set; }
}