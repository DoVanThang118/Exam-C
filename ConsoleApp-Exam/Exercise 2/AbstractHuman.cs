using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp_Exam.Exercise_2
{
    internal abstract class AbstractHuman
    {
        public int weight;
        public string name;
        public abstract string Show();
        public abstract void SetMe(int weight, string name );

    }
}
