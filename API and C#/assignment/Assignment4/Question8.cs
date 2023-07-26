using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4
{
   

    internal class Question8
    {
        static void Main(string[] args)
        {
            string[] line1 = Console.ReadLine().Split();
            int n = int.Parse(line1[0]);
            int q = int.Parse(line1[1]); 

          
            List<int>[] armies = new List<int>[n];
            for (int i = 0; i < n; i++)
            {
                armies[i] = new List<int>();
            }

            int[] maxCombat = new int[n];
            for (int i = 0; i < n; i++)
            {
                maxCombat[i] = int.MinValue;
            }

         
            for (int i = 0; i < q; i++)
            {
                string[] line = Console.ReadLine().Split();
                int type = int.Parse(line[0]);

                if (type == 1)
                { 
                    int army = int.Parse(line[1]) - 1;
                    Console.WriteLine(maxCombat[army]);
                }
                else if (type == 2)
                { 
                    int army = int.Parse(line[1]) - 1;
                    int maxCombatIndex = armies[army].Count - 1;
                    for (int j = armies[army].Count - 2; j >= 0; j--)
                    {
                        if (armies[army][j] > armies[army][maxCombatIndex])
                        {
                            maxCombatIndex = j;
                        }
                    }
                    armies[army].RemoveAt(maxCombatIndex);
                    if (armies[army].Count > 0)
                    {
                        maxCombat[army] = armies[army][armies[army].Count - 1];
                    }
                    else
                    {
                        maxCombat[army] = int.MinValue;
                    }
                }
                else if (type == 3)
                { 
                    int army = int.Parse(line[1]) - 1;
                    int combat = int.Parse(line[2]);
                    armies[army].Add(combat);
                    if (combat > maxCombat[army])
                    {
                        maxCombat[army] = combat;
                    }
                }
                else
                {
                    int army1 = int.Parse(line[1]) - 1; 
                    int army2 = int.Parse(line[2]) - 1;
                    armies[army1].AddRange(armies[army2]);
                    armies[army2] = null; 
                    maxCombat[army1] = Math.Max(maxCombat[army1], maxCombat[army2]);
                    maxCombat[army2] = int.MinValue;
                }
            }
        }
    }

}
