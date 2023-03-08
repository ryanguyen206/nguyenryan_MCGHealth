using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using nguyenryan_MCGHealth.Shapes;




/** 
 * You will have to tweak the file path variable so it works for your computer. Sorry! I tried searching up ways for StreamWriter to create a txt file but had some trouble.
 * 
 * Some thoughts I had:
 * 
 * One drawback of this program is that users can instantiate a Shape class which doesnt really mean sense in this context.
 * 
 * An interface would be fine for calculating area method since other classes can implement to their liking but since area is a common property among the shapes and interfaces cant have fields, I decided not to use an inteface.
 * 
 * An abstract class would have worked to get rid of the problem of instantiating a Shape class and I coudlve done a readonly Area property but I liked the idea of a method to calculate area. 
 * 
 * Any feedback on how I could improve would be appreciated regardless of interview decision! Thanks!!!
 * 
 * 
 **/
namespace nguyenryan_MCGHealth
{
    internal class Program
    {
        static void Main(string[] args)


        {
           
            CalculateShapes calcShape = new CalculateShapes();

            //Should receieve shapes that are either one of the four and have valid dimensions
            List<Shape> shapes = calcShape.GetShapesAndTheirArea();

            //Calculating areas for each shape
            foreach (Shape shape in shapes)
            {
                shape.area = shape.calculateArea();
            }

            //Sort
            shapes.Sort();

            foreach (Shape shape in shapes)
            {
                Console.WriteLine(shape);
            }

            Console.ReadLine();
        }
    }
}
