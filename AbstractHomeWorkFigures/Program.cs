namespace AbstractHomeWorkFigures
{
    class Program
    {
        static void Main(string[] args)
        {
            // ---------    1 Задание. Геометрические фигуры/ Абстрактный класс ---------
            Console.WriteLine("1 Задание. Геометрические фигуры \n Расчет площади и периметра \n");
            double sumScuare = 0;
            double sumPer = 0;
            Figures[] figures = new Figures[]
            {
                new Triangle(20,30,15),
                new Circle(10.1),
                new Circle(12.55),
                new Rectangle(3.5, 7),
                new Rectangle(4, 9),
            };
            foreach (var figure in figures)
            {
                figure.Print();
                Console.WriteLine($"Площадь фигуры = {figure.CalcScuare()}");
                sumScuare += figure.CalcScuare();
            }
            Console.WriteLine($"\nПлощадь всех фигур = {Math.Round(sumScuare, 2)}\n");
            foreach (var figure in figures)
            {
                figure.Print();
                Console.WriteLine($"Периметр фигуры = {figure.CalcPerimetr()}");
                sumPer += figure.CalcPerimetr();
            }
            Console.WriteLine($"\nПериметр всех фигур = {Math.Round(sumPer, 2)}\n");
        }
    }
}