using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscreteKnapsackProblem
{
    class Item
    {
        public string name;
        public double weight;
        public double value;
        public double pricePerKg;

        public Item(string nameIn, double weightIn, double valueIn)
        {
            this.name = nameIn;
            this.weight = weightIn;
            this.value = valueIn;
            pricePerKg = value / weight;            
        }

        public void print()
        {
            Console.WriteLine(this.name + " " + this.weight + " kg " + this.value + "$");
        }
        public void printAvg()
        {
            print();
            Console.WriteLine("Price Per Kg: " + pricePerKg);
        }
        
    }
}
