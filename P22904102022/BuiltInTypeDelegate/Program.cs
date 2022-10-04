using BuiltInTypeDelegate.Models;
using System;
using System.Collections.Generic;
using BuiltInTypeDelegate.Extensions;

namespace BuiltInTypeDelegate
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Action - Return Type Void Olan Ve 0-dan 16-a qeder parametri olan Methodlari Temsil Edir
            //Action feridmensurov = Test;
            //feridmensurov += delegate ()
            // {

            // };
            //feridmensurov += () => Console.WriteLine();


            //Action<string> action1 = Test;
            //Action<int, bool, double> action2 = Test;
            //action2 += delegate (int a, bool b, double c)
            //  {
            //      Console.WriteLine();
            //  };
            //action2 += (a, b, c) => Console.WriteLine();

            #endregion

            #region Func - Returtn type Void-den Ferqli Olan ve 0 -dan 16 qeder parametr Qebul Eden Methodlari Temsil Edir
            //Func<bool> func1 = delegate ()
            //{
            //    return true;
            //};
            //func1 += () => true;

            //Func<int, bool> func2 = n => n % 2 == 0;
            #endregion

            #region Predicate - Return Type yalniz Bool Olan Yalniz Bir Parametr Qebul Eden Methodlari Temsil Edir
            //Predicate<int> predicate1 = n => n % 2 == 0;
            //predicate1 +=n=> n % 3 == 0;
            //predicate1.Invoke(5);
            //predicate1(5);
            #endregion

            List<Student> students = new List<Student>
            {
                new Student{ Name = "Vusal",SurName = "Zeynalov",Age=19},
                new Student{ Name = "Meherrem",SurName = "Demirchiyev",Age=26},
                new Student{ Name = "Rovsen",SurName = "Bayramov",Age=19},
                new Student{ Name = "Ferid",SurName = "Mensurov",Age=19},
                new Student{ Name = "Ferid",SurName = "Qarayev",Age=19},
                new Student{ Name = "Rashad",SurName = "Ismayilov",Age=22}
            };

            //students.CustomForeach(delegate (Student student) 
            //{
            //    Console.WriteLine($"{student.Name} {student.SurName}");
            //});
            //students.CustomForeach(delegate (Student student)
            //{
            //    Console.WriteLine($"{student.Age}");
            //});
            //Console.WriteLine(students.Exists(CheckStuByName));

            Student student = students.Find(s => s.Age > 22);
            Student student1 = students.CustomFind(s => s.Age > 19);
            Console.WriteLine(student.Name);
            Console.WriteLine(student1.Name);
            //Console.WriteLine(CustomExist(students, CheckStuByName));

            //Console.WriteLine(students.CustomExist(CheckStuByName));
            //Console.WriteLine(students.CustomExist(delegate (Student student)
            //{
            //    //if (student.Name == "Ferid" && student.Age == 19)
            //    //{
            //    //    return true;
            //    //}
            //    //else
            //    //{
            //    //    return false;
            //    //}

            //    return student.Name == "Ferid" && student.Age == 19;
            //}));

            //students.CustomExist(s => s.Name == "Ferid" && s.SurName == "Qarayev");
        }

        

        static bool CheckStuByName(Student student)
        {
            return student.Name == "Rashad";
        }

        static void Test()
        {

        }

        static void Test(string str)
        {

        }

        static void Test(int a, bool check, double num)
        {

        }

        static string Test1(int a, bool check, double num)
        {
            return "";
        }
    }
}
