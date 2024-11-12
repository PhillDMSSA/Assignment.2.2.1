using System.Formats.Asn1;

namespace Assignment._2._2._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            do
            {
                
                Circle circle = new Circle();
                Square square = new Square();

                Console.WriteLine("Select which shape you would like to find the area for: " +
                    "\n\t1) Circle" +
                    "\n\t2) Square");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Enter Shape ID: ");
                        circle.ShapeId = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter Shape name: ");
                        circle.ShapeName = Console.ReadLine();
                        Console.WriteLine("Enter the Shape Color: ");
                        circle.Color = Console.ReadLine();
                        Console.WriteLine("Enter the radius of the circle to get the area: ");
                        circle.Radius = Convert.ToDouble(Console.ReadLine()); //ensure property is public
                        circle.CalculateArea();
                        break;
                    case 2:
                        Console.WriteLine("Enter Shape ID: ");
                        square.ShapeId = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter Shape name: ");
                        square.ShapeName = Console.ReadLine();
                        Console.WriteLine("Enter the Shape Color: ");
                        square.Color = Console.ReadLine();
                        Console.WriteLine("Enter length of the square to get the area: ");
                        square.SideLength = Convert.ToDouble(Console.ReadLine());
                        square.CalculateArea();
                        break;
                }
                Console.WriteLine("Do you want to select another shape? (Y/N)");
            }
            while (Console.ReadLine().ToUpper() == "Y");

                Console.WriteLine("\t\t\t\t This is the end of the code.");
        }
    }
    public abstract class Shape //base class (Parent) //abstract = does not allow for Shape to be instantiated (Only a parent class)
    {
        private int shapeId;
        private string shapeName;
        private string shapeColor;

        public int ShapeId { get; set; }
        public string ShapeName { get; set; }
        public string Color { get; set; }

        public virtual double CalculateArea() //method
        {
            double area = 0;
            return area;
        }
    }
    public class Circle : Shape //derived class (child)
    {
        private double radius; //local field
        
        public double Radius { get; set; } //radius property created 
        public override double CalculateArea() 
        {
           double area =  Math.PI * Radius * Radius;
            Console.WriteLine($"Shape ID is: {ShapeId}");
            Console.WriteLine($"Shape name is: {ShapeName}");
            Console.WriteLine($"Shape color is: {Color}");
            Console.Write($"Area of circle is: ");
            Console.WriteLine(Math.Round(area, 2)); //rounds to the 2nd decimal place
            return area;
        }
    }
    public class Square : Shape
    {
        private double sideLength;
        public double area;

        public double SideLength { get; set; }
        public override double CalculateArea()
        {
            double area = SideLength * SideLength;

            Console.WriteLine($"Shape ID is: {ShapeId}");
            Console.WriteLine($"Shape name is: {ShapeName}");
            Console.WriteLine($"Shape color is: {Color}");
            Console.Write($"Area of square is: ");
            Console.WriteLine(area);
            return area;
        }
    } 
}
