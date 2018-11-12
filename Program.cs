using System;
using System.Text;
namespace csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "120";
            int i = 0;
            int.TryParse
            if ( int.TryParse( str , out i ) ) {
                Console.WriteLine( $"新的值：{i}" );
            } else {
                Console.WriteLine( $"{str}不是字符串" );
            }
        }
    }
}
