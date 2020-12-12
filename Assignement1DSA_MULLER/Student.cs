using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignement1DSA_MULLER
{
    public class Student
    {
        private string firstName;
        private string lastName;
        private string studentNumber;
        private float averageScore;

        //Constructor
        public Student(string firstName, string lastName, string studentNumber, float averageScore)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.studentNumber = studentNumber;
            this.averageScore = averageScore;
        }

        //Property
        public string FirstName
        {
            get { return this.firstName; }
        }        

        //Method
        public override string ToString()
        {
            return "The student with the student number " + studentNumber + " is " + firstName + " " + lastName + " and has an average score of " + averageScore + ".";
        }
    }
}
