using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Exam.Exercise_2
{
    internal class Tiger : AbstractHuman
    {

        public override void SetMe(int weight, string name)
        {
            
        }

        public override string Show()
        {
            return ("Name: " + name + "," + "Weight: " + weight);
        }
    }
}
