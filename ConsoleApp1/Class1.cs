using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_1
{
    public class HW1
    {
        public static long QueueTime(int[] customers, int n)
        {
            int[] cashiers = new int[n];
            int cashier = 0;
            int point = 0;

            for (int j = 0; j < n; j++)
            {
                cashiers[j] = customers[j];
            }
            point = n - 1;

            while (true)
            {
                for (int j = 0; j < n; j++)
                {
                    cashiers[j] -= 1;
                    cashier += 1;
                    if (cashiers[j] == 0)
                    {
                        if (point >= customers.Length - 1 && cashiers.Max() == 0)
                        {
                            while (cashier % n != 0)
                            {
                                cashier += 1;
                            }
                            Console.WriteLine("Clients = {0}", string.Join(", ", customers));
                            Console.WriteLine("Sellers = {0}", n);
                            Console.WriteLine("Result = {0}\n", (cashier / n));
                            return 0;
                        }
                        else if (point < customers.Length - 1)
                        {
                            point += 1;
                            cashiers[j] = customers[point];
                        }
                    }
                }
            }
        }

    }

}