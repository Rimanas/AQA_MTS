namespace OOPHomeWorkShapes
{
    class Program
    {
        static void Main(string[] args)
        {
            // ---------    1 Задание. Геометрические фигуры ---------
            Console.WriteLine("1 Задание. Геометрические фигуры \n Расчет полащади \n");
            Creator creator = new Creator(7,2,4);
            Shapes trriangle = new VersatileTriangle(5, 6, 7);
            Shapes triangle1 = new EquilateralTriangle(5, 5, 5);
            //Console.WriteLine($"Треуголник: {.CreateTriangels()} ");
            Console.WriteLine($"Периметр треуголника: {trriangle.CalcPerimeter()} ");
            Console.WriteLine($"Площадь треуголника 1: {trriangle.CalcScuare()} ");
            Console.WriteLine($"Площадь треуголника 2: {triangle1.CalcScuare()} ");
            //Console.WriteLine($"Площадь треуголника from CREATOR: {creator.CreateTriangels(7,2,4)} ");

            Rectangle rectangle = new Rectangle(5, 6);
            Console.WriteLine($"Площадь прямоугольника: {rectangle.CalcScuare()} ");

        }
    }
}