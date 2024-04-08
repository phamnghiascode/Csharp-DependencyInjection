


using Microsoft.Extensions.DependencyInjection;

namespace Blabla
{
   public interface IEngine
   {
        public void Run();
   }
   public class ChinaEngine : IEngine
   {
        public void Run() => Console.WriteLine("This freaking china engine is running");
   }
   public class GermanEngine : IEngine
   {
        public void Run() => Console.WriteLine("This german engine is running");
   }
 

   public class Car
   {
        IEngine engine;
        public Car (IEngine engine) => this.engine = engine;

        public void Start()=> engine.Run();
   }
   
    public class Program
    {
        
        static void Main(string[] args)
            {
                // simple way using 
                Car car = new(new GermanEngine());
                car.Start();

                // using Microsoft.Extensions.DependencyInjection way with the same result
                // i dont understand why we should use this way


                // var service = new ServiceCollection();
                // service.AddSingleton<IEngine, GermanEngine>();
                // service.AddSingleton<Car, Car>();
                // using var provider = service.BuildServiceProvider();
                // var car = provider.GetService<Car>();
                // car?.Start();
            }         
    }
}
  
