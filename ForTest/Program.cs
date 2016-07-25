using Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForTest
{
    class Program
    {
        static void Main(string[] args)
        {
            AlgoService algo =  new AlgoService();
            DataService data = new DataService(3);

            data.AddItem(3);
            data.AddItem(2);
            data.AddItem(1);

            foreach(var d in data.GetAllData())
                Console.WriteLine(d);
            Console.WriteLine("-----------------------");
            MasterService ms = new MasterService(algo, data);

            double res = ms.GetAverage();
            Console.WriteLine(res);

            res = ms.GetDoubleSum();
            Console.WriteLine(res);
            
            res = ms.Function();
            Console.WriteLine(res);

            res = ms.MinValue();
            Console.WriteLine(res);

            Console.ReadKey();
        }
    }
}
