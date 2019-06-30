using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSort
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] rendezendo = { 3, 5, 6, 9, 1, 4, 2, 7, 8, 10 };
            int[] rendezendo = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            //int[] rendezendo = new int[1000];
            //Random rnd = new Random();

            bool keszenVagyun;

            //for(int k = 0; k < 1000; k++)
            //{
            //    rendezendo[k] = rnd.Next(0, 999);
            //}

            Console.Write("Rendezés elött: ");
            for (int x = 0; x < rendezendo.Length; x++)
            {
                Console.Write($"{rendezendo[x]}, ");
            }
            Console.WriteLine("");

            #region --- régi módszer ---
            for (int j = 0; j < rendezendo.Length - 1; j++)
            {
                keszenVagyun = true;

                for (int i = 0; i < rendezendo.Length - (j + 1); i++)
                {
                    if (rendezendo[i] < rendezendo[i + 1])
                    {
                        int seged = rendezendo[i + 1];
                        rendezendo[i + 1] = rendezendo[i];
                        rendezendo[i] = seged;

                        keszenVagyun = false;
                    }
                }

                if (keszenVagyun)
                {
                    break;
                }
            }
            #endregion

            #region --- új módszer ---
            //List<int> rendezendoLista = new List<int>(rendezendo);
            //rendezendoLista.Sort();
            //rendezendo = rendezendoLista.ToArray();
            #endregion

            Console.Write("Rendezés után: ");
            for (int x = 0; x < rendezendo.Length; x++)
            {
                Console.Write($"{rendezendo[x]}, ");
            }

            Console.ReadLine();
        }
    }
}
