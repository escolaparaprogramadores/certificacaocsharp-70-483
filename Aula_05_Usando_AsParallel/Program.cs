
using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Aula_05_Usando_AsParallel
{
    class Program
    {
        static void Main(string[] args)
        {
          var lista = Enumerable.Range(0, 10);

          var resultadoLista = 
          from n in lista.AsParallel()
          where BuscarNumeroPar(n)
          select n;

          Parallel.ForEach (resultadoLista, (i)=>
          {
            System.Console.WriteLine(i);

          });

        }

        private static bool BuscarNumeroPar(int n)
        {
            Thread.Sleep(1000);
            return n % 2 == 0;
        }
    }
}
















        // var lista = Enumerable.Range(0, 10);

        //     var resultadoLista =
        //     from n in lista
        //     where buscarNumeroPar(n)
        //     select n;

        //     var resultadoLista2 =
        //     from n in lista.AsParallel()
        //     where buscarNumeroPar(n)
        //     select n;

        //     var resultadoLista3 =
        //     from n in lista.AsParallel()
        //     .WithExecutionMode(ParallelExecutionMode.ForceParallelism)
        //     where buscarNumeroPar(n)
        //     select n;

        //     var resultadoLista4 =
        //     from n in lista.AsParallel()
        //     .WithExecutionMode(ParallelExecutionMode.ForceParallelism)
        //     .WithDegreeOfParallelism(2)
        //     where buscarNumeroPar(n)
        //     select n;

        //     var resultadoLista5 =
        //     from n in lista.AsParallel()
        //     .AsOrdered()
        //     .WithExecutionMode(ParallelExecutionMode.ForceParallelism)
        //     .WithDegreeOfParallelism(2)
        //     where buscarNumeroPar(n)
        //     select n;


        //     var resultadoLista6 =
        //     (from n in lista.AsParallel()
        //     .AsOrdered()
        //     .WithExecutionMode(ParallelExecutionMode.ForceParallelism)
        //     .WithDegreeOfParallelism(2)
        //     where buscarNumeroPar(n)
        //     orderby n descending
        //     select n).Take(3);


        //     var resultadoLista7 =
        //     from n in lista.AsParallel()
        //     where buscarNumeroPar(n)
        //     select n;

        //     Parallel.ForEach(resultadoLista, (i)=>
        //     {
        //       Console.WriteLine(i);
        //     });



        //     public static bool buscarNumeroPar(int i)
        // {
        //   Thread.Sleep(1000);
        //   return i % 2 == 0;
        // }