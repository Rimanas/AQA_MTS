using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionsHomeWork.TaskAuthorization
{
    internal class WrongPasswordException: Exception
    {
        public WrongPasswordException() { }
        public WrongPasswordException(string password, string message)
            : base($"Неверный ввод в поле '{password}': {message}")
        {
        }
    }
}