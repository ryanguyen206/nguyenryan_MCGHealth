using nguyenryan_MCGHealth.Shapes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nguyenryan_MCGHealth
{
    public class Square : Shape
    {
  
        public double width { get; set; }
      
        public Square(double width) {

            this.width = width;

        }

        public override double calculateArea()
        {

            this.area = width * width;

            return area;
        }

    }
}
