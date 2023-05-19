using System;
using System.Collections.Generic;
using System.Linq;

namespace IceCreams
{
    internal class Program     //2022-cs-187
    {
        static void Main(string[] args)
        {
            List<IceCream> ices = GetIceCreamsFromInput();
            Console.WriteLine(SweetestIceCream(ices));
        }

        public static List<IceCream> GetIceCreamsFromInput()
        {
            List<IceCream> iceCreams = new List<IceCream>();

            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; ++i)
            {
                string[] _params = Console.ReadLine().Split(' ');
                IceCream _iceCream = new IceCream(_params[0], int.Parse(_params[1]));
                iceCreams.Add(_iceCream);
            }

            return iceCreams;
        }

        public static int SweetestIceCream(List<IceCream> icecream)
        {
            string sweetness;
            // Write your Code Here
            for (int i=0;i< icecream.Count;i++)
            {
                //Console.WriteLine("icecreamlist"+ icecream);
                if(icecream[i]="plain")
                {
                    sweetness = 0 + icecream[1];
                }
                else if (icecream[i] = "vinilla")
                {
                    sweetness = 0 + icecream[1];
                }
                else if (icecream[i] = "ChocolateChip")
                {
                    sweetness = 0 + icecream[1];
                }
               else if (icecream[i] = "Strawberry")
                {
                    sweetness = 0 + icecream[1];
                }
                else if (icecream[i] = "Chocolate")
                {
                    sweetness = 0 + icecream[1];
                }

            }

        }
    }

    public class IceCream
    {
        public string flavour;
        public int sprinkles;

        public IceCream(string flavour,int sprinkles)
        {
            this.flavour = flavour;
            this.sprinkles = sprinkles;
        }
    }


}