namespace AbstractHomeWorkFigures 
{
    class Program
    {
        static void Main(string[] args)
        {
            // ---------    1 Задание. Геометрические фигуры/ Абстрактный класс ---------
            Console.WriteLine("1 Задание. Геометрические фигуры \n Расчет полащади \n");
            Figures[] figures = new Figures[]
            {
                new Triangle(3,5,8),
                new Triangle(10,10,5),
                new Rectangle(12, 5),
                new Rectangle(3, 7),
            };
            foreach (var figure in figures)
            {
                var figureScuare = figure.CalcScuare();
                Console.WriteLine($"Площадь геометрической фигуры = {figureScuare}");
            }
            foreach (var figure in figures)
            {
                var figurePerimetr = figure.CalcPerimetr();
                Console.WriteLine($"Периметр геометрической фигуры = {figurePerimetr}");
            }
        }
    }
}
