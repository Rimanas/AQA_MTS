using System.ComponentModel.DataAnnotations;
using System.Numerics;
using System.Reflection;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ClassesHomeWork
{
    class Program
    {
        static void Main(string[] args)
        {


            // 1 Задание. Работа с классом Phone
            Console.WriteLine("1 Задание. Работа с классом Phone \n");
            /*
            Phone phone1 = new Phone();
            Console.WriteLine($"Номер телефона: {phone1.GetNumber(89600000000)}");
            phone1.ReceiveCall("Kate");

            phone1.SendMessage(89600000000, 89600000001, 89600000002, 89600000003);
            */
            //Phone phone1 = new Phone ()


            class Phone
        {
            long number;
            string model;
            string name;
            int weight;
            //public string name;
            //конструтор без параметров
            //public Phone() { number = 89000000000; model = "Nokia"; weight = 100; }

            /*
            //конструктор с двумя параметрами
            public Phone(long number, string model)
            {
                this.number = number;
                this.model = model;
                weight = 100;
            }
            */

            // вызов 2 конструктора из 3 конгструктора
            public Phone(long number, string model) : this(number, model, 100) { }

            // 3 конструктор c тремя параметрами
            public Phone(long number, string model, int weight)
            {
                this.number = number;
                this.model = model;
                this.weight = weight;
            }

            //public Phone() { number = 89100000000; name = "Alice"; numbers = {1000002,1212,12121}; }
            public Phone() { number = 9700000000; name = "Alice"; }

            public void ReceiveCall(string name)
            {
                Console.WriteLine($"Звонит: {name}");
            }

            public long GetNumber(long number)
            {
                return number;
            }


            public void SendMessage(params long[] numbers)
            {
                Console.WriteLine("Номера телефонов, которым будет отправлено сообщение:");
                for (long i = 0; i < numbers.Length; i++)
                {
                    Console.WriteLine("Номер телефона  = " + numbers[i]);
                }
            }




        }


    }
    


        
    
}
