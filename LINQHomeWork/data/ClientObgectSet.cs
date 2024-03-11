using LINQHomeWork.models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQHomeWork.data
{
    internal class ClientObgectSet : IEnumerable<Clients>
    {
        public IEnumerator<Clients> GetEnumerator()
        {

            var list = new List<Clients>()
        {
            new Clients(10, 2023, 1, 145),
            new Clients(11, 2023, 12, 1341),
            new Clients(12, 2022, 11, 1145),
            new Clients(13, 2024, 5, 343),
            new Clients(14, 2023, 3, 167),
            new Clients(15, 2021, 10, 646),
            new Clients(16, 2023, 1, 145),
        };

            foreach (Clients s in list)
            {
                yield return s;
            }
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}