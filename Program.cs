using System.Formats.Asn1;

namespace Assignment._2._2._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Shape shape = new Shape();
                Circle circle = new Circle();
                Square square = new Square();

                Console.WriteLine("Select which shape you would like to find the area for: " +
                    "\n\t1) Circle" +
                    "\n\t2) Square");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Enter the radius of the cricle to get the area: ");
                        circle.Radius = Convert.ToDouble(Console.ReadLine()); //ensure property is public
                        circle.CalculateArea();
                        break;
                    case 2:
                        Console.WriteLine("Enter length of square to get the area: ");
                        square.Width = Convert.ToDouble(Console.ReadLine());
                        square.CalculateArea();
                        break;
                }
                Console.WriteLine("Do you want to select another shape? (Y/N)");
            }
            while (Console.ReadLine().ToUpper() == "Y");

                Console.WriteLine("\t\t\t\t This is the end of the code.");

               

               
            
            



        }
    }
    class Shape //base class (Parent)
    {
        private int id;
        private string name;
        private string color;
        
        

        public int Id { get; set; }
        public string Name { get; set; }
        public string Color { get; set; }
        
        

        public virtual void CalculateArea() //method
        {

        }
    }
    class Circle : Shape //derived class (child)
    {
        private double radius;
        public double Radius { get; set; }
        public override void CalculateArea() 
        {
           double calculateArea =  Math.PI * Radius * Radius;

            Console.Write($"Area of circle is: ");
            Console.WriteLine(Math.Round(calculateArea, 2)); //rounds to the 2nd decimal place
        }
    }
    class Square : Shape
    {
        private double width;
        public double area;

        public double Width { get; set; }
        public override  void CalculateArea()
        {
            double calculateArea = Width * Width;
            Console.Write($"Area of square is: ");
            Console.WriteLine(calculateArea);
        }
    }
        
    
}
