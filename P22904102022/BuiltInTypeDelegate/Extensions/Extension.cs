using BuiltInTypeDelegate.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BuiltInTypeDelegate.Extensions
{
    static class Extension
    {
        public static bool CustomExist(this List<Student> students, Predicate<Student> predicate)
        {
            foreach (Student item in students)
            {
                if (predicate(item))
                {
                    return true;
                }
            }
            return false;
        }

        public static void CustomForeach(this List<Student> students, Action<Student> action)
        {
            foreach (Student item in students)
            {
                action(item);
            }
        }

        public static Student CustomFind(this List<Student> students, Predicate<Student> predicate)
        {
            foreach (Student item in students)
            {
                if (predicate(item))
                {
                    return item;
                }
            }

            return null;
        }
    }
}
