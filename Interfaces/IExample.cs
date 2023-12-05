using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public interface IExample
    {
        // константа
        const int minSpeed = 0;     // минимальная скорость
                                    // статическая переменная
        static int maxSpeed = 60;   // максимальная скорость
                                    // метод
        void Move();                // движение
                                    // свойство
        string Name { get; set; }   // название
    }
}
