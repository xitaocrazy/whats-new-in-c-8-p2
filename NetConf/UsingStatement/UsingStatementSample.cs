using System;
using System.IO;

namespace NetConf.UsingStatement
{
    public class UsingStatementSample
    {
        private const string Original = ".\\UsingStatement\\file.txt";
        private const string Copy1Using = ".\\UsingStatement\\fileCopy1Using.txt";
        private const string Copy2Using = ".\\UsingStatement\\fileCopy2Using.txt";
        private const string Copy1UsingStatement = ".\\UsingStatement\\fileCopy1UsingStatement.txt";
        private const string Copy2UsingStatement = ".\\UsingStatement\\fileCopy2UsingStatement.txt";

        public static void Demo()
        {
            CopyWithoutUsingStatement();
            CopyWithUsingStatement();
        }
        
        private static void CopyWithoutUsingStatement() 
        {
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Using braces to set scope");
            using (var streamReader = new StreamReader(Original))
            {
                Console.WriteLine("Using tab to set scope");
                Console.WriteLine("First copy");
                using (var streamWriter = new StreamWriter(Copy1Using))
                    streamWriter.Write(streamReader.ReadToEnd()); 
                Console.WriteLine("Discarding buffer");
                streamReader.DiscardBufferedData();
                streamReader.BaseStream.Seek(0, SeekOrigin.Begin);
                Console.WriteLine("Second copy");
                using (var streamWriter = new StreamWriter(Copy2Using))
                    streamWriter.Write(streamReader.ReadToEnd()); 
            }
        } 

        private static void CopyWithUsingStatement()  
        {
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("You don't need braces or tab");
            using var streamReader = new StreamReader(Original);
            Console.WriteLine("First copy");
            using var streamWriter1 = new StreamWriter(Copy1UsingStatement);
            streamWriter1.Write(streamReader.ReadToEnd());
            Console.WriteLine("Discarding buffer");
            streamReader.DiscardBufferedData();
            streamReader.BaseStream.Seek(0, SeekOrigin.Begin);
            Console.WriteLine("Second copy");
            using var streamWriter2 = new StreamWriter(Copy2UsingStatement);
            streamWriter2.Write(streamReader.ReadToEnd());
        }
    }
}