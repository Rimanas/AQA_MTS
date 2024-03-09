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

        public void Solve()
        {
            List<Clients> expectedList = new List<Clients>();

            foreach (Clients client in _clientObjectSet)
            {
                if (client.Duration == 45)
                {
                    expectedList.Add(client);
                }
            }

            Console.WriteLine(expectedList.Count());

            Console.WriteLine(_clientObjectSet.Where(obj => obj.Duration == 45).Select(obj => obj).Count());
        }
    }
}
