using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
    internal class Question7
    {
       
        static int[] parent;
        static int[] size;

        static int Find(int x)
        {
            if (parent[x] == x)
            {
                return x;
            }
            return parent[x] = Find(parent[x]);
        }

        static void Union(int x, int y)
        {
            int rootX = Find(x);
            int rootY = Find(y);
            if (rootX != rootY)
            {
                if (size[rootX] < size[rootY])
                {
                    int temp = rootX;
                    rootX = rootY;
                    rootY = temp;
                }
                parent[rootY] = rootX;
                size[rootX] += size[rootY];
            }
        }

        static void main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            parent = new int[n + 1];
            size = new int[n + 1];
            for (int i = 1; i <= n; i++)
            {
                parent[i] = i;
                size[i] = 1;
            }
            for (int i = 0; i < m; i++)
            {
                string[] line = Console.ReadLine().Split();
                int x = int.Parse(line[0]);
                int y = int.Parse(line[1]);
                Union(x, y);
            }
            int[] groupSize = new int[n + 1];
            for (int i = 1; i <= n; i++)
            {
                groupSize[Find(i)]++;
            }
            int cost = 0;
            int remaining = n;
            for (int i = 1; i <= n; i++)
            {
                if (groupSize[i] > 0)
                {
                    int k = (int)Math.Ceiling(Math.Sqrt(groupSize[i]));
                    cost += k;
                    remaining -= k * k;
                }
            }
            if (remaining > 0)
            {
                cost += (int)Math.Ceiling((double)remaining / Math.Sqrt(remaining));
            }
            Console.WriteLine(cost);
        }
    }

}
