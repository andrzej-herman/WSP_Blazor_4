using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Models
{
    public class Student
    {

        public Student()
        {
            
        }

       public Student(int id, string firstName, string lastName)
       {
           StudentId = id;
           FirstName = firstName;
           LastName = lastName;
       }

        public int StudentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

    }
}