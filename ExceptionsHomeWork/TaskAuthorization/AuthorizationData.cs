using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace ExceptionsHomeWork.TaskAuthorization
{
    public class AuthorizationData
    {
        public static bool CheckInputData(string login, string password, string confirmPassword) 
        {
            if (login.Length > 20 || login.Contains(' '))
            {
                throw new WrongLoginException(nameof(login), "Длина Логина больше 20 символов или есть пробелы");
            }
            else
            {
                Console.WriteLine($"Ваш Логин: {login}");
            }
            if (password.Length > 20 || password.Contains(' ')|| !StringIsDigits(password))
            {
                throw new WrongPasswordException(nameof(password), "Длина Пароля больше 20 символов или есть пробелы или цифры");
            }
            if (password != confirmPassword)
            {
                throw new WrongPasswordException(nameof(password), "Пароли не совпадают");
            }


            return true;
        }
        private static bool StringIsDigits(string s)
        {
            foreach (var item in s)
            {
                if (char.IsDigit(item))
                    return false; //если хоть один символ число, то "ложь"
            }
            return true; //если ни разу не выбило в цикле, значит, все символы - это буквы
        }
    }
}
