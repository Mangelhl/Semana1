using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Classroom : Students
{
    public int Room;
    public string Teacher;

    public Classroom(int room, string teacher) : base(teacher, 0) 
    {
        Teacher = teacher;
        Room = room;
    }

    public override void ShowClass()
    {
        base.ShowClass();
        Debug.Log($"Clase derivada: Room: {Room} - Teacher: {Name}");
    }
}
