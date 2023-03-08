using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace nguyenryan_MCGHealth.Shapes
{
    public class Shape : IComparable<Shape>
    {
     
        public double area { get; set; }

        public virtual double calculateArea()
        {
            return 0.0;
        }

        public override string ToString()
        {
            return (this.GetType().Name + " " + String.Format("{0:0.00}", this.area));
        }
        public int CompareTo(Shape other)
        {
           return other.area.CompareTo(area);
        }
    }
}
