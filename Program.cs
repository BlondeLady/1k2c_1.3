using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1k2c_1._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Bottle[] bottlesList = new Bottle[]
            {
                new Bottle(230, "Вино", true),
                new Bottle(90, "Водка", false),
                new Bottle(500, "Коньяк", false),
                new Bottle(450, "Виски", true),
                new Bottle(35, "Пиво", true),
                new Bottle(60, "Эль", true)
            };
            foreach (var g in Bottle.GetOnlyEmpty(bottlesList))
                Console.WriteLine(g);
            Console.ReadKey();
        }
    }
}
