using nguyenryan_MCGHealth.Shapes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nguyenryan_MCGHealth
{
    public class Rectangle : Shape
    {
    
        public double width { get; set; }
        public double height { get; set; }

        public Rectangle(double width, double height)
        {
            this.width = width;
            this.height = height;

          
        }
        
        public override double calculateArea()
        {
            this.area = width * height;
            return area;
        }
    }
}
