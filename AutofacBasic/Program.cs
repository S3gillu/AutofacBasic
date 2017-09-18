using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac;

namespace AutofacBasic
{
    public interface IPrintService                 //IPrintService is Interface here
    {
        void PrintSomething(string text);
    }


    public class PrintService : IPrintService      //Implementation of Interface in Class
    {
        public void PrintSomething(string text)
        {
            Console.WriteLine(text);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {



            //Registering Interface with class that implemented

            var builder = new ContainerBuilder();
            builder.RegisterType<PrintService>().As<IPrintService>();

            //Resolving Inteface with Autofac

            var container = builder.Build();
            var printService = container.Resolve<IPrintService>();
            printService.PrintSomething("Hello !! This Is My First DepenDency Program Using IOC,DI and AutoFac");
            Console.ReadKey();


        }
    }
}

//First I have created an object of Container Builder and then I have register type with PrintService.
//Then I have build container builder to get container object.
//After that I have resolved print service with container and get the object of printer service.
//Then I have printed ( "Hello !! This Is My First DepenDency Program Using IOC,DI and AutoFac" ) with PrintSomeThing method.