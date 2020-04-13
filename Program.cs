using System;

namespace MyprojecsApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ReadKey();
        }
    }
    class Person
    {
        public string LastName;
        public string FirstName;
        public string MiddleName;
        public int BirthYear;
        public string Nation;
        public string Gender;
        public int Age;
        public string PlaceOfBirth;                 //место рождения
        public string PlaceOfResidence;             //место жителство
    }
    class Student : Person
    {
        public string University;
        public string Faculty;
        public string Specialty;
        public int Login;              //int потому что все логин у нас примерно в такой формат: 2017010136
        public int Password;            //Логин и Пароль для проверка результат!!
    }
}
