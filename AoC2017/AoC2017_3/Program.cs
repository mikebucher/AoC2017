using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AoC2017_3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<points> points = new List<points>();

            int x = 0;
            int y = 0;
            points.Add(new points { number = points.Count + 1, xpos = x, ypos = y });

            for (int level = 1; level < 500; level++)
            {
                x++;
                points.Add(new points { number = points.Count + 1, xpos = x, ypos = y });



                do
                {
                    y++;
                    points.Add(new points { number = points.Count + 1, xpos = x, ypos = y });
                } while (y != level);

                do
                {
                    x--;
                    points.Add(new points { number = points.Count + 1, xpos = x, ypos = y });
                } while (x != level * -1);

                do
                {
                    y--;
                    points.Add(new points { number = points.Count + 1, xpos = x, ypos = y });
                } while (y != level * -1);

                do
                {
                    x++;
                    points.Add(new points { number = points.Count + 1, xpos = x, ypos = y });
                } while (x != level);

                Console.WriteLine("Level: " + level.ToString() + " Index: " + points.Count);
            }

            Console.WriteLine("Point 289326 - x: " + points.Where(pos => pos.number == 289326).FirstOrDefault().xpos + " y: " + points.Where(pos => pos.number == 289326).FirstOrDefault().ypos);
            Console.ReadKey();
        }
    }

    class points
    {
        public int number { get; set; }
        public int xpos { get; set; }
        public int ypos { get; set; }
    }
}
