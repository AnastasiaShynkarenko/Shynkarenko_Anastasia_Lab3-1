
using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab3
{
    public static class Program
    {

        static void Main(string[] args)
        {
            Parking parking = new Parking(10);
            parking.enter(3);
            parking.enter(3);
            parking.enter(1);

            parking.print();
            parking.exit(3);
            parking.print();

        }
        class Parking
        {
            public int n;
            public List<bool> spaces;
            public Parking(int n)
            {
                this.n = n;
                this.spaces = new List<bool>(n);
                for (int index = 0; index < n; index++) this.spaces.Add(false);
            }
            public void exit(int number)
            {
                spaces[number - 1] = false;
            }
            public void enter(int space)
            {
                int index = space - 1;
                while (this.spaces[index] && index < this.n) index++;
                this.spaces[index] = true;
            }
            public void print()
            {
                for (int index = 0; index < this.n; index++)
                {
                    Console.Write(this.spaces[index].ToString() + " ");
                }
                Console.WriteLine();
            }
        }
    }
}