﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace ExaminationSystem.Entities;

public partial class QuestModelanswer
{
    public string ModelAnswer { get; set; }

    public int QuestionId { get; set; }

    public virtual Question Question { get; set; }
}