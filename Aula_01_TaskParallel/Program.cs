using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Aula_01_TaskParallel
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            Parallel.Invoke(()=> ImprimirZero(), ()=> ImprimirUm(), ()=> ImprimirPonto());

            stopwatch.Stop();
            System.Console.WriteLine( );
            System.Console.WriteLine(" A tarefa foi finalizada {0}", stopwatch.ElapsedMilliseconds / 1000.0);

           
            stopwatch.Reset();
            stopwatch.Start();

            ImprimirZero();
            ImprimirUm();
            ImprimirPonto();

            stopwatch.Stop();
            System.Console.WriteLine(" A tarefa foi finalizada {0}", stopwatch.ElapsedMilliseconds / 1000.0);
        }

        private static void ImprimirPonto()
        {
        //    for (int i = 0; i < 300; i++)           
        //    {
        //        ExecutarTarefaDemorada();
        //        System.Console.Write(".");
        //    } 

           Parallel.For(0,300, (i)=>
           {
               ExecutarTarefaDemorada();
               System.Console.Write(".");             
           }); 

        //    var lista = Enumerable.Range(0,300);
        //    Parallel.ForEach(lista, (ietm)=>
        //    {
        //        ExecutarTarefaDemorada();
        //        System.Console.Write(".");
        //    });         
        }

        private static void ImprimirUm()
        {
        //    for (int i = 0; i < 300; i++)
        //    {
        //        ExecutarTarefaDemorada();
        //        System.Console.Write("1");
        //    }

             Parallel.For(0,300, (i)=>
           {
               ExecutarTarefaDemorada();
               System.Console.Write("1");             
           }); 

        //    var lista = Enumerable.Range(0,300);
        //    Parallel.ForEach(lista, (ietm)=>
        //    {
        //        ExecutarTarefaDemorada();
        //        System.Console.Write("1");
        //    });      
        }

        private static void ImprimirZero()
        {
        //    for (int i = 0; i < 300; i++)
        //    {
        //        ExecutarTarefaDemorada();
        //        System.Console.Write("0");
        //    }

             Parallel.For(0,300, (i)=>
           {
               ExecutarTarefaDemorada();
               System.Console.Write("0");             
           }); 

        //    var lista = Enumerable.Range(0,300);
        //    Parallel.ForEach(lista, (ietm)=>
        //    {
        //        ExecutarTarefaDemorada();
        //        System.Console.Write("0");
        //    });      
        }
        private static void ExecutarTarefaDemorada()
        {
            Thread.Sleep(10);
        }
    }
}
