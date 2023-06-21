using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_C_Lab_1
{
    class marks
    {
        public int grade { get; set; }
        public int IDS { get; set; }
        public int IDO { get; set; }

        public marks(int IDS, int IDO, int grade)
        {
            this.IDS = IDS;
            this.IDO = IDO;
            this.grade = grade;
        }
    }
}
