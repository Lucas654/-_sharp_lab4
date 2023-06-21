using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_C_Lab_1
{
    [Serializable]
    class stud
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }

        public stud(int ID, string FirstName, string SecondName)
        {
            this.ID = ID;
            this.FirstName = FirstName;
            this.SecondName = SecondName;
        }
    }
}
