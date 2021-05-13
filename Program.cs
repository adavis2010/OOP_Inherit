using System;

namespace OOP_
{
    class Program
    {
        public static void Main()
        {

            Person myPerson = new Person();
            myPerson.Greet();

            Student myStudent = new Student();
            myStudent.SetAge(20);
            myStudent.Greet();
            myStudent.ShowAge();
            myStudent.Study();

            Teacher myTeacher = new Teacher();
            myTeacher.SetAge(36);
            myTeacher.Greet();
            myTeacher.Explain();
        }







    }
    }
}
