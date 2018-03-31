using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12
{
    public class StudentAlreadyExistsException : Exception
    {
        public override string Message
        {
            get
            {
                return "Студент с таким номером студенческого билета уже существует.";
            }
        }
    };


    public class TestCollection
    {
        public Random rnd = new Random();

        public Queue<Person> persons { get; private set; }

        public Queue<string> personsKeys { get; private set; }

        public SortedDictionary<Person, Student> studentsByPerson { get; private set; }

        public SortedDictionary<string, Student> studentsByString { get; private set; }

        public TestCollection(int count)
        {
            FillCollections(count);
        }

        private void FillCollections(int count)
        {
            for (int i = 0; i < count; i++)
            {
                var student = GenerateStudent(rnd.Next(0, 999999));

                AddItem(student);
            }
        }

        public static Student GenerateStudent(int studentCardNumber)
        {
            return new Student(studentCardNumber);
        }

        public void AddItem(Student student)
        {
            if (studentsByString[student.Person.ToString()] != null)
            {
                throw new StudentAlreadyExistsException();
            }

            persons.Enqueue(student.Person);
            personsKeys.Enqueue(student.Person.ToString());
            studentsByPerson[student.Person] = student;
            studentsByString[student.Person.ToString()] = student;
        }

        public void DeleteItem()
        {
            var person = persons.Peek();

            persons.Dequeue();
            personsKeys.Dequeue();
            studentsByPerson.Remove(person);
            studentsByString.Remove(person.ToString());
        }

        public void PrintStudents()
        {
            foreach (var student in studentsByString)
            {
                Console.WriteLine(student);
            } 
        }
    }
}
