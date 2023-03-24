using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentApplication
{
    public class Student
    {
        //VARIABLES
        private String StudentNumber;

        //COBSTRUCTOR
        public Student(string studentNumber, string name, string surname)
        {
            this.StudentNumber = studentNumber;
        }

        //GETTER AND SETTERS
        public void setStudentNumber(String studentNumber)
        {
            StudentNumber = studentNumber;
        }

        public String getStudentNumber()
        {
            return StudentNumber;
        }

    }
}
