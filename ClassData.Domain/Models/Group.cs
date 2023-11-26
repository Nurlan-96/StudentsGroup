using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ClassData.Domain.Models
{
    public class Group
    {
        public string GroupNo { get; set; }
        private int MaxSize = 18;
        private int MinSize = 5;

        private Student[] students;

        public Group(string groupNo, Student[] student)
        {
            GroupNo = groupNo;
            if ((student.Length > MinSize) || (student.Length < MaxSize))
            {
                students = student;
            }
        }

        public void AddStudent(Student student)
        {
            if (students.Length + 1 > MaxSize)
            {
                Console.WriteLine("Maximum Capacity Reached");
                return;
            }
            Array.Resize(ref students, students.Length + 1);
            students[students.Length - 1] = student;
        }

        public string GetStudent(int Id)
        {
            foreach (Student student in students)
            {
                if (student.Id == Id)
                {
                    return student.Fullname;
                }
            }
            throw new Exception($"Student with {Id} could not be found.");
        }

        public void GetAll ()
        {
            foreach(Student student in students)
            {
                Console.WriteLine($"ID: {student.Id}, Name: {student.Fullname}, Point: {student.Point}.");
            }
        }

        public bool CheckGroupNo()
        {
            string pattern = @"^[A-Z]{2}(?=.*\d.*\d.*\d.*)";
            Regex regex = new Regex(pattern);
            return regex.IsMatch(GroupNo);
        }
    }
}
