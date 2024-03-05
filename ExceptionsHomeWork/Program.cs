using ExceptionsHomeWork;
using ExceptionsHomeWork.TaskAuthorization;
using ExceptionsHomeWork.TaskOrders;
using ExceptionsHomeWork.TaskOrders.Exceptions;

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
Console.WriteLine("2 Task");
try
{
    List<Order> order1 =
[
    new("Apple", 10, 1230.55),
    new("Pineapple", 10, 670.99),
    new("Banana", 20, 2050.00),
    new("Carrot", 30, 2300.00),
];
    List<Order> order2 = [];
    //OrderCreator.CheckOrder(11100, order1, "Казань", "Bob"); // позитивный сценарий
    //OrderCreator.CheckOrder(11100, order2, "Казань", "Bob"); // нет товаров
    //OrderCreator.CheckOrder(11101, order1, "", "Bob"); // пустой адрес
    //OrderCreator.CheckOrder(11102, order1, "Казань", ""); // пустой получатель
    //OrderCreator.CheckOrder(11102, order1, "", ""); // пустой адрес и получатель
    //OrderCreator.CheckOrder(-100000, order1, "Казань", "Bob"); // отрицательный номер заказа
    OrderCreator.CheckOrder(-11100, order2, "", ""); // полностью негативный сенарий.Срабатывает 1 Exception
}
catch (EmptyOrderException e)
{
    Console.WriteLine(e.Message);
}

catch (InvalidOrderNumberException e)
{
    Console.WriteLine(e.Message);
}

catch (DeliveryInformationMissingException e)
{
    Console.WriteLine(e.Message);
}