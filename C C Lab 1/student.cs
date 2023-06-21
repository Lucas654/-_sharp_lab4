using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Json;

namespace C_C_Lab_1
{
    [Serializable]
    class student
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        
        public string Sub { get; set; }
        public int Grade { get; set; }

        public student(int ID,string FirstName, string SecondName, string Sub,int Grade)
        {
            this.ID = ID;
            this.FirstName = FirstName;
            this.SecondName = SecondName;
            this.Sub = Sub;
            this.Grade = Grade;

        }

    }
}
