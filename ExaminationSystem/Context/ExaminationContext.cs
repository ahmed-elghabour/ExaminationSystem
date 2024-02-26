﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using ExaminationSystem.Entities;
using Microsoft.EntityFrameworkCore;

namespace ExaminationSystem.Context;

public partial class ExaminationContext : DbContext
{
    public ExaminationContext()
    {
    }

    public ExaminationContext(DbContextOptions<ExaminationContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Course> Courses { get; set; }

    public virtual DbSet<Department> Departments { get; set; }

    public virtual DbSet<Exam> Exams { get; set; }

    public virtual DbSet<Instructor> Instructors { get; set; }

    public virtual DbSet<InstructorLogin> InstructorLogins { get; set; }

    public virtual DbSet<QuesType> QuesTypes { get; set; }

    public virtual DbSet<QuestChoice> QuestChoices { get; set; }

    public virtual DbSet<QuestModelanswer> QuestModelanswers { get; set; }

    public virtual DbSet<Question> Questions { get; set; }

    public virtual DbSet<StdCr> StdCrs { get; set; }

    public virtual DbSet<StdQuesExam> StdQuesExams { get; set; }

    public virtual DbSet<Student> Students { get; set; }

    public virtual DbSet<StudentLogin> StudentLogins { get; set; }

    public virtual DbSet<Topic> Topics { get; set; }

    // Amr
    // protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    //    => optionsBuilder.UseSqlServer("Data Source=VOLT\\SQLEXPRESS;Initial Catalog=Examination;Integrated Security=True; Encrypt=false");

    // Abdo
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Data Source=ARAHMAN\\SQLEXPRESS01;Initial Catalog=Examination;Integrated Security=True; Encrypt=false");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Course>(entity =>
        {
            entity.ToTable("Course");

            entity.HasIndex(e => e.CourseName, "CourseNameConstraint").IsUnique();

            entity.Property(e => e.CourseId).HasColumnName("Course_ID");
            entity.Property(e => e.CourseName)
                .IsRequired()
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Course_Name");

            entity.HasMany(d => d.Instructors).WithMany(p => p.Courses)
                .UsingEntity<Dictionary<string, object>>(
                    "InsCr",
                    r => r.HasOne<Instructor>().WithMany()
                        .HasForeignKey("InstructorId")
                        .HasConstraintName("FK_INS_CRS_Instructor"),
                    l => l.HasOne<Course>().WithMany()
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_INS_CRS_Course"),
                    j =>
                    {
                        j.HasKey("CourseId", "InstructorId");
                        j.ToTable("INS_CRS");
                        j.IndexerProperty<int>("CourseId").HasColumnName("Course_ID");
                        j.IndexerProperty<int>("InstructorId").HasColumnName("Instructor_ID");
                    });

            entity.HasMany(d => d.Questions).WithMany(p => p.Courses)
                .UsingEntity<Dictionary<string, object>>(
                    "CrsQue",
                    r => r.HasOne<Question>().WithMany()
                        .HasForeignKey("QuestionId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_CRS_QUES_Questions"),
                    l => l.HasOne<Course>().WithMany()
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_CRS_QUES_Course"),
                    j =>
                    {
                        j.HasKey("CourseId", "QuestionId");
                        j.ToTable("CRS_QUES");
                        j.IndexerProperty<int>("CourseId").HasColumnName("Course_ID");
                        j.IndexerProperty<int>("QuestionId").HasColumnName("QuestionID");
                    });
        });

        modelBuilder.Entity<Department>(entity =>
        {
            entity.HasKey(e => e.DeptId);

            entity.ToTable("Department");

            entity.HasIndex(e => e.DeptName, "deptNameConstraint").IsUnique();

            entity.Property(e => e.DeptId).HasColumnName("Dept_ID");
            entity.Property(e => e.DeptLocation)
                .IsRequired()
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Dept_Location");
            entity.Property(e => e.DeptName)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Dept_Name");
            entity.Property(e => e.ManagerId).HasColumnName("Manager_ID");

            entity.HasOne(d => d.Manager).WithMany(p => p.Departments)
                .HasForeignKey(d => d.ManagerId)
                .HasConstraintName("FK_Department_Instructor");

            entity.HasMany(d => d.Courses).WithMany(p => p.Depts)
                .UsingEntity<Dictionary<string, object>>(
                    "DeptCr",
                    r => r.HasOne<Course>().WithMany()
                        .HasForeignKey("CourseId")
                        .HasConstraintName("FK_DEPT_CRS_Course"),
                    l => l.HasOne<Department>().WithMany()
                        .HasForeignKey("DeptId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_DEPT_CRS_Department"),
                    j =>
                    {
                        j.HasKey("DeptId", "CourseId");
                        j.ToTable("DEPT_CRS");
                        j.IndexerProperty<int>("DeptId").HasColumnName("Dept_ID");
                        j.IndexerProperty<int>("CourseId").HasColumnName("Course_ID");
                    });
        });

