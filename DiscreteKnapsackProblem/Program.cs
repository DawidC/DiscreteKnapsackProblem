/*
    Dawid Czarneta
    Discrete Knapsack Problem implementation
    Approximation algorithm method
    16.07.2016
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscreteKnapsackProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            //backpack capacity = 15kg
            //item1 9kg 10$
            //item2 12kg 7$
            //item3 2kg 1$
            //item4 7kg 3$
            //item5 5kg 2$
            double backpackCapacity = 15.0;
            int N = 5;
            Item[] items = new Item[N];
            items[0] = new Item("item1", 9, 10);
            items[1] = new Item("item2", 12, 7);
            items[2] = new Item("item3", 2, 1);
            items[3] = new Item("item4", 7, 3);
            items[4] = new Item("item5", 5, 2);

            for(int i = 0; i < N; i++)
            {
                items[i].print();
            }
            Console.WriteLine();
            
            Array.Sort(items, delegate (Item x, Item y) { return x.pricePerKg.CompareTo(y.pricePerKg); });
            Array.Reverse(items);
            for (int i = 0; i < N; i++)
            {
                items[i].print();
            }

            int X = 0;
            int I = 0;
            Item[] backpack = new Item[N];
            double totalWeight = 0;
            double totalValue = 0;
            while (backpackCapacity >= 0&&I<N)
            {
                //if(I<N)
                if (items[I].weight <= backpackCapacity)
                {
                    backpack[X] = items[I];
                    backpackCapacity -= items[I].weight;
                    totalValue += items[I].value;
                    totalWeight += items[I].weight;
                    X++;
                    I++;
                } else
                {
                    I++;
                }
            }
            Console.WriteLine("Backpack (total " + totalWeight + "kg " + totalValue + "$): " );
            for(int i = 0; i < X; i++)
            {
                backpack[i].print();
            }

        }
    }
}
