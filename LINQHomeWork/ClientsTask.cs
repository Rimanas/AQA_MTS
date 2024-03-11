using LINQHomeWork.data;
using LINQHomeWork.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQHomeWork
{
    internal class ClientsTask
    {
        private ClientObgectSet _clientObjectSet = new();
        public void Solve2()
        {
            Console.WriteLine("Задание 2. Сведения о клиентах фитнес - центра");
            PrintHelper.Print(_clientObjectSet, i => Console.WriteLine($"Клиент Фитинес - центра : {i}"));
            var queryResultClient = _clientObjectSet.Where(obj => obj.Duration == _clientObjectSet.Min(p => p.Duration)).Last();
            Console.WriteLine($"Клиент с min продолжительностью занятий: " +
                $"Client Code: {queryResultClient.Code}, " +
                $"Year: {queryResultClient.Year}, " +
                $"Month {queryResultClient.Month}, " +
                $"Duration of classes in hours {queryResultClient.Duration}");
        }
    }
}