using System;
namespace BankSystem {
    class Logger {
        public static void Log( string msg ) {
            Console.WriteLine( $"{msg}" );
        }
        public static bool ReadByte(out byte o) {
           return byte.TryParse( Console.ReadLine(), out o );
        }
        public static bool ReadInt(out int o) {
           return int.TryParse( Console.ReadLine(), out o );
        }
        public static bool ReadDouble(out double o) {
           return double.TryParse( Console.ReadLine(), out o );
        }
        public static bool ReadString(out string o) {
           try {
               o = Console.ReadLine();
               return true;
           } catch ( Exception e ) {
               o = string.Empty;
               Log( e.ToString() );
               return false;
           }
        }
        public static bool ReadByte( string prompt, out byte o) {
            Log( prompt );
            return byte.TryParse( Console.ReadLine(), out o );
        }
        public static bool ReadInt( string prompt, out int o) {
            Log( prompt );
            return int.TryParse( Console.ReadLine(), out o );
        }
        public static bool ReadDouble( string prompt, out double o) {
            Log( prompt );
            return double.TryParse( Console.ReadLine(), out o );
        }
        public static bool ReadString( string prompt, out string o) {
            Log( prompt );
            try {
                o = Console.ReadLine();
                return true;
            } catch ( Exception e ) {
                o = string.Empty;
                return false;
            }
        }
    }
}