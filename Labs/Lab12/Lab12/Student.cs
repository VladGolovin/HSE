using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12
{
    public class Student: Person
    {
        private Student() { }

        public Student(int studentCardNumber)
        {
            person = new Person() { PassportNumber = studentCardNumber };
            StudentCardNumber = studentCardNumber;
        }

        public int StudentCardNumber { get; private set; }

        private Person person;

        public Person Person
        {
            get
            {
                return Person;
            }
        }

        public override string ToString()
        {
            return $"Номер студенческого билета: {StudentCardNumber}";
        }
    }
}
