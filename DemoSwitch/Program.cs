using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoSwitch
{
    class Program
    {
        static void Main(string[] args)
        {
            var season = Season.Winter;

            switch (season)
            {
                case Season.Winter:
                    Console.WriteLine("waktunya untuk nonton GOT");
                    break;

                case Season.Autum:
                    Console.WriteLine("tunggu musim depan");
                    break;

                default:
                    Console.WriteLine("masih jauh untuk nonton GOT");
                    break;
            }
        }
        }
    }
