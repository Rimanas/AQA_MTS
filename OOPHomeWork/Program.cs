namespace OOPHomeWorkShapes
{
    class Program
    {
        static void Main(string[] args)
        {
            // ---------    1 Задание. Геометрические фигуры ---------
            Console.WriteLine("1 Задание. Геометрические фигуры \n Расчет полащади \n");
            Shapes[] shapes = new Shapes[]
            { 
                Creator.CreateTriangels(20,30,10),   //разносторонний треугольник -- здесь должен быть 0 запись , что это не тругольник
                Creator.CreateTriangels(20,30,15),   //разносторонний треугольник
                Creator.CreateTriangels(20,20,20),   //равносторонний треугольник
                Creator.CreateTriangels(50,50,40),   //равнобедренный треугольник
                Creator.CreateTriangels(50,30,40),   //прямоугольный треугольник
                new Rectangle(12, 5),
                new Rectangle(3, 7),
                new Square(10)
            };
            foreach (var shape in shapes)
            {
                var shapeScuare = shape.CalcScuare();
                Console.WriteLine($"Площадь геометрической фигуры = {shapeScuare}"); 
            }

        }
    }
}