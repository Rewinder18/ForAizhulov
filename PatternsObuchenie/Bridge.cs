using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsObuchenie
{
    internal class User
    {
        public string UserName { get; set; }
        public string RoleName { get; set; }
    }
    internal abstract class Person
    {
        protected ICourseMenu _coursemenu;

        public Person(ICourseMenu coursemenu)
        {
            this._coursemenu = coursemenu;
        }

        public abstract string GetInterface();
    }

    internal class Student : Person
    {
        public Student(ICourseMenu courseMenu) : base(courseMenu) { }

        public override string GetInterface()
        {
            string result = "You Student - " + this._coursemenu.GetCourseMenuInterface();

            return result;
        }
    }

    internal class Instructor : Person
    {
        public Instructor(ICourseMenu courseMenu) : base(courseMenu) { }

        public override string GetInterface()
        {
            string result = "You Instructor - " + this._coursemenu.GetCourseMenuInterface();

            return result;
        }
    }

    internal interface ICourseMenu
    {
        string GetCourseMenuInterface();
    }

    internal class LowLevelClassMenu : ICourseMenu
    {
        public string GetCourseMenuInterface()
        {
            return "subject Math";
        }
    }

    internal class HighLevelClassMenu : ICourseMenu
    {
        public string GetCourseMenuInterface()
        {
            return "subject Math Zimin";
        }
    }
}
