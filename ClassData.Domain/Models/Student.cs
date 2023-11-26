using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassData.Domain.Models
{
    public class Student
    {
        private static int nextId = 1;
        public int Id { get; }
        public string Fullname { get; set; }

        public int Point { get; set; }

        public void StudentInfo()
        { Console.WriteLine($"ID:{Id}, Name: {Fullname}, Point:{Point}");}

        public Student(string fullName, int point)
        {
            Id = nextId;
            nextId++;
            Fullname = fullName;
            Point = point;
        }
    }
}
