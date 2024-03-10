using DelegateHomeWork;
using DelegateHomeWork.Task2;
using DelegateHomeWork.Task3;

//1 Задание
new Task1().RunReturnNumber();
//2 Задание
new Task2().RunCalculation();
//3 Задание
MethodOfArraySort methodOfArraySort = new MethodOfArraySort();
int[] array = methodOfArraySort.MethodOfArrayCreate();
methodOfArraySort.PrintArray(array);