        modelBuilder.Entity<Exam>(entity =>
        {
            entity.ToTable("Exam");

            entity.Property(e => e.ExamId).HasColumnName("ExamID");
            entity.Property(e => e.CourseId).HasColumnName("Course_ID");

            entity.HasOne(d => d.Course).WithMany(p => p.Exams)
                .HasForeignKey(d => d.CourseId)
                .HasConstraintName("FK_Exam_Course");

            entity.HasMany(d => d.Quests).WithMany(p => p.Exams)
                .UsingEntity<Dictionary<string, object>>(
                    "ExamQue",
                    r => r.HasOne<Question>().WithMany()
                        .HasForeignKey("QuestId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_Exam_Ques_Questions"),
                    l => l.HasOne<Exam>().WithMany()
                        .HasForeignKey("ExamId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_Exam_Ques_Exam"),
                    j =>
                    {
                        j.HasKey("ExamId", "QuestId");
                        j.ToTable("Exam_Ques");
                        j.IndexerProperty<int>("ExamId").HasColumnName("ExamID");
                        j.IndexerProperty<int>("QuestId").HasColumnName("QuestID");
                    });
        });

        modelBuilder.Entity<Instructor>(entity =>
        {
            entity.HasKey(e => e.InsId);

            entity.ToTable("Instructor");

            entity.Property(e => e.InsId).HasColumnName("Ins_ID");
            entity.Property(e => e.Degree)
                .IsRequired()
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.DeptId).HasColumnName("Dept_ID");
            entity.Property(e => e.InsName)
                .IsRequired()
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Ins_Name");

            entity.HasOne(d => d.Dept).WithMany(p => p.Instructors)
                .HasForeignKey(d => d.DeptId)
                .HasConstraintName("FK_Instructor_Department");
        });

        modelBuilder.Entity<InstructorLogin>(entity =>
        {
            entity.HasKey(e => e.UserName);

            entity.ToTable("Instructor_Login");

            entity.Property(e => e.UserName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.InsId).HasColumnName("Ins_ID");
            entity.Property(e => e.Password)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.Ins).WithMany(p => p.InstructorLogins)
                .HasForeignKey(d => d.InsId)
                .HasConstraintName("FK_Instructor_Login_Instructor");
        });

        modelBuilder.Entity<QuesType>(entity =>
        {
            entity.HasKey(e => e.TypeId);

            entity.ToTable("QUES_TYPE");

            entity.Property(e => e.TypeId)
                .ValueGeneratedNever()
                .HasColumnName("TypeID");
            entity.Property(e => e.TypeName)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<QuestChoice>(entity =>
        {
            entity.HasKey(e => new { e.Letter, e.QuestionId });

            entity.ToTable("QUEST_CHOICES");

            entity.Property(e => e.Letter)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.QuestionId).HasColumnName("QuestionID");
            entity.Property(e => e.Sentence)
                .IsRequired()
                .HasMaxLength(500)
                .IsUnicode(false);

            entity.HasOne(d => d.Question).WithMany(p => p.QuestChoices)
                .HasForeignKey(d => d.QuestionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_QUEST_CHOICES_Questions");
        });

        modelBuilder.Entity<QuestModelanswer>(entity =>
        {
            entity.HasKey(e => new { e.ModelAnswer, e.QuestionId });

            entity.ToTable("QUEST_MODELANSWER");

            entity.Property(e => e.ModelAnswer)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.QuestionId).HasColumnName("QuestionID");

            entity.HasOne(d => d.Question).WithMany(p => p.QuestModelanswers)
                .HasForeignKey(d => d.QuestionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_QUEST_MODELANSWER_Questions");
        });

        modelBuilder.Entity<Question>(entity =>
        {
            entity.Property(e => e.QuestionId).HasColumnName("QuestionID");
            entity.Property(e => e.QuestionHead)
                .IsRequired()
                .HasMaxLength(500)
                .IsUnicode(false);
            entity.Property(e => e.TypeId).HasColumnName("TypeID");

            entity.HasOne(d => d.Type).WithMany(p => p.Questions)
                .HasForeignKey(d => d.TypeId)
                .HasConstraintName("FK_Questions_QUES_TYPE");
        });

        modelBuilder.Entity<StdCr>(entity =>
        {
            entity.HasKey(e => new { e.StdId, e.CourseId });

            entity.ToTable("STD_CRS");

            entity.Property(e => e.StdId).HasColumnName("Std_ID");
            entity.Property(e => e.CourseId).HasColumnName("Course_ID");
            entity.Property(e => e.StdGrade).HasColumnName("Std_Grade");

            entity.HasOne(d => d.Course).WithMany(p => p.StdCrs)
                .HasForeignKey(d => d.CourseId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_STD_CRS_Course");

            entity.HasOne(d => d.Std).WithMany(p => p.StdCrs)
                .HasForeignKey(d => d.StdId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_STD_CRS_Student");
        });

        modelBuilder.Entity<StdQuesExam>(entity =>
        {
            entity.HasKey(e => new { e.QuestionId, e.StdAnswer });

            entity.ToTable("STD_QUES_EXAM");

            entity.Property(e => e.QuestionId).HasColumnName("QuestionID");
            entity.Property(e => e.StdAnswer)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Std_Answer");
            entity.Property(e => e.ExamId).HasColumnName("ExamID");
            entity.Property(e => e.StdId).HasColumnName("Std_ID");

            entity.HasOne(d => d.Exam).WithMany(p => p.StdQuesExams)
                .HasForeignKey(d => d.ExamId)
                .HasConstraintName("FK_STD_QUES_EXAM_Exam");

            entity.HasOne(d => d.Question).WithMany(p => p.StdQuesExams)
                .HasForeignKey(d => d.QuestionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_STD_QUES_EXAM_Questions");

            entity.HasOne(d => d.Std).WithMany(p => p.StdQuesExams)
                .HasForeignKey(d => d.StdId)
                .HasConstraintName("FK_STD_QUES_EXAM_Student");
        });

        modelBuilder.Entity<Student>(entity =>
        {
            entity.HasKey(e => e.StdId);

            entity.ToTable("Student");

            entity.HasIndex(e => e.PhoneNumber, "PhoneNumberConstraint").IsUnique();

            entity.Property(e => e.StdId).HasColumnName("Std_ID");
            entity.Property(e => e.Address)
                .IsRequired()
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.BirthDate).HasColumnName("Birth_Date");
            entity.Property(e => e.DeptId).HasColumnName("Dept_ID");
            entity.Property(e => e.Gender)
                .IsRequired()
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.PhoneNumber)
                .IsRequired()
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Phone_Number");
            entity.Property(e => e.StdFirstName)
                .IsRequired()
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Std_FirstName");
            entity.Property(e => e.StdLastName)
                .IsRequired()
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Std_LastName");

            entity.HasOne(d => d.Dept).WithMany(p => p.Students)
                .HasForeignKey(d => d.DeptId)
                .HasConstraintName("FK_Student_Department");

            entity.HasMany(d => d.Ins).WithMany(p => p.Stds)
                .UsingEntity<Dictionary<string, object>>(
                    "StdIn",
                    r => r.HasOne<Instructor>().WithMany()
                        .HasForeignKey("InsId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_STD_INS_Instructor"),
                    l => l.HasOne<Student>().WithMany()
                        .HasForeignKey("StdId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_STD_INS_Student"),
                    j =>
                    {
                        j.HasKey("StdId", "InsId");
                        j.ToTable("STD_INS");
                        j.IndexerProperty<int>("StdId").HasColumnName("Std_ID");
                        j.IndexerProperty<int>("InsId").HasColumnName("Ins_ID");
                    });
        });

        modelBuilder.Entity<StudentLogin>(entity =>
        {
            entity.HasKey(e => e.UserName);

            entity.ToTable("Student_Login");

            entity.Property(e => e.UserName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Password)
                .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.StdId).HasColumnName("Std_ID");

            entity.HasOne(d => d.Std).WithMany(p => p.StudentLogins)
                .HasForeignKey(d => d.StdId)
                .HasConstraintName("FK_Student_Login_Student");
        });

        modelBuilder.Entity<Topic>(entity =>
        {
            entity.HasKey(e => new { e.TopicId, e.CourseId });

            entity.ToTable("Topic");

            entity.HasIndex(e => e.TopicName, "TopicNameConstraint").IsUnique();

            entity.Property(e => e.TopicId).HasColumnName("Topic_ID");
            entity.Property(e => e.CourseId).HasColumnName("Course_ID");
            entity.Property(e => e.TopicName)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.HasOne(d => d.Course).WithMany(p => p.Topics)
                .HasForeignKey(d => d.CourseId)
                .HasConstraintName("FK_Topic_Course");
        });

        OnModelCreatingGeneratedProcedures(modelBuilder);
        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}