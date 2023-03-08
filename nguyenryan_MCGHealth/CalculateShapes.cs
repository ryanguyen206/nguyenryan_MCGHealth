using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using nguyenryan_MCGHealth.Shapes;

namespace nguyenryan_MCGHealth
{
    public class CalculateShapes
    {
        public string filePath { get; set; }

        public List<Shape> shapes { get; set; }
        public CalculateShapes()
        {
            this.filePath = @"C:\Users\Ryan\Desktop\shapeCalc.txt";

            shapes = new List<Shape>(); 
        }


        public List<Shape> GetShapesAndTheirArea() { 
        

            try
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    string line;
                
                    // Read line by line  
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] segment = line.Split(' ');

                        double diamater;
                        double width;
                        double height;
                        bool widthIsParsable;
                        bool heightIsParsable;
                        bool diamaterIsParasable;

                        switch (segment[0].ToLower())
                        {
                            case "circle":
                                diamaterIsParasable = double.TryParse(segment[1], out diamater);
                                if (diamaterIsParasable && diamater > 0)
                                {
                                    shapes.Add(new Circle(diamater));
                                }
                                break;
                            case "rectangle":
                                heightIsParsable = double.TryParse(segment[1], out width);
                                widthIsParsable = double.TryParse(segment[2], out height);
                                if (widthIsParsable && heightIsParsable && width > 0 && height > 0)
                                {
                                    shapes.Add(new Rectangle(width, height));
                                }
                                break;
                            case "square":
                                widthIsParsable = double.TryParse(segment[1], out width);

                                if (widthIsParsable && width > 0)
                                {
                                    shapes.Add(new Square(width));
                                }
                                break;
                            case "triangle":
                                heightIsParsable = double.TryParse(segment[1], out width);
                                widthIsParsable = double.TryParse(segment[2], out height);
                                if (widthIsParsable && heightIsParsable && width > 0 && height > 0 )
                                {
                                    shapes.Add(new Triangle(width, height));
                                }
                                break;
                            default:
                                break;
                        }
                    }
                }
            } catch (Exception e)
            {
                Console.WriteLine("Something went wrong." + e.Message);
            }

            return shapes;
        }
       
    }
}
