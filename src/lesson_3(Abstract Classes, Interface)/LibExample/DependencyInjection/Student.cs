﻿namespace LibExample.DependencyInjection;

/// <summary> Студент. </summary>
public class Student
{
    /// <summary> Имя. </summary>
    public string FirstName;

    /// <summary> Фамилия. </summary>
    public string SecondName;

    /// <summary> Почта. </summary>
    public string Email;

    /// <summary> Телефон. </summary>
    public string PhoneNumber;

    /// <summary> Стипендия </summary>
    public int Scholarship;

    /// <summary> Философия. </summary>
    public int Philosophy { get; set; }

    /// <summary> ООП. </summary>
    public int ObjectOrientedProgramming { get; set; }

    /// <summary> Операционные системы. </summary>
    public int OperatingSystems { get; set; }

    /// <summary> Методы оптимизации. </summary>
    public int OptimizationMethods { get; set; }

}