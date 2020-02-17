using System;
using System.IO;

namespace Straten
{
    class Program
    {
        //graaf bestaat uit dictionary waaruit de knoop de id is
        static void Main(string[] args)
        {
            Lezen l1 = new Lezen();
            l1.BestandLezen();
        }
    }
}
