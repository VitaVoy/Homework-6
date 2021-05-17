using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework_6._2
{
    class student
    {
        public student(string firstName, string lastName, string university, string faculty, string department, int age, int course, int group, string city)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.university = university;
            this.faculty = faculty;
            this.department = department;
            this.age = age;
            this.course = course;
            this.group = group;
            this.city = city;
        }

        public string firstName { get; set; }
        public string lastName { get; set; }
        public string university { get; set; }
        public string faculty { get; set; }
        public string department { get; set; }
        public int age { get; set; }
        public int course { get; set; }
        public int group { get; set; }
        public string city { get; set; }

        public override string ToString()
        {
            return $"{this.firstName,20} {this.lastName,15} {this.university,5} {this.faculty,15} {this.department,20} {this.age,3} {this.course,3} { this.group,3 } { this.city,15} ";
        }
    }
}
