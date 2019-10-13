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

            Parallel.For(0, 300, (int i, ParallelLoopState state)=>
            {
                if(i == 99)
                {
                    System.Console.WriteLine($"O loop foi parado na posição {i}");
                    state.Stop();
                }

            });  

            var lista = Enumerable.Range(0, 300);
            Parallel.ForEach(lista, (int i, ParallelLoopState state)=>
            {
                if(i == 99)
                {
                    System.Console.WriteLine($"O loop foi parado na posição {i}");
                    state.Break();
                }

            }); 




        }
    }
}

