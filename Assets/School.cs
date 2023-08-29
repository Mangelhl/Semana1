using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class School 
{
    static void Main(string[] args)
    {
        Students student = new Students("Juan", 45);
        Classroom classroom = new Classroom(105, "Pedro");

        student.StudentOrder();
        classroom.ShowClass();
    }
}
