using System;
using NetConf.Helpers.Structs;

namespace NetConf.UnmanagedConstraint
{
    public class UnmanagedConstraint
    {
        public static void Demo() 
        {
            DisplaySize<Medidas<int>>();
            DisplaySize<Medidas<double>>();
        }

        private unsafe static void DisplaySize<T>() where T : unmanaged
        {
            Console.WriteLine($"{typeof(T)} não é gerenciada e seu tamanho é {sizeof(T)} bytes");
        }
    }
}