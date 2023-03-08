using nguyenryan_MCGHealth.Shapes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nguyenryan_MCGHealth
{
    public class Circle : Shape
    {
 
        public double diamater { get; set; }

        public Circle(double diameter)
        {
            this.diamater = diameter;
        }
        public override double calculateArea()
        {
          
            this.area = Math.PI * Math.Pow((diamater / 2), 2);

            return area;
        }

       
    }
}
