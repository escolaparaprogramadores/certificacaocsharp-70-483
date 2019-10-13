using System.Linq;
using System.Threading.Tasks;

namespace Aula_03_Parando_um_loop_Paralello
{
    class Program
    {
        static void Main(string[] args)
        {         
            // for (int i = 0; i < 300; i++)
            // {
            //     if(i == 99)
            //     {
            //         System.Console.WriteLine($"O loop foi parado na posição {i}");
            //         break;
            //     }
            // }  

           ParallelLoopResult result =  Parallel.For(0, 300, (int i, ParallelLoopState state)=>
            {
                if(i == 67)
                {
                    System.Console.WriteLine($"O loop foi parado na posição {i}");
                    state.Break();
                }

            });  
            System.Console.WriteLine($"Qual foi o maior valor executado? {result.LowestBreakIteration}");
            System.Console.WriteLine($"O loop foi completado? {result.IsCompleted}");  //true


         var lista = Enumerable.Range(0, 300);
          ParallelLoopResult result1 = Parallel.ForEach(lista, (int i, ParallelLoopState state)=>
            {
                if(i == 65)
                {
                    System.Console.WriteLine($"O loop foi parado na posição {i}");
                    state.Break();
                }

            }); 
            System.Console.WriteLine($"Qual foi o maior valor executado? {result1.LowestBreakIteration}");
            System.Console.WriteLine($"O loop foi completado? {result1.IsCompleted}");  //true




        }
    }
}

