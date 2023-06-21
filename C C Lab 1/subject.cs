using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Json;

namespace C_C_Lab_1
{
    [Serializable]
    class subject
    {
        public string Name { get; set; }
        public int Grade { get; set; }


        public subject(string Name)
        {
            this.Name = Name;
            this.Grade = 0;
        }
    }
}
