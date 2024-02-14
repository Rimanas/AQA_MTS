using ExceptionsHomeWork;
using ExceptionsHomeWork.TaskAuthorization;

Console.WriteLine("1 Task");
try
{
    AuthorizationData.CheckInputData("loginqpppppppqqq", "qwerty", "qwerty");  // Успешная авторизация
    //AuthorizationData.CheckInputData("loginqpppppppqqqqqqqqqqqq", "qwerty", "qwerty");  // Логин более 20 символом: Exception
    //AuthorizationData.CheckInputData("loginq qqq", "qwerty", "qwerty");  // В логине есть пробелы: Exception
    //AuthorizationData.CheckInputData("loginqpppppppqqq", "qwerty1", "qwerty1"); // Цифры в пароле: Exception
    //AuthorizationData.CheckInputData("loginqpppp", "qwertyeeeeee", "qwerty");  // Пароли не совпадают: Exception
    //AuthorizationData.CheckInputData("loginqpppppppqqq", "qwertyxxxxxxxxxxxxxxxxxxxx", "qwertyxxxxxxxxxxxxxxxxxxxx");  // Пароль более 20 символом: Exception
    //AuthorizationData.CheckInputData("loginqqqq", " qwerty", " qwerty");  // В пароле есть пробелы: Exception
    //AuthorizationData.CheckInputData("logi nqqqq", "11qwerty", "rrrqwerty");  // Проверка нескольких некорректных случаев: Первый Exception по логину 
}
catch (WrongLoginException e)
{
    Console.WriteLine(e.Message);
}
catch (WrongPasswordException e)
{
    Console.WriteLine(e.Message);
}
