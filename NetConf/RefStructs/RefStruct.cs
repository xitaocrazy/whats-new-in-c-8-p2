using System;
namespace NetConf.RefStructs
{
    public class RefStruct
    {
        public static void Demo() 
        {
            using var refStruct = new NetConf.Helpers.Structs.RefStruct();
            Console.WriteLine(refStruct.GetValue());
        }
    }
}