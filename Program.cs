using System;
using System.Text;
using System.Collections.Generic;
namespace csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> fiber = new List<int>{ 1, 1 };
            for ( int i = 0; i < 18; i++) {
                fiber.Add( fiber[ fiber.Count - 1] + fiber[ fiber.Count - 2] );
            }
            fiber.ForEach( fib => {
                Console.WriteLine( $"斐波那契数字：{fib}" );
            });
        }
    }
}
