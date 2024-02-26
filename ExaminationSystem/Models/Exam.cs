﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace ExaminationSystem.Entities;

public partial class Exam
{
    public int ExamId { get; set; }

    public int Duration { get; set; }

    public int? CourseId { get; set; }

    public int? Grade { get; set; }

    public virtual Course Course { get; set; }

    public virtual ICollection<StdQuesExam> StdQuesExams { get; set; } = new List<StdQuesExam>();

    public virtual ICollection<Question> Quests { get; set; } = new List<Question>();
}