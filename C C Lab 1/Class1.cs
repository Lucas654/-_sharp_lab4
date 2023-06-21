using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_C_Lab_1
{
    class Class1
    {
        public static List<student> students = new List<student>();
        public static List<stud> studen = new List<stud>();

        public static List<subject> subjects = new List<subject>() { new subject("matan"),new subject("ukr") };
        public static Dictionary<student, subject> data = new Dictionary<student, subject>();
        

    }
}
