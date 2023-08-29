using System;
using UnityEngine;

public class Students
    {
        public string Name;
        public int Number;

        public Students(string name, int number)
        {
            Name = name;
            Number = number;
        }

        public virtual void StudentOrder()
        {
            Debug.Log($"El código de {Name} es: {Number}");
        }

        public virtual void ShowClass()
        {
            Debug.Log("Clase base: Students");
        }
}

