using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Exam.GeometryExample
{
    internal class Cylinder
    {
        public double BaseArea { get; set; }
        public double LateralArea { get;  set; }
        public double TotalArea { get;  set; }
        public double Volume { get;  set; }
        public double Radius { get;  set; }
        public double Height { get;  set; }

        public void Process()
        {
            BaseArea = Radius * Radius * Math.PI;

            LateralArea = (2 * Math.PI * Radius * Height);

            TotalArea = (2 * Math.PI * Radius * (Height + Radius));

            Volume = Math.PI * Radius * Radius * Height;

        }
        public string Result()
        {
            return("Radius: " + Radius + "," + "Height: " + Height + "\n"+ "BaseArea: " + BaseArea + "," + "LateralArea: " + LateralArea + "TotalArea: " + TotalArea + "," + "Volume: " + Volume); 
        }
    }
}
