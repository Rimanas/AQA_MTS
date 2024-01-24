namespace OOPHomeWorkShapes
{
    class Program
    {
        static void Main(string[] args)
        {
            // ---------    1 Задание. Геометрические фигуры ---------
            Console.WriteLine("1 Задание. Геометрические фигуры \n Расчет полащади \n");
            Creator creator = new Creator(10,10,10);
            Creator creator1 = new Creator(5,6,7);
            Shapes triangle = new VersatileTriangle(5,6,7);
            Shapes triangle10 = new EquilateralTriangle(5, 5, 5);
            //Console.WriteLine($"Треуголник: {.CreateTriangels()} ");
            Console.WriteLine($"Периметр треуголника: {triangle.CalcPerimeter()} ");
            Console.WriteLine($"Площадь треуголника разностороннего 1: {triangle.CalcScuare()} ");
            Console.WriteLine($"Площадь треуголника 2: {triangle10.CalcScuare()} ");
            //Console.WriteLine($"Площадь треуголника CREATOR: {creator} ");
            //double s = creator.CreateTriangels(10,10,10);
            //Console.WriteLine($"Площадь треуголника CREATOR: {creator.CalcScuare()} ");
            //Console.WriteLine($"Площадь треуголника CREATOR: {creator1.CalcScuare()} ");
            creator.CreateTriangels(5,5,5);
            creator.CreateTriangels(5,6,7);
            //double s = creator.CreateTriangels(10, 10, 10)
            //Console.WriteLine($"Площадь треуголника CREATOR: {creator.CreateTriangels(10,10,10)} ");

            Rectangle rectangle = new Rectangle(5, 6);
            Console.WriteLine($"Площадь прямоугольника: {rectangle.CalcScuare()} ");

        }
    }
